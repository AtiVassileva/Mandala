using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mandala.Web.Controllers
{
    public class ClassroomsController : Controller
    {
        // GET: ClassroomsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClassroomsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClassroomsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassroomsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassroomsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClassroomsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassroomsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClassroomsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
