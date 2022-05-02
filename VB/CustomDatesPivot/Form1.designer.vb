Imports Microsoft.VisualBasic
Imports System
Namespace CustomDatesPivot
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
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.dateEdit2 = New DevExpress.XtraEditors.DateEdit()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel1.SuspendLayout()
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel2.SuspendLayout()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.pivotGridField4, Me.pivotGridField5})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(826, 452)
            Me.pivotGridControl1.TabIndex = 0
            '
            'pivotGridField1
            '
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField1.AreaIndex = 0
            DataSourceColumnBinding1.ColumnName = "Name"
            Me.pivotGridField1.DataBinding = DataSourceColumnBinding1
            Me.pivotGridField1.Name = "pivotGridField1"
            '
            'pivotGridField2
            '
            Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField2.AreaIndex = 0
            DataSourceColumnBinding2.ColumnName = "Value"
            Me.pivotGridField2.DataBinding = DataSourceColumnBinding2
            Me.pivotGridField2.Name = "pivotGridField2"
            '
            'pivotGridField3
            '
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pivotGridField3.AreaIndex = 2
            Me.pivotGridField3.Caption = "Month"
            DataSourceColumnBinding3.ColumnName = "Date"
            DataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.pivotGridField3.DataBinding = DataSourceColumnBinding3
            Me.pivotGridField3.Name = "pivotGridField3"
            '
            'pivotGridField4
            '
            Me.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pivotGridField4.AreaIndex = 0
            Me.pivotGridField4.Caption = "Year"
            DataSourceColumnBinding4.ColumnName = "Date"
            DataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.pivotGridField4.DataBinding = DataSourceColumnBinding4
            Me.pivotGridField4.Name = "pivotGridField4"
            '
            'pivotGridField5
            '
            Me.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pivotGridField5.AreaIndex = 1
            Me.pivotGridField5.Caption = "Quarter"
            DataSourceColumnBinding5.ColumnName = "Date"
            DataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.pivotGridField5.DataBinding = DataSourceColumnBinding5
            Me.pivotGridField5.Name = "pivotGridField5"
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            '
            'splitContainerControl1.Panel1
            '
            Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGridControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            '
            'splitContainerControl1.Panel2
            '
            Me.splitContainerControl1.Panel2.Controls.Add(Me.labelControl3)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.labelControl2)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.labelControl1)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.comboBoxEdit1)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.simpleButton1)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.dateEdit2)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.dateEdit1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1053, 452)
            Me.splitContainerControl1.SplitterPosition = 217
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'labelControl3
            '
            Me.labelControl3.Location = New System.Drawing.Point(12, 103)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(38, 13)
            Me.labelControl3.TabIndex = 6
            Me.labelControl3.Text = "Interval"
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(12, 58)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(44, 13)
            Me.labelControl2.TabIndex = 5
            Me.labelControl2.Text = "End Date"
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(12, 13)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(50, 13)
            Me.labelControl1.TabIndex = 4
            Me.labelControl1.Text = "Start Date"
            '
            'comboBoxEdit1
            '
            Me.comboBoxEdit1.EditValue = "Month"
            Me.comboBoxEdit1.Location = New System.Drawing.Point(12, 135)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.Items.AddRange(New Object() {"Day", "Month", "Quarter", "Year"})
            Me.comboBoxEdit1.Size = New System.Drawing.Size(193, 20)
            Me.comboBoxEdit1.TabIndex = 3
            '
            'simpleButton1
            '
            Me.simpleButton1.Location = New System.Drawing.Point(12, 170)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(193, 23)
            Me.simpleButton1.TabIndex = 2
            Me.simpleButton1.Text = "Create Custom Dates"
            '
            'dateEdit2
            '
            Me.dateEdit2.EditValue = Nothing
            Me.dateEdit2.Location = New System.Drawing.Point(12, 77)
            Me.dateEdit2.Name = "dateEdit2"
            Me.dateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit2.Size = New System.Drawing.Size(193, 20)
            Me.dateEdit2.TabIndex = 1
            '
            'dateEdit1
            '
            Me.dateEdit1.EditValue = Nothing
            Me.dateEdit1.Location = New System.Drawing.Point(12, 32)
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit1.Size = New System.Drawing.Size(193, 20)
            Me.dateEdit1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1053, 452)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel1.ResumeLayout(False)
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel2.ResumeLayout(False)
            Me.splitContainerControl1.Panel2.PerformLayout()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private dateEdit2 As DevExpress.XtraEditors.DateEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
	End Class
End Namespace

