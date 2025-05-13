using Microsoft.AspNetCore.Mvc;
using HumanResourcesForm.Data;
using HumanResourcesForm.Models;

namespace HumanResourcesForm.Controllers
{
    public class ApplicantsController : Controller
    {
        private readonly HRContext _context;
        public ApplicantsController(HRContext context)
        {
            _context = context;
        }

        //GET: Index
        public IActionResult Index()
        {
            var applicants = _context.Applicants.ToList();
            return View(applicants);
        }

        //GET: Create
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                _context.Applicants.Add(applicant);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicant);
        }

        //GET: Edit
        public IActionResult Edit(int id)
        {
            var applicant = _context.Applicants.Find(id);
            if (applicant == null)
            {
                return NotFound();
            }
            return View(applicant);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Applicant applicant)
        {
            if (id != applicant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(applicant);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(applicant);
        }

        //GET: Delete
        public IActionResult Delete(int id)
        {
            var applicant = _context.Applicants.Find(id);
            if (applicant == null)
            {
                return NotFound();
            }
            return View(applicant);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var applicant = _context.Applicants.Find(id);
            if (applicant == null)
            {
                return NotFound();
            }
            _context.Applicants.Remove(applicant);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        //GET: Details
        public IActionResult Details(int id)
        {
            var applicant = _context.Applicants.Find(id);
            if (applicant == null)
            {
                return NotFound();
            }
            return View(applicant);
        }
    }
}
