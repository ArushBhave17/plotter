<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Text = "Form1"
    End Sub

End Class

Imports System.Windows.Forms.DataVisualization.Charting
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scatterChart As New Chart

        'Create the series
        scatterChart.Series.Add(New Series("Property1") With {.ChartType = SeriesChartType.Point, .Color = Color.Green})
        scatterChart.Series.Add(New Series("Property2") With {.ChartType = SeriesChartType.Point, .Color = Color.Green})

        'Set the minimum and maximums
        scatterChart.ChartAreas.Add(New ChartArea)
        scatterChart.ChartAreas(0).AxisX.Minimum = 0
        scatterChart.ChartAreas(0).AxisX.Maximum = 100
        scatterChart.ChartAreas(0).AxisY.Minimum = 0
        scatterChart.ChartAreas(0).AxisY.Maximum = 100

        'Invert the y axis
        scatterChart.ChartAreas(0).AxisY.IsReversed = True

        'Plot the 2 sample data
        scatterChart.Series("Property1").Points.AddXY(50, 25)
        scatterChart.Series("Property2").Points.AddXY(75, 65)

        Me.Controls.Add(scatterChart)
    End Sub
End Class

