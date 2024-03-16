using idflApp.auth;
using idflApp.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using idflApp.Core.Models;
using idflApp.Exceptions;
using idflApp.Services.Repositories;
using idflApp.Data;
using idflApp.Constants;
using idflApp.Services.management.booking;
using System.Linq.Expressions;

namespace Controllers.Management
{
    [ApiController]
    [Authorize]
    [Route("api/management/book")]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly ILogger<BookController> _logger;
        private readonly IRepository<ProjectModel, object> _repositoryProject;
        private readonly IRepository<BookModel, object> _repositoryBook;
        private readonly IRepository<BookUserModel, object> _repositoryUserBook;
        private readonly IRepository<UserModel, object> _repositoryUser;
        private readonly IRepository<UserInformationModel, object> _repositoryUserInfo;
        private readonly ApplicationDbContext _dbContext;
        public BookController(
            ILogger<BookController> logger, IRepository<ProjectModel, object> repositoryProject
            , IRepository<BookUserModel, object> repositoryUserBook, IRepository<BookModel, object> repositoryBook,
            IRepository<UserModel, object> repositoryUser, ApplicationDbContext dbContext, BookService bookService, IRepository<UserInformationModel, object> repositoryUserInfo)
        {
            _logger = logger;
            _repositoryProject = repositoryProject;
            _repositoryUserBook = repositoryUserBook;
            _repositoryBook = repositoryBook;
            _repositoryUser = repositoryUser;
            _dbContext = dbContext;
            _bookService = bookService;
            _repositoryUserInfo = repositoryUserInfo;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookRequestDto bookRequest)
        {

            if (bookRequest != null)
            {
                using (var transactions = _dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        //Begin transaction
                        if (_bookService.CheckExistBookDate(bookRequest))
                        {
                            return BadRequest(
                                new CreateBooKResponseDto
                                {
                                    Result = false,
                                    Message = ResponseErrorConstant.ExistBookDate,
                                });
                        }
                        //var res = await _repositoryBook.ExistsAsync(bookRequest.ProjectId, "ProjectId");
                        //if (res)
                        //{
                        //    return BadRequest(new CreateBooKResponseDto
                        //    {
                        //        Result = false,
                        //        Message = ResponseErrorConstant.ExistBookDate,
                        //    });
                        //}
                        var user = HttpContext.Items["User"] as UserModel;
                        bookRequest.UserId = user!.Id;
                        bookRequest.CreatedAt = DateTime.Now;
                        var book = new BookModel()
                        {
                            FactoryId = bookRequest.FactoryId,
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
                        var requestUser = bookRequest.UserBookRequest!.Select(s => new BookUserModel
                        {
                            AuditorId = s.AuditorId,
                            BookId = bookId,
                            CreatedAt = DateTime.Now
                        }).ToList();
                        var userBook = await _repositoryUserBook.CreateRangeAsync(requestUser);
                        //Commit transation
                        await transactions.CommitAsync();
                        return Ok(response);
                    }
                    catch (CreateException ex)
                    {
                        //Roll back transaction
                        await transactions.RollbackAsync();
                        return BadRequest(new CreateException(ResponseErrorConstant.CreateExceptionTransaction));
                    }
                }
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFormCreate(Guid id)
        {
            var Users = await _repositoryUser.GetAllAsync(s => new Auditors
            {
                Id = s.Id.ToString(),
                Name = s.DisplayName
            });
            Expression<Func<ProjectModel, bool>> filter = p => p.Id == id;
            var projects = await _repositoryProject.GetDetailFilteredAsync(s => new GetBookFormDto
            {
                Id = s.Id.ToString(),
                Client = s.ClientModel.DisplayName,
                Standard = s.StandardModel.Displayname,
                Status = s.Status,
            }, filter, p => p.StandardModel!, p => p.ClientModel!);
            if (projects == null && Users == null)
            {
                _logger.LogError("Get Form Create");
                return NotFound(projects);
            }
            return Ok(new { projects, Users });
        }
        //TODO: Update
        public async Task<IActionResult> Update()
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var response = await _repositoryBook.DeleteAsync(id);
            return Ok(response);
        }
        public async Task<IActionResult> GetDetail(Guid id)
        {
             var user = HttpContext.Items["User"] as UserModel;
            Expression<Func<BookModel, bool>> filter = p => p.Id == id;
            var result = _repositoryBook.GetDetailFilteredAsync(s=>  new UpdateBookRequestDto{
                Id = id.ToString(),
                UserId = user.Id.ToString(),
                FactoryId = s.FactoryId.ToString(),
                Title = s.Title,
                UserBookRequest = s.BookUserModels.Select(m=> new UpdateUserBookRequestDto{
                    AuditorId = m.AuditorId.ToString(),
                    BookId = m.BookId.ToString()
                }).ToList()
            },filter, c=> c.FactoryModel);
            return Ok();
        }
        //TODO: Time line
        [HttpGet]
        public async Task<IActionResult> GetAllTimeLine()
        {
            try
            {
                var users = await _repositoryUser.GetAllAsync(s => new FindBookTimeLineDto
                {
                    Id = s.Id.ToString(),
                    Label = new Label
                    {
                        Icon = s.UserInformationModels.Select(s=>s.Icon).First() ?? "",
                        Title = s.DisplayName ?? "",
                        Subtitle = s.UserInformationModels.Select(s=>s.Title).First() ?? ""
                    },
                    Data = s.BookUserModels!.Select(book => new BookingData
                    {
                        Id = book.Id.ToString(),
                        Title = book.BookModel!.Title ?? "",
                        Subtitle = book.BookModel.SubTitle ?? "",
                        Description = book.BookModel.Description ?? "",
                        BgColor = book.BookModel.BgColor ?? "",
                        StartDate = book.BookModel.StartDate,
                        EndDate = book.BookModel.EndDate,
                        Occupancy = book.BookModel.Occupancy ?? 0
                    }).ToList(),
                }, x => x.BookUserModels!, c=>c.UserInformationModels!);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}