<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewTransaction
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PesanansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.penjualanDataSet = New PenjualanHP.penjualanDataSet()
        Me.rv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnViewTransaction = New System.Windows.Forms.Button()
        Me.btnManageBarang = New System.Windows.Forms.Button()
        Me.btnManageUser = New System.Windows.Forms.Button()
        Me.PesanansTableAdapter = New PenjualanHP.penjualanDataSetTableAdapters.PesanansTableAdapter()
        CType(Me.PesanansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.penjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PesanansBindingSource
        '
        Me.PesanansBindingSource.DataMember = "Pesanans"
        Me.PesanansBindingSource.DataSource = Me.penjualanDataSet
        '
        'penjualanDataSet
        '
        Me.penjualanDataSet.DataSetName = "penjualanDataSet"
        Me.penjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rv
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.PesanansBindingSource
        Me.rv.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rv.LocalReport.ReportEmbeddedResource = "PenjualanHP.Report1.rdlc"
        Me.rv.Location = New System.Drawing.Point(182, 116)
        Me.rv.Name = "rv"
        Me.rv.ShowBackButton = False
        Me.rv.ShowPageNavigationControls = False
        Me.rv.ShowStopButton = False
        Me.rv.Size = New System.Drawing.Size(656, 347)
        Me.rv.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(591, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CV OKE CELL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(428, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 25)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "View Transaction"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(853, 56)
        Me.Panel1.TabIndex = 52
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Location = New System.Drawing.Point(757, 0)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(96, 56)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnViewTransaction)
        Me.Panel2.Controls.Add(Me.btnManageBarang)
        Me.Panel2.Controls.Add(Me.btnManageUser)
        Me.Panel2.Location = New System.Drawing.Point(-1, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 427)
        Me.Panel2.TabIndex = 55
        '
        'btnViewTransaction
        '
        Me.btnViewTransaction.BackColor = System.Drawing.Color.Lime
        Me.btnViewTransaction.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnViewTransaction.FlatAppearance.BorderSize = 3
        Me.btnViewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTransaction.Location = New System.Drawing.Point(10, 129)
        Me.btnViewTransaction.Margin = New System.Windows.Forms.Padding(0)
        Me.btnViewTransaction.Name = "btnViewTransaction"
        Me.btnViewTransaction.Size = New System.Drawing.Size(146, 40)
        Me.btnViewTransaction.TabIndex = 2
        Me.btnViewTransaction.Text = "View Transaction"
        Me.btnViewTransaction.UseVisualStyleBackColor = False
        '
        'btnManageBarang
        '
        Me.btnManageBarang.BackColor = System.Drawing.Color.Lime
        Me.btnManageBarang.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnManageBarang.FlatAppearance.BorderSize = 0
        Me.btnManageBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageBarang.Location = New System.Drawing.Point(10, 73)
        Me.btnManageBarang.Margin = New System.Windows.Forms.Padding(0)
        Me.btnManageBarang.Name = "btnManageBarang"
        Me.btnManageBarang.Size = New System.Drawing.Size(146, 40)
        Me.btnManageBarang.TabIndex = 1
        Me.btnManageBarang.Text = "Manage Barang"
        Me.btnManageBarang.UseVisualStyleBackColor = False
        '
        'btnManageUser
        '
        Me.btnManageUser.BackColor = System.Drawing.Color.Lime
        Me.btnManageUser.FlatAppearance.BorderSize = 0
        Me.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUser.Location = New System.Drawing.Point(10, 17)
        Me.btnManageUser.Margin = New System.Windows.Forms.Padding(0)
        Me.btnManageUser.Name = "btnManageUser"
        Me.btnManageUser.Size = New System.Drawing.Size(146, 40)
        Me.btnManageUser.TabIndex = 0
        Me.btnManageUser.Text = "Manage User"
        Me.btnManageUser.UseVisualStyleBackColor = False
        '
        'PesanansTableAdapter
        '
        Me.PesanansTableAdapter.ClearBeforeFill = True
        '
        'ViewTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(850, 482)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rv)
        Me.Name = "ViewTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewTransaction"
        CType(Me.PesanansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.penjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rv As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PesanansBindingSource As BindingSource
    Friend WithEvents penjualanDataSet As penjualanDataSet
    Friend WithEvents PesanansTableAdapter As penjualanDataSetTableAdapters.PesanansTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnViewTransaction As Button
    Friend WithEvents btnManageBarang As Button
    Friend WithEvents btnManageUser As Button
    Friend WithEvents btnLogout As Button
End Class
