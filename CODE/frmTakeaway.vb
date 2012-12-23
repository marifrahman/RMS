
Imports System.Globalization
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmTakeaway
    Inherits System.Windows.Forms.Form

    Dim iOrderId As Integer
    Dim strItemInfo(,) As String
    Dim conControlName As Control

    Private bPrint As Boolean = False

    Dim WithEvents objfrmKeyBoard As frmKeyBoard

    Private WithEvents objtaskbarNotifier As TaskBarNotifier

    Dim bCboLoad As Boolean
    Dim gError As Boolean
    Dim bClickedBefore As Boolean = False

    Dim strClickTypeName As String
    Dim strNewClickType As String

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

    'Public Shared Sub Main()
    '    Dim VSContext = Skybound.VisualStyles.VisualStyleContext.Create
    '    Application.Run(New frmTakeaway)
    'End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tabTakeaway As System.Windows.Forms.TabControl
    Friend WithEvents tbpgCustInfo As System.Windows.Forms.TabPage
    Friend WithEvents lblTotalPrice As System.Windows.Forms.TabPage
    Friend WithEvents tbpgPayment As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents gbBasicInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtFaxNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents txtReviews As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverDic As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtBillAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtCardHolder As System.Windows.Forms.TextBox
    Friend WithEvents txtExpiryDate As System.Windows.Forms.TextBox
    Friend WithEvents txtValidFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtIssueNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCreditCard As System.Windows.Forms.TextBox
    Friend WithEvents txtLastOrderDate As System.Windows.Forms.TextBox
    Friend WithEvents txtDateOfEntry As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents xpnLstMain As XPanderControl.XPanderList
    Friend WithEvents xpndLstScnd As XPanderControl.XPanderList
    Friend WithEvents xpndrItems As XPanderControl.XPander
    Friend WithEvents txtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lvOrder As System.Windows.Forms.ListView
    Friend WithEvents cQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents cItem As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents cInstruction As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cStockInHand As System.Windows.Forms.ColumnHeader
    Friend WithEvents cServeLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboInstruction As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblTotalOrderPrice As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cboTips As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboDiscount As System.Windows.Forms.ComboBox
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents txtTips As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtCashPay As System.Windows.Forms.TextBox
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents txtChequeNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents txtChequePay As System.Windows.Forms.TextBox
    Friend WithEvents txtCardPay As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboCardType As System.Windows.Forms.ComboBox
    Friend WithEvents chkAccumulate As System.Windows.Forms.CheckBox
    Friend WithEvents chkReprint As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gbPaymentInformation As System.Windows.Forms.GroupBox
    Friend WithEvents gbPrintOrder As System.Windows.Forms.GroupBox
    Friend WithEvents gbPriceCalculation As System.Windows.Forms.GroupBox
    Friend WithEvents gbPriceInformation As System.Windows.Forms.GroupBox
    Friend WithEvents gbAdditionalInformation As System.Windows.Forms.GroupBox
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    Friend WithEvents btCanceOrder As MACButtonLib.MACButton
    Friend WithEvents btnSubmit As MACButtonLib.MACButton
    Friend WithEvents btnPayment As MACButtonLib.MACButton
    Friend WithEvents btnAdministrate As MACButtonLib.MACButton
    Friend WithEvents btnDine As MACButtonLib.MACButton
    Friend WithEvents btnClear As MACButtonLib.MACButton
    Friend WithEvents btnRefreshMenu As MACButtonLib.MACButton
    Friend WithEvents btnRemove As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnBckSpace As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents btnMultiply As MACButtonLib.MACButton
    Friend WithEvents btnDot As MACButtonLib.MACButton
    Friend WithEvents btn0 As MACButtonLib.MACButton
    Friend WithEvents btn9 As MACButtonLib.MACButton
    Friend WithEvents btn8 As MACButtonLib.MACButton
    Friend WithEvents btn7 As MACButtonLib.MACButton
    Friend WithEvents btn6 As MACButtonLib.MACButton
    Friend WithEvents btn5 As MACButtonLib.MACButton
    Friend WithEvents btn4 As MACButtonLib.MACButton
    Friend WithEvents btn3 As MACButtonLib.MACButton
    Friend WithEvents btn2 As MACButtonLib.MACButton
    Friend WithEvents btn1 As MACButtonLib.MACButton
    Friend WithEvents btnLevelPrint As MACButtonLib.MACButton
    Friend WithEvents btnKitchPrint As MACButtonLib.MACButton
    Friend WithEvents btBillPrint As MACButtonLib.MACButton
    Friend WithEvents btnAllPrint As MACButtonLib.MACButton
    Friend WithEvents btntillOpen As MACButtonLib.MACButton
    Friend WithEvents btnPay As MACButtonLib.MACButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDriverName As System.Windows.Forms.TextBox
    Friend WithEvents cboDriverNumber As System.Windows.Forms.ComboBox
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cCustomerName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCity As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPostCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCustPhone As System.Windows.Forms.ColumnHeader
    Friend WithEvents cFaxNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents cId As System.Windows.Forms.ColumnHeader
    Friend WithEvents stxtMain As ScrollingTextControl.ScrollingText
    Friend WithEvents CtypeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel As MACButtonLib.MACButton
    Friend WithEvents btnMinimize As MACButtonLib.MACButton
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents btnPayBill As MACButtonLib.MACButton
    Friend WithEvents btnUpItem As MACButtonLib.MACButton
    Friend WithEvents btnDownItem As MACButtonLib.MACButton
    Friend WithEvents btnDownType As MACButtonLib.MACButton
    Friend WithEvents btnUpType As MACButtonLib.MACButton
    Friend WithEvents AxActiveCID1 As AxActiveCIDctl.AxActiveCID
    Friend WithEvents btnwaitingCust As MACButtonLib.MACButton
    Friend WithEvents chkBoxWaitingCust As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxPayBill As System.Windows.Forms.CheckBox
    Friend WithEvents btnCollection As MACButtonLib.MACButton
    Friend WithEvents chkBoxCollection As System.Windows.Forms.CheckBox
    Friend WithEvents MacButton1 As MACButtonLib.MACButton
    Friend WithEvents btnRefund As MACButtonLib.MACButton
    Friend WithEvents lbTotalQty As System.Windows.Forms.Label
    Friend WithEvents lbQty As System.Windows.Forms.Label
    Friend WithEvents cCheckBox As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkReprintWAY As System.Windows.Forms.CheckBox
    Friend WithEvents cQtyRemaning As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUser As MACButtonLib.MACButton

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTakeaway))
        Me.tabTakeaway = New System.Windows.Forms.TabControl
        Me.tbpgCustInfo = New System.Windows.Forms.TabPage
        Me.AxActiveCID1 = New AxActiveCIDctl.AxActiveCID
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cId = New System.Windows.Forms.ColumnHeader
        Me.cCustomerName = New System.Windows.Forms.ColumnHeader
        Me.cCustPhone = New System.Windows.Forms.ColumnHeader
        Me.cPostCode = New System.Windows.Forms.ColumnHeader
        Me.cCity = New System.Windows.Forms.ColumnHeader
        Me.cAddress = New System.Windows.Forms.ColumnHeader
        Me.cFaxNumber = New System.Windows.Forms.ColumnHeader
        Me.gbAdditionalInformation = New System.Windows.Forms.GroupBox
        Me.cboDriverNumber = New System.Windows.Forms.ComboBox
        Me.txtDriverName = New System.Windows.Forms.TextBox
        Me.txtExpiryDate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.btnClear = New MACButtonLib.MACButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.txtFaxNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtURL = New System.Windows.Forms.TextBox
        Me.txtReviews = New System.Windows.Forms.TextBox
        Me.txtDriverDic = New System.Windows.Forms.TextBox
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtBillAddress = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtCardHolder = New System.Windows.Forms.TextBox
        Me.txtValidFrom = New System.Windows.Forms.TextBox
        Me.txtIssueNo = New System.Windows.Forms.TextBox
        Me.txtCreditCard = New System.Windows.Forms.TextBox
        Me.txtLastOrderDate = New System.Windows.Forms.TextBox
        Me.txtDateOfEntry = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.gbBasicInfo = New System.Windows.Forms.GroupBox
        Me.chkBoxWaitingCust = New System.Windows.Forms.CheckBox
        Me.txtTown = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnCollection = New MACButtonLib.MACButton
        Me.btnwaitingCust = New MACButtonLib.MACButton
        Me.txtCustomerNo = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtPostCode = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.lblTotalPrice = New System.Windows.Forms.TabPage
        Me.chkReprintWAY = New System.Windows.Forms.CheckBox
        Me.lbQty = New System.Windows.Forms.Label
        Me.lbTotalQty = New System.Windows.Forms.Label
        Me.btnDownType = New MACButtonLib.MACButton
        Me.btnUpType = New MACButtonLib.MACButton
        Me.btnDownItem = New MACButtonLib.MACButton
        Me.btnUpItem = New MACButtonLib.MACButton
        Me.btnRefreshMenu = New MACButtonLib.MACButton
        Me.btnRemove = New MACButtonLib.MACButton
        Me.lblTotalOrderPrice = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lvOrder = New System.Windows.Forms.ListView
        Me.cCheckBox = New System.Windows.Forms.ColumnHeader
        Me.cQty = New System.Windows.Forms.ColumnHeader
        Me.cItem = New System.Windows.Forms.ColumnHeader
        Me.cPrice = New System.Windows.Forms.ColumnHeader
        Me.cInstruction = New System.Windows.Forms.ColumnHeader
        Me.ItemId = New System.Windows.Forms.ColumnHeader
        Me.cStockInHand = New System.Windows.Forms.ColumnHeader
        Me.cServeLocation = New System.Windows.Forms.ColumnHeader
        Me.CtypeName = New System.Windows.Forms.ColumnHeader
        Me.cQtyRemaning = New System.Windows.Forms.ColumnHeader
        Me.cboInstruction = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.xpnLstMain = New XPanderControl.XPanderList
        Me.xpndLstScnd = New XPanderControl.XPanderList
        Me.xpndrItems = New XPanderControl.XPander
        Me.btnKitchPrint = New MACButtonLib.MACButton
        Me.tbpgPayment = New System.Windows.Forms.TabPage
        Me.gbPaymentInformation = New System.Windows.Forms.GroupBox
        Me.btnRefund = New MACButtonLib.MACButton
        Me.btnPayBill = New MACButtonLib.MACButton
        Me.btnPay = New MACButtonLib.MACButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCashPay = New System.Windows.Forms.TextBox
        Me.txtBankName = New System.Windows.Forms.TextBox
        Me.txtChequeNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtChange = New System.Windows.Forms.TextBox
        Me.lblChange = New System.Windows.Forms.Label
        Me.txtChequePay = New System.Windows.Forms.TextBox
        Me.txtCardPay = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cboCardType = New System.Windows.Forms.ComboBox
        Me.chkAccumulate = New System.Windows.Forms.CheckBox
        Me.chkReprint = New System.Windows.Forms.CheckBox
        Me.gbPrintOrder = New System.Windows.Forms.GroupBox
        Me.btnLevelPrint = New MACButtonLib.MACButton
        Me.btBillPrint = New MACButtonLib.MACButton
        Me.btnAllPrint = New MACButtonLib.MACButton
        Me.gbPriceCalculation = New System.Windows.Forms.GroupBox
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnBckSpace = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.btnMultiply = New MACButtonLib.MACButton
        Me.btnDot = New MACButtonLib.MACButton
        Me.btn0 = New MACButtonLib.MACButton
        Me.btn9 = New MACButtonLib.MACButton
        Me.btn8 = New MACButtonLib.MACButton
        Me.btn7 = New MACButtonLib.MACButton
        Me.btn6 = New MACButtonLib.MACButton
        Me.btn5 = New MACButtonLib.MACButton
        Me.btn4 = New MACButtonLib.MACButton
        Me.btn3 = New MACButtonLib.MACButton
        Me.btn2 = New MACButtonLib.MACButton
        Me.btn1 = New MACButtonLib.MACButton
        Me.gbPriceInformation = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.cboTips = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboDiscount = New System.Windows.Forms.ComboBox
        Me.txtNetPay = New System.Windows.Forms.TextBox
        Me.txtTips = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotalPrice = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MacButton1 = New MACButtonLib.MACButton
        Me.chkBoxCollection = New System.Windows.Forms.CheckBox
        Me.btntillOpen = New MACButtonLib.MACButton
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.btnDine = New MACButtonLib.MACButton
        Me.btCanceOrder = New MACButtonLib.MACButton
        Me.btnSubmit = New MACButtonLib.MACButton
        Me.btnPayment = New MACButtonLib.MACButton
        Me.btnAdministrate = New MACButtonLib.MACButton
        Me.stxtMain = New ScrollingTextControl.ScrollingText
        Me.btnCancel = New MACButtonLib.MACButton
        Me.btnMinimize = New MACButtonLib.MACButton
        Me.btnUser = New MACButtonLib.MACButton
        Me.tabTakeaway.SuspendLayout()
        Me.tbpgCustInfo.SuspendLayout()
        CType(Me.AxActiveCID1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAdditionalInformation.SuspendLayout()
        Me.gbBasicInfo.SuspendLayout()
        Me.lblTotalPrice.SuspendLayout()
        Me.xpndLstScnd.SuspendLayout()
        Me.tbpgPayment.SuspendLayout()
        Me.gbPaymentInformation.SuspendLayout()
        Me.gbPrintOrder.SuspendLayout()
        Me.gbPriceCalculation.SuspendLayout()
        Me.gbPriceInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabTakeaway
        '
        Me.tabTakeaway.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tabTakeaway.Controls.Add(Me.tbpgCustInfo)
        Me.tabTakeaway.Controls.Add(Me.lblTotalPrice)
        Me.tabTakeaway.Controls.Add(Me.tbpgPayment)
        Me.tabTakeaway.Font = New System.Drawing.Font("Times New Roman", 12.5!, System.Drawing.FontStyle.Bold)
        Me.tabTakeaway.ImageList = Me.ImageList1
        Me.tabTakeaway.Location = New System.Drawing.Point(4, 50)
        Me.tabTakeaway.Name = "tabTakeaway"
        Me.tabTakeaway.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabTakeaway.SelectedIndex = 0
        Me.tabTakeaway.Size = New System.Drawing.Size(792, 480)
        Me.tabTakeaway.TabIndex = 0
        '
        'tbpgCustInfo
        '
        Me.tbpgCustInfo.BackColor = System.Drawing.Color.Ivory
        Me.tbpgCustInfo.BackgroundImage = CType(resources.GetObject("tbpgCustInfo.BackgroundImage"), System.Drawing.Image)
        Me.tbpgCustInfo.Controls.Add(Me.AxActiveCID1)
        Me.tbpgCustInfo.Controls.Add(Me.lvLookUp)
        Me.tbpgCustInfo.Controls.Add(Me.gbAdditionalInformation)
        Me.tbpgCustInfo.Controls.Add(Me.gbBasicInfo)
        Me.tbpgCustInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpgCustInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbpgCustInfo.ImageIndex = 0
        Me.tbpgCustInfo.Location = New System.Drawing.Point(4, 31)
        Me.tbpgCustInfo.Name = "tbpgCustInfo"
        Me.tbpgCustInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbpgCustInfo.Size = New System.Drawing.Size(784, 445)
        Me.tbpgCustInfo.TabIndex = 0
        Me.tbpgCustInfo.Text = "Customer Information    "
        '
        'AxActiveCID1
        '
        Me.AxActiveCID1.ContainingControl = Me
        Me.AxActiveCID1.Enabled = True
        Me.AxActiveCID1.Location = New System.Drawing.Point(232, 496)
        Me.AxActiveCID1.Name = "AxActiveCID1"
        Me.AxActiveCID1.OcxState = CType(resources.GetObject("AxActiveCID1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxActiveCID1.Size = New System.Drawing.Size(32, 34)
        Me.AxActiveCID1.TabIndex = 93
        '
        'lvLookUp
        '
        Me.lvLookUp.BackColor = System.Drawing.Color.Ivory
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cId, Me.cCustomerName, Me.cCustPhone, Me.cPostCode, Me.cCity, Me.cAddress, Me.cFaxNumber})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(8, 488)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(766, 258)
        Me.lvLookUp.TabIndex = 92
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        Me.lvLookUp.Visible = False
        '
        'cId
        '
        Me.cId.Text = "ID"
        Me.cId.Width = 0
        '
        'cCustomerName
        '
        Me.cCustomerName.Text = "Name"
        Me.cCustomerName.Width = 200
        '
        'cCustPhone
        '
        Me.cCustPhone.Text = "Phone"
        Me.cCustPhone.Width = 100
        '
        'cPostCode
        '
        Me.cPostCode.Text = "Post Code"
        Me.cPostCode.Width = 70
        '
        'cCity
        '
        Me.cCity.Text = "City"
        Me.cCity.Width = 100
        '
        'cAddress
        '
        Me.cAddress.Text = "Address"
        Me.cAddress.Width = 296
        '
        'cFaxNumber
        '
        Me.cFaxNumber.Text = ""
        Me.cFaxNumber.Width = 0
        '
        'gbAdditionalInformation
        '
        Me.gbAdditionalInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAdditionalInformation.Controls.Add(Me.cboDriverNumber)
        Me.gbAdditionalInformation.Controls.Add(Me.txtDriverName)
        Me.gbAdditionalInformation.Controls.Add(Me.txtExpiryDate)
        Me.gbAdditionalInformation.Controls.Add(Me.Label10)
        Me.gbAdditionalInformation.Controls.Add(Me.Label42)
        Me.gbAdditionalInformation.Controls.Add(Me.btnClear)
        Me.gbAdditionalInformation.Controls.Add(Me.Label4)
        Me.gbAdditionalInformation.Controls.Add(Me.txtMobile)
        Me.gbAdditionalInformation.Controls.Add(Me.txtFaxNo)
        Me.gbAdditionalInformation.Controls.Add(Me.Label3)
        Me.gbAdditionalInformation.Controls.Add(Me.txtURL)
        Me.gbAdditionalInformation.Controls.Add(Me.txtReviews)
        Me.gbAdditionalInformation.Controls.Add(Me.txtDriverDic)
        Me.gbAdditionalInformation.Controls.Add(Me.txtComments)
        Me.gbAdditionalInformation.Controls.Add(Me.txtEmail)
        Me.gbAdditionalInformation.Controls.Add(Me.txtBillAddress)
        Me.gbAdditionalInformation.Controls.Add(Me.Label24)
        Me.gbAdditionalInformation.Controls.Add(Me.txtCardHolder)
        Me.gbAdditionalInformation.Controls.Add(Me.txtValidFrom)
        Me.gbAdditionalInformation.Controls.Add(Me.txtIssueNo)
        Me.gbAdditionalInformation.Controls.Add(Me.txtCreditCard)
        Me.gbAdditionalInformation.Controls.Add(Me.txtLastOrderDate)
        Me.gbAdditionalInformation.Controls.Add(Me.txtDateOfEntry)
        Me.gbAdditionalInformation.Controls.Add(Me.Label9)
        Me.gbAdditionalInformation.Controls.Add(Me.Label8)
        Me.gbAdditionalInformation.Controls.Add(Me.Label7)
        Me.gbAdditionalInformation.Controls.Add(Me.Label6)
        Me.gbAdditionalInformation.Controls.Add(Me.Label5)
        Me.gbAdditionalInformation.Controls.Add(Me.Label33)
        Me.gbAdditionalInformation.Controls.Add(Me.Label39)
        Me.gbAdditionalInformation.Controls.Add(Me.Label40)
        Me.gbAdditionalInformation.Controls.Add(Me.Label41)
        Me.gbAdditionalInformation.Controls.Add(Me.Label43)
        Me.gbAdditionalInformation.Controls.Add(Me.Label44)
        Me.gbAdditionalInformation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbAdditionalInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAdditionalInformation.ForeColor = System.Drawing.Color.Maroon
        Me.gbAdditionalInformation.Location = New System.Drawing.Point(8, 167)
        Me.gbAdditionalInformation.Name = "gbAdditionalInformation"
        Me.gbAdditionalInformation.Size = New System.Drawing.Size(770, 262)
        Me.gbAdditionalInformation.TabIndex = 17
        Me.gbAdditionalInformation.TabStop = False
        Me.gbAdditionalInformation.Text = "Additional Information"
        '
        'cboDriverNumber
        '
        Me.cboDriverNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboDriverNumber.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cboDriverNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDriverNumber.Location = New System.Drawing.Point(426, 168)
        Me.cboDriverNumber.MaxLength = 20
        Me.cboDriverNumber.Name = "cboDriverNumber"
        Me.cboDriverNumber.Size = New System.Drawing.Size(48, 23)
        Me.cboDriverNumber.TabIndex = 45
        '
        'txtDriverName
        '
        Me.txtDriverName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDriverName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDriverName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDriverName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(475, 168)
        Me.txtDriverName.MaxLength = 50
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.ReadOnly = True
        Me.txtDriverName.Size = New System.Drawing.Size(135, 21)
        Me.txtDriverName.TabIndex = 46
        Me.txtDriverName.Text = ""
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExpiryDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpiryDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiryDate.Location = New System.Drawing.Point(123, 197)
        Me.txtExpiryDate.MaxLength = 10
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(185, 21)
        Me.txtExpiryDate.TabIndex = 31
        Me.txtExpiryDate.Text = ""
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(307, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Driver Direction"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(314, 168)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(105, 20)
        Me.Label42.TabIndex = 44
        Me.Label42.Text = "Driver Info."
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnClear.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnClear.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnClear.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(628, 192)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 56)
        Me.btnClear.TabIndex = 51
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColorDefault = System.Drawing.Color.Black
        Me.btnClear.TextColorDisabled = System.Drawing.Color.Black
        Me.btnClear.TextColorHover = System.Drawing.Color.White
        Me.btnClear.TextColorNormal = System.Drawing.Color.White
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(9, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Date Of Entry"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMobile
        '
        Me.txtMobile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMobile.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(426, 23)
        Me.txtMobile.MaxLength = 20
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(185, 21)
        Me.txtMobile.TabIndex = 35
        Me.txtMobile.Text = ""
        '
        'txtFaxNo
        '
        Me.txtFaxNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFaxNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtFaxNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFaxNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaxNo.Location = New System.Drawing.Point(123, 226)
        Me.txtFaxNo.MaxLength = 20
        Me.txtFaxNo.Name = "txtFaxNo"
        Me.txtFaxNo.Size = New System.Drawing.Size(185, 21)
        Me.txtFaxNo.TabIndex = 33
        Me.txtFaxNo.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(9, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fax No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtURL
        '
        Me.txtURL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtURL.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtURL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtURL.Location = New System.Drawing.Point(426, 110)
        Me.txtURL.MaxLength = 25
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(185, 21)
        Me.txtURL.TabIndex = 41
        Me.txtURL.Text = ""
        '
        'txtReviews
        '
        Me.txtReviews.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtReviews.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtReviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReviews.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReviews.Location = New System.Drawing.Point(426, 226)
        Me.txtReviews.MaxLength = 50
        Me.txtReviews.Name = "txtReviews"
        Me.txtReviews.Size = New System.Drawing.Size(185, 21)
        Me.txtReviews.TabIndex = 50
        Me.txtReviews.Text = ""
        '
        'txtDriverDic
        '
        Me.txtDriverDic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDriverDic.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDriverDic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDriverDic.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverDic.Location = New System.Drawing.Point(426, 197)
        Me.txtDriverDic.MaxLength = 50
        Me.txtDriverDic.Name = "txtDriverDic"
        Me.txtDriverDic.Size = New System.Drawing.Size(185, 21)
        Me.txtDriverDic.TabIndex = 48
        Me.txtDriverDic.Text = ""
        '
        'txtComments
        '
        Me.txtComments.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtComments.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComments.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(426, 139)
        Me.txtComments.MaxLength = 50
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(185, 21)
        Me.txtComments.TabIndex = 43
        Me.txtComments.Text = ""
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(426, 81)
        Me.txtEmail.MaxLength = 20
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(185, 21)
        Me.txtEmail.TabIndex = 39
        Me.txtEmail.Text = ""
        '
        'txtBillAddress
        '
        Me.txtBillAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBillAddress.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBillAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBillAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillAddress.Location = New System.Drawing.Point(426, 52)
        Me.txtBillAddress.MaxLength = 50
        Me.txtBillAddress.Name = "txtBillAddress"
        Me.txtBillAddress.Size = New System.Drawing.Size(185, 21)
        Me.txtBillAddress.TabIndex = 37
        Me.txtBillAddress.Text = ""
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(314, 226)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(105, 20)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "Reviews"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCardHolder
        '
        Me.txtCardHolder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCardHolder.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCardHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardHolder.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardHolder.Location = New System.Drawing.Point(123, 81)
        Me.txtCardHolder.MaxLength = 50
        Me.txtCardHolder.Name = "txtCardHolder"
        Me.txtCardHolder.Size = New System.Drawing.Size(185, 21)
        Me.txtCardHolder.TabIndex = 23
        Me.txtCardHolder.Text = ""
        '
        'txtValidFrom
        '
        Me.txtValidFrom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtValidFrom.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtValidFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValidFrom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValidFrom.Location = New System.Drawing.Point(123, 168)
        Me.txtValidFrom.MaxLength = 10
        Me.txtValidFrom.Name = "txtValidFrom"
        Me.txtValidFrom.Size = New System.Drawing.Size(185, 21)
        Me.txtValidFrom.TabIndex = 29
        Me.txtValidFrom.Text = ""
        '
        'txtIssueNo
        '
        Me.txtIssueNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIssueNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtIssueNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIssueNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssueNo.Location = New System.Drawing.Point(123, 139)
        Me.txtIssueNo.MaxLength = 10
        Me.txtIssueNo.Name = "txtIssueNo"
        Me.txtIssueNo.Size = New System.Drawing.Size(185, 21)
        Me.txtIssueNo.TabIndex = 27
        Me.txtIssueNo.Text = ""
        '
        'txtCreditCard
        '
        Me.txtCreditCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCreditCard.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCreditCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCreditCard.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCard.Location = New System.Drawing.Point(123, 110)
        Me.txtCreditCard.MaxLength = 50
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.Size = New System.Drawing.Size(185, 21)
        Me.txtCreditCard.TabIndex = 25
        Me.txtCreditCard.Text = ""
        '
        'txtLastOrderDate
        '
        Me.txtLastOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastOrderDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtLastOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastOrderDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastOrderDate.Location = New System.Drawing.Point(123, 52)
        Me.txtLastOrderDate.MaxLength = 10
        Me.txtLastOrderDate.Name = "txtLastOrderDate"
        Me.txtLastOrderDate.ReadOnly = True
        Me.txtLastOrderDate.Size = New System.Drawing.Size(185, 21)
        Me.txtLastOrderDate.TabIndex = 21
        Me.txtLastOrderDate.Text = ""
        '
        'txtDateOfEntry
        '
        Me.txtDateOfEntry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDateOfEntry.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDateOfEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateOfEntry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateOfEntry.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDateOfEntry.Location = New System.Drawing.Point(123, 23)
        Me.txtDateOfEntry.MaxLength = 10
        Me.txtDateOfEntry.Name = "txtDateOfEntry"
        Me.txtDateOfEntry.ReadOnly = True
        Me.txtDateOfEntry.Size = New System.Drawing.Size(185, 21)
        Me.txtDateOfEntry.TabIndex = 19
        Me.txtDateOfEntry.Text = ""
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(9, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Expiry Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Valid From"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(9, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Issue No"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(9, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Card Holder"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(9, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Last Order Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(9, 110)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(105, 20)
        Me.Label33.TabIndex = 24
        Me.Label33.Text = "Credit Card No"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(314, 139)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(105, 20)
        Me.Label39.TabIndex = 42
        Me.Label39.Text = "Comments"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label40.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label40.Location = New System.Drawing.Point(314, 110)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(105, 20)
        Me.Label40.TabIndex = 40
        Me.Label40.Text = "URL"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label41.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(314, 81)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(105, 20)
        Me.Label41.TabIndex = 38
        Me.Label41.Text = "E-mail"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label43.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(314, 52)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(105, 20)
        Me.Label43.TabIndex = 36
        Me.Label43.Text = "Bill Address"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label44.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label44.Location = New System.Drawing.Point(314, 23)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(105, 20)
        Me.Label44.TabIndex = 34
        Me.Label44.Text = "Mobile"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbBasicInfo
        '
        Me.gbBasicInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBasicInfo.Controls.Add(Me.chkBoxWaitingCust)
        Me.gbBasicInfo.Controls.Add(Me.txtTown)
        Me.gbBasicInfo.Controls.Add(Me.Label22)
        Me.gbBasicInfo.Controls.Add(Me.btnCollection)
        Me.gbBasicInfo.Controls.Add(Me.btnwaitingCust)
        Me.gbBasicInfo.Controls.Add(Me.txtCustomerNo)
        Me.gbBasicInfo.Controls.Add(Me.Label31)
        Me.gbBasicInfo.Controls.Add(Me.txtPhoneNumber)
        Me.gbBasicInfo.Controls.Add(Me.Label32)
        Me.gbBasicInfo.Controls.Add(Me.txtPostCode)
        Me.gbBasicInfo.Controls.Add(Me.txtAddress)
        Me.gbBasicInfo.Controls.Add(Me.txtCompany)
        Me.gbBasicInfo.Controls.Add(Me.Label36)
        Me.gbBasicInfo.Controls.Add(Me.txtName)
        Me.gbBasicInfo.Controls.Add(Me.Label23)
        Me.gbBasicInfo.Controls.Add(Me.Label30)
        Me.gbBasicInfo.Controls.Add(Me.Label37)
        Me.gbBasicInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbBasicInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBasicInfo.ForeColor = System.Drawing.Color.Maroon
        Me.gbBasicInfo.Location = New System.Drawing.Point(8, 10)
        Me.gbBasicInfo.Name = "gbBasicInfo"
        Me.gbBasicInfo.Size = New System.Drawing.Size(770, 142)
        Me.gbBasicInfo.TabIndex = 1
        Me.gbBasicInfo.TabStop = False
        Me.gbBasicInfo.Text = "Basic Information"
        '
        'chkBoxWaitingCust
        '
        Me.chkBoxWaitingCust.Location = New System.Drawing.Point(784, 56)
        Me.chkBoxWaitingCust.Name = "chkBoxWaitingCust"
        Me.chkBoxWaitingCust.Size = New System.Drawing.Size(40, 24)
        Me.chkBoxWaitingCust.TabIndex = 96
        '
        'txtTown
        '
        Me.txtTown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTown.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTown.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTown.Location = New System.Drawing.Point(123, 77)
        Me.txtTown.MaxLength = 35
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(185, 21)
        Me.txtTown.TabIndex = 7
        Me.txtTown.Text = ""
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(18, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 22)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Post Code"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCollection
        '
        Me.btnCollection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCollection.BackColor = System.Drawing.Color.Transparent
        Me.btnCollection.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnCollection.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnCollection.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnCollection.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnCollection.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCollection.Location = New System.Drawing.Point(625, 75)
        Me.btnCollection.Name = "btnCollection"
        Me.btnCollection.Size = New System.Drawing.Size(131, 56)
        Me.btnCollection.TabIndex = 16
        Me.btnCollection.Text = "Collection"
        Me.btnCollection.TextColorDefault = System.Drawing.Color.Black
        Me.btnCollection.TextColorDisabled = System.Drawing.Color.Black
        Me.btnCollection.TextColorHover = System.Drawing.Color.White
        Me.btnCollection.TextColorNormal = System.Drawing.Color.White
        '
        'btnwaitingCust
        '
        Me.btnwaitingCust.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnwaitingCust.BackColor = System.Drawing.Color.Transparent
        Me.btnwaitingCust.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnwaitingCust.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnwaitingCust.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnwaitingCust.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnwaitingCust.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwaitingCust.Location = New System.Drawing.Point(625, 19)
        Me.btnwaitingCust.Name = "btnwaitingCust"
        Me.btnwaitingCust.Size = New System.Drawing.Size(131, 56)
        Me.btnwaitingCust.TabIndex = 15
        Me.btnwaitingCust.Text = "Waiting Cusomer"
        Me.btnwaitingCust.TextColorDefault = System.Drawing.Color.Black
        Me.btnwaitingCust.TextColorDisabled = System.Drawing.Color.Black
        Me.btnwaitingCust.TextColorHover = System.Drawing.Color.White
        Me.btnwaitingCust.TextColorNormal = System.Drawing.Color.White
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCustomerNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCustomerNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCustomerNo.Location = New System.Drawing.Point(123, 21)
        Me.txtCustomerNo.MaxLength = 35
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.ReadOnly = True
        Me.txtCustomerNo.Size = New System.Drawing.Size(185, 21)
        Me.txtCustomerNo.TabIndex = 3
        Me.txtCustomerNo.Text = ""
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(322, 48)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 22)
        Me.Label31.TabIndex = 14
        Me.Label31.Text = "Phone Number"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPhoneNumber.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPhoneNumber.Location = New System.Drawing.Point(426, 48)
        Me.txtPhoneNumber.MaxLength = 20
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(185, 21)
        Me.txtPhoneNumber.TabIndex = 95
        Me.txtPhoneNumber.Text = ""
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(18, 77)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 22)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Town"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPostCode
        '
        Me.txtPostCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPostCode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtPostCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPostCode.Location = New System.Drawing.Point(123, 107)
        Me.txtPostCode.MaxLength = 10
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(185, 21)
        Me.txtPostCode.TabIndex = 9
        Me.txtPostCode.Text = ""
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAddress.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAddress.Location = New System.Drawing.Point(426, 80)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(185, 52)
        Me.txtAddress.TabIndex = 13
        Me.txtAddress.Text = ""
        '
        'txtCompany
        '
        Me.txtCompany.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCompany.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompany.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCompany.Location = New System.Drawing.Point(123, 48)
        Me.txtCompany.MaxLength = 35
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(185, 21)
        Me.txtCompany.TabIndex = 5
        Me.txtCompany.Text = ""
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(18, 48)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(96, 22)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Door Number"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtName.Location = New System.Drawing.Point(426, 19)
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(185, 21)
        Me.txtName.TabIndex = 11
        Me.txtName.Text = ""
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(323, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 22)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Name"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(18, 19)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 22)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Customer No"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(322, 88)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(96, 22)
        Me.Label37.TabIndex = 12
        Me.Label37.Text = "Address"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.Color.Ivory
        Me.lblTotalPrice.BackgroundImage = CType(resources.GetObject("lblTotalPrice.BackgroundImage"), System.Drawing.Image)
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPrice.Controls.Add(Me.chkReprintWAY)
        Me.lblTotalPrice.Controls.Add(Me.lbQty)
        Me.lblTotalPrice.Controls.Add(Me.lbTotalQty)
        Me.lblTotalPrice.Controls.Add(Me.btnDownType)
        Me.lblTotalPrice.Controls.Add(Me.btnUpType)
        Me.lblTotalPrice.Controls.Add(Me.btnDownItem)
        Me.lblTotalPrice.Controls.Add(Me.btnUpItem)
        Me.lblTotalPrice.Controls.Add(Me.btnRefreshMenu)
        Me.lblTotalPrice.Controls.Add(Me.btnRemove)
        Me.lblTotalPrice.Controls.Add(Me.lblTotalOrderPrice)
        Me.lblTotalPrice.Controls.Add(Me.Label35)
        Me.lblTotalPrice.Controls.Add(Me.Label15)
        Me.lblTotalPrice.Controls.Add(Me.lvOrder)
        Me.lblTotalPrice.Controls.Add(Me.cboInstruction)
        Me.lblTotalPrice.Controls.Add(Me.Label14)
        Me.lblTotalPrice.Controls.Add(Me.xpnLstMain)
        Me.lblTotalPrice.Controls.Add(Me.xpndLstScnd)
        Me.lblTotalPrice.Controls.Add(Me.btnKitchPrint)
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ImageIndex = 1
        Me.lblTotalPrice.Location = New System.Drawing.Point(4, 31)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(784, 445)
        Me.lblTotalPrice.TabIndex = 1
        Me.lblTotalPrice.Text = "Generate Order"
        '
        'chkReprintWAY
        '
        Me.chkReprintWAY.BackColor = System.Drawing.Color.Azure
        Me.chkReprintWAY.Enabled = False
        Me.chkReprintWAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkReprintWAY.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReprintWAY.Location = New System.Drawing.Point(544, 400)
        Me.chkReprintWAY.Name = "chkReprintWAY"
        Me.chkReprintWAY.Size = New System.Drawing.Size(72, 34)
        Me.chkReprintWAY.TabIndex = 136
        Me.chkReprintWAY.Text = "Reprint"
        '
        'lbQty
        '
        Me.lbQty.Location = New System.Drawing.Point(560, 366)
        Me.lbQty.Name = "lbQty"
        Me.lbQty.Size = New System.Drawing.Size(24, 23)
        Me.lbQty.TabIndex = 135
        Me.lbQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbTotalQty
        '
        Me.lbTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotalQty.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalQty.Location = New System.Drawing.Point(528, 362)
        Me.lbTotalQty.Name = "lbTotalQty"
        Me.lbTotalQty.Size = New System.Drawing.Size(64, 29)
        Me.lbTotalQty.TabIndex = 128
        Me.lbTotalQty.Text = "QTY:"
        Me.lbTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDownType
        '
        Me.btnDownType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDownType.BackColor = System.Drawing.Color.Transparent
        Me.btnDownType.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnDownType.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnDownType.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnDownType.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnDownType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownType.Location = New System.Drawing.Point(199, 388)
        Me.btnDownType.Name = "btnDownType"
        Me.btnDownType.Size = New System.Drawing.Size(48, 48)
        Me.btnDownType.TabIndex = 126
        Me.btnDownType.Text = "Down"
        Me.btnDownType.TextColorDefault = System.Drawing.Color.Black
        Me.btnDownType.TextColorDisabled = System.Drawing.Color.Black
        Me.btnDownType.TextColorHover = System.Drawing.Color.White
        Me.btnDownType.TextColorNormal = System.Drawing.Color.White
        '
        'btnUpType
        '
        Me.btnUpType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpType.BackColor = System.Drawing.Color.Transparent
        Me.btnUpType.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnUpType.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnUpType.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnUpType.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnUpType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpType.Location = New System.Drawing.Point(201, 8)
        Me.btnUpType.Name = "btnUpType"
        Me.btnUpType.Size = New System.Drawing.Size(48, 48)
        Me.btnUpType.TabIndex = 125
        Me.btnUpType.Text = "Up"
        Me.btnUpType.TextColorDefault = System.Drawing.Color.Black
        Me.btnUpType.TextColorDisabled = System.Drawing.Color.Black
        Me.btnUpType.TextColorHover = System.Drawing.Color.White
        Me.btnUpType.TextColorNormal = System.Drawing.Color.White
        '
        'btnDownItem
        '
        Me.btnDownItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDownItem.BackColor = System.Drawing.Color.Transparent
        Me.btnDownItem.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnDownItem.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnDownItem.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnDownItem.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnDownItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownItem.Location = New System.Drawing.Point(488, 392)
        Me.btnDownItem.Name = "btnDownItem"
        Me.btnDownItem.Size = New System.Drawing.Size(48, 48)
        Me.btnDownItem.TabIndex = 124
        Me.btnDownItem.Text = "Down"
        Me.btnDownItem.TextColorDefault = System.Drawing.Color.Black
        Me.btnDownItem.TextColorDisabled = System.Drawing.Color.Black
        Me.btnDownItem.TextColorHover = System.Drawing.Color.White
        Me.btnDownItem.TextColorNormal = System.Drawing.Color.White
        '
        'btnUpItem
        '
        Me.btnUpItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpItem.BackColor = System.Drawing.Color.Transparent
        Me.btnUpItem.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnUpItem.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnUpItem.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnUpItem.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnUpItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpItem.Location = New System.Drawing.Point(480, 8)
        Me.btnUpItem.Name = "btnUpItem"
        Me.btnUpItem.Size = New System.Drawing.Size(48, 48)
        Me.btnUpItem.TabIndex = 123
        Me.btnUpItem.Text = "Up"
        Me.btnUpItem.TextColorDefault = System.Drawing.Color.Black
        Me.btnUpItem.TextColorDisabled = System.Drawing.Color.Black
        Me.btnUpItem.TextColorHover = System.Drawing.Color.White
        Me.btnUpItem.TextColorNormal = System.Drawing.Color.White
        '
        'btnRefreshMenu
        '
        Me.btnRefreshMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefreshMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnRefreshMenu.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnRefreshMenu.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnRefreshMenu.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnRefreshMenu.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnRefreshMenu.Enabled = False
        Me.btnRefreshMenu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshMenu.Location = New System.Drawing.Point(544, 400)
        Me.btnRefreshMenu.Name = "btnRefreshMenu"
        Me.btnRefreshMenu.Size = New System.Drawing.Size(64, 44)
        Me.btnRefreshMenu.TabIndex = 59
        Me.btnRefreshMenu.Text = "Refresh "
        Me.btnRefreshMenu.TextColorDefault = System.Drawing.Color.Black
        Me.btnRefreshMenu.TextColorDisabled = System.Drawing.Color.Black
        Me.btnRefreshMenu.TextColorHover = System.Drawing.Color.White
        Me.btnRefreshMenu.TextColorNormal = System.Drawing.Color.White
        Me.btnRefreshMenu.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnRemove.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnRemove.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnRemove.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(704, 400)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(72, 44)
        Me.btnRemove.TabIndex = 58
        Me.btnRemove.Text = "Remove "
        Me.btnRemove.TextColorDefault = System.Drawing.Color.Black
        Me.btnRemove.TextColorDisabled = System.Drawing.Color.Black
        Me.btnRemove.TextColorHover = System.Drawing.Color.White
        Me.btnRemove.TextColorNormal = System.Drawing.Color.White
        '
        'lblTotalOrderPrice
        '
        Me.lblTotalOrderPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalOrderPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOrderPrice.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lblTotalOrderPrice.Location = New System.Drawing.Point(688, 368)
        Me.lblTotalOrderPrice.Name = "lblTotalOrderPrice"
        Me.lblTotalOrderPrice.Size = New System.Drawing.Size(72, 16)
        Me.lblTotalOrderPrice.TabIndex = 57
        Me.lblTotalOrderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(600, 362)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(176, 29)
        Me.Label35.TabIndex = 56
        Me.Label35.Text = " Total Price:-"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(528, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(248, 16)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Ordred Items"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvOrder
        '
        Me.lvOrder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvOrder.BackColor = System.Drawing.Color.Ivory
        Me.lvOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvOrder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cCheckBox, Me.cQty, Me.cItem, Me.cPrice, Me.cInstruction, Me.ItemId, Me.cStockInHand, Me.cServeLocation, Me.CtypeName, Me.cQtyRemaning})
        Me.lvOrder.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvOrder.FullRowSelect = True
        Me.lvOrder.GridLines = True
        Me.lvOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvOrder.Location = New System.Drawing.Point(528, 64)
        Me.lvOrder.MultiSelect = False
        Me.lvOrder.Name = "lvOrder"
        Me.lvOrder.Size = New System.Drawing.Size(248, 296)
        Me.lvOrder.TabIndex = 55
        Me.lvOrder.View = System.Windows.Forms.View.Details
        '
        'cCheckBox
        '
        Me.cCheckBox.Text = ""
        Me.cCheckBox.Width = 0
        '
        'cQty
        '
        Me.cQty.Text = "Qty"
        Me.cQty.Width = 48
        '
        'cItem
        '
        Me.cItem.Text = "Item"
        Me.cItem.Width = 160
        '
        'cPrice
        '
        Me.cPrice.Text = "Price"
        Me.cPrice.Width = 87
        '
        'cInstruction
        '
        Me.cInstruction.Text = "Instruction"
        Me.cInstruction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cInstruction.Width = 200
        '
        'ItemId
        '
        Me.ItemId.Text = ""
        Me.ItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ItemId.Width = 0
        '
        'cStockInHand
        '
        Me.cStockInHand.Text = ""
        Me.cStockInHand.Width = 0
        '
        'cServeLocation
        '
        Me.cServeLocation.Width = 0
        '
        'CtypeName
        '
        Me.CtypeName.Width = 0
        '
        'cQtyRemaning
        '
        Me.cQtyRemaning.Text = ""
        Me.cQtyRemaning.Width = 0
        '
        'cboInstruction
        '
        Me.cboInstruction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboInstruction.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInstruction.Items.AddRange(New Object() {"No Coriander", "With Coriander", "No Coriander", "With Coriander", "No Oil", "With Oil", "No Sugar", "With Suger", "No Salty", "Salty", "No Nuts", "With Nuts", "More Spicy", "Less Spicy", "Saucy", "Buttery", "Crispy"})
        Me.cboInstruction.Location = New System.Drawing.Point(528, 21)
        Me.cboInstruction.Name = "cboInstruction"
        Me.cboInstruction.Size = New System.Drawing.Size(248, 21)
        Me.cboInstruction.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(528, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(240, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Instruction on Item"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xpnLstMain
        '
        Me.xpnLstMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xpnLstMain.AutoScroll = True
        Me.xpnLstMain.BackColor = System.Drawing.Color.Ivory
        Me.xpnLstMain.BackColorDark = System.Drawing.Color.Ivory
        Me.xpnLstMain.BackColorLight = System.Drawing.Color.Honeydew
        Me.xpnLstMain.Location = New System.Drawing.Point(4, 8)
        Me.xpnLstMain.Name = "xpnLstMain"
        Me.xpnLstMain.Size = New System.Drawing.Size(221, 416)
        Me.xpnLstMain.TabIndex = 60
        '
        'xpndLstScnd
        '
        Me.xpndLstScnd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xpndLstScnd.AutoScroll = True
        Me.xpndLstScnd.BackColor = System.Drawing.Color.Ivory
        Me.xpndLstScnd.BackColorDark = System.Drawing.Color.Ivory
        Me.xpndLstScnd.BackColorLight = System.Drawing.Color.Honeydew
        Me.xpndLstScnd.Controls.Add(Me.xpndrItems)
        Me.xpndLstScnd.Location = New System.Drawing.Point(246, 8)
        Me.xpndLstScnd.Name = "xpndLstScnd"
        Me.xpndLstScnd.Size = New System.Drawing.Size(258, 416)
        Me.xpndLstScnd.TabIndex = 61
        '
        'xpndrItems
        '
        Me.xpndrItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xpndrItems.BackColor = System.Drawing.Color.Transparent
        Me.xpndrItems.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.xpndrItems.CanToggle = False
        Me.xpndrItems.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xpndrItems.CaptionFormatFlag = XPanderControl.XPander.FormatFlag.NoWrap
        Me.xpndrItems.CaptionHeight = 30
        Me.xpndrItems.CaptionLeftColor = System.Drawing.Color.RosyBrown
        Me.xpndrItems.CaptionRightColor = System.Drawing.Color.Maroon
        Me.xpndrItems.CaptionStyle = XPanderControl.XPander.CaptionStyleEnum.Normal
        Me.xpndrItems.CaptionText = "No Dish Type selected"
        Me.xpndrItems.CaptionTextAlign = XPanderControl.XPander.CaptionTextAlignment.Middle
        Me.xpndrItems.CaptionTextColor = System.Drawing.Color.White
        Me.xpndrItems.CaptionTextHighlightColor = System.Drawing.Color.DarkOrange
        Me.xpndrItems.ChevronStyle = XPanderControl.XPander.ChevronStyleEnum.Image
        Me.xpndrItems.CollapsedHighlightImage = CType(resources.GetObject("xpndrItems.CollapsedHighlightImage"), System.Drawing.Bitmap)
        Me.xpndrItems.CollapsedImage = CType(resources.GetObject("xpndrItems.CollapsedImage"), System.Drawing.Bitmap)
        Me.xpndrItems.DockPadding.Top = 30
        Me.xpndrItems.ExpandedHighlightImage = CType(resources.GetObject("xpndrItems.ExpandedHighlightImage"), System.Drawing.Bitmap)
        Me.xpndrItems.ExpandedImage = CType(resources.GetObject("xpndrItems.ExpandedImage"), System.Drawing.Bitmap)
        Me.xpndrItems.Location = New System.Drawing.Point(11, 9)
        Me.xpndrItems.Name = "xpndrItems"
        Me.xpndrItems.Size = New System.Drawing.Size(187, 31)
        Me.xpndrItems.TabIndex = 33
        Me.xpndrItems.Tag = 0
        Me.xpndrItems.TooltipText = Nothing
        '
        'btnKitchPrint
        '
        Me.btnKitchPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKitchPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnKitchPrint.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnKitchPrint.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnKitchPrint.ButtonColorHover = System.Drawing.Color.Salmon
        Me.btnKitchPrint.ButtonColorNormal = System.Drawing.Color.Maroon
        Me.btnKitchPrint.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKitchPrint.Location = New System.Drawing.Point(616, 400)
        Me.btnKitchPrint.Name = "btnKitchPrint"
        Me.btnKitchPrint.Size = New System.Drawing.Size(80, 44)
        Me.btnKitchPrint.TabIndex = 94
        Me.btnKitchPrint.Text = "Order Print"
        Me.btnKitchPrint.TextColorDefault = System.Drawing.Color.Black
        Me.btnKitchPrint.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKitchPrint.TextColorHover = System.Drawing.Color.White
        Me.btnKitchPrint.TextColorNormal = System.Drawing.Color.White
        '
        'tbpgPayment
        '
        Me.tbpgPayment.BackColor = System.Drawing.Color.Ivory
        Me.tbpgPayment.BackgroundImage = CType(resources.GetObject("tbpgPayment.BackgroundImage"), System.Drawing.Image)
        Me.tbpgPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbpgPayment.Controls.Add(Me.gbPaymentInformation)
        Me.tbpgPayment.Controls.Add(Me.gbPrintOrder)
        Me.tbpgPayment.Controls.Add(Me.gbPriceCalculation)
        Me.tbpgPayment.Controls.Add(Me.gbPriceInformation)
        Me.tbpgPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpgPayment.ImageIndex = 2
        Me.tbpgPayment.Location = New System.Drawing.Point(4, 31)
        Me.tbpgPayment.Name = "tbpgPayment"
        Me.tbpgPayment.Size = New System.Drawing.Size(784, 445)
        Me.tbpgPayment.TabIndex = 2
        Me.tbpgPayment.Text = "Payment   "
        '
        'gbPaymentInformation
        '
        Me.gbPaymentInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbPaymentInformation.BackColor = System.Drawing.Color.Ivory
        Me.gbPaymentInformation.Controls.Add(Me.btnRefund)
        Me.gbPaymentInformation.Controls.Add(Me.btnPayBill)
        Me.gbPaymentInformation.Controls.Add(Me.btnPay)
        Me.gbPaymentInformation.Controls.Add(Me.Label11)
        Me.gbPaymentInformation.Controls.Add(Me.txtCashPay)
        Me.gbPaymentInformation.Controls.Add(Me.txtBankName)
        Me.gbPaymentInformation.Controls.Add(Me.txtChequeNo)
        Me.gbPaymentInformation.Controls.Add(Me.Label2)
        Me.gbPaymentInformation.Controls.Add(Me.Label1)
        Me.gbPaymentInformation.Controls.Add(Me.txtChange)
        Me.gbPaymentInformation.Controls.Add(Me.lblChange)
        Me.gbPaymentInformation.Controls.Add(Me.txtChequePay)
        Me.gbPaymentInformation.Controls.Add(Me.txtCardPay)
        Me.gbPaymentInformation.Controls.Add(Me.Label21)
        Me.gbPaymentInformation.Controls.Add(Me.Label20)
        Me.gbPaymentInformation.Controls.Add(Me.Label19)
        Me.gbPaymentInformation.Controls.Add(Me.cboCardType)
        Me.gbPaymentInformation.Controls.Add(Me.chkAccumulate)
        Me.gbPaymentInformation.Controls.Add(Me.chkReprint)
        Me.gbPaymentInformation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbPaymentInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPaymentInformation.ForeColor = System.Drawing.Color.Maroon
        Me.gbPaymentInformation.Location = New System.Drawing.Point(522, 7)
        Me.gbPaymentInformation.Name = "gbPaymentInformation"
        Me.gbPaymentInformation.Size = New System.Drawing.Size(252, 426)
        Me.gbPaymentInformation.TabIndex = 96
        Me.gbPaymentInformation.TabStop = False
        Me.gbPaymentInformation.Text = "Payment Information    "
        '
        'btnRefund
        '
        Me.btnRefund.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefund.BackColor = System.Drawing.Color.Transparent
        Me.btnRefund.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnRefund.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnRefund.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnRefund.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnRefund.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefund.Location = New System.Drawing.Point(73, 344)
        Me.btnRefund.Name = "btnRefund"
        Me.btnRefund.Size = New System.Drawing.Size(102, 56)
        Me.btnRefund.TabIndex = 116
        Me.btnRefund.Text = "RePrint"
        Me.btnRefund.TextColorDefault = System.Drawing.Color.Black
        Me.btnRefund.TextColorDisabled = System.Drawing.Color.Black
        Me.btnRefund.TextColorHover = System.Drawing.Color.White
        Me.btnRefund.TextColorNormal = System.Drawing.Color.White
        '
        'btnPayBill
        '
        Me.btnPayBill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPayBill.BackColor = System.Drawing.Color.Transparent
        Me.btnPayBill.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnPayBill.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnPayBill.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnPayBill.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnPayBill.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayBill.Location = New System.Drawing.Point(16, 281)
        Me.btnPayBill.Name = "btnPayBill"
        Me.btnPayBill.Size = New System.Drawing.Size(102, 56)
        Me.btnPayBill.TabIndex = 114
        Me.btnPayBill.Text = "Pay"
        Me.btnPayBill.TextColorDefault = System.Drawing.Color.Black
        Me.btnPayBill.TextColorDisabled = System.Drawing.Color.Black
        Me.btnPayBill.TextColorHover = System.Drawing.Color.White
        Me.btnPayBill.TextColorNormal = System.Drawing.Color.White
        '
        'btnPay
        '
        Me.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPay.BackColor = System.Drawing.Color.Transparent
        Me.btnPay.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnPay.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnPay.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnPay.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnPay.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(136, 280)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(102, 56)
        Me.btnPay.TabIndex = 113
        Me.btnPay.Text = "Pay Print"
        Me.btnPay.TextColorDefault = System.Drawing.Color.Black
        Me.btnPay.TextColorDisabled = System.Drawing.Color.Black
        Me.btnPay.TextColorHover = System.Drawing.Color.White
        Me.btnPay.TextColorNormal = System.Drawing.Color.White
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(6, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 1)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Label11"
        '
        'txtCashPay
        '
        Me.txtCashPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCashPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashPay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashPay.Location = New System.Drawing.Point(104, 42)
        Me.txtCashPay.Name = "txtCashPay"
        Me.txtCashPay.Size = New System.Drawing.Size(138, 21)
        Me.txtCashPay.TabIndex = 98
        Me.txtCashPay.Text = ""
        '
        'txtBankName
        '
        Me.txtBankName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(512, 171)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(138, 21)
        Me.txtBankName.TabIndex = 103
        Me.txtBankName.Text = ""
        Me.txtBankName.Visible = False
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChequeNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.Location = New System.Drawing.Point(584, 200)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(138, 21)
        Me.txtChequeNo.TabIndex = 105
        Me.txtChequeNo.Text = ""
        Me.txtChequeNo.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(-4, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 22)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Cheque Amount"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(488, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Cheque No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'txtChange
        '
        Me.txtChange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtChange.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(104, 216)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(138, 21)
        Me.txtChange.TabIndex = 110
        Me.txtChange.Text = ""
        '
        'lblChange
        '
        Me.lblChange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblChange.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChange.Location = New System.Drawing.Point(8, 216)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(96, 22)
        Me.lblChange.TabIndex = 109
        Me.lblChange.Text = "Change"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChequePay
        '
        Me.txtChequePay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtChequePay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChequePay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequePay.Location = New System.Drawing.Point(104, 168)
        Me.txtChequePay.MaxLength = 8
        Me.txtChequePay.Name = "txtChequePay"
        Me.txtChequePay.Size = New System.Drawing.Size(138, 21)
        Me.txtChequePay.TabIndex = 107
        Me.txtChequePay.Text = ""
        '
        'txtCardPay
        '
        Me.txtCardPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCardPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardPay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardPay.Location = New System.Drawing.Point(104, 87)
        Me.txtCardPay.MaxLength = 8
        Me.txtCardPay.Name = "txtCardPay"
        Me.txtCardPay.Size = New System.Drawing.Size(138, 21)
        Me.txtCardPay.TabIndex = 100
        Me.txtCardPay.Text = ""
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(6, 87)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 22)
        Me.Label21.TabIndex = 99
        Me.Label21.Text = "Card amount"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(416, 171)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 22)
        Me.Label20.TabIndex = 102
        Me.Label20.Text = "Bank Name"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(6, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 22)
        Me.Label19.TabIndex = 97
        Me.Label19.Text = "Cash Amount"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboCardType
        '
        Me.cboCardType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboCardType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCardType.Location = New System.Drawing.Point(104, 116)
        Me.cboCardType.MaxLength = 20
        Me.cboCardType.Name = "cboCardType"
        Me.cboCardType.Size = New System.Drawing.Size(138, 21)
        Me.cboCardType.TabIndex = 101
        Me.cboCardType.Text = "(Select a Card type)"
        '
        'chkAccumulate
        '
        Me.chkAccumulate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAccumulate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccumulate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAccumulate.Location = New System.Drawing.Point(272, 328)
        Me.chkAccumulate.Name = "chkAccumulate"
        Me.chkAccumulate.TabIndex = 111
        Me.chkAccumulate.Text = "Accumulate"
        '
        'chkReprint
        '
        Me.chkReprint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkReprint.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReprint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkReprint.Location = New System.Drawing.Point(400, 328)
        Me.chkReprint.Name = "chkReprint"
        Me.chkReprint.TabIndex = 112
        Me.chkReprint.Text = "Reprint"
        Me.chkReprint.Visible = False
        '
        'gbPrintOrder
        '
        Me.gbPrintOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbPrintOrder.Controls.Add(Me.btnLevelPrint)
        Me.gbPrintOrder.Controls.Add(Me.btBillPrint)
        Me.gbPrintOrder.Controls.Add(Me.btnAllPrint)
        Me.gbPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbPrintOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPrintOrder.ForeColor = System.Drawing.Color.Maroon
        Me.gbPrintOrder.Location = New System.Drawing.Point(267, 322)
        Me.gbPrintOrder.Name = "gbPrintOrder"
        Me.gbPrintOrder.Size = New System.Drawing.Size(253, 115)
        Me.gbPrintOrder.TabIndex = 91
        Me.gbPrintOrder.TabStop = False
        Me.gbPrintOrder.Text = "PrintOption"
        '
        'btnLevelPrint
        '
        Me.btnLevelPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLevelPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnLevelPrint.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnLevelPrint.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnLevelPrint.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnLevelPrint.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnLevelPrint.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevelPrint.Location = New System.Drawing.Point(7, 15)
        Me.btnLevelPrint.Name = "btnLevelPrint"
        Me.btnLevelPrint.Size = New System.Drawing.Size(112, 48)
        Me.btnLevelPrint.TabIndex = 92
        Me.btnLevelPrint.Text = "Label Print"
        Me.btnLevelPrint.TextColorDefault = System.Drawing.Color.Black
        Me.btnLevelPrint.TextColorDisabled = System.Drawing.Color.Black
        Me.btnLevelPrint.TextColorHover = System.Drawing.Color.White
        Me.btnLevelPrint.TextColorNormal = System.Drawing.Color.White
        '
        'btBillPrint
        '
        Me.btBillPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btBillPrint.BackColor = System.Drawing.Color.Transparent
        Me.btBillPrint.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btBillPrint.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btBillPrint.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btBillPrint.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btBillPrint.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBillPrint.Location = New System.Drawing.Point(133, 15)
        Me.btBillPrint.Name = "btBillPrint"
        Me.btBillPrint.Size = New System.Drawing.Size(112, 48)
        Me.btBillPrint.TabIndex = 93
        Me.btBillPrint.Text = "Bill  Print"
        Me.btBillPrint.TextColorDefault = System.Drawing.Color.Black
        Me.btBillPrint.TextColorDisabled = System.Drawing.Color.Black
        Me.btBillPrint.TextColorHover = System.Drawing.Color.White
        Me.btBillPrint.TextColorNormal = System.Drawing.Color.White
        '
        'btnAllPrint
        '
        Me.btnAllPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAllPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnAllPrint.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnAllPrint.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnAllPrint.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnAllPrint.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnAllPrint.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllPrint.Location = New System.Drawing.Point(80, 64)
        Me.btnAllPrint.Name = "btnAllPrint"
        Me.btnAllPrint.Size = New System.Drawing.Size(112, 48)
        Me.btnAllPrint.TabIndex = 95
        Me.btnAllPrint.Text = "All Print"
        Me.btnAllPrint.TextColorDefault = System.Drawing.Color.Black
        Me.btnAllPrint.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAllPrint.TextColorHover = System.Drawing.Color.White
        Me.btnAllPrint.TextColorNormal = System.Drawing.Color.White
        '
        'gbPriceCalculation
        '
        Me.gbPriceCalculation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.gbPriceCalculation.Controls.Add(Me.btnDelete)
        Me.gbPriceCalculation.Controls.Add(Me.btnBckSpace)
        Me.gbPriceCalculation.Controls.Add(Me.btnAdd)
        Me.gbPriceCalculation.Controls.Add(Me.btnMultiply)
        Me.gbPriceCalculation.Controls.Add(Me.btnDot)
        Me.gbPriceCalculation.Controls.Add(Me.btn0)
        Me.gbPriceCalculation.Controls.Add(Me.btn9)
        Me.gbPriceCalculation.Controls.Add(Me.btn8)
        Me.gbPriceCalculation.Controls.Add(Me.btn7)
        Me.gbPriceCalculation.Controls.Add(Me.btn6)
        Me.gbPriceCalculation.Controls.Add(Me.btn5)
        Me.gbPriceCalculation.Controls.Add(Me.btn4)
        Me.gbPriceCalculation.Controls.Add(Me.btn3)
        Me.gbPriceCalculation.Controls.Add(Me.btn2)
        Me.gbPriceCalculation.Controls.Add(Me.btn1)
        Me.gbPriceCalculation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbPriceCalculation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPriceCalculation.ForeColor = System.Drawing.Color.Maroon
        Me.gbPriceCalculation.Location = New System.Drawing.Point(267, 7)
        Me.gbPriceCalculation.Name = "gbPriceCalculation"
        Me.gbPriceCalculation.Size = New System.Drawing.Size(252, 313)
        Me.gbPriceCalculation.TabIndex = 75
        Me.gbPriceCalculation.TabStop = False
        Me.gbPriceCalculation.Text = "Price Calculation"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnDelete.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnDelete.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnDelete.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(15, 267)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 40)
        Me.btnDelete.TabIndex = 89
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextColorDefault = System.Drawing.Color.Black
        Me.btnDelete.TextColorDisabled = System.Drawing.Color.Black
        Me.btnDelete.TextColorHover = System.Drawing.Color.White
        Me.btnDelete.TextColorNormal = System.Drawing.Color.White
        '
        'btnBckSpace
        '
        Me.btnBckSpace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBckSpace.BackColor = System.Drawing.Color.Transparent
        Me.btnBckSpace.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnBckSpace.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnBckSpace.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnBckSpace.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnBckSpace.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBckSpace.Location = New System.Drawing.Point(16, 224)
        Me.btnBckSpace.Name = "btnBckSpace"
        Me.btnBckSpace.Size = New System.Drawing.Size(104, 40)
        Me.btnBckSpace.TabIndex = 88
        Me.btnBckSpace.Text = "BackSpace"
        Me.btnBckSpace.TextColorDefault = System.Drawing.Color.Black
        Me.btnBckSpace.TextColorDisabled = System.Drawing.Color.Black
        Me.btnBckSpace.TextColorHover = System.Drawing.Color.White
        Me.btnBckSpace.TextColorNormal = System.Drawing.Color.White
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnAdd.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnAdd.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnAdd.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(127, 243)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 56)
        Me.btnAdd.TabIndex = 90
        Me.btnAdd.Text = "Enter"
        Me.btnAdd.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdd.TextColorHover = System.Drawing.Color.White
        Me.btnAdd.TextColorNormal = System.Drawing.Color.White
        '
        'btnMultiply
        '
        Me.btnMultiply.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMultiply.BackColor = System.Drawing.Color.Transparent
        Me.btnMultiply.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnMultiply.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnMultiply.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnMultiply.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnMultiply.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(175, 172)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(56, 52)
        Me.btnMultiply.TabIndex = 87
        Me.btnMultiply.Text = "X"
        Me.btnMultiply.TextColorDefault = System.Drawing.Color.Black
        Me.btnMultiply.TextColorDisabled = System.Drawing.Color.Black
        Me.btnMultiply.TextColorHover = System.Drawing.Color.White
        Me.btnMultiply.TextColorNormal = System.Drawing.Color.White
        '
        'btnDot
        '
        Me.btnDot.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDot.BackColor = System.Drawing.Color.Transparent
        Me.btnDot.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnDot.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnDot.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnDot.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnDot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDot.Location = New System.Drawing.Point(99, 172)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(56, 52)
        Me.btnDot.TabIndex = 86
        Me.btnDot.Text = "."
        Me.btnDot.TextColorDefault = System.Drawing.Color.Black
        Me.btnDot.TextColorDisabled = System.Drawing.Color.Black
        Me.btnDot.TextColorHover = System.Drawing.Color.White
        Me.btnDot.TextColorNormal = System.Drawing.Color.White
        '
        'btn0
        '
        Me.btn0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn0.BackColor = System.Drawing.Color.Transparent
        Me.btn0.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn0.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn0.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn0.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn0.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(23, 171)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(56, 52)
        Me.btn0.TabIndex = 85
        Me.btn0.Text = "0"
        Me.btn0.TextColorDefault = System.Drawing.Color.Black
        Me.btn0.TextColorDisabled = System.Drawing.Color.Black
        Me.btn0.TextColorHover = System.Drawing.Color.White
        Me.btn0.TextColorNormal = System.Drawing.Color.White
        '
        'btn9
        '
        Me.btn9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn9.BackColor = System.Drawing.Color.Transparent
        Me.btn9.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn9.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn9.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn9.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(175, 121)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(56, 52)
        Me.btn9.TabIndex = 84
        Me.btn9.Text = "9"
        Me.btn9.TextColorDefault = System.Drawing.Color.Black
        Me.btn9.TextColorDisabled = System.Drawing.Color.Black
        Me.btn9.TextColorHover = System.Drawing.Color.White
        Me.btn9.TextColorNormal = System.Drawing.Color.White
        '
        'btn8
        '
        Me.btn8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn8.BackColor = System.Drawing.Color.Transparent
        Me.btn8.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn8.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn8.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn8.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(99, 121)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(56, 52)
        Me.btn8.TabIndex = 83
        Me.btn8.Text = "8"
        Me.btn8.TextColorDefault = System.Drawing.Color.Black
        Me.btn8.TextColorDisabled = System.Drawing.Color.Black
        Me.btn8.TextColorHover = System.Drawing.Color.White
        Me.btn8.TextColorNormal = System.Drawing.Color.White
        '
        'btn7
        '
        Me.btn7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn7.BackColor = System.Drawing.Color.Transparent
        Me.btn7.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn7.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn7.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn7.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn7.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(23, 121)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(56, 52)
        Me.btn7.TabIndex = 82
        Me.btn7.Text = "7"
        Me.btn7.TextColorDefault = System.Drawing.Color.Black
        Me.btn7.TextColorDisabled = System.Drawing.Color.Black
        Me.btn7.TextColorHover = System.Drawing.Color.White
        Me.btn7.TextColorNormal = System.Drawing.Color.White
        '
        'btn6
        '
        Me.btn6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn6.BackColor = System.Drawing.Color.Transparent
        Me.btn6.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn6.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn6.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn6.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(173, 70)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(56, 52)
        Me.btn6.TabIndex = 81
        Me.btn6.Text = "6"
        Me.btn6.TextColorDefault = System.Drawing.Color.Black
        Me.btn6.TextColorDisabled = System.Drawing.Color.Black
        Me.btn6.TextColorHover = System.Drawing.Color.White
        Me.btn6.TextColorNormal = System.Drawing.Color.White
        '
        'btn5
        '
        Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn5.BackColor = System.Drawing.Color.Transparent
        Me.btn5.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn5.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn5.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn5.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(99, 70)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(56, 52)
        Me.btn5.TabIndex = 80
        Me.btn5.Text = "5"
        Me.btn5.TextColorDefault = System.Drawing.Color.Black
        Me.btn5.TextColorDisabled = System.Drawing.Color.Black
        Me.btn5.TextColorHover = System.Drawing.Color.White
        Me.btn5.TextColorNormal = System.Drawing.Color.White
        '
        'btn4
        '
        Me.btn4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn4.BackColor = System.Drawing.Color.Transparent
        Me.btn4.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn4.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn4.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn4.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(21, 71)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(56, 52)
        Me.btn4.TabIndex = 79
        Me.btn4.Text = "4"
        Me.btn4.TextColorDefault = System.Drawing.Color.Black
        Me.btn4.TextColorDisabled = System.Drawing.Color.Black
        Me.btn4.TextColorHover = System.Drawing.Color.White
        Me.btn4.TextColorNormal = System.Drawing.Color.White
        '
        'btn3
        '
        Me.btn3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn3.BackColor = System.Drawing.Color.Transparent
        Me.btn3.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn3.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn3.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn3.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(173, 21)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(56, 52)
        Me.btn3.TabIndex = 78
        Me.btn3.Text = "3"
        Me.btn3.TextColorDefault = System.Drawing.Color.Black
        Me.btn3.TextColorDisabled = System.Drawing.Color.Black
        Me.btn3.TextColorHover = System.Drawing.Color.White
        Me.btn3.TextColorNormal = System.Drawing.Color.White
        '
        'btn2
        '
        Me.btn2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        Me.btn2.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn2.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn2.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn2.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(99, 20)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(56, 52)
        Me.btn2.TabIndex = 77
        Me.btn2.Text = "2"
        Me.btn2.TextColorDefault = System.Drawing.Color.Black
        Me.btn2.TextColorDisabled = System.Drawing.Color.Black
        Me.btn2.TextColorHover = System.Drawing.Color.White
        Me.btn2.TextColorNormal = System.Drawing.Color.White
        '
        'btn1
        '
        Me.btn1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn1.BackColor = System.Drawing.Color.Transparent
        Me.btn1.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn1.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn1.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn1.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(22, 21)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(56, 52)
        Me.btn1.TabIndex = 76
        Me.btn1.Text = "1"
        Me.btn1.TextColorDefault = System.Drawing.Color.Black
        Me.btn1.TextColorDisabled = System.Drawing.Color.Black
        Me.btn1.TextColorHover = System.Drawing.Color.White
        Me.btn1.TextColorNormal = System.Drawing.Color.White
        '
        'gbPriceInformation
        '
        Me.gbPriceInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbPriceInformation.Controls.Add(Me.Label16)
        Me.gbPriceInformation.Controls.Add(Me.Label38)
        Me.gbPriceInformation.Controls.Add(Me.cboTips)
        Me.gbPriceInformation.Controls.Add(Me.Label18)
        Me.gbPriceInformation.Controls.Add(Me.Label17)
        Me.gbPriceInformation.Controls.Add(Me.Label13)
        Me.gbPriceInformation.Controls.Add(Me.cboDiscount)
        Me.gbPriceInformation.Controls.Add(Me.txtNetPay)
        Me.gbPriceInformation.Controls.Add(Me.txtTips)
        Me.gbPriceInformation.Controls.Add(Me.txtDiscount)
        Me.gbPriceInformation.Controls.Add(Me.Label12)
        Me.gbPriceInformation.Controls.Add(Me.txtTotalPrice)
        Me.gbPriceInformation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbPriceInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPriceInformation.ForeColor = System.Drawing.Color.Maroon
        Me.gbPriceInformation.Location = New System.Drawing.Point(8, 8)
        Me.gbPriceInformation.Name = "gbPriceInformation"
        Me.gbPriceInformation.Size = New System.Drawing.Size(252, 426)
        Me.gbPriceInformation.TabIndex = 62
        Me.gbPriceInformation.TabStop = False
        Me.gbPriceInformation.Text = "Price Information    "
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(9, 258)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 22)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "in  Amount"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label38.BackColor = System.Drawing.Color.Ivory
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(9, 194)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(128, 22)
        Me.Label38.TabIndex = 67
        Me.Label38.Text = "in  Amount"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboTips
        '
        Me.cboTips.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboTips.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTips.Items.AddRange(New Object() {"5", "10", "15", "20", "25"})
        Me.cboTips.Location = New System.Drawing.Point(145, 226)
        Me.cboTips.Name = "cboTips"
        Me.cboTips.Size = New System.Drawing.Size(96, 21)
        Me.cboTips.TabIndex = 70
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(9, 226)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 22)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Service charge in %"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(9, 290)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 22)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Net Pay"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.BackColor = System.Drawing.Color.Ivory
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(9, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 22)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Discount in % "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboDiscount
        '
        Me.cboDiscount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboDiscount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiscount.Items.AddRange(New Object() {"5", "10", "15", "20", "25"})
        Me.cboDiscount.Location = New System.Drawing.Point(145, 162)
        Me.cboDiscount.Name = "cboDiscount"
        Me.cboDiscount.Size = New System.Drawing.Size(96, 21)
        Me.cboDiscount.TabIndex = 66
        '
        'txtNetPay
        '
        Me.txtNetPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNetPay.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetPay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.Location = New System.Drawing.Point(145, 290)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(96, 21)
        Me.txtNetPay.TabIndex = 74
        Me.txtNetPay.Text = ""
        '
        'txtTips
        '
        Me.txtTips.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTips.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTips.Location = New System.Drawing.Point(145, 258)
        Me.txtTips.MaxLength = 8
        Me.txtTips.Name = "txtTips"
        Me.txtTips.Size = New System.Drawing.Size(96, 21)
        Me.txtTips.TabIndex = 72
        Me.txtTips.Text = ""
        '
        'txtDiscount
        '
        Me.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(145, 194)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(96, 21)
        Me.txtDiscount.TabIndex = 68
        Me.txtDiscount.Text = ""
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(9, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 22)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Total Price"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalPrice.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPrice.Location = New System.Drawing.Point(145, 130)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(96, 21)
        Me.txtTotalPrice.TabIndex = 64
        Me.txtTotalPrice.Text = ""
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'MacButton1
        '
        Me.MacButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MacButton1.BackColor = System.Drawing.Color.Transparent
        Me.MacButton1.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.MacButton1.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.MacButton1.ButtonColorHover = System.Drawing.Color.Maroon
        Me.MacButton1.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.MacButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MacButton1.Location = New System.Drawing.Point(472, 540)
        Me.MacButton1.Name = "MacButton1"
        Me.MacButton1.Size = New System.Drawing.Size(104, 56)
        Me.MacButton1.TabIndex = 127
        Me.MacButton1.Text = " Miscell "
        Me.MacButton1.TextColorDefault = System.Drawing.Color.Black
        Me.MacButton1.TextColorDisabled = System.Drawing.Color.Black
        Me.MacButton1.TextColorHover = System.Drawing.Color.White
        Me.MacButton1.TextColorNormal = System.Drawing.Color.White
        '
        'chkBoxCollection
        '
        Me.chkBoxCollection.Location = New System.Drawing.Point(0, 0)
        Me.chkBoxCollection.Name = "chkBoxCollection"
        Me.chkBoxCollection.TabIndex = 0
        '
        'btntillOpen
        '
        Me.btntillOpen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btntillOpen.BackColor = System.Drawing.Color.Transparent
        Me.btntillOpen.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btntillOpen.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btntillOpen.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btntillOpen.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btntillOpen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntillOpen.Location = New System.Drawing.Point(696, 540)
        Me.btntillOpen.Name = "btntillOpen"
        Me.btntillOpen.Size = New System.Drawing.Size(104, 56)
        Me.btntillOpen.TabIndex = 120
        Me.btntillOpen.Text = "Till Open"
        Me.btntillOpen.TextColorDefault = System.Drawing.Color.Black
        Me.btntillOpen.TextColorDisabled = System.Drawing.Color.Black
        Me.btntillOpen.TextColorHover = System.Drawing.Color.White
        Me.btntillOpen.TextColorNormal = System.Drawing.Color.White
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(10048, 5109)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 40)
        Me.btnRefresh.TabIndex = 33
        Me.btnRefresh.Text = "Refresh Order"
        '
        'btnKeyBoard
        '
        Me.btnKeyBoard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeyBoard.BackColor = System.Drawing.Color.Transparent
        Me.btnKeyBoard.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btnKeyBoard.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnKeyBoard.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnKeyBoard.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btnKeyBoard.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyBoard.Location = New System.Drawing.Point(585, 540)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(104, 56)
        Me.btnKeyBoard.TabIndex = 119
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'btnDine
        '
        Me.btnDine.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDine.BackColor = System.Drawing.Color.Transparent
        Me.btnDine.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btnDine.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnDine.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnDine.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btnDine.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDine.Location = New System.Drawing.Point(354, 540)
        Me.btnDine.Name = "btnDine"
        Me.btnDine.Size = New System.Drawing.Size(104, 56)
        Me.btnDine.TabIndex = 118
        Me.btnDine.Text = "Dine"
        Me.btnDine.TextColorDefault = System.Drawing.Color.Black
        Me.btnDine.TextColorDisabled = System.Drawing.Color.Black
        Me.btnDine.TextColorHover = System.Drawing.Color.White
        Me.btnDine.TextColorNormal = System.Drawing.Color.White
        '
        'btCanceOrder
        '
        Me.btCanceOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btCanceOrder.BackColor = System.Drawing.Color.Transparent
        Me.btCanceOrder.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btCanceOrder.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btCanceOrder.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btCanceOrder.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btCanceOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCanceOrder.Location = New System.Drawing.Point(238, 540)
        Me.btCanceOrder.Name = "btCanceOrder"
        Me.btCanceOrder.Size = New System.Drawing.Size(104, 56)
        Me.btCanceOrder.TabIndex = 117
        Me.btCanceOrder.Text = "New"
        Me.btCanceOrder.TextColorDefault = System.Drawing.Color.Black
        Me.btCanceOrder.TextColorDisabled = System.Drawing.Color.Black
        Me.btCanceOrder.TextColorHover = System.Drawing.Color.White
        Me.btCanceOrder.TextColorNormal = System.Drawing.Color.White
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btnSubmit.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnSubmit.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnSubmit.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(256, 540)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(32, 56)
        Me.btnSubmit.TabIndex = 116
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextColorDefault = System.Drawing.Color.Black
        Me.btnSubmit.TextColorDisabled = System.Drawing.Color.Black
        Me.btnSubmit.TextColorHover = System.Drawing.Color.White
        Me.btnSubmit.TextColorNormal = System.Drawing.Color.White
        Me.btnSubmit.Visible = False
        '
        'btnPayment
        '
        Me.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPayment.BackColor = System.Drawing.Color.Transparent
        Me.btnPayment.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btnPayment.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnPayment.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnPayment.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btnPayment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Location = New System.Drawing.Point(120, 540)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(104, 56)
        Me.btnPayment.TabIndex = 115
        Me.btnPayment.Text = "Pending"
        Me.btnPayment.TextColorDefault = System.Drawing.Color.Black
        Me.btnPayment.TextColorDisabled = System.Drawing.Color.Black
        Me.btnPayment.TextColorHover = System.Drawing.Color.White
        Me.btnPayment.TextColorNormal = System.Drawing.Color.White
        '
        'btnAdministrate
        '
        Me.btnAdministrate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdministrate.BackColor = System.Drawing.Color.Transparent
        Me.btnAdministrate.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btnAdministrate.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnAdministrate.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnAdministrate.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btnAdministrate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrate.Location = New System.Drawing.Point(6, 540)
        Me.btnAdministrate.Name = "btnAdministrate"
        Me.btnAdministrate.Size = New System.Drawing.Size(104, 56)
        Me.btnAdministrate.TabIndex = 114
        Me.btnAdministrate.Text = "Admin"
        Me.btnAdministrate.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdministrate.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdministrate.TextColorHover = System.Drawing.Color.White
        Me.btnAdministrate.TextColorNormal = System.Drawing.Color.White
        '
        'stxtMain
        '
        Me.stxtMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.stxtMain.BackColor = System.Drawing.Color.Ivory
        Me.stxtMain.BorderColor = System.Drawing.Color.Transparent
        Me.stxtMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.stxtMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stxtMain.ForeColor = System.Drawing.Color.Brown
        Me.stxtMain.ForegroundBrush = Nothing
        Me.stxtMain.Location = New System.Drawing.Point(4, 4)
        Me.stxtMain.Name = "stxtMain"
        Me.stxtMain.ScrollDirection = ScrollingTextControl.ScrollDirection.Bouncing
        Me.stxtMain.ScrollText = ""
        Me.stxtMain.ShowBorder = True
        Me.stxtMain.Size = New System.Drawing.Size(684, 40)
        Me.stxtMain.StopScrollOnMouseOver = True
        Me.stxtMain.TabIndex = 121
        Me.stxtMain.TextScrollDistance = 2
        Me.stxtMain.TextScrollSpeed = 25
        Me.stxtMain.VerticleTextPosition = ScrollingTextControl.VerticleTextPosition.Center
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnCancel.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnCancel.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnCancel.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(746, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(48, 40)
        Me.btnCancel.TabIndex = 123
        Me.btnCancel.Text = "X"
        Me.btnCancel.TextColorDefault = System.Drawing.Color.Black
        Me.btnCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.btnCancel.TextColorHover = System.Drawing.Color.White
        Me.btnCancel.TextColorNormal = System.Drawing.Color.White
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnMinimize.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnMinimize.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnMinimize.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(693, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(48, 40)
        Me.btnMinimize.TabIndex = 122
        Me.btnMinimize.Text = "__"
        Me.btnMinimize.TextColorDefault = System.Drawing.Color.Black
        Me.btnMinimize.TextColorDisabled = System.Drawing.Color.Black
        Me.btnMinimize.TextColorHover = System.Drawing.Color.White
        Me.btnMinimize.TextColorNormal = System.Drawing.Color.White
        '
        'btnUser
        '
        Me.btnUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUser.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btnUser.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnUser.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnUser.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btnUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Location = New System.Drawing.Point(6, 540)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(104, 56)
        Me.btnUser.TabIndex = 115
        Me.btnUser.Text = "User"
        Me.btnUser.TextColorDefault = System.Drawing.Color.Black
        Me.btnUser.TextColorDisabled = System.Drawing.Color.Black
        Me.btnUser.TextColorHover = System.Drawing.Color.White
        Me.btnUser.TextColorNormal = System.Drawing.Color.White
        Me.btnUser.Visible = False
        '
        'frmTakeaway
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.stxtMain)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnKeyBoard)
        Me.Controls.Add(Me.btnDine)
        Me.Controls.Add(Me.btCanceOrder)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnAdministrate)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.tabTakeaway)
        Me.Controls.Add(Me.btntillOpen)
        Me.Controls.Add(Me.MacButton1)
        Me.Controls.Add(Me.btnUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTakeaway"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabTakeaway.ResumeLayout(False)
        Me.tbpgCustInfo.ResumeLayout(False)
        CType(Me.AxActiveCID1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAdditionalInformation.ResumeLayout(False)
        Me.gbBasicInfo.ResumeLayout(False)
        Me.lblTotalPrice.ResumeLayout(False)
        Me.xpndLstScnd.ResumeLayout(False)
        Me.tbpgPayment.ResumeLayout(False)
        Me.gbPaymentInformation.ResumeLayout(False)
        Me.gbPrintOrder.ResumeLayout(False)
        Me.gbPriceCalculation.ResumeLayout(False)
        Me.gbPriceInformation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private Function FillInstructionCombo()
        Dim iCountDataSetRow As Integer
        Dim strSQL As String

        Dim dsInstruction As DataSet
        Dim daInstruction As SqlClient.SqlDataAdapter


        strSQL = "SELECT nInstruction_Id,cInstruction FROM tInstruction WHERE nItem_Id=0 AND nActiveInstruction=1 ORDER BY cInstruction"
        Try
            dsInstruction = New DataSet("Instruction")
            daInstruction = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daInstruction.Fill(dsInstruction, "Instruction")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        cboInstruction.DataSource = Nothing
        cboInstruction.Items.Clear()

        iCountDataSetRow = dsInstruction.Tables("Instruction").Rows.Count
        If iCountDataSetRow > 0 Then
            cboInstruction.DataSource = dsInstruction.Tables("Instruction")
            cboInstruction.DisplayMember = "cInstruction"
            cboInstruction.SelectedIndex = -1
        End If
    End Function

    Private Function FillCardCombo()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsCard As DataSet
        Dim daCardInfo As SqlClient.SqlDataAdapter

        Try
            dsCard = New DataSet("Card")
            strSQL = "SELECT cCardType,nCardId FROM tCard_Info WHERE nCardActive = 1"
            daCardInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCardInfo.Fill(dsCard, "Card")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsCard.Tables("Card").Rows.Count

        If icount > 0 Then
            With cboCardType
                .DataSource = dsCard.Tables("Card")
                .DisplayMember = "cCardType"
                .ValueMember = "nCardId"
                .SelectedIndex = -1
            End With
        End If
    End Function

    Private Function FillDriverCombo()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsDriver As DataSet
        Dim daDriverInfo As SqlClient.SqlDataAdapter

        Try
            dsDriver = New DataSet("Driver")
            strSQL = "SELECT nEmployeeId,cEmployeeName FROM tEmployee WHERE nActiveEmployee = 1 AND cDesignation='Driver'"
            daDriverInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daDriverInfo.Fill(dsDriver, "Driver")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsDriver.Tables("Driver").Rows.Count

        If icount > 0 Then
            With cboDriverNumber
                .DataSource = dsDriver.Tables("Driver")
                .DisplayMember = "nEmployeeId"
                .ValueMember = "cEmployeeName"
                .SelectedIndex = -1
            End With
        End If
    End Function

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim iItemCount As Integer
        Dim iItemQty As Integer
        Dim lvOrderItem As ListViewItem
        Dim dTotalPrice As Double
        Dim dUnitPrice As Double

        iItemCount = lvOrder.Items.Count

        If iItemCount >= 1 Then
            For Each lvOrderItem In lvOrder.SelectedItems
                iItemQty = lvOrderItem.SubItems(1).Text
                dTotalPrice = Decimal.Parse(Trim(lvOrder.SelectedItems(0).SubItems(3).Text), NumberStyles.Currency)
                dUnitPrice = dTotalPrice / iItemQty

                lvOrderItem.SubItems(1).Text = CStr(iItemQty - 1)
                If iItemQty = 1 Then
                    Me.lvOrder.Items.Remove(lvOrderItem)
                Else
                    If iItemQty > 1 Then
                        lvOrderItem.SubItems(1).Text = CStr(iItemQty - 1)
                        lvOrderItem.SubItems(3).Text = dUnitPrice * Val(Trim(lvOrderItem.SubItems(1).Text))
                    End If
                End If
            Next
        End If
        Call CalculateTotalPrice()
        Call calculatetotalItem()
        FillInstructionCombo()
    End Sub

    Public Sub AddXpndrtoPnl()

        Dim strSQL As String
        Dim icount As Integer 'For count the number of rows in Category Dataset 
        Dim ds As DataSet
        Dim da As SqlClient.SqlDataAdapter

        Try
            ds = New DataSet("DishMenu")
            strSQL = "SELECT * FROM tCategory WHERE nCtgyActive=1" '
            da = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            da.Fill(ds, "dsCategory")

            icount = ds.Tables("dsCategory").Rows.Count
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        Dim i As Integer
        For i = 0 To icount - 1
            Dim XPanderTemp As New XPanderControl.XPander
            XPanderTemp.Width = 187
            XPanderTemp.Height = 31
            XPanderTemp.Left = 11
            XPanderTemp.Top = 9
            XPanderTemp.CaptionHeight = 30
            XPanderTemp.CaptionFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
            XPanderTemp.CaptionText = ds.Tables(0).Rows(i).Item(1)
            Me.xpnLstMain.Controls.Add(XPanderTemp)
            XPanderTemp.CaptionLeftColor = Color.RosyBrown
            XPanderTemp.CaptionRightColor = Color.Maroon
            XPanderTemp.CaptionTextColor = Color.White
            XPanderTemp.CaptionTextHighlightColor = Color.DarkOrange
            AddLabeltoXpander(XPanderTemp, 2, ds.Tables(0).Rows(i).Item(0))
            XPanderTemp.Collapse()
            AddHandler XPanderTemp.Click, AddressOf CaltegoryClick
        Next
    End Sub

    Public Sub CaltegoryClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.xpndrItems.Controls.Clear()
        Me.xpndrItems.Width = 187
        Me.xpndrItems.Height = 31
        Me.xpndrItems.Left = 11
        Me.xpndrItems.Top = 9
        sender.width = 187
        sender.left = 11
        Me.xpndrItems.CaptionText = "No Dish Type selected"
        If xpnLstMain.DisplayRectangle.Height > 424 Then
            Me.xpndLstScnd.AutoScroll = True
        Else
            Me.xpndLstScnd.AutoScroll = False
        End If
    End Sub

    '"Type Menu"
    Public Sub AddLabeltoXpander(ByRef rXpanderTemp As XPanderControl.XPander, ByVal Flag As Integer, ByVal aCtgryId As Integer)

        Dim strSQL As String
        Dim icount As Integer 'For count the number of rows in Category Dataset 
        Dim ds As DataSet

        Try
            ds = New DataSet("DishMenu")
            strSQL = "SELECT * FROM tType WHERE nCtgry_Id=" & aCtgryId & " AND nTypeActive=1"
            da = New SqlClient.SqlDataAdapter(strSQL, connRestuarant)
            da.Fill(ds, "dsType")

            icount = ds.Tables("dsType").Rows.Count
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        Dim i As Integer
        Dim Count As Integer
        If icount > 0 Then
            For i = 0 To icount - 1 'No_of_Items
                Dim btnType As New MACButtonLib.MACButton
                With btnType
                    .Width = 165     ''First xpander Label width
                    .Height = 40
                    .Top = 35 + 40 * Count
                    .Left = 4

                    .ButtonColorNormal = Color.Salmon
                    .ButtonColorHover = Color.Maroon
                    .ButtonColorDisabled = Color.SeaShell
                    .ButtonColorDefault = Color.DarkOrange
                    .Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
                    .TextColorDefault = Color.Black
                    .TextColorDisabled = Color.Black
                    .TextColorHover = Color.White
                    .TextColorNormal = Color.White
                    .Tag = Trim(ds.Tables(0).Rows(i).Item(0)) 'Type ID
                    .Text = Trim(ds.Tables(0).Rows(i).Item(2)) ' Type name
                End With
                With rXpanderTemp
                    .Controls.Add(btnType)
                    .Width = 187
                    .Left = 11
                    .Height = 40 + 40 * Count
                    .BackColor = Color.Ivory
                    .PaneBottomRightColor = Color.Ivory
                    .PaneOutlineColor = Color.White
                    .PaneTopLeftColor = Color.Honeydew
                End With

                'Set initial properties for the Label object.
                AddHandler btnType.Click, AddressOf ClickXpndrMainHandler
                Count += 1
            Next
            rXpanderTemp.Height += 40
        Else
            rXpanderTemp.Width = 187
            rXpanderTemp.Height = 31
            rXpanderTemp.Left = 11
        End If

        'Dim XPanderTemp As New XPanderControl.XPander
        'XPanderTemp.Width = 187
        'XPanderTemp.Height = 0
        'xpndLstScnd.Controls.Add(XPanderTemp)
    End Sub

    'Function to add Labels to the Secondary Panel X pander  item colour
    Public Sub AddLabeltoXpander(ByRef rXpanderTemp As XPanderControl.XPander, ByVal Flag As Char, ByVal aTypeId As Integer)

        Dim ds As DataSet
        Dim strSQL As String
        Dim icount As Integer 'For count the number of rows in Category Dataset 
        Dim iColumn As Integer = 0
        Dim iRow As Integer = 0

        strSQL = "SELECT nItem_Id,cItem_Name,cItem_SC,nItem_Stock,mTakeawayPrice,cItem_ServeLoc " & _
                 " FROM tItem WHERE nType_Id= " & aTypeId & " AND nItemActive=1 ORDER BY  nItem_Id"

        Try
            ds = New DataSet("DishMenu")
            da = New SqlClient.SqlDataAdapter(strSQL, connRestuarant)
            da.Fill(ds, "dsItem")
            icount = ds.Tables("dsItem").Rows.Count
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        ReDim strItemInfo(icount, 4)

        Dim i As Integer

        Dim Count As Integer
        If icount > 0 Then
            For i = 0 To icount - 1 'No_of_Items
                Dim btnType As New MACButtonLib.MACButton
                With btnType
                    '.Width = 165    ''First xpander Label width 180
                    '.Height = 40
                    '.Top = 35 + 40 * Count
                    '.Left = 4

                    .Width = 110 ''First xpander Label width  180
                    .Height = 40
                    .Top = 40 + 40 * iRow
                    .Left = 2 + 114 * iColumn



                    .ButtonColorNormal = Color.OliveDrab 'Color.Salmon
                    .ButtonColorHover = Color.Maroon
                    .ButtonColorDisabled = Color.SeaShell
                    .ButtonColorDefault = Color.DarkOrange
                    .Font = New System.Drawing.Font("Arial ", 7.0!, System.Drawing.FontStyle.Bold)
                    .TextColorDefault = Color.Black
                    .TextColorDisabled = Color.Black
                    .TextColorHover = Color.White
                    .TextColorNormal = Color.White
                    .Tag = i
                    .Text = Trim(ds.Tables(0).Rows(i).Item(2))      'Item Short Code
                End With

                With rXpanderTemp
                    .Controls.Add(btnType)
                    .Left = 11
                    .Width = 246
                    '.Height = 40 + 40 * Count
                    .Height = 40 + 40 * iRow
                    .CaptionTextAlign = XPanderControl.XPander.CaptionTextAlignment.Middle
                    .BackColor = Color.Ivory
                    .PaneBottomRightColor = Color.Ivory
                    .PaneOutlineColor = Color.White
                    .PaneTopLeftColor = Color.Honeydew
                End With

                strItemInfo(i, 0) = Trim(ds.Tables(0).Rows(i).Item(0)) 'Item ID
                strItemInfo(i, 1) = Trim(ds.Tables(0).Rows(i).Item(2)) 'Item Short Code
                strItemInfo(i, 2) = Trim(ds.Tables(0).Rows(i).Item(3)) 'Item Stock in Hand
                strItemInfo(i, 3) = Trim(ds.Tables(0).Rows(i).Item(4)) 'Item Takeaway In Price
                strItemInfo(i, 4) = Trim(ds.Tables(0).Rows(i).Item(5)) 'Item Serve location

                AddHandler btnType.Click, AddressOf ClickXpndrScndHandler
                'Count += 1

                iColumn += 1
                If iColumn = 2 Then
                    iColumn = 0

                    iRow += 1
                End If

            Next
            rXpanderTemp.Height += 40
            'Dim XPanderTemp As New XPanderControl.XPander
            'XPanderTemp.Width = 187
            'XPanderTemp.Height = 31
            'xpndLstScnd.Controls.Add(XPanderTemp)
        Else
            Me.xpndrItems.Height = 30
            rXpanderTemp.Width = 246
            rXpanderTemp.Height = 40
        End If
    End Sub

    Public Sub ClickXpndrMainHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim iHeight As Integer
        Dim cFlag As Char
        strClickTypeName = strNewClickType
        If bClickedBefore = False Then
            Me.xpndLstScnd.Controls.Clear()
            Me.xpndrItems.Controls.Clear()
            Me.xpndrItems.Width = 258
            Me.xpndrItems.Left = 11
            Me.xpndrItems.Top = 9
            Me.xpndLstScnd.Controls.Add(xpndrItems)
            Me.xpndrItems.CaptionText = sender.Text
            Dim tmpInt As Integer = CInt(sender.tag)
            AddLabeltoXpander(Me.xpndrItems, cFlag, tmpInt)
            iHeight = Me.xpndrItems.Height
            strNewClickType = Me.xpndrItems.CaptionText
            bClickedBefore = True
            If iHeight > 424 Then
                Me.xpndLstScnd.AutoScroll = True
            Else
                Me.xpndLstScnd.AutoScroll = False
            End If
        ElseIf bClickedBefore = True Then
            Me.xpndLstScnd.Controls.Clear()
            Me.xpndrItems.Controls.Clear()
            Me.xpndrItems.Width = 258
            Me.xpndrItems.Left = 11
            Me.xpndrItems.Top = 9
            Me.xpndLstScnd.Controls.Add(xpndrItems)
            Me.xpndrItems.CaptionText = sender.Text
            Dim tmpInt As Integer = CInt(sender.tag)
            AddLabeltoXpander(Me.xpndrItems, cFlag, tmpInt)
            iHeight = Me.xpndrItems.Height

            If iHeight > 424 Then
                Me.xpndLstScnd.AutoScroll = True
            Else
                Me.xpndLstScnd.AutoScroll = False
            End If

            strNewClickType = Me.xpndrItems.CaptionText

            If strClickTypeName = strNewClickType Then
                Me.xpndLstScnd.AutoScroll = False
                xpnLstMain.Controls.Clear()
                AddXpndrtoPnl()
                Me.xpndrItems.Controls.Clear()
                Me.xpndrItems.Width = 258
                Me.xpndrItems.Left = 11
                Me.xpndrItems.Top = 9
                Me.xpndrItems.CaptionText = "No Dish Type selected"
                bClickedBefore = False
            Else
                bClickedBefore = True
            End If
        End If
    End Sub

    Public Sub ClickXpndrScndHandler(ByVal sender As Object, ByVal e As _
   System.EventArgs)
        cboInstruction.Text = vbNullString
        Dim i As Integer
        Dim iIndex As Integer

        Dim strTypename As String
        Dim strImageName As String = "skin.bmp"
        Dim strTitel As String = "Item Stock Information"
        Dim strMessage As String = "Your Selected Item is in Reorder Label." & vbCrLf & "Please Update the Stock."
        Dim recTitleRectangle As New Rectangle(110, 65, 200, 28)
        Dim recTextRectangle As New Rectangle(90, 92, 200, 55)
        Dim pClosingPoint As New Point(280, 69)

        strTypename = Me.xpndrItems.CaptionText
        iIndex = sender.tag

        If lvOrder.Items.Count = 0 Then
            Me.lvOrder.Items.Add(" ")
            Me.lvOrder.Items(0).SubItems.Add("1")
            Me.lvOrder.Items(0).SubItems.Add(strItemInfo(iIndex, 1))
            Me.lvOrder.Items(0).SubItems.Add(FormatCurrency(strItemInfo(iIndex, 3)))
            Me.lvOrder.Items(0).SubItems.Add(cboInstruction.Text)
            Me.lvOrder.Items(0).SubItems.Add(strItemInfo(iIndex, 0))
            Me.lvOrder.Items(0).SubItems.Add(strItemInfo(iIndex, 2))
            Me.lvOrder.Items(0).SubItems.Add(strItemInfo(iIndex, 4))
            Me.lvOrder.Items(0).SubItems.Add(strTypename)
            Me.lvOrder.Focus()                     'new added for order highlight on london 12.1.08
            Me.lvOrder.Items(0).Selected = True    'new added for order highlight on london 12.1.08
        Else
            For i = 0 To Me.lvOrder.Items.Count - 1
                If Me.lvOrder.Items(i).SubItems(5).Text = strItemInfo(iIndex, 0) And Me.lvOrder.Items(i).SubItems(4).Text = vbNullString Then

                    If (Val(strItemInfo(iIndex, 2)) - Val(lvOrder.Items(i).Text)) <= 4 Then
                        'ShowTaskBarNotifire(strImageName, strTitel, strMessage, recTitleRectangle, recTextRectangle, pClosingPoint)
                        Me.lvOrder.Items(i).SubItems(1).Text = Val(Me.lvOrder.Items(i).SubItems(1).Text) + 1
                        Me.lvOrder.Items(i).SubItems(3).Text = FormatCurrency(Val(strItemInfo(iIndex, 3)) * Val(Me.lvOrder.Items(i).SubItems(1).Text))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 0))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 2))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 4))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strTypename)
                        Me.lvOrder.Focus()                    'new added for order highlight on london 12.1.08
                        Me.lvOrder.Items(i).Selected = True   'new added for order highlight on london 12.1.08
                    Else
                        Me.lvOrder.Items(i).SubItems(1).Text = Val(Me.lvOrder.Items(i).SubItems(1).Text) + 1
                        Me.lvOrder.Items(i).SubItems(3).Text = FormatCurrency(Val(strItemInfo(iIndex, 3)) * Val(Me.lvOrder.Items(i).SubItems(1).Text))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 0))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 2))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 4))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strTypename)
                        Me.lvOrder.Focus()            'new added for order highlight on london 12.1.08
                        Me.lvOrder.Items(i).Selected = True  'new added for order highlight on london 12.1.08
                    End If
                    Exit For
                ElseIf i = Me.lvOrder.Items.Count - 1 Then
                    Me.lvOrder.Items.Add(" ")
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add("1")
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 1))
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(FormatCurrency(strItemInfo(iIndex, 3)))
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(cboInstruction.Text)
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 0))
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 2))
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 4))
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strTypename)
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).EnsureVisible()
                    Me.lvOrder.Focus()             'new added for order highlight on london 12.1.08
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).Selected = True    'new added for order highlight on london 12.1.08
                    If lvOrder.CheckBoxes = True Then
                        Dim NewQty As Integer
                        NewQty = CInt(lvOrder.Items(lvOrder.Items.Count - 1).SubItems(1).Text)
                        lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(0)
                    End If
                End If
            Next

            If lvOrder.CheckBoxes = True Then
                lvOrder.Items(i).Checked = True
            End If

        End If

        Call CalculateTotalPrice()
        Call calculatetotalItem()

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

    Public Sub ClickMenuItemUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        sender.backcolor = Color.Transparent
    End Sub

    Public Sub ClickMenuItemDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        sender.backcolor = Color.Orange
    End Sub

    Private Function CalculateTotalPrice()
        Dim i As Integer
        Dim dTotalPrice As Double
        i = 0
        dTotalPrice = 0
        For i = 1 To lvOrder.Items.Count
            dTotalPrice = dTotalPrice + CDbl(lvOrder.Items(i - 1).SubItems(3).Text)
        Next
        If dTotalPrice = 0 Then
            lblTotalOrderPrice.Text = ""
        Else
            lblTotalOrderPrice.Text = FormatCurrency(dTotalPrice)
            txtNetPay.Text = lblTotalOrderPrice.Text               'new added 'milton 21-05-07'
        End If
    End Function

    Private Sub frmTakeaway_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddXpndrtoPnl()
        conControlName = txtCustomerNo
        dblFirstValue = 1
        dblSecondValue = 1

        If mdConfiguration.user = "Administrator" Then
            btnAdministrate.Visible = True
        Else
            btnAdministrate.Visible = False
            btnUser.Visible = True
        End If

        txtDateOfEntry.Text = GetOrderDate().Date
        txtLastOrderDate.Text = GetOrderDate().Date
        mdConfiguration.GetPrinterSetting()
        txtCustomerNo.Text = "New Customer"

        Dim BackgroundBrush As New LinearGradientBrush(Me.stxtMain.ClientRectangle _
                           , Color.Honeydew, Color.White, LinearGradientMode.Horizontal)
        stxtMain.BackgroundBrush = BackgroundBrush

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            stxtMain.ScrollText = "UySys eRestuarant " & ": Takeaway"
        Else
            stxtMain.ScrollText = mdConfiguration.strResturantName & ": Takeaway"
        End If

        bCboLoad = True
        FillCardCombo()
        ''cboCardType.SelectedIndex = 0
        FillDriverCombo()
        cboDriverNumber.SelectedIndex = -1
        FillInstructionCombo()
        cboInstruction.SelectedIndex = -1
        bCboLoad = False

        gError = False
        If GetSetting("Restaurant", "PrintSetting", "SerialPort") <> vbNullString Then
            AxActiveCID1.Port = CInt(GetSetting("Restaurant", "PrintSetting", "SerialPort")) ' set the port
            Try
                AxActiveCID1.Initialise()                                                    ' initialise ActiveCID
            Catch ex As Exception
                MsgBox(ex)
            End Try
        Else
            MsgBox("There is no port is selected for Caller ID." & vbCrLf & _
                   " So pleaes select one port for Caller ID.")
        End If

        'If GetSetting("Restaurant", "PrintSetting", "SerialPort") <> vbNullString Then
        '    moActiveCID = New ActiveCIDNet.clsMain
        '    moActiveCID.Port = CInt(GetSetting("Restaurant", "PrintSetting", "SerialPort")) ' set the port
        '    Try
        '        moActiveCID.Initialise()
        '    Catch ex As Exception
        '        MsgBox(ex)
        '    End Try
        'Else
        '    MsgBox("There is no port is selected for Caller ID." & vbCrLf & _
        '           " So pleaes select one port for Caller ID.")
        'End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim strSQL As String
        ClearAllField()
        txtDateOfEntry.Text = GetOrderDate().Date
        If btnSubmit.Enabled = False Then
            btnSubmit.Enabled = True
        End If
        iOrderId = 0
    End Sub

    Private Sub cboInstruction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInstruction.SelectedIndexChanged
        'Dim i As Integer
        'Dim lvOrderItem As ListViewItem
        'For Each lvOrderItem In Me.lvOrder.SelectedItems
        '    lvOrderItem.SubItems(3).Text = sender.Text
        'Next
    End Sub

    Private Sub cboInstruction_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInstruction.Click
        cboInstruction.Text = vbNullString
    End Sub

    Private Sub btnKeyBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyBoard.Click
        If Not IsNothing(objfrmKeyBoard) Then
            objfrmKeyBoard = New frmKeyBoard
            objfrmKeyBoard.Show()
        Else
            objfrmKeyBoard = Nothing
            objfrmKeyBoard = New frmKeyBoard
            objfrmKeyBoard.Show()
        End If
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btnDot.Click
        If mdValidation.IsTextEditableControl(conControlName) = True Then
            IsEnterPress(conControlName)
            conControlName.Text += sender.Text
        End If
    End Sub

    Private Sub txtCashPay_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashPay.LostFocus
        If txtCashPay.Text <> vbNullString Then
            txtCashPay.Text = FormatCurrency(txtCashPay.Text)
        End If
    End Sub

    Private Sub txtCardPay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCardPay.LostFocus
        If Trim(txtCardPay.Text) <> vbNullString Then
            txtCardPay.Text = FormatCurrency(txtCardPay.Text)
        End If

    End Sub

    Private Sub txtCheque_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChequePay.LostFocus
        If Trim(txtChequePay.Text) <> vbNullString Then
            txtChequePay.Text = FormatCurrency(txtChequePay.Text)
        End If
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        IsMultiplyButtonPress(conControlName)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If conControlName.Focus() = True And conControlName.Text <> vbNullString Then
            CalculateResult(conControlName)
        End If
    End Sub

    Private Sub btnBckSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBckSpace.Click
        If conControlName.Text.Length > 0 Then
            conControlName.Text = conControlName.Text.Remove(conControlName.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        conControlName.Text = vbNullString
    End Sub

    Public Sub clearInfo(ByVal aContainer As Object)
        '-------------------------------------------------------------------
        'Purpose                :Following sub procedure takes the from name
        '                        as argument clear all the TextBox, ComboBox,
        '                        FlextGrid, ListView and CheckBox available
        '                        in the Form
        'Author                 :Humayun Kabir Foysol,Md. Monjur Morshed
        'Created on             :16-NOV-2005
        'Last Modification By   :Md. Monjur Morshed 
        '-------------------------------------------------------------------
        Dim ctrl As Control

        For Each ctrl In aContainer.Controls
            If TypeName(ctrl) = "TextBox" Then
                ctrl.Text = vbNullString
            End If
        Next
    End Sub

    Private Sub btnAdministrate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministrate.Click
        'Dim ofrmAdmin As New frmAdmin
        'ofrmAdmin.Show()
        'Me.Dispose()

        If lvOrder.Items.Count = 0 Then
            Dim ofrmAdmin As New frmAdmin
            ofrmAdmin.Show()
            Me.Dispose()

        ElseIf btnPayBill.Enabled = False Then
            Dim ofrmAdmin As New frmAdmin
            ofrmAdmin.Show()
            Me.Dispose()
        ElseIf btnPay.Enabled = False Then
            Dim ofrmAdmin As New frmAdmin
            ofrmAdmin.Show()
            Me.Dispose()
        Else
            Dim Itype As Integer
            Itype = MsgBox("A Ordered is Remaninig!!if want to keep,Press YES", MsgBoxStyle.YesNo, "eRestuarant")
            If Itype = MsgBoxResult.Yes Then
                If lvOrder.CheckBoxes = False Then
                    Me.tabTakeaway.SelectedIndex = 2
                    SubmitOrder()
                    Dim ofrmAdmin As New frmAdmin
                    ofrmAdmin.Show()
                    Me.Dispose()
                ElseIf lvOrder.CheckBoxes = True Then
                    Me.tabTakeaway.SelectedIndex = 2
                    UpdateOrder()
                    Dim ofrmAdmin As New frmAdmin
                    ofrmAdmin.Show()
                    Me.Dispose()
                End If
            Else
                Dim ofrmAdmin As New frmAdmin
                ofrmAdmin.Show()
                Me.Dispose()

            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ClearAllField()
    End Sub

    Private Sub btnDine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDine.Click


        If lvOrder.Items.Count = 0 Then
            Dim ofrm As New frmDine
            ofrm.Show()
            Me.Dispose()
        ElseIf btnPayBill.Enabled = False Then
            Dim ofrm As New frmDine
            ofrm.Show()
            Me.Dispose()
        ElseIf btnPay.Enabled = False Then
            Dim ofrm As New frmDine
            ofrm.Show()
            Me.Dispose()
        Else
            Dim Itype As Integer
            Itype = MsgBox("A Ordered is Remaninig!!if want to keep,Press YES", MsgBoxStyle.YesNo, "eRestuarant")
            If Itype = MsgBoxResult.Yes Then
                If lvOrder.CheckBoxes = False Then
                    Me.tabTakeaway.SelectedIndex = 2
                    SubmitOrder()
                    Dim ofrm As New frmDine
                    ofrm.Show()
                    Me.Dispose()
                ElseIf lvOrder.CheckBoxes = True Then
                    Me.tabTakeaway.SelectedIndex = 2
                    UpdateOrder()
                    Dim ofrm As New frmDine
                    ofrm.Show()
                    Me.Dispose()
                End If
            Else
                Dim ofrm As New frmDine
                ofrm.Show()
                Me.Dispose()

            End If
        End If
    End Sub

    Private Function MakeCardDate(ByVal tmpDate As String) As String
        If tmpDate.Length <= 5 Then
            tmpDate = "01/" + tmpDate
        End If
        MakeCardDate = tmpDate
    End Function

    Private Function SubmitOrder()

        Dim strSQLInsertCust_Info As String
        Dim strSQLInsertOrder_Info As String
        Dim strSQLInsertOrder_Payment As String
        Dim strSQLUpdateCust_Info As String
        Dim strSQLUpdateStock_Info As String

        Dim strSQL As String
        Dim sInstruction As String
        Dim strCustEntryDate As String
        Dim strLastOrderDate As String
        Dim strCardValidDate As String
        Dim strCardExpireDate As String

        Dim iIndex As Integer
        Dim icountLVRow As Integer
        Dim iItemId As Integer
        Dim iQuantity As Integer
        Dim iQuantityInHand As Integer
        Dim iCurrentStock As Integer
        Dim iOrderStatus As Integer
        Dim srtsqlstatus As String

        Dim dTotalPrice As Double
        Dim dDiscount As Double
        Dim dTips As Double
        Dim dNetPrice As Double
        Dim dCash As Double
        Dim dCard As Double
        Dim dBalance As Double

        Dim dUnitPrice As Double
        Dim dTotalPricePerItem As Double

        Dim blnTrans As Boolean

        Dim strImageName As String = "skin1.bmp"
        Dim strTitel As String = "Save Message"
        Dim strMessage As String = "Your Order has been created Successfully"
        Dim recTitleRectangle As New Rectangle(148, 50, 200, 28)
        Dim recTextRectangle As New Rectangle(90, 92, 200, 55)
        Dim pClosingPoint As New Point(280, 56)

        Me.lvOrder.Sorting = SortOrder.Ascending

        Dim cmdInsert As SqlClient.SqlCommand
        Dim tnsAll_Quary As SqlClient.SqlTransaction

        '----------To add or Update Customer Information-----------------------------------------------------
        'If chkBoxWaitingCust.Checked = False Then
        '    '    If Len(Trim(txtPhoneNumber.Text)) <= 0 Then
        '    '        MessageBox.Show("Please insert Customer phone number", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    '        tabTakeaway.SelectedIndex = 0
        '    '        txtPhoneNumber.Focus()
        '    '        Exit Function
        '    '    ElseIf Len(Trim(txtPostCode.Text)) <= 0 Then
        '    '        MessageBox.Show("Please insert Post Code.", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    '        tabTakeaway.SelectedIndex = 0
        '    '        txtPostCode.Focus()
        '    '        Exit Function
        '    '    End If
        '    'Else
        '    '    'If Len(Trim(txtName.Text)) <= 0 Then
        '    '    '    MessageBox.Show("Please insert Customer Name", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    '    '    tabTakeaway.SelectedIndex = 0
        '    '    '    'txtName.Focus()
        '    '    'End If
        '    'End If

        '    If Len(Trim(cboDriverNumber.Text)) <= 0 Then
        '        cboDriverNumber.Text = "0"
        '    Else
        '        If ValidationForEmailAddress(txtEmail) = False Then
        '            MessageBox.Show("Please email address in right format", "eRestuarant", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
        '    End If

        'ElseIf chkBoxCollection.Checked = False Then

        If Len(Trim(cboDriverNumber.Text)) <= 0 Then
            cboDriverNumber.Text = "0"
        Else
            If ValidationForEmailAddress(txtEmail) = False Then
                MessageBox.Show("Please email address in right format", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        ' End If


        If txtIssueNo.Text = vbNullString Then
            txtIssueNo.Text = 0
        End If

        If Trim(txtCustomerNo.Text) = "New Customer" Then
            txtCustomerNo.Text = ""
        End If

        strCustEntryDate = DateTime.Parse(Trim(txtDateOfEntry.Text)).ToString("MM/dd/yyyy")
        strLastOrderDate = DateTime.Parse(Trim(txtLastOrderDate.Text)).ToString("MM/dd/yyyy")


        If Trim(txtValidFrom.Text) <> vbNullString Then
            Try
                strCardValidDate = DateTime.Parse(MakeCardDate(Trim(txtValidFrom.Text))).ToString("MM/dd/yyyy")
            Catch ex As Exception
                MessageBox.Show("Date Format is not correct.", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tabTakeaway.SelectedIndex = 0
                txtValidFrom.Focus()
            End Try
        Else
            strCardValidDate = vbNullString
        End If

        If Trim(txtExpiryDate.Text) <> vbNullString Then
            Try
                strCardExpireDate = DateTime.Parse(MakeCardDate(Trim(txtExpiryDate.Text))).ToString("MM/dd/yyyy")
            Catch ex As Exception
                MessageBox.Show("Date Format is not correct.", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tabTakeaway.SelectedIndex = 0
                txtExpiryDate.Focus()
            End Try
        Else
            strCardExpireDate = vbNullString
        End If

        strSQLInsertCust_Info = "INSERT INTO tCust_Info(cCust_Name,cPhnNo,cPostCode,cAddress,cCompany,dCust_EntryDate" & _
                                ",dLstOrdrDate,cCust_BillAdd,cEmail,cURL,cCust_Fax,cCust_Mobile,cComment,cDriverDirection, " & _
                                "cReview,cCardHolder,cCardNo,nIssueNo,dValidfrom,dExpiryDate,cCity,nDriverNumber,cUserId,cTermenal,dAccessTime)" & _
                                " VALUES('" & Replace(Trim(txtName.Text), "'", "''") & "','" & Replace(Trim(txtPhoneNumber.Text), "'", "''") & _
                                "','" & Replace(Trim(txtPostCode.Text), "'", "''") & "','" & Replace(Trim(txtAddress.Text), "'", "''") & _
                                "','" & Replace(Trim(txtCompany.Text), "'", "''") & "','" & strCustEntryDate & "','" & strLastOrderDate & _
                                "','" & Replace(Trim(txtBillAddress.Text), "'", "''") & "','" & Replace(Trim(txtEmail.Text), "'", "''") & _
                                "','" & Replace(Trim(txtURL.Text), "'", "''") & "','" & Replace(Trim(txtFaxNo.Text), "'", "''") & _
                                "','" & Replace(Trim(txtMobile.Text), "'", "''") & "','" & Replace(Trim(txtComments.Text), "'", "''") & _
                                "','" & Replace(Trim(txtDriverDic.Text), "'", "''") & "','" & Replace(Trim(txtReviews.Text), "'", "''") & _
                                "','" & Replace(Trim(txtCardHolder.Text), "'", "''") & "','" & Replace(Trim(txtCreditCard.Text), "'", "''") & _
                                "'," & CStr(txtIssueNo.Text) & ",'" & strCardValidDate & "','" & strCardExpireDate & _
                                "','" & Replace(Trim(txtTown.Text), "'", "''") & "'," & CStr(Trim(cboDriverNumber.Text)) & ",'" + user + _
                                " ','" + sTerminal + "',GETDATE())"

        strSQLUpdateCust_Info = "UPDATE tCust_Info SET cCust_Name='" & Replace(Trim(txtName.Text), "'", "''") & _
                                "',cPhnNo='" & Replace(Trim(txtPhoneNumber.Text), "'", "''") & _
                                "',cPostCode='" & Replace(Trim(txtPostCode.Text), "'", "''") & _
                                "',cAddress= '" & Replace(Trim(txtAddress.Text), "'", "''") & _
                                "',cCompany= '" & Replace(Trim(txtCompany.Text), "'", "''") & _
                                "',dCust_EntryDate='" & strCustEntryDate & "',dLstOrdrDate= '" & strLastOrderDate & _
                                "',cCust_BillAdd='" & Replace(Trim(txtBillAddress.Text), "'", "''") & _
                                "',cEmail='" & Replace(Trim(txtEmail.Text), "'", "''") & _
                                "',cURL='" & Replace(Trim(txtURL.Text), "'", "''") & _
                                "',cCust_Fax='" & Replace(Trim(txtFaxNo.Text), "'", "''") & _
                                "',cCust_Mobile='" & Replace(Trim(txtMobile.Text), "'", "''") & _
                                "',cComment='" & Replace(Trim(txtComments.Text), "'", "''") & _
                                "',cDriverDirection= '" & Replace(Trim(txtDriverDic.Text), "'", "''") & _
                                "',cReview='" & Replace(Trim(txtReviews.Text), "'", "''") & _
                                "',cCardHolder= '" & Replace(Trim(txtCardHolder.Text), "'", "''") & _
                                "',cCardNo='" & Replace(Trim(txtCreditCard.Text), "'", "''") & _
                                "',nIssueNo=" & CStr(txtIssueNo.Text) & ",dValidfrom='" & strCardValidDate & _
                                "',dExpiryDate='" & strCardExpireDate & "',cCity='" & Replace(Trim(txtTown.Text), "'", "''") & _
                                "',nDriverNumber=" & CStr(Trim(cboDriverNumber.Text)) & ",cUserId= '" & user & _
                                "',cTermenal='" & sTerminal & "',dAccessTime=GETDATE()" & _
                                "WHERE nCust_Id=" + CStr(txtCustomerNo.Text) + ""

        dTotalPrice = GetTotalPrice()
        dDiscount = GetDiscount()
        dTips = GetTips()
        dNetPrice = GetNetpay()

        If Trim(txtCustomerNo.Text) = vbNullString Then
            strSQLInsertOrder_Payment = "INSERT INTO tOrder_Payment(nCust_Id,dOrder_date,nTable_Id,mTotalPrice,mDiscount" & _
                                         ",mService_Charge,mNetpay,nOrderStatus,cUserId,cTerminal,dAccessTime,perdiscount,perservice) " & _
                                         "SELECT MAX(tCust_Info.nCust_Id),GETDATE(),0," & CStr(dTotalPrice) & "," & CStr(dDiscount) & _
                                          "," & CStr(dTips) & "," & CStr(dNetPrice) & ",0,'" & user & "','" & sTerminal & _
                                          "',GETDATE(),'" & Trim(cboDiscount.Text) & "','" & Trim(cboTips.Text) & "' FROM tCust_Info"
        Else
            strSQLInsertOrder_Payment = "INSERT INTO tOrder_Payment(nCust_Id,dOrder_date,nTable_Id,mTotalPrice,mDiscount" & _
                                        ",mService_Charge,mNetpay,nOrderStatus,cUserId,cTerminal,dAccessTime,perdiscount,perservice) " & _
                                        "VALUES(" + Trim(txtCustomerNo.Text) + ",GETDATE(),0," + CStr(dTotalPrice) + _
                                        "," + CStr(dDiscount) + "," + CStr(dTips) + "," + CStr(dNetPrice) + _
                                        ",0,'" + user + "','" + sTerminal + "',GETDATE(),'" + Trim(cboDiscount.Text) + "','" + Trim(cboTips.Text) + "')"
        End If




        Try
            icountLVRow = lvOrder.Items.Count
            If icountLVRow > 0 Then

                cmdInsert = New SqlClient.SqlCommand
                cmdInsert.Connection = mdDBConnection.connRestuarant
                tnsAll_Quary = mdDBConnection.connRestuarant.BeginTransaction()
                blnTrans = True
                cmdInsert.Transaction = tnsAll_Quary

                If Trim(txtCustomerNo.Text) <> vbNullString Then
                    cmdInsert.CommandText = strSQLUpdateCust_Info
                Else
                    cmdInsert.CommandText = strSQLInsertCust_Info
                End If
                cmdInsert.ExecuteNonQuery()

                cmdInsert.CommandText = strSQLInsertOrder_Payment
                cmdInsert.ExecuteNonQuery()

                For iIndex = 0 To icountLVRow - 1
                    iQuantity = lvOrder.Items(iIndex).SubItems(1).Text          'To Get the item Quantity
                    dTotalPricePerItem = lvOrder.Items(iIndex).SubItems(3).Text 'To Get the Individual item Total Price
                    dUnitPrice = dTotalPricePerItem / iQuantity                 'To Get the Unit Price of a Item
                    sInstruction = lvOrder.Items(iIndex).SubItems(4).Text       'To Get the Item Instruction
                    iItemId = lvOrder.Items(iIndex).SubItems(5).Text            'To Get the ItemID
                    iQuantityInHand = lvOrder.Items(iIndex).SubItems(6).Text    'To Get the Current Stock of an Item

                    strSQLInsertOrder_Info = "INSERT INTO tOrdered_Item(nOrder_Id,nItem_Id,mUnitPrice " & _
                                             ",nItem_Qty,cInstruction ,cUserId,cTerminal,dAccessTime)" & _
                                             " SELECT MAX(tOrder_Payment.nOrder_Id)," & CStr(iItemId) & _
                                             "," & CStr(dUnitPrice) & "," & CStr(iQuantity) & _
                                             ",'" & sInstruction & "','" & user & "','" & sTerminal & _
                                             "',GETDATE() FROM tOrder_Payment"

                    cmdInsert.CommandText = strSQLInsertOrder_Info
                    cmdInsert.ExecuteNonQuery()

                    iCurrentStock = iQuantityInHand - iQuantity

                    'If iCurrentStock >= 0 Then [Commented for the Client's request]
                    strSQLUpdateStock_Info = "UPDATE tItem SET nItem_Stock=" & CStr(iCurrentStock) & _
                                             " WHERE nItem_Id=" & CStr(iItemId) & ""
                    cmdInsert.CommandText = strSQLUpdateStock_Info
                    cmdInsert.ExecuteNonQuery()
                    'End If
                Next
            Else
                MessageBox.Show("There is no Item For Order", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tabTakeaway.SelectedIndex = 1
            End If
            'txtName.Text = ""    'doubt
        Catch ex As Exception
            If blnTrans = True Then
                tnsAll_Quary.Rollback()
                blnTrans = False
                bPrint = False
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End If
        Finally
            If blnTrans = True Then
                'If MessageBox.Show("Do you want to submit the order.", "Takeaway", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                tnsAll_Quary.Commit()
                blnTrans = False
                bPrint = True
                If Trim(txtCustomerNo.Text) = vbNullString Then
                    txtCustomerNo.Text = GetCustomerID()
                End If
                txtCustomerNo.Tag = GetOrderId()
                'ShowTaskBarNotifire(strImageName, strTitel, strMessage, recTitleRectangle, recTextRectangle, pClosingPoint)
            End If
        End Try
    End Function

    Private Function GetCustomerID() As Integer
        Dim strSQL As String

        Dim iDataSetRow As Integer

        Dim iCustomerId As Integer
        Dim dsCustomerId As DataSet
        Dim daCustomerId As SqlClient.SqlDataAdapter

        strSQL = "SELECT MAX(nCust_Id) FROM tCust_Info"

        Try
            dsCustomerId = New DataSet("CustomerId")
            daCustomerId = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCustomerId.Fill(dsCustomerId, "CustomerId")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        If IsDBNull(dsCustomerId.Tables("CustomerId").Rows(0).Item(0)) = False Then
            iCustomerId = dsCustomerId.Tables("CustomerId").Rows(0).Item(0)
        End If
        GetCustomerID = iCustomerId
    End Function

    Private Function GetOrderId() As Integer
        Dim strSQL As String

        Dim iDataSetRow As Integer

        Dim iOrderId As Integer
        Dim dsOrderId As DataSet
        Dim daOrderId As SqlClient.SqlDataAdapter

        strSQL = "SELECT MAX(nOrder_Id) FROM tOrder_Payment"

        Try
            dsOrderId = New DataSet("OrderId")
            daOrderId = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daOrderId.Fill(dsOrderId, "OrderId")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        If IsDBNull(dsOrderId.Tables("OrderId").Rows(0).Item(0)) = False Then
            iOrderId = dsOrderId.Tables("OrderId").Rows(0).Item(0)
        End If
        GetOrderId = iOrderId
    End Function

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If btnSubmit.Text = "Update" Then
            Call UpdateOrder()
        ElseIf btnSubmit.Enabled = True Then
            SubmitOrder()
        End If

        ClearAllField()
        txtNetPay.Text = ""
        cboDiscount.SelectedIndex = -1
        iOrderId = 0

        Me.Dispose()
        Dim frmNew As New frmTakeaway
        frmNew.Show()

    End Sub

    Private Function GetTotalPrice() As Double
        If Trim(lblTotalOrderPrice.Text) <> vbNullString Then
            If Trim(lblTotalOrderPrice.Text) <> "." Then
                GetTotalPrice = Trim(lblTotalOrderPrice.Text)
            Else
                GetTotalPrice = 0
            End If
        Else
            GetTotalPrice = 0
        End If
    End Function

    Private Function GetDiscount() As Double
        If Trim(txtDiscount.Text) <> vbNullString Then
            If Trim(txtDiscount.Text) <> "." Then
                GetDiscount = Trim(txtDiscount.Text)
            Else
                GetDiscount = 0
            End If
        Else
            GetDiscount = 0
        End If
    End Function

    Private Function GetTips() As Double
        If Trim(txtTips.Text) <> vbNullString Then
            If Trim(txtTips.Text) <> "." Then
                GetTips = Trim(txtTips.Text)
            Else
                GetTips = 0
            End If
        Else
            GetTips = 0
        End If
    End Function

    Private Function GetNetpay() As Double
        If Trim(txtNetPay.Text) <> vbNullString Then
            If Trim(txtNetPay.Text) <> "." Then
                GetNetpay = Trim(txtNetPay.Text)
            Else
                GetNetpay = 0
            End If
        Else
            GetNetpay = 0
        End If
    End Function

    Private Function GetCashPayAmount() As Double

        If Trim(txtCashPay.Text) <> vbNullString Then
            If Trim(txtCashPay.Text) <> "." Then
                If txtCashPay.Text >= txtCardPay.Text And txtCashPay.Text >= txtChequePay.Text Then

                    GetCashPayAmount = Trim(txtCashPay.Text) - Trim(txtChange.Text)     ' new added Trim(txtChange.Text)
                Else

                    GetCashPayAmount = Trim(txtCashPay.Text)
                End If

            Else
                GetCashPayAmount = 0
            End If
        Else
            GetCashPayAmount = 0
        End If

    End Function

    Private Function GetCardPayAmount() As Double

        If Trim(txtCardPay.Text) <> vbNullString Then
            If Trim(txtCardPay.Text) <> "." Then
                If txtCardPay.Text > txtCashPay.Text And txtCardPay.Text >= txtChequePay.Text Then
                    GetCardPayAmount = Trim(txtCardPay.Text) - Trim(txtChange.Text) ' new added Trim(txtChange.Text)

                Else

                    GetCardPayAmount = Trim(txtCardPay.Text)
                End If
            Else
                GetCardPayAmount = 0
            End If
        Else
            GetCardPayAmount = 0
        End If

    End Function

    Private Function GetChequePayAmount() As Double

        If Trim(txtChequePay.Text) <> vbNullString Then
            If Trim(txtChequePay.Text) <> "." Then
                If txtChequePay.Text > txtCashPay.Text And txtChequePay.Text > txtCardPay.Text Then
                    GetChequePayAmount = Trim(txtChequePay.Text) - Trim(txtChange.Text) ' new added Trim(txtChange.Text)
                Else
                    GetChequePayAmount = Trim(txtChequePay.Text)
                End If

            Else
                GetChequePayAmount = 0
            End If
        Else
            GetChequePayAmount = 0
        End If

    End Function

    Public Function ClearAllField()
        clearInfo(gbBasicInfo)
        clearInfo(gbAdditionalInformation)
        clearInfo(gbPriceInformation)
        clearInfo(gbPaymentInformation)
        lvOrder.Items.Clear()
        txtCustomerNo.Text = "New Customer"
        txtNetPay.Text = ""
        txtChange.Text = ""
        lblTotalOrderPrice.Text = ""
        cboDiscount.Text = ""
        cboTips.Text = ""
        cboCardType.Text = ""
        txtDateOfEntry.Text = GetOrderDate().Date
        txtLastOrderDate.Text = GetOrderDate().Date
    End Function

    'Private Sub tbpgPayment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbpgPayment.Click
    '    Dim icountLVRow As Integer
    '    Dim iIndex As Integer
    '    Dim iQuantity As Integer

    '    Dim dUnitPrice As Double
    '    Dim dTotalPrice As Double

    '    icountLVRow = lvOrder.Items.Count
    '    If icountLVRow > 0 Then
    '        For iIndex = 0 To icountLVRow - 1
    '            iQuantity = lvOrder.Items(iIndex).Text
    '            dUnitPrice = lvOrder.Items(iIndex).SubItems(2).Text
    '            dTotalPrice += dUnitPrice * iQuantity
    '        Next
    '        txtTotalPrice.Text = dTotalPrice
    '    End If
    'End Sub

    Private Sub txtTips_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTips.TextChanged
        If Trim(txtTips.Text) <> vbNullString Then
            ValidationForNumaricData(txtTips)
            CalculateTips()
            CalculatePrice()
        End If
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        Dim strSQLCust_Info As String
        Dim strSQLOrder_Info As String
        Dim strSQLPayment_Info As String

        Dim iCountDataSetRow As Integer
        Dim strSQL As String
        Dim iCustomerId As Integer

        Dim dsTakeawayInfo As DataSet
        Dim daTakeawayInfo As SqlClient.SqlDataAdapter
        Dim objfrmPaymentStatus As New frmPaymentStatus

        ClearAllField()
        cboCardType.Text = ""
        cboTips.Text = ""
        lbQty.Text = ""
        btnPayBill.Enabled = True
        btnPay.Enabled = True
        btnwaitingCust.Enabled = True
        chkBoxWaitingCust.Checked = False
        Me.lvOrder.Columns(0).Width = 0
        Me.lvOrder.Columns(1).Width = 45

        strSQL = "SELECT P.nOrder_Id,P.dOrder_date,C.cCust_Name,C.cCust_BillAdd,P.mNetpay," & _
                 "P.nOrderStatus,P.cUserId,C.nCust_Id,P.mCashPayAmount,P.mCardPayAmount,P.mChequeAmount,P.nTable_Id,P.nOrderStatus FROM tOrder_Payment P,tCust_Info C " & _
                 "WHERE P.nCust_Id=C.nCust_Id AND P.nOrderStatus=0 AND P.nTable_Id=0"
        Try
            dsTakeawayInfo = New DataSet("TakeawayInfo")
            daTakeawayInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daTakeawayInfo.Fill(dsTakeawayInfo, "TakeawayInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsTakeawayInfo.Tables("TakeawayInfo").Rows.Count

        If iCountDataSetRow > 0 Then
            objfrmPaymentStatus.pnlPassword.Visible = False
            objfrmPaymentStatus.btnLookUpOk.Visible = True
            objfrmPaymentStatus.btnCancel.Visible = True
            objfrmPaymentStatus.FillPaymentStatus(dsTakeawayInfo)
            objfrmPaymentStatus.ShowDialog()

            If strfindcode <> vbNullString Then
                iCustomerId = strfindDesc
                iOrderId = strfindcode

                strSQLCust_Info = "SELECT nCust_Id,cCust_Name,cPhnNo,cPostCode,cAddress,cCompany,dCust_EntryDate," & _
                                  "dLstOrdrDate,cCust_BillAdd,cEmail,cURL,cCust_Fax,cCust_Mobile,cComment," & _
                                  "cDriverDirection,cReview,cCardHolder,cCardNo,nIssueNo,dValidfrom,dExpiryDate,cCity,nDriverNumber" & _
                                  " FROM tCust_Info WHERE nCust_Id=" + CStr(iCustomerId) + ""

                txtCustomerNo.Tag = iOrderId

                PutDataIntoCustomerInfo(strSQLCust_Info)

                strSQLOrder_Info = "SELECT O.nItem_Qty,I.cItem_SC,I.mTakeawayPrice,O.cInstruction,O.nItem_Id," & _
                                   "I.nItem_Stock,I.cItem_ServeLoc,T.cType_Name FROM tOrdered_Item O,tItem I, tType T " & _
                                   "WHERE O.nOrder_Id=" + CStr(iOrderId) + " AND O.nItem_Id=I.nItem_Id AND" & _
                                   " I.nType_Id=T.nType_Id ORDER BY O.nItem_Id"

                PutDataIntoOrderInfo(strSQLOrder_Info)

                strSQLPayment_Info = "SELECT mTotalPrice,mDiscount,mService_Charge,mNetpay,mCashPayAmount," & _
                                     "mCardPayAmount,cCardType,mChequeAmount,cChequeNumber,cBankName,perdiscount,perservice " & _
                                     "FROM tOrder_Payment WHERE nOrder_Id=" + CStr(iOrderId) + ""
                PutDataIntoPaymentInfo(strSQLPayment_Info)
                btnSubmit.Text = "Update"
                If txtPhoneNumber.Text = vbNullString Then
                    btnwaitingCust.Enabled = False
                    chkBoxWaitingCust.Checked = True
                    SetEnablePropertyFalse(gbBasicInfo)
                    SetEnablePropertyFalse(gbAdditionalInformation)
                End If

                Call CalculateTotalPrice()
                Call CalculatePrice()
                Call calculatetotalItem()
                chkReprintWAY.Enabled = True
                If chkReprintWAY.Checked = True Then
                    chkReprintWAY.Checked = False
                End If

                Me.tabTakeaway.SelectedIndex = 2
            End If

            strfindcode = vbNullString
        Else
            MessageBox.Show("There is no Due payment to show", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function IsCustomerExist(ByVal tmpCustomerInfo As String) As Boolean
        Dim bCustomerExist As Boolean
        Dim iCountDataSetRow As Integer
        Dim dsCustomerInfo As DataSet
        Dim daCustomerInfo As SqlClient.SqlDataAdapter

        Try
            dsCustomerInfo = New DataSet("CustomerInfo")
            daCustomerInfo = New SqlClient.SqlDataAdapter(tmpCustomerInfo, mdDBConnection.connRestuarant)
            daCustomerInfo.Fill(dsCustomerInfo, "CustomerInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsCustomerInfo.Tables("CustomerInfo").Rows.Count
        If iCountDataSetRow > 0 Then
            bCustomerExist = True
        Else
            bCustomerExist = False
        End If
        IsCustomerExist = bCustomerExist
    End Function

    Private Function SearchCustomer()
        Dim strSQLCustInfo As String

        If Len(Trim(txtPhoneNumber.Text)) > 0 And Len(Trim(txtPostCode.Text)) <= 0 Then

            strSQLCustInfo = "SELECT nCust_Id,cCust_Name,cPhnNo,cPostCode,cAddress,cCompany,dCust_EntryDate," & _
                             "dLstOrdrDate,cCust_BillAdd,cEmail,cURL,cCust_Fax,cCust_Mobile,cComment," & _
                             "cDriverDirection,cReview,cCardHolder,cCardNo,nIssueNo,dValidfrom,dExpiryDate,cCity,nDriverNumber" & _
                             " FROM tCust_Info WHERE cPhnNo='" & Trim(txtPhoneNumber.Text) & "'"
            If IsCustomerExist(strSQLCustInfo) = False Then
                If MessageBox.Show("There is no customer to show.Do you want to add?", "Takeaway", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    txtPostCode.Focus()
                Else
                    Exit Function
                End If
            Else
                PutDataIntoCustomerInfo(strSQLCustInfo)
            End If
        Else
            Exit Function
        End If
    End Function

    Private Sub btnCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollection.Click
        SearchCustomer()   'this is close for collection and changed btnSearch to btnCollection
        btnCollection.Enabled = False
        If chkBoxCollection.Checked = False Then
            chkBoxCollection.Checked = True
            SetEnablePropertyFalse(gbBasicInfo) 'Should be change
            'txtCustomerNo.Enabled = False.
            txtPhoneNumber.Enabled = True
            txtName.Enabled = True
            txtName.Focus()
            SetEnablePropertyFalse(gbAdditionalInformation)
            cboDriverNumber.Enabled = False
            If Trim(mdConfiguration.strResturantName) = vbNullString Then
                stxtMain.ScrollText = "UySys eRestuarant " & ": Takeaway" & "-Collection"
            Else
                stxtMain.ScrollText = mdConfiguration.strResturantName & ": Takeaway" & "-Collection"
            End If
        Else
            Me.Dispose()
            Dim frmNew As New frmTakeaway
            frmNew.Show()
        End If

    End Sub

    Private Function PutDataIntoOrderInfo(ByVal tmpOrderInfo As String)
        Dim iCountDataSetRow As Integer
        Dim iIndex As Integer
        Dim iItemQuantity As Integer

        Dim dUnitPrice As Double
        Dim dTotalPrice As Double

        Dim dsOrderInfo As DataSet
        Dim daOrderInfo As SqlClient.SqlDataAdapter

        Try
            dsOrderInfo = New DataSet("OrderInfo")
            daOrderInfo = New SqlClient.SqlDataAdapter(tmpOrderInfo, mdDBConnection.connRestuarant)
            daOrderInfo.Fill(dsOrderInfo, "OrderInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsOrderInfo.Tables("OrderInfo").Rows.Count

        lvOrder.Items.Clear()

        If iCountDataSetRow > 0 Then
            lvOrder.CheckBoxes = True
            For iIndex = 0 To iCountDataSetRow - 1
                lvOrder.Items.Add(" ")
                lvOrder.Items(iIndex).SubItems.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(0)) 'For add Item Qty In Ordered Item ListView
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(1))) 'For add Item Name In Ordered Item ListView
                iItemQuantity = CInt(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(0)))
                dUnitPrice = CDbl(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(2)))
                dTotalPrice = iItemQuantity * dUnitPrice 'For Calculating Item Total price For a specific Item In Ordered Item ListView
                lvOrder.Items(iIndex).SubItems.Add(FormatCurrency(dTotalPrice)) 'For adding Item Total price For a specific Item In Ordered Item ListView

                If dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(3) <> vbNullString Then 'For adding Instruction For a specific Item In Ordered Item ListView
                    lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(3)))
                Else
                    lvOrder.Items(iIndex).SubItems.Add("")
                End If
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(4))) 'For adding Item Id In Ordered Item ListView 
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(5))) 'For adding Item Quantity In Hand In Ordered Item ListView
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(6))) 'For adding Item Serve Location
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(7))) 'For adding Type Name
                'lvOrder.Items(iIndex).Checked = False
                lvOrder.Items(iIndex).SubItems.Add(iItemQuantity)  'added for only new QTY PRINT
            Next
            Me.lvOrder.Columns(0).Width = 30
            Me.lvOrder.Columns(1).Width = 30
        Else
            MessageBox.Show("There is no Order information against this order", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dsOrderInfo = Nothing
        daOrderInfo = Nothing
    End Function

    Private Function PutDataIntoPaymentInfo(ByVal tmpOrderPayment As String)

        Dim dDiscount As Double
        Dim dTips As Double
        Dim dTotalPrice As Double
        Dim CbodDiscount As Double
        Dim CbodTips As Double

        Dim iCountDataSetRow As Integer

        Dim dsPaymentInfo As DataSet
        Dim daPaymentInfo As SqlClient.SqlDataAdapter

        Try
            dsPaymentInfo = New DataSet("PaymentInfo")
            daPaymentInfo = New SqlClient.SqlDataAdapter(tmpOrderPayment, mdDBConnection.connRestuarant)
            daPaymentInfo.Fill(dsPaymentInfo, "PaymentInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsPaymentInfo.Tables("PaymentInfo").Rows.Count

        If iCountDataSetRow > 0 Then
            txtTotalPrice.Text = FormatCurrency(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(0)) & vbNullString

            dDiscount = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(1) & vbNullString
            'dDiscount = Val(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(1))
            If dDiscount > 0 Then
                txtDiscount.Text = FormatCurrency(dDiscount)
            End If


            dTips = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(2) & vbNullString
            If dTips > 0 Then
                txtTips.Text = FormatCurrency(dTips)
            End If


            dTotalPrice = txtTotalPrice.Text
            '''''''''''''''''''''''''''''''''' off this block for discount (milton-25.08.07)

            'If dTotalPrice <> 0 Then
            '    dDiscount = (dDiscount * 100) / dTotalPrice
            'Else
            '    dDiscount = 0
            '    'dDiscount = (dDiscount * 100) / dTotalPrice
            'End If
            'cboDiscount.Text = Format(dDiscount, "##.##")

            '''''''''''''''''''''''''''''''''''''''''''''''

            txtNetPay.Text = FormatCurrency(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(3))

            If IsDBNull(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(4)) = False Then
                txtCashPay.Text = FormatCurrency(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(4))
            End If

            If IsDBNull(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(5)) = False Then
                txtCardPay.Text = FormatCurrency(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(5))
            End If

            If IsDBNull(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(6)) = False Then
                cboCardType.Text = Trim(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(6))
            End If

            If IsDBNull(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(7)) = False Then
                txtChequePay.Text = FormatCurrency(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(7))
            End If

            If IsDBNull(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(8)) = False Then
                txtChequeNo.Text = Trim(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(8))
            End If

            If IsDBNull(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(9)) = False Then
                txtBankName.Text = Trim(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(9))
            End If

            If IsDBNull(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(10)) = False Then
                'cboDiscount.Text = Trim(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(10))
                CbodDiscount = Trim(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(10))
                If CbodDiscount > 0 Then
                    cboDiscount.Text = CbodDiscount
                End If
            End If

            If IsDBNull(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(11)) = False Then
                'cboTips.Text = Trim(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(11))
                CbodTips = Trim(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(11))
                If CbodTips > 0 Then
                    cboTips.Text = CbodTips
                End If

            End If

        Else
            MessageBox.Show("There is no Payment information against this order", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'ClearTextProperty(gbPaymentInformation)
        ' cboCardType.SelectedIndex = -1
        dsPaymentInfo = Nothing
        daPaymentInfo = Nothing
    End Function

    Private Sub lvOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvOrder.Click
        Dim strSQL As String
        Dim sInstructionId As String
        Dim sInstruction As String
        Dim sItemName As String
        Dim strQty As String
        Dim icount As Integer 'For count the number of rows in Category Dataset 
        Dim iIndex As Integer
        Dim iItemId As Integer
        Dim iItemStock As Integer
        Dim iCurrentItemQty As Integer

        Dim dTotalPrice As Double
        Dim dUnitPrice As Double

        Dim dsInstraction As DataSet
        Dim daInstraction As SqlClient.SqlDataAdapter

        If lvOrder.SelectedItems.Count = 0 Then


        Else
            strQty = lvOrder.SelectedItems(0).SubItems(1).Text
            iCurrentItemQty = CInt(strQty)
            dTotalPrice = Decimal.Parse(Trim(lvOrder.SelectedItems(0).SubItems(3).Text), NumberStyles.Currency)
            dUnitPrice = dTotalPrice / iCurrentItemQty

            iItemId = lvOrder.SelectedItems(0).SubItems(5).Text
            iItemStock = lvOrder.SelectedItems(0).SubItems(6).Text

            PutDataIntoGridFromCombo(iItemStock, iCurrentItemQty, dUnitPrice)

            strSQL = "SELECT I.nInstruction_Id,I.cInstruction,D.cItem_Name FROM tInstruction I," & _
                     "tItem D WHERE I.nItem_Id=D.nItem_Id AND I.nItem_Id=" + CStr(iItemId) + ""

            Try
                dsInstraction = New DataSet("Instruction")
                daInstraction = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                daInstraction.Fill(dsInstraction, "Instruction")
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try

            cboInstruction.DataSource = Nothing
            cboInstruction.Items.Clear()
            icount = dsInstraction.Tables("Instruction").Rows.Count

            If icount > 1 Then
                cboInstruction.DataSource = dsInstraction.Tables("Instruction")
                cboInstruction.DisplayMember = "cInstruction"
            Else
                FillInstructionCombo()
            End If

            dsInstraction = Nothing
            daInstraction = Nothing
        End If
    End Sub

    Private Function PutDataIntoGridFromCombo(ByVal tmpItemStock As Integer, _
                                              ByVal tmpCurrentQty As Integer, ByVal tmpUnitPrice As Double)

        Dim dTotalPrice As Double
        Dim strImageName As String = "skin.bmp"
        Dim strTitel As String = "Item Stock Information."
        Dim strMessage As String = "Your Selected Item is in Reorder Label." & vbCrLf & "Please Update the Stock."
        Dim recTitleRectangle As New Rectangle(110, 65, 200, 28)
        Dim recTextRectangle As New Rectangle(90, 92, 200, 55)
        Dim pClosingPoint As New Point(280, 69)

        If Trim(cboInstruction.Text) <> vbNullString Then
            If IsNumeric(Trim(cboInstruction.Text)) = True Then
                Dim cbovalue As Integer
                Dim listvalue As Integer
                Dim total As Integer
                cbovalue = Trim(cboInstruction.Text)
                listvalue = lvOrder.SelectedItems(0).SubItems(1).Text
                total = cbovalue + listvalue
                lvOrder.SelectedItems(0).SubItems(1).Text = total
                'If (tmpItemStock - CInt(Trim(cboInstruction.Text))) <= 4 And tmpCurrentQty <> CInt(Trim(cboInstruction.Text)) Then
                'ShowTaskBarNotifire(strImageName, strTitel, strMessage, recTitleRectangle, recTextRectangle, pClosingPoint)
                dTotalPrice = tmpUnitPrice * CInt(lvOrder.SelectedItems(0).SubItems(1).Text)
                lvOrder.SelectedItems(0).SubItems(3).Text = FormatCurrency(dTotalPrice)
                If lvOrder.CheckBoxes = True Then
                    lvOrder.SelectedItems(0).Checked = True
                End If
                Call CalculateTotalPrice()
                Call calculatetotalItem()
                'End If
            Else
                lvOrder.SelectedItems(0).SubItems(4).Text = Trim(cboInstruction.Text)
                If lvOrder.CheckBoxes = True Then
                    lvOrder.SelectedItems(0).Checked = True
                End If
            End If
        End If
    End Function

    Private Sub btnKitchPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKitchPrint.Click
        'If chkBoxWaitingCust.Checked = False Then
        '    '    If Len(Trim(txtPhoneNumber.Text)) <= 0 Then
        '    '        MessageBox.Show("Please insert Customer phone number", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    '        Exit Sub
        '    '    ElseIf Len(Trim(txtPostCode.Text)) <= 0 Then
        '    '        MessageBox.Show("Please insert Post Code.", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    '        Exit Sub
        '    '    ElseIf lvOrder.Items.Count = 0 Then
        '    '        MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    '        Exit Sub
        '    '    Else
        '    '        If btnSubmit.Enabled = True Then
        '    '            SubmitOrder()
        '    '            If bPrint = True Then
        '    '                showOredInfo()
        '    '                PrintOrder()
        '    '            End If
        '    '        Else
        '    '            PrintOrder()
        '    '        End If
        '    '    End If
        '    'Else
        '    If lvOrder.Items.Count = 0 Then
        '        MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    ElseIf chkBoxCollection.Checked = False Then
        Me.lvOrder.Sorting = SortOrder.Ascending

        If lvOrder.Items.Count = 0 Then
            MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "eRestaurant", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            btnKitchPrint.Enabled = False
            If lvOrder.CheckBoxes = True Then          'btnSubmit.Text = "Update" Then  "for new button in london on 1.02.08
                Me.tabTakeaway.SelectedIndex = 2
                UpdateOrder()
                If bPrint = True Then                    'previously TRUE
                    PrintOrder()
                End If
            ElseIf lvOrder.CheckBoxes = False Then     'btnSubmit.Text = "Submit" Then   "for new button in london on 1.02.08"
                Me.tabTakeaway.SelectedIndex = 2
                SubmitOrder()
                If bPrint = True Then
                    'showOredInfo()
                    PrintOrder()
                    btnSubmit.Text = "Update"
                End If
            Else
                PrintOrder()
            End If
        End If
        ' End If
        '  End If
        Me.Dispose()
        Dim frmNew As New frmTakeaway
        frmNew.Show()
    End Sub

    Private Sub tabTakeaway_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabTakeaway.SelectedIndexChanged
        Dim strTotalPrice As Double

        If Me.tabTakeaway.SelectedIndex = 2 Then
            Dim i As Integer
            For i = 1 To Me.lvOrder.Items.Count
                strTotalPrice = strTotalPrice + CDbl(Me.lvOrder.Items(i - 1).SubItems(3).Text)
            Next
        Else
            Me.txtTotalPrice.Clear()
        End If

        Me.txtTotalPrice.Text = FormatCurrency(strTotalPrice, , , TriState.True, TriState.True)

        If txtNetPay.Text = vbNullString Then
            Me.txtNetPay.Text = Me.txtTotalPrice.Text
        End If
        If Trim(txtCardPay.Text) = "" Then
            cboCardType.SelectedIndex = -1
        End If
    End Sub

    Private Sub txtCashPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashPay.TextChanged
        If Trim(txtCashPay.Text) <> vbNullString Then
            ValidationForNumaricData(txtCashPay)
        End If
        CalculateChangre()
    End Sub

    Private Sub txtChequePay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequePay.TextChanged
        If Trim(txtChequePay.Text) <> vbNullString Then
            ValidationForNumaricData(txtChequePay)
        End If
        CalculateChangre()
    End Sub

    Private Sub txtCardPay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCardPay.TextChanged
        If Trim(txtCardPay.Text) <> vbNullString Then
            ValidationForNumaricData(txtCardPay)
        End If
        CalculateChangre()
    End Sub

    Private Function CalculateChangre()
        Dim dCash As Double
        Dim dCard As Double
        Dim dCheque As Double
        Dim dNetPay As Double
        Dim dResult As Double

        If Trim(txtTotalPrice.Text) <> vbNullString Then
            If Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency) = 0.0 Then
                txtCardPay.Text = ""
                txtChequePay.Text = ""
                txtCashPay.Text = ""
                Exit Function
            End If
        End If

        If Trim(txtCashPay.Text) <> vbNullString Then
            If Trim(txtCashPay.Text) <> "." Then
                dCash = CDbl(txtCashPay.Text)
            Else
                dCash = 0
            End If
        Else
            dCash = 0
        End If

        If Trim(txtCardPay.Text) <> vbNullString Then
            If Trim(txtCardPay.Text) <> "." Then
                dCard = CDbl(txtCardPay.Text)
            Else
                dCard = 0
            End If
        Else
            dCard = 0
        End If

        If Trim(txtChequePay.Text) <> vbNullString Then
            If Trim(txtChequePay.Text) <> "." Then
                dCheque = CDbl(txtChequePay.Text)
            Else
                dCheque = 0
            End If
        Else
            dCheque = 0
        End If

        If Trim(txtNetPay.Text) <> vbNullString Then
            If Trim(txtNetPay.Text) <> "." Then
                dNetPay = CDbl(txtNetPay.Text)
            Else
                dNetPay = 0
            End If
        Else
            dNetPay = 0
        End If

        dResult = (dCash + dCard + dCheque) - dNetPay
        txtChange.Text = FormatCurrency(dResult, , , TriState.True, TriState.True)
    End Function

    Private Sub btCanceOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCanceOrder.Click
        'Me.Dispose()
        'Dim frmNew As New frmTakeaway
        'frmNew.Show()
        Me.lvOrder.Sorting = SortOrder.Ascending
        If btnPayBill.Enabled = False Then
            Me.Dispose()
            Dim frmNew As New frmTakeaway
            frmNew.Show()
        ElseIf btnPay.Enabled = False Then
            Me.Dispose()
            Dim frmNew As New frmTakeaway
            frmNew.Show()
        ElseIf lvOrder.Items.Count = 0 Then
            Me.Dispose()
            Dim frmNew As New frmTakeaway
            frmNew.Show()
        ElseIf lvOrder.CheckBoxes = False Then
            Me.tabTakeaway.SelectedIndex = 2
            SubmitOrder()
            Me.Dispose()
            Dim frmNew As New frmTakeaway
            frmNew.Show()
        ElseIf lvOrder.CheckBoxes = True Then
            Me.tabTakeaway.SelectedIndex = 2
            UpdateOrder()
            Me.Dispose()
            Dim frmNew As New frmTakeaway
            frmNew.Show()
        End If
    End Sub

    Private Function PutDriverInfo(ByVal tmpDriverNumber As String)

        Dim iDriverNumber As Integer
        Dim iRowCount As Integer
        Dim strSQL As String
        Dim dsDriverInfo As DataSet
        Dim daDriverInfo As SqlClient.SqlDataAdapter

        iDriverNumber = CInt(tmpDriverNumber)

        strSQL = "SELECT cEmployeeName FROM tEmployee WHERE nEmployeeId=" & CStr(iDriverNumber) & ""

        Try
            dsDriverInfo = New DataSet("Driver")
            daDriverInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daDriverInfo.Fill(dsDriverInfo, "Driver")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iRowCount = dsDriverInfo.Tables("Driver").Rows.Count

        If iRowCount > 0 Then
            cboDriverNumber.Text = iDriverNumber
            txtDriverName.Text = dsDriverInfo.Tables("Driver").Rows(0).Item(0)
        Else
            cboDriverNumber.Text = vbNullString
        End If
    End Function

    Private Function PutDataIntoCustomerInfo(ByVal tmpCustomerInfo As String)


        Dim strDriverNumber As String
        Dim iCountDataSetRow As Integer
        Dim dValidDate As Date
        Dim dExpireDate As Date

        Dim dsCustomerInfo As DataSet
        Dim daCustomerInfo As SqlClient.SqlDataAdapter

        Try
            dsCustomerInfo = New DataSet("CustomerInfo")
            daCustomerInfo = New SqlClient.SqlDataAdapter(tmpCustomerInfo, mdDBConnection.connRestuarant)
            daCustomerInfo.Fill(dsCustomerInfo, "CustomerInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsCustomerInfo.Tables("CustomerInfo").Rows.Count
        If iCountDataSetRow > 0 Then
            txtCustomerNo.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(0) & vbNullString
            txtName.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(1) & vbNullString   'new add
            If chkBoxWaitingCust.Checked = True Then
                If InStr(Trim(dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(1)), txtName.Text, CompareMethod.Binary) = 1 Then
                    'txtName.Text = ""
                    If Trim(mdConfiguration.strResturantName) = vbNullString Then
                        stxtMain.ScrollText = "UySys eRestuarant " & ": Takeaway" & "-Waiting Customer"
                    Else
                        stxtMain.ScrollText = mdConfiguration.strResturantName & ": Takeaway" & "-Waiting Customer"
                    End If
                End If

            Else
                'txtName.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(1) & vbNullString
                chkBoxWaitingCust.Checked = False
                If Trim(mdConfiguration.strResturantName) = vbNullString Then
                    stxtMain.ScrollText = "UySys eRestuarant " & ": Takeaway"
                Else
                    stxtMain.ScrollText = mdConfiguration.strResturantName & ": Takeaway"
                End If
            End If
            txtPhoneNumber.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(2) & vbNullString
            txtPostCode.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(3) & vbNullString
            txtAddress.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(4) & vbNullString
            txtCompany.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(5) & vbNullString
            txtDateOfEntry.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(6) & vbNullString
            txtLastOrderDate.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(7) & vbNullString
            txtBillAddress.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(8) & vbNullString
            txtEmail.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(9) & vbNullString
            txtURL.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(10) & vbNullString
            txtFaxNo.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(11) & vbNullString
            txtMobile.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(12) & vbNullString
            txtComments.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(13) & vbNullString
            txtDriverDic.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(14) & vbNullString
            txtReviews.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(15) & vbNullString
            txtCardHolder.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(16) & vbNullString
            txtCreditCard.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(17) & vbNullString

            If IsDBNull(dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(18)) = True Then
                txtIssueNo.Text = vbNullString
            Else
                If dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(18) = "0" Then
                    txtIssueNo.Text = vbNullString
                Else
                    txtIssueNo.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(18) & vbNullString
                End If
            End If

            If IsDBNull(dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(19)) = True Then
                txtValidFrom.Text = ""
            Else
                dValidDate = DateTime.Parse(Trim(dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(19))).ToString("dd/MM/yyyy")
                Dim strTempDate As String
                If dValidDate <> "1/1/1900" Then
                    strTempDate = dValidDate
                    txtValidFrom.Text = strTempDate.Remove(0, 3)
                Else
                    txtValidFrom.Text = ""
                End If
            End If

            If IsDBNull(dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(20)) = True Then
                txtExpiryDate.Text = ""
            Else
                dExpireDate = DateTime.Parse(Trim(dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(20))).ToString("dd/MM/yyyy")
                Dim strTempDate As String
                If dExpireDate <> "1/1/1900" Then
                    strTempDate = dExpireDate
                    txtExpiryDate.Text = strTempDate.Remove(0, 3)
                Else
                    txtExpiryDate.Text = ""
                End If
            End If
            txtTown.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(21) & vbNullString
            If IsDBNull(dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(22)) = True Then
                strDriverNumber = vbNullString
            Else
                If dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(22) = "0" Then
                    strDriverNumber = vbNullString
                Else
                    strDriverNumber = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(22) & vbNullString
                    If strDriverNumber <> vbNullString Then
                        PutDriverInfo(strDriverNumber)
                    End If
                End If
            End If
        Else
            MessageBox.Show("There is no customer to show.", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dsCustomerInfo = Nothing
        daCustomerInfo = Nothing
    End Function

    Private Function showOredInfo()

        Dim strSQLCust_Info As String
        Dim strSQLOrder_Info As String
        Dim strSQLPayment_Info As String

        strSQLCust_Info = "SELECT nCust_Id,cCust_Name,cPhnNo,cPostCode,cAddress,cCompany,dCust_EntryDate," & _
                          "dLstOrdrDate,cCust_BillAdd,cEmail,cURL,cCust_Fax,cCust_Mobile,cComment," & _
                          "cDriverDirection,cReview,cCardHolder,cCardNo,nIssueNo,dValidfrom,dExpiryDate,cCity,nDriverNumber" & _
                          " FROM tCust_Info WHERE nCust_Id=" + CStr(Trim(txtCustomerNo.Text)) + ""

        PutDataIntoCustomerInfo(strSQLCust_Info)

        strSQLOrder_Info = "SELECT O.nItem_Qty,I.cItem_SC,I.mTakeawayPrice,O.cInstruction,O.nItem_Id," & _
                           "I.nItem_Stock,I.cItem_ServeLoc,T.cType_Name FROM tOrdered_Item O,tItem I,tType T " & _
                           "WHERE O.nOrder_Id=" + CStr(Trim(txtCustomerNo.Tag)) + " AND O.nItem_Id=I.nItem_Id AND " & _
                           "I.nType_Id=T.nType_Id ORDER BY O.nItem_Id"

        PutDataIntoOrderInfo(strSQLOrder_Info)
        strSQLPayment_Info = "SELECT mTotalPrice,mDiscount,mService_Charge,mNetpay,mCashPayAmount,mCardPayAmount," & _
                             "cCardType,mChequeAmount,cChequeNumber,cBankName,perdiscount,perservice FROM tOrder_Payment " & _
                             "WHERE nOrder_Id=" + CStr(Trim(txtCustomerNo.Tag)) + ""

        PutDataIntoPaymentInfo(strSQLPayment_Info)
        ' btnSubmit.Enabled = False
        Call CalculateTotalPrice()
        Call calculatetotalItem()
        Call CalculatePrice()
    End Function

    Private Sub btBillPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBillPrint.Click
        Me.lvOrder.Sorting = SortOrder.Ascending

        If lvOrder.Items.Count = 0 Then
            MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "eRestaurant", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            btBillPrint.Enabled = False
            If lvOrder.CheckBoxes = True Then         'btnSubmit.Text = "Update" Then "for new button in london on 1.02.08
                Call UpdateOrder()
                If bPrint = True Then
                    PrintBill()
                End If
            ElseIf lvOrder.CheckBoxes = False Then   'btnSubmit.Text = "Submit" Then "for new button in london on 1.02.08
                SubmitOrder()
                If bPrint = True Then
                    'showOredInfo()
                    PrintBill()
                    btnSubmit.Text = "Update"
                End If
            Else
                PrintBill()
            End If
        End If
        'End If
        ' End If
        Me.Dispose()
        Dim frmNew As New frmTakeaway
        frmNew.Show()
    End Sub
    'EnablePaymentButton
    Private Function EnablePaymentButton()
        If Trim(txtNetPay.Text) <> vbNullString Then
            If Decimal.Parse(Trim(txtNetPay.Text), NumberStyles.Currency) > 0.0 Then
                If Trim(txtChange.Text) <> vbNullString Then
                    If Decimal.Parse(Trim(txtChange.Text), NumberStyles.Currency) >= 0.0 Then
                        btnPay.Enabled = True
                        btnPayBill.Enabled = True

                    Else
                        btnPay.Enabled = False
                        btnPayBill.Enabled = False

                    End If
                End If
            End If
        End If
    End Function

    Private Function UpdateOrderStatus()

        Dim strSQLUpdate As String
        Dim strSQL As String
        Dim dTotalPrice As Double
        Dim dDiscount As Double
        Dim dTips As Double
        Dim dNetPrice As Double
        Dim dCashPay As Double
        Dim dCardPay As Double
        Dim dCheque As Double

        Dim cmdUpdateStatus As SqlClient.SqlCommand

        dTotalPrice = GetTotalPrice()
        dDiscount = GetDiscount()
        dTips = GetTips()
        dNetPrice = GetNetpay()
        dCashPay = GetCashPayAmount()
        dCardPay = GetCardPayAmount()
        dCheque = GetChequePayAmount()

        Try
            strSQL = "UPDATE tOrder_Payment SET nOrderStatus=1, mDiscount=" + CStr(dDiscount) + ",mService_Charge=" + _
                     CStr(dTips) + ",mNetpay=" + CStr(dNetPrice) + ",mCashPayAmount=" + CStr(dCashPay) + _
                     ",mCardPayAmount=" + CStr(dCardPay) + ",cCardType='" + Trim(cboCardType.Text) + _
                     "',mChequeAmount=" + CStr(dCheque) + ",cChequeNumber='" + Replace(Trim(txtChequeNo.Text), "'", "''") + "',cBankName='" + _
                     Replace(Trim(txtBankName.Text), "'", "''") + "',cUserId='" + user + "',cTerminal='" + sTerminal + _
                     "',dAccessTime=GETDATE() WHERE nOrder_Id=" + CStr(Trim(txtCustomerNo.Tag)) + ""
            cmdUpdateStatus = New SqlClient.SqlCommand
            cmdUpdateStatus.Connection = mdDBConnection.connRestuarant
            cmdUpdateStatus.CommandText = strSQL
            cmdUpdateStatus.ExecuteNonQuery()
            btnSubmit.Enabled = True
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        cmdUpdateStatus = Nothing
        txtCustomerNo.Tag = ""
    End Function

    Private Sub btnPayBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayBill.Click
        'If txtCardPay.Text <> vbNullString And cboCardType.Text = vbNullString Then
        '    MsgBox("Plz select card type", MsgBoxStyle.Information)
        '    cboCardType.Focus()
        'Else
        Me.lvOrder.Sorting = SortOrder.Ascending

        If txtCardPay.Text = vbNullString And txtCashPay.Text = vbNullString And txtChequePay.Text = vbNullString Then
            MsgBox("Plz Put Net Pay Amount", MsgBoxStyle.Information)
        Else
            btnKitchPrint.Enabled = False
            btnAllPrint.Enabled = False
            btBillPrint.Enabled = False
            btnLevelPrint.Enabled = False
            btnPayBill.Enabled = False
            If btnPay.Enabled = False Then
                MsgBox("This Order Already Paid", MsgBoxStyle.Information)
                Exit Sub
            End If
            If lvOrder.CheckBoxes = True Then      'btnSubmit.Text = "Update" Then "for new button in london on 1.02.08
                UpdateOrder()
                If bPrint = True Then
                    UpdateOrderStatus()
                    OpenCashDrawer()
                End If
            ElseIf lvOrder.CheckBoxes = False Then  'btnSubmit.Text = "Submit" Then "for new button in london on 1.02.08
                SubmitOrder()
                If bPrint = True Then
                    ' showOredInfo()
                    UpdateOrderStatus()
                    OpenCashDrawer()
                End If
            Else
                UpdateOrderStatus()
                OpenCashDrawer()
            End If
        End If
        'End If
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        'If txtCardPay.Text <> vbNullString And cboCardType.Text = vbNullString Then
        '    MsgBox("Plz select card type", MsgBoxStyle.Information)
        '    cboCardType.Focus()
        'Else
        Me.lvOrder.Sorting = SortOrder.Ascending

        If txtCardPay.Text = vbNullString And txtCashPay.Text = vbNullString And txtChequePay.Text = vbNullString Then
            MsgBox("Plz Put Net Pay Amount", MsgBoxStyle.Information)
        Else
            btnKitchPrint.Enabled = False
            btnAllPrint.Enabled = False
            btBillPrint.Enabled = False
            btnLevelPrint.Enabled = False
            btnPay.Enabled = False
            If btnPayBill.Enabled = False Then
                PrintBill()
                Exit Sub
            End If
            If lvOrder.CheckBoxes = True Then    'btnSubmit.Text = "Update" Then "for new button in london on 1.02.08
                UpdateOrder()
                If bPrint = True Then
                    UpdateOrderStatus()
                    OpenCashDrawer()
                    PrintBill()
                    btnPayBill.Enabled = False
                End If
            ElseIf lvOrder.CheckBoxes = False Then   'btnSubmit.Text = "Submit" Then "for new button in london on 1.02.08
                SubmitOrder()
                If bPrint = True Then
                    'showOredInfo()
                    UpdateOrderStatus()
                    PrintBill()
                    OpenCashDrawer()
                    btnPayBill.Enabled = False
                End If
            Else
                UpdateOrderStatus()
                PrintBill()
                OpenCashDrawer()
                btnPayBill.Enabled = False
            End If
        End If
        ' End If
    End Sub

    Private Function IsStarterType(ByVal strStarter As String) As Boolean
        Dim iIndex As Integer

        Dim blnStarter As Boolean = False

        Dim strTypeStarter As String
        Dim tmpTypeNamePrefix As String
        Dim strTempItalic As String

        Dim strSeparator() As Char = {","}

        tmpTypeNamePrefix = Trim(GetSetting("Restaurant", "FormSetting", "TypePrefix"))

        For iIndex = 0 To tmpTypeNamePrefix.Split(strSeparator(0)).Length - 1
            strTypeStarter = tmpTypeNamePrefix.Split(strSeparator(0)).GetValue(iIndex)

            If InStr(1, Trim(strTypeStarter.ToUpper), Trim(strStarter.ToUpper), CompareMethod.Binary) = 1 Then
                blnStarter = True
                Exit For
            Else
                blnStarter = False
            End If
        Next
        IsStarterType = blnStarter
    End Function

    Private Function IsItalicType(ByVal strItalic As String) As Boolean
        Dim iIndex As Integer

        Dim blnIsItalic As Boolean = False

        Dim strTypeItalic As String
        Dim tmpTypeNamePrefixItalic As String
        Dim strTempItalic As String

        Dim strSeparator() As Char = {","}

        tmpTypeNamePrefixItalic = Trim(GetSetting("Restaurant", "FormSetting", "TypePrefixItalic"))

        For iIndex = 0 To tmpTypeNamePrefixItalic.Split(strSeparator(0)).Length - 1
            strTempItalic = tmpTypeNamePrefixItalic.Split(strSeparator(0)).GetValue(iIndex)

            If InStr(1, Trim(strTempItalic.ToUpper), Trim(strItalic.ToUpper), CompareMethod.Binary) = 1 Then
                blnIsItalic = True
                Exit For
            Else
                blnIsItalic = False
            End If
        Next
        IsItalicType = blnIsItalic
    End Function

    Private Function PrintOrder()

        Dim i As Integer
        Dim iIndex As Integer
        Dim iIndexItalic As Integer
        Dim PaperHeight As Integer
        Dim iMaxItemLen As Integer = 0
        Dim iMaxItemQtyLen As Integer = 0
        Dim iKitchenItem As Integer = 0
        Dim iKitchenItemMain As Integer = 0
        Dim iKitchenItemMainItalic As Integer = 0
        Dim iItemInfoKitchenStarters As Integer = 0
        Dim iItemInfoKitchenStartersItalic As Integer = 0
        Dim Total_item_food As Integer = 0

        Dim iBarItem As Integer = 0

        Dim strOrderDate As String = vbNewLine + "Date: " + DateTime.Parse(GetOrderDate()).ToString("dd/MM/yyyy") _
                                     + vbNewLine + "Time:" + DateTime.Parse(GetOrderDate()).ToString("hh:mm:ss tt") + vbNewLine

        Dim strOrderTime As String = vbNewLine + "Time In :" + DateTime.Parse(GetOrderDate()).ToString("hh:mm:ss tt")

        'Dim strOrderId As String = vbNewLine + "Order Id: " + CStr(Trim(txtCustomerNo.Tag))
        Dim strSeparator() As Char = {","}
        Dim strItemInfoKitchenStarters As String
        Dim strItemInfoKitchenStartersItalic As String
        Dim strItemInfoKitchenMain As String
        Dim strItemInfoKitchenMainItalic As String
        Dim strItemInfoBar As String
        Dim tmptext As String
        Dim tmpTypeName As String

        Dim strTemp As String

        Dim TotalQty As Integer
        Dim PendingQty As Integer
        Dim NewQty As Integer

        If lvOrder.Items.Count > 0 Then
            For i = 0 To lvOrder.Items.Count - 1
                If Len(lvOrder.Items(i).SubItems(2).Text) > iMaxItemLen Then
                    iMaxItemLen = Len(lvOrder.Items(i).SubItems(2).Text)
                End If
                If Len(lvOrder.Items(i).SubItems(1).Text) > iMaxItemQtyLen Then
                    iMaxItemQtyLen = Len(lvOrder.Items(i).SubItems(1).Text)
                End If
            Next

            i = 0
            If Me.lvOrder.CheckBoxes = False Then
                For i = 0 To lvOrder.Items.Count - 1
                    tmptext = Trim(lvOrder.Items(i).SubItems(7).Text)
                    tmpTypeName = Trim(lvOrder.Items(i).SubItems(8).Text).ToUpper
                    If tmptext.ToUpper = "KITCHEN" Then
                        If strItemInfoKitchenStarters = vbNullString Then
                            strItemInfoKitchenStarters = "-----------------------" & vbNewLine
                        End If

                        If IsStarterType(tmpTypeName) = True Then
                            If IsItalicType(tmpTypeName) = True Then
                                strItemInfoKitchenStartersItalic += lvOrder.Items(i).SubItems(1).Text & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                                                    lvOrder.Items(i).SubItems(2).Text
                                If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                                    strItemInfoKitchenStartersItalic += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & _
                                                                  vbNewLine & lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                                Else
                                    strItemInfoKitchenStartersItalic += vbNewLine & vbNewLine
                                End If
                                iItemInfoKitchenStartersItalic += 1
                            Else
                                strItemInfoKitchenStarters += lvOrder.Items(i).SubItems(1).Text & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                                              lvOrder.Items(i).SubItems(2).Text
                                If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                                    strItemInfoKitchenStarters += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & _
                                                                  vbNewLine & lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                                Else
                                    strItemInfoKitchenStarters += vbNewLine & vbNewLine
                                End If
                                iItemInfoKitchenStarters += 1
                            End If
                        Else
                            If IsItalicType(tmpTypeName) = True Then
                                strItemInfoKitchenMainItalic += lvOrder.Items(i).SubItems(1).Text & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                                                lvOrder.Items(i).SubItems(2).Text
                                If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                                    strItemInfoKitchenMainItalic += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & _
                                                                  vbNewLine & lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                                Else
                                    strItemInfoKitchenMainItalic += vbNewLine & vbNewLine
                                End If
                                iKitchenItemMainItalic += 1
                            Else
                                strItemInfoKitchenMain += lvOrder.Items(i).SubItems(1).Text & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                                          lvOrder.Items(i).SubItems(2).Text
                                If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                                    strItemInfoKitchenMain += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & vbNewLine & _
                                                              lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                                Else
                                    strItemInfoKitchenMain += vbNewLine & vbNewLine
                                End If
                                iKitchenItemMain += 1
                            End If
                        End If
                        iKitchenItem += 1
                    ElseIf tmptext.ToUpper = "BAR" Then
                        If strItemInfoBar = vbNullString Then
                            strItemInfoBar = "-----------------------" & vbNewLine
                        End If
                        strItemInfoBar += lvOrder.Items(i).SubItems(1).Text & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                          lvOrder.Items(i).SubItems(2).Text
                        If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                            strItemInfoBar += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & vbNewLine & _
                                             lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                        Else
                            strItemInfoBar += vbNewLine & vbNewLine
                        End If
                        iBarItem += 1
                    End If
                Next

                If iItemInfoKitchenStarters > 0 And iItemInfoKitchenStartersItalic > 0 Then
                    strItemInfoKitchenStartersItalic += "-----------------------------" & vbNewLine + vbNewLine + vbNewLine
                    If iItemInfoKitchenStarters >= 14 Then
                        strItemInfoKitchenStarters += vbNewLine + vbNewLine
                    End If
                ElseIf iItemInfoKitchenStarters > 0 Then
                    strItemInfoKitchenStarters += "-----------------------" & vbNewLine + vbNewLine + vbNewLine
                    If iItemInfoKitchenStarters >= 14 Then
                        strItemInfoKitchenStarters += vbNewLine + vbNewLine
                    End If
                ElseIf iItemInfoKitchenStartersItalic > 0 Then
                    strItemInfoKitchenStartersItalic += "-----------------------------" & vbNewLine + vbNewLine + vbNewLine
                    If iItemInfoKitchenStartersItalic >= 14 Then
                        strItemInfoKitchenStartersItalic += vbNewLine + vbNewLine
                    End If
                Else
                    strItemInfoKitchenStarters += ""
                    strItemInfoKitchenStartersItalic += ""
                End If

                If iKitchenItemMain > 0 And iKitchenItemMainItalic > 0 Then
                    strItemInfoKitchenMainItalic += "-----------------------------" & vbNewLine
                ElseIf iKitchenItemMain > 0 Then
                    strItemInfoKitchenMain += "-----------------------" & vbNewLine
                ElseIf iKitchenItemMainItalic > 0 Then
                    strItemInfoKitchenMainItalic += "-----------------------------" & vbNewLine
                Else
                    strItemInfoKitchenMain = ""
                    strItemInfoKitchenMainItalic = ""
                End If

                strItemInfoBar += "-----------------------" & vbNewLine

            Else
                For i = 0 To lvOrder.Items.Count - 1
                    'If lvOrder.Items(i).Checked = False Then
                    Me.lvOrder.Focus()
                    If lvOrder.Items(i).Checked = True Then
                        tmptext = Trim(lvOrder.Items(i).SubItems(7).Text)
                        tmpTypeName = Trim(lvOrder.Items(i).SubItems(8).Text).ToUpper
                        If tmptext.ToUpper = "KITCHEN" Then
                            If strItemInfoKitchenStarters = vbNullString Then
                                strItemInfoKitchenStarters = "-----------------------" & vbNewLine
                            End If

                            If IsStarterType(tmpTypeName) = True Then
                                If IsItalicType(tmpTypeName) = True Then
                                    'added for newadded qty will go to kitchen "milton in london on 30.01.08"'
                                    TotalQty = CInt(lvOrder.Items(i).SubItems(1).Text)
                                    PendingQty = CInt(lvOrder.Items(i).SubItems(9).Text)
                                    If TotalQty > PendingQty Then
                                        NewQty = TotalQty - PendingQty
                                    Else
                                        NewQty = lvOrder.Items(i).SubItems(1).Text

                                    End If
                                    ''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    strItemInfoKitchenStartersItalic += NewQty & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                                                        lvOrder.Items(i).SubItems(2).Text
                                    If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                                        strItemInfoKitchenStartersItalic += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & _
                                                                      vbNewLine & lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                                    Else
                                        strItemInfoKitchenStartersItalic += vbNewLine & vbNewLine
                                    End If
                                    iItemInfoKitchenStartersItalic += 1
                                Else
                                    'added for newadded qty will go to kitchen "milton in london on 30.01.08"'
                                    TotalQty = CInt(lvOrder.Items(i).SubItems(1).Text)
                                    PendingQty = CInt(lvOrder.Items(i).SubItems(9).Text)
                                    If TotalQty > PendingQty Then
                                        NewQty = TotalQty - PendingQty
                                    Else
                                        NewQty = lvOrder.Items(i).SubItems(1).Text

                                    End If
                                    ''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    strItemInfoKitchenStarters += NewQty & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                                                  lvOrder.Items(i).SubItems(2).Text
                                    If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                                        strItemInfoKitchenStarters += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & _
                                                                      vbNewLine & lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                                    Else
                                        strItemInfoKitchenStarters += vbNewLine & vbNewLine
                                    End If
                                    iItemInfoKitchenStarters += 1
                                End If
                            Else
                                If IsItalicType(tmpTypeName) = True Then
                                    'added for newadded qty will go to kitchen "milton in london on 30.01.08"'
                                    TotalQty = CInt(lvOrder.Items(i).SubItems(1).Text)
                                    PendingQty = CInt(lvOrder.Items(i).SubItems(9).Text)
                                    If TotalQty > PendingQty Then
                                        NewQty = TotalQty - PendingQty
                                    Else
                                        NewQty = lvOrder.Items(i).SubItems(1).Text

                                    End If
                                    ''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    strItemInfoKitchenMainItalic += NewQty & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                                                    lvOrder.Items(i).SubItems(2).Text
                                    If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                                        strItemInfoKitchenMainItalic += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & _
                                                                      vbNewLine & lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                                    Else
                                        strItemInfoKitchenMainItalic += vbNewLine & vbNewLine
                                    End If
                                    iKitchenItemMainItalic += 1
                                Else
                                    'added for newadded qty will go to kitchen "milton in london on 30.01.08"'
                                    TotalQty = CInt(lvOrder.Items(i).SubItems(1).Text)
                                    PendingQty = CInt(lvOrder.Items(i).SubItems(9).Text)
                                    If TotalQty > PendingQty Then
                                        NewQty = TotalQty - PendingQty
                                    Else
                                        NewQty = lvOrder.Items(i).SubItems(1).Text

                                    End If
                                    ''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    strItemInfoKitchenMain += NewQty & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                                              lvOrder.Items(i).SubItems(2).Text
                                    If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                                        strItemInfoKitchenMain += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & vbNewLine & _
                                                                  lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                                    Else
                                        strItemInfoKitchenMain += vbNewLine & vbNewLine
                                    End If
                                    iKitchenItemMain += 1
                                End If
                            End If
                            iKitchenItem += 1
                        ElseIf tmptext.ToUpper = "BAR" Then
                            If strItemInfoBar = vbNullString Then
                                strItemInfoBar = "-----------------------" & vbNewLine
                            End If
                            'added for newadded qty will go to kitchen "milton in london on 30.01.08"'
                            TotalQty = CInt(lvOrder.Items(i).SubItems(1).Text)
                            PendingQty = CInt(lvOrder.Items(i).SubItems(9).Text)
                            If TotalQty > PendingQty Then
                                NewQty = TotalQty - PendingQty
                            Else
                                NewQty = lvOrder.Items(i).SubItems(1).Text

                            End If
                            ''''''''''''''''''''''''''''''''''''''''''''''''''''
                            strItemInfoBar += NewQty & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                          lvOrder.Items(i).SubItems(2).Text
                            If Trim(lvOrder.Items(i).SubItems(4).Text) <> "" Then
                                strItemInfoBar += Space((iMaxItemLen - Len(lvOrder.Items(i).SubItems(2).Text)) + 2) & vbNewLine & _
                                                 lvOrder.Items(i).SubItems(4).Text & vbNewLine & vbNewLine
                            Else
                                strItemInfoBar += vbNewLine & vbNewLine
                            End If
                            iBarItem += 1
                        End If

                    End If
                Next

                If iItemInfoKitchenStarters > 0 And iItemInfoKitchenStartersItalic > 0 Then
                    strItemInfoKitchenStartersItalic += "-----------------------------" & vbNewLine + vbNewLine + vbNewLine
                    If iItemInfoKitchenStarters >= 14 Then
                        strItemInfoKitchenStarters += vbNewLine + vbNewLine
                    End If


                ElseIf iItemInfoKitchenStarters > 0 Then
                    strItemInfoKitchenStarters += "-----------------------" & vbNewLine + vbNewLine + vbNewLine
                    If iItemInfoKitchenStarters >= 14 Then
                        strItemInfoKitchenStarters += vbNewLine + vbNewLine
                    End If
                ElseIf iItemInfoKitchenStartersItalic > 0 Then
                    strItemInfoKitchenStartersItalic += "-----------------------------" & vbNewLine + vbNewLine + vbNewLine
                    If iItemInfoKitchenStartersItalic >= 14 Then
                        iItemInfoKitchenStartersItalic += vbNewLine + vbNewLine
                    End If
                Else
                    strItemInfoKitchenStarters += ""
                    strItemInfoKitchenStartersItalic += ""
                End If

                If iKitchenItemMain > 0 And iKitchenItemMainItalic > 0 Then
                    strItemInfoKitchenMainItalic += "-----------------------------" & vbNewLine
                ElseIf iKitchenItemMain > 0 Then
                    strItemInfoKitchenMain += "-----------------------" & vbNewLine
                ElseIf iKitchenItemMainItalic > 0 Then
                    strItemInfoKitchenMainItalic += "-----------------------------" & vbNewLine
                Else
                    strItemInfoKitchenMain = ""
                    strItemInfoKitchenMainItalic = ""
                End If
                strItemInfoBar += "-----------------------" & vbNewLine
            End If
            Total_item_food = iKitchenItem
            Dim strUser As String = "Taken By:" + struserName + vbNewLine

            Dim ObjrstPrinter As New RstPrinter.printdoc
            Dim objPrintDirect As New PrintDirect
            Dim offPrintDialog As New StandardPrintController
            ObjrstPrinter.PrintController = offPrintDialog

            If iBarItem > 0 Then
                If mdConfiguration.sBarPrinter <> vbNullString Then
                    ObjrstPrinter.PrinterSettings.PrinterName = mdConfiguration.sBarPrinter
                    ObjrstPrinter.DateText = strOrderDate
                    ObjrstPrinter.ItemFont = New Font("Lucida Console", 12, FontStyle.Bold)
                    ObjrstPrinter.ItemText = vbNewLine + strUser + strItemInfoBar   ' strOrderId +  'change milton 19.08.07

                    If chkBoxWaitingCust.Checked = True Then

                        ObjrstPrinter.CustomerAddressText = "Waiting Customer" + vbNewLine + vbNewLine + txtName.Text

                    ElseIf chkBoxCollection.Checked = True Then

                        ObjrstPrinter.CustomerAddressText = "Collection" + vbNewLine + txtName.Text + vbNewLine + txtPhoneNumber.Text


                    Else
                        ObjrstPrinter.CustomerAddressText = vbNewLine + vbNewLine + txtName.Text + vbNewLine + txtCompany.Text _
                                                       + vbNewLine + txtAddress.Text + vbNewLine + txtPostCode.Text _
                                                       + vbNewLine + txtTown.Text + vbNewLine + txtPhoneNumber.Text
                    End If

                    ObjrstPrinter.Print()
                    objPrintDirect.OnCutter(mdConfiguration.sBarPrinter)
                    ObjrstPrinter.DateText = ""
                    ObjrstPrinter.DateHeight = 0
                    ObjrstPrinter.ItemStarterText = ""
                    ObjrstPrinter.ItemStarterHeight = 0
                    ' ObjrstPrinter.ItemStarterItalicHeight = ""     'changed for dinks
                    ObjrstPrinter.ItemStarterItalicHeight = 0
                    ObjrstPrinter.ItemText = ""
                    ObjrstPrinter.ItemHeight = 0
                    ObjrstPrinter.ItemTextItalic = ""
                    ObjrstPrinter.ItemItalicHeight = 0
                    ObjrstPrinter.CustomerAddressText = ""
                    ObjrstPrinter.CustomerAddressHeight = 0
                    ObjrstPrinter.FooterText = ""
                    ObjrstPrinter.FooterHeight = 0
                Else
                    'MsgBox("Please select a printer for Bar.", MsgBoxStyle.Information, "Takeaway")
                End If
            End If
            Dim addtime As Date = Now.ToShortTimeString
            If iKitchenItem > 0 Then
                If mdConfiguration.sOrderPrinter <> vbNullString Then
                    ObjrstPrinter.PrinterSettings.PrinterName = mdConfiguration.sOrderPrinter
                    ObjrstPrinter.DateText = strOrderDate
                    ObjrstPrinter.ItemFont = New Font("Lucida Console", 12, FontStyle.Bold)
                    ObjrstPrinter.ItemStarterText = vbNewLine + strUser + strItemInfoKitchenStarters    'strOrderId + 'changed milton
                    ObjrstPrinter.ItemStarterItalicText = strItemInfoKitchenStartersItalic
                    ObjrstPrinter.ItemText = strItemInfoKitchenMain + vbNewLine + "Total Item: " + CStr(Total_item_food) + vbNewLine + "Net Total:   " + lblTotalOrderPrice.Text + strOrderTime

                    ObjrstPrinter.ItemTextItalic = strItemInfoKitchenMainItalic

                    If chkBoxWaitingCust.Checked = True Then

                        ObjrstPrinter.FooterFont = New Font("Lucida Console", 10, FontStyle.Bold)
                        ObjrstPrinter.FooterText = "Time Out : " + CStr(addtime.AddMinutes(mdConfiguration.collectiontime)) + vbNewLine + "Waiting Customer" + vbNewLine + vbNewLine + txtName.Text

                    ElseIf chkBoxCollection.Checked = True Then

                        ObjrstPrinter.FooterFont = New Font("Lucida Console", 10, FontStyle.Bold)
                        ObjrstPrinter.FooterText = "Time Out : " + CStr(addtime.AddMinutes(mdConfiguration.collectiontime)) + vbNewLine + "Collection" + vbNewLine + txtName.Text + vbNewLine + txtPhoneNumber.Text + vbNewLine


                    Else
                        ObjrstPrinter.CustomerAddressText = "Time Out : " + CStr(addtime.AddMinutes(mdConfiguration.collectiontime)) + vbNewLine + txtName.Text + vbNewLine + txtCompany.Text _
                                                       + vbNewLine + txtAddress.Text + vbNewLine + txtPostCode.Text _
                                                       + vbNewLine + txtTown.Text + vbNewLine + txtPhoneNumber.Text + vbNewLine
                    End If
                    ObjrstPrinter.Print()
                    objPrintDirect.OnCutter(mdConfiguration.sOrderPrinter)
                    'new added
                    If mdConfiguration.sOrderPrinter1 <> vbNullString Then
                        ObjrstPrinter.PrinterSettings.PrinterName = mdConfiguration.sOrderPrinter1
                        ObjrstPrinter.DateText = strOrderDate
                        ObjrstPrinter.ItemFont = New Font("Lucida Console", 12, FontStyle.Bold)
                        ObjrstPrinter.ItemStarterText = vbNewLine + strUser + strItemInfoKitchenStarters       'strOrderId + 'changed milton
                        ObjrstPrinter.ItemStarterItalicText = strItemInfoKitchenStartersItalic
                        ObjrstPrinter.ItemText = strItemInfoKitchenMain
                        ObjrstPrinter.ItemTextItalic = strItemInfoKitchenMainItalic

                        If chkBoxWaitingCust.Checked = True Then

                            ObjrstPrinter.FooterFont = New Font("Lucida Console", 10, FontStyle.Bold)
                            ObjrstPrinter.FooterText = "Waiting Customer" + vbNewLine + vbNewLine + txtName.Text

                        ElseIf chkBoxCollection.Checked = True Then

                            ObjrstPrinter.FooterFont = New Font("Lucida Console", 10, FontStyle.Bold)
                            ObjrstPrinter.FooterText = "Collection" + vbNewLine + txtName.Text + vbNewLine + txtPhoneNumber.Text + vbNewLine

                        Else
                            ObjrstPrinter.CustomerAddressText = vbNewLine + vbNewLine + txtName.Text + vbNewLine + txtCompany.Text _
                                                           + vbNewLine + txtAddress.Text + vbNewLine + txtPostCode.Text _
                                                           + vbNewLine + txtTown.Text + vbNewLine + txtPhoneNumber.Text + vbNewLine
                        End If
                        ObjrstPrinter.Print()
                        objPrintDirect.OnCutter(mdConfiguration.sOrderPrinter1)
                    Else
                        'MsgBox("Please select a printer for kitchenPrinter2", MsgBoxStyle.Information, "Takeaway")
                    End If
                End If
            End If
        End If

    End Function

    Private Function SpaceCalculation(ByVal strText As String) As Integer
        Dim SpaceLength As Integer
        Dim wordlength As Integer = Len(strText)

        SpaceLength = (30 / 2 - wordlength / 2) - 2

        If SpaceLength > 0 Then
            SpaceCalculation = SpaceLength
        Else
            SpaceCalculation = 0
        End If
    End Function

    Public Function PrintBill()

        Dim PaperHeight As Integer
        Dim i As Integer
        Dim iMaxItemLen As Integer = 0
        Dim iMaxItemQtyLen As Integer = 0
        Dim iStringLenCount As Integer
        Dim iPriceStringLen As Integer
        Dim iSpaceForPrice As Integer

        Dim strOrderDate As String
        Dim strCompanyName As String
        Dim strCompanyType As String
        Dim strCompanyAddress1 As String
        Dim strCompanyAddress2 As String
        Dim strCompanyAddress3 As String
        Dim strCompanyPhone As String
        Dim strVatNumber As String
        Dim strEmailAddress As String
        Dim strwebAddress As String
        Dim strFooter As String
        Dim strItemInformation As String
        Dim strAfterDISandSER As String
        Dim strItemInfoHeader As String
        Dim strItemPrice As String
        Dim strDis As String
        Dim strTips As String
        Dim strOrderId As String
        Dim strCash As String
        Dim strCard As String
        Dim srtCheque As String
        Dim srtChange As String


        strOrderDate = "Date: " + DateTime.Parse(GetOrderDate()).ToString("dd/MM/yyyy") _
                       + vbNewLine + "Time:" + DateTime.Parse(GetOrderDate()).ToString("hh:mm:ss tt") + vbNewLine
        If Len(Trim(mdConfiguration.strResturantName)) > 0 Then
            strCompanyName = Space(SpaceCalculation(Trim(mdConfiguration.strResturantName)) - 4) _
                             + mdConfiguration.strResturantName                 'To print Restaurant name
        Else
            strCompanyName = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantType)) > 0 Then
            strCompanyType = Space(SpaceCalculation(Trim(mdConfiguration.strRestuarantType))) _
                             + Trim(mdConfiguration.strRestuarantType) + vbNewLine 'To print Restaurant Type
        Else
            strCompanyType = ""
        End If

        If Len(Trim(mdConfiguration.strResturantAddress1)) > 0 Then
            strCompanyAddress1 = Space(SpaceCalculation(Trim(mdConfiguration.strResturantAddress1))) _
                                 + Trim(mdConfiguration.strResturantAddress1) + vbNewLine 'To print Restaurant Address1
        Else
            strCompanyAddress1 = ""
        End If

        If Len(Trim(mdConfiguration.strRestuantAddress2)) > 0 Then
            strCompanyAddress2 = Space(SpaceCalculation(Trim(mdConfiguration.strRestuantAddress2))) _
                                 + Trim(mdConfiguration.strRestuantAddress2) + vbNewLine 'To print Restaurant Address2
        Else
            strCompanyAddress2 = ""
        End If

        If Len(Trim(mdConfiguration.strRestuantAddress3)) > 0 Then
            strCompanyAddress3 = Space(SpaceCalculation(Trim(mdConfiguration.strRestuantAddress3))) _
                                 + Trim(mdConfiguration.strRestuantAddress3) + vbNewLine 'To print Restaurant Address3
        Else
            strCompanyAddress3 = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantPhone)) > 0 Then
            Dim strPhone As String = Trim(mdConfiguration.strRestuarantPhone)
            strCompanyPhone = Space((SpaceCalculation(strPhone))) + "Tel:" _
                              + Trim(mdConfiguration.strRestuarantPhone) + vbNewLine  'To print Restaurant Phone

        Else
            strCompanyPhone = ""
        End If

        If Len(Trim(mdConfiguration.strVatNumber)) > 0 Then
            strVatNumber = Space(SpaceCalculation(Trim(mdConfiguration.strVatNumber)) - 6) + "Vat Number: " _
                           + Trim(mdConfiguration.strVatNumber) + vbNewLine           'To print Restaurant VatNumber
        Else
            strVatNumber = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantWeb)) > 0 Then
            strwebAddress = Space(SpaceCalculation(Trim(mdConfiguration.strRestuarantWeb))) _
            + Trim(mdConfiguration.strRestuarantWeb) + vbNewLine                     'To print Restaurant Web Address
        Else
            strwebAddress = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantEmail)) > 0 Then
            strEmailAddress = Space(SpaceCalculation(Trim(mdConfiguration.strRestuarantEmail))) _
            + Trim(mdConfiguration.strRestuarantEmail) + vbNewLine                           'To print Restaurant Email address
        Else
            strEmailAddress = ""
        End If

        '  strOrderId = "Order Id: " + CStr(Trim(txtCustomerNo.Tag)) + vbNewLine   'for client requriement we removed 

        strItemInformation = "-------------------------------" & vbNewLine

        If lvOrder.Items.Count > 0 Then

            For i = 0 To lvOrder.Items.Count - 1
                If Len(lvOrder.Items(i).SubItems(2).Text) > iMaxItemLen Then
                    iMaxItemLen = Len(lvOrder.Items(i).SubItems(2).Text)
                End If
                If Len(lvOrder.Items(i).SubItems(1).Text) > iMaxItemQtyLen Then
                    iMaxItemQtyLen = Len(lvOrder.Items(i).SubItems(1).Text)
                End If
            Next
            i = 0

            For i = 0 To lvOrder.Items.Count - 1

                strItemInformation += lvOrder.Items(i).SubItems(1).Text & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                                      lvOrder.Items(i).SubItems(2).Text
                'strItemInformation += lvOrder.Items(i).SubItems(1).Text & Space((iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2) & _
                ' lvOrder.Items(i).SubItems(2).Text

                '-----------------For The Purpose Of Price make Right Align-------------------------------------------'

                iStringLenCount = Len(Trim(lvOrder.Items(i).SubItems(1).Text)) + (iMaxItemQtyLen - Len(lvOrder.Items(i).SubItems(1).Text)) + 2 _
                                  + Len(Trim(lvOrder.Items(i).SubItems(2).Text))

                If iStringLenCount <= 25 Then   '22
                    iStringLenCount = 25 - iStringLenCount
                    iPriceStringLen = Len(Trim((lvOrder.Items(i).SubItems(3).Text))) + 1
                    iSpaceForPrice = iStringLenCount + 7 - iPriceStringLen
                End If
                strItemInformation += Space(iSpaceForPrice) + FormatCurrency(lvOrder.Items(i).SubItems(3).Text) + vbNewLine
            Next

            strItemInformation += "-------------------------------" '& vbNewLine

            strItemPrice = vbNewLine + "Sub Total : " + Space(32 - (Len(Trim("Total Price:")) + Len(Trim(txtTotalPrice.Text)) + 1)) + txtTotalPrice.Text + vbNewLine


            If Trim(txtDiscount.Text) <> "" Then
                If Decimal.Parse(Trim(txtDiscount.Text), NumberStyles.Currency) <> 0.0 Then
                    strDis = FormatCurrency(Trim(txtDiscount.Text))
                End If
            Else
                strDis = ""
            End If
            Dim strDiscountPrice As String = IIf(strDis <> "", "Discount:" + Space(32 - (Len(Trim("Discount:")) + Len(Trim(strDis)) + 1)) + strDis + vbNewLine, "")


            If Trim(txtTips.Text) <> "" Then
                If Decimal.Parse(Trim(txtTips.Text), NumberStyles.Currency) <> 0.0 Then
                    strTips = FormatCurrency(Trim(txtTips.Text))
                    strFooter = ""
                Else
                    strTips = ""
                    strFooter = "Service Charge not included" + vbNewLine
                End If
            Else
                strTips = ""
                strFooter = "Service Charge not included" + vbNewLine
            End If

            ' Dim strTipsAmount As String = IIf(strTips <> "", "Service Charge:" + Space(29 - (Len(Trim("Service Charge:")) + Len(Trim(strTips)) + 1)) + strTips + vbNewLine, "")
            Dim strTipsAmount As String = IIf(strTips <> "", "s.charge:      " + Space(32 - (Len(Trim("Service Charge:")) + Len(Trim(strTips)) + 1)) + strTips + vbNewLine, "")

            'Dim strNetPay As String = "Grand Total:" + Space(29 - (Len(Trim("Grand Total:")) + Len(Trim(txtNetPay.Text)) + 1)) + txtNetPay.Text + vbNewLine
            Dim strNetPay As String = "Total  :" + Space(30 - (Len(Trim("Grand Total:")) + Len(Trim(txtNetPay.Text)) + 1)) + txtNetPay.Text '+ vbNewLine
            Dim strCardType As String
            If Len(Trim(txtChange.Text)) > 0 Then
                strCash = IIf(Trim(txtCashPay.Text) <> "", "Cash given:" + Space(32 - (Len(Trim("Cash given:")) + _
                          Len(Trim(txtCashPay.Text)) + 1)) + Trim(txtCashPay.Text) + vbNewLine, "")
                strCard = IIf(Trim(txtCardPay.Text) = "", "", "Payment in card:" + _
                          Space(32 - (Len(Trim("Payment in card:")) + Len(Trim(txtCardPay.Text)) + 1)) + txtCardPay.Text + vbNewLine)
                If strCard <> "" Then
                    'If Trim(cboCardType.Text) = vbNullString Then
                    ' MsgBox("Please select a card type.", MsgBoxStyle.Information, "Takeaway")
                    'cboCardType.Focus()
                    'Exit Function
                    ' Else
                    strCardType = "Card Type:" + Space(32 - (Len(Trim("Card Type:")) + Len(Trim(cboCardType.Text)) + 1)) + Trim(cboCardType.Text) + vbNewLine
                    strCard += strCardType
                    'End If
                End If
                srtCheque = IIf(Trim(txtChequePay.Text) <> "", "Cheque Payment:" + Space(32 - (Len(Trim("Cheque Payment:")) + _
                            Len(Trim(txtChequePay.Text)) + 1)) + Trim(txtChequePay.Text) + vbNewLine, "")
                srtChange = IIf(Trim(txtChange.Text) <> "", "Change:" + Space(32 - (Len(Trim("Change: ")) + _
                            Len(Trim(txtChange.Text)) + 1)) + Trim(txtChange.Text) + vbNewLine, "")
            End If
            Dim strUser As String
            If SpaceCalculation(struserName) >= 6 Then
                strUser = Space(SpaceCalculation(struserName) - 6) + "Taken By: " + struserName
            Else
                strUser = Space(SpaceCalculation(struserName)) + "Taken By: " + struserName
            End If

            Dim strPrintItem As String
            Dim strNetpayItem As String
            Dim strviapaid As String

            strAfterDISandSER = "                   ------------"

            strPrintItem = strItemInformation + strItemPrice + strDiscountPrice + strTipsAmount + strAfterDISandSER '+ strNetPay
            strNetpayItem = strNetPay

            If strCash <> "" Then
                ' strPrintItem += strCash
                strviapaid += strCash
            End If
            If strCard <> "" Then
                'strPrintItem += strCard
                strviapaid += strCard
            End If
            If srtCheque <> "" Then
                'strPrintItem += srtCheque
                strviapaid += srtCheque
            End If
            If srtChange <> "" Then
                strviapaid += srtChange

            End If
            strFooter += Space(SpaceCalculation(Trim(mdConfiguration.strGreetingMsg))) _
                         + IIf(Trim(mdConfiguration.strGreetingMsg) <> vbNullString, _
                         Trim(mdConfiguration.strGreetingMsg), " ") + vbNewLine ' To Print Greeting Message

            strFooter += strEmailAddress + strwebAddress

            Dim ObjbillrstPrinter As New BillRstPrinter.printdoc
            Dim objPrintDirect As New PrintDirectt
            Dim offPrintDialog As New StandardPrintController

            ObjbillrstPrinter.PrintController = offPrintDialog

            If mdConfiguration.sBillPrinter <> vbNullString Then
                ObjbillrstPrinter.PrinterSettings.PrinterName = mdConfiguration.sBillPrinter
                ObjbillrstPrinter.DateText = strOrderDate
                If File.Exists("C:\Program Files\UYSYS\Logo\logo.bmp") Then
                    Dim strLogoPath As String
                    strLogoPath = "C:\Program Files\UYSYS\Logo\logo.bmp"
                    ObjbillrstPrinter.LogoImage = New Bitmap(strLogoPath)
                    ObjbillrstPrinter.HeaderText = vbNewLine + vbNewLine
                Else
                    ObjbillrstPrinter.HeaderText = vbNewLine + strCompanyName
                End If

                ObjbillrstPrinter.AddressText = strCompanyType + strCompanyAddress1 + strCompanyAddress2 _
                                            + strCompanyAddress3 + strCompanyPhone + strVatNumber + strUser _
                                            + vbNewLine '+ vbNewLine
                ObjbillrstPrinter.ItemText = strPrintItem  'strOrderId + vbNewLine + 
                ObjbillrstPrinter.NetpayText = strNetpayItem '+ vbNewLine
                ObjbillrstPrinter.ViaPaidText = strviapaid
                If chkBoxWaitingCust.Checked = True Then

                    ObjbillrstPrinter.CustomerAddressText = "Waiting Customer" + vbNewLine + txtName.Text + vbNewLine

                ElseIf chkBoxCollection.Checked = True Then

                    ObjbillrstPrinter.CustomerAddressText = "Collection" + vbNewLine + txtName.Text + vbNewLine + txtPhoneNumber.Text + vbNewLine

                Else
                    Dim CADDRESS As String
                    If txtName.Text <> "" Then
                        CADDRESS += txtName.Text + vbNewLine
                    End If

                    If txtCompany.Text <> "" Then
                        CADDRESS += txtCompany.Text + vbNewLine
                    End If

                    If txtAddress.Text <> "" Then
                        CADDRESS += txtAddress.Text + vbNewLine
                    End If

                    If txtPostCode.Text <> "" Then
                        CADDRESS += txtPostCode.Text + vbNewLine
                    End If

                    If txtTown.Text <> "" Then
                        CADDRESS += txtTown.Text + vbNewLine
                    End If

                    If txtPhoneNumber.Text <> "" Then
                        CADDRESS += txtPhoneNumber.Text + vbNewLine
                    End If
                    'ObjbillrstPrinter.CustomerAddressText = vbNewLine + txtName.Text + vbNewLine + txtCompany.Text + vbNewLine + txtAddress.Text + vbNewLine _
                    '                                     + txtPostCode.Text + vbNewLine + txtTown.Text + vbNewLine _
                    '                                     + Trim(txtPhoneNumber.Text) + vbNewLine
                    'ObjbillrstPrinter.CustomerAddressText = vbNewLine + txtName.Text + txtCompany.Text + txtAddress.Text + txtPostCode.Text + txtTown.Text + vbNewLine _
                    '                                         + Trim(txtPhoneNumber.Text) + vbNewLine
                    ObjbillrstPrinter.CustomerAddressText = vbNewLine + CADDRESS
                End If

                ObjbillrstPrinter.FooterText = strFooter
                ObjbillrstPrinter.Print()
                objPrintDirect.OnCutter(mdConfiguration.sBillPrinter)
            Else
                MsgBox("Please select a printer for printing bill.", MsgBoxStyle.Information, "Takeaway")
            End If
        Else
            MsgBox("Please select one or more item for order to print bill", MsgBoxStyle.Information, "Dine In")
        End If

    End Function

    Private Sub btnAllPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllPrint.Click
        Me.lvOrder.Sorting = SortOrder.Ascending

        If lvOrder.Items.Count = 0 Then
            MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            btBillPrint.Enabled = False
            btnAllPrint.Enabled = False
            btnLevelPrint.Enabled = False
            btnKitchPrint.Enabled = False
            If lvOrder.CheckBoxes = True Then    'btnSubmit.Text = "Update" Then "for new button in london on 1.02.08 
                Call UpdateOrder()
                If bPrint = True Then
                    PrintBill()
                    PrintOrder()
                    Printlevel()
                End If
            ElseIf lvOrder.CheckBoxes = False Then  'btnSubmit.Text = "Submit" Then  "for new button in london on 1.02.08
                SubmitOrder()
                PrintOrder()
                PrintBill()
                Printlevel()
                btnSubmit.Text = "Update"
            Else
                PrintOrder()
                PrintBill()
                Printlevel()
                btnSubmit.Text = "Update"
            End If
        End If
        'End If
        Me.Dispose()
        Dim frmNew As New frmTakeaway
        frmNew.Show()
    End Sub

    Private Sub txtCashPay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCashPay.GotFocus
        conControlName = txtCashPay
        autocash()

        If Trim(txtCashPay.Text) <> vbNullString Then
            txtCashPay.Text = FormatNumber(txtCashPay.Text)
        End If
    End Sub

    Private Sub txtCardPay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCardPay.GotFocus
        conControlName = txtCardPay
        autocard()

        If Trim(txtCardPay.Text) <> vbNullString Then
            txtCardPay.Text = FormatNumber(txtCardPay.Text)
        End If
    End Sub

    Private Sub txtChequePay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequePay.GotFocus
        conControlName = txtChequePay
        autocheque()
        If Trim(txtChequePay.Text) <> vbNullString Then
            txtChequePay.Text = FormatNumber(txtChequePay.Text)
        End If
    End Sub

    Private Sub txtDiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.LostFocus
        If txtDiscount.Text <> vbNullString Then
            txtDiscount.Text = FormatCurrency(txtDiscount.Text)
        End If
    End Sub

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        conControlName = txtDiscount
        If Trim(txtDiscount.Text) <> vbNullString Then
            txtDiscount.Text = FormatNumber(txtDiscount.Text)
        End If
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        If Trim(txtName.Text) <> vbNullString Then
            ValidationForCharacter(txtName)
        End If
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        If Trim(txtTotalPrice.Text) <> vbNullString Then
            ValidationForNumaricData(txtDiscount)
            CalculateDiscount()
            CalculatePrice()
        End If
    End Sub

    Private Sub txtMobile_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.TextChanged
        If Trim(txtMobile.Text) <> vbNullString Then
            ValidationForPhoneNumber(txtMobile)
        End If
    End Sub

    Private Sub txtPhoneNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoneNumber.TextChanged
        If Trim(txtPhoneNumber.Text) <> vbNullString Then
            ValidationForPhoneNumber(txtPhoneNumber)
        End If
    End Sub

    Private Sub txtFaxNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFaxNo.TextChanged
        If Trim(txtFaxNo.Text) <> vbNullString Then
            ValidationForPhoneNumber(txtFaxNo)
        End If
    End Sub

    Private Sub txtIssueNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIssueNo.TextChanged
        If Trim(txtIssueNo.Text) <> vbNullString Then
            ValidationForNumaricData(txtIssueNo)
        End If
    End Sub

    Private Sub txtTotalPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalPrice.TextChanged

        If Trim(txtTotalPrice.Text) <> vbNullString Then
            CalculateTipsAmount()
            CalculateDiscoutAmount()  'added milton for changing discount
            CalculatePrice()
        End If

    End Sub

    Private Sub btnRefreshMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshMenu.Click
        lvOrder.Items.Clear()
        lblTotalOrderPrice.Text = ""
    End Sub

    Private Sub cboDiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDiscount.LostFocus
        CalculateDiscoutAmount()
    End Sub

    Private Sub cboDiscount_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDiscount.SelectedIndexChanged
        CalculateDiscoutAmount()
    End Sub

    Private Function CalculateDiscoutAmount()

        Dim dTotalPrice As Double

        If txtTotalPrice.Text = vbNullString Then
            Exit Function
        Else
            If Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency) = 0.0 Then
                Exit Function
            Else
                dTotalPrice = Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency)
            End If
        End If
        If Trim(cboDiscount.Text) <> vbNullString Then
            If Trim(cboDiscount.Text) <> "." Then
                txtDiscount.Text = FormatCurrency(dTotalPrice * Val(Trim(cboDiscount.Text)) / 100)
            Else
                txtDiscount.Text = ""
            End If
        Else
            txtDiscount.Text = ""
        End If

    End Function

    Private Function CalculateDiscount()
        Dim dTotalPrice As Double
        Dim dDiscount As Double
        Dim dDiscountedValue As Double
        Dim tmpText As String

        If txtTotalPrice.Text = vbNullString Then
            Exit Function
        Else
            If Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency) = 0.0 Then
                Exit Function
            Else
                dTotalPrice = Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency)
            End If
        End If

        dTotalPrice = Trim(txtTotalPrice.Text)

        If Trim(txtDiscount.Text) <> vbNullString Then
            If Trim(txtDiscount.Text) <> "." Then
                dDiscount = Decimal.Parse(Trim(txtDiscount.Text), NumberStyles.Currency)
            Else
                dDiscount = 0
            End If
        Else
            dDiscount = 0
        End If
        dDiscountedValue = (dDiscount * 100) / dTotalPrice
        'cboDiscount.Text = Format(dDiscountedValue, "00.00")  'changed milton  25.08.07


    End Function

    Private Sub cboTips_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTips.LostFocus
        CalculateTipsAmount()
    End Sub

    Private Sub cboTips_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTips.SelectedIndexChanged
        CalculateTipsAmount()
    End Sub

    Private Function CalculateTips()
        Dim dTotalPrice As Double
        Dim dTips As Double
        Dim dTipsAmount As Double
        Dim tmpText As String

        If txtTotalPrice.Text = vbNullString Then
            Exit Function
        Else
            If Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency) = 0.0 Then
                Exit Function
            Else
                dTotalPrice = Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency)
            End If
        End If


        If Trim(txtTips.Text) <> vbNullString Then
            If Trim(txtTips.Text) <> "." Then
                dTips = Decimal.Parse(Trim(txtTips.Text), NumberStyles.Currency)
            Else
                dTips = 0
            End If
        Else
            dTips = 0
        End If
        dTipsAmount = (dTips * 100) / dTotalPrice
        'cboTips.Text = Format(dTipsAmount, "00.00") 'changed milton 25.08.07

    End Function

    Private Function CalculateTipsAmount()

        Dim dTotalPrice As Double

        If txtTotalPrice.Text = vbNullString Then
            Exit Function
        Else
            If Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency) = 0.0 Then
                Exit Function
            Else
                dTotalPrice = Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency)
            End If
        End If

        If Trim(cboTips.Text) <> vbNullString Then
            If Trim(cboTips.Text) <> "." Then
                txtTips.Text = FormatCurrency(dTotalPrice * Val(Trim(cboTips.Text)) / 100)
            Else
                txtTips.Text = ""
            End If
        Else
            txtTips.Text = ""
        End If
    End Function

    Private Sub CalculatePrice()

        Dim dTotalPrice As Double
        Dim dDiscount As Double
        Dim dTips As Double
        Dim dDiscountedValue As Double
        Dim dNetPay As Double

        If txtTotalPrice.Text = vbNullString Then
            Exit Sub
        Else
            If Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency) = 0.0 Then
                Exit Sub
            Else
                dTotalPrice = Decimal.Parse(Trim(txtTotalPrice.Text), NumberStyles.Currency)
            End If
        End If

        If Trim(txtDiscount.Text) <> vbNullString Then
            If Trim(txtDiscount.Text) <> "." Then
                dDiscountedValue = Decimal.Parse(Trim(txtDiscount.Text), NumberStyles.Currency)
            Else
                dDiscountedValue = 0
            End If
        Else
            dDiscountedValue = 0
        End If

        If Trim(txtTips.Text) <> vbNullString Then
            If Trim(txtTips.Text) <> "." Then
                dTips = Decimal.Parse(Trim(txtTips.Text), NumberStyles.Currency)
            Else
                dTips = 0
            End If
        Else
            dTips = 0
        End If
        dNetPay = (dTotalPrice + dTips) - dDiscountedValue
        txtNetPay.Text = FormatCurrency(dNetPay)
    End Sub

    Private Sub txtTips_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTips.GotFocus
        conControlName = txtTips
        If Trim(txtTips.Text) <> vbNullString Then
            txtTips.Text = FormatNumber(txtTips.Text)
        End If
    End Sub

    Private Sub txtTips_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTips.LostFocus
        If txtTips.Text <> vbNullString Then
            txtTips.Text = FormatCurrency(txtTips.Text)
        End If
    End Sub

    Private Sub cboDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDiscount.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, cboDiscount)
    End Sub

    Private Sub cboTips_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTips.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, cboTips)
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtDiscount)
    End Sub

    Private Sub txtTips_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTips.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtTips)
    End Sub

    Private Sub txtCardPay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardPay.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtCardPay)
    End Sub

    Private Sub txtCashPay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashPay.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtCashPay)
    End Sub

    Private Sub txtChequePay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChequePay.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtChequePay)
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar <> Microsoft.VisualBasic.ChrW(13) Then
            ValidationForCharacter(e, txtName)
        Else
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtIssueNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIssueNo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        Else
            ValidationForNumaricDataFromKeyBoaer(e, txtIssueNo)
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompany.KeyPress, txtDateOfEntry.KeyPress, txtLastOrderDate.KeyPress, txtCardHolder.KeyPress, txtCreditCard.KeyPress, txtValidFrom.KeyPress, txtExpiryDate.KeyPress, txtFaxNo.KeyPress, txtMobile.KeyPress, txtBillAddress.KeyPress, txtEmail.KeyPress, txtURL.KeyPress, txtComments.KeyPress, txtDriverDic.KeyPress, txtReviews.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPhoneNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            If Len(Trim(txtPhoneNumber.Text)) > 0 And Len(Trim(txtPostCode.Text)) <= 0 Then
                SearchCustomer()
            End If
        End If
    End Sub

    Private Function SearchCustomerFromAFD()
        Dim strAddress As String
        Dim details As New afdAPI.afdAddressData
        Dim retVal As Long

        Dim afdObj As afdAPI
        afdObj = New afdAPI

        ' Set the lookup
        details.Lookup = txtPostCode.Text ' Change txtLookup to your lookup entry textbox      ' Carry out the lookup (no need to alter the line below, unless you want to add a sector skip option - see constants)
        ' Where multiple results exist the user will be prompted to select the required record
        retVal = afdObj.AFDData(afdAPI.afdFieldSpec, afdAPI.AFD_POSTCODE_LOOKUP + afdAPI.AFD_LIST_BOX, details)

        ' Abort with Message if error or user cancelled
        If retVal < 0 Then
            If retVal <> -99 Then ' User Cancelled
                MsgBox(afdObj.AFDErrorText(retVal))
            End If
            Exit Function
        End If

        ' Display any changed postcode if applicable
        If details.PostcodeFrom <> "" Then
            MsgBox("Postcode has changed from " + details.PostcodeFrom + " to " + details.Postcode)
        End If

        ' Now Assign required fields to your application
        ' These are any of the members of the details. structure
        txtCompany.Text = details.Organisation
        txtTown.Text = details.Town
        txtPostCode.Text = details.Postcode

        txtName.Text = details.Name
        strAddress = details.Street & vbNewLine & details.Locality
        txtAddress.Text = strAddress
    End Function

    Private Sub txtPostCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPostCode.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            If Len(Trim(txtPostCode.Text)) > 0 Then
                SearchCustomerFromAFD()
            End If
        End If
    End Sub

    Private Sub Button_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdministrate.KeyPress, btnPayment.KeyPress, btnSubmit.KeyPress, btCanceOrder.KeyPress, btnDine.KeyPress, btnKeyBoard.KeyPress, btnClear.KeyPress, btnRemove.KeyPress, btnRefreshMenu.KeyPress, btn1.KeyPress, btn2.KeyPress, btn3.KeyPress, btn4.KeyPress, btn5.KeyPress, btn6.KeyPress, btn7.KeyPress, btn8.KeyPress, btn9.KeyPress, btn0.KeyPress, btnDot.KeyPress, btnMultiply.KeyPress, btnBckSpace.KeyPress, btnDelete.KeyPress, btnAdd.KeyPress, btnLevelPrint.KeyPress, btnKitchPrint.KeyPress, btBillPrint.KeyPress, btnAllPrint.KeyPress, btnPay.KeyPress, btntillOpen.KeyPress, btnwaitingCust.KeyPress, btnCollection.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtChange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChange.TextChanged
        EnablePaymentButton()
    End Sub

    Private Sub frmTakeaway_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub cboDriverNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDriverNumber.SelectedIndexChanged
        If bCboLoad = False Then
            If Trim(cboDriverNumber.Text) <> vbNullString Then
                txtDriverName.Text = Trim(cboDriverNumber.SelectedValue)
            End If
        End If
    End Sub

    Private Function Printlevel()
        Dim strItemName As String

        Dim iItemCount As Integer
        Dim iIndex As Integer


        Dim objPrintDirect As New PrintDirect
        Dim offPrintDialog As New StandardPrintController

        iItemCount = lvOrder.Items.Count
        If iItemCount > 0 Then
            If mdConfiguration.sLevelPrinter <> vbNullString Then
                For iIndex = 0 To iItemCount - 1
                    strItemName = lvOrder.Items(iIndex).SubItems(2).Text + vbNewLine + vbNewLine + vbNewLine + vbNewLine + vbNewLine + vbNewLine + vbNewLine + vbNewLine + "."
                    objPrintDirect.LevelPrint(mdConfiguration.sLevelPrinter, strItemName)
                    'objPrintDirect.OnCutter(mdConfiguration.sLevelPrinter)
                Next
            Else
                'MsgBox("Please select a LABEL Printer.", MsgBoxStyle.Information, "Takeaway")
            End If
        End If
    End Function

    Private Sub btnLevelPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevelPrint.Click
        Me.lvOrder.Sorting = SortOrder.Ascending
        If lvOrder.Items.Count = 0 Then
            MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "eRestaurant", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            btnLevelPrint.Enabled = False
            If lvOrder.CheckBoxes = True Then       'btnSubmit.Text = "Update" Then "for new button in london on 1.02.08
                Call UpdateOrder()
                If bPrint = True Then
                    Printlevel()
                End If
            ElseIf lvOrder.CheckBoxes = False Then     'btnSubmit.Text = "Submit" Then "for new button in london on 1.02.08
                SubmitOrder()
                If bPrint = True Then
                    'showOredInfo()
                    Printlevel()
                    btnSubmit.Text = "Update"
                End If
            Else
                Printlevel()
            End If
        End If
        'End If
        'End If
        Me.Dispose()
        Dim frmNew As New frmTakeaway
        frmNew.Show()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim Itype As Integer
        Itype = MsgBox("Do you  want to Exit", MsgBoxStyle.YesNo, "eRestuarant")
        If Itype = MsgBoxResult.Yes Then
            Application.Exit()
            Dim thisProcess = Process.GetCurrentProcess
            thisProcess.Kill()
        End If

    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cboDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDiscount.GotFocus
        conControlName = cboDiscount
        CalculateDiscoutAmount()
    End Sub

    Private Sub cboTips_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTips.GotFocus
        conControlName = cboTips
        CalculateTipsAmount()
    End Sub

    Private Sub btntillOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntillOpen.Click
        Dim objPrintDirect As New PrintDirect
        objPrintDirect.OpenCashDrawer(mdConfiguration.sBillPrinter)
    End Sub

    'AxActiveCID1_OnError
    Private Sub AxActiveCID1_OnError(ByVal sender As Object, ByVal e As AxActiveCIDctl.__ActiveCID_OnErrorEvent) Handles AxActiveCID1.OnError
        gError = True

        Select Case e.nError
            Case e.nError.CidCommError
                ' comms error
                MsgBox(DateTime.Parse(DateTime.Now).ToString("dd/MM/yyyy tt") + "  " + "Comms error (" + e.sDescription + ")")
            Case e.nError.CidUnexpectedError
                ' unexpected error
                MsgBox(DateTime.Parse(DateTime.Now).ToString("dd/MM/yyyy tt") + "  " + "Unexpected error (" + e.sDescription + ")")
        End Select
    End Sub

    'AxActiveCID1_IncomingCall   
    Private Sub AxActiveCID1_IncomingCall(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxActiveCID1.IncomingCall
        Dim sTemp As String
        gError = False
        If Not gError Then
            Select Case AxActiveCID1.CurrentCallStatus
                Case AxActiveCID1.CurrentCallStatus.CidCallWithCID
                    Select Case AxActiveCID1.ReasonNoNumber
                        Case AxActiveCID1.ReasonNoNumber.CidUnavailable
                        Case AxActiveCID1.ReasonNoNumber.CidWithheld
                        Case Else
                            txtPhoneNumber.Text = AxActiveCID1.PhoneNumber
                            SearchCustomer()
                            Select Case AxActiveCID1.CallType
                                Case AxActiveCID1.CallType.CidVoiceCall
                                Case AxActiveCID1.CallType.CidRingBack
                                Case AxActiveCID1.CallType.CidMessageWaiting
                            End Select
                            Select Case AxActiveCID1.ReasonNoName
                                Case AxActiveCID1.ReasonNoName.CidUnavailable
                                Case AxActiveCID1.ReasonNoName.CidWithheld
                            End Select
                    End Select
                Case AxActiveCID1.CurrentCallStatus.CidCallWithNoCID
                Case AxActiveCID1.CurrentCallStatus.CidRing
                Case AxActiveCID1.CurrentCallStatus.CidDigitPressed
                Case AxActiveCID1.CurrentCallStatus.CidCallAnswered
                Case AxActiveCID1.CurrentCallStatus.CidCallComplete
            End Select
        End If
    End Sub

    Private Sub btnUpItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpItem.Click
        Dim iUpYaxes As Integer
        If Me.xpndLstScnd.AutoScroll = True Then
            iUpYaxes = Math.Abs(Me.xpndLstScnd.AutoScrollPosition.Y)
            iUpYaxes -= 100
            Me.xpndLstScnd.AutoScrollPosition = New Point(0, iUpYaxes)
        End If
    End Sub


    Private Sub btnDownItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownItem.Click
        Dim iUpYaxes As Integer
        If Me.xpndLstScnd.AutoScroll = True Then
            iUpYaxes = Math.Abs(Me.xpndLstScnd.AutoScrollPosition.Y)
            iUpYaxes += 100
            Me.xpndLstScnd.AutoScrollPosition = New Point(0, iUpYaxes)
        End If
    End Sub

    Private Sub btnUpType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpType.Click
        Dim iUpYaxes As Integer
        If Me.xpnLstMain.AutoScroll = True Then
            iUpYaxes = Math.Abs(Me.xpnLstMain.AutoScrollPosition.Y)
            iUpYaxes -= 100
            Me.xpnLstMain.AutoScrollPosition = New Point(0, iUpYaxes)
        End If
    End Sub

    Private Sub btnDownType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownType.Click
        Dim iUpYaxes As Integer
        If Me.xpnLstMain.AutoScroll = True Then
            iUpYaxes = Math.Abs(Me.xpnLstMain.AutoScrollPosition.Y)
            iUpYaxes += 100
            Me.xpnLstMain.AutoScrollPosition = New Point(0, iUpYaxes)
        End If
    End Sub

    Private Sub btnwaitingCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwaitingCust.Click
        If chkBoxWaitingCust.Checked = False Then
            chkBoxWaitingCust.Checked = True
            btnwaitingCust.Enabled = False
            SetEnablePropertyFalse(gbBasicInfo) 'Should be change
            'txtCustomerNo.Enabled = False
            txtName.Enabled = True
            txtName.Focus()
            SetEnablePropertyFalse(gbAdditionalInformation)
            cboDriverNumber.Enabled = False
            If Trim(mdConfiguration.strResturantName) = vbNullString Then
                stxtMain.ScrollText = "UySys eRestuarant " & ": Takeaway" & "-Waiting Customer"
            Else
                stxtMain.ScrollText = mdConfiguration.strResturantName & ": Takeaway" & "-Waiting Customer"
            End If
        Else
            Me.Dispose()
            Dim frmNew As New frmTakeaway
            frmNew.Show()
        End If
    End Sub

    Private Sub MacButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MacButton1.Click
        Dim ofrmAddMiscellaneousItem As New frmAddMis
        ofrmAddMiscellaneousItem.Show()
    End Sub

    Private Function UpdateOrder()

        Dim strSQLUpdateCust_Info As String
        Dim strSQLUpdatePaymentInfo As String
        Dim strSQLDeleteOrderedItem As String
        Dim strSQLInsertOrder_Info As String
        Dim strSQLUpdateTableInfo As String
        Dim strSQLUpdateStock_Info As String
        Dim strSQLTable_Info As String
        Dim sInstruction As String

        Dim iIndex As Integer
        Dim icountLVRow As Integer
        Dim iQuantity As Integer
        Dim iQuantityInHand As Integer
        Dim iCurrentStock As Integer
        Dim iItemId As Integer
        ' Dim iTableId As Integer

        Dim dTotalPricePerItem As Double
        Dim dUnitPrice As Double
        Dim dTotalPrice As Double
        Dim dDiscount As Double
        Dim dTips As Double
        Dim dNetPrice As Double
        Dim blnTrans As Boolean

        Dim strImageName As String = "skin1.bmp"
        Dim strTitel As String = "Save Message"
        Dim strMessage As String = "Your Order has been updated Successfully"
        Dim recTitleRectangle As New Rectangle(148, 50, 200, 28)
        Dim recTextRectangle As New Rectangle(90, 92, 200, 55)
        Dim pClosingPoint As New Point(280, 58)

        Me.lvOrder.Sorting = SortOrder.Ascending

        Dim cmdUpdate As SqlClient.SqlCommand
        Dim tnsAll As SqlClient.SqlTransaction

        'If CheckValidate() = False Then
        '    Exit Function
        'End If

        dTotalPrice = GetTotalPrice()
        dDiscount = GetDiscount()
        dTips = GetTips()
        dNetPrice = GetNetpay()
        ' iTableId = Trim(txtTableId.Text)

        icountLVRow = lvOrder.Items.Count

        If icountLVRow = 0 Then
            MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If

        If iOrderId = 0 Then
            Dim dsItemInfo As DataSet
            Dim daItemInfo As SqlClient.SqlDataAdapter

            Dim strSQL As String
            strSQL = "  select max(nOrder_Id) from tOrder_Payment "
            Try
                dsItemInfo = New DataSet("OrderId")
                daItemInfo = New SqlClient.SqlDataAdapter(strSQL, connRestuarant)
                daItemInfo.Fill(dsItemInfo, "OrderId")
                iOrderId = CInt(dsItemInfo.Tables("OrderId").Rows(0).Item(0))
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If

        strSQLUpdateCust_Info = "UPDATE tCust_Info SET cCust_Name='" & (txtName.Text) & _
                                "',cCompany= '" & Trim(txtCompany.Text) & "',dCust_EntryDate=GETDATE()," & _
                                "cEmail='" & Trim(txtEmail.Text) & "',cComment='" & Trim(txtComments.Text) & _
                                "',cUserId= '" & user & "',cTermenal='" & sTerminal & _
                                "',dAccessTime=GETDATE()WHERE nCust_Id=" & CStr(txtCustomerNo.Text) & ""

        'strSQLUpdatePaymentInfo = "UPDATE tOrder_Payment SET dOrder_date=GETDATE(),nTable_Id= 0,nNumberofGuests= 0 ,mTotalPrice=" & CStr(dTotalPrice) & _
        '                          ",mDiscount=" & CStr(dDiscount) & ",mService_Charge=" & CStr(dTips) & _
        '                          ",mNetpay=" & CStr(dNetPrice) & ",nOrderStatus=0,cUserId= '" & user & _
        '                          "',cTerminal='" & sTerminal & "' WHERE nOrder_Id=" & CStr(iOrderId) & _
        '                          " AND nCust_Id=" & CStr(Trim(txtCustomerNo.Text)) & ""                                       'cnaged milton 25.08.07

        strSQLUpdatePaymentInfo = "UPDATE tOrder_Payment SET dOrder_date=GETDATE(),nTable_Id= 0,nNumberofGuests= 0 ,mTotalPrice=" & CStr(dTotalPrice) & _
                          ",mDiscount=" & CStr(dDiscount) & ",mService_Charge=" & CStr(dTips) & _
                          ",mNetpay=" & CStr(dNetPrice) & ",nOrderStatus=0,cUserId= '" & user & _
                          "',cTerminal='" & sTerminal & "',perdiscount='" & Trim(cboDiscount.Text) & "',perservice='" & Trim(cboTips.Text) & "' WHERE nOrder_Id=" & CStr(iOrderId) & _
                          " AND nCust_Id=" & CStr(Trim(txtCustomerNo.Text)) & ""


        strSQLDeleteOrderedItem = "DELETE FROM tOrdered_Item WHERE nOrder_Id=" & CStr(iOrderId) & ""
        'strSQLUpdateTableInfo = "UPDATE tTable_Info SET nStatus=0 WHERE nTable_Id=00"
        'strSQLTable_Info = "UPDATE tTable_Info SET nStatus=1 WHERE nTable_Id=00"

        Try
            If icountLVRow > 0 Then

                cmdUpdate = New SqlClient.SqlCommand
                tnsAll = mdDBConnection.connRestuarant.BeginTransaction()
                blnTrans = True
                cmdUpdate.Transaction = tnsAll
                cmdUpdate.Connection = mdDBConnection.connRestuarant

                cmdUpdate.CommandText = strSQLUpdateCust_Info
                cmdUpdate.ExecuteNonQuery()

                cmdUpdate.CommandText = strSQLUpdatePaymentInfo
                cmdUpdate.ExecuteNonQuery()

                cmdUpdate.CommandText = strSQLDeleteOrderedItem
                cmdUpdate.ExecuteNonQuery()

                For iIndex = 0 To icountLVRow - 1
                    iQuantity = lvOrder.Items(iIndex).SubItems(1).Text
                    dTotalPricePerItem = lvOrder.Items(iIndex).SubItems(3).Text
                    dUnitPrice = dTotalPricePerItem / iQuantity
                    sInstruction = lvOrder.Items(iIndex).SubItems(4).Text
                    iItemId = lvOrder.Items(iIndex).SubItems(5).Text
                    iQuantityInHand = lvOrder.Items(iIndex).SubItems(6).Text

                    strSQLInsertOrder_Info = "INSERT INTO tOrdered_Item VALUES(" & CStr(iOrderId) & _
                                             "," & CStr(iItemId) & "," & CStr(dUnitPrice) & _
                                             "," & CStr(iQuantity) & ",'" & sInstruction & "','" & user & _
                                             "','" & sTerminal & "',GETDATE())"

                    iCurrentStock = iQuantityInHand - iQuantity

                    'If iCurrentStock >= 0 Then [Commented for Client's requirement]
                    strSQLUpdateStock_Info = "UPDATE tItem SET nItem_Stock=" + CStr(iCurrentStock) + " WHERE nItem_Id=" + CStr(iItemId) + ""

                    cmdUpdate.CommandText = strSQLUpdateStock_Info
                    cmdUpdate.ExecuteNonQuery()
                    'End If

                    cmdUpdate.CommandText = strSQLInsertOrder_Info
                    cmdUpdate.ExecuteNonQuery()
                Next
            End If
        Catch ex As Exception
            If blnTrans = True Then
                tnsAll.Rollback()
                blnTrans = False
                MsgBox("This error Occurred for: ", MsgBoxStyle.Critical, "Database Error")
                Exit Function
            End If
        Finally
            If blnTrans = True Then
                'If MessageBox.Show("Do you want to update the order with" & "customer ID:" & txtCustomerNo.Text & " and Order ID:" & iOrderId, "Takeaway", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                tnsAll.Commit()
                blnTrans = False
                bPrint = True
                txtCustomerNo.Tag = iOrderId
                ' PutDataIntoOrderInfoo(Trim(txtCustomerNo.Tag))
                'ShowTaskBarNotifire(strImageName, strTitel, strMessage, recTitleRectangle, recTextRectangle, pClosingPoint)
                'Else
                'tnsAll.Rollback()
                'blnTrans = False
                'End If
            End If
        End Try
    End Function

    Private Function OpenCashDrawer()
        Dim objPrintDirect As New PrintDirect
        objPrintDirect.OpenCashDrawer(mdConfiguration.sBillPrinter)
    End Function

    Private Sub PutDataIntoOrderInfoo(ByVal tmpOrderId As Integer)

        Dim strSQL As String
        Dim iCountDataSetRow As Integer
        Dim iIndex As Integer
        Dim iItemQuantity As Integer

        Dim dUnitPrice As Double
        Dim dTotalPrice As Double

        Dim dsOrderInfo As DataSet
        Dim daOrderInfo As SqlClient.SqlDataAdapter

        'strSQL = "SELECT O.nItem_Qty,I.cItem_SC,I.mTakeawayPrice,O.cInstruction,O.nItem_Id,I.nItem_Stock," & _
        '         "I.cItem_ServeLoc,T.cType_Name FROM tOrdered_Item O,tItem I, tType T " & _
        '         "WHERE O.nOrder_Id=" + CStr(tmpOrderId) + " AND O.nItem_Id=I.nItem_Id AND " & _
        '         "I.nType_Id=T.nType_Id ORDER BY O.nItem_Id"

        strSQL = "SELECT O.nItem_Qty,I.cItem_SC,I.mTakeawayPrice,O.cInstruction,O.nItem_Id," & _
                 "I.nItem_Stock,I.cItem_ServeLoc,T.cType_Name FROM tOrdered_Item O,tItem I, tType T " & _
                 "WHERE O.nOrder_Id=" + CStr(iOrderId) + " AND O.nItem_Id=I.nItem_Id AND" & _
                 " I.nType_Id=T.nType_Id ORDER BY O.nItem_Id"


        Try
            dsOrderInfo = New DataSet("OrderInfo")
            daOrderInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daOrderInfo.Fill(dsOrderInfo, "OrderInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsOrderInfo.Tables("OrderInfo").Rows.Count

        lvOrder.Items.Clear()

        If iCountDataSetRow > 0 Then
            lvOrder.CheckBoxes = True
            For iIndex = 0 To iCountDataSetRow - 1
                lvOrder.Items.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(0))
                'lvOrder.Items(iIndex).SubItems.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(0)) 'For add Item Qty In Ordered Item ListView
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(1))) 'For add Item Name In Ordered Item ListView
                iItemQuantity = CInt(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(0)))
                dUnitPrice = CDbl(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(2)))
                dTotalPrice = iItemQuantity * dUnitPrice 'For Calculating Item Total price For a specific Item In Ordered Item ListView
                lvOrder.Items(iIndex).SubItems.Add(FormatCurrency(dTotalPrice)) 'For adding Item Total price For a specific Item In Ordered Item ListView

                If dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(3) <> vbNullString Then 'For adding Instruction For a specific Item In Ordered Item ListView
                    lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(3)))
                Else
                    lvOrder.Items(iIndex).SubItems.Add("")
                End If
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(4))) 'For adding Item Id In Ordered Item ListView 
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(5))) 'For adding Item Quantity In Hand In Ordered Item ListView
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(6))) 'For adding Item Serve Location
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(7))) 'For adding Type Name
                'lvOrder.Items(iIndex).Checked = False
            Next
        Else
            MessageBox.Show("There is no Order information against this order", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dsOrderInfo = Nothing
        daOrderInfo = Nothing
    End Sub

    Private Sub btnRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefund.Click
        'Call PrintBill()
        Dim objfrm As New frmBillSplitting
        objfrm.Show()

    End Sub

    Public Function PaymentStatusPurpose()

        Dim iCustomerId As Integer
        Dim strSQLCust_Info As String
        Dim strSQLOrder_Info As String
        Dim strSQLPayment_Info As String

        ' Dim iOrderIdd As String

        iCustomerId = strfindDesc
        iOrderId = strfindcode

        strSQLCust_Info = "SELECT nCust_Id,cCust_Name,cPhnNo,cPostCode,cAddress,cCompany,dCust_EntryDate," & _
                          "dLstOrdrDate,cCust_BillAdd,cEmail,cURL,cCust_Fax,cCust_Mobile,cComment," & _
                          "cDriverDirection,cReview,cCardHolder,cCardNo,nIssueNo,dValidfrom,dExpiryDate,cCity,nDriverNumber" & _
                          " FROM tCust_Info WHERE nCust_Id=" + CStr(iCustomerId) + ""

        txtCustomerNo.Tag = iOrderId

        PutDataIntoCustomerInfo(strSQLCust_Info)

        strSQLOrder_Info = "SELECT O.nItem_Qty,I.cItem_SC,I.mTakeawayPrice,O.cInstruction,O.nItem_Id," & _
                           "I.nItem_Stock,I.cItem_ServeLoc,T.cType_Name FROM tOrdered_Item O,tItem I, tType T " & _
                           "WHERE O.nOrder_Id=" + CStr(iOrderId) + " AND O.nItem_Id=I.nItem_Id AND" & _
                           " I.nType_Id=T.nType_Id ORDER BY O.nItem_Id"

        PutDataIntoOrderInfo(strSQLOrder_Info)

        strSQLPayment_Info = "SELECT mTotalPrice,mDiscount,mService_Charge,mNetpay,mCashPayAmount," & _
                             "mCardPayAmount,cCardType,mChequeAmount,cChequeNumber,cBankName,perdiscount,perservice " & _
                             "FROM tOrder_Payment WHERE nOrder_Id=" + CStr(iOrderId) + ""
        PutDataIntoPaymentInfo(strSQLPayment_Info)

    End Function

    Private Sub cboDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDiscount.TextChanged
        CalculateDiscoutAmount()
    End Sub

    Private Sub cboTips_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTips.TextChanged

        CalculateTipsAmount()

    End Sub

    'Private Sub lvOrder_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvOrder.DoubleClick

    '    Dim ofrmTopping As New frmToppingTakeway
    '    ofrmTopping.frmToppingTakeaway(Me)
    '    Dim b As String
    '    Dim c As Double
    '    Dim d As Integer

    '    b = Me.lvOrder.SelectedItems(0).SubItems(1).Text
    '    c = Me.lvOrder.SelectedItems(0).SubItems(2).Text
    '    d = Me.lvOrder.SelectedItems(0).SubItems(4).Text
    '    ofrmTopping.IteamCollect(b, c, d)
    '    ofrmTopping.Show()
    '    CalculateTopingPrice()


    'End Sub

    Public Function addtoping(ByVal TopIteam As String)

        Me.lvOrder.SelectedItems(0).SubItems(3).Text = TopIteam

    End Function

    Public Function CalculateTopingPrice()
        Dim i As Integer
        Dim dTotalPrice As Double
        i = 0
        dTotalPrice = 0

        For i = 1 To lvOrder.Items.Count
            dTotalPrice = dTotalPrice + CDbl(lvOrder.Items(i - 1).SubItems(2).Text)
        Next

        If dTotalPrice = 0 Then
            lblTotalOrderPrice.Text = ""
        Else
            lblTotalOrderPrice.Text = FormatCurrency(dTotalPrice)
            txtNetPay.Text = lblTotalOrderPrice.Text               'new added 'milton 21-05-07'
        End If
    End Function

    Private Sub txtCashPay_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCashPay.DoubleClick
        txtCashPay.Text = ""
    End Sub

    Private Sub txtCardPay_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCardPay.DoubleClick
        txtCardPay.Text = ""
    End Sub

    Private Sub txtChequePay_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequePay.DoubleClick
        txtChequePay.Text = ""
    End Sub

    Private Function autocash()
        If txtCardPay.Text = vbNullString And txtChequePay.Text = vbNullString Then
            txtCashPay.Text = txtNetPay.Text
        Else
            If txtCardPay.Text = vbNullString Then
                txtCashPay.Text = txtNetPay.Text - CDbl(txtChequePay.Text)
            ElseIf txtChequePay.Text = vbNullString Then
                txtCashPay.Text = txtNetPay.Text - CDbl(txtCardPay.Text)
            Else
                If txtNetPay.Text > (CDbl(txtCardPay.Text) + CDbl(txtChequePay.Text)) Then
                    txtCashPay.Text = txtNetPay.Text - (CDbl(txtCardPay.Text) + CDbl(txtChequePay.Text))
                End If

            End If
        End If
    End Function

    Private Function autocard()

        If txtCashPay.Text = vbNullString And txtChequePay.Text = vbNullString Then
            txtCardPay.Text = txtNetPay.Text
        Else
            If txtCashPay.Text = vbNullString Then
                txtCardPay.Text = txtNetPay.Text - CDbl(txtChequePay.Text)
            ElseIf txtChequePay.Text = vbNullString Then
                txtCardPay.Text = txtNetPay.Text - CDbl(txtCashPay.Text)
            Else
                If txtNetPay.Text > (CDbl(txtCashPay.Text) + CDbl(txtChequePay.Text)) Then
                    txtCardPay.Text = txtNetPay.Text - (CDbl(txtCashPay.Text) + CDbl(txtChequePay.Text))
                End If

            End If

        End If

    End Function

    Private Function autocheque()

        If txtCashPay.Text = vbNullString And txtCardPay.Text = vbNullString Then
            txtChequePay.Text = txtNetPay.Text
        Else
            If txtCashPay.Text = vbNullString Then
                txtChequePay.Text = txtNetPay.Text - CDbl(txtCardPay.Text)
            ElseIf txtCardPay.Text = vbNullString Then
                txtChequePay.Text = txtNetPay.Text - CDbl(txtCashPay.Text)
            Else
                If txtNetPay.Text < (CDbl(txtCashPay.Text) + CDbl(txtCardPay.Text)) Then
                    txtChequePay.Text = ""
                Else
                    If txtNetPay.Text > (CDbl(txtCashPay.Text) + CDbl(txtCardPay.Text)) Then
                        txtChequePay.Text = txtNetPay.Text - (CDbl(txtCashPay.Text) + CDbl(txtCardPay.Text))
                    End If

                End If

            End If

        End If
    End Function

    Private Sub txtNetPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNetPay.TextChanged

        Dim b As String
        Dim c As String
        Dim f As String
        Dim g As String
        Dim h As String

        b = lblTotalOrderPrice.Text
        If btnKitchPrint.Enabled = True Then
            c = b
        ElseIf btnLevelPrint.Enabled = True Then
            f = b
        ElseIf btBillPrint.Enabled = True Then
            g = b
        ElseIf btnAllPrint.Enabled = True Then
            h = b
        End If
        If c <> b Then
            btnKitchPrint.Enabled = True
        End If

        If f <> b Then
            btnLevelPrint.Enabled = True
        End If

        If g <> b Then
            btBillPrint.Enabled = True
        End If

        If h <> b Then
            btnAllPrint.Enabled = True
        End If

    End Sub

    'new add for totlaItem show(25.10.07)
    Private Function calculatetotalItem()
        Dim b As Integer
        Dim h As String
        b = lvOrder.Items.Count
        lbQty.Text = b

    End Function

    Private Sub chkReprintWAY_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkReprintWAY.Click
        Dim iItemCount As Integer
        Dim iIndex As Integer
        iItemCount = lvOrder.Items.Count
        If iItemCount > 0 Then
            If lvOrder.CheckBoxes = True Then
                If chkReprintWAY.Checked = True Then
                    For iIndex = 0 To iItemCount - 1
                        If lvOrder.Items(iIndex).Checked = False Then
                            lvOrder.Items(iIndex).Checked = True
                        End If
                    Next
                Else
                    For iIndex = 0 To iItemCount - 1
                        If lvOrder.Items(iIndex).Checked = True Then
                            lvOrder.Items(iIndex).Checked = False
                        End If
                    Next
                End If
            End If
        End If

    End Sub

    Private Sub txtDateOfEntry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateOfEntry.TextChanged

    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        MsgBox("THIS PAGE UNDER DEVELOPMENT")
    End Sub

    Private Sub stxtMain_TextClicked(ByVal sender As System.Object, ByVal args As System.EventArgs) Handles stxtMain.TextClicked

    End Sub
End Class



