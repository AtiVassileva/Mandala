using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace Mandala.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UsersController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: UsersController
        public ActionResult Index()
        {
            var userId = _httpContextAccessor.HttpContext!.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            Console.WriteLine($"Current user id: {userId}");
            return View();
        }

        //// GET: UsersController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: UsersController/Create
        public ActionResult Register() => View();

        //// POST: UsersController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Register(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UsersController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: UsersController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UsersController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: UsersController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
