<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment_History
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblPastOrders = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvPayment = New System.Windows.Forms.DataGridView()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnPastOrders = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnBrideDetails = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(400, 1457)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(448, 81)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Search Filters"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(2470, 43)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(166, 157)
        Me.btnRefresh.TabIndex = 46
        Me.btnRefresh.Text = "↻"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1564, 1457)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(319, 81)
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblPastOrders
        '
        Me.lblPastOrders.AutoSize = True
        Me.lblPastOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastOrders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPastOrders.Location = New System.Drawing.Point(375, 53)
        Me.lblPastOrders.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPastOrders.Name = "lblPastOrders"
        Me.lblPastOrders.Size = New System.Drawing.Size(1014, 147)
        Me.lblPastOrders.TabIndex = 44
        Me.lblPastOrders.Text = "Payment History"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(1915, 1457)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(368, 81)
        Me.btnEdit.TabIndex = 43
        Me.btnEdit.Text = "Toggle Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(2327, 1457)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(307, 81)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "Save Edit"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'dgvPayment
        '
        Me.dgvPayment.AllowUserToAddRows = False
        Me.dgvPayment.AllowUserToDeleteRows = False
        Me.dgvPayment.AllowUserToResizeRows = False
        Me.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPayment.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayment.Location = New System.Drawing.Point(400, 229)
        Me.dgvPayment.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvPayment.Name = "dgvPayment"
        Me.dgvPayment.ReadOnly = True
        Me.dgvPayment.RowHeadersWidth = 82
        Me.dgvPayment.Size = New System.Drawing.Size(2236, 1169)
        Me.dgvPayment.TabIndex = 41
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.Location = New System.Drawing.Point(0, 1080)
        Me.btnSupplier.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(338, 279)
        Me.btnSupplier.TabIndex = 40
        Me.btnSupplier.Text = "Suppliers"
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'btnPastOrders
        '
        Me.btnPastOrders.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPastOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPastOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastOrders.Location = New System.Drawing.Point(0, 531)
        Me.btnPastOrders.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnPastOrders.Name = "btnPastOrders"
        Me.btnPastOrders.Size = New System.Drawing.Size(338, 273)
        Me.btnPastOrders.TabIndex = 39
        Me.btnPastOrders.Text = "Past Orders"
        Me.btnPastOrders.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Location = New System.Drawing.Point(0, 804)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(338, 276)
        Me.btnPayment.TabIndex = 38
        Me.btnPayment.Text = "Payment History"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnBrideDetails
        '
        Me.btnBrideDetails.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBrideDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrideDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrideDetails.Location = New System.Drawing.Point(0, 258)
        Me.btnBrideDetails.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnBrideDetails.Name = "btnBrideDetails"
        Me.btnBrideDetails.Size = New System.Drawing.Size(338, 273)
        Me.btnBrideDetails.TabIndex = 37
        Me.btnBrideDetails.Text = "Bride Details"
        Me.btnBrideDetails.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(0, -1)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(338, 259)
        Me.btnHome.TabIndex = 36
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(0, 1360)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(338, 258)
        Me.btnReport.TabIndex = 48
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'Payment_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2693, 1619)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblPastOrders)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvPayment)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.btnPastOrders)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnBrideDetails)
        Me.Controls.Add(Me.btnHome)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Payment_History"
        Me.Text = "Payment_History"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblPastOrders As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvPayment As DataGridView
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnPastOrders As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnBrideDetails As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnReport As Button
End Class
