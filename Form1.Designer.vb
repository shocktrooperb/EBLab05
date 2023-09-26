<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTempF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.hsbTemp = New System.Windows.Forms.HScrollBar()
        Me.txtTempC = New System.Windows.Forms.TextBox()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fahrenheit"
        '
        'txtTempF
        '
        Me.txtTempF.BackColor = System.Drawing.Color.White
        Me.txtTempF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempF.Location = New System.Drawing.Point(135, 13)
        Me.txtTempF.Name = "txtTempF"
        Me.txtTempF.ReadOnly = True
        Me.txtTempF.Size = New System.Drawing.Size(100, 22)
        Me.txtTempF.TabIndex = 1
        Me.txtTempF.TabStop = False
        Me.txtTempF.Text = "32.0"
        Me.txtTempF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Celsius"
        '
        'lblBlue
        '
        Me.lblBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBlue.Location = New System.Drawing.Point(3, 51)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(217, 63)
        Me.lblBlue.TabIndex = 3
        '
        'hsbTemp
        '
        Me.hsbTemp.Location = New System.Drawing.Point(16, 73)
        Me.hsbTemp.Maximum = 1209
        Me.hsbTemp.Minimum = -600
        Me.hsbTemp.Name = "hsbTemp"
        Me.hsbTemp.Size = New System.Drawing.Size(196, 22)
        Me.hsbTemp.TabIndex = 4
        Me.hsbTemp.Value = 320
        '
        'txtTempC
        '
        Me.txtTempC.BackColor = System.Drawing.Color.White
        Me.txtTempC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempC.Location = New System.Drawing.Point(135, 117)
        Me.txtTempC.Name = "txtTempC"
        Me.txtTempC.ReadOnly = True
        Me.txtTempC.Size = New System.Drawing.Size(100, 22)
        Me.txtTempC.TabIndex = 5
        Me.txtTempC.TabStop = False
        Me.txtTempC.Text = "0.0"
        Me.txtTempC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRed
        '
        Me.lblRed.BackColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(3, 51)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(217, 63)
        Me.lblRed.TabIndex = 6
        '
        'frmTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 155)
        Me.Controls.Add(Me.txtTempC)
        Me.Controls.Add(Me.hsbTemp)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTempF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTempF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents hsbTemp As HScrollBar
    Friend WithEvents txtTempC As TextBox
    Friend WithEvents lblRed As Label







    Dim IsHot As Boolean

    Private Sub hsbTemp_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbTemp.Scroll
        Dim TempF As Single, TempC As Single
        'Read F and convert to C - divide by 10 needed since Value is tenths of degrees
        TempF = CSng(hsbTemp.Value / 10)
        'Check to see if changed from hot to cold or vice versa
        If IsHot And TempF < 70 Then
            'changed to cold
            IsHot = False
            lblBlue.BringToFront()
            hsbTemp.BringToFront()
        ElseIf Not (IsHot) And TempF >= 70 Then
            'changed to hot
            IsHot = True
            lblRed.BringToFront()
            hsbTemp.BringToFront()
        End If
        txtTempF.Text = Format(TempF, "0.0")
        TempC = (TempF - 32) * 5 / 9
        txtTempC.Text = Format(TempC, "0.0")
    End Sub

End Class
