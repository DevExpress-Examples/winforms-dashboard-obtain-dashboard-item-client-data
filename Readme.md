# How to Get and Process the Dashboard Item's Underlying Data


The following example demonstrates how to get client data corresponding to a particular visual element using DashboardViewer's API.

In this example, the [DashboardViewer.DashboardItemClick](http://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemClick) event is handled to obtain client data for the [Card](http://docs.devexpress.com/Dashboard/15263) dashboard item and display this data in a [Chart control](http://docs.devexpress.com/WindowsForms/8117). 

When the user clicks a card, the axis points placed on the ['Sparkline' axis](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardDataAxisNames._members)  are used to determine the actual/target values. The values are saved to a data table whose data are displayed in a Chart control.

![](/images/winforms-dashboard-obtain-client-data-click.png)

See Also:

* [How to: Display the Underlying Data for a Dashboard Item](https://github.com/DevExpress-Examples/winviewer-how-to-obtain-a-dashboard-items-underlying-data-for-a-clicked-visual-element-t129135)




