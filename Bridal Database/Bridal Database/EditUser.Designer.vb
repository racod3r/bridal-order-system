<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbNewAccessLevel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCurrentUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNewPassConfEdit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtNewPassEdit = New System.Windows.Forms.TextBox()
        Me.txtNewUserEdit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.cmbNewAccessLevel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtNewPassConfEdit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.txtNewPassEdit)
        Me.GroupBox1.Controls.Add(Me.txtNewUserEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 203)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(2625, 1363)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'cmbNewAccessLevel
        '
        Me.cmbNewAccessLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewAccessLevel.FormattingEnabled = True
        Me.cmbNewAccessLevel.Items.AddRange(New Object() {"Basic", "Admin"})
        Me.cmbNewAccessLevel.Location = New System.Drawing.Point(1316, 974)
        Me.cmbNewAccessLevel.Name = "cmbNewAccessLevel"
        Me.cmbNewAccessLevel.Size = New System.Drawing.Size(577, 93)
        Me.cmbNewAccessLevel.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(602, 977)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(691, 90)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "New Access Level:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox2.Controls.Add(Me.txtCurrentUser)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(2625, 278)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'txtCurrentUser
        '
        Me.txtCurrentUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtCurrentUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentUser.Location = New System.Drawing.Point(1316, 76)
        Me.txtCurrentUser.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCurrentUser.Name = "txtCurrentUser"
        Me.txtCurrentUser.Size = New System.Drawing.Size(1094, 152)
        Me.txtCurrentUser.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1166, 162)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Current Username:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1777, 807)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'txtNewPassConfEdit
        '
        Me.txtNewPassConfEdit.BackColor = System.Drawing.SystemColors.Window
        Me.txtNewPassConfEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassConfEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassConfEdit.Location = New System.Drawing.Point(1316, 794)
        Me.txtNewPassConfEdit.Margin = New System.Windows.Forms.Padding(6)
        Me.txtNewPassConfEdit.Name = "txtNewPassConfEdit"
        Me.txtNewPassConfEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassConfEdit.Size = New System.Drawing.Size(577, 92)
        Me.txtNewPassConfEdit.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 807)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1118, 79)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Confirm New Password:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(48, 1228)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 94)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1777, 636)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(2242, 1228)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(329, 94)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Confirm"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(722, 629)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(586, 81)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "New Password:"
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(708, 448)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(609, 85)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "New Username:"
        '
        'txtNewPassEdit
        '
        Me.txtNewPassEdit.BackColor = System.Drawing.SystemColors.Window
        Me.txtNewPassEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassEdit.Location = New System.Drawing.Point(1316, 622)
        Me.txtNewPassEdit.Margin = New System.Windows.Forms.Padding(6)
        Me.txtNewPassEdit.Name = "txtNewPassEdit"
        Me.txtNewPassEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassEdit.Size = New System.Drawing.Size(577, 92)
        Me.txtNewPassEdit.TabIndex = 1
        '
        'txtNewUserEdit
        '
        Me.txtNewUserEdit.BackColor = System.Drawing.SystemColors.Window
        Me.txtNewUserEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewUserEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUserEdit.Location = New System.Drawing.Point(1316, 441)
        Me.txtNewUserEdit.Margin = New System.Windows.Forms.Padding(6)
        Me.txtNewUserEdit.Name = "txtNewUserEdit"
        Me.txtNewUserEdit.Size = New System.Drawing.Size(577, 92)
        Me.txtNewUserEdit.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(749, 138)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Edit User"
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2740, 1619)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "EditUser"
        Me.Text = "EditUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtNewPassEdit As TextBox
    Friend WithEvents txtNewUserEdit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNewPassConfEdit As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCurrentUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbNewAccessLevel As ComboBox
    Friend WithEvents Label4 As Label
End Class
