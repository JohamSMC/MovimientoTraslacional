<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart_G1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_G2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.L_title = New System.Windows.Forms.Label()
        CType(Me.Chart_G1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_G2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart_G1
        '
        Me.Chart_G1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.Title = "T"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.Red
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.AxisY.Title = "X"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.Green
        ChartArea1.Name = "ChartArea1"
        Me.Chart_G1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart_G1.Legends.Add(Legend1)
        Me.Chart_G1.Location = New System.Drawing.Point(50, 60)
        Me.Chart_G1.Name = "Chart_G1"
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.Green
        Series1.Legend = "Legend1"
        Series1.Name = "G1"
        Me.Chart_G1.Series.Add(Series1)
        Me.Chart_G1.Size = New System.Drawing.Size(700, 170)
        Me.Chart_G1.TabIndex = 0
        Me.Chart_G1.Text = "Chart1"
        '
        'Chart_G2
        '
        Me.Chart_G2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisX.Title = "T"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.AxisY.Title = "X"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.TitleForeColor = System.Drawing.Color.Navy
        ChartArea2.Name = "ChartArea1"
        Me.Chart_G2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart_G2.Legends.Add(Legend2)
        Me.Chart_G2.Location = New System.Drawing.Point(50, 250)
        Me.Chart_G2.Name = "Chart_G2"
        Series2.BorderWidth = 4
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.Navy
        Series2.Legend = "Legend1"
        Series2.Name = "G2"
        Me.Chart_G2.Series.Add(Series2)
        Me.Chart_G2.Size = New System.Drawing.Size(700, 170)
        Me.Chart_G2.TabIndex = 1
        Me.Chart_G2.Text = "Chart2"
        '
        'L_title
        '
        Me.L_title.AutoSize = True
        Me.L_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_title.Location = New System.Drawing.Point(12, 9)
        Me.L_title.Name = "L_title"
        Me.L_title.Size = New System.Drawing.Size(153, 29)
        Me.L_title.TabIndex = 2
        Me.L_title.Text = "Graficas de "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.L_title)
        Me.Controls.Add(Me.Chart_G2)
        Me.Controls.Add(Me.Chart_G1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Graficas"
        CType(Me.Chart_G1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_G2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart_G1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart_G2 As DataVisualization.Charting.Chart
    Friend WithEvents L_title As Label
End Class
