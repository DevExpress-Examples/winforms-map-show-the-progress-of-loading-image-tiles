Namespace TilesLoaded
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
            Dim imageTilesLayer1 As New DevExpress.XtraMap.ImageLayer()
            Dim openStreetMapDataProvider1 As New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.progressBar1 = New System.Windows.Forms.ProgressBar()
            Me.label1 = New System.Windows.Forms.Label()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(55R, 25R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            imageTilesLayer1.DataProvider = openStreetMapDataProvider1
            Me.mapControl1.Layers.Add(imageTilesLayer1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(906, 520)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ZoomLevel = 6R
            ' 
            ' progressBar1
            ' 
            Me.progressBar1.Location = New System.Drawing.Point(12, 12)
            Me.progressBar1.Name = "progressBar1"
            Me.progressBar1.Size = New System.Drawing.Size(146, 23)
            Me.progressBar1.TabIndex = 1
            Me.progressBar1.Visible = False
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(41, 40)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(80, 13)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Loading Data..."
            Me.label1.Visible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(906, 520)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.progressBar1)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private progressBar1 As System.Windows.Forms.ProgressBar
        Private label1 As System.Windows.Forms.Label
    End Class
End Namespace

