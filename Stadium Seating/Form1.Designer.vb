<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClassATS = New System.Windows.Forms.TextBox()
        Me.txtClassBTS = New System.Windows.Forms.TextBox()
        Me.txtClassCTS = New System.Windows.Forms.TextBox()
        Me.txtClassARG = New System.Windows.Forms.TextBox()
        Me.txtClassBRG = New System.Windows.Forms.TextBox()
        Me.txtClassCRG = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalRev = New System.Windows.Forms.TextBox()
        Me.btnCalculateRv = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClassCTS)
        Me.GroupBox1.Controls.Add(Me.txtClassBTS)
        Me.GroupBox1.Controls.Add(Me.txtClassATS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 325)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of tickets sold for each class seats"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Class A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Class B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Class C"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalRev)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtClassCRG)
        Me.GroupBox2.Controls.Add(Me.txtClassBRG)
        Me.GroupBox2.Controls.Add(Me.txtClassARG)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(465, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 311)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue generated"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Class A"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Class B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Class C"
        '
        'txtClassATS
        '
        Me.txtClassATS.Location = New System.Drawing.Point(142, 95)
        Me.txtClassATS.Name = "txtClassATS"
        Me.txtClassATS.Size = New System.Drawing.Size(154, 30)
        Me.txtClassATS.TabIndex = 4
        '
        'txtClassBTS
        '
        Me.txtClassBTS.Location = New System.Drawing.Point(142, 161)
        Me.txtClassBTS.Name = "txtClassBTS"
        Me.txtClassBTS.Size = New System.Drawing.Size(154, 30)
        Me.txtClassBTS.TabIndex = 5
        '
        'txtClassCTS
        '
        Me.txtClassCTS.Location = New System.Drawing.Point(142, 228)
        Me.txtClassCTS.Name = "txtClassCTS"
        Me.txtClassCTS.Size = New System.Drawing.Size(154, 30)
        Me.txtClassCTS.TabIndex = 6
        '
        'txtClassARG
        '
        Me.txtClassARG.Location = New System.Drawing.Point(201, 82)
        Me.txtClassARG.Name = "txtClassARG"
        Me.txtClassARG.Size = New System.Drawing.Size(166, 30)
        Me.txtClassARG.TabIndex = 3
        '
        'txtClassBRG
        '
        Me.txtClassBRG.Location = New System.Drawing.Point(201, 152)
        Me.txtClassBRG.Name = "txtClassBRG"
        Me.txtClassBRG.Size = New System.Drawing.Size(166, 30)
        Me.txtClassBRG.TabIndex = 4
        '
        'txtClassCRG
        '
        Me.txtClassCRG.Location = New System.Drawing.Point(201, 220)
        Me.txtClassCRG.Name = "txtClassCRG"
        Me.txtClassCRG.Size = New System.Drawing.Size(166, 30)
        Me.txtClassCRG.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Revenue"
        '
        'txtTotalRev
        '
        Me.txtTotalRev.Location = New System.Drawing.Point(201, 266)
        Me.txtTotalRev.Name = "txtTotalRev"
        Me.txtTotalRev.Size = New System.Drawing.Size(166, 30)
        Me.txtTotalRev.TabIndex = 7
        '
        'btnCalculateRv
        '
        Me.btnCalculateRv.Location = New System.Drawing.Point(12, 392)
        Me.btnCalculateRv.Name = "btnCalculateRv"
        Me.btnCalculateRv.Size = New System.Drawing.Size(135, 34)
        Me.btnCalculateRv.TabIndex = 8
        Me.btnCalculateRv.Text = "Calculate Revenue"
        Me.btnCalculateRv.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(259, 392)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(465, 392)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 34)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 468)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateRv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClassCTS As TextBox
    Friend WithEvents txtClassBTS As TextBox
    Friend WithEvents txtClassATS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalRev As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtClassCRG As TextBox
    Friend WithEvents txtClassBRG As TextBox
    Friend WithEvents txtClassARG As TextBox
    Friend WithEvents btnCalculateRv As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
