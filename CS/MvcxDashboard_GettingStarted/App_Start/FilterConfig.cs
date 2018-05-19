using System.Web;
using System.Web.Mvc;

namespace MvcxDashboard_GettingStarted {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}