<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.cmbMonths = New System.Windows.Forms.ComboBox()
        Me.lblSelectedMonthsSavings = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAverageMonthly = New System.Windows.Forms.Label()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.lblGreatestSavings = New System.Windows.Forms.Label()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(119, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(367, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Smart Home Savings"
        '
        'picMain
        '
        Me.picMain.Image = CType(resources.GetObject("picMain.Image"), System.Drawing.Image)
        Me.picMain.Location = New System.Drawing.Point(12, 12)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(376, 263)
        Me.picMain.TabIndex = 1
        Me.picMain.TabStop = False
        '
        'cmbMonths
        '
        Me.cmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonths.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonths.FormattingEnabled = True
        Me.cmbMonths.Location = New System.Drawing.Point(218, 61)
        Me.cmbMonths.Name = "cmbMonths"
        Me.cmbMonths.Size = New System.Drawing.Size(168, 29)
        Me.cmbMonths.TabIndex = 2
        '
        'lblSelectedMonthsSavings
        '
        Me.lblSelectedMonthsSavings.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedMonthsSavings.Location = New System.Drawing.Point(11, 123)
        Me.lblSelectedMonthsSavings.Name = "lblSelectedMonthsSavings"
        Me.lblSelectedMonthsSavings.Size = New System.Drawing.Size(591, 38)
        Me.lblSelectedMonthsSavings.TabIndex = 3
        Me.lblSelectedMonthsSavings.Text = "Placeholder"
        Me.lblSelectedMonthsSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSelectedMonthsSavings.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblGreatestSavings)
        Me.Panel1.Controls.Add(Me.btnStats)
        Me.Panel1.Controls.Add(Me.lblAverageMonthly)
        Me.Panel1.Controls.Add(Me.lblSelectedMonthsSavings)
        Me.Panel1.Controls.Add(Me.cmbMonths)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(401, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 408)
        Me.Panel1.TabIndex = 4
        '
        'lblAverageMonthly
        '
        Me.lblAverageMonthly.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageMonthly.Location = New System.Drawing.Point(3, 265)
        Me.lblAverageMonthly.Name = "lblAverageMonthly"
        Me.lblAverageMonthly.Size = New System.Drawing.Size(599, 38)
        Me.lblAverageMonthly.TabIndex = 4
        Me.lblAverageMonthly.Text = "Placeholder"
        Me.lblAverageMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAverageMonthly.Visible = False
        '
        'btnStats
        '
        Me.btnStats.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.Location = New System.Drawing.Point(200, 194)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(205, 38)
        Me.btnStats.TabIndex = 5
        Me.btnStats.Text = "Display Statistics"
        Me.btnStats.UseVisualStyleBackColor = True
        Me.btnStats.Visible = False
        '
        'lblGreatestSavings
        '
        Me.lblGreatestSavings.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreatestSavings.Location = New System.Drawing.Point(11, 317)
        Me.lblGreatestSavings.Name = "lblGreatestSavings"
        Me.lblGreatestSavings.Size = New System.Drawing.Size(591, 91)
        Me.lblGreatestSavings.TabIndex = 6
        Me.lblGreatestSavings.Text = "Placeholder"
        Me.lblGreatestSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGreatestSavings.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 432)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picMain)
        Me.Name = "frmMain"
        Me.Text = "Smart Home Savings"
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picMain As PictureBox
    Friend WithEvents cmbMonths As ComboBox
    Friend WithEvents lblSelectedMonthsSavings As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGreatestSavings As Label
    Friend WithEvents btnStats As Button
    Friend WithEvents lblAverageMonthly As Label
End Class
