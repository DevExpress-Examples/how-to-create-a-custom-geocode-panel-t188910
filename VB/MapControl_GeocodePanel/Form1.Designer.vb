﻿Namespace MapControl_GeocodePanel
    Partial Public Class Form1
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.bingMapDataProvider1 = New DevExpress.XtraMap.BingMapDataProvider()
            Me.informationLayer1 = New DevExpress.XtraMap.InformationLayer()
            Me.bingGeocodeDataProvider1 = New DevExpress.XtraMap.BingGeocodeDataProvider()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.bSearch = New System.Windows.Forms.Button()
            Me.teLongitude = New DevExpress.XtraEditors.TextEdit()
            Me.teLatitude = New DevExpress.XtraEditors.TextEdit()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLatitude = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLongitude = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.teLongitude.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.teLatitude.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciLatitude, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciLongitude, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' imageTilesLayer1
            ' 
            Me.imageLayer1.DataProvider = Me.bingMapDataProvider1
            ' 
            ' informationLayer1
            ' 
            Me.informationLayer1.DataProvider = Me.bingGeocodeDataProvider1
            Me.informationLayer1.Name = "GeocodeLayer"
            ' 
            ' bingGeocodeDataProvider1
            ' 
            Me.bingGeocodeDataProvider1.MaxVisibleResultCount = 3
            Me.bingGeocodeDataProvider1.ProcessMouseEvents = True
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.bSearch)
            Me.layoutControl1.Controls.Add(Me.teLongitude)
            Me.layoutControl1.Controls.Add(Me.teLatitude)
            Me.layoutControl1.Controls.Add(Me.mapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(624, 441)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' bSearch
            ' 
            Me.bSearch.Location = New System.Drawing.Point(504, 4)
            Me.bSearch.Name = "bSearch"
            Me.bSearch.Size = New System.Drawing.Size(116, 20)
            Me.bSearch.TabIndex = 7
            Me.bSearch.Text = "Search"
            Me.bSearch.UseVisualStyleBackColor = True
            ' 
            ' teLongitude
            ' 
            Me.teLongitude.Location = New System.Drawing.Point(308, 4)
            Me.teLongitude.Name = "teLongitude"
            Me.teLongitude.Size = New System.Drawing.Size(192, 20)
            Me.teLongitude.StyleController = Me.layoutControl1
            Me.teLongitude.TabIndex = 6
            ' 
            ' teLatitude
            ' 
            Me.teLatitude.Location = New System.Drawing.Point(58, 4)
            Me.teLatitude.Name = "teLatitude"
            Me.teLatitude.Size = New System.Drawing.Size(192, 20)
            Me.teLatitude.StyleController = Me.layoutControl1
            Me.teLatitude.TabIndex = 5
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.informationLayer1)
            Me.mapControl1.Location = New System.Drawing.Point(4, 28)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(616, 409)
            Me.mapControl1.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.lciLatitude, Me.lciLongitude, Me.layoutControlItem4})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(624, 441)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(620, 413)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' lciLatitude
            ' 
            Me.lciLatitude.Control = Me.teLatitude
            Me.lciLatitude.Location = New System.Drawing.Point(0, 0)
            Me.lciLatitude.Name = "lciLatitude"
            Me.lciLatitude.Size = New System.Drawing.Size(250, 24)
            Me.lciLatitude.Text = "Latitude:"
            Me.lciLatitude.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' lciLongitude
            ' 
            Me.lciLongitude.Control = Me.teLongitude
            Me.lciLongitude.Location = New System.Drawing.Point(250, 0)
            Me.lciLongitude.Name = "lciLongitude"
            Me.lciLongitude.Size = New System.Drawing.Size(250, 24)
            Me.lciLongitude.Text = "Longitude:"
            Me.lciLongitude.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.bSearch
            Me.layoutControlItem4.Location = New System.Drawing.Point(500, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(120, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 441)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.teLongitude.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.teLatitude.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciLatitude, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciLongitude, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private WithEvents bSearch As System.Windows.Forms.Button
        Private teLongitude As DevExpress.XtraEditors.TextEdit
        Private teLatitude As DevExpress.XtraEditors.TextEdit
        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private lciLatitude As DevExpress.XtraLayout.LayoutControlItem
        Private lciLongitude As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private imageLayer1 As DevExpress.XtraMap.ImageLayer
        Private bingMapDataProvider1 As DevExpress.XtraMap.BingMapDataProvider
        Private informationLayer1 As DevExpress.XtraMap.InformationLayer
        Private bingGeocodeDataProvider1 As DevExpress.XtraMap.BingGeocodeDataProvider
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

