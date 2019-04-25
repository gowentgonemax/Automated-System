<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegisteration
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbtnCakeNo = New System.Windows.Forms.RadioButton()
        Me.rdbtnCakeYes = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdCouponNo = New System.Windows.Forms.RadioButton()
        Me.rdCouponYes = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbNumberOfChildren = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.txtBoxLastName = New System.Windows.Forms.TextBox()
        Me.cbAdult = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkOthers = New System.Windows.Forms.CheckBox()
        Me.chkGettogether = New System.Windows.Forms.CheckBox()
        Me.chkMarriage = New System.Windows.Forms.CheckBox()
        Me.chkGraduation = New System.Windows.Forms.CheckBox()
        Me.chkPromotion = New System.Windows.Forms.CheckBox()
        Me.chkBirthday = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 533)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Gray
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Location = New System.Drawing.Point(94, 364)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(375, 105)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Coupon Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbtnCakeNo)
        Me.GroupBox2.Controls.Add(Me.rdbtnCakeYes)
        Me.GroupBox2.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(214, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 63)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Message On cake ?"
        '
        'rdbtnCakeNo
        '
        Me.rdbtnCakeNo.AutoSize = True
        Me.rdbtnCakeNo.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnCakeNo.Location = New System.Drawing.Point(79, 32)
        Me.rdbtnCakeNo.Name = "rdbtnCakeNo"
        Me.rdbtnCakeNo.Size = New System.Drawing.Size(45, 21)
        Me.rdbtnCakeNo.TabIndex = 0
        Me.rdbtnCakeNo.TabStop = True
        Me.rdbtnCakeNo.Text = "No"
        Me.rdbtnCakeNo.UseVisualStyleBackColor = True
        '
        'rdbtnCakeYes
        '
        Me.rdbtnCakeYes.AutoSize = True
        Me.rdbtnCakeYes.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnCakeYes.Location = New System.Drawing.Point(24, 32)
        Me.rdbtnCakeYes.Name = "rdbtnCakeYes"
        Me.rdbtnCakeYes.Size = New System.Drawing.Size(50, 21)
        Me.rdbtnCakeYes.TabIndex = 0
        Me.rdbtnCakeYes.TabStop = True
        Me.rdbtnCakeYes.Text = "Yes"
        Me.rdbtnCakeYes.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdCouponNo)
        Me.GroupBox6.Controls.Add(Me.rdCouponYes)
        Me.GroupBox6.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(187, 63)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Do you have coupon code?"
        '
        'rdCouponNo
        '
        Me.rdCouponNo.AutoSize = True
        Me.rdCouponNo.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCouponNo.Location = New System.Drawing.Point(79, 32)
        Me.rdCouponNo.Name = "rdCouponNo"
        Me.rdCouponNo.Size = New System.Drawing.Size(45, 21)
        Me.rdCouponNo.TabIndex = 0
        Me.rdCouponNo.TabStop = True
        Me.rdCouponNo.Text = "No"
        Me.rdCouponNo.UseVisualStyleBackColor = True
        '
        'rdCouponYes
        '
        Me.rdCouponYes.AutoSize = True
        Me.rdCouponYes.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCouponYes.Location = New System.Drawing.Point(24, 32)
        Me.rdCouponYes.Name = "rdCouponYes"
        Me.rdCouponYes.Size = New System.Drawing.Size(50, 21)
        Me.rdCouponYes.TabIndex = 0
        Me.rdCouponYes.TabStop = True
        Me.rdCouponYes.Text = "Yes"
        Me.rdCouponYes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.Controls.Add(Me.cbNumberOfChildren)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtBoxEmail)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtBoxFirstName)
        Me.GroupBox3.Controls.Add(Me.txtBoxLastName)
        Me.GroupBox3.Controls.Add(Me.cbAdult)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtBoxPhone)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(94, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 181)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Persoanl Information"
        '
        'cbNumberOfChildren
        '
        Me.cbNumberOfChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNumberOfChildren.FormattingEnabled = True
        Me.cbNumberOfChildren.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.cbNumberOfChildren.Location = New System.Drawing.Point(277, 147)
        Me.cbNumberOfChildren.Name = "cbNumberOfChildren"
        Me.cbNumberOfChildren.Size = New System.Drawing.Size(41, 21)
        Me.cbNumberOfChildren.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Adult:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "First Name"
        '
        'txtBoxEmail
        '
        Me.txtBoxEmail.Location = New System.Drawing.Point(151, 116)
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.Size = New System.Drawing.Size(125, 20)
        Me.txtBoxEmail.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "EMail-ID"
        '
        'txtBoxFirstName
        '
        Me.txtBoxFirstName.Location = New System.Drawing.Point(151, 17)
        Me.txtBoxFirstName.Name = "txtBoxFirstName"
        Me.txtBoxFirstName.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxFirstName.TabIndex = 0
        '
        'txtBoxLastName
        '
        Me.txtBoxLastName.Location = New System.Drawing.Point(151, 50)
        Me.txtBoxLastName.Name = "txtBoxLastName"
        Me.txtBoxLastName.Size = New System.Drawing.Size(125, 20)
        Me.txtBoxLastName.TabIndex = 2
        '
        'cbAdult
        '
        Me.cbAdult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAdult.FormattingEnabled = True
        Me.cbAdult.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.cbAdult.Location = New System.Drawing.Point(151, 147)
        Me.cbAdult.Name = "cbAdult"
        Me.cbAdult.Size = New System.Drawing.Size(42, 21)
        Me.cbAdult.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Phone Number:"
        '
        'txtBoxPhone
        '
        Me.txtBoxPhone.Location = New System.Drawing.Point(151, 85)
        Me.txtBoxPhone.Name = "txtBoxPhone"
        Me.txtBoxPhone.Size = New System.Drawing.Size(125, 20)
        Me.txtBoxPhone.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Children:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.chkOthers)
        Me.GroupBox1.Controls.Add(Me.chkGettogether)
        Me.GroupBox1.Controls.Add(Me.chkMarriage)
        Me.GroupBox1.Controls.Add(Me.chkGraduation)
        Me.GroupBox1.Controls.Add(Me.chkPromotion)
        Me.GroupBox1.Controls.Add(Me.chkBirthday)
        Me.GroupBox1.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(94, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dining Reason"
        '
        'chkOthers
        '
        Me.chkOthers.AutoSize = True
        Me.chkOthers.Location = New System.Drawing.Point(204, 81)
        Me.chkOthers.Name = "chkOthers"
        Me.chkOthers.Size = New System.Drawing.Size(72, 21)
        Me.chkOthers.TabIndex = 5
        Me.chkOthers.Text = "others"
        Me.chkOthers.UseVisualStyleBackColor = True
        '
        'chkGettogether
        '
        Me.chkGettogether.AutoSize = True
        Me.chkGettogether.Location = New System.Drawing.Point(204, 54)
        Me.chkGettogether.Name = "chkGettogether"
        Me.chkGettogether.Size = New System.Drawing.Size(117, 21)
        Me.chkGettogether.TabIndex = 4
        Me.chkGettogether.Text = "Get-together"
        Me.chkGettogether.UseVisualStyleBackColor = True
        '
        'chkMarriage
        '
        Me.chkMarriage.AutoSize = True
        Me.chkMarriage.Location = New System.Drawing.Point(20, 81)
        Me.chkMarriage.Name = "chkMarriage"
        Me.chkMarriage.Size = New System.Drawing.Size(174, 21)
        Me.chkMarriage.TabIndex = 2
        Me.chkMarriage.Text = "Marriage Anniversery"
        Me.chkMarriage.UseVisualStyleBackColor = True
        '
        'chkGraduation
        '
        Me.chkGraduation.AutoSize = True
        Me.chkGraduation.Location = New System.Drawing.Point(204, 27)
        Me.chkGraduation.Name = "chkGraduation"
        Me.chkGraduation.Size = New System.Drawing.Size(104, 21)
        Me.chkGraduation.TabIndex = 3
        Me.chkGraduation.Text = "Graduation"
        Me.chkGraduation.UseVisualStyleBackColor = True
        '
        'chkPromotion
        '
        Me.chkPromotion.AutoSize = True
        Me.chkPromotion.Location = New System.Drawing.Point(20, 54)
        Me.chkPromotion.Name = "chkPromotion"
        Me.chkPromotion.Size = New System.Drawing.Size(98, 21)
        Me.chkPromotion.TabIndex = 1
        Me.chkPromotion.Text = "Promotion"
        Me.chkPromotion.UseVisualStyleBackColor = True
        '
        'chkBirthday
        '
        Me.chkBirthday.AutoSize = True
        Me.chkBirthday.Location = New System.Drawing.Point(20, 27)
        Me.chkBirthday.Name = "chkBirthday"
        Me.chkBirthday.Size = New System.Drawing.Size(129, 21)
        Me.chkBirthday.TabIndex = 0
        Me.chkBirthday.Text = "BirthDay party"
        Me.chkBirthday.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(331, 490)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 33)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(224, 490)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(101, 33)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Yu Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(117, 490)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 33)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next>>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(88, 481)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 52)
        Me.Panel2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(107, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Customer Registeration"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDate.Font = New System.Drawing.Font("Yu Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Gray
        Me.lblDate.Location = New System.Drawing.Point(371, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(57, 19)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "-Date-"
        '
        'FormRegisteration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 533)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRegisteration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seating"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkOthers As CheckBox
    Friend WithEvents chkGettogether As CheckBox
    Friend WithEvents chkMarriage As CheckBox
    Friend WithEvents chkGraduation As CheckBox
    Friend WithEvents chkPromotion As CheckBox
    Friend WithEvents chkBirthday As CheckBox
    Friend WithEvents lblDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rdCouponNo As RadioButton
    Friend WithEvents rdCouponYes As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbtnCakeNo As RadioButton
    Friend WithEvents rdbtnCakeYes As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbNumberOfChildren As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents txtBoxLastName As TextBox
    Friend WithEvents cbAdult As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxPhone As TextBox
    Friend WithEvents Label4 As Label
End Class
