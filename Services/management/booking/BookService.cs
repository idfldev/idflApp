using idflApp.Core.Dtos;
using idflApp.Data;
namespace idflApp.Services.management.booking
{
    public class BookService
    {
        private readonly ApplicationDbContext _context;
        public BookService(ApplicationDbContext context)
        {
            _context = context;
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




    }
}