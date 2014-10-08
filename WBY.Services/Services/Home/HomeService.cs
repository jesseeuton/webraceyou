using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WBY.Web.ViewModels;

namespace WBY.Servicess.Home
{
    public class HomeService : IHomeService
    {
        public HomeService()
        {
        }

        public IndexViewModel GetModelForIndex()
        {
            return new IndexViewModel();
        }


        public void GetModelForAbout()
        {
            throw new NotImplementedException();
        }

        public void GetModelForContact()
        {
            throw new NotImplementedException();
        }
    }
}