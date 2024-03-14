using idflApp.auth;
using idflApp.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using idflApp.Core.Models;
using idflApp.Exceptions;
using idflApp.Services.Repositories;
using idflApp.Data;
using idflApp.Constants;
using idflApp.Services.management.booking;
using idflApp.Core.Models.Interfaces;

namespace Controllers.Management
{
    [ApiController]
    [Authorize]
    [Route("api/management/book")]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly ILogger<BookController> _logger;
        private readonly IRepository<ProjectModel> _repositoryProject;
        private readonly IRepository<BookModel> _repositoryBook;
        private readonly IRepository<BookUserModel> _repositoryUserBook;
        private readonly IRepository<UserModel> _repositoryUser;
        private readonly ApplicationDbContext _dbContext;
        public BookController(
            ILogger<BookController> logger, IRepository<ProjectModel> repositoryProject
            , IRepository<BookUserModel> repositoryUserBook, IRepository<BookModel> repositoryBook,
            IRepository<UserModel> repositoryUser, ApplicationDbContext dbContext, BookService bookService)
        {
            _logger = logger;
            _repositoryProject = repositoryProject;
            _repositoryUserBook = repositoryUserBook;
            _repositoryBook = repositoryBook;
            _repositoryUser = repositoryUser;
            _dbContext = dbContext;
            _bookService = bookService;
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
                        var res = await _repositoryBook.GetAnyAsync(bookRequest.ProjectId, "ProjectId");
                        if (res)
                        {
                            return BadRequest(new CreateBooKResponseDto
                            {
                                Result = false,
                                Message = ResponseErrorConstant.ExistBookDate,
                            });
                        }
                        var user = HttpContext.Items["User"] as UserModel;
                        bookRequest.UserId = user!.Id;
                        bookRequest.CreatedAt = DateTime.Now;
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
        //TODO: Time line
        [HttpGet]
        public async Task<IActionResult> GetAllTimeLine()
        {
            var users = await _repositoryUser.GetAllAsync(x=>x.BookUserModels, x=>x.BookModels);
            var bookUser = await _repositoryUserBook.GetAllAsync();
            var userBooks = await _repositoryUserBook.GetAllParamAsync("AuditorId", users.Select(s => s.Id), x => x.BookModel!, x=>x.UserModel);
            //var result = userBooks.Select(book => new BookingData
            //{
            //    Id = book.Id.ToString(),
            //    Title = book.BookModel!.Title != null ? book.BookModel.Title : "",
            //    Subtitle = book.BookModel.SubTitle != null ? book.BookModel.SubTitle : "",
            //    Description = book.BookModel.Description != null ? book.BookModel.Description : "",
            //    BgColor = book.BookModel.BgColor != null ? book.BookModel.BgColor : "",
            //    StartDate = book.BookModel.StartDate,
            //    EndDate = book.BookModel.EndDate,
            //    Occupancy = book.BookModel.Occupancy
            //}).ToList();
            var lables = users.Select(s => new FindBookTimeLineDto
            {
                Id = s.Id.ToString(),
                Label = new Label
                {
                    Icon = s.Icon != null ? s.Icon : "",
                    Title = s.AccountName != null ? s.AccountName : "",
                    Subtitle = s.Title
                },
                Data = bookUser.Where(b=>b.AuditorId == s.Id).Select(book => new BookingData
                {
                    Id = book.Id.ToString(),
                    Title = book.BookModel!.Title != null ? book.BookModel.Title : "",
                    Subtitle = book.BookModel.SubTitle != null ? book.BookModel.SubTitle : "",
                    Description = book.BookModel.Description != null ? book.BookModel.Description : "",
                    BgColor = book.BookModel.BgColor != null ? book.BookModel.BgColor : "",
                    StartDate = book.BookModel.StartDate,
                    EndDate = book.BookModel.EndDate,
                    Occupancy = book.BookModel.Occupancy
                }).ToList()
            }).ToList();
            

            return Ok(lables);
        }
    }
}