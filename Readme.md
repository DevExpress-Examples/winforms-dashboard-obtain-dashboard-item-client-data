<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581179/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T140553)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Dashboard1.cs](./CS/Dashboard_ClientDataCards_Win/Dashboard1.cs) (VB: [Dashboard1.vb](./VB/Dashboard_ClientDataCards_Win/Dashboard1.vb))
* [Form1.cs](./CS/Dashboard_ClientDataCards_Win/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_ClientDataCards_Win/Form1.vb))
<!-- default file list end -->
# How to obtain a dashboard item's client data in the WinForms Viewer


<p>The following example demonstrates how to get client data corresponding to a particular visual element using DashboardViewer's API.<br>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_DashboardItemClicktopic">DashboardViewer.DashboardItemClick</a> event is handled to obtain client data for the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15263">Card</a> dashboard item and display this data in a <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument8117">Chart control</a>. We obtain axis points placed on the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardDataAxisNamesMembersTopicAll">"Sparkline" axis</a> for the clicked card, determine corresponding actual/target values, and save these values to a data table. This table is used as a data source for the Chart control. <br>Note that you can apply master filtering by year in the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15262">Pie</a> dashboard item. The chart will display client data according to the selected year.<br><br>See Also:<br><a href="https://www.devexpress.com/Support/Center/p/T359303">T359303: How to get data from a clicked dashboard item (WinForms)</a></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-obtain-dashboard-item-client-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-obtain-dashboard-item-client-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
