﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StarApp.Api.Controllers
{
    public class FallbackController : Controller
    {
        public ActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), 
                "wwwroot", "index.html"), "text/HTML");
        }
    }
}
