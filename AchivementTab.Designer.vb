<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AchivementTab
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AchivementTab))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Success1 = New System.Windows.Forms.Button()
        Me.Success2 = New System.Windows.Forms.Button()
        Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Success3 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.NotifyIcon3 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon4 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Success4 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Success5 = New System.Windows.Forms.Button()
        Me.Success6 = New System.Windows.Forms.Button()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.SecretSuccess1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Succès N°1"
        Me.NotifyIcon1.Visible = True
        '
        'Success1
        '
        Me.Success1.Location = New System.Drawing.Point(12, 12)
        Me.Success1.Name = "Success1"
        Me.Success1.Size = New System.Drawing.Size(166, 68)
        Me.Success1.TabIndex = 0
        Me.Success1.Text = "Succès n°1"
        Me.Success1.UseVisualStyleBackColor = True
        '
        'Success2
        '
        Me.Success2.Enabled = False
        Me.Success2.Location = New System.Drawing.Point(218, 40)
        Me.Success2.Name = "Success2"
        Me.Success2.Size = New System.Drawing.Size(172, 33)
        Me.Success2.TabIndex = 1
        Me.Success2.Text = "Succès n°2"
        Me.Success2.UseVisualStyleBackColor = True
        '
        'NotifyIcon2
        '
        Me.NotifyIcon2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon2.BalloonTipTitle = "App Achivements"
        Me.NotifyIcon2.Icon = CType(resources.GetObject("NotifyIcon2.Icon"), System.Drawing.Icon)
        Me.NotifyIcon2.Text = "Succès n°2"
        Me.NotifyIcon2.Visible = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(218, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "->"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Success3
        '
        Me.Success3.Enabled = False
        Me.Success3.Location = New System.Drawing.Point(435, 33)
        Me.Success3.Name = "Success3"
        Me.Success3.Size = New System.Drawing.Size(166, 40)
        Me.Success3.TabIndex = 4
        Me.Success3.Text = "Succès n°3"
        Me.Success3.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(456, 15)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(118, 17)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Obtenir le succès"
        '
        'NotifyIcon3
        '
        Me.NotifyIcon3.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon3.Icon = CType(resources.GetObject("NotifyIcon3.Icon"), System.Drawing.Icon)
        Me.NotifyIcon3.Text = "Success n°3"
        Me.NotifyIcon3.Visible = True
        '
        'NotifyIcon4
        '
        Me.NotifyIcon4.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon4.Icon = CType(resources.GetObject("NotifyIcon4.Icon"), System.Drawing.Icon)
        Me.NotifyIcon4.Text = "Success n°4"
        Me.NotifyIcon4.Visible = True
        '
        'Success4
        '
        Me.Success4.Enabled = False
        Me.Success4.Location = New System.Drawing.Point(627, 33)
        Me.Success4.Name = "Success4"
        Me.Success4.Size = New System.Drawing.Size(166, 40)
        Me.Success4.TabIndex = 6
        Me.Success4.Text = "Succès n°4"
        Me.Success4.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Enabled = False
        Me.LinkLabel2.Location = New System.Drawing.Point(650, 15)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(118, 17)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Obtenir le succès"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(841, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 21)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Cochez !"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Success5
        '
        Me.Success5.Location = New System.Drawing.Point(818, 37)
        Me.Success5.Name = "Success5"
        Me.Success5.Size = New System.Drawing.Size(122, 33)
        Me.Success5.TabIndex = 9
        Me.Success5.Text = "Succès n°5"
        Me.Success5.UseVisualStyleBackColor = True
        '
        'Success6
        '
        Me.Success6.Enabled = False
        Me.Success6.Location = New System.Drawing.Point(958, 37)
        Me.Success6.Name = "Success6"
        Me.Success6.Size = New System.Drawing.Size(122, 33)
        Me.Success6.TabIndex = 10
        Me.Success6.Text = "Succès n°6"
        Me.Success6.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(955, 12)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(135, 17)
        Me.LinkLabel3.TabIndex = 11
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Accéder au succès !"
        '
        'SecretSuccess1
        '
        Me.SecretSuccess1.Location = New System.Drawing.Point(1467, 539)
        Me.SecretSuccess1.Name = "SecretSuccess1"
        Me.SecretSuccess1.Size = New System.Drawing.Size(72, 50)
        Me.SecretSuccess1.TabIndex = 12
        Me.SecretSuccess1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.AchivementApp.My.Resources.Resources.settings_icon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(2, 503)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 45)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AchivementTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 546)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SecretSuccess1)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Success6)
        Me.Controls.Add(Me.Success5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Success4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Success3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Success2)
        Me.Controls.Add(Me.Success1)
        Me.Name = "AchivementTab"
        Me.Text = "Application Succès"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Success1 As Button
    Friend WithEvents Success2 As Button
    Friend WithEvents NotifyIcon2 As NotifyIcon
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Success3 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents NotifyIcon3 As NotifyIcon
    Friend WithEvents NotifyIcon4 As NotifyIcon
    Friend WithEvents Success4 As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Success5 As Button
    Friend WithEvents Success6 As Button
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents SecretSuccess1 As Button
    Friend WithEvents Button2 As Button
End Class
