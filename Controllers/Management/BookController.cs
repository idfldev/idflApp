using idflApp.auth;
using idflApp.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using idflApp.Services.management.booking.interfaces;
using idflApp.Core.Models;
using idflApp.Exceptions;
using static idflApp.Core.Dtos.CreateBookRequestDto;
using idflApp.Services.Repositories;

namespace Controllers.Management
{
    [ApiController]
    [Authorize]
    [Route("api/management/book")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<BookController> _logger;
        private readonly IRepository<ProjectModel> _repositoryProject;
        private readonly IRepository<BookModel> _repositoryBook;
        private readonly IRepository<BookUserModel> _repositoryUserBook;
        private readonly IRepository<UserModel> _repositoryUser;
        public BookController(IBookRepository bookRepository,
            ILogger<BookController> logger, IRepository<ProjectModel> repositoryProject
            , IRepository<BookUserModel> repositoryUserBook, IRepository<BookModel> repositoryBook,
            IRepository<UserModel> repositoryUser)
        {
            _bookRepository = bookRepository;
            _logger = logger;
            _repositoryProject = repositoryProject;
            _repositoryUserBook = repositoryUserBook;
            _repositoryBook = repositoryBook;
            _repositoryUser = repositoryUser;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookRequestDto bookRequest)
        {
            try
            {
                var user = HttpContext.Items["User"] as UserModel;
                bookRequest.UserId = user!.Id;
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
                var response = await _repositoryBook.CreateAsync(book);
                var bookId = response.Id;
                var requestUser = bookRequest.UserBookRequest!.Select(s=> new BookUserModel{
                    AuditorId = s.AuditorId,
                    BookId = bookId
                }).ToList();
                var userBook = await _repositoryUserBook.CreateRangeAsync(requestUser);
                return Ok(response);

            }
            catch (BookCreateException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFormCreate(Guid id)
        {
            var responseUser = await _repositoryUser.GetAllAsync();

            var response = await _repositoryProject.GetAsync(id, x => x.ClientModel!, x => x.StandardModel!);
            if (response == null)
            {
                _logger.LogError("Get Form Create");
                return NotFound(response);
            }
            var result = new GetBookFormDto
            {
                Id = response.Id.ToString(),
                Client = response.ClientModel != null ? response.ClientModel.AccountName : "",
                Standard = response.StandardModel != null ? response.StandardModel.Name : "",
                Status = response.Status,
                Auditors = responseUser.Select(s => new Auditors
                {
                    Id = s.Id.ToString(),
                    Name = s.AccountName
                }).ToList(),

            };
            return Ok(result);
        }
        //TODO: Update
        //TODO: Remove
        //TODO: Get Detail

    }
}