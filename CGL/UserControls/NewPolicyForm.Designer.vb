<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPolicyForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPolicy = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtLine = New System.Windows.Forms.TextBox()
        Me.dtExpiration = New System.Windows.Forms.DateTimePicker()
        Me.dtInception = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCompany = New System.Windows.Forms.ComboBox()
        Me.cbBarangay = New System.Windows.Forms.ComboBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtStamp = New System.Windows.Forms.TextBox()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.txtPremium = New System.Windows.Forms.TextBox()
        Me.txtLGT = New System.Windows.Forms.TextBox()
        Me.txtLiability = New System.Windows.Forms.TextBox()
        Me.txtEVAT = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPrintOR = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPolicyNumber = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Company Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Policy Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Inception"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Expiration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Street / Building"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Barangay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 21)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Line of Business"
        '
        'txtPolicy
        '
        Me.txtPolicy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPolicy.Location = New System.Drawing.Point(143, 56)
        Me.txtPolicy.Name = "txtPolicy"
        Me.txtPolicy.ReadOnly = True
        Me.txtPolicy.Size = New System.Drawing.Size(387, 29)
        Me.txtPolicy.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(143, 91)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(387, 29)
        Me.txtName.TabIndex = 1
        '
        'txtStreet
        '
        Me.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreet.Location = New System.Drawing.Point(144, 202)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(387, 29)
        Me.txtStreet.TabIndex = 1
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Location = New System.Drawing.Point(144, 272)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(172, 29)
        Me.txtCity.TabIndex = 1
        Me.txtCity.Text = "TAGUIG CITY"
        '
        'txtLine
        '
        Me.txtLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLine.Location = New System.Drawing.Point(144, 307)
        Me.txtLine.Name = "txtLine"
        Me.txtLine.Size = New System.Drawing.Size(387, 29)
        Me.txtLine.TabIndex = 1
        '
        'dtExpiration
        '
        Me.dtExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtExpiration.Location = New System.Drawing.Point(142, 165)
        Me.dtExpiration.Name = "dtExpiration"
        Me.dtExpiration.Size = New System.Drawing.Size(272, 29)
        Me.dtExpiration.TabIndex = 11
        '
        'dtInception
        '
        Me.dtInception.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtInception.Location = New System.Drawing.Point(142, 126)
        Me.dtInception.Name = "dtInception"
        Me.dtInception.Size = New System.Drawing.Size(272, 29)
        Me.dtInception.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.txtCompany)
        Me.Panel1.Controls.Add(Me.cbBarangay)
        Me.Panel1.Controls.Add(Me.dtInception)
        Me.Panel1.Controls.Add(Me.dtExpiration)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnApply)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtLine)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.txtStreet)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtPolicy)
        Me.Panel1.Location = New System.Drawing.Point(17, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 375)
        Me.Panel1.TabIndex = 12
        '
        'txtCompany
        '
        Me.txtCompany.FormattingEnabled = True
        Me.txtCompany.Location = New System.Drawing.Point(142, 21)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(328, 29)
        Me.txtCompany.TabIndex = 14
        '
        'cbBarangay
        '
        Me.cbBarangay.FormattingEnabled = True
        Me.cbBarangay.Items.AddRange(New Object() {"Bagumbayan", "Bambang", "Calzada", "Hagonoy", "Ibayo-Tipas", "Ligid-Tipas", "Lower Bicutan", "New Lower Bicutan", "Napindan", "Palingon", "San Miguel", "Santa Ana", "Tuktukan", "Ususan", "Wawa", "Central Bicutan", "Central Signal Village", "Fort Bonifacio", "Katuparan", "Maharlika Village", "North Daang Hari", "North Signal Village", "Pinagsama", "South Daang Hari", "South Signal Village", "Tanyag", "Upper Bicutan", "Western Bicutan"})
        Me.cbBarangay.Location = New System.Drawing.Point(145, 238)
        Me.cbBarangay.Name = "cbBarangay"
        Me.cbBarangay.Size = New System.Drawing.Size(386, 29)
        Me.cbBarangay.TabIndex = 12
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.Location = New System.Drawing.Point(476, 23)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(69, 27)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "apply"
        Me.btnApply.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.txtStamp)
        Me.Panel2.Controls.Add(Me.txtFee)
        Me.Panel2.Controls.Add(Me.txtPremium)
        Me.Panel2.Controls.Add(Me.txtLGT)
        Me.Panel2.Controls.Add(Me.txtLiability)
        Me.Panel2.Controls.Add(Me.txtEVAT)
        Me.Panel2.Controls.Add(Me.txtArea)
        Me.Panel2.Location = New System.Drawing.Point(594, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(571, 315)
        Me.Panel2.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(171, 25)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Policy Information"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(351, 209)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 21)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(278, 173)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 21)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Connection Fee"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(358, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 21)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "LGT"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(401, 260)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 41)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(349, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "EVAT"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(275, 260)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 41)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Doc Stamp"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(31, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 21)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Net. Premium"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 21)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Limit of Liability"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(24, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 21)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Area per sq. m."
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(401, 206)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(117, 29)
        Me.txtTotal.TabIndex = 1
        '
        'txtStamp
        '
        Me.txtStamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStamp.Location = New System.Drawing.Point(144, 166)
        Me.txtStamp.Name = "txtStamp"
        Me.txtStamp.ReadOnly = True
        Me.txtStamp.Size = New System.Drawing.Size(117, 29)
        Me.txtStamp.TabIndex = 1
        '
        'txtFee
        '
        Me.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFee.Location = New System.Drawing.Point(401, 169)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.ReadOnly = True
        Me.txtFee.Size = New System.Drawing.Size(117, 29)
        Me.txtFee.TabIndex = 1
        '
        'txtPremium
        '
        Me.txtPremium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPremium.Location = New System.Drawing.Point(144, 131)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.ReadOnly = True
        Me.txtPremium.Size = New System.Drawing.Size(117, 29)
        Me.txtPremium.TabIndex = 1
        '
        'txtLGT
        '
        Me.txtLGT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLGT.Location = New System.Drawing.Point(401, 134)
        Me.txtLGT.Name = "txtLGT"
        Me.txtLGT.ReadOnly = True
        Me.txtLGT.Size = New System.Drawing.Size(117, 29)
        Me.txtLGT.TabIndex = 1
        '
        'txtLiability
        '
        Me.txtLiability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLiability.Location = New System.Drawing.Point(144, 96)
        Me.txtLiability.Name = "txtLiability"
        Me.txtLiability.ReadOnly = True
        Me.txtLiability.Size = New System.Drawing.Size(117, 29)
        Me.txtLiability.TabIndex = 1
        '
        'txtEVAT
        '
        Me.txtEVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEVAT.Location = New System.Drawing.Point(401, 99)
        Me.txtEVAT.Name = "txtEVAT"
        Me.txtEVAT.Size = New System.Drawing.Size(117, 29)
        Me.txtEVAT.TabIndex = 1
        '
        'txtArea
        '
        Me.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArea.Location = New System.Drawing.Point(144, 61)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(117, 29)
        Me.txtArea.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(594, 439)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 41)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnPrintOR
        '
        Me.btnPrintOR.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnPrintOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintOR.ForeColor = System.Drawing.Color.White
        Me.btnPrintOR.Location = New System.Drawing.Point(720, 439)
        Me.btnPrintOR.Name = "btnPrintOR"
        Me.btnPrintOR.Size = New System.Drawing.Size(120, 41)
        Me.btnPrintOR.TabIndex = 9
        Me.btnPrintOR.Text = "Print OR"
        Me.btnPrintOR.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Location = New System.Drawing.Point(846, 439)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(120, 41)
        Me.btnPayment.TabIndex = 9
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 37)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "New Policy"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.lblPolicyNumber)
        Me.Panel3.Location = New System.Drawing.Point(1083, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(82, 67)
        Me.Panel3.TabIndex = 13
        '
        'lblPolicyNumber
        '
        Me.lblPolicyNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPolicyNumber.ForeColor = System.Drawing.Color.White
        Me.lblPolicyNumber.Location = New System.Drawing.Point(4, -1)
        Me.lblPolicyNumber.Name = "lblPolicyNumber"
        Me.lblPolicyNumber.Size = New System.Drawing.Size(86, 56)
        Me.lblPolicyNumber.TabIndex = 13
        Me.lblPolicyNumber.Text = "01"
        '
        'NewPolicyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnPrintOR)
        Me.Controls.Add(Me.btnPrint)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "NewPolicyForm"
        Me.Size = New System.Drawing.Size(1184, 517)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPolicy As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtLine As TextBox
    Friend WithEvents dtExpiration As DateTimePicker
    Friend WithEvents dtInception As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPremium As TextBox
    Friend WithEvents txtLiability As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtStamp As TextBox
    Friend WithEvents txtFee As TextBox
    Friend WithEvents txtLGT As TextBox
    Friend WithEvents txtEVAT As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPrintOR As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents cbBarangay As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPolicyNumber As Label
    Friend WithEvents txtCompany As System.Windows.Forms.ComboBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
End Class
