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

        public IActionResult Index() 
        {
            var applicants = _context.Applicants.ToList();
            return View(applicants);
        }

        //GET
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

    }
}
