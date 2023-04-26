using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mandala.Web.Controllers
{
    public class SubjectsController : Controller
    {
        // GET: SubjectsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubjectsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubjectsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectsController/Create
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

        // GET: SubjectsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectsController/Edit/5
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

        // GET: SubjectsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubjectsController/Delete/5
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
