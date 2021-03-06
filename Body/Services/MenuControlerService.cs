﻿using FarmConsole.Body.Controlers.MenuControlers;
using FarmConsole.Body.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmConsole.Body.Services
{
    public class MenuControlerService
    {
        protected static SaveModel save;

        public static string POPUPTEXT = "";
        public static int POPUPSTAGE = -1;
        public static int POPUPID = 0;
        public static DateTime Now = DateTime.Now;
        public static string openScreen = "Load";
        public static string lastScreen = "Load";

        public static void PopUp(int id, string text)
        {
            string popupText = text;
            if (id > 0) popupText = XF.GetString(300 + id);
            if (POPUPSTAGE >= 0) POPUPSTAGE = AnimationControler.PopUp(MenuViewService.TextBoxView(popupText), POPUPSTAGE);
            if (POPUPSTAGE < 0) POPUPID = 0;
        }

        static MenuControlerService()
        {
            save = new SaveModel();
        }
    }
}
