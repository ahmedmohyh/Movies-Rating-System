using System.Web;
using System.Web.Mvc;

namespace Movies_Rating_Sysyem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
