Public Class frmSalesReport
    Inherits System.Windows.Forms.Form

    'For capturing reference to Report viewer on admin panel
    Dim tmpReportViewr As New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Dim strfromdatee As String
    Dim strfromtime As String
    'Dim strtotalformdatetime As String
    Dim strtodatee As String
    Dim strtotime As String
    Dim strFromDate As String
    Dim strToDate As String
    'Dim strtotaltodatetime As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents gbSalesReport As System.Windows.Forms.GroupBox
    Friend WithEvents gbDate As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnWeekly As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnToday As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSpecificDate As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnPaymentwise As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCustomerwise As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnItemwise As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cItemName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSc As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvItemInfo As System.Windows.Forms.ListView
    Friend WithEvents gbItemInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cboPayment As System.Windows.Forms.ComboBox
    Friend WithEvents rbtnSummmary As System.Windows.Forms.RadioButton
    Friend WithEvents btnSalesReportCancel As MACButtonLib.MACButton
    Friend WithEvents btnShowReport As MACButtonLib.MACButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbDateTime As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbtnSpecificDateTime As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents fromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents toDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents fromTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents toTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbtCustInfo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbSalesReport = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtCustInfo = New System.Windows.Forms.RadioButton
        Me.rbtnSummmary = New System.Windows.Forms.RadioButton
        Me.rbtnPaymentwise = New System.Windows.Forms.RadioButton
        Me.rbtnCustomerwise = New System.Windows.Forms.RadioButton
        Me.rbtnItemwise = New System.Windows.Forms.RadioButton
        Me.cboPayment = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtnSpecificDate = New System.Windows.Forms.RadioButton
        Me.rbtnMonthly = New System.Windows.Forms.RadioButton
        Me.rbtnWeekly = New System.Windows.Forms.RadioButton
        Me.rbtnToday = New System.Windows.Forms.RadioButton
        Me.rbtnSpecificDateTime = New System.Windows.Forms.RadioButton
        Me.RadioButton10 = New System.Windows.Forms.RadioButton
        Me.gbDate = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.gbDateTime = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.toDate = New System.Windows.Forms.DateTimePicker
        Me.fromDate = New System.Windows.Forms.DateTimePicker
        Me.fromTime = New System.Windows.Forms.DateTimePicker
        Me.toTime = New System.Windows.Forms.DateTimePicker
        Me.gbItemInfo = New System.Windows.Forms.GroupBox
        Me.lvItemInfo = New System.Windows.Forms.ListView
        Me.cItemName = New System.Windows.Forms.ColumnHeader
        Me.cId = New System.Windows.Forms.ColumnHeader
        Me.cSc = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.btnSalesReportCancel = New MACButtonLib.MACButton
        Me.btnShowReport = New MACButtonLib.MACButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.gbSalesReport.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDate.SuspendLayout()
        Me.gbDateTime.SuspendLayout()
        Me.gbItemInfo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSalesReport
        '
        Me.gbSalesReport.Controls.Add(Me.GroupBox2)
        Me.gbSalesReport.Controls.Add(Me.GroupBox1)
        Me.gbSalesReport.Controls.Add(Me.gbDate)
        Me.gbSalesReport.Controls.Add(Me.gbDateTime)
        Me.gbSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbSalesReport.Location = New System.Drawing.Point(8, 11)
        Me.gbSalesReport.Name = "gbSalesReport"
        Me.gbSalesReport.Size = New System.Drawing.Size(296, 373)
        Me.gbSalesReport.TabIndex = 0
        Me.gbSalesReport.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtCustInfo)
        Me.GroupBox2.Controls.Add(Me.rbtnSummmary)
        Me.GroupBox2.Controls.Add(Me.rbtnPaymentwise)
        Me.GroupBox2.Controls.Add(Me.rbtnCustomerwise)
        Me.GroupBox2.Controls.Add(Me.rbtnItemwise)
        Me.GroupBox2.Controls.Add(Me.cboPayment)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(154, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(126, 181)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Type"
        '
        'rbtCustInfo
        '
        Me.rbtCustInfo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCustInfo.ForeColor = System.Drawing.Color.Black
        Me.rbtCustInfo.Location = New System.Drawing.Point(8, 112)
        Me.rbtCustInfo.Name = "rbtCustInfo"
        Me.rbtCustInfo.Size = New System.Drawing.Size(112, 24)
        Me.rbtCustInfo.TabIndex = 17
        Me.rbtCustInfo.Text = "Customer Info"
        '
        'rbtnSummmary
        '
        Me.rbtnSummmary.Checked = True
        Me.rbtnSummmary.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSummmary.ForeColor = System.Drawing.Color.Black
        Me.rbtnSummmary.Location = New System.Drawing.Point(8, 72)
        Me.rbtnSummmary.Name = "rbtnSummmary"
        Me.rbtnSummmary.Size = New System.Drawing.Size(112, 24)
        Me.rbtnSummmary.TabIndex = 10
        Me.rbtnSummmary.TabStop = True
        Me.rbtnSummmary.Text = "Summary"
        '
        'rbtnPaymentwise
        '
        Me.rbtnPaymentwise.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPaymentwise.ForeColor = System.Drawing.Color.Black
        Me.rbtnPaymentwise.Location = New System.Drawing.Point(8, 40)
        Me.rbtnPaymentwise.Name = "rbtnPaymentwise"
        Me.rbtnPaymentwise.Size = New System.Drawing.Size(112, 24)
        Me.rbtnPaymentwise.TabIndex = 9
        Me.rbtnPaymentwise.Text = "Payment wise"
        '
        'rbtnCustomerwise
        '
        Me.rbtnCustomerwise.Enabled = False
        Me.rbtnCustomerwise.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCustomerwise.ForeColor = System.Drawing.Color.Black
        Me.rbtnCustomerwise.Location = New System.Drawing.Point(8, 55)
        Me.rbtnCustomerwise.Name = "rbtnCustomerwise"
        Me.rbtnCustomerwise.Size = New System.Drawing.Size(112, 24)
        Me.rbtnCustomerwise.TabIndex = 8
        Me.rbtnCustomerwise.Text = "Orderwise"
        Me.rbtnCustomerwise.Visible = False
        '
        'rbtnItemwise
        '
        Me.rbtnItemwise.Enabled = False
        Me.rbtnItemwise.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnItemwise.ForeColor = System.Drawing.Color.Black
        Me.rbtnItemwise.Location = New System.Drawing.Point(8, 24)
        Me.rbtnItemwise.Name = "rbtnItemwise"
        Me.rbtnItemwise.Size = New System.Drawing.Size(112, 24)
        Me.rbtnItemwise.TabIndex = 7
        Me.rbtnItemwise.Text = "Itemwise "
        Me.rbtnItemwise.Visible = False
        '
        'cboPayment
        '
        Me.cboPayment.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPayment.ForeColor = System.Drawing.Color.Black
        Me.cboPayment.Items.AddRange(New Object() {"All", "Cash", "Cheque", "Card"})
        Me.cboPayment.Location = New System.Drawing.Point(3, 84)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(110, 23)
        Me.cboPayment.TabIndex = 16
        Me.cboPayment.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnSpecificDate)
        Me.GroupBox1.Controls.Add(Me.rbtnMonthly)
        Me.GroupBox1.Controls.Add(Me.rbtnWeekly)
        Me.GroupBox1.Controls.Add(Me.rbtnToday)
        Me.GroupBox1.Controls.Add(Me.rbtnSpecificDateTime)
        Me.GroupBox1.Controls.Add(Me.RadioButton10)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 181)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Type"
        '
        'rbtnSpecificDate
        '
        Me.rbtnSpecificDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSpecificDate.ForeColor = System.Drawing.Color.Black
        Me.rbtnSpecificDate.Location = New System.Drawing.Point(13, 106)
        Me.rbtnSpecificDate.Name = "rbtnSpecificDate"
        Me.rbtnSpecificDate.Size = New System.Drawing.Size(109, 24)
        Me.rbtnSpecificDate.TabIndex = 5
        Me.rbtnSpecificDate.Text = "Specific Date"
        '
        'rbtnMonthly
        '
        Me.rbtnMonthly.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMonthly.ForeColor = System.Drawing.Color.Black
        Me.rbtnMonthly.Location = New System.Drawing.Point(13, 82)
        Me.rbtnMonthly.Name = "rbtnMonthly"
        Me.rbtnMonthly.Size = New System.Drawing.Size(109, 24)
        Me.rbtnMonthly.TabIndex = 4
        Me.rbtnMonthly.Text = "Monthly"
        '
        'rbtnWeekly
        '
        Me.rbtnWeekly.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnWeekly.ForeColor = System.Drawing.Color.Black
        Me.rbtnWeekly.Location = New System.Drawing.Point(13, 58)
        Me.rbtnWeekly.Name = "rbtnWeekly"
        Me.rbtnWeekly.Size = New System.Drawing.Size(109, 24)
        Me.rbtnWeekly.TabIndex = 3
        Me.rbtnWeekly.Text = "Weekly"
        '
        'rbtnToday
        '
        Me.rbtnToday.Checked = True
        Me.rbtnToday.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnToday.ForeColor = System.Drawing.Color.Black
        Me.rbtnToday.Location = New System.Drawing.Point(13, 34)
        Me.rbtnToday.Name = "rbtnToday"
        Me.rbtnToday.Size = New System.Drawing.Size(109, 24)
        Me.rbtnToday.TabIndex = 2
        Me.rbtnToday.TabStop = True
        Me.rbtnToday.Text = "Today"
        '
        'rbtnSpecificDateTime
        '
        Me.rbtnSpecificDateTime.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSpecificDateTime.ForeColor = System.Drawing.Color.Black
        Me.rbtnSpecificDateTime.Location = New System.Drawing.Point(13, 136)
        Me.rbtnSpecificDateTime.Name = "rbtnSpecificDateTime"
        Me.rbtnSpecificDateTime.Size = New System.Drawing.Size(109, 32)
        Me.rbtnSpecificDateTime.TabIndex = 5
        Me.rbtnSpecificDateTime.Text = "Specific Date & Time"
        '
        'RadioButton10
        '
        Me.RadioButton10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(16, 144)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton10.TabIndex = 5
        Me.RadioButton10.Text = "Specific Date"
        '
        'gbDate
        '
        Me.gbDate.Controls.Add(Me.Label2)
        Me.gbDate.Controls.Add(Me.Label1)
        Me.gbDate.Controls.Add(Me.dtpToDate)
        Me.gbDate.Controls.Add(Me.dtpFromDate)
        Me.gbDate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbDate.Location = New System.Drawing.Point(8, 218)
        Me.gbDate.Name = "gbDate"
        Me.gbDate.Size = New System.Drawing.Size(278, 48)
        Me.gbDate.TabIndex = 11
        Me.gbDate.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "To"
        '
        'dtpToDate
        '
        Me.dtpToDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(171, 17)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(101, 21)
        Me.dtpToDate.TabIndex = 15
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(48, 16)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(100, 21)
        Me.dtpFromDate.TabIndex = 13
        '
        'gbDateTime
        '
        Me.gbDateTime.Controls.Add(Me.Label5)
        Me.gbDateTime.Controls.Add(Me.Label6)
        Me.gbDateTime.Controls.Add(Me.toDate)
        Me.gbDateTime.Controls.Add(Me.fromDate)
        Me.gbDateTime.Controls.Add(Me.fromTime)
        Me.gbDateTime.Controls.Add(Me.toTime)
        Me.gbDateTime.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbDateTime.Location = New System.Drawing.Point(8, 285)
        Me.gbDateTime.Name = "gbDateTime"
        Me.gbDateTime.Size = New System.Drawing.Size(278, 72)
        Me.gbDateTime.TabIndex = 11
        Me.gbDateTime.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "From"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(149, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "To"
        '
        'toDate
        '
        Me.toDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.toDate.Location = New System.Drawing.Point(171, 17)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(101, 21)
        Me.toDate.TabIndex = 15
        '
        'fromDate
        '
        Me.fromDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromDate.Location = New System.Drawing.Point(48, 16)
        Me.fromDate.Name = "fromDate"
        Me.fromDate.Size = New System.Drawing.Size(100, 21)
        Me.fromDate.TabIndex = 13
        '
        'fromTime
        '
        Me.fromTime.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.fromTime.Location = New System.Drawing.Point(47, 40)
        Me.fromTime.Name = "fromTime"
        Me.fromTime.ShowUpDown = True
        Me.fromTime.Size = New System.Drawing.Size(100, 21)
        Me.fromTime.TabIndex = 13
        '
        'toTime
        '
        Me.toTime.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.toTime.Location = New System.Drawing.Point(170, 40)
        Me.toTime.Name = "toTime"
        Me.toTime.ShowUpDown = True
        Me.toTime.Size = New System.Drawing.Size(101, 21)
        Me.toTime.TabIndex = 15
        '
        'gbItemInfo
        '
        Me.gbItemInfo.Controls.Add(Me.lvItemInfo)
        Me.gbItemInfo.Location = New System.Drawing.Point(331, 11)
        Me.gbItemInfo.Name = "gbItemInfo"
        Me.gbItemInfo.Size = New System.Drawing.Size(304, 213)
        Me.gbItemInfo.TabIndex = 6
        Me.gbItemInfo.TabStop = False
        Me.gbItemInfo.Text = "Item List"
        '
        'lvItemInfo
        '
        Me.lvItemInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvItemInfo.CheckBoxes = True
        Me.lvItemInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cItemName, Me.cId, Me.cSc})
        Me.lvItemInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvItemInfo.GridLines = True
        Me.lvItemInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvItemInfo.Location = New System.Drawing.Point(12, 24)
        Me.lvItemInfo.Name = "lvItemInfo"
        Me.lvItemInfo.Size = New System.Drawing.Size(280, 179)
        Me.lvItemInfo.TabIndex = 0
        Me.lvItemInfo.View = System.Windows.Forms.View.Details
        '
        'cItemName
        '
        Me.cItemName.Text = "Name"
        Me.cItemName.Width = 280
        '
        'cId
        '
        Me.cId.Text = ""
        Me.cId.Width = 0
        '
        'cSc
        '
        Me.cSc.Text = ""
        Me.cSc.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'btnSalesReportCancel
        '
        Me.btnSalesReportCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSalesReportCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnSalesReportCancel.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnSalesReportCancel.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnSalesReportCancel.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnSalesReportCancel.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnSalesReportCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReportCancel.Location = New System.Drawing.Point(156, 395)
        Me.btnSalesReportCancel.Name = "btnSalesReportCancel"
        Me.btnSalesReportCancel.Size = New System.Drawing.Size(95, 41)
        Me.btnSalesReportCancel.TabIndex = 17
        Me.btnSalesReportCancel.Text = "Cancel"
        Me.btnSalesReportCancel.TextColorDefault = System.Drawing.Color.Black
        Me.btnSalesReportCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.btnSalesReportCancel.TextColorHover = System.Drawing.Color.White
        Me.btnSalesReportCancel.TextColorNormal = System.Drawing.Color.White
        '
        'btnShowReport
        '
        Me.btnShowReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShowReport.BackColor = System.Drawing.Color.Transparent
        Me.btnShowReport.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnShowReport.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnShowReport.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnShowReport.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnShowReport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowReport.Location = New System.Drawing.Point(52, 395)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(95, 41)
        Me.btnShowReport.TabIndex = 16
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.TextColorDefault = System.Drawing.Color.Black
        Me.btnShowReport.TextColorDisabled = System.Drawing.Color.Black
        Me.btnShowReport.TextColorHover = System.Drawing.Color.White
        Me.btnShowReport.TextColorNormal = System.Drawing.Color.White
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(21, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(272, 296)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(154, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(136, 157)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report Type"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(8, 115)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.Text = "Summery"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.Items.AddRange(New Object() {"All", "Cash", "Cheque", "Card"})
        Me.ComboBox1.Location = New System.Drawing.Point(8, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 16
        Me.ComboBox1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(8, 86)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.Text = "Paymentwise"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(8, 62)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.Text = "Orderwise"
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(8, 38)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton4.TabIndex = 7
        Me.RadioButton4.Text = "Itemwise "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton5)
        Me.GroupBox5.Controls.Add(Me.RadioButton6)
        Me.GroupBox5.Controls.Add(Me.RadioButton7)
        Me.GroupBox5.Controls.Add(Me.RadioButton8)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(136, 157)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Search Type"
        '
        'RadioButton5
        '
        Me.RadioButton5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(13, 106)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.Text = "Specific Date"
        '
        'RadioButton6
        '
        Me.RadioButton6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(13, 82)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton6.TabIndex = 4
        Me.RadioButton6.Text = "Monthly"
        '
        'RadioButton7
        '
        Me.RadioButton7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(13, 58)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton7.TabIndex = 3
        Me.RadioButton7.Text = "Weekly"
        '
        'RadioButton8
        '
        Me.RadioButton8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(13, 34)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(109, 24)
        Me.RadioButton8.TabIndex = 2
        Me.RadioButton8.Text = "Today"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox6.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(278, 48)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "From"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(149, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(171, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 21)
        Me.DateTimePicker1.TabIndex = 15
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(48, 16)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker2.TabIndex = 13
        '
        'frmSalesReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(322, 471)
        Me.Controls.Add(Me.btnSalesReportCancel)
        Me.Controls.Add(Me.btnShowReport)
        Me.Controls.Add(Me.gbItemInfo)
        Me.Controls.Add(Me.gbSalesReport)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sales Summery Report"
        Me.gbSalesReport.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbDate.ResumeLayout(False)
        Me.gbDateTime.ResumeLayout(False)
        Me.gbItemInfo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbtnToday.Checked = True

        gbDate.Enabled = False
        ' gbDateTime.Enabled = False
        dtpFromDate.Value = GetOrderDate().Date
        dtpToDate.Value = GetOrderDate().Date

        Dim objAdmin As New frmAdmin
        Me.Left = (objAdmin.Width - Me.Width) / 2 - 90
        Me.Top = (objAdmin.Height - Me.Height) / 2
    End Sub

    Private Sub rbtnSpecificDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rbtnSpecificDate.Checked = True Then
            gbDate.Enabled = True
        End If
    End Sub

    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        If rbtnItemwise.Checked = True Then
            CreatItemwiseReport()
        ElseIf rbtnCustomerwise.Checked = True Then
            CreatCustomerwiseReport()
        ElseIf rbtnPaymentwise.Checked = True Then
            CreatPaymentWiseReport()
        ElseIf rbtnSummmary.Checked = True Then
            CreatSalesSummary()
        ElseIf rbtCustInfo.Checked = True Then
            CreatPaymeReport()
        Else
            MsgBox("Please select Rrporte type", MsgBoxStyle.Information, "Sales Report")
        End If
    End Sub

    Private Function CreatCustomerwiseReport()

        Dim strFromDate As String
        Dim strToDate As String
        Dim iCountDataSetRow As Integer

        Dim strSQL As String

        Dim daSales As SqlClient.SqlDataAdapter

        Dim dsSales As dsReport
        Dim objrSales As New rSales

        If gbDateTime.Enabled = True Then
            'for from date
            strfromdatee = DateTime.Parse(Trim(fromDate.Text)).ToString(" MM/dd/yyyy ")
            strfromtime = DateTime.Parse(Trim(fromTime.Text)).ToString(" hh:mm:ss tt ")
            strFromDate = strfromdatee + strfromtime
            'for to date
            strtodatee = DateTime.Parse(Trim(toDate.Text)).ToString(" MM/dd/yyyy ")
            strtotime = DateTime.Parse(Trim(toTime.Text)).ToString(" hh:mm:ss tt ")
            strToDate = strtodatee + strtotime
        Else
            strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
            strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")
        End If

        strSQL = "SELECT O.nOrder_id,P.dOrder_Date,O.nItem_Qty,P.mTotalPrice,P.mDiscount" & _
                 ",P.mService_Charge,P.mNetpay,P.nOrderStatus,I.cItem_Name " & _
                 "FROM tOrdered_Item O, tOrder_Payment P, tItem I WHERE I.nItem_Id=O.nItem_Id AND " & _
                 "O.nOrder_Id=P.nOrder_Id AND P.dOrder_Date BETWEEN '" + strFromDate + "' AND '" + strToDate + "' "
     

        Try
            dsSales = New dsReport
            daSales = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daSales.Fill(dsSales, "tCust_Info")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsSales.Tables("tCust_Info").Rows.Count

        If iCountDataSetRow > 0 Then
            objrSales.SetDataSource(dsSales)
            tmpReportViewr.Visible = True
            tmpReportViewr.ReportSource = objrSales
            Me.Dispose()
        Else
            MessageBox.Show("There is no sales information ", "ERestuarant", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Function

    Private Function CreatItemwiseReport()
        Dim i As Integer
        Dim icount As Integer
        Dim iItemId As Integer
        Dim iCountDataSetRow As Integer

        Dim strItemId As String
        Dim strSQL As String

        Dim strFromDate As String
        Dim strToDate As String

        Dim dsSales As dsReport
        Dim objrSales As New rItemwiseSales
        Dim daSales As SqlClient.SqlDataAdapter
        icount = lvItemInfo.Items.Count


        If icount > 0 Then
            For i = 0 To icount - 1
                If lvItemInfo.Items(i).Checked = True Then
                    iItemId = lvItemInfo.Items(i).SubItems(1).Text
                    If Trim(strItemId) = vbNullString Then
                        strItemId = "I.nItem_Id=" & iItemId
                    Else
                        strItemId += " OR I.nItem_Id=" & iItemId
                    End If
                End If
            Next
        End If

        If gbDateTime.Enabled = True Then

            'for from date
            strfromdatee = DateTime.Parse(Trim(fromDate.Text)).ToString(" MM/dd/yyyy ")
            strfromtime = DateTime.Parse(Trim(fromTime.Text)).ToString(" hh:mm:ss tt ")
            strFromDate = strfromdatee + strfromtime
            'for to date
            strtodatee = DateTime.Parse(Trim(toDate.Text)).ToString(" MM/dd/yyyy ")
            strtotime = DateTime.Parse(Trim(toTime.Text)).ToString(" hh:mm:ss tt ")
            strToDate = strtodatee + strtotime

        Else
            strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
            strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")
        End If

        If Trim(strItemId) <> vbNullString Then

            strSQL = "SELECT I.nItem_Id,I.cItem_Name,sum(O.nItem_Qty) as nItem_Qty,O.mUnitPrice,sum((O.nItem_Qty) * O.mUnitPrice) as mTotalPrice, P.dOrder_date " & _
                     "FROM tItem as I,tOrdered_Item as O,tOrder_Payment as P WHERE I.nItem_Id=O.nItem_Id" & _
                     " AND O.nOrder_Id=P.nOrder_Id AND P.dOrder_date BETWEEN '" + strFromDate + "' AND '" + strToDate + _
                     "'" & " AND (" & strItemId & ") group by P.dOrder_date, I.nItem_Id,I.cItem_Name,O.mUnitPrice "
        Else

            strSQL = "SELECT I.nItem_Id,I.cItem_Name,sum(O.nItem_Qty) as nItem_Qty,O.mUnitPrice,(sum(O.nItem_Qty) * O.mUnitPrice) as mTotalPrice, P.dOrder_date " & _
                     "FROM tItem as I,tOrdered_Item as O,tOrder_Payment as P WHERE I.nItem_Id=O.nItem_Id" & _
                     " AND O.nOrder_Id=P.nOrder_Id AND P.dOrder_date BETWEEN '" + strFromDate + "' AND '" + strToDate + _
                     "' ,  AND group by P.dOrder_date, I.nItem_Id,I.cItem_Name,O.mUnitPrice"
        End If

        Try

            dsSales = New dsReport
            daSales = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daSales.Fill(dsSales, "tCust_Info")

        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsSales.Tables("tCust_Info").Rows.Count

        If iCountDataSetRow > 0 Then
            objrSales.SetDataSource(dsSales)
            tmpReportViewr.Visible = True
            tmpReportViewr.ReportSource = objrSales
            Me.Dispose()
        Else
            MessageBox.Show("There is no sales information ", "ERestuarant", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Function

    Private Function CreatPaymentWiseReport()
        Dim strSQl As String
        Dim strFromDate As String
        Dim strToDate As String
        Dim iCountDataSetRow As Integer
        Dim strFrom As String
        Dim strTo As String


        Dim dsSales As DataSet
        Dim daSales As SqlClient.SqlDataAdapter
        Dim objrSales As New rPaymetWiseReport

        strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
        strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")

        strSQl = "SELECT SUM(mCashPayAmount)  mCashPayAmount,SUM(mCardPayAmount) mCardPayAmount," & _
                 "SUM(mChequeAmount) mCashPayAmount From tOrder_Payment " & _
                 " WHERE dOrder_date BETWEEN '" & strFromDate & "' AND '" & strToDate & "'"
        Try

            dsSales = New dsReport
            daSales = New SqlClient.SqlDataAdapter(strSQl, mdDBConnection.connRestuarant)
            daSales.Fill(dsSales, "tCust_Info")

        Catch ex As Exception

            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsSales.Tables("tCust_Info").Rows.Count

        If iCountDataSetRow > 0 Then
            'dsSales.Tables("tCust_Info").Rows(0)("dOrder_date") = strFromDate
            'dsSales.Tables("tCust_Info").Rows(0)("dLstOrdrDate") = strToDate
            'dsSales.Tables("tCust_Info").Rows(0)("dCust_EntryDate") = strFrom
            'dsSales.Tables("tCust_Info").Rows(0)("dLstOrdrDate") = strTo
            objrSales.SetDataSource(dsSales)
            tmpReportViewr.Visible = True
            tmpReportViewr.ReportSource = objrSales
            Me.Dispose()
        End If

    End Function

    Private Function UpDateGeneralInformation(ByVal tmpSqlString As String, ByVal tmpdataset As DataSet)

        Dim dsInformation As New DataSet("Information")
        Dim daInformation As SqlClient.SqlDataAdapter
        Dim iRowCount As Integer
        Dim iIndex As Integer
        Dim dTotalFoodPrice As Double = 0
        Dim dTotalDrinkPrice As Double = 0
        Dim dTotalDiscount As Double = 0
        Dim dTotalTips As Double = 0
        Dim dTotalCashPay As Double = 0
        Dim dTotalCardPay As Double = 0
        Dim dTotalChequePay As Double = 0
        Dim iTotelOrder As Integer
        Dim iOrderId As Integer

        Try
            daInformation = New SqlClient.SqlDataAdapter(tmpSqlString, mdDBConnection.connRestuarant)
            daInformation.Fill(dsInformation, "Information")
            iRowCount = dsInformation.Tables("Information").Rows.Count

            If iRowCount > 0 Then
                iOrderId = dsInformation.Tables("Information").Rows(iIndex).Item(0)
                iTotelOrder = 1
                If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(5)) Then
                    dTotalDiscount = Val(dsInformation.Tables("Information").Rows(iIndex).Item(5))
                End If

                If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(6)) Then
                    dTotalTips = Val(dsInformation.Tables("Information").Rows(iIndex).Item(6))
                End If

                If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(7)) Then
                    dTotalCashPay = Val(dsInformation.Tables("Information").Rows(iIndex).Item(7))
                End If

                If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(8)) Then
                    dTotalCardPay = Val(dsInformation.Tables("Information").Rows(iIndex).Item(8))
                End If

                If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(9)) Then
                    dTotalChequePay = Val(dsInformation.Tables("Information").Rows(iIndex).Item(9))
                End If

                For iIndex = 0 To iRowCount - 1
                    If dsInformation.Tables("Information").Rows(iIndex).Item(2).ToUpper = "KITCHEN" Then
                        dTotalFoodPrice += Val(dsInformation.Tables("Information").Rows(iIndex).Item(3)) * Val(dsInformation.Tables("Information").Rows(iIndex).Item(4))
                    Else
                        dTotalDrinkPrice += Val(dsInformation.Tables("Information").Rows(iIndex).Item(3)) * Val(dsInformation.Tables("Information").Rows(iIndex).Item(4))
                    End If
                    If iOrderId <> Val(dsInformation.Tables("Information").Rows(iIndex).Item(0)) Then
                        iTotelOrder += 1
                        If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(5)) Then
                            dTotalDiscount += Val(dsInformation.Tables("Information").Rows(iIndex).Item(5))
                        End If

                        If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(6)) Then
                            dTotalTips += Val(dsInformation.Tables("Information").Rows(iIndex).Item(6))
                        End If

                        If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(7)) Then
                            dTotalCashPay += Val(dsInformation.Tables("Information").Rows(iIndex).Item(7))
                        End If

                        If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(8)) Then
                            dTotalCardPay += Val(dsInformation.Tables("Information").Rows(iIndex).Item(8))
                        End If

                        If Not IsDBNull(dsInformation.Tables("Information").Rows(iIndex).Item(9)) Then
                            dTotalChequePay += Val(dsInformation.Tables("Information").Rows(iIndex).Item(9))
                        End If
                        iOrderId = Val(dsInformation.Tables("Information").Rows(iIndex).Item(0))
                    End If
                Next

            End If
            tmpdataset.Tables("tCust_Info").Rows(0)("nOrder_id") = iTotelOrder
            tmpdataset.Tables("tCust_Info").Rows(0)("mTotalFoodSales") = dTotalFoodPrice
            tmpdataset.Tables("tCust_Info").Rows(0)("mTotalDrinkSales") = dTotalDrinkPrice
            tmpdataset.Tables("tCust_Info").Rows(0)("mTotalPrice") = dTotalFoodPrice + dTotalDrinkPrice
            tmpdataset.Tables("tCust_Info").Rows(0)("mDiscount") = dTotalDiscount
            tmpdataset.Tables("tCust_Info").Rows(0)("mService_Charge") = dTotalTips
            tmpdataset.Tables("tCust_Info").Rows(0)("mNetpay") = dTotalFoodPrice + dTotalDrinkPrice + dTotalTips - dTotalDiscount
            tmpdataset.Tables("tCust_Info").Rows(0)("mCashPayAmount") = dTotalCashPay
            tmpdataset.Tables("tCust_Info").Rows(0)("mCardPayAmount") = dTotalCardPay
            tmpdataset.Tables("tCust_Info").Rows(0)("mChequeAmount") = dTotalChequePay

        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Function

    Private Function UpDateModewiseInformation(ByVal tmpSqlString As String, ByVal tmpdataset As DataSet)

        Dim dsInformation As New DataSet("Information")
        Dim daInformation As SqlClient.SqlDataAdapter
        Dim iRowCount As Integer
        Dim iIndex As Integer

        Dim iOrderId As Integer
        Dim iTotalTakeawayOrder As Integer = 0
        Dim iTotalDineInOrder As Integer = 0
        Dim iTotalGuestNumber As Integer = 0
        Dim dTotalTakeawaySales As Double = 0
        Dim dTotalDineInSales As Double = 0
        Dim bAdded As Boolean = False
        Dim bAddedDineIn As Boolean = False
        Dim bAddedGNember As Boolean = False
        Dim TableId As Integer



        Try
            daInformation = New SqlClient.SqlDataAdapter(tmpSqlString, mdDBConnection.connRestuarant)
            daInformation.Fill(dsInformation, "Information")

            iRowCount = dsInformation.Tables("Information").Rows.Count

            If iRowCount > 0 Then
                iOrderId = dsInformation.Tables("Information").Rows(iIndex).Item(0)
                For iIndex = 0 To iRowCount - 1
                    If Val(dsInformation.Tables("Information").Rows(iIndex).Item(1)) = 0 Then
                        dTotalTakeawaySales += Val(dsInformation.Tables("Information").Rows(iIndex).Item(4)) * Val(dsInformation.Tables("Information").Rows(iIndex).Item(5))
                        If iOrderId <> dsInformation.Tables("Information").Rows(iIndex).Item(0) Then
                            iTotalTakeawayOrder += 1
                            iOrderId = dsInformation.Tables("Information").Rows(iIndex).Item(0)
                        Else
                            If bAdded = False Then
                                iTotalTakeawayOrder = 1
                                bAdded = True
                            End If
                        End If
                    Else
                        If iOrderId <> dsInformation.Tables("Information").Rows(iIndex).Item(0) Then            'new added if part
                            iTotalGuestNumber += Val(dsInformation.Tables("Information").Rows(iIndex).Item(2))
                        Else
                            If bAddedGNember = False Then
                                iTotalGuestNumber = Val(dsInformation.Tables("Information").Rows(iIndex).Item(2))
                                bAddedGNember = True
                            End If
                        End If
                        ' iTotalGuestNumber += Val(dsInformation.Tables("Information").Rows(iIndex).Item(2))
                        dTotalDineInSales += Val(dsInformation.Tables("Information").Rows(iIndex).Item(4)) * Val(dsInformation.Tables("Information").Rows(iIndex).Item(5))
                        If iOrderId <> dsInformation.Tables("Information").Rows(iIndex).Item(0) Then

                            ' If (dsInformation.Tables("Information").Rows(iIndex).Item(1)) <> vbNullString Then
                            iTotalDineInOrder += 1
                            iOrderId = dsInformation.Tables("Information").Rows(iIndex).Item(0)
                        Else
                            If bAddedDineIn = False Then
                                iTotalDineInOrder = 1
                                bAddedDineIn = True

                            End If

                            ' iTotalDineInOrder += 1
                            'iOrderId = dsInformation.Tables("Information").Rows(iIndex).Item(0)
                            'Else
                            '    If bAddedDineIn = False Then
                            '        iTotalDineInOrder += 1
                            '        bAddedDineIn = True
                            '    End If
                            'End If
                        End If

                    End If



                Next
            End If
            tmpdataset.Tables("tCust_Info").Rows(0)("nGuestsNumber") = iTotalGuestNumber
            tmpdataset.Tables("tCust_Info").Rows(0)("nTable_Id") = iTotalDineInOrder
            tmpdataset.Tables("tCust_Info").Rows(0)("nTable_Capacity") = iTotalTakeawayOrder
            tmpdataset.Tables("tCust_Info").Rows(0)("mDinePrice") = dTotalDineInSales
            tmpdataset.Tables("tCust_Info").Rows(0)("mTakeawayPrice") = dTotalTakeawaySales
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Function

    Private Function CreatSalesSummary()

        Dim iCountDataSetRow As Integer
        Dim strSQL As String
        Dim daSales As SqlClient.SqlDataAdapter
        Dim dsSales As dsReport
        Dim objrSalesSummary As New rSalesSummary


        'If mdConfiguration.sReportPrinter <> vbNullString Then
        '    objrSales.PrintOptions.PrinterName = mdConfiguration.sReportPrinter
        'Else
        '    MsgBox("Please select a printer to print report.", MsgBoxStyle.Information, "Sales Report")
        '    Exit Function
        'End If
        If gbDateTime.Enabled = True Then

            'for from date
            strfromdatee = DateTime.Parse(Trim(fromDate.Text)).ToString(" MM/dd/yyyy ")
            strfromtime = DateTime.Parse(Trim(fromTime.Text)).ToString(" hh:mm:ss tt ")
            strFromDate = strfromdatee + strfromtime
            'for to date
            strtodatee = DateTime.Parse(Trim(toDate.Text)).ToString(" MM/dd/yyyy ")
            strtotime = DateTime.Parse(Trim(toTime.Text)).ToString(" hh:mm:ss tt ")
            strToDate = strtodatee + strtotime

        Else
            strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
            strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")
        End If

        strSQL = "SELECT cRestName,cRestType,cResAddress1,cResAddress2,cResAddress3,cResPhoneNumber,nVat FROM tMasterInfo"

        Try
            dsSales = New dsReport
            daSales = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daSales.Fill(dsSales, "tCust_Info")
            dsSales.Tables("tCust_Info").Rows(0)("cUserId") = struserName

            strSQL = "SELECT P.nOrder_id,O.nItem_Id,I.cItem_ServeLoc,O.mUnitPrice,O.nItem_Qty,P.mDiscount," & _
                     "P.mService_Charge,P.mCashPayAmount,P.mCardPayAmount,P.mChequeAmount " & _
                     "FROM tOrder_Payment as P, tOrdered_Item as O, tItem as I WHERE P.nOrder_id=O.nOrder_id " & _
                     " AND P.nOrderstatus=1 AND O.nItem_Id=I.nItem_Id AND P.dOrder_date BETWEEN '" & strFromDate & "' AND '" & strToDate & "'order by P.nOrder_id"

            UpDateGeneralInformation(strSQL, dsSales)

            strSQL = "SELECT P.nOrder_id,P.nTable_Id,P.nNumberofGuests,O.nItem_Id,O.mUnitPrice,O.nItem_Qty " & _
                     "FROM tOrder_Payment as P, tOrdered_Item as O  WHERE P.nOrder_id=O.nOrder_id " & _
                     " AND P.nOrderstatus=1 AND P.dOrder_date BETWEEN '" & strFromDate & "' AND '" & strToDate & "'order by P.nOrder_id,O.nItem_Id"    'new added order by P.nOrder_id,O.nItem_Id

            UpDateModewiseInformation(strSQL, dsSales)

        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsSales.Tables("tCust_Info").Rows.Count

        If iCountDataSetRow > 0 Then

            objrSalesSummary.SetDataSource(dsSales)
            tmpReportViewr.Visible = True
            tmpReportViewr.ReportSource = objrSalesSummary
            Me.Dispose()
        Else
            MessageBox.Show("There is no sales information ", "ERestuarant", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function

    Public Function SetReportViewer(ByRef aReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer)
        tmpReportViewr = aReportViewer
    End Function

    Private Sub btnSalesReportCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesReportCancel.Click
        Me.Dispose()
    End Sub

    Private Sub rbtnWeekly_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnWeekly.Click
        gbDate.Enabled = False
        dtpToDate.Value = GetOrderDate().Date
        dtpFromDate.Value = DateAdd(DateInterval.Day, -7, GetOrderDate().Date)
    End Sub

    Private Sub rbtnMonthly_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnMonthly.Click
        gbDate.Enabled = False
        dtpToDate.Value = GetOrderDate().Date
        dtpFromDate.Value = DateAdd(DateInterval.Month, -1, GetOrderDate().Date)
    End Sub

    Private Sub rbtnToday_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnToday.Click
        gbDate.Enabled = False
        gbDateTime.Enabled = False
        dtpToDate.Value = GetOrderDate().Date
        dtpFromDate.Value = GetOrderDate().Date
    End Sub

    Private Sub rbtnSpecificDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnSpecificDate.Click
        gbDate.Enabled = True
        gbDateTime.Enabled = False
    End Sub

    Private Sub rbtnSpecificDateTime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnSpecificDateTime.Click
        gbDateTime.Enabled = True
        gbDate.Enabled = False
    End Sub

    Private Function FillItemInfo()
        Dim strSQL As String
        Dim icount As Integer
        Dim i As Integer

        Dim dsItemInfo As DataSet
        Dim daItemInfo As SqlClient.SqlDataAdapter

        strSQL = "SELECT cItem_Name,nItem_Id,cItem_SC FROM tItem"

        Try
            dsItemInfo = New DataSet("ItemInfo")
            daItemInfo = New SqlClient.SqlDataAdapter(strSQL, connRestuarant)
            daItemInfo.Fill(dsItemInfo, "ItemInfo")
            icount = dsItemInfo.Tables("ItemInfo").Rows.Count
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        If icount > 0 Then
            For i = 0 To icount - 1
                lvItemInfo.Items.Add(dsItemInfo.Tables("ItemInfo").Rows(i).Item(0)) 'To add ItemName
                lvItemInfo.Items(i).SubItems.Add(dsItemInfo.Tables("ItemInfo").Rows(i).Item(1)) 'To add ItemId
                lvItemInfo.Items(i).SubItems.Add(dsItemInfo.Tables("ItemInfo").Rows(i).Item(2)) 'To add ItemShortCode
            Next
        End If
    End Function

    Private Sub rbtnItemwise_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnItemwise.Click
        Me.Width = 632
        btnShowReport.Left = 210
        btnSalesReportCancel.Left = 328
        gbItemInfo.Left = 315
        gbItemInfo.Top = 11
        rbtnItemwise.Top = 38
        rbtnCustomerwise.Top = 62
        rbtnPaymentwise.Top = 86
        cboPayment.Visible = False
        FillItemInfo()
    End Sub

    Private Sub rbtnCustomerwise_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCustomerwise.Click
        Me.Width = 324
        btnShowReport.Left = 56
        btnSalesReportCancel.Left = 168
        gbItemInfo.Left = 331
        rbtnItemwise.Top = 38
        rbtnCustomerwise.Top = 62
        rbtnPaymentwise.Top = 86
        cboPayment.Visible = False
    End Sub

    Private Sub rbtnPaymentwise_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnPaymentwise.Click
        Me.Width = 324
        btnShowReport.Left = 56
        btnSalesReportCancel.Left = 168
        gbItemInfo.Left = 331
        rbtnItemwise.Top = 38
        rbtnCustomerwise.Top = 62
        'rbtnPaymentwise.Top = 86
        cboPayment.Visible = False
    End Sub

    Private Sub rbtnSummmary_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnSummmary.Click
        Me.Width = 324
        btnShowReport.Left = 56
        btnSalesReportCancel.Left = 168
        gbItemInfo.Left = 331
        rbtnItemwise.Top = 38
        rbtnCustomerwise.Top = 62
        'rbtnPaymentwise.Top = 86
        cboPayment.Visible = False
    End Sub

    Private Function CreatPaymeReport()

        Dim strSQl As String
        Dim strFromDate As String
        Dim strToDate As String
        Dim iCountDataSetRow As Integer
        Dim strFrom As String
        Dim strTo As String


        Dim dsSales As DataSet
        Dim daSales As SqlClient.SqlDataAdapter
        Dim objrSales As New rCustInfo

        strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
        strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")

        strSQl = "SELECT cCust_Name,cPhnNo,cPostCode,cAddress,cCompany  from tCust_Info  WHERE dCust_EntryDate BETWEEN '" & strFromDate & "' AND '" & strToDate & "'"

        Try

            dsSales = New dsReport
            daSales = New SqlClient.SqlDataAdapter(strSQl, mdDBConnection.connRestuarant)
            daSales.Fill(dsSales, "tCust_Info")

        Catch ex As Exception

            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsSales.Tables("tCust_Info").Rows.Count

        If iCountDataSetRow > 0 Then
            'dsSales.Tables("tCust_Info").Rows(0)("dOrder_date") = strFromDate
            'dsSales.Tables("tCust_Info").Rows(0)("dLstOrdrDate") = strToDate
            'dsSales.Tables("tCust_Info").Rows(0)("dCust_EntryDate") = strFrom
            'dsSales.Tables("tCust_Info").Rows(0)("dLstOrdrDate") = strTo
            objrSales.SetDataSource(dsSales)
            tmpReportViewr.Visible = True
            tmpReportViewr.ReportSource = objrSales
            Me.Dispose()
        End If

    End Function

    Private Sub rbtCustInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtCustInfo.Click
        Me.Width = 324
        btnShowReport.Left = 56
        btnSalesReportCancel.Left = 168
        gbItemInfo.Left = 331
        rbtnItemwise.Top = 38
        rbtnCustomerwise.Top = 62
        'rbtnPaymentwise.Top = 86
        cboPayment.Visible = False

    End Sub

 

 
End Class
