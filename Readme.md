# Dashboard for WinForms - How to Get and Process the Dashboard Item's Underlying Data


The following example demonstrates how to get client data corresponding to a particular visual element using DashboardViewer's API.

In this example, the [DashboardViewer.DashboardItemClick](http://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemClick) event is handled to obtain client data for the [Card](http://docs.devexpress.com/Dashboard/15263) dashboard item and display this data in a [Chart control](http://docs.devexpress.com/WindowsForms/8117). 

When the user clicks a card, the axis points placed on the ['Sparkline' axis](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardDataAxisNames._members)  are used to determine the actual/target values. The values are saved to a data table whose data are displayed in a Chart control.

![](/images/winforms-dashboard-obtain-client-data-click.png)

## Documentation

- [Obtain Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/17269/winforms-dashboard/winforms-viewer/obtaining-underlying-and-displayed-data)

## More Examples

* [How to: Add Custom Interactivity to a Dashboard Displayed in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-add-custom-interactivity-to-a-dashboard-displayed-in-the-winforms-viewer-t189795)
* [How to: Calculate and Display Totals for the Hidden Measure](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-display-hidden-field-totals)
* [How to: Display the Total Value above each Pie Chart in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-display-the-total-value-above-each-pie-chart)
* [How to: Customize the Data Inspector Dialog](https://github.com/DevExpress-Examples/winforms-dashboard-data-inspector-customization)


