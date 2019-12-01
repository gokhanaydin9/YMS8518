using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuestBook.Data.Dto;

namespace GuestBook.Controllers
{
    public class GuestBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendAction([FromBody]GuestBookSendActionDto guestBookSendActionDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Biz de yapardık zamanında");
            }

            return new JsonResult("ok");
        }
    }
}