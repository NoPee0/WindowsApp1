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
        Me.components = New System.ComponentModel.Container()
        Me.MySqlConnection1 = New MySql.Data.MySqlClient.MySqlConnection()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 20
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Button4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.DarkCyan
        Me.Guna2CustomGradientPanel1.CustomizableEdges.BottomLeft = False
        Me.Guna2CustomGradientPanel1.CustomizableEdges.TopLeft = False
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.DimGray
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.AppWorkspace
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.GhostWhite
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Quality = 50
        Me.Guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 10
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(196, 450)
        Me.Guna2CustomGradientPanel1.TabIndex = 18
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button4.Location = New System.Drawing.Point(8, 142)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(177, 45)
        Me.Guna2Button4.TabIndex = 21
        Me.Guna2Button4.Text = "Connection"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button3.Location = New System.Drawing.Point(8, 244)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(182, 45)
        Me.Guna2Button3.TabIndex = 20
        Me.Guna2Button3.Text = "Database"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button2.Location = New System.Drawing.Point(8, 193)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(182, 45)
        Me.Guna2Button2.TabIndex = 19
        Me.Guna2Button2.Text = "Registration"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(196, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 450)
        Me.Panel1.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MySqlConnection1 As MySql.Data.MySqlClient.MySqlConnection
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Panel1 As Guna.UI2.WinForms.Guna2GradientPanel
End Class
