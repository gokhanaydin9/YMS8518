using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat2.Dto;
using Chat2.Interfaces;
using Chat2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chat2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _IUnitOfWork;

        public HomeController(IUnitOfWork iUnitOfWork)
        {
            _IUnitOfWork = iUnitOfWork;
        }
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult LoginUser([FromBody]SignUpDto signUpDto)
        {
            User user = _IUnitOfWork.GetDataContext().Users.SingleOrDefault(a =>
             a.Username == signUpDto.Username && a.Password == signUpDto.Password);

            if (user != null)
            {
                HttpContext.Session.SetInt32("userId", user.Id);
                return RedirectToAction("Chat", "Home", new { id = user.Id });

            }
            else
            {
                return Unauthorized();
            }

        }

        public IActionResult SaveUser([FromBody]SignUpDto signUpDto)
        {
            User user = new User();
            user.Username = signUpDto.Username;
            user.Password = signUpDto.Password;

            _IUnitOfWork.UserRepository.Insert(user);
            _IUnitOfWork.Complete();

            return new JsonResult("ok");
        }

        [HttpGet("home/chat/{id}")]
        public IActionResult Chat(int id)
        {

            if (id == 0)
            {
                return Unauthorized();
            }

            User user = _IUnitOfWork.GetDataContext().Users.SingleOrDefault(a => a.Id == id);

            return View(user);
        }
    }
}