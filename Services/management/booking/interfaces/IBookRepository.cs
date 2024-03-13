using idflApp.Core.Dtos;
using static idflApp.Core.Dtos.CreateBookRequestDto;

namespace idflApp.Services.management.booking.interfaces
{
    public interface IBookRepository
    {
        public CreateBooKResponseDto Create(CreateBookRequestDto bookRequest);
        //public UpdateBookDto Update(UpdateBook ob);
        //public GetBookDetailDto GetById(Guid id);
        public GetBookFormDto GetBookForm(Guid id);
        //public  IEnumerable<FindBookTimeLineDto> Find();
        //public bool Delete(Guid id);
    };
}