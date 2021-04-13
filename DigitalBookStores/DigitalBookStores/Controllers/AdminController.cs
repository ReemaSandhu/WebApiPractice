using BusinessLayer.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebAPIsEntities.Entities;
using WebAPIsEntities.Entities.BookDatabase;

namespace DigitalBookStores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private UserManager<ApplicationUser> _userManager;
        private readonly IBookComponent _bookComponent;
        public AdminController(UserManager<ApplicationUser> userManager, IBookComponent bookComponent)
        {
            _userManager = userManager;
            _bookComponent = bookComponent;
        }
        [HttpGet]
        [Authorize]
        //Get: api/Admin
        public async Task<Object> GetUser()
        {
            string userId = User.Claims.First(c=>c.Type == "UserId").Value;
            var user = await _userManager.FindByIdAsync(userId);
            return new
            {
                user.FullName,
                user.Email,
                user.UserName
            };
        }
       // [HttpGet]
       // [Authorize(Roles ="Owner")]
        [Route("AddBook")]
        [HttpPost]
        public IActionResult AddBook(BookData model)
        {
            _bookComponent.InsertNewBook(model);
            return Ok("Record inserted Successfully!");
                //try
            //{
            //    var file = Request.Form.Files[0];
            //    var folderName = Path.Combine("Resources", "Images");
            //    var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            //    if(file.Length>0)
            //    {
            //        var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            //        var fullPath = Path.Combine(pathToSave, fileName);
            //        var dbPath = Path.Combine(folderName, fileName);
            //        using(var stream=new FileStream(fullPath,FileMode.Create))
            //        {
            //            file.CopyTo(stream);
            //        }
            //        return Ok(new { dbPath });
            //    }
            //    else
            //    {
            //        return BadRequest();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    return StatusCode(500, $"Internal Server Error:{ex}");
            //}
        }

        [HttpGet]
       // [Authorize(Roles = "coOwner")]
        [Route("ShowList")]
        public IActionResult GetBooksList()
        {
            var result = _bookComponent.GetList();
            return Ok(result);
        }
        [HttpDelete]
        [Route("DeleteBook")]
        public IActionResult RemoveBook(long id)
        {
            _bookComponent.DeleteBook(id);
            return Ok("Recod Deleted Successfully!");
        }
        [HttpPut]
        [Route("UpdateBook")]
        public IActionResult UpdateBook(BookData book)
        {
            _bookComponent.UpdateBook(book);
            return Ok("Record Updated Successfully");
        }
        [HttpGet]
        [Route("GetBookById")]
        public IActionResult GetBookById(long id)
        {
            var result = _bookComponent.GetBookById(id);
            return Ok(result);
        }

    }
}
