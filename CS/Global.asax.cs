using DashboardGridHyperlink.Models;
using System;

namespace DashboardGridHyperlink {
    public class Global : System.Web.HttpApplication {
        protected void Application_Start(object sender, EventArgs e) {
            DevExpress.Utils.DeserializationSettings.RegisterTrustedClass(typeof(SalesPersonData));
        }
    }
}