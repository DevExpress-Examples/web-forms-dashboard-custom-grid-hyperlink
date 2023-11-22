﻿using System;
using DashboardGridHyperlink.Models;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;

namespace DashboardGridHyperlink {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            DevExpress.Utils.DeserializationSettings.RegisterTrustedClass(typeof(SalesPersonData));
            ASPxDashboard1.SetDataSourceStorage(CreateDataSourceStorage());
        }

        public DataSourceInMemoryStorage CreateDataSourceStorage() {
            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
            DashboardObjectDataSource objDataSource = new DashboardObjectDataSource("Object Data Source", typeof(SalesPersonData));

            objDataSource.DataMember = "GetSalesData";
            dataSourceStorage.RegisterDataSource("objectDataSource", objDataSource.SaveToXml());

            return dataSourceStorage;
        }
    }
}