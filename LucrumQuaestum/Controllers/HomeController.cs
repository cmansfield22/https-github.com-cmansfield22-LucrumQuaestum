using LucrumQuaestum.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.AlpacaKeyProcessor;

namespace LucrumQuaestum.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AlpacaApiKeys()
        {
            ViewBag.Message = "Alpaca Keys Entry";

            var userID = User.Identity.GetUserId();
            var alpacaKeys = LoadAlpacaKeys(userID);

            //Quick mapper
            AlpacaKeyModel alpacaKeyMap = new AlpacaKeyModel
            {
                LiveApiKey = alpacaKeys.LastOrDefault().LiveApiKey,
                LiveApiSecretKey = alpacaKeys.LastOrDefault().LiveApiSecretKey,
                PaperApiKey = alpacaKeys.LastOrDefault().PaperApiKey,
                PaperApiSecretKey = alpacaKeys.LastOrDefault().PaperApiSecretKey
            };

            return View(alpacaKeyMap);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlpacaApiKeys(AlpacaKeyModel model)
        {
            if (ModelState.IsValid)
            {
                var userID = User.Identity.GetUserId();

                int recordsCreated = UpdateAlpacaKeys(userID,
                    model.LiveApiKey,
                    model.LiveApiSecretKey,
                    model.PaperApiKey,
                    model.PaperApiSecretKey);

                return RedirectToAction("AlpacaApiKeys");
            }

            return View();
        }

    }
}