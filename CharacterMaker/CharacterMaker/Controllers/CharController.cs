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
                _businessLogic.PlayerUpdateRace(_dbContext, _player.Player, races.Races[(int)RaceID].GetRaceID());
                ViewBag.Radio = RaceID;
            }
            else
                ViewBag.Radio = -1;
                

            ViewBag.Rolls = _player.Rolls;

            this.SharedSession["PassModels"] = _player;

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
                _businessLogic.PlayerUpdateClass(_dbContext, _player.Player, classes.Classes[(int)ClassID].ClassID);
                ViewBag.Radio = ClassID;
            }
            else
                ViewBag.Radio = -1;

            this.SharedSession["PassModels"] = _player;

            return View(classes);
        }

        public ActionResult Abilities()
        {
            ViewBag.Rolls = _player.Rolls;
            ViewBag.StatModifiers = _businessLogic.UpdateModifiers(_dbContext, _player.Player.ClassID, _player.Player.RaceID);

            this.SharedSession["PassModels"] = _player;

            return View();
        }

        [HttpPost]
        public ActionResult Skills(ModifierModel abilities)
        {
            _player.Modifiers = abilities;

            SkillsViewModel skills = new SkillsViewModel(_dbContext);
            skills.AvalaiblePoints = _businessLogic.CheckAvailableSkillPoints(_dbContext, _player);

            this.SharedSession["PassModels"] = _player;

            return View(skills);
        }

        [HttpPost]
        public ActionResult Feats(SkillsViewModel skillz)
        {
            _player.Skills = new SkillLevelModel(skillz.Skills.Count());
            for(int i=0; i< skillz.Skills.Count(); i++)
                _player.Skills.SkillID[i] = skillz.Skills[i].SkillID;
            _player.Skills.SkillLevel = skillz.Skills.Select(x => x.Value).ToArray();
            
            FeatsViewModel feats = new FeatsViewModel(_dbContext);
            feats.AvalaiblePoints = _businessLogic.CheckAvailableFeatPoints(_dbContext, _player);

            this.SharedSession["PassModels"] = _player;

            return View(feats);
        }

        [HttpPost]
        public ActionResult Finalise(FeatsViewModel featz)
        {
            _player.Feats = new FeatLevelModel(featz.Feats.Count());
            for (int i = 0; i < featz.Feats.Count(); i++)
                _player.Skills.SkillID[i] = featz.Feats[i].FeatID;
            _player.Skills.SkillLevel = featz.Feats.Select(x => x.Value).ToArray();

            DetailsViewModel details = new DetailsViewModel();
            _businessLogic.UpdateDetails(_dbContext, details);

            this.SharedSession["PassModels"] = _player;

            return View(details);
        }

        [HttpPost]
        public ActionResult End(DetailsModel details)
        {

            return View();
        }
    }
}