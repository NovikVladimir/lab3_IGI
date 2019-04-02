using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using lab3.Models;
using lab3.ViewModels;
using lab3.Services;

namespace lab3.Controllers
{
    public class HomeController : Controller
    {
        private IMemoryCache _cache;
        public HomeController(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            HomeViewModel homeViewModel = _cache.Get<HomeViewModel>("operation");
            return View(homeViewModel);
        }

        public IActionResult About2()
        {
            HomeViewModel homeViewModel = TakeLast.GetHomeViewModel();
            return View("~/Views/Home/About.cshtml", homeViewModel);
        }

        [ResponseCache(CacheProfileName = "Caching")]
        public IActionResult About3()
        {

            HomeViewModel homeViewModel = TakeLast.GetHomeViewModel();
            return View("~/Views/Home/About.cshtml", homeViewModel);
        }

        [HttpGet]
        public IActionResult Home()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        [HttpGet]
        public IActionResult Disease()
        {
            if (HttpContext.Session.Keys.Contains("name"))
            {
                ViewBag.DiseaseName = HttpContext.Session.GetString("name");
            }
            if (HttpContext.Session.Keys.Contains("symptoms"))
            {
                ViewBag.DiseaseSymptoms = HttpContext.Session.GetString("symptoms");
            }
            if (HttpContext.Session.Keys.Contains("duration"))
            {
                ViewBag.DiseaseDuration = HttpContext.Session.GetString("duration");
            }
            if (HttpContext.Session.Keys.Contains("consequences"))
            {
                ViewBag.DiseaseConsequences = HttpContext.Session.GetString("consequences");
            }
            return View("~/Views/Disease/Index.cshtml");
        }

        [HttpGet]
        [ResponseCache(CacheProfileName = "Caching")]
        public IActionResult Treatment()
        {
            return View("~/Views/Treatment/Index.cshtml");
        }

        [HttpGet]
        public IActionResult Patient()
        {
            return View("~/Views/Patient/Index.cshtml");
        }

        [HttpGet]
        public IActionResult Medicine()
        {
            string medicineName = "", medicineIndications = "", medicineContraindications = "", medicineManufacturer = "", medicinePackaging = "", medicineDosage = "";
            if (HttpContext.Request.Cookies.ContainsKey("medicineName"))
            {
                medicineName = HttpContext.Request.Cookies["medicineName"];
            }
            if (HttpContext.Request.Cookies.ContainsKey("medicineIndications"))
            {
                medicineIndications = HttpContext.Request.Cookies["medicineIndications"];
            }
            if (HttpContext.Request.Cookies.ContainsKey("medicineContraindications"))
            {
                medicineContraindications = HttpContext.Request.Cookies["medicineContraindications"];
            }
            if (HttpContext.Request.Cookies.ContainsKey("medicineManufacturer"))
            {
                medicineManufacturer = HttpContext.Request.Cookies["medicineManufacturer"];
            }
            if (HttpContext.Request.Cookies.ContainsKey("medicinePackaging"))
            {
                medicinePackaging = HttpContext.Request.Cookies["medicinePackaging"];
            }
            if (HttpContext.Request.Cookies.ContainsKey("medicineDosage"))
            {
                medicineDosage = HttpContext.Request.Cookies["medicineDosage"];
            }
            ViewBag.MedicineName = medicineName;
            ViewBag.MedicineIndications = medicineIndications;
            ViewBag.MedicineContraindications = medicineContraindications;
            ViewBag.MedicineManufacturer = medicineManufacturer;
            ViewBag.MedicinePackaging = medicinePackaging;
            ViewBag.MedicineDosage = medicineDosage;
            return View("~/Views/Medicine/Index.cshtml");
        }

        [HttpPost]
        public string Disease(string name, string symptoms,
            string duration, string consequences)
        {
            HttpContext.Session.SetString("name", name);
            HttpContext.Session.SetString("symptoms", symptoms);
            HttpContext.Session.SetString("duration", duration);
            HttpContext.Session.SetString("consequences", consequences);
            return "Болезнь \"" + name + "\"" + " c симптомами \"" + symptoms +
                 "\" и последствиями \"" + consequences + "\" добавлена в базу";
        }

        [HttpPost]
        public string Treatment(string nameDisease, string nameMedicine, string duration)
        {
            return "Лечение болезни \"" + nameDisease + "\" с помощью лекарства \"" + nameMedicine + "\" добавлено в базу. \nДлительность лечения: \"" + duration + "\"";
        }

        [HttpPost]
        public string Medicine(string medicineName, string medicineManufacturer, int medicineDosage)
        {
            HttpContext.Response.Cookies.Append("medicineName", medicineName);
            HttpContext.Response.Cookies.Append("medicineManufacturer", medicineManufacturer);
            HttpContext.Response.Cookies.Append("medicineManufacturer", medicineManufacturer);
            return "Лекарство \"" + medicineName + "\" от \"" + medicineManufacturer + "\" добавлено в базу.\nДозировка: \"" + medicineDosage + "\"";
        }

        [HttpPost]
        public string Patient(string name, string sex, string phone, string disease, DateTime date)
        {
            return "Пациент: " + name + ". Номер телефона: " + phone + ". Болезнь: " + disease + ". Дата поступления: " + date.Year + "." + date.Month + "." +
            +date.Day + ". Пол: " + sex;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
