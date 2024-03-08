using idflApp.Core.Dtos;

namespace idflApp.Services.management.booking.interfaces
{
    public interface IBookRepository
    {
        public CreateBooKDto Create(CreateBook ob);
        public UpdateBookDto Update(UpdateBook ob);
        public GetBookDetailDto GetById(Guid id);
        public GetBookFormDto GetBookForm(Guid id);
        //public IEnumerable<string> Find();
        //public bool Delete(Guid id);
    };
}