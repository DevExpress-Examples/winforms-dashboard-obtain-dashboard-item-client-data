Namespace Dashboard_ClientDataCards_Win
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim card1 As New DevExpress.DashboardCommon.Card()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim measure3 As New DevExpress.DashboardCommon.Measure()
            Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.dataSource1 = New DevExpress.DashboardCommon.DataSource()
            Me.nwindDataSet1 = New Dashboard_ClientDataCards_Win.Data.nwindDataSet()
            Me.cardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
            DirectCast(Me.dataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' dataSource1
            ' 
            Me.dataSource1.ComponentName = "dataSource1"
            Me.dataSource1.Data = Me.nwindDataSet1
            Me.dataSource1.DataMember = "SalesPerson"
            Me.dataSource1.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client
            Me.dataSource1.Name = "Data Source 1"
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' cardDashboardItem1
            ' 
            measure1.DataMember = "Extended Price"
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.StdDev
            measure2.DataMember = "Extended Price"
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.StdDevp
            card1.AddDataItem("ActualValue", measure1)
            card1.AddDataItem("TargetValue", measure2)
            Me.cardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1})
            Me.cardDashboardItem1.ComponentName = "cardDashboardItem1"
            dimension1.DataMember = "Sales Person"
            dimension2.DataMember = "OrderDate"
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.cardDashboardItem1.DataItemRepository.Clear()
            Me.cardDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.cardDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1")
            Me.cardDashboardItem1.DataItemRepository.Add(measure1, "DataItem2")
            Me.cardDashboardItem1.DataItemRepository.Add(measure2, "DataItem3")
            Me.cardDashboardItem1.DataSource = Me.dataSource1
            Me.cardDashboardItem1.IgnoreMasterFilters = False
            Me.cardDashboardItem1.Name = "Cards 1"
            Me.cardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.cardDashboardItem1.ShowCaption = False
            Me.cardDashboardItem1.SparklineArgument = dimension2
            ' 
            ' pieDashboardItem1
            ' 
            dimension3.DataMember = "OrderDate"
            Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
            Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
            measure3.DataMember = "Extended Price"
            dimension4.DataMember = "Country"
            Me.pieDashboardItem1.DataItemRepository.Clear()
            Me.pieDashboardItem1.DataItemRepository.Add(measure3, "DataItem0")
            Me.pieDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2")
            Me.pieDashboardItem1.DataItemRepository.Add(dimension4, "DataItem1")
            Me.pieDashboardItem1.DataSource = Me.dataSource1
            Me.pieDashboardItem1.IgnoreMasterFilters = False
            Me.pieDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.pieDashboardItem1.Name = "Pies 1"
            Me.pieDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
            Me.pieDashboardItem1.ShowCaption = False
            Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure3})
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() { Me.dataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.cardDashboardItem1, Me.pieDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.pieDashboardItem1
            dashboardLayoutItem1.Weight = 30.327868852459016R
            dashboardLayoutItem2.DashboardItem = Me.cardDashboardItem1
            dashboardLayoutItem2.Weight = 69.672131147540981R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            DirectCast(Me.dataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private dataSource1 As DevExpress.DashboardCommon.DataSource
        Private nwindDataSet1 As Data.nwindDataSet
        Private cardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
        Private pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
    End Class
End Namespace
