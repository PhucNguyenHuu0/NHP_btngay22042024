using System.Web;
using System.Web.Mvc;

namespace NHP_2210900119_bai2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
