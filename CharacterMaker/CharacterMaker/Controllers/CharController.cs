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
        private ApplicationDbContext _dbContext;
        private BusinessLogic _businessLogic;
        private RollModel _roll;
        public CharController()
        {
            _businessLogic = new BusinessLogic();
            _roll = new RollModel();
            _dbContext = new ApplicationDbContext();
        }

        // GET: Char
        public ActionResult Roll()
        {
            _businessLogic.RollTide(_roll.Rolls, _roll.numOfRolls, _roll.numOfStats);
            _businessLogic.SumTheStrong(_roll);
            _businessLogic.CheckReroll(_roll);

            return View(_roll);
        }

        public ActionResult Race(RollModel roll)
        {
            RacesModel races = new RacesModel(_dbContext);

            return View(races);
        }

        public ActionResult Class()
        {

            return View();
        }
    }
}