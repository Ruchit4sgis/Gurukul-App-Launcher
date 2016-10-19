using System.Web;
using System.Web.Mvc;

namespace Gurukul_App_Launcher
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
