using AutoMapper;
using idflApp.Constants;
using idflApp.Core.Dtos;
using idflApp.Core.Models;
using idflApp.Data;
using idflApp.Exceptions;
using idflApp.Services.management.booking.interfaces;
using Microsoft.EntityFrameworkCore;

namespace idflApp.Services.management.booking
{
    public class BookService : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public BookService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool CheckExistBookDate(DateTime startedDate, DateTime endedDate, Guid auditId)
        {
            var startedAt = startedDate.Date;
            var endedAt = endedDate.Date;
            // Check if any book with the specified auditId exists within the date range
            var books = _context.Book.Where(s => s.AuditBy == auditId).ToList();
            foreach (var book in books)
            {
                if (book.StartedAt.Date >= startedAt && book.EndedAt.Date <= endedDate.Date)
                {
                    // If any book falls within the date range, return true
                    return true;
                }
            }

            // If no book falls within the date range, return false
            return false;
        }

        public CreateBooKDto Create(CreateBook ob)
        {
            try
            {
                // if project booked, can not book more
                if (_context.Book.Any(s => s.ProjectId.Equals(ob.ProjectId)))
                {
                    return new CreateBooKDto
                    {
                        Result = false,
                        Message = ResponseErrorConstant.ExistBookDate,
                        Data = ob
                    };
                }
                // check start data and end date exist
                if (CheckExistBookDate(ob.StartedAt, ob.EndedAt, ob.AuditBy))
                {
                    return new CreateBooKDto
                    {
                        Result = false,
                        Message = ResponseErrorConstant.BookTimeError,
                        Data = ob
                    };
                }
                ob.CreatedAt = DateTime.Now;
                if (ob.UserId != Guid.Empty && ob.ProjectId != Guid.Empty)
                {
                    
                    BookModel bookModel = _mapper.Map<BookModel>(ob);
                    bookModel.IsBooked = true;
                    _context.Add(bookModel);
                    _context.SaveChanges();
                    return new CreateBooKDto
                    {
                        Result = true,
                        Message = ResponseSuccessConstant.Create,
                        Data = ob
                    };
                }
                return new CreateBooKDto
                {
                    Result = false,
                    Message = ResponseErrorConstant.Create,
                    Data = ob
                };


            }
            catch (Exception)
            {
                throw new BookCreateException(ResponseErrorConstant.CreateException);
            }
        }

        public GetBookDetailDto GetById(Guid id)
        {
            var data = _context.Book
                .Include(x => x.UserModel)
                .Include(x => x.ProjectModel)
                .Include(x => x.ProjectModel!.ClientModel)
                .Where(w => w.Id.Equals(id)).First();
            if (data != null)
            {
                var audit = _context.User.Where(s => s.Id.Equals(data.AuditBy)).Select(s => new Audit
                {
                    Id = s.Id,
                    Name = s.AccountName
                }).FirstOrDefault();
                var completerData = _context.User.Where(s => s.Id.Equals(data.CompletedBy)).Select(s => new CompletedBy
                {
                    Id = s.Id,
                    Name = s.AccountName
                }).FirstOrDefault()!;
                return new GetBookDetailDto
                {
                    BookId = data.Id,
                    CompletedAt = data.CompletedAt.ToString("dd/MMM/yyyy"),
                    StartedAt = data.StartedAt.ToString("dd/MMM/yyyy"),
                    EndedAt = data.EndedAt.ToString("dd/MMM/yyyy"),
                    CompletedAccount = completerData,
                    Project = new Project
                    {
                        Id = data.ProjectId,
                        Name = data.ProjectModel!.ClientModel!.AccountName
                    },
                    UserAccount = new HandleBy
                    {
                        Id = data.UserId,
                        Name = data.UserModel.AccountName
                    },
                    AuditAccount = audit
                };
            }
            throw new NotImplementedException();
        }

        public UpdateBookDto Update(UpdateBook ob)
        {
            var data = _context.Book.Where(i => i.Id.Equals(ob.BookId)).First();
            if (data != null)
            {
                data.ProjectId = ob.ProjectId;
                data.AuditBy = ob.AuditById;
                data.StartedAt = ob.StartedAt;
                data.EndedAt = ob.EndedAt;
                data.Purpose = ob.Purpose;
                data.Description = ob.Description;
                data.UpdatedAt = DateTime.Now;
                _context.Update(data);
                _context.SaveChanges();
                return new UpdateBookDto
                {
                    Result = true,
                    Message = ResponseSuccessConstant.Update,
                    Data = ob
                };
            };
            return new UpdateBookDto
            {
                Result = false,
                Message = ResponseErrorConstant.Update,
                Data = ob
            };
        }
        public GetBookFormDto GetBookForm(Guid id)
        {
            var data = _context.Project
            .Include(s => s.ClientModel)
            .Include(s => s.StandardModel)
            .Select(s => new GetBookFormDto
            {
                Id = s.Id.ToString(),
                Client = s.ClientModel != null ? s.ClientModel.CompanyName : "",
                Standard = s.StandardModel != null ? s.StandardModel.Name : "",
                Status = s.Status != null ? s.Status : "",
                Auditors = _context.User.Select(s=> new Auditors{
                    Id = s.Id.ToString(),
                    Name = s.AccountName
                }).ToList()

            }).FirstOrDefault();
            if (data != null)
            {
                return data;
            }
            return null;
        }
    }
}