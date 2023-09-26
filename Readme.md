<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581179/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T140553)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - How to Get and Process the Dashboard Item's Client Data

The following example shows how to use DashboardViewer's API and get client data corresponding to a particular visual element.

In this example, the [DashboardViewer.DashboardItemClick](http://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemClick) event is handled to obtain client data for the [Card](http://docs.devexpress.com/Dashboard/15263) dashboard item and display this data in a [Chart control](http://docs.devexpress.com/WindowsForms/8117). 

When the user clicks a card, the axis points placed on the ['Sparkline' axis](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardDataAxisNames._members)  are used to determine the actual/target values. The values are saved to a data table whose data are displayed in a Chart control.

![](/images/winforms-dashboard-obtain-client-data-click.png)

## Files to Review

* [Form1.cs](./CS/Dashboard_ClientDataCards_Win/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_ClientDataCards_Win/Form1.vb))

## Documentation

- [Obtain Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/17269/winforms-dashboard/winforms-viewer/obtaining-underlying-and-displayed-data)

## More Examples

* [How to: Add Custom Interactivity to a Dashboard Displayed in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-add-custom-interactivity-to-a-dashboard-displayed-in-the-winforms-viewer-t189795)
* [How to: Calculate and Display Totals for the Hidden Measure](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-display-hidden-field-totals)
* [How to: Display the Total Value above each Pie Chart in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-display-the-total-value-above-each-pie-chart)
* [How to: Customize the Data Inspector Dialog](https://github.com/DevExpress-Examples/winforms-dashboard-data-inspector-customization)
