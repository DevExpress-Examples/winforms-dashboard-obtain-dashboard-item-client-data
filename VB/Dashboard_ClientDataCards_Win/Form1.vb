Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.DashboardWin
Imports DevExpress.DashboardCommon
Imports DevExpress.XtraCharts
Imports DevExpress.DashboardCommon.ViewerData

Namespace Dashboard_ClientDataCards_Win
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        ' Handles the DashboardViewer.DashboardItemClick event.
        Private Sub dashboardViewer1_DashboardItemClick(ByVal sender As Object, _
                                                        ByVal e As DashboardItemMouseActionEventArgs) _
                                                    Handles dashboardViewer1.DashboardItemClick
            If e.DashboardItemName = "cardDashboardItem1" And e.GetAxisPoint() IsNot Nothing Then
                ' Obtains client data related to the clicked card.
                Dim clickedItemData As MultiDimensionalData = e.Data.GetSlice(e.GetAxisPoint())
                Dim delta As DeltaDescriptor = e.GetDeltas()(0)

                ' Creates a data table that will be used to hold client data.
                Dim dataSource As New DataTable()
                dataSource.Columns.Add("Argument", GetType(Date))
                dataSource.Columns.Add("Actual", GetType(Double))
                dataSource.Columns.Add("Target", GetType(Double))

                ' Saves values of axis points placed on the "sparkline" axis and corresponding
                ' actual/target values to the data table.
                For Each point As AxisPoint In clickedItemData.GetAxisPoints(DashboardDataAxisNames.SparklineAxis)
                    Dim row As DataRow = dataSource.NewRow()
                    Dim deltaValue As DeltaValue = clickedItemData.GetSlice(point).GetDeltaValue(delta)
                    If deltaValue.ActualValue.Value IsNot Nothing AndAlso
                        deltaValue.TargetValue.Value IsNot Nothing Then
                        row("Argument") = point.Value
                        row("Actual") = deltaValue.ActualValue.Value
                        row("Target") = deltaValue.TargetValue.Value
                    Else
                        row("Argument") = DBNull.Value
                        row("Actual") = DBNull.Value
                        row("Target") = DBNull.Value
                    End If
                    dataSource.Rows.Add(row)
                Next point
                DisplayDetailedChart(GetFormTitle(clickedItemData), dataSource)
            End If
        End Sub

        ' Creates a new form that is invoked on the card click and 
        ' shows the chart displaying client data.
        Private Sub DisplayDetailedChart(ByVal title As String, ByVal dataSource As DataTable)
            Dim form As New XtraForm()
            form.Text = title
            form.Bounds = New Rectangle(100, 100, 700, 350)

            Dim chart As New ChartControl()
            chart.Parent = form
            chart.Dock = DockStyle.Fill

            Dim series1 As New Series("Actual", ViewType.SplineArea)
            Dim series2 As New Series("Target", ViewType.Spline)
            chart.Series.AddRange(New Series() { series1, series2 })

            For Each series As Series In chart.Series
                series.DataSource = dataSource
                series.ArgumentDataMember = "Argument"
                series.ValueScaleType = ScaleType.Numerical
            Next series
            series1.ValueDataMembers.AddRange(New String() { "Actual" })
            series2.ValueDataMembers.AddRange(New String() { "Target" })
            CType(chart.Diagram, XYDiagram).AxisY.Label.TextPattern = "{V:$0}"

            form.ShowDialog()
            form.Dispose()
        End Sub

        ' Obtains a value of the axis point placed on the "default" axis
        ' to display this value in the invoked form title.
        Private Function GetFormTitle(ByVal clickedItemData As MultiDimensionalData) As String
            Dim clickedPoint As AxisPoint = clickedItemData.GetAxisPoints(DashboardDataAxisNames.DefaultAxis)(0)
            Dim clickedPointValue As String = clickedPoint.Value.ToString()
            Return clickedPointValue
        End Function
    End Class
End Namespace
