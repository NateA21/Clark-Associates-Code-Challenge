using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClarkCodingChallenge.Models;
using ClarkCodingChallenge.BusinessLogic;
using System.Collections.Generic;

namespace ClarkCodingChallenge.Controllers
{
    public class ContactsController : Controller {

        private ContactsService ContactService;

        public ContactsController(ContactsService contactService){
            ContactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Create(UserInfoModel user) {
            
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            ViewBag.CurrentUser = user;
            ContactService.Add(user);

            return View("Index");
        }

        [HttpGet]
        public ActionResult<List<UserInfoModel>> Contacts() {

            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var Contacts = ContactService.Get();

            return View(Contacts);
        }







    }
}
