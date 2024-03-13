using idflApp.auth;
using idflApp.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using idflApp.Services.management.booking.interfaces;
using idflApp.Core.Models;
using idflApp.Exceptions;
using static idflApp.Core.Dtos.CreateBookRequestDto;

namespace Controllers.Management
{
    [ApiController]
    [Authorize]
    [Route("api/management/book")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<BookController> _logger;
        public BookController(IBookRepository bookRepository, ILogger<BookController> logger)
        {
            _bookRepository = bookRepository;
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateBookRequestDto bookRequest)
        {
            try
            {
                var user = HttpContext.Items["User"] as UserModel;
                bookRequest.UserId = user!.Id;
                var result = _bookRepository.Create(bookRequest);
                if (result.Result == true)
                {

                    return Ok(result);
                }
                else
                {
                    _logger.LogError("BookController create", bookRequest);
                    return BadRequest(result);
                }

            }
            catch (BookCreateException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // [TODO]
        //[HttpPut]
        //public IActionResult Update(UpdateBook ob)
        //{
        //    try
        //    {
        //        var response = _bookRepository.Update(ob);
        //        if (response.Result == true)
        //        {
        //            return Ok(response);
        //        }
        //        return BadRequest(response);
        //    }
        //    catch (System.Exception ex)
        //    {
                
        //        _logger.LogError("Book controller update", ob);
        //       return BadRequest(ex.Message);
        //    }
        //}
        [HttpGet("{id}")]
        public IActionResult GetBookForm(Guid id)
        {
           var response = _bookRepository.GetBookForm(id);
           return Ok(response);
        }
        //[HttpGet]
        //public IActionResult FindTimeline()
        //{
        //    var response = _bookRepository.Find();
        //    return Ok(response);
        //}
    }
}