Public Class frmPaymentStatus
    Inherits System.Windows.Forms.Form

    Dim bPasswordGiven As Boolean
    Dim iOkClickCount As Integer
    Dim iOrderId As Integer
    Dim refund As String
    Dim TableNum As String
    Dim strTableNumber As String
    Dim strFromDate As String
    Dim strToDate As String
    ' Dim tmpTakeaway As DataSet

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents pnlPassword As System.Windows.Forms.Panel
    Friend WithEvents lvPaymentStatus As System.Windows.Forms.ListView
    Friend WithEvents lvcOrderId As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcOrderDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcOrderTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcBillAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcNetPay As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcUserId As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcCustomerId As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnOk As MACButtonLib.MACButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShowPaymentStatus As MACButtonLib.MACButton
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnUpdatePayment As MACButtonLib.MACButton
    Friend WithEvents btnLookUpOk As MACButtonLib.MACButton
    Friend WithEvents btnCancel As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    Friend WithEvents lvcViaPay As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkBoxRefund As System.Windows.Forms.CheckBox
    Friend WithEvents btnRefundd As MACButtonLib.MACButton
    Friend WithEvents RPTbtn As MACButtonLib.MACButton
    Friend WithEvents lbSelectDatefrom As System.Windows.Forms.Label
    Friend WithEvents lbSelectDateTo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPaymentStatus))
        Me.pnlPassword = New System.Windows.Forms.Panel
        Me.btnOk = New MACButtonLib.MACButton
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnExit = New MACButtonLib.MACButton
        Me.lvPaymentStatus = New System.Windows.Forms.ListView
        Me.lvcOrderId = New System.Windows.Forms.ColumnHeader
        Me.lvcOrderDate = New System.Windows.Forms.ColumnHeader
        Me.lvcOrderTime = New System.Windows.Forms.ColumnHeader
        Me.lvcName = New System.Windows.Forms.ColumnHeader
        Me.lvcBillAddress = New System.Windows.Forms.ColumnHeader
        Me.lvcNetPay = New System.Windows.Forms.ColumnHeader
        Me.lvcStatus = New System.Windows.Forms.ColumnHeader
        Me.lvcUserId = New System.Windows.Forms.ColumnHeader
        Me.lvcCustomerId = New System.Windows.Forms.ColumnHeader
        Me.lvcViaPay = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnShowPaymentStatus = New MACButtonLib.MACButton
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.lbSelectDateTo = New System.Windows.Forms.Label
        Me.lbSelectDatefrom = New System.Windows.Forms.Label
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.btnUpdatePayment = New MACButtonLib.MACButton
        Me.btnLookUpOk = New MACButtonLib.MACButton
        Me.btnCancel = New MACButtonLib.MACButton
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.btnRefundd = New MACButtonLib.MACButton
        Me.chkBoxRefund = New System.Windows.Forms.CheckBox
        Me.RPTbtn = New MACButtonLib.MACButton
        Me.pnlPassword.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPassword
        '
        Me.pnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPassword.Controls.Add(Me.btnOk)
        Me.pnlPassword.Controls.Add(Me.txtPassword)
        Me.pnlPassword.Location = New System.Drawing.Point(223, 439)
        Me.pnlPassword.Name = "pnlPassword"
        Me.pnlPassword.Size = New System.Drawing.Size(280, 40)
        Me.pnlPassword.TabIndex = 8
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnOk.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnOk.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnOk.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnOk.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(204, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(48, 37)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "OK"
        Me.btnOk.TextColorDefault = System.Drawing.Color.Black
        Me.btnOk.TextColorDisabled = System.Drawing.Color.Black
        Me.btnOk.TextColorHover = System.Drawing.Color.White
        Me.btnOk.TextColorNormal = System.Drawing.Color.White
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(24, 10)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(35)
        Me.txtPassword.Size = New System.Drawing.Size(176, 20)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.Text = ""
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnExit.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnExit.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnExit.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(164, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 52)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextColorDefault = System.Drawing.Color.Black
        Me.btnExit.TextColorDisabled = System.Drawing.Color.Black
        Me.btnExit.TextColorHover = System.Drawing.Color.White
        Me.btnExit.TextColorNormal = System.Drawing.Color.White
        Me.btnExit.Visible = False
        '
        'lvPaymentStatus
        '
        Me.lvPaymentStatus.BackColor = System.Drawing.Color.Ivory
        Me.lvPaymentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvPaymentStatus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcOrderId, Me.lvcOrderDate, Me.lvcOrderTime, Me.lvcName, Me.lvcBillAddress, Me.lvcNetPay, Me.lvcStatus, Me.lvcUserId, Me.lvcCustomerId, Me.lvcViaPay})
        Me.lvPaymentStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPaymentStatus.FullRowSelect = True
        Me.lvPaymentStatus.GridLines = True
        Me.lvPaymentStatus.Location = New System.Drawing.Point(9, 61)
        Me.lvPaymentStatus.MultiSelect = False
        Me.lvPaymentStatus.Name = "lvPaymentStatus"
        Me.lvPaymentStatus.Size = New System.Drawing.Size(751, 368)
        Me.lvPaymentStatus.TabIndex = 7
        Me.lvPaymentStatus.View = System.Windows.Forms.View.Details
        '
        'lvcOrderId
        '
        Me.lvcOrderId.Text = ""
        Me.lvcOrderId.Width = 0
        '
        'lvcOrderDate
        '
        Me.lvcOrderDate.Text = "Order Date"
        Me.lvcOrderDate.Width = 80
        '
        'lvcOrderTime
        '
        Me.lvcOrderTime.Text = "Order Time"
        Me.lvcOrderTime.Width = 86
        '
        'lvcName
        '
        Me.lvcName.Text = "Customer Name"
        Me.lvcName.Width = 100
        '
        'lvcBillAddress
        '
        Me.lvcBillAddress.Text = "Bill Add/Tab Num"
        Me.lvcBillAddress.Width = 150
        '
        'lvcNetPay
        '
        Me.lvcNetPay.Text = "Net Pay"
        Me.lvcNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvcNetPay.Width = 80
        '
        'lvcStatus
        '
        Me.lvcStatus.Text = "Status"
        Me.lvcStatus.Width = 80
        '
        'lvcUserId
        '
        Me.lvcUserId.Text = "UserId"
        Me.lvcUserId.Width = 81
        '
        'lvcCustomerId
        '
        Me.lvcCustomerId.Width = 0
        '
        'lvcViaPay
        '
        Me.lvcViaPay.Text = "Via Pay"
        Me.lvcViaPay.Width = 108
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnShowPaymentStatus)
        Me.GroupBox1.Controls.Add(Me.dtpToDate)
        Me.GroupBox1.Controls.Add(Me.lbSelectDateTo)
        Me.GroupBox1.Controls.Add(Me.lbSelectDatefrom)
        Me.GroupBox1.Controls.Add(Me.dtpFromDate)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(479, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(8, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnShowPaymentStatus
        '
        Me.btnShowPaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShowPaymentStatus.BackColor = System.Drawing.Color.Transparent
        Me.btnShowPaymentStatus.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnShowPaymentStatus.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnShowPaymentStatus.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnShowPaymentStatus.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnShowPaymentStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPaymentStatus.Location = New System.Drawing.Point(504, 11)
        Me.btnShowPaymentStatus.Name = "btnShowPaymentStatus"
        Me.btnShowPaymentStatus.Size = New System.Drawing.Size(184, 32)
        Me.btnShowPaymentStatus.TabIndex = 6
        Me.btnShowPaymentStatus.Text = "Show Payment Status"
        Me.btnShowPaymentStatus.TextColorDefault = System.Drawing.Color.Black
        Me.btnShowPaymentStatus.TextColorDisabled = System.Drawing.Color.Black
        Me.btnShowPaymentStatus.TextColorHover = System.Drawing.Color.White
        Me.btnShowPaymentStatus.TextColorNormal = System.Drawing.Color.White
        '
        'dtpToDate
        '
        Me.dtpToDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpToDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpToDate.Location = New System.Drawing.Point(360, 15)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpToDate.TabIndex = 4
        Me.dtpToDate.Value = New Date(2006, 9, 23, 0, 0, 0, 0)
        Me.dtpToDate.Visible = False
        '
        'lbSelectDateTo
        '
        Me.lbSelectDateTo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSelectDateTo.Location = New System.Drawing.Point(329, 15)
        Me.lbSelectDateTo.Name = "lbSelectDateTo"
        Me.lbSelectDateTo.Size = New System.Drawing.Size(22, 23)
        Me.lbSelectDateTo.TabIndex = 3
        Me.lbSelectDateTo.Text = "To "
        Me.lbSelectDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbSelectDateTo.Visible = False
        '
        'lbSelectDatefrom
        '
        Me.lbSelectDatefrom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSelectDatefrom.Location = New System.Drawing.Point(72, 15)
        Me.lbSelectDatefrom.Name = "lbSelectDatefrom"
        Me.lbSelectDatefrom.Size = New System.Drawing.Size(128, 23)
        Me.lbSelectDatefrom.TabIndex = 1
        Me.lbSelectDatefrom.Text = "Select Date :     From"
        Me.lbSelectDatefrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbSelectDatefrom.Visible = False
        '
        'dtpFromDate
        '
        Me.dtpFromDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFromDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFromDate.Location = New System.Drawing.Point(212, 15)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpFromDate.TabIndex = 2
        Me.dtpFromDate.Value = New Date(2006, 9, 23, 0, 0, 0, 0)
        Me.dtpFromDate.Visible = False
        '
        'btnUpdatePayment
        '
        Me.btnUpdatePayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdatePayment.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdatePayment.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnUpdatePayment.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnUpdatePayment.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnUpdatePayment.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnUpdatePayment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePayment.Location = New System.Drawing.Point(468, 440)
        Me.btnUpdatePayment.Name = "btnUpdatePayment"
        Me.btnUpdatePayment.Size = New System.Drawing.Size(140, 52)
        Me.btnUpdatePayment.TabIndex = 12
        Me.btnUpdatePayment.Text = "Update Pay Status"
        Me.btnUpdatePayment.TextColorDefault = System.Drawing.Color.Black
        Me.btnUpdatePayment.TextColorDisabled = System.Drawing.Color.Black
        Me.btnUpdatePayment.TextColorHover = System.Drawing.Color.White
        Me.btnUpdatePayment.TextColorNormal = System.Drawing.Color.White
        Me.btnUpdatePayment.Visible = False
        '
        'btnLookUpOk
        '
        Me.btnLookUpOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLookUpOk.BackColor = System.Drawing.Color.Transparent
        Me.btnLookUpOk.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnLookUpOk.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnLookUpOk.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnLookUpOk.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnLookUpOk.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookUpOk.Location = New System.Drawing.Point(524, 440)
        Me.btnLookUpOk.Name = "btnLookUpOk"
        Me.btnLookUpOk.Size = New System.Drawing.Size(88, 52)
        Me.btnLookUpOk.TabIndex = 39
        Me.btnLookUpOk.Text = "Ok"
        Me.btnLookUpOk.TextColorDefault = System.Drawing.Color.Black
        Me.btnLookUpOk.TextColorDisabled = System.Drawing.Color.Black
        Me.btnLookUpOk.TextColorHover = System.Drawing.Color.White
        Me.btnLookUpOk.TextColorNormal = System.Drawing.Color.White
        Me.btnLookUpOk.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnCancel.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnCancel.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnCancel.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnCancel.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(108, 440)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 52)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.TextColorDefault = System.Drawing.Color.Black
        Me.btnCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.btnCancel.TextColorHover = System.Drawing.Color.White
        Me.btnCancel.TextColorNormal = System.Drawing.Color.White
        Me.btnCancel.Visible = False
        '
        'btnKeyBoard
        '
        Me.btnKeyBoard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeyBoard.BackColor = System.Drawing.Color.Transparent
        Me.btnKeyBoard.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnKeyBoard.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnKeyBoard.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnKeyBoard.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnKeyBoard.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyBoard.Location = New System.Drawing.Point(620, 440)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(140, 52)
        Me.btnKeyBoard.TabIndex = 78
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'btnRefundd
        '
        Me.btnRefundd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefundd.BackColor = System.Drawing.Color.Transparent
        Me.btnRefundd.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnRefundd.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnRefundd.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnRefundd.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnRefundd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefundd.Location = New System.Drawing.Point(10, 440)
        Me.btnRefundd.Name = "btnRefundd"
        Me.btnRefundd.Size = New System.Drawing.Size(88, 52)
        Me.btnRefundd.TabIndex = 120
        Me.btnRefundd.Text = "Refund"
        Me.btnRefundd.TextColorDefault = System.Drawing.Color.Black
        Me.btnRefundd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnRefundd.TextColorHover = System.Drawing.Color.White
        Me.btnRefundd.TextColorNormal = System.Drawing.Color.White
        '
        'chkBoxRefund
        '
        Me.chkBoxRefund.Location = New System.Drawing.Point(0, 0)
        Me.chkBoxRefund.Name = "chkBoxRefund"
        Me.chkBoxRefund.TabIndex = 0
        '
        'RPTbtn
        '
        Me.RPTbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RPTbtn.BackColor = System.Drawing.Color.Transparent
        Me.RPTbtn.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.RPTbtn.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.RPTbtn.ButtonColorHover = System.Drawing.Color.Maroon
        Me.RPTbtn.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.RPTbtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPTbtn.Location = New System.Drawing.Point(760, 360)
        Me.RPTbtn.Name = "RPTbtn"
        Me.RPTbtn.Size = New System.Drawing.Size(48, 56)
        Me.RPTbtn.TabIndex = 121
        Me.RPTbtn.Text = "RPT"
        Me.RPTbtn.TextColorDefault = System.Drawing.Color.Black
        Me.RPTbtn.TextColorDisabled = System.Drawing.Color.Black
        Me.RPTbtn.TextColorHover = System.Drawing.Color.White
        Me.RPTbtn.TextColorNormal = System.Drawing.Color.White
        '
        'frmPaymentStatus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(810, 512)
        Me.Controls.Add(Me.btnRefundd)
        Me.Controls.Add(Me.btnKeyBoard)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvPaymentStatus)
        Me.Controls.Add(Me.pnlPassword)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdatePayment)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLookUpOk)
        Me.Controls.Add(Me.RPTbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPaymentStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Status"
        Me.pnlPassword.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents objtaskbarNotifier As TaskBarNotifier

    Private Sub frmPaymentStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iOrderId = 0
        iOkClickCount = 0

        dtpFromDate.Value = DateTime.Now
        dtpToDate.Value = DateTime.Now
        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Payment Status"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Payment Status"
        End If
    End Sub

    Public Sub FillPaymentStatus(ByVal tmpTakeaway As DataSet)

        Dim iCountDataSetRow As Integer
        Dim iIndex As Integer
        Dim dNetPay As Double

        iCountDataSetRow = tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows.Count

        If IsDBNull(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(0).Item(0)) Then
            MessageBox.Show("There is no Order placed", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For iIndex = 0 To iCountDataSetRow - 1
                lvPaymentStatus.Items.Add(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(0))
                lvPaymentStatus.Items(iIndex).SubItems.Add(Format((tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(1)), "dd/MM/yyyy"))
                lvPaymentStatus.Items(iIndex).SubItems.Add(Format((tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(1)), "hh:mm:ss tt"))

                If tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(2) = "" Then
                    lvPaymentStatus.Items(iIndex).SubItems.Add("")
                Else
                    If InStr(Trim((tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(2)).ToUpper), "WAITING CUSTOMER", CompareMethod.Binary) = 1 Then
                        lvPaymentStatus.Items(iIndex).SubItems.Add("")
                    Else
                        lvPaymentStatus.Items(iIndex).SubItems.Add(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(2))
                    End If
                End If

                If (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(11)) = 0 Then
                    If IsDBNull(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(3)) Then
                        lvPaymentStatus.Items(iIndex).SubItems.Add(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(3))
                    Else
                        lvPaymentStatus.Items(iIndex).SubItems.Add(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(3))
                    End If
                Else

                    Dim strSQL As String

                    Dim dsDineInfo As DataSet
                    Dim dsTableInfo As DataSet
                    Dim daDineInfo As SqlClient.SqlDataAdapter

                    strTableNumber = tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(11)
                    strSQL = "SELECT cTableNumber FROM tTable_Info WHERE nTable_Id=" & CStr(strTableNumber) & ""

                    Try
                        dsTableInfo = New DataSet("TableInfo")
                        daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                        daDineInfo.Fill(dsTableInfo, "TableInfo")
                    Catch ex As Exception

                        MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")

                    End Try

                    Dim iIndexx As Integer = 0
                    TableNum = dsTableInfo.Tables("TableInfo").Rows(iIndexx).Item(0)
                    tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(3) = TableNum
                    lvPaymentStatus.Items(iIndex).SubItems.Add(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(3))
                End If


                dNetPay = tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(4)
                lvPaymentStatus.Items(iIndex).SubItems.Add(dNetPay)
                If tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(5) = 1 Then
                    lvPaymentStatus.Items(iIndex).SubItems.Add("Paid")
                Else
                    lvPaymentStatus.Items(iIndex).SubItems.Add("NotPaid")
                End If

                If tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(6) = "" Then
                    lvPaymentStatus.Items(iIndex).SubItems.Add("")
                Else
                    lvPaymentStatus.Items(iIndex).SubItems.Add(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(6))
                End If
                lvPaymentStatus.Items(iIndex).SubItems.Add(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(7))


                If IsDBNull(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(8)) And (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(12)) = 0 Then
                    lvPaymentStatus.Items(iIndex).SubItems.Add("Not Paid")
                ElseIf IsDBNull(tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(8)) And (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(12)) = 2 Then
                    lvPaymentStatus.Items(iIndex).SubItems.Add("Cancelled")
                Else
                    If (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(8)) <> vbNullString And (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(12)) = 1 Then   'IsDBNull
                        lvPaymentStatus.Items(iIndex).SubItems.Add("Cash")

                    ElseIf (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(9)) <> vbNullString And (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(12)) = 1 Then
                        lvPaymentStatus.Items(iIndex).SubItems.Add("Card")


                    ElseIf (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(10)) <> vbNullString And (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(12)) = 1 Then
                        lvPaymentStatus.Items(iIndex).SubItems.Add("Cheque")

                        'for refund purpose we update nOrderstatus into flag-2 and fetching here to refund 

                    ElseIf (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(8)) <> vbNullString And (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(12)) = 2 Then
                        lvPaymentStatus.Items(iIndex).SubItems.Add("Refund")

                    ElseIf (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(9)) <> vbNullString And (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(12)) = 2 Then
                        lvPaymentStatus.Items(iIndex).SubItems.Add("Refund")

                    ElseIf (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(10)) <> vbNullString And (tmpTakeaway.Tables(tmpTakeaway.DataSetName).Rows(iIndex).Item(12)) = 2 Then
                        lvPaymentStatus.Items(iIndex).SubItems.Add("Refund")

                    End If
                End If
            Next
        End If
        tmpTakeaway = Nothing
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Login()
    End Sub

    Private Function Login()

        Dim strSQL As String
        Dim dsSecurityCode As DataSet
        Dim daSecurityCode As SqlClient.SqlDataAdapter

        strSQL = "SELECT cSecurityCode FROM tMasterInfo"

        Try
            dsSecurityCode = New DataSet("SecurityCode")
            daSecurityCode = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daSecurityCode.Fill(dsSecurityCode, "SecurityCode")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        If txtPassword.Text = Trim(dsSecurityCode.Tables("SecurityCode").Rows(0).Item(0)) And iOkClickCount < 3 Then
            txtPassword.Text = vbNullString
            pnlPassword.Visible = False
            bPasswordGiven = True
            iOkClickCount = 0
            btnExit.Visible = True
            btnUpdatePayment.Visible = True
            lbSelectDatefrom.Visible = True
            lbSelectDateTo.Visible = True
            dtpFromDate.Visible = True
            dtpToDate.Visible = True
        Else
            MessageBox.Show("Password is not correct and you have clicked for" & iOkClickCount + 1 & " times.", "Payment status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Text = vbNullString
            iOkClickCount += 1
            bPasswordGiven = False
            If iOkClickCount = 3 Then
                Me.Dispose()
            End If
        End If
    End Function

    Private Sub RefresPaymentStatusGrid()
        Dim iCountDataSetRow As Integer
        Dim strSQL As String

        Dim dsOrderPayment As DataSet
        Dim daOederPayment As SqlClient.SqlDataAdapter

        strSQL = "SELECT P.nOrder_Id,P.dOrder_date,C.cCust_Name,C.cCust_BillAdd,P.mNetpay,P.nOrderStatus," & _
                "P.cUserId,C.nCust_Id FROM tOrder_Payment P,tCust_Info C WHERE P.nCust_Id=C.nCust_Id"

        Try
            dsOrderPayment = New DataSet("PaymentStatus")
            daOederPayment = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daOederPayment.Fill(dsOrderPayment, "PaymentStatus")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsOrderPayment.Tables("PaymentStatus").Rows.Count

        If iCountDataSetRow > 0 Then
            FillPaymentStatus(dsOrderPayment)
        Else
            MessageBox.Show("There is no payment to show", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dsOrderPayment = Nothing
        daOederPayment = Nothing
    End Sub

    Private Sub btnUpdatePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdatePayment.Click
        Dim strSQL As String
        Dim cmdUpdateStatus As SqlClient.SqlCommand

        If iOrderId = 0 Then
            MessageBox.Show("Please select an Order to update", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            strSQL = "UPDATE tOrder_Payment SET nOrderStatus=1 WHERE nOrder_Id=" + CStr(iOrderId) + ""
            Try
                cmdUpdateStatus = New SqlClient.SqlCommand
                cmdUpdateStatus.Connection = mdDBConnection.connRestuarant
                cmdUpdateStatus.CommandText = strSQL
                cmdUpdateStatus.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
            lvPaymentStatus.Items.Clear()
            RefresPaymentStatusGrid()
            iOrderId = 0
        End If
        cmdUpdateStatus = Nothing
    End Sub

    Private Sub lvPaymentStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPaymentStatus.Click
        iOrderId = lvPaymentStatus.SelectedItems(0).Text
    End Sub

    Public Function ShowTaskBarNotifire(ByVal tmpImageName As String, ByVal tmpTitle As String, _
                                       ByVal tmpMessage As String, ByVal tmpTitleRectangle As Rectangle, _
                                       ByVal tmpTextRectangle As Rectangle, ByVal tmpClosingPoint As Point)

        objtaskbarNotifier = New TaskBarNotifier

        With objtaskbarNotifier
            .SetBackgroundBitmap(New Bitmap(MyClass.GetType(), tmpImageName), Color.FromArgb(255, 0, 255))
            .SetCloseBitmap(New Bitmap(MyClass.GetType(), "close.bmp"), Color.FromArgb(255, 0, 255), tmpClosingPoint)
            .TitleRectangle = tmpTitleRectangle
            .TextRectangle = tmpTextRectangle
            .NormalTitleColor = Color.Brown
            .HoverTitleColor = Color.Black
            .NormalContentColor = Color.Yellow
            .HoverContentColor = Color.White
            .CloseButtonClickEnabled = True
            .TitleClickEnabled = False
            .TextClickEnabled = False
            .DrawTextFocusRect = True
            .KeepVisibleOnMouseOver = True
            .ReShowOnMouseOver = True
            .Show(tmpTitle, tmpMessage, 200, 2000, 200)
        End With
    End Function

    Private Sub btnDeleteOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strSQLDelete As String
        Dim strSQL As String
        Dim blnTrans As Boolean

        Dim cmdDeleteOrder As SqlClient.SqlCommand
        Dim trnsDelete As SqlClient.SqlTransaction

        If iOrderId = 0 Then
            MessageBox.Show("Please select an Order to delete", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            strSQLDelete = "DELETE  FROM tOrder_Payment WHERE nOrder_Id=" + CStr(iOrderId) + ""
            strSQL = "DELETE  FROM tOrdered_Item WHERE nOrder_Id=" + CStr(iOrderId) + ""
            Try
                cmdDeleteOrder = New SqlClient.SqlCommand
                cmdDeleteOrder.Connection = mdDBConnection.connRestuarant
                cmdDeleteOrder.CommandText = strSQLDelete
                trnsDelete = mdDBConnection.connRestuarant.BeginTransaction()
                blnTrans = True
                cmdDeleteOrder.Transaction = trnsDelete
                cmdDeleteOrder.ExecuteNonQuery()

                cmdDeleteOrder = Nothing
                cmdDeleteOrder = New SqlClient.SqlCommand
                cmdDeleteOrder.Connection = mdDBConnection.connRestuarant
                cmdDeleteOrder.CommandText = strSQLDelete
                cmdDeleteOrder.Transaction = trnsDelete
                cmdDeleteOrder.ExecuteNonQuery()
            Catch ex As Exception
                If blnTrans = True Then
                    trnsDelete.Rollback()
                    blnTrans = False
                    MsgBox("This error Occurred for: ", MsgBoxStyle.Critical, "Database Error")
                End If
            Finally
                trnsDelete.Commit()
                blnTrans = False
            End Try
            lvPaymentStatus.Items.Clear()
            RefresPaymentStatusGrid()
            iOrderId = 0
        End If
        cmdDeleteOrder = Nothing
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Login()
        End If
    End Sub

    Private Sub lvPaymentStatus_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPaymentStatus.DoubleClick
        Dim lvOrderItem As ListViewItem
        If bPasswordGiven = True Then
            Dim objFrmEditOrder As New frmEditOrder
            objFrmEditOrder.strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
            objFrmEditOrder.strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")
            For Each lvOrderItem In lvPaymentStatus.SelectedItems
                objFrmEditOrder.iOrderId = CInt(Trim(lvOrderItem.SubItems(0).Text))
            Next
            Me.Hide()
            objFrmEditOrder.ShowDialog()
            'changed for refresh
            'Dim strFromDate As String
            'Dim strToDate As String
            ''''''''''''
            Me.Show()
            strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
            strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")
            ShowPaymentInfo(strFromDate, strToDate)
        End If
    End Sub

    Public Function ShowPaymentInfo(ByVal tmpStartDate As String, ByVal tmpTodate As String)

        Dim iCountDataSetRow As Integer
        Dim strSQL As String
        Dim dsOrderPayment As DataSet
        Dim daOederPayment As SqlClient.SqlDataAdapter

        strSQL = "SELECT P.nOrder_Id,P.dOrder_date,C.cCust_Name,C.cCust_BillAdd,P.mNetpay," & _
                 "P.nOrderStatus,P.cUserId,C.nCust_Id,P.mCashPayAmount,P.mCardPayAmount,P.mChequeAmount,P.nTable_Id,P.nOrderStatus FROM tOrder_Payment P,tCust_Info C " & _
                 "WHERE P.nCust_Id=C.nCust_Id AND P.dOrder_date BETWEEN '" & tmpStartDate & _
                 "' AND '" & tmpTodate & "'  and P.nOrderStatus BETWEEN   1 and 2 "

        Try
            dsOrderPayment = New DataSet("PaymentStatus")
            daOederPayment = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daOederPayment.Fill(dsOrderPayment, "PaymentStatus")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsOrderPayment.Tables("PaymentStatus").Rows.Count

        If iCountDataSetRow > 0 Then
            lvPaymentStatus.Items.Clear()
            FillPaymentStatus(dsOrderPayment)
        Else
            lvPaymentStatus.Items.Clear()
        End If
        dsOrderPayment = Nothing
        daOederPayment = Nothing
    End Function

    Private Sub btnShowPaymentStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPaymentStatus.Click
        Dim strFromDate As String
        Dim strToDate As String
        If dtpFromDate.Visible = True And dtpToDate.Visible = True Then
            strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
            strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")

        Else
            strFromDate = DateTime.Parse(Trim(DateTime.Now)).ToString("MM/dd/yyyy 00:00:00")
            strToDate = DateTime.Parse(Trim(DateTime.Now)).ToString("MM/dd/yyyy 23:59:59")
        End If
        'strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
        'strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")
        'strFromDate = DateTime.Parse(Trim(DateTime.Now)).ToString("MM/dd/yyyy 00:00:00")
        'strToDate = DateTime.Parse(Trim(DateTime.Now)).ToString("MM/dd/yyyy 23:59:59")

        ShowPaymentInfo(strFromDate, strToDate)
        btnLookUpOk.Visible = False 'added 03.02.2008 in london 
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnLookUpOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLookUpOk.Click

        Dim strImageName As String = "skin1.bmp"
        Dim strTitel As String = " "
        Dim strMessage As String = "Please Select an Order from the above Grid"
        Dim recTitleRectangle As New Rectangle(148, 50, 200, 28)
        Dim recTextRectangle As New Rectangle(90, 92, 200, 55)
        Dim pClosingPoint As New Point(280, 58)

        If lvPaymentStatus.SelectedItems.Count = 1 Then

            strfindcode = lvPaymentStatus.SelectedItems(0).Text
            strfindDesc = lvPaymentStatus.SelectedItems(0).SubItems(8).Text
            Me.Dispose()
        Else
            ShowTaskBarNotifire(strImageName, strTitel, strMessage, recTitleRectangle, recTextRectangle, pClosingPoint)
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnKeyBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyBoard.Click
        If Not IsNothing(objfrmKeyBoard) Then
            If Not objfrmKeyBoard.IsDisposed() Then
                objfrmKeyBoard.Show()
                objfrmKeyBoard.WindowState = FormWindowState.Normal
                objfrmKeyBoard.BringToFront()
            Else
                objfrmKeyBoard = New frmKeyBoard
                objfrmKeyBoard.Show()
            End If
        Else
            objfrmKeyBoard = New frmKeyBoard
            objfrmKeyBoard.Show()
        End If
    End Sub

    Private Sub btnRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefundd.Click

        'chkBoxRefund.Checked = True
        'Dim srt1 As String = "Cash"
        'Dim strSQL As String
        'Dim cmdUpdate As SqlClient.SqlCommand
        'Dim tnsAll As SqlClient.SqlTransaction

        'refund = lvPaymentStatus.SelectedItems(0).SubItems(9).Text

        'If InStr(1, refund, srt1, CompareMethod.Binary) = 1 Then
        '    strSQL = "UPDATE tOrder_Payment SET mCashPayAmount=refund WHERE nOrder_Id=" & CStr(iOrderId) & ""
        '    cmdUpdate = New SqlClient.SqlCommand
        '    tnsAll = mdDBConnection.connRestuarant.BeginTransaction()
        '    cmdUpdate.Transaction = tnsAll
        '    cmdUpdate.Connection = mdDBConnection.connRestuarant
        '    cmdUpdate.CommandText = strSQL
        '    cmdUpdate.ExecuteNonQuery()
        '    tnsAll.Commit()
        'End If
        Dim strImageName As String = "skin1.bmp"
        Dim strTitel As String = " "
        Dim strMessage As String = "Please Select an Order from the above Grid"
        Dim recTitleRectangle As New Rectangle(148, 50, 200, 28)
        Dim recTextRectangle As New Rectangle(90, 92, 200, 55)
        Dim pClosingPoint As New Point(280, 58)


        Dim strSQL As String
        Dim cmdUpdate As SqlClient.SqlCommand
        Dim tnsAll As SqlClient.SqlTransaction
        Dim strFromDate As String
        Dim strToDate As String

        If lvPaymentStatus.SelectedItems.Count = 1 Then

            strSQL = "UPDATE  tOrder_Payment set nOrderStatus=2 WHERE nOrder_Id=" & CStr(iOrderId) & ""
            cmdUpdate = New SqlClient.SqlCommand
            tnsAll = mdDBConnection.connRestuarant.BeginTransaction()
            cmdUpdate.Transaction = tnsAll
            cmdUpdate.Connection = mdDBConnection.connRestuarant
            cmdUpdate.CommandText = strSQL
            cmdUpdate.ExecuteNonQuery()
            tnsAll.Commit()


            Dim dsDineInfo As DataSet
            Dim daDineInfo As SqlClient.SqlDataAdapter
            Dim GuestNum As String
            Dim GNUM As Integer

            strSQL = "select nTable_Id,nNumberofGuests from tOrder_Payment WHERE nOrder_Id=" & CStr(iOrderId) & ""

            Try
                dsDineInfo = New DataSet("DineInfo")
                daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                daDineInfo.Fill(dsDineInfo, "DineInfo")
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
            'iCountDataSetRow = dsDineInfo.Tables("DineInfo").Rows.Count
            strTableNumber = dsDineInfo.Tables("DineInfo").Rows(0).Item(0)
            'GuestNum = dsDineInfo.Tables("DineInfo").Rows(0).Item(1)
            'GNUM = CInt(GuestNum)
            If strTableNumber <> vbNullString And IsDBNull(dsDineInfo.Tables("DineInfo").Rows(0).Item(1)) Then

                Me.lvPaymentStatus.Items.Clear()
                Call NotPaidStatusTakeway()
            Else
                GNUM = CInt(dsDineInfo.Tables("DineInfo").Rows(0).Item(1))
                If GNUM > 0 Then
                    strSQL = "UPDATE tTable_Info SET nStatus=0 WHERE nTable_Id=" + CStr(strTableNumber) + ""
                    cmdUpdate = New SqlClient.SqlCommand
                    tnsAll = mdDBConnection.connRestuarant.BeginTransaction()
                    cmdUpdate.Transaction = tnsAll
                    cmdUpdate.Connection = mdDBConnection.connRestuarant
                    cmdUpdate.CommandText = strSQL
                    cmdUpdate.ExecuteNonQuery()
                    tnsAll.Commit()
                    'strTableNumber = ""
                    Me.lvPaymentStatus.Items.Clear()
                    Call NotPaidStatus()

                Else
                    Me.lvPaymentStatus.Items.Clear()
                    Call NotPaidStatusTakeway()

                End If

            End If

        Else

            ShowTaskBarNotifire(strImageName, strTitel, strMessage, recTitleRectangle, recTextRectangle, pClosingPoint)

        End If



    End Sub

    Private Sub RPTbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RPTbtn.Click

        Dim strImageName As String = "skin1.bmp"
        Dim strTitel As String = " "
        Dim strMessage As String = "Please Select an Order from the above Grid"
        Dim recTitleRectangle As New Rectangle(148, 50, 200, 28)
        Dim recTextRectangle As New Rectangle(90, 92, 200, 55)
        Dim pClosingPoint As New Point(280, 58)

        If lvPaymentStatus.SelectedItems.Count = 1 Then

            Dim dsDineInfo As DataSet
            Dim daDineInfo As SqlClient.SqlDataAdapter
            Dim GuestNum As String
            Dim GNUM As Integer
            Dim strSQL As String

            strSQL = "select nTable_Id,nNumberofGuests from tOrder_Payment WHERE nOrder_Id=" & CStr(iOrderId) & ""

            Try
                dsDineInfo = New DataSet("DineInfo")
                daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                daDineInfo.Fill(dsDineInfo, "DineInfo")
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try

            strTableNumber = dsDineInfo.Tables("DineInfo").Rows(0).Item(0)
            
            If strTableNumber <> vbNullString And IsDBNull(dsDineInfo.Tables("DineInfo").Rows(0).Item(1)) Then

                strfindcode = lvPaymentStatus.SelectedItems(0).Text
                strfindDesc = lvPaymentStatus.SelectedItems(0).SubItems(8).Text
                Dim objTake As New frmTakeaway
                objTake.PaymentStatusPurpose()
                objTake.PrintBill()
                objTake.ClearAllField()
                strfindcode = ""
                strfindDesc = ""
                'End If
            Else

                GNUM = CInt(dsDineInfo.Tables("DineInfo").Rows(0).Item(1))
                'GNUM = CInt(GuestNum)
                If GNUM > 0 Then
                    strfindcode = lvPaymentStatus.SelectedItems(0).Text
                    strfindDesc = lvPaymentStatus.SelectedItems(0).SubItems(8).Text
                    'Me.Dispose()
                    Dim objDine As New frmDine
                    objDine.PaymentStatusPurpose()
                    objDine.PrintBill()
                    objDine.ClearAllField()
                    strfindcode = ""
                    strfindDesc = ""
                Else
                    strfindcode = lvPaymentStatus.SelectedItems(0).Text
                    strfindDesc = lvPaymentStatus.SelectedItems(0).SubItems(8).Text
                    Dim objTake As New frmTakeaway
                    objTake.PaymentStatusPurpose()
                    objTake.PrintBill()
                    objTake.ClearAllField()
                    strfindcode = ""
                    strfindDesc = ""

                End If
            End If


            'If lvPaymentStatus.SelectedItems(0).SubItems(3).Text = vbNullString Then
            '    strfindcode = lvPaymentStatus.SelectedItems(0).Text
            '    strfindDesc = lvPaymentStatus.SelectedItems(0).SubItems(8).Text
            '    'Me.Dispose()
            '    Dim objDine As New frmDine
            '    objDine.PaymentStatusPurpose()
            '    objDine.PrintBill()
            '    objDine.ClearAllField()
            '    strfindcode = ""
            '    strfindDesc = ""



            'Else

            '    strfindcode = lvPaymentStatus.SelectedItems(0).Text
            '    strfindDesc = lvPaymentStatus.SelectedItems(0).SubItems(8).Text
            '    Dim objTake As New frmTakeaway
            '    objTake.PaymentStatusPurpose()
            '    objTake.PrintBill()
            '    objTake.ClearAllField()
            '    strfindcode = ""
            '    strfindDesc = ""

            ' End If

        Else

        ShowTaskBarNotifire(strImageName, strTitel, strMessage, recTitleRectangle, recTextRectangle, pClosingPoint)

        End If

    End Sub

    Private Function NotPaidStatus()
        Dim iCountDataSetRow As Integer
        Dim strSQL As String


        Dim dsDineInfo As DataSet
        Dim daDineInfo As SqlClient.SqlDataAdapter
        Dim objfrmPaymentStatus As New frmPaymentStatus



        strSQL = "SELECT P.nOrder_Id,P.dOrder_date,C.cCust_Name,C.cCust_BillAdd,P.mNetpay,P.nOrderStatus," & _
                 "P.cUserId,C.nCust_Id,P.mCashPayAmount,P.mCardPayAmount,P.mChequeAmount,P.nTable_Id,P.nOrderStatus FROM tOrder_Payment P,tCust_Info C WHERE P.nCust_Id=C.nCust_Id AND " & _
                 "P.nOrderStatus=0 AND P.nTable_Id<>0"

        Try
            dsDineInfo = New DataSet("DineInfo")
            daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daDineInfo.Fill(dsDineInfo, "DineInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        iCountDataSetRow = dsDineInfo.Tables("DineInfo").Rows.Count

        If iCountDataSetRow > 0 Then

            FillPaymentStatus(dsDineInfo)

        Else

            MessageBox.Show("There is no Due payment to show", "DineIn", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        End If

    End Function

    Private Function NotPaidStatusTakeway()
        Dim iCountDataSetRow As Integer
        Dim strSQL As String


        Dim dsDineInfo As DataSet
        Dim daDineInfo As SqlClient.SqlDataAdapter
        Dim objfrmPaymentStatus As New frmPaymentStatus



        strSQL = "SELECT P.nOrder_Id,P.dOrder_date,C.cCust_Name,C.cCust_BillAdd,P.mNetpay," & _
                 "P.nOrderStatus,P.cUserId,C.nCust_Id,P.mCashPayAmount,P.mCardPayAmount,P.mChequeAmount,P.nTable_Id,P.nOrderStatus FROM tOrder_Payment P,tCust_Info C " & _
                 "WHERE P.nCust_Id=C.nCust_Id AND P.nOrderStatus=0 AND P.nTable_Id=0"

        Try
            dsDineInfo = New DataSet("DineInfo")
            daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daDineInfo.Fill(dsDineInfo, "DineInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        iCountDataSetRow = dsDineInfo.Tables("DineInfo").Rows.Count

        If iCountDataSetRow > 0 Then

            FillPaymentStatus(dsDineInfo)

        Else

            MessageBox.Show("There is no Due payment to show", "DineIn", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        End If

    End Function

End Class

