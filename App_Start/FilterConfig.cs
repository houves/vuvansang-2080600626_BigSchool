using System.Web;
using System.Web.Mvc;

namespace vuvansang_2080600626
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
