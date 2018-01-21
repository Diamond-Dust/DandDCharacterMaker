using CharacterMaker.BL;
using CharacterMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterMaker.Controllers
{
    public class CharController : ControllerSharedSession
    {
        private ApplicationDbContext _dbContext;
        private BusinessLogic _businessLogic;
        private PlayerViewModel _player;
        public CharController()
        {
            _businessLogic = new BusinessLogic();
            _dbContext = new ApplicationDbContext();
            if ((this.SharedSession != null) && (this.SharedSession["PassModels"] != null))
                _player = (PlayerViewModel)this.SharedSession["PassModels"];
            else
                _player = new PlayerViewModel();
        }

        // GET: Char
        public ActionResult Roll()
        {
            _businessLogic.RollTide(_player.Rolls.Rolls, _player.Rolls.numOfRolls, _player.Rolls.numOfStats);
            _businessLogic.SumTheStrong(_player.Rolls);
            _businessLogic.CheckReroll(_player.Rolls);
            this.SharedSession["PassModels"] = _player;

            return View(_player.Rolls);
        }

        public ActionResult Race(int? RaceID)
        {
            RacesViewModel races = new RacesViewModel(_dbContext);
            if (RaceID != null)
            {
                _businessLogic.UpdateModifiers(_dbContext, races, (int)RaceID);
                _businessLogic.PlayerUpdateRace(_player.Player, (int)RaceID);
                ViewBag.Radio = RaceID;
            }
            else
                ViewBag.Radio = -1;
                

            ViewBag.Rolls = _player.Rolls;

            return View(races);
        }

        [HttpGet]
        public ActionResult Class(int? ClassID)
        {
            ClassesViewModel classes = new ClassesViewModel(_dbContext);
            _businessLogic.CheckPreferredClass(_dbContext, classes, _player.Player.RaceID);

            if (ClassID != null)
            {
                _businessLogic?.UpdateModifiers(_dbContext, classes, (int)ClassID);
                _businessLogic.PlayerUpdateClass(_player.Player, (int)ClassID);
                ViewBag.Radio = ClassID;
            }
            else
                ViewBag.Radio = -1;


            return View(classes);
        }

        public ActionResult Abilities()
        {
            ViewBag.Rolls = _player.Rolls;

            return View();
        }
    }
}