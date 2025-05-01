<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSupplier
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
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.lblSuppliers = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMenu
        '
        Me.grpMenu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grpMenu.Controls.Add(Me.lblSuppliers)
        Me.grpMenu.Controls.Add(Me.txtPostcode)
        Me.grpMenu.Controls.Add(Me.Label12)
        Me.grpMenu.Controls.Add(Me.txtMail)
        Me.grpMenu.Controls.Add(Me.Label8)
        Me.grpMenu.Controls.Add(Me.btnNext)
        Me.grpMenu.Controls.Add(Me.txtTel)
        Me.grpMenu.Controls.Add(Me.Label5)
        Me.grpMenu.Controls.Add(Me.txtAddress)
        Me.grpMenu.Controls.Add(Me.Label4)
        Me.grpMenu.Controls.Add(Me.txtSupplier)
        Me.grpMenu.Controls.Add(Me.btnCancel)
        Me.grpMenu.Controls.Add(Me.lblItemName)
        Me.grpMenu.Location = New System.Drawing.Point(687, 109)
        Me.grpMenu.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpMenu.Size = New System.Drawing.Size(1372, 1388)
        Me.grpMenu.TabIndex = 4
        Me.grpMenu.TabStop = False
        '
        'lblSuppliers
        '
        Me.lblSuppliers.AutoSize = True
        Me.lblSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppliers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSuppliers.Location = New System.Drawing.Point(12, 20)
        Me.lblSuppliers.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSuppliers.Name = "lblSuppliers"
        Me.lblSuppliers.Size = New System.Drawing.Size(831, 147)
        Me.lblSuppliers.TabIndex = 58
        Me.lblSuppliers.Text = "New Supplier"
        '
        'txtPostcode
        '
        Me.txtPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostcode.Location = New System.Drawing.Point(744, 877)
        Me.txtPostcode.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(586, 92)
        Me.txtPostcode.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(354, 877)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(382, 85)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Postcode:"
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(744, 1089)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(586, 92)
        Me.txtMail.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(531, 1096)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 85)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Mail:"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(967, 1260)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(363, 93)
        Me.btnNext.TabIndex = 29
        Me.btnNext.Text = "Confirm"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(744, 453)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(586, 92)
        Me.txtTel.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(505, 453)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 85)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Tel 1:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(744, 662)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(586, 92)
        Me.txtAddress.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 665)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(343, 85)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Address:"
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.Location = New System.Drawing.Point(744, 249)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(586, 92)
        Me.txtSupplier.TabIndex = 22
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(37, 1260)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(310, 93)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(393, 249)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(344, 85)
        Me.lblItemName.TabIndex = 16
        Me.lblItemName.Text = "Supplier:"
        '
        'AddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2568, 1619)
        Me.Controls.Add(Me.grpMenu)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "AddSupplier"
        Me.Text = "AddSupplier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpMenu.ResumeLayout(False)
        Me.grpMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMenu As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblItemName As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents lblSuppliers As Label
End Class
