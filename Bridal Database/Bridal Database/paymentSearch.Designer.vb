<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentSearch
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
        Me.lblQuickSearch = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMaxRemaining = New System.Windows.Forms.TextBox()
        Me.txtMaxPaid = New System.Windows.Forms.TextBox()
        Me.txtMaxTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMinTotal = New System.Windows.Forms.TextBox()
        Me.txtMinPaid = New System.Windows.Forms.TextBox()
        Me.txtMinRemaining = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAuthorisation = New System.Windows.Forms.TextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCustomerSearch = New System.Windows.Forms.Button()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.grpMenu.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMenu
        '
        Me.grpMenu.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.grpMenu.Controls.Add(Me.lblQuickSearch)
        Me.grpMenu.Controls.Add(Me.GroupBox2)
        Me.grpMenu.Location = New System.Drawing.Point(27, 52)
        Me.grpMenu.Margin = New System.Windows.Forms.Padding(6)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Padding = New System.Windows.Forms.Padding(6)
        Me.grpMenu.Size = New System.Drawing.Size(2627, 1539)
        Me.grpMenu.TabIndex = 5
        Me.grpMenu.TabStop = False
        '
        'lblQuickSearch
        '
        Me.lblQuickSearch.AutoSize = True
        Me.lblQuickSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblQuickSearch.Location = New System.Drawing.Point(12, 20)
        Me.lblQuickSearch.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblQuickSearch.Name = "lblQuickSearch"
        Me.lblQuickSearch.Size = New System.Drawing.Size(501, 85)
        Me.lblQuickSearch.TabIndex = 5
        Me.lblQuickSearch.Text = "Quick Search"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.cmbPaymentMethod)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtAuthorisation)
        Me.GroupBox2.Controls.Add(Me.lblItemName)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnCustomerSearch)
        Me.GroupBox2.Controls.Add(Me.lblCustomers)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 133)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(2549, 1362)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.txtMaxRemaining)
        Me.Panel1.Controls.Add(Me.txtMaxPaid)
        Me.Panel1.Controls.Add(Me.txtMaxTotal)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtMinTotal)
        Me.Panel1.Controls.Add(Me.txtMinPaid)
        Me.Panel1.Controls.Add(Me.txtMinRemaining)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(180, 570)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2183, 585)
        Me.Panel1.TabIndex = 97
        '
        'txtMaxRemaining
        '
        Me.txtMaxRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxRemaining.Location = New System.Drawing.Point(1528, 445)
        Me.txtMaxRemaining.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMaxRemaining.Name = "txtMaxRemaining"
        Me.txtMaxRemaining.Size = New System.Drawing.Size(586, 92)
        Me.txtMaxRemaining.TabIndex = 109
        '
        'txtMaxPaid
        '
        Me.txtMaxPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxPaid.Location = New System.Drawing.Point(1528, 288)
        Me.txtMaxPaid.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMaxPaid.Name = "txtMaxPaid"
        Me.txtMaxPaid.Size = New System.Drawing.Size(586, 92)
        Me.txtMaxPaid.TabIndex = 108
        '
        'txtMaxTotal
        '
        Me.txtMaxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxTotal.Location = New System.Drawing.Point(1528, 135)
        Me.txtMaxTotal.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMaxTotal.Name = "txtMaxTotal"
        Me.txtMaxTotal.Size = New System.Drawing.Size(586, 92)
        Me.txtMaxTotal.TabIndex = 107
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(1513, 44)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(200, 85)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "Max:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(808, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 85)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Min:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(718, 142)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 85)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "£"
        '
        'txtMinTotal
        '
        Me.txtMinTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinTotal.Location = New System.Drawing.Point(808, 135)
        Me.txtMinTotal.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMinTotal.Name = "txtMinTotal"
        Me.txtMinTotal.Size = New System.Drawing.Size(591, 92)
        Me.txtMinTotal.TabIndex = 89
        '
        'txtMinPaid
        '
        Me.txtMinPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinPaid.Location = New System.Drawing.Point(808, 288)
        Me.txtMinPaid.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMinPaid.Name = "txtMinPaid"
        Me.txtMinPaid.Size = New System.Drawing.Size(591, 92)
        Me.txtMinPaid.TabIndex = 91
        '
        'txtMinRemaining
        '
        Me.txtMinRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinRemaining.Location = New System.Drawing.Point(808, 445)
        Me.txtMinRemaining.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMinRemaining.Name = "txtMinRemaining"
        Me.txtMinRemaining.Size = New System.Drawing.Size(588, 92)
        Me.txtMinRemaining.TabIndex = 92
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(718, 452)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 85)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "£"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(717, 305)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 85)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "£"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 142)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(438, 85)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Order Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 452)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(711, 85)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Balance Remaining:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 305)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(488, 85)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Amount Paid:"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(660, 165)
        Me.txtID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(236, 92)
        Me.txtID.TabIndex = 94
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(157, 165)
        Me.lblID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(491, 85)
        Me.lblID.TabIndex = 93
        Me.lblID.Text = "Customer ID:"
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"Cash", "Bank Transfer", "Direct Debit ", "Debit Card", "Credit Card"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(1850, 159)
        Me.cmbPaymentMethod.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(586, 93)
        Me.cmbPaymentMethod.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1111, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(727, 85)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Method of Payment:"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(1670, 425)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(6)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(766, 92)
        Me.dtpDate.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1115, 432)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(547, 85)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Payment Date:"
        '
        'txtAuthorisation
        '
        Me.txtAuthorisation.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorisation.Location = New System.Drawing.Point(1850, 282)
        Me.txtAuthorisation.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAuthorisation.Name = "txtAuthorisation"
        Me.txtAuthorisation.Size = New System.Drawing.Size(586, 92)
        Me.txtAuthorisation.TabIndex = 82
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(1120, 289)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(718, 85)
        Me.lblItemName.TabIndex = 81
        Me.lblItemName.Text = "Authorisation Code:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1781, 1220)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(276, 100)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Clear fields"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(46, 1220)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(276, 100)
        Me.btnCancel.TabIndex = 71
        Me.btnCancel.Text = "Back"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnCustomerSearch
        '
        Me.btnCustomerSearch.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomerSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerSearch.Location = New System.Drawing.Point(2078, 1220)
        Me.btnCustomerSearch.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCustomerSearch.Name = "btnCustomerSearch"
        Me.btnCustomerSearch.Size = New System.Drawing.Size(426, 100)
        Me.btnCustomerSearch.TabIndex = 22
        Me.btnCustomerSearch.Text = "Search"
        Me.btnCustomerSearch.UseVisualStyleBackColor = False
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomers.Location = New System.Drawing.Point(16, 13)
        Me.lblCustomers.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(341, 85)
        Me.lblCustomers.TabIndex = 7
        Me.lblCustomers.Text = "Payment"
        '
        'paymentSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2693, 1619)
        Me.Controls.Add(Me.grpMenu)
        Me.Name = "paymentSearch"
        Me.Text = "paymentSearch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpMenu.ResumeLayout(False)
        Me.grpMenu.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMenu As GroupBox
    Friend WithEvents lblQuickSearch As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCustomerSearch As Button
    Friend WithEvents lblCustomers As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtMinRemaining As TextBox
    Friend WithEvents txtMinPaid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMinTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAuthorisation As TextBox
    Friend WithEvents lblItemName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMaxRemaining As TextBox
    Friend WithEvents txtMaxPaid As TextBox
    Friend WithEvents txtMaxTotal As TextBox
End Class
