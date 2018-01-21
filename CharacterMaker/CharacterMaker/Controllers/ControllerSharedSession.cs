using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterMaker.Controllers
{
    public class ControllerSharedSession : Controller
    {
        public System.Web.SessionState.HttpSessionState SharedSession
        {
            get
            {
                return System.Web.HttpContext.Current.Session;
            }
        }
    }
}