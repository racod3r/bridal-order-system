<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment
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
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.lblPaymentID = New System.Windows.Forms.Label()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblItem6 = New System.Windows.Forms.Label()
        Me.lblItem5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblItem4 = New System.Windows.Forms.Label()
        Me.lblItem3 = New System.Windows.Forms.Label()
        Me.lblItem2 = New System.Windows.Forms.Label()
        Me.lblItem1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRemaining = New System.Windows.Forms.TextBox()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.lblOrderTotal = New System.Windows.Forms.Label()
        Me.txtOrderTotal = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAuthorisation = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMenu
        '
        Me.grpMenu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grpMenu.Controls.Add(Me.txtPID)
        Me.grpMenu.Controls.Add(Me.lblPaymentID)
        Me.grpMenu.Controls.Add(Me.txtCID)
        Me.grpMenu.Controls.Add(Me.lblCustomerID)
        Me.grpMenu.Controls.Add(Me.lblTotal)
        Me.grpMenu.Controls.Add(Me.lblItem6)
        Me.grpMenu.Controls.Add(Me.lblItem5)
        Me.grpMenu.Controls.Add(Me.Label1)
        Me.grpMenu.Controls.Add(Me.lblItem4)
        Me.grpMenu.Controls.Add(Me.lblItem3)
        Me.grpMenu.Controls.Add(Me.lblItem2)
        Me.grpMenu.Controls.Add(Me.lblItem1)
        Me.grpMenu.Controls.Add(Me.Label9)
        Me.grpMenu.Controls.Add(Me.txtRemaining)
        Me.grpMenu.Controls.Add(Me.txtPaid)
        Me.grpMenu.Controls.Add(Me.lblOrderTotal)
        Me.grpMenu.Controls.Add(Me.txtOrderTotal)
        Me.grpMenu.Controls.Add(Me.lblBalance)
        Me.grpMenu.Controls.Add(Me.Label4)
        Me.grpMenu.Controls.Add(Me.cmbPaymentMethod)
        Me.grpMenu.Controls.Add(Me.Label3)
        Me.grpMenu.Controls.Add(Me.Label8)
        Me.grpMenu.Controls.Add(Me.btnBack)
        Me.grpMenu.Controls.Add(Me.dtpDate)
        Me.grpMenu.Controls.Add(Me.btnNext)
        Me.grpMenu.Controls.Add(Me.Label6)
        Me.grpMenu.Controls.Add(Me.txtAuthorisation)
        Me.grpMenu.Controls.Add(Me.btnCancel)
        Me.grpMenu.Controls.Add(Me.Label2)
        Me.grpMenu.Controls.Add(Me.lblOrder)
        Me.grpMenu.Controls.Add(Me.lblCustomer)
        Me.grpMenu.Controls.Add(Me.lblItemName)
        Me.grpMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMenu.Location = New System.Drawing.Point(44, 43)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(1261, 761)
        Me.grpMenu.TabIndex = 4
        Me.grpMenu.TabStop = False
        '
        'txtPID
        '
        Me.txtPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPID.Location = New System.Drawing.Point(628, 128)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(120, 50)
        Me.txtPID.TabIndex = 82
        Me.txtPID.Visible = False
        '
        'lblPaymentID
        '
        Me.lblPaymentID.AutoSize = True
        Me.lblPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentID.Location = New System.Drawing.Point(392, 132)
        Me.lblPaymentID.Name = "lblPaymentID"
        Me.lblPaymentID.Size = New System.Drawing.Size(239, 44)
        Me.lblPaymentID.TabIndex = 81
        Me.lblPaymentID.Text = "Payment ID:"
        Me.lblPaymentID.Visible = False
        '
        'txtCID
        '
        Me.txtCID.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCID.Location = New System.Drawing.Point(264, 128)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(120, 50)
        Me.txtCID.TabIndex = 80
        Me.txtCID.Visible = False
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.Location = New System.Drawing.Point(16, 132)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(255, 44)
        Me.lblCustomerID.TabIndex = 79
        Me.lblCustomerID.Text = "Customer ID:"
        Me.lblCustomerID.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal.Location = New System.Drawing.Point(935, 684)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(262, 44)
        Me.lblTotal.TabIndex = 78
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItem6
        '
        Me.lblItem6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblItem6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItem6.Location = New System.Drawing.Point(776, 599)
        Me.lblItem6.Name = "lblItem6"
        Me.lblItem6.Size = New System.Drawing.Size(430, 66)
        Me.lblItem6.TabIndex = 77
        '
        'lblItem5
        '
        Me.lblItem5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblItem5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItem5.Location = New System.Drawing.Point(776, 527)
        Me.lblItem5.Name = "lblItem5"
        Me.lblItem5.Size = New System.Drawing.Size(430, 66)
        Me.lblItem5.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(776, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 66)
        Me.Label1.TabIndex = 75
        '
        'lblItem4
        '
        Me.lblItem4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblItem4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItem4.Location = New System.Drawing.Point(776, 456)
        Me.lblItem4.Name = "lblItem4"
        Me.lblItem4.Size = New System.Drawing.Size(430, 66)
        Me.lblItem4.TabIndex = 75
        '
        'lblItem3
        '
        Me.lblItem3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItem3.Location = New System.Drawing.Point(776, 312)
        Me.lblItem3.Name = "lblItem3"
        Me.lblItem3.Size = New System.Drawing.Size(430, 66)
        Me.lblItem3.TabIndex = 74
        '
        'lblItem2
        '
        Me.lblItem2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItem2.Location = New System.Drawing.Point(778, 246)
        Me.lblItem2.Name = "lblItem2"
        Me.lblItem2.Size = New System.Drawing.Size(430, 66)
        Me.lblItem2.TabIndex = 73
        '
        'lblItem1
        '
        Me.lblItem1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItem1.Location = New System.Drawing.Point(778, 173)
        Me.lblItem1.Name = "lblItem1"
        Me.lblItem1.Size = New System.Drawing.Size(430, 66)
        Me.lblItem1.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(781, 684)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 44)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Total: £"
        '
        'txtRemaining
        '
        Me.txtRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemaining.Location = New System.Drawing.Point(422, 564)
        Me.txtRemaining.Name = "txtRemaining"
        Me.txtRemaining.ReadOnly = True
        Me.txtRemaining.Size = New System.Drawing.Size(295, 50)
        Me.txtRemaining.TabIndex = 63
        '
        'txtPaid
        '
        Me.txtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.Location = New System.Drawing.Point(420, 491)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(295, 50)
        Me.txtPaid.TabIndex = 62
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.AutoSize = True
        Me.lblOrderTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderTotal.Location = New System.Drawing.Point(158, 430)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(268, 44)
        Me.lblOrderTotal.TabIndex = 61
        Me.lblOrderTotal.Text = "Order Total: £"
        '
        'txtOrderTotal
        '
        Me.txtOrderTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderTotal.Location = New System.Drawing.Point(420, 421)
        Me.txtOrderTotal.Name = "txtOrderTotal"
        Me.txtOrderTotal.ReadOnly = True
        Me.txtOrderTotal.Size = New System.Drawing.Size(295, 50)
        Me.txtOrderTotal.TabIndex = 60
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(20, 568)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(411, 44)
        Me.lblBalance.TabIndex = 59
        Me.lblBalance.Text = "Balance Remaining: £"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 493)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 44)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Amount Paid:  £"
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"Cash", "Bank Transfer", "Direct Debit ", "Debit Card", "Credit Card"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(419, 274)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(295, 50)
        Me.cmbPaymentMethod.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 44)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Method of Payment:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(772, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(440, 605)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Overview"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(196, 689)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 51)
        Me.btnBack.TabIndex = 47
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(337, 200)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(377, 50)
        Me.dtpDate.TabIndex = 30
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(540, 689)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(172, 48)
        Me.btnNext.TabIndex = 29
        Me.btnNext.Text = "Confirm Order"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 44)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Payment Date:"
        '
        'txtAuthorisation
        '
        Me.txtAuthorisation.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorisation.Location = New System.Drawing.Point(419, 348)
        Me.txtAuthorisation.Name = "txtAuthorisation"
        Me.txtAuthorisation.ReadOnly = True
        Me.txtAuthorisation.Size = New System.Drawing.Size(295, 50)
        Me.txtAuthorisation.TabIndex = 22
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(26, 689)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(154, 51)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(841, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(421, 87)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Payment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOrder
        '
        Me.lblOrder.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOrder.Location = New System.Drawing.Point(420, 0)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(421, 87)
        Me.lblOrder.TabIndex = 6
        Me.lblOrder.Text = "Order"
        Me.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustomer
        '
        Me.lblCustomer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomer.Location = New System.Drawing.Point(0, 0)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(421, 87)
        Me.lblCustomer.TabIndex = 5
        Me.lblCustomer.Text = "Customer"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(62, 349)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(372, 44)
        Me.lblItemName.TabIndex = 16
        Me.lblItemName.Text = "Authorisation Code:"
        '
        'Timer1
        '
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1339, 833)
        Me.Controls.Add(Me.grpMenu)
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpMenu.ResumeLayout(False)
        Me.grpMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMenu As GroupBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnNext As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAuthorisation As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRemaining As TextBox
    Friend WithEvents txtPaid As TextBox
    Friend WithEvents lblOrderTotal As Label
    Friend WithEvents txtOrderTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblItem2 As Label
    Friend WithEvents lblItem1 As Label
    Friend WithEvents lblItem6 As Label
    Friend WithEvents lblItem5 As Label
    Friend WithEvents lblItem4 As Label
    Friend WithEvents lblItem3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtCID As TextBox
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPID As TextBox
    Friend WithEvents lblPaymentID As Label
End Class
