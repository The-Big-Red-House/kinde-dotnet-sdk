﻿using Kinde.Authorization.Enums;
using Kinde.Authorization.Models.Configuration;
using Kinde.DemoMVC.Authorization;
using Kinde.DemoMVC.Models;
using Kinde.WebExtensions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kinde.DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var client = KindeClientFactory.Instance.Get(HttpContext.Session.Id);
            return View();
        }
        [KindeAuthorize("Any")]
        public IActionResult Callback()
        {
            return RedirectToAction("Index");
        }
  
        [KindeAuthorize("PKCE")]
        public IActionResult SignInPKCE()
        {
            return RedirectToAction("Index");
        }
        [KindeAuthorize("ClientCredentials")]
        public IActionResult SigninClientCredentials()
        {
            return RedirectToAction("Index");
        }
        [KindeAuthorize("AuthorizationCode")]
        public IActionResult SignInCode()
        {
            return RedirectToAction("Index");
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