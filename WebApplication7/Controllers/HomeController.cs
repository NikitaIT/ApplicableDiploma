using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = ApplicationDbContext.Create();
        public ActionResult Index(string countires)
        {
            var _events = from _event in db.Events.Include(Event => Event.Compani)
                          select _event;
            if (!string.IsNullOrEmpty(countires))
            {
                _events = _events.Where(
                    _event => _event.Name.ToUpper().Contains(countires.ToUpper()));
            }
            ViewBag.Events = _events.ToList();
            return View();
        }
        [HttpGet]
        public ContentResult GetName()
        {
            string s = Request.Params["countires"].ToString();
            var _event = db.Events.ToList().Find(x => x.Name.Contains(s));
            if (_event == null) return Content(" <p>Ответ = не найдено</p>");
            return Content(" <p>Ответ = " + _event.Name + "</p>");
        }
        //public IEnumerable<Event> GetBooks()
        //{
        //    return db.Events;
        //}
    }
}