using WBY.Web.ViewModels;

namespace WBY.Servicess.Home
{
    public interface IHomeService
    {
        IndexViewModel GetModelForIndex();
        void GetModelForAbout();
        void GetModelForContact();
    }
}
