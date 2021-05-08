using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using SalesWebMVC.Services;
=======
>>>>>>> SellersController

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
<<<<<<< HEAD
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
=======
        public IActionResult Index()
        {
            return View();
>>>>>>> SellersController
        }
    }
}
