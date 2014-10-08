﻿using WBY.Web.ViewModels;

namespace WBY.Services.Home
{
    public interface IHomeService
    {
        IndexViewModel GetModelForIndex();
        void GetModelForAbout();
        void GetModelForContact();
    }
}
