using Microsoft.AspNetCore.Mvc;
using CV_bin.Models;

namespace CV_bin.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeModels _resumeModel;

        public ResumeController()
        {
            _resumeModel = new ResumeModels();
        }

        public IActionResult Resume(int page = 1)
        {
            int totalPages = 6;
            if (page < 1) page = 1;
            if (page > totalPages) page = totalPages;

            ViewBag.Page = page;
            return View(_resumeModel);
        }

        [HttpPost]
        public IActionResult CalculateTax(decimal income)
        {
            decimal tax = 0;
            if (income <= 300000)
            {
                tax = income * 0.07m;
            }
            else if (income <= 600000)
            {
                tax = 300000 * 0.07m + (income - 300000) * 0.11m;
            }
            else if (income <= 1100000)
            {
                tax = 300000 * 0.07m + 300000 * 0.11m + (income - 600000) * 0.15m;
            }
            else
            {
                tax = 300000 * 0.07m + 300000 * 0.11m + 500000 * 0.15m + (income - 1100000) * 0.19m;
            }

            ViewBag.Tax = tax;
            ViewBag.Income = income;
            ViewBag.Page = 6;
            return View("Resume", _resumeModel);
        }
    }
}
