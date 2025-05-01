<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class orderSearch
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
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.lblQuickSearch = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radNot = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMaxPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMinPrice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMaxTotal = New System.Windows.Forms.TextBox()
        Me.txtMaxDiscount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaxQuantity = New System.Windows.Forms.TextBox()
        Me.txtMinDiscount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMinTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMinQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.cmbItemName = New System.Windows.Forms.ComboBox()
        Me.radHire = New System.Windows.Forms.RadioButton()
        Me.cmbDesigner = New System.Windows.Forms.ComboBox()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.radStock = New System.Windows.Forms.RadioButton()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.grpMenu.TabIndex = 4
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
        Me.GroupBox2.Controls.Add(Me.radNot)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.txtColour)
        Me.GroupBox2.Controls.Add(Me.cmbItemName)
        Me.GroupBox2.Controls.Add(Me.radHire)
        Me.GroupBox2.Controls.Add(Me.cmbDesigner)
        Me.GroupBox2.Controls.Add(Me.cmbItemType)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.radStock)
        Me.GroupBox2.Controls.Add(Me.cmbSize)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label3)
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
        'radNot
        '
        Me.radNot.AutoSize = True
        Me.radNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNot.Location = New System.Drawing.Point(1507, 901)
        Me.radNot.Margin = New System.Windows.Forms.Padding(6)
        Me.radNot.Name = "radNot"
        Me.radNot.Size = New System.Drawing.Size(403, 89)
        Me.radNot.TabIndex = 90
        Me.radNot.TabStop = True
        Me.radNot.Text = "Not Stock"
        Me.radNot.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtMaxPrice)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtMinPrice)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtMaxTotal)
        Me.Panel1.Controls.Add(Me.txtMaxDiscount)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtMaxQuantity)
        Me.Panel1.Controls.Add(Me.txtMinDiscount)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtMinTotal)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtMinQuantity)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(1188, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1316, 754)
        Me.Panel1.TabIndex = 96
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(886, 17)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(204, 85)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "Max:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(488, 17)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 85)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Min:"
        '
        'txtMaxPrice
        '
        Me.txtMaxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxPrice.Location = New System.Drawing.Point(901, 108)
        Me.txtMaxPrice.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMaxPrice.Name = "txtMaxPrice"
        Me.txtMaxPrice.Size = New System.Drawing.Size(327, 92)
        Me.txtMaxPrice.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(420, 115)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 85)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "£"
        '
        'txtMinPrice
        '
        Me.txtMinPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinPrice.Location = New System.Drawing.Point(503, 108)
        Me.txtMinPrice.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMinPrice.Name = "txtMinPrice"
        Me.txtMinPrice.Size = New System.Drawing.Size(307, 92)
        Me.txtMinPrice.TabIndex = 99
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(41, 115)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(394, 85)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Price(AD):"
        '
        'txtMaxTotal
        '
        Me.txtMaxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxTotal.Location = New System.Drawing.Point(901, 259)
        Me.txtMaxTotal.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMaxTotal.Name = "txtMaxTotal"
        Me.txtMaxTotal.Size = New System.Drawing.Size(327, 92)
        Me.txtMaxTotal.TabIndex = 97
        '
        'txtMaxDiscount
        '
        Me.txtMaxDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxDiscount.Location = New System.Drawing.Point(901, 420)
        Me.txtMaxDiscount.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMaxDiscount.Name = "txtMaxDiscount"
        Me.txtMaxDiscount.Size = New System.Drawing.Size(170, 92)
        Me.txtMaxDiscount.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1079, 423)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 85)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "%"
        '
        'txtMaxQuantity
        '
        Me.txtMaxQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxQuantity.Location = New System.Drawing.Point(901, 600)
        Me.txtMaxQuantity.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMaxQuantity.Name = "txtMaxQuantity"
        Me.txtMaxQuantity.Size = New System.Drawing.Size(170, 92)
        Me.txtMaxQuantity.TabIndex = 94
        '
        'txtMinDiscount
        '
        Me.txtMinDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinDiscount.Location = New System.Drawing.Point(503, 417)
        Me.txtMinDiscount.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMinDiscount.Name = "txtMinDiscount"
        Me.txtMinDiscount.Size = New System.Drawing.Size(170, 92)
        Me.txtMinDiscount.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(672, 424)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 85)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "%"
        '
        'txtMinTotal
        '
        Me.txtMinTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinTotal.Location = New System.Drawing.Point(503, 259)
        Me.txtMinTotal.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMinTotal.Name = "txtMinTotal"
        Me.txtMinTotal.Size = New System.Drawing.Size(307, 92)
        Me.txtMinTotal.TabIndex = 83
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(114, 600)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(348, 85)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Quantity:"
        '
        'txtMinQuantity
        '
        Me.txtMinQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinQuantity.Location = New System.Drawing.Point(503, 600)
        Me.txtMinQuantity.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMinQuantity.Name = "txtMinQuantity"
        Me.txtMinQuantity.Size = New System.Drawing.Size(168, 92)
        Me.txtMinQuantity.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 423)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 85)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Discount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(167, 266)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 85)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(411, 266)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 85)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "£"
        '
        'txtColour
        '
        Me.txtColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColour.Location = New System.Drawing.Point(463, 307)
        Me.txtColour.Margin = New System.Windows.Forms.Padding(6)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(539, 92)
        Me.txtColour.TabIndex = 94
        '
        'cmbItemName
        '
        Me.cmbItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemName.FormattingEnabled = True
        Me.cmbItemName.Location = New System.Drawing.Point(463, 1035)
        Me.cmbItemName.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Size = New System.Drawing.Size(686, 93)
        Me.cmbItemName.TabIndex = 87
        '
        'radHire
        '
        Me.radHire.AutoSize = True
        Me.radHire.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHire.Location = New System.Drawing.Point(1964, 901)
        Me.radHire.Margin = New System.Windows.Forms.Padding(6)
        Me.radHire.Name = "radHire"
        Me.radHire.Size = New System.Drawing.Size(210, 89)
        Me.radHire.TabIndex = 91
        Me.radHire.TabStop = True
        Me.radHire.Text = "Hire"
        Me.radHire.UseVisualStyleBackColor = True
        '
        'cmbDesigner
        '
        Me.cmbDesigner.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDesigner.FormattingEnabled = True
        Me.cmbDesigner.Items.AddRange(New Object() {"Maggie Sottero", "Sottero and midgley", "Pronovias", "Allure", "Bridha privè", "Richard Designs", "Jupon", "Carringtons", "Alberto Palatchi", "Queen"})
        Me.cmbDesigner.Location = New System.Drawing.Point(463, 850)
        Me.cmbDesigner.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbDesigner.Name = "cmbDesigner"
        Me.cmbDesigner.Size = New System.Drawing.Size(686, 93)
        Me.cmbDesigner.TabIndex = 86
        '
        'cmbItemType
        '
        Me.cmbItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Items.AddRange(New Object() {"Bridal Gown", "Bridesmaid Dress", "Veil", "Tiara", "Belt", "Hoop", "Fabric", "Jewellery", "Cape", "Jacket", "Miscellaneous"})
        Me.cmbItemType.Location = New System.Drawing.Point(463, 669)
        Me.cmbItemType.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(686, 93)
        Me.cmbItemType.TabIndex = 85
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(172, 134)
        Me.lblID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(491, 85)
        Me.lblID.TabIndex = 88
        Me.lblID.Text = "Customer ID:"
        '
        'radStock
        '
        Me.radStock.AutoSize = True
        Me.radStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStock.Location = New System.Drawing.Point(1188, 901)
        Me.radStock.Margin = New System.Windows.Forms.Padding(6)
        Me.radStock.Name = "radStock"
        Me.radStock.Size = New System.Drawing.Size(262, 89)
        Me.radStock.TabIndex = 73
        Me.radStock.TabStop = True
        Me.radStock.Text = "Stock"
        Me.radStock.UseVisualStyleBackColor = True
        '
        'cmbSize
        '
        Me.cmbSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Items.AddRange(New Object() {"TBD", "UK 0", "UK 2 ", "UK 4", "UK 6", "UK 8", "UK 10", "UK 12", "UK 14", "UK 16", "UK 18", "UK 20", "UK 22", "UK 24", "UK 26", "UK 28", "UK 30", "UK 32"})
        Me.cmbSize.Location = New System.Drawing.Point(464, 490)
        Me.cmbSize.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(330, 93)
        Me.cmbSize.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(265, 493)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 85)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 1043)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(434, 85)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Item Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 850)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 85)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Designer:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(70, 677)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(402, 85)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Item Type:"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(672, 134)
        Me.txtID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(330, 92)
        Me.txtID.TabIndex = 95
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 314)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 85)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Colour:"
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
        Me.lblCustomers.Size = New System.Drawing.Size(273, 85)
        Me.lblCustomers.TabIndex = 7
        Me.lblCustomers.Text = "Orders"
        '
        'orderSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2693, 1619)
        Me.Controls.Add(Me.grpMenu)
        Me.Name = "orderSearch"
        Me.Text = "orderSearch"
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
    Friend WithEvents radNot As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMaxPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMinPrice As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMaxTotal As TextBox
    Friend WithEvents txtMaxDiscount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMaxQuantity As TextBox
    Friend WithEvents txtMinDiscount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMinTotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMinQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtColour As TextBox
    Friend WithEvents cmbItemName As ComboBox
    Friend WithEvents radHire As RadioButton
    Friend WithEvents cmbDesigner As ComboBox
    Friend WithEvents cmbItemType As ComboBox
    Friend WithEvents lblID As Label
    Friend WithEvents radStock As RadioButton
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
End Class
