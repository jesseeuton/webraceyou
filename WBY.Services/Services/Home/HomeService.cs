using System;
using WBY.Domain.ViewModels;

namespace WBY.Services.Home
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