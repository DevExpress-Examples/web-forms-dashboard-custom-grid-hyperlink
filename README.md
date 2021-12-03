<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/434593648/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1049972)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Dashboard for Web Forms - How to customize Grid's Hyperlink Column behavior by using Custom Properties
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/434593648/)**
<!-- run online end -->

This example shows how to adjust [Hyperlink Column](https://docs.devexpress.com/Dashboard/119499/web-dashboard/create-dashboards-on-the-web/dashboard-item-settings/grid/columns/hyperlink-column) behavior for the [Grid](https://docs.devexpress.com/Dashboard/117161/web-dashboard/create-dashboards-on-the-web/dashboard-item-settings/grid) item. The following [Custom Properties](https://docs.devexpress.com/Dashboard/401702/web-dashboard/ui-elements-and-customization/create-custom-properties) are implemented:

* **Target** - Specifies whether the link will be opened in a new or separate window (webpage).
* **Custom JavaScript Code** - Specifies JS code which will be executed when the hyperlink is clicked. You can use the `{0}` placeholder in this code to get the value of a field which is specified in the hyperlinks Uri dimension.

In addition, to pass multiple URL arguments, the [Calculated Field](https://docs.devexpress.com/Dashboard/117196/web-dashboard/create-dashboards-on-the-web/providing-data/calculated-fields) is used in the hyperlink column configuration.

The resulting options look as follows:

![](images/screenshot.png)

<!-- default file list -->
## Files to look at

* [Default.aspx](./CS/Default.aspx)
* [Default.aspx.cs](./CS/Default.aspx.cs)
* [CustomRange.cs](./CS/Models/CustomRange.cs)
* [GridHyperlinkOptionsExtension.js](./CS/GridHyperlinkOptionsExtension.js)

<!-- default file list end -->

## Documentation

- [Hyperlink Column](https://docs.devexpress.com/Dashboard/119499/web-dashboard/create-dashboards-on-the-web/dashboard-item-settings/grid/columns/hyperlink-column) 
- [Access to Underlying Widgets in ASP.NET Web Forms](https://docs.devexpress.com/Dashboard/117573/web-dashboard/aspnet-web-forms-dashboard-control/access-to-underlying-widgets)
- [Custom Properties](https://docs.devexpress.com/Dashboard/401702/web-dashboard/ui-elements-and-customization/custom-properties)

## More Examples

- [Dashboard - Constant Lines](https://github.com/DevExpress-Examples/dashboard-constant-lines)
- [Dashboard for Web Forms - How to use Custom Properties to Modify Ranges in the Gauge Dashboard Item](https://github.com/DevExpress-Examples/web-forms-dashboard-gauge-ranges)
- [Dashboard for Web Forms - How to access API of underlying widgets](https://github.com/DevExpress-Examples/how-to-access-api-of-underlying-widgets-in-the-aspnet-dashboard-control-t492396)
