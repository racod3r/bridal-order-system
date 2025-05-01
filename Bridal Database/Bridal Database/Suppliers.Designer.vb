<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblSuppliers = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnPastOrders = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnBrideDetails = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(2470, 43)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(166, 157)
        Me.btnRefresh.TabIndex = 59
        Me.btnRefresh.Text = "↻"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1564, 1457)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(319, 81)
        Me.btnAdd.TabIndex = 58
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblSuppliers
        '
        Me.lblSuppliers.AutoSize = True
        Me.lblSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppliers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSuppliers.Location = New System.Drawing.Point(375, 53)
        Me.lblSuppliers.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSuppliers.Name = "lblSuppliers"
        Me.lblSuppliers.Size = New System.Drawing.Size(603, 147)
        Me.lblSuppliers.TabIndex = 57
        Me.lblSuppliers.Text = "Suppliers"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(1915, 1457)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(368, 81)
        Me.btnEdit.TabIndex = 56
        Me.btnEdit.Text = "Toggle Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(2327, 1457)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(307, 81)
        Me.btnSave.TabIndex = 55
        Me.btnSave.Text = "Save Edit"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        Me.dgvSupplier.AllowUserToResizeRows = False
        Me.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSupplier.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Location = New System.Drawing.Point(400, 229)
        Me.dgvSupplier.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.RowHeadersWidth = 82
        Me.dgvSupplier.Size = New System.Drawing.Size(2236, 1169)
        Me.dgvSupplier.TabIndex = 54
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(1, 1361)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(6)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(338, 258)
        Me.btnReport.TabIndex = 65
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.Location = New System.Drawing.Point(1, 1081)
        Me.btnSupplier.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(338, 279)
        Me.btnSupplier.TabIndex = 64
        Me.btnSupplier.Text = "Suppliers"
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'btnPastOrders
        '
        Me.btnPastOrders.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPastOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPastOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastOrders.Location = New System.Drawing.Point(1, 532)
        Me.btnPastOrders.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPastOrders.Name = "btnPastOrders"
        Me.btnPastOrders.Size = New System.Drawing.Size(338, 273)
        Me.btnPastOrders.TabIndex = 63
        Me.btnPastOrders.Text = "Past Orders"
        Me.btnPastOrders.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Location = New System.Drawing.Point(1, 805)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(338, 276)
        Me.btnPayment.TabIndex = 62
        Me.btnPayment.Text = "Payment History"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnBrideDetails
        '
        Me.btnBrideDetails.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBrideDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrideDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrideDetails.Location = New System.Drawing.Point(1, 259)
        Me.btnBrideDetails.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBrideDetails.Name = "btnBrideDetails"
        Me.btnBrideDetails.Size = New System.Drawing.Size(338, 273)
        Me.btnBrideDetails.TabIndex = 61
        Me.btnBrideDetails.Text = "Bride Details"
        Me.btnBrideDetails.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(1, 0)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(6)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(338, 259)
        Me.btnHome.TabIndex = 60
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2693, 1619)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.btnPastOrders)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnBrideDetails)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSuppliers)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvSupplier)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Suppliers"
        Me.Text = "Suppliers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblSuppliers As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents btnReport As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnPastOrders As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnBrideDetails As Button
    Friend WithEvents btnHome As Button
End Class
