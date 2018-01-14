using CharacterMaker.BL;
using CharacterMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterMaker.Controllers
{
    public class CharController : Controller
    {
        private BusinessLogic _businessLogic;
        public CharController()
        {
            _businessLogic = new BusinessLogic();
        }

        // GET: Char
        public ActionResult Roll()
        {
            RollModel Roll = new RollModel();
            _businessLogic.RollTide(Roll.Rolls);
            _businessLogic.SumTheStrong(Roll);

            return View(Roll);
        }
    }
}