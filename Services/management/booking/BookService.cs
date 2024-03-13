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
        private readonly ILogger<BookService> _logger;
        private readonly IMapper _mapper;
        public BookService(ApplicationDbContext context, IMapper mapper, ILogger<BookService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
        public bool CheckExistBookDate(CreateBookRequestDto bookRequest)
        {
            var startDate = bookRequest.StartDate;
            var endDate = bookRequest.EndDate;
            var books = from item in bookRequest.UserBookRequest
                        join bookUser in _context.BookUser on item.AuditorId equals bookUser.AuditorId
                        join bookModel in _context.Book on bookUser.BookId equals bookModel.Id
                        where bookModel.StartDate.Date >= startDate.Date && bookModel.EndDate.Date <= endDate.Date
                        select bookModel;

            bool anyBookInDateRange = books.Any();
            return anyBookInDateRange;
            //foreach (var item in bookRequest.UserBookRequest)
            //{
            //    var books = _context.BookUser.Include(c => c.BookModel).Where(s => s.AuditorId == item.AuditorId).Select(s => new
            //    {
            //        s.Id,
            //        s.BookId,
            //        s.BookModel.StartDate,
            //        s.BookModel.EndDate,
            //    }).ToList();
            //    foreach (var book in books)
            //    {
            //        if (book.StartDate.Date >= startDate.Date && book.EndDate.Date <= endDate.Date)
            //        {
            //            If any book falls within the date range, return true
            //            return true;
            //        }
            //    }

            //    If no book falls within the date range, return false
            //}
            //return false;

        }

        public CreateBooKResponseDto Create(CreateBookRequestDto bookRequest)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    bookRequest.CreatedAt = DateTime.Now;
                    if (bookRequest != null)
                    {
                        if (_context.Book.Any(s => s.ProjectId.Equals(bookRequest.ProjectId)))
                        {
                            return new CreateBooKResponseDto
                            {
                                Result = false,
                                Message = ResponseErrorConstant.ExistBookDate,
                            };
                        }
                        if (CheckExistBookDate(bookRequest))
                        {
                            return new CreateBooKResponseDto
                            {
                                Result = false,
                                Message = ResponseErrorConstant.BookTimeError,
                            };
                        }
                        var book = new BookModel()
                        {
                            UserId = bookRequest.UserId,
                            ProjectId = bookRequest.ProjectId,
                            Title = bookRequest.Title,
                            SubTitle = bookRequest.SubTitle,
                            BgColor = bookRequest.BgColor,
                            Occupancy = bookRequest.Occupancy,
                            Description = bookRequest.Description,
                            CreatedAt = bookRequest.CreatedAt,
                            StartDate = bookRequest.StartDate,
                            EndDate = bookRequest.EndDate,
                            IsBooked = true

                        };
                        _context.Book.Add(book);
                        var bookId = book.Id;
                        var bookUserModels = bookRequest.UserBookRequest!
                            .Select(items => new BookUserModel
                            {
                                AuditorId = items.AuditorId,
                                BookId = bookId,
                                CreatedAt = DateTime.Now,

                            }).ToList();
                        _context.AddRange(bookUserModels);
                        transaction.Commit();
                        _context.SaveChanges();
                        return new CreateBooKResponseDto
                        {
                            Result = true,
                            Message = ResponseSuccessConstant.Create,
                            Data = new CreateBookRequestDto
                            {
                                UserId = bookRequest.UserId,
                                ProjectId = bookRequest.ProjectId,
                                Title = bookRequest.Title,
                                SubTitle = bookRequest.SubTitle,
                                BgColor = bookRequest.BgColor,
                                Occupancy = bookRequest.Occupancy,
                                Description = bookRequest.Description,
                                CreatedAt = bookRequest.CreatedAt,
                                StartDate = bookRequest.StartDate,
                                EndDate = bookRequest.EndDate,
                                UserBookRequest = bookUserModels.Select(s => new UserBookRequestDto
                                {
                                    AuditorId = s.AuditorId,
                                    BookId = s.BookId,
                                }).ToList(),
                            }
                        };
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    _logger.LogError("Book transaction service");
                    transaction.Rollback();
                    throw new Exception(ex.Message);

                }
            }
        }

        //public GetBookDetailDto GetById(Guid id)
        //{
        //    var data = _context.Book
        //        .Include(x => x.UserModel)
        //        .Include(x => x.ProjectModel)
        //        .Include(x => x.ProjectModel!.ClientModel)
        //        .Where(w => w.Id.Equals(id)).First();
        //    if (data != null)
        //    {
        //        var audit = _context.User.Where(s => s.Id.Equals(data.AuditBy)).Select(s => new Audit
        //        {
        //            Id = s.Id,
        //            Name = s.AccountName
        //        }).FirstOrDefault();
        //        var completerData = _context.User.Where(s => s.Id.Equals(data.CompletedBy)).Select(s => new CompletedBy
        //        {
        //            Id = s.Id,
        //            Name = s.AccountName
        //        }).FirstOrDefault()!;
        //        return new GetBookDetailDto
        //        {
        //            BookId = data.Id,
        //            CompletedAt = data.CompletedDate.ToString("dd/MMM/yyyy"),
        //            StartedAt = data.StartDate.ToString("dd/MMM/yyyy"),
        //            EndedAt = data.EndDate.ToString("dd/MMM/yyyy"),
        //            CompletedAccount = completerData,
        //            Project = new Project
        //            {
        //                Id = data.ProjectId,
        //                Name = data.ProjectModel!.ClientModel!.AccountName
        //            },
        //            UserAccount = new HandleBy
        //            {
        //                Id = data.UserId,
        //                Name = data.UserModel.AccountName
        //            },
        //            AuditAccount = audit
        //        };
        //    }
        //    throw new NotImplementedException();
        //}

        public UpdateBookDto Update(UpdateBook ob)
        {
            var data = _context.Book.Where(i => i.Id.Equals(ob.BookId)).First();
            if (data != null)
            {
                data.ProjectId = ob.ProjectId;
                data.StartDate = ob.StartedAt;
                data.EndDate = ob.EndedAt;
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
            .Where(s=>s.Id == id)
            .Select(s => new GetBookFormDto
            {
                Id = s.Id.ToString(),
                Client = s.ClientModel != null ? s.ClientModel.CompanyName : "",
                Standard = s.StandardModel != null ? s.StandardModel.Name : "",
                Status = s.Status != null ? s.Status : "",
                Auditors = _context.User.Select(s => new Auditors
                {
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

        //public IEnumerable<FindBookTimeLineDto> Find()
        //{
        //    var books = _context.User.Include(c => c.BookModels).Select(s => new FindBookTimeLineDto
        //    {
        //        Id = s.Id.ToString(),
        //        Label = new Label
        //        {
        //            Icon = s.Icon != null ? s.Icon : "",
        //            Title = s.AccountName != null ? s.AccountName : "",
        //            Subtitle = s.Title
        //        },
        //        Data = _context.Book.Where(m=>m.AuditBy == s.Id).Select(book => new BookingData
        //        {
        //            Id = book.Id.ToString(),
        //            Title = book.Title != null ? book.Title : "",
        //            Subtitle = book.SubTitle != null ? book.SubTitle : "",
        //            Description = book.Description != null ? book.Description: "",
        //            BgColor = book.BgColor != null ? book.BgColor : "",
        //            StartDate = book.StartDate,
        //            EndDate = book.EndDate,
        //            Occupancy = book.Occupancy
        //        }).ToList()

        //    }).ToList();
        //   return books;
        //}
    }
}