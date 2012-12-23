Imports System.Globalization
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmDine
    Inherits System.Windows.Forms.Form

    Dim iOrderId As Integer

    Dim dblFirstValue As Double
    Dim dblSecondValue As Double
    Dim blnEnterPress As Boolean

    Private bPrint As Boolean = False

    Dim strItemInfo(,) As String

    Dim conControlName As Control
    Dim objfrmKeyBoard As New frmKeyBoard
    Dim bCboLoad As Boolean
    Dim bClickedBefore As Boolean = False
    Dim strClickTypeName As String
    Dim strNewClickType As String
    Dim iCustomerId As Integer
    Dim bcash As String
    Dim bcard As String
    Dim fcash As String
    Dim fcard As String
    Dim fcheque As String



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
    Friend WithEvents tabTakeaway As System.Windows.Forms.TabControl
    Friend WithEvents tbpgCustInfo As System.Windows.Forms.TabPage
    Friend WithEvents gbBasicInfo As System.Windows.Forms.GroupBox
    Friend WithEvents tbpgPayment As System.Windows.Forms.TabPage
    Friend WithEvents gbPaymentInformation As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents gbPrintOrder As System.Windows.Forms.GroupBox
    Friend WithEvents gbPriceCalculation As System.Windows.Forms.GroupBox
    Friend WithEvents gbPriceInformation As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtGuestNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTableId As System.Windows.Forms.TextBox
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnAdministrate As MACButtonLib.MACButton
    Friend WithEvents btnPayment As MACButtonLib.MACButton
    Friend WithEvents btnSubmit As MACButtonLib.MACButton
    Friend WithEvents btCanceOrder As MACButtonLib.MACButton
    Friend WithEvents btnTakeaway As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    Friend WithEvents btnClear As MACButtonLib.MACButton
    Friend WithEvents btTblSelect As MACButtonLib.MACButton
    Friend WithEvents btn2 As MACButtonLib.MACButton
    Friend WithEvents btn4 As MACButtonLib.MACButton
    Friend WithEvents btn3 As MACButtonLib.MACButton
    Friend WithEvents btn8 As MACButtonLib.MACButton
    Friend WithEvents btn7 As MACButtonLib.MACButton
    Friend WithEvents btn6 As MACButtonLib.MACButton
    Friend WithEvents btn5 As MACButtonLib.MACButton
    Friend WithEvents btnDot As MACButtonLib.MACButton
    Friend WithEvents btn0 As MACButtonLib.MACButton
    Friend WithEvents btn9 As MACButtonLib.MACButton
    Friend WithEvents btnMultiply As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnBckSpace As MACButtonLib.MACButton
    Friend WithEvents btnAllPrint As MACButtonLib.MACButton
    Friend WithEvents btBillPrint As MACButtonLib.MACButton
    Friend WithEvents btnLevelPrint As MACButtonLib.MACButton
    Friend WithEvents btnPay As MACButtonLib.MACButton
    Friend WithEvents btntillOpen As MACButtonLib.MACButton
    Friend WithEvents stxtMain As ScrollingTextControl.ScrollingText
    Friend WithEvents btnCancel As MACButtonLib.MACButton
    Friend WithEvents btnNine As MACButtonLib.MACButton
    Friend WithEvents btnEight As MACButtonLib.MACButton
    Friend WithEvents btnSeven As MACButtonLib.MACButton
    Friend WithEvents btnSix As MACButtonLib.MACButton
    Friend WithEvents btnFive As MACButtonLib.MACButton
    Friend WithEvents btnFour As MACButtonLib.MACButton
    Friend WithEvents btnThree As MACButtonLib.MACButton
    Friend WithEvents btnTwo As MACButtonLib.MACButton
    Friend WithEvents btnOne As MACButtonLib.MACButton
    Friend WithEvents btnBackSpace As MACButtonLib.MACButton
    Friend WithEvents btnZero As MACButtonLib.MACButton
    Friend WithEvents btnMinimize As MACButtonLib.MACButton
    Friend WithEvents txtTableNo As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As MACButtonLib.MACButton
    Friend WithEvents txtPDAPrint As MACButtonLib.MACButton
    Friend WithEvents btnPayBill As MACButtonLib.MACButton
    Friend WithEvents MacButton1 As MACButtonLib.MACButton
    Friend WithEvents btnRefund As MACButtonLib.MACButton
    Friend WithEvents txtnOrderId As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents xpnLstMain As XPanderControl.XPanderList
    Friend WithEvents lbQty As System.Windows.Forms.Label
    Friend WithEvents lbTotalQty As System.Windows.Forms.Label
    Friend WithEvents chkReprint As System.Windows.Forms.CheckBox
    Friend WithEvents btnRefreshMenu As MACButtonLib.MACButton
    Friend WithEvents btnRemove As MACButtonLib.MACButton
    Friend WithEvents lblTotalOrderPrice As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lvOrder As System.Windows.Forms.ListView
    Friend WithEvents cCheckBox As System.Windows.Forms.ColumnHeader
    Friend WithEvents cQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents cItem As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents cInstruction As System.Windows.Forms.ColumnHeader
    Friend WithEvents cItemId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cStockInHand As System.Windows.Forms.ColumnHeader
    Friend WithEvents cServeLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTypeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboInstruction As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnKitchPrint As MACButtonLib.MACButton
    Friend WithEvents lblTotalPrice As System.Windows.Forms.TabPage
    Friend WithEvents xpndLstScnd As XPanderControl.XPanderList
    Friend WithEvents xpndrItems As XPanderControl.XPander
    Friend WithEvents btnUpType As MACButtonLib.MACButton
    Friend WithEvents btnDownType As MACButtonLib.MACButton
    Friend WithEvents btnUpItem As MACButtonLib.MACButton
    Friend WithEvents btnDownItem As MACButtonLib.MACButton
    Friend WithEvents txtUpdate As System.Windows.Forms.TextBox
    Friend WithEvents cQtyRemaning As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUser As MACButtonLib.MACButton
    Friend WithEvents nTypeId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ncatId As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDine))
        Me.tabTakeaway = New System.Windows.Forms.TabControl
        Me.tbpgCustInfo = New System.Windows.Forms.TabPage
        Me.gbBasicInfo = New System.Windows.Forms.GroupBox
        Me.txtUpdate = New System.Windows.Forms.TextBox
        Me.txtnOrderId = New System.Windows.Forms.TextBox
        Me.txtTableNo = New System.Windows.Forms.TextBox
        Me.btnBackSpace = New MACButtonLib.MACButton
        Me.btnZero = New MACButtonLib.MACButton
        Me.btnNine = New MACButtonLib.MACButton
        Me.btnEight = New MACButtonLib.MACButton
        Me.btnSeven = New MACButtonLib.MACButton
        Me.btnSix = New MACButtonLib.MACButton
        Me.btnFive = New MACButtonLib.MACButton
        Me.btnFour = New MACButtonLib.MACButton
        Me.btnThree = New MACButtonLib.MACButton
        Me.btnTwo = New MACButtonLib.MACButton
        Me.btnOne = New MACButtonLib.MACButton
        Me.btTblSelect = New MACButtonLib.MACButton
        Me.btnClear = New MACButtonLib.MACButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTableId = New System.Windows.Forms.TextBox
        Me.lblTable = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtCustomerNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtGuestNumber = New System.Windows.Forms.TextBox
        Me.lblTotalPrice = New System.Windows.Forms.TabPage
        Me.btnDownItem = New MACButtonLib.MACButton
        Me.btnUpItem = New MACButtonLib.MACButton
        Me.btnDownType = New MACButtonLib.MACButton
        Me.btnUpType = New MACButtonLib.MACButton
        Me.xpndLstScnd = New XPanderControl.XPanderList
        Me.xpndrItems = New XPanderControl.XPander
        Me.xpnLstMain = New XPanderControl.XPanderList
        Me.lbQty = New System.Windows.Forms.Label
        Me.lbTotalQty = New System.Windows.Forms.Label
        Me.chkReprint = New System.Windows.Forms.CheckBox
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
        Me.cItemId = New System.Windows.Forms.ColumnHeader
        Me.cStockInHand = New System.Windows.Forms.ColumnHeader
        Me.cServeLocation = New System.Windows.Forms.ColumnHeader
        Me.cTypeName = New System.Windows.Forms.ColumnHeader
        Me.nTypeId = New System.Windows.Forms.ColumnHeader
        Me.cQtyRemaning = New System.Windows.Forms.ColumnHeader
        Me.cboInstruction = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
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
        Me.gbPrintOrder = New System.Windows.Forms.GroupBox
        Me.btBillPrint = New MACButtonLib.MACButton
        Me.btnAllPrint = New MACButtonLib.MACButton
        Me.btnLevelPrint = New MACButtonLib.MACButton
        Me.txtPDAPrint = New MACButtonLib.MACButton
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
        Me.btntillOpen = New MACButtonLib.MACButton
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnAdministrate = New MACButtonLib.MACButton
        Me.btnPayment = New MACButtonLib.MACButton
        Me.btnSubmit = New MACButtonLib.MACButton
        Me.btCanceOrder = New MACButtonLib.MACButton
        Me.btnTakeaway = New MACButtonLib.MACButton
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.stxtMain = New ScrollingTextControl.ScrollingText
        Me.btnCancel = New MACButtonLib.MACButton
        Me.btnMinimize = New MACButtonLib.MACButton
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.btnUser = New MACButtonLib.MACButton
        Me.ncatId = New System.Windows.Forms.ColumnHeader
        Me.tabTakeaway.SuspendLayout()
        Me.tbpgCustInfo.SuspendLayout()
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
        Me.tabTakeaway.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.tabTakeaway.ImageList = Me.ImageList1
        Me.tabTakeaway.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tabTakeaway.Location = New System.Drawing.Point(4, 50)
        Me.tabTakeaway.Name = "tabTakeaway"
        Me.tabTakeaway.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabTakeaway.SelectedIndex = 0
        Me.tabTakeaway.Size = New System.Drawing.Size(792, 480)
        Me.tabTakeaway.TabIndex = 1
        '
        'tbpgCustInfo
        '
        Me.tbpgCustInfo.BackColor = System.Drawing.Color.Ivory
        Me.tbpgCustInfo.BackgroundImage = CType(resources.GetObject("tbpgCustInfo.BackgroundImage"), System.Drawing.Image)
        Me.tbpgCustInfo.Controls.Add(Me.gbBasicInfo)
        Me.tbpgCustInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbpgCustInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbpgCustInfo.ImageIndex = 0
        Me.tbpgCustInfo.Location = New System.Drawing.Point(4, 31)
        Me.tbpgCustInfo.Name = "tbpgCustInfo"
        Me.tbpgCustInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbpgCustInfo.Size = New System.Drawing.Size(784, 445)
        Me.tbpgCustInfo.TabIndex = 0
        Me.tbpgCustInfo.Text = "Customer Information    "
        '
        'gbBasicInfo
        '
        Me.gbBasicInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBasicInfo.BackColor = System.Drawing.Color.Ivory
        Me.gbBasicInfo.Controls.Add(Me.txtUpdate)
        Me.gbBasicInfo.Controls.Add(Me.txtnOrderId)
        Me.gbBasicInfo.Controls.Add(Me.txtTableNo)
        Me.gbBasicInfo.Controls.Add(Me.btnBackSpace)
        Me.gbBasicInfo.Controls.Add(Me.btnZero)
        Me.gbBasicInfo.Controls.Add(Me.btnNine)
        Me.gbBasicInfo.Controls.Add(Me.btnEight)
        Me.gbBasicInfo.Controls.Add(Me.btnSeven)
        Me.gbBasicInfo.Controls.Add(Me.btnSix)
        Me.gbBasicInfo.Controls.Add(Me.btnFive)
        Me.gbBasicInfo.Controls.Add(Me.btnFour)
        Me.gbBasicInfo.Controls.Add(Me.btnThree)
        Me.gbBasicInfo.Controls.Add(Me.btnTwo)
        Me.gbBasicInfo.Controls.Add(Me.btnOne)
        Me.gbBasicInfo.Controls.Add(Me.btTblSelect)
        Me.gbBasicInfo.Controls.Add(Me.btnClear)
        Me.gbBasicInfo.Controls.Add(Me.Label8)
        Me.gbBasicInfo.Controls.Add(Me.txtTableId)
        Me.gbBasicInfo.Controls.Add(Me.lblTable)
        Me.gbBasicInfo.Controls.Add(Me.lblEmail)
        Me.gbBasicInfo.Controls.Add(Me.txtComment)
        Me.gbBasicInfo.Controls.Add(Me.txtCompany)
        Me.gbBasicInfo.Controls.Add(Me.txtName)
        Me.gbBasicInfo.Controls.Add(Me.txtCustomerNo)
        Me.gbBasicInfo.Controls.Add(Me.Label10)
        Me.gbBasicInfo.Controls.Add(Me.Label3)
        Me.gbBasicInfo.Controls.Add(Me.Label4)
        Me.gbBasicInfo.Controls.Add(Me.Label5)
        Me.gbBasicInfo.Controls.Add(Me.txtEmail)
        Me.gbBasicInfo.Controls.Add(Me.txtGuestNumber)
        Me.gbBasicInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbBasicInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBasicInfo.ForeColor = System.Drawing.Color.Maroon
        Me.gbBasicInfo.Location = New System.Drawing.Point(51, 45)
        Me.gbBasicInfo.Name = "gbBasicInfo"
        Me.gbBasicInfo.Size = New System.Drawing.Size(685, 352)
        Me.gbBasicInfo.TabIndex = 90
        Me.gbBasicInfo.TabStop = False
        Me.gbBasicInfo.Text = "Basic Information"
        '
        'txtUpdate
        '
        Me.txtUpdate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdate.Location = New System.Drawing.Point(168, 137)
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.ReadOnly = True
        Me.txtUpdate.Size = New System.Drawing.Size(104, 22)
        Me.txtUpdate.TabIndex = 131
        Me.txtUpdate.Text = ""
        Me.txtUpdate.Visible = False
        '
        'txtnOrderId
        '
        Me.txtnOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnOrderId.Location = New System.Drawing.Point(168, 169)
        Me.txtnOrderId.Name = "txtnOrderId"
        Me.txtnOrderId.Size = New System.Drawing.Size(232, 20)
        Me.txtnOrderId.TabIndex = 129
        Me.txtnOrderId.Text = ""
        Me.txtnOrderId.Visible = False
        '
        'txtTableNo
        '
        Me.txtTableNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTableNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTableNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableNo.Location = New System.Drawing.Point(168, 137)
        Me.txtTableNo.Name = "txtTableNo"
        Me.txtTableNo.ReadOnly = True
        Me.txtTableNo.Size = New System.Drawing.Size(156, 22)
        Me.txtTableNo.TabIndex = 1
        Me.txtTableNo.Text = ""
        '
        'btnBackSpace
        '
        Me.btnBackSpace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBackSpace.BackColor = System.Drawing.Color.Transparent
        Me.btnBackSpace.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnBackSpace.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnBackSpace.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnBackSpace.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnBackSpace.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackSpace.Location = New System.Drawing.Point(508, 240)
        Me.btnBackSpace.Name = "btnBackSpace"
        Me.btnBackSpace.Size = New System.Drawing.Size(119, 56)
        Me.btnBackSpace.TabIndex = 128
        Me.btnBackSpace.Text = "BackSpace"
        Me.btnBackSpace.TextColorDefault = System.Drawing.Color.Black
        Me.btnBackSpace.TextColorDisabled = System.Drawing.Color.Black
        Me.btnBackSpace.TextColorHover = System.Drawing.Color.White
        Me.btnBackSpace.TextColorNormal = System.Drawing.Color.White
        '
        'btnZero
        '
        Me.btnZero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnZero.BackColor = System.Drawing.Color.Transparent
        Me.btnZero.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnZero.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnZero.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnZero.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnZero.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(440, 240)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(56, 56)
        Me.btnZero.TabIndex = 127
        Me.btnZero.Text = "0"
        Me.btnZero.TextColorDefault = System.Drawing.Color.Black
        Me.btnZero.TextColorDisabled = System.Drawing.Color.Black
        Me.btnZero.TextColorHover = System.Drawing.Color.White
        Me.btnZero.TextColorNormal = System.Drawing.Color.White
        '
        'btnNine
        '
        Me.btnNine.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNine.BackColor = System.Drawing.Color.Transparent
        Me.btnNine.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnNine.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnNine.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnNine.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnNine.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.Location = New System.Drawing.Point(571, 176)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(56, 56)
        Me.btnNine.TabIndex = 126
        Me.btnNine.Text = "9"
        Me.btnNine.TextColorDefault = System.Drawing.Color.Black
        Me.btnNine.TextColorDisabled = System.Drawing.Color.Black
        Me.btnNine.TextColorHover = System.Drawing.Color.White
        Me.btnNine.TextColorNormal = System.Drawing.Color.White
        '
        'btnEight
        '
        Me.btnEight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEight.BackColor = System.Drawing.Color.Transparent
        Me.btnEight.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnEight.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnEight.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnEight.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnEight.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.Location = New System.Drawing.Point(505, 176)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(56, 56)
        Me.btnEight.TabIndex = 125
        Me.btnEight.Text = "8"
        Me.btnEight.TextColorDefault = System.Drawing.Color.Black
        Me.btnEight.TextColorDisabled = System.Drawing.Color.Black
        Me.btnEight.TextColorHover = System.Drawing.Color.White
        Me.btnEight.TextColorNormal = System.Drawing.Color.White
        '
        'btnSeven
        '
        Me.btnSeven.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSeven.BackColor = System.Drawing.Color.Transparent
        Me.btnSeven.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnSeven.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnSeven.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnSeven.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnSeven.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(440, 176)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(56, 56)
        Me.btnSeven.TabIndex = 124
        Me.btnSeven.Text = "7"
        Me.btnSeven.TextColorDefault = System.Drawing.Color.Black
        Me.btnSeven.TextColorDisabled = System.Drawing.Color.Black
        Me.btnSeven.TextColorHover = System.Drawing.Color.White
        Me.btnSeven.TextColorNormal = System.Drawing.Color.White
        '
        'btnSix
        '
        Me.btnSix.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSix.BackColor = System.Drawing.Color.Transparent
        Me.btnSix.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnSix.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnSix.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnSix.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnSix.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.Location = New System.Drawing.Point(571, 112)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(56, 56)
        Me.btnSix.TabIndex = 123
        Me.btnSix.Text = "6"
        Me.btnSix.TextColorDefault = System.Drawing.Color.Black
        Me.btnSix.TextColorDisabled = System.Drawing.Color.Black
        Me.btnSix.TextColorHover = System.Drawing.Color.White
        Me.btnSix.TextColorNormal = System.Drawing.Color.White
        '
        'btnFive
        '
        Me.btnFive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFive.BackColor = System.Drawing.Color.Transparent
        Me.btnFive.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnFive.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnFive.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnFive.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnFive.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(505, 112)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(56, 56)
        Me.btnFive.TabIndex = 122
        Me.btnFive.Text = "5"
        Me.btnFive.TextColorDefault = System.Drawing.Color.Black
        Me.btnFive.TextColorDisabled = System.Drawing.Color.Black
        Me.btnFive.TextColorHover = System.Drawing.Color.White
        Me.btnFive.TextColorNormal = System.Drawing.Color.White
        '
        'btnFour
        '
        Me.btnFour.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFour.BackColor = System.Drawing.Color.Transparent
        Me.btnFour.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnFour.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnFour.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnFour.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnFour.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(440, 112)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(56, 56)
        Me.btnFour.TabIndex = 121
        Me.btnFour.Text = "4"
        Me.btnFour.TextColorDefault = System.Drawing.Color.Black
        Me.btnFour.TextColorDisabled = System.Drawing.Color.Black
        Me.btnFour.TextColorHover = System.Drawing.Color.White
        Me.btnFour.TextColorNormal = System.Drawing.Color.White
        '
        'btnThree
        '
        Me.btnThree.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnThree.BackColor = System.Drawing.Color.Transparent
        Me.btnThree.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnThree.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnThree.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnThree.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnThree.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(571, 48)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(56, 56)
        Me.btnThree.TabIndex = 120
        Me.btnThree.Text = "3"
        Me.btnThree.TextColorDefault = System.Drawing.Color.Black
        Me.btnThree.TextColorDisabled = System.Drawing.Color.Black
        Me.btnThree.TextColorHover = System.Drawing.Color.White
        Me.btnThree.TextColorNormal = System.Drawing.Color.White
        '
        'btnTwo
        '
        Me.btnTwo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTwo.BackColor = System.Drawing.Color.Transparent
        Me.btnTwo.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnTwo.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnTwo.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnTwo.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnTwo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(505, 48)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(56, 56)
        Me.btnTwo.TabIndex = 119
        Me.btnTwo.Text = "2"
        Me.btnTwo.TextColorDefault = System.Drawing.Color.Black
        Me.btnTwo.TextColorDisabled = System.Drawing.Color.Black
        Me.btnTwo.TextColorHover = System.Drawing.Color.White
        Me.btnTwo.TextColorNormal = System.Drawing.Color.White
        '
        'btnOne
        '
        Me.btnOne.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOne.BackColor = System.Drawing.Color.Transparent
        Me.btnOne.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnOne.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnOne.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnOne.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnOne.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(440, 48)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(56, 56)
        Me.btnOne.TabIndex = 118
        Me.btnOne.Text = "1"
        Me.btnOne.TextColorDefault = System.Drawing.Color.Black
        Me.btnOne.TextColorDisabled = System.Drawing.Color.Black
        Me.btnOne.TextColorHover = System.Drawing.Color.White
        Me.btnOne.TextColorNormal = System.Drawing.Color.White
        '
        'btTblSelect
        '
        Me.btTblSelect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btTblSelect.BackColor = System.Drawing.Color.Transparent
        Me.btTblSelect.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btTblSelect.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btTblSelect.ButtonColorHover = System.Drawing.Color.IndianRed
        Me.btTblSelect.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btTblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTblSelect.Location = New System.Drawing.Point(328, 128)
        Me.btTblSelect.Name = "btTblSelect"
        Me.btTblSelect.Size = New System.Drawing.Size(72, 39)
        Me.btTblSelect.TabIndex = 103
        Me.btTblSelect.Text = "Select"
        Me.btTblSelect.TextColorDefault = System.Drawing.Color.Black
        Me.btTblSelect.TextColorDisabled = System.Drawing.Color.Black
        Me.btTblSelect.TextColorHover = System.Drawing.Color.White
        Me.btTblSelect.TextColorNormal = System.Drawing.Color.White
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnClear.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnClear.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnClear.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnClear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(206, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 56)
        Me.btnClear.TabIndex = 102
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColorDefault = System.Drawing.Color.Black
        Me.btnClear.TextColorDisabled = System.Drawing.Color.Black
        Me.btnClear.TextColorHover = System.Drawing.Color.White
        Me.btnClear.TextColorNormal = System.Drawing.Color.White
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(40, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 22)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "No of Guests"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTableId
        '
        Me.txtTableId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTableId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTableId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableId.Location = New System.Drawing.Point(168, 137)
        Me.txtTableId.Name = "txtTableId"
        Me.txtTableId.ReadOnly = True
        Me.txtTableId.Size = New System.Drawing.Size(156, 22)
        Me.txtTableId.TabIndex = 45
        Me.txtTableId.Text = ""
        '
        'lblTable
        '
        Me.lblTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTable.Location = New System.Drawing.Point(40, 137)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(120, 22)
        Me.lblTable.TabIndex = 57
        Me.lblTable.Text = "Table No."
        Me.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmail.Location = New System.Drawing.Point(-368, 251)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(217, 22)
        Me.lblEmail.TabIndex = 56
        Me.lblEmail.Text = "E-mail"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEmail.Visible = False
        '
        'txtComment
        '
        Me.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(-240, 283)
        Me.txtComment.MaxLength = 50
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(240, 22)
        Me.txtComment.TabIndex = 51
        Me.txtComment.Text = ""
        Me.txtComment.Visible = False
        '
        'txtCompany
        '
        Me.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(-240, 219)
        Me.txtCompany.MaxLength = 35
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(240, 22)
        Me.txtCompany.TabIndex = 50
        Me.txtCompany.Text = ""
        Me.txtCompany.Visible = False
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(-240, 186)
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(240, 22)
        Me.txtName.TabIndex = 49
        Me.txtName.Text = ""
        Me.txtName.Visible = False
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCustomerNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNo.Location = New System.Drawing.Point(-240, 153)
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.ReadOnly = True
        Me.txtCustomerNo.Size = New System.Drawing.Size(240, 22)
        Me.txtCustomerNo.TabIndex = 48
        Me.txtCustomerNo.Text = ""
        Me.txtCustomerNo.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(-368, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(217, 22)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Comment"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(-368, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 22)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Company"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(-368, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 22)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(-368, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 22)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Customer ID."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(-240, 251)
        Me.txtEmail.MaxLength = 20
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(240, 22)
        Me.txtEmail.TabIndex = 59
        Me.txtEmail.Text = ""
        Me.txtEmail.Visible = False
        '
        'txtGuestNumber
        '
        Me.txtGuestNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuestNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestNumber.Location = New System.Drawing.Point(168, 169)
        Me.txtGuestNumber.MaxLength = 4
        Me.txtGuestNumber.Name = "txtGuestNumber"
        Me.txtGuestNumber.Size = New System.Drawing.Size(232, 22)
        Me.txtGuestNumber.TabIndex = 47
        Me.txtGuestNumber.Text = ""
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.Color.Ivory
        Me.lblTotalPrice.BackgroundImage = CType(resources.GetObject("lblTotalPrice.BackgroundImage"), System.Drawing.Image)
        Me.lblTotalPrice.Controls.Add(Me.btnDownItem)
        Me.lblTotalPrice.Controls.Add(Me.btnUpItem)
        Me.lblTotalPrice.Controls.Add(Me.btnDownType)
        Me.lblTotalPrice.Controls.Add(Me.btnUpType)
        Me.lblTotalPrice.Controls.Add(Me.xpndLstScnd)
        Me.lblTotalPrice.Controls.Add(Me.xpnLstMain)
        Me.lblTotalPrice.Controls.Add(Me.lbQty)
        Me.lblTotalPrice.Controls.Add(Me.lbTotalQty)
        Me.lblTotalPrice.Controls.Add(Me.chkReprint)
        Me.lblTotalPrice.Controls.Add(Me.btnRefreshMenu)
        Me.lblTotalPrice.Controls.Add(Me.btnRemove)
        Me.lblTotalPrice.Controls.Add(Me.lblTotalOrderPrice)
        Me.lblTotalPrice.Controls.Add(Me.Label35)
        Me.lblTotalPrice.Controls.Add(Me.Label15)
        Me.lblTotalPrice.Controls.Add(Me.lvOrder)
        Me.lblTotalPrice.Controls.Add(Me.cboInstruction)
        Me.lblTotalPrice.Controls.Add(Me.Label14)
        Me.lblTotalPrice.Controls.Add(Me.btnKitchPrint)
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ImageIndex = 1
        Me.lblTotalPrice.Location = New System.Drawing.Point(4, 31)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(784, 445)
        Me.lblTotalPrice.TabIndex = 1
        Me.lblTotalPrice.Text = "Generate Order"
        Me.lblTotalPrice.Visible = False
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
        Me.btnDownItem.Location = New System.Drawing.Point(480, 392)
        Me.btnDownItem.Name = "btnDownItem"
        Me.btnDownItem.Size = New System.Drawing.Size(48, 48)
        Me.btnDownItem.TabIndex = 142
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
        Me.btnUpItem.TabIndex = 141
        Me.btnUpItem.Text = "Up"
        Me.btnUpItem.TextColorDefault = System.Drawing.Color.Black
        Me.btnUpItem.TextColorDisabled = System.Drawing.Color.Black
        Me.btnUpItem.TextColorHover = System.Drawing.Color.White
        Me.btnUpItem.TextColorNormal = System.Drawing.Color.White
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
        Me.btnDownType.Location = New System.Drawing.Point(201, 392)
        Me.btnDownType.Name = "btnDownType"
        Me.btnDownType.Size = New System.Drawing.Size(48, 48)
        Me.btnDownType.TabIndex = 140
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
        Me.btnUpType.TabIndex = 139
        Me.btnUpType.Text = "Up"
        Me.btnUpType.TextColorDefault = System.Drawing.Color.Black
        Me.btnUpType.TextColorDisabled = System.Drawing.Color.Black
        Me.btnUpType.TextColorHover = System.Drawing.Color.White
        Me.btnUpType.TextColorNormal = System.Drawing.Color.White
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
        Me.xpndLstScnd.TabIndex = 138
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
        Me.xpndrItems.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xpndrItems.Location = New System.Drawing.Point(11, 9)
        Me.xpndrItems.Name = "xpndrItems"
        Me.xpndrItems.PaneBottomRightColor = System.Drawing.Color.Ivory
        Me.xpndrItems.PaneTopLeftColor = System.Drawing.Color.Honeydew
        Me.xpndrItems.Size = New System.Drawing.Size(221, 31)
        Me.xpndrItems.TabIndex = 33
        Me.xpndrItems.Tag = 0
        Me.xpndrItems.TooltipText = Nothing
        '
        'xpnLstMain
        '
        Me.xpnLstMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xpnLstMain.AutoScroll = True
        Me.xpnLstMain.BackColor = System.Drawing.Color.Ivory
        Me.xpnLstMain.BackColorDark = System.Drawing.Color.Ivory
        Me.xpnLstMain.BackColorLight = System.Drawing.Color.Honeydew
        Me.xpnLstMain.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xpnLstMain.Location = New System.Drawing.Point(4, 8)
        Me.xpnLstMain.Name = "xpnLstMain"
        Me.xpnLstMain.Size = New System.Drawing.Size(221, 416)
        Me.xpnLstMain.TabIndex = 136
        '
        'lbQty
        '
        Me.lbQty.BackColor = System.Drawing.Color.Ivory
        Me.lbQty.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQty.Location = New System.Drawing.Point(560, 366)
        Me.lbQty.Name = "lbQty"
        Me.lbQty.Size = New System.Drawing.Size(24, 23)
        Me.lbQty.TabIndex = 135
        Me.lbQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbTotalQty
        '
        Me.lbTotalQty.BackColor = System.Drawing.Color.Ivory
        Me.lbTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotalQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTotalQty.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalQty.Location = New System.Drawing.Point(528, 362)
        Me.lbTotalQty.Name = "lbTotalQty"
        Me.lbTotalQty.Size = New System.Drawing.Size(64, 29)
        Me.lbTotalQty.TabIndex = 134
        Me.lbTotalQty.Text = "QTY:"
        Me.lbTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkReprint
        '
        Me.chkReprint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkReprint.BackColor = System.Drawing.Color.Ivory
        Me.chkReprint.BackgroundImage = CType(resources.GetObject("chkReprint.BackgroundImage"), System.Drawing.Image)
        Me.chkReprint.Enabled = False
        Me.chkReprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkReprint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReprint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkReprint.Location = New System.Drawing.Point(552, 400)
        Me.chkReprint.Name = "chkReprint"
        Me.chkReprint.Size = New System.Drawing.Size(72, 34)
        Me.chkReprint.TabIndex = 102
        Me.chkReprint.Text = "Reprint"
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
        Me.btnRefreshMenu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshMenu.Location = New System.Drawing.Point(568, 400)
        Me.btnRefreshMenu.Name = "btnRefreshMenu"
        Me.btnRefreshMenu.Size = New System.Drawing.Size(56, 44)
        Me.btnRefreshMenu.TabIndex = 101
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
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(712, 400)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(64, 44)
        Me.btnRemove.TabIndex = 100
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
        Me.lblTotalOrderPrice.BackColor = System.Drawing.Color.Ivory
        Me.lblTotalOrderPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOrderPrice.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lblTotalOrderPrice.Location = New System.Drawing.Point(688, 368)
        Me.lblTotalOrderPrice.Name = "lblTotalOrderPrice"
        Me.lblTotalOrderPrice.Size = New System.Drawing.Size(72, 16)
        Me.lblTotalOrderPrice.TabIndex = 83
        Me.lblTotalOrderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.BackColor = System.Drawing.Color.Ivory
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(600, 362)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(176, 29)
        Me.Label35.TabIndex = 81
        Me.Label35.Text = "Total Price:-"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Ivory
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(528, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(248, 16)
        Me.Label15.TabIndex = 37
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
        Me.lvOrder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cCheckBox, Me.cQty, Me.cItem, Me.cPrice, Me.cInstruction, Me.cItemId, Me.cStockInHand, Me.cServeLocation, Me.cTypeName, Me.nTypeId, Me.ncatId, Me.cQtyRemaning})
        Me.lvOrder.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvOrder.FullRowSelect = True
        Me.lvOrder.GridLines = True
        Me.lvOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvOrder.Location = New System.Drawing.Point(520, 64)
        Me.lvOrder.MultiSelect = False
        Me.lvOrder.Name = "lvOrder"
        Me.lvOrder.Size = New System.Drawing.Size(256, 296)
        Me.lvOrder.TabIndex = 39
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
        Me.cQty.Width = 45
        '
        'cItem
        '
        Me.cItem.Text = "Item"
        Me.cItem.Width = 90
        '
        'cPrice
        '
        Me.cPrice.Text = "Price"
        Me.cPrice.Width = 171
        '
        'cInstruction
        '
        Me.cInstruction.Text = "Instruction"
        Me.cInstruction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cInstruction.Width = 200
        '
        'cItemId
        '
        Me.cItemId.Text = ""
        Me.cItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cItemId.Width = 0
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
        'cTypeName
        '
        Me.cTypeName.Width = 0
        '
        'nTypeId
        '
        Me.nTypeId.Text = "nTypeIdd"
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
        Me.cboInstruction.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cboInstruction.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInstruction.ItemHeight = 15
        Me.cboInstruction.Items.AddRange(New Object() {"No Coriander", "With Coriander", "No Coriander", "With Coriander", "No Oil", "With Oil", "No Sugar", "With Suger", "No Salty", "Salty", "No Nuts", "With Nuts", "More Spicy", "Less Spicy", "Saucy", "Buttery", "Crispy"})
        Me.cboInstruction.Location = New System.Drawing.Point(528, 21)
        Me.cboInstruction.Name = "cboInstruction"
        Me.cboInstruction.Size = New System.Drawing.Size(248, 23)
        Me.cboInstruction.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Ivory
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(528, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(240, 16)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Instruction on Item"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnKitchPrint.Location = New System.Drawing.Point(632, 400)
        Me.btnKitchPrint.Name = "btnKitchPrint"
        Me.btnKitchPrint.Size = New System.Drawing.Size(72, 44)
        Me.btnKitchPrint.TabIndex = 118
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
        Me.tbpgPayment.Controls.Add(Me.gbPaymentInformation)
        Me.tbpgPayment.Controls.Add(Me.gbPrintOrder)
        Me.tbpgPayment.Controls.Add(Me.gbPriceCalculation)
        Me.tbpgPayment.Controls.Add(Me.gbPriceInformation)
        Me.tbpgPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbpgPayment.ImageIndex = 2
        Me.tbpgPayment.Location = New System.Drawing.Point(4, 31)
        Me.tbpgPayment.Name = "tbpgPayment"
        Me.tbpgPayment.Size = New System.Drawing.Size(784, 445)
        Me.tbpgPayment.TabIndex = 2
        Me.tbpgPayment.Text = "Payment   "
        Me.tbpgPayment.Visible = False
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
        Me.gbPaymentInformation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbPaymentInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPaymentInformation.ForeColor = System.Drawing.Color.Maroon
        Me.gbPaymentInformation.Location = New System.Drawing.Point(526, 7)
        Me.gbPaymentInformation.Name = "gbPaymentInformation"
        Me.gbPaymentInformation.Size = New System.Drawing.Size(252, 430)
        Me.gbPaymentInformation.TabIndex = 4
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
        Me.btnRefund.TabIndex = 119
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
        Me.btnPayBill.TabIndex = 118
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
        Me.btnPay.TabIndex = 117
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
        Me.Label11.Location = New System.Drawing.Point(6, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 1)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Label11"
        '
        'txtCashPay
        '
        Me.txtCashPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCashPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashPay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashPay.Location = New System.Drawing.Point(104, 43)
        Me.txtCashPay.Name = "txtCashPay"
        Me.txtCashPay.Size = New System.Drawing.Size(138, 21)
        Me.txtCashPay.TabIndex = 77
        Me.txtCashPay.Text = ""
        '
        'txtBankName
        '
        Me.txtBankName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(352, 173)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(138, 21)
        Me.txtBankName.TabIndex = 80
        Me.txtBankName.Text = ""
        Me.txtBankName.Visible = False
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChequeNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.Location = New System.Drawing.Point(504, 202)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(138, 21)
        Me.txtChequeNo.TabIndex = 81
        Me.txtChequeNo.Text = ""
        Me.txtChequeNo.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(2, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 22)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Cheque Amount"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(400, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 75
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
        Me.txtChange.Location = New System.Drawing.Point(104, 224)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(138, 21)
        Me.txtChange.TabIndex = 83
        Me.txtChange.Text = ""
        '
        'lblChange
        '
        Me.lblChange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblChange.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChange.Location = New System.Drawing.Point(2, 224)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(96, 22)
        Me.lblChange.TabIndex = 74
        Me.lblChange.Text = "Change"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChequePay
        '
        Me.txtChequePay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtChequePay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChequePay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequePay.Location = New System.Drawing.Point(104, 172)
        Me.txtChequePay.MaxLength = 8
        Me.txtChequePay.Name = "txtChequePay"
        Me.txtChequePay.Size = New System.Drawing.Size(138, 21)
        Me.txtChequePay.TabIndex = 82
        Me.txtChequePay.Text = ""
        '
        'txtCardPay
        '
        Me.txtCardPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCardPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardPay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardPay.Location = New System.Drawing.Point(104, 89)
        Me.txtCardPay.MaxLength = 8
        Me.txtCardPay.Name = "txtCardPay"
        Me.txtCardPay.Size = New System.Drawing.Size(138, 21)
        Me.txtCardPay.TabIndex = 78
        Me.txtCardPay.Text = ""
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(2, 89)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 22)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "Card amount"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(264, 173)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 22)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Bank Name"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(2, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 22)
        Me.Label19.TabIndex = 71
        Me.Label19.Text = "Cash amount"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboCardType
        '
        Me.cboCardType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboCardType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCardType.Items.AddRange(New Object() {"Master", "Visa", "Local"})
        Me.cboCardType.Location = New System.Drawing.Point(104, 119)
        Me.cboCardType.Name = "cboCardType"
        Me.cboCardType.Size = New System.Drawing.Size(138, 21)
        Me.cboCardType.TabIndex = 79
        Me.cboCardType.Text = "(Select a Card type)"
        '
        'chkAccumulate
        '
        Me.chkAccumulate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAccumulate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccumulate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAccumulate.Location = New System.Drawing.Point(328, 337)
        Me.chkAccumulate.Name = "chkAccumulate"
        Me.chkAccumulate.TabIndex = 70
        Me.chkAccumulate.Text = "Accumulate"
        '
        'gbPrintOrder
        '
        Me.gbPrintOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbPrintOrder.Controls.Add(Me.btBillPrint)
        Me.gbPrintOrder.Controls.Add(Me.btnAllPrint)
        Me.gbPrintOrder.Controls.Add(Me.btnLevelPrint)
        Me.gbPrintOrder.Controls.Add(Me.txtPDAPrint)
        Me.gbPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbPrintOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPrintOrder.ForeColor = System.Drawing.Color.Maroon
        Me.gbPrintOrder.Location = New System.Drawing.Point(267, 322)
        Me.gbPrintOrder.Name = "gbPrintOrder"
        Me.gbPrintOrder.Size = New System.Drawing.Size(253, 115)
        Me.gbPrintOrder.TabIndex = 3
        Me.gbPrintOrder.TabStop = False
        Me.gbPrintOrder.Text = "PrintOption"
        '
        'btBillPrint
        '
        Me.btBillPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btBillPrint.BackColor = System.Drawing.Color.Transparent
        Me.btBillPrint.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btBillPrint.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btBillPrint.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btBillPrint.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btBillPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBillPrint.Location = New System.Drawing.Point(132, 40)
        Me.btBillPrint.Name = "btBillPrint"
        Me.btBillPrint.Size = New System.Drawing.Size(112, 46)
        Me.btBillPrint.TabIndex = 117
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
        Me.btnAllPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllPrint.Location = New System.Drawing.Point(8, 40)
        Me.btnAllPrint.Name = "btnAllPrint"
        Me.btnAllPrint.Size = New System.Drawing.Size(112, 46)
        Me.btnAllPrint.TabIndex = 116
        Me.btnAllPrint.Text = "All Print"
        Me.btnAllPrint.TextColorDefault = System.Drawing.Color.Black
        Me.btnAllPrint.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAllPrint.TextColorHover = System.Drawing.Color.White
        Me.btnAllPrint.TextColorNormal = System.Drawing.Color.White
        '
        'btnLevelPrint
        '
        Me.btnLevelPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLevelPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnLevelPrint.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnLevelPrint.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnLevelPrint.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnLevelPrint.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnLevelPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevelPrint.Location = New System.Drawing.Point(8, 56)
        Me.btnLevelPrint.Name = "btnLevelPrint"
        Me.btnLevelPrint.Size = New System.Drawing.Size(112, 24)
        Me.btnLevelPrint.TabIndex = 119
        Me.btnLevelPrint.Text = "Level Print"
        Me.btnLevelPrint.TextColorDefault = System.Drawing.Color.Black
        Me.btnLevelPrint.TextColorDisabled = System.Drawing.Color.Black
        Me.btnLevelPrint.TextColorHover = System.Drawing.Color.White
        Me.btnLevelPrint.TextColorNormal = System.Drawing.Color.White
        Me.btnLevelPrint.Visible = False
        '
        'txtPDAPrint
        '
        Me.txtPDAPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPDAPrint.BackColor = System.Drawing.Color.Transparent
        Me.txtPDAPrint.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.txtPDAPrint.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.txtPDAPrint.ButtonColorHover = System.Drawing.Color.Maroon
        Me.txtPDAPrint.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.txtPDAPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPDAPrint.Location = New System.Drawing.Point(8, 48)
        Me.txtPDAPrint.Name = "txtPDAPrint"
        Me.txtPDAPrint.Size = New System.Drawing.Size(104, 32)
        Me.txtPDAPrint.TabIndex = 120
        Me.txtPDAPrint.Text = "PDA Print"
        Me.txtPDAPrint.TextColorDefault = System.Drawing.Color.Black
        Me.txtPDAPrint.TextColorDisabled = System.Drawing.Color.Black
        Me.txtPDAPrint.TextColorHover = System.Drawing.Color.White
        Me.txtPDAPrint.TextColorNormal = System.Drawing.Color.White
        Me.txtPDAPrint.Visible = False
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
        Me.gbPriceCalculation.TabIndex = 1
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
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(16, 265)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 40)
        Me.btnDelete.TabIndex = 117
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
        Me.btnBckSpace.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBckSpace.Location = New System.Drawing.Point(16, 220)
        Me.btnBckSpace.Name = "btnBckSpace"
        Me.btnBckSpace.Size = New System.Drawing.Size(104, 40)
        Me.btnBckSpace.TabIndex = 116
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
        Me.btnAdd.Location = New System.Drawing.Point(127, 234)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 56)
        Me.btnAdd.TabIndex = 115
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
        Me.btnMultiply.Location = New System.Drawing.Point(175, 163)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(56, 52)
        Me.btnMultiply.TabIndex = 114
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
        Me.btnDot.Location = New System.Drawing.Point(99, 163)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(56, 52)
        Me.btnDot.TabIndex = 113
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
        Me.btn0.Location = New System.Drawing.Point(23, 162)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(56, 52)
        Me.btn0.TabIndex = 112
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
        Me.btn9.Location = New System.Drawing.Point(175, 112)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(56, 52)
        Me.btn9.TabIndex = 111
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
        Me.btn8.Location = New System.Drawing.Point(99, 112)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(56, 52)
        Me.btn8.TabIndex = 110
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
        Me.btn7.Location = New System.Drawing.Point(23, 112)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(56, 52)
        Me.btn7.TabIndex = 109
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
        Me.btn6.Location = New System.Drawing.Point(173, 61)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(56, 52)
        Me.btn6.TabIndex = 108
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
        Me.btn5.Location = New System.Drawing.Point(99, 61)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(56, 52)
        Me.btn5.TabIndex = 107
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
        Me.btn4.Location = New System.Drawing.Point(21, 62)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(56, 52)
        Me.btn4.TabIndex = 106
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
        Me.btn3.Location = New System.Drawing.Point(173, 12)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(56, 52)
        Me.btn3.TabIndex = 105
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
        Me.btn2.Location = New System.Drawing.Point(99, 11)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(56, 52)
        Me.btn2.TabIndex = 104
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
        Me.btn1.Location = New System.Drawing.Point(22, 12)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(56, 52)
        Me.btn1.TabIndex = 103
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
        Me.gbPriceInformation.Location = New System.Drawing.Point(8, 7)
        Me.gbPriceInformation.Name = "gbPriceInformation"
        Me.gbPriceInformation.Size = New System.Drawing.Size(252, 430)
        Me.gbPriceInformation.TabIndex = 0
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
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "in Amount"
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
        Me.Label38.TabIndex = 54
        Me.Label38.Text = "in Amount"
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
        Me.cboTips.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(9, 226)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 24)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Service charge in %"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(9, 291)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 22)
        Me.Label17.TabIndex = 47
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
        Me.Label13.Size = New System.Drawing.Size(128, 24)
        Me.Label13.TabIndex = 46
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
        Me.cboDiscount.TabIndex = 49
        '
        'txtNetPay
        '
        Me.txtNetPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNetPay.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetPay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.Location = New System.Drawing.Point(145, 291)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(96, 21)
        Me.txtNetPay.TabIndex = 52
        Me.txtNetPay.Text = ""
        Me.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtTips.TabIndex = 51
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
        Me.txtDiscount.TabIndex = 50
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
        Me.Label12.TabIndex = 39
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
        Me.txtTotalPrice.TabIndex = 40
        Me.txtTotalPrice.Text = ""
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.MacButton1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MacButton1.Location = New System.Drawing.Point(472, 540)
        Me.MacButton1.Name = "MacButton1"
        Me.MacButton1.Size = New System.Drawing.Size(104, 56)
        Me.MacButton1.TabIndex = 132
        Me.MacButton1.Text = "Miscell "
        Me.MacButton1.TextColorDefault = System.Drawing.Color.Black
        Me.MacButton1.TextColorDisabled = System.Drawing.Color.Black
        Me.MacButton1.TextColorHover = System.Drawing.Color.White
        Me.MacButton1.TextColorNormal = System.Drawing.Color.White
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
        Me.btntillOpen.TabIndex = 118
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
        Me.btnRefresh.Location = New System.Drawing.Point(10024, 4089)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(124, 40)
        Me.btnRefresh.TabIndex = 39
        Me.btnRefresh.Text = "Refresh Order"
        Me.btnRefresh.Visible = False
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
        Me.btnAdministrate.TabIndex = 97
        Me.btnAdministrate.Text = "Admin"
        Me.btnAdministrate.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdministrate.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdministrate.TextColorHover = System.Drawing.Color.White
        Me.btnAdministrate.TextColorNormal = System.Drawing.Color.White
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
        Me.btnPayment.TabIndex = 98
        Me.btnPayment.Text = "Pending"
        Me.btnPayment.TextColorDefault = System.Drawing.Color.Black
        Me.btnPayment.TextColorDisabled = System.Drawing.Color.Black
        Me.btnPayment.TextColorHover = System.Drawing.Color.White
        Me.btnPayment.TextColorNormal = System.Drawing.Color.White
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
        Me.btnSubmit.Location = New System.Drawing.Point(238, 540)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(18, 56)
        Me.btnSubmit.TabIndex = 99
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextColorDefault = System.Drawing.Color.Black
        Me.btnSubmit.TextColorDisabled = System.Drawing.Color.Black
        Me.btnSubmit.TextColorHover = System.Drawing.Color.White
        Me.btnSubmit.TextColorNormal = System.Drawing.Color.White
        Me.btnSubmit.Visible = False
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
        Me.btCanceOrder.TabIndex = 100
        Me.btCanceOrder.Text = "New"
        Me.btCanceOrder.TextColorDefault = System.Drawing.Color.Black
        Me.btCanceOrder.TextColorDisabled = System.Drawing.Color.Black
        Me.btCanceOrder.TextColorHover = System.Drawing.Color.White
        Me.btCanceOrder.TextColorNormal = System.Drawing.Color.White
        '
        'btnTakeaway
        '
        Me.btnTakeaway.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTakeaway.BackColor = System.Drawing.Color.Transparent
        Me.btnTakeaway.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btnTakeaway.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnTakeaway.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnTakeaway.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btnTakeaway.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakeaway.Location = New System.Drawing.Point(354, 540)
        Me.btnTakeaway.Name = "btnTakeaway"
        Me.btnTakeaway.Size = New System.Drawing.Size(104, 56)
        Me.btnTakeaway.TabIndex = 101
        Me.btnTakeaway.Text = "Takeaway"
        Me.btnTakeaway.TextColorDefault = System.Drawing.Color.Black
        Me.btnTakeaway.TextColorDisabled = System.Drawing.Color.Black
        Me.btnTakeaway.TextColorHover = System.Drawing.Color.White
        Me.btnTakeaway.TextColorNormal = System.Drawing.Color.White
        '
        'btnKeyBoard
        '
        Me.btnKeyBoard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeyBoard.BackColor = System.Drawing.Color.Transparent
        Me.btnKeyBoard.ButtonColorDefault = System.Drawing.Color.PeachPuff
        Me.btnKeyBoard.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnKeyBoard.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnKeyBoard.ButtonColorNormal = System.Drawing.Color.Chocolate
        Me.btnKeyBoard.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyBoard.Location = New System.Drawing.Point(585, 540)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(104, 56)
        Me.btnKeyBoard.TabIndex = 102
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'stxtMain
        '
        Me.stxtMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.stxtMain.BorderColor = System.Drawing.Color.Transparent
        Me.stxtMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.stxtMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stxtMain.ForeColor = System.Drawing.Color.Brown
        Me.stxtMain.ForegroundBrush = Nothing
        Me.stxtMain.Location = New System.Drawing.Point(4, 0)
        Me.stxtMain.Name = "stxtMain"
        Me.stxtMain.ScrollDirection = ScrollingTextControl.ScrollDirection.Bouncing
        Me.stxtMain.ScrollText = ""
        Me.stxtMain.ShowBorder = True
        Me.stxtMain.Size = New System.Drawing.Size(684, 40)
        Me.stxtMain.StopScrollOnMouseOver = True
        Me.stxtMain.TabIndex = 104
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
        Me.btnCancel.TabIndex = 105
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
        Me.btnMinimize.TabIndex = 119
        Me.btnMinimize.Text = "__"
        Me.btnMinimize.TextColorDefault = System.Drawing.Color.Black
        Me.btnMinimize.TextColorDisabled = System.Drawing.Color.Black
        Me.btnMinimize.TextColorHover = System.Drawing.Color.White
        Me.btnMinimize.TextColorNormal = System.Drawing.Color.White
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Qty"
        Me.ColumnHeader2.Width = 45
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Item"
        Me.ColumnHeader3.Width = 153
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Instruction"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = ""
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = ""
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = ""
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Qty"
        Me.ColumnHeader11.Width = 45
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Item"
        Me.ColumnHeader12.Width = 153
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Price"
        Me.ColumnHeader13.Width = 87
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Instruction"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 200
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = ""
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = ""
        Me.ColumnHeader16.Width = 0
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Width = 0
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Width = 0
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
        Me.btnUser.TabIndex = 98
        Me.btnUser.Text = "User"
        Me.btnUser.TextColorDefault = System.Drawing.Color.Black
        Me.btnUser.TextColorDisabled = System.Drawing.Color.Black
        Me.btnUser.TextColorHover = System.Drawing.Color.White
        Me.btnUser.TextColorNormal = System.Drawing.Color.White
        Me.btnUser.Visible = False
        '
        'frmDine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.stxtMain)
        Me.Controls.Add(Me.btnKeyBoard)
        Me.Controls.Add(Me.btnTakeaway)
        Me.Controls.Add(Me.btCanceOrder)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.tabTakeaway)
        Me.Controls.Add(Me.btnAdministrate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btntillOpen)
        Me.Controls.Add(Me.MacButton1)
        Me.Controls.Add(Me.btnUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDine"
        Me.Text = "frmDine"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabTakeaway.ResumeLayout(False)
        Me.tbpgCustInfo.ResumeLayout(False)
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

    Private WithEvents objtaskbarNotifier As TaskBarNotifier

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

    Private Function ShowSelectOrderInfo()
        Dim iCountDataSetRow As Integer
        Dim strSQL As String
        Dim iCustomerId As Integer
        Dim iTableId As Integer
        Dim strTableNo As String

        Dim dsDineInfo As DataSet
        Dim daDineInfo As SqlClient.SqlDataAdapter


        strSQL = "SELECT P.nOrder_Id,P.dOrder_date,C.cCust_Name,C.cCust_BillAdd,P.mNetpay," & _
                 "P.nOrderStatus,P.cUserId,C.nCust_Id FROM tOrder_Payment P,tCust_Info C " & _
                 "WHERE P.nCust_Id=C.nCust_Id AND P.nOrderStatus=0 AND P.nTable_Id=" & CStr(Trim(txtTableId.Text)) & ""

        iTableId = Trim(txtTableId.Text)
        strTableNo = Trim(txtTableNo.Text)

        Try
            dsDineInfo = New DataSet("DineInfo")
            daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daDineInfo.Fill(dsDineInfo, "DineInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        iCountDataSetRow = dsDineInfo.Tables("DineInfo").Rows.Count

        If iCountDataSetRow > 0 Then
            ClearAllField()
            txtNetPay.Text = ""
            cboDiscount.Text = ""
            iOrderId = dsDineInfo.Tables("DineInfo").Rows(0).Item(0)
            txtTableId.Tag = iOrderId
            iCustomerId = dsDineInfo.Tables("DineInfo").Rows(0).Item(7)
            PutDataIntoCustomerInfo(iCustomerId)
            PutDataIntoOrderInfo(iOrderId)
            PutDataIntoPaymentInfo(iOrderId)
            btnSubmit.Text = "Update"
            chkReprint.Enabled = True
            If chkReprint.Checked = True Then
                chkReprint.Checked = False
            End If
        Else
            'ClearAllField()
            'txtNetPay.Text = ""
            'cboDiscount.Text = ""
            txtTableId.Text = iTableId
            txtTableNo.Text = strTableNo
        End If
        Call calculatetotalItem()
    End Function

    Private Sub btTblSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTblSelect.Click

        If txtTableNo.Text = vbNullString And txtGuestNumber.Text = vbNullString Then
            If txtNetPay.Text = vbNullString Then
                ClearAllField()
                txtNetPay.Text = ""
                cboDiscount.Text = ""
            End If

        Else
            'Dim strSQL As String
            'Dim iSelectedOrderId As Integer
            'Dim cmdUpdate As SqlClient.SqlCommand
            'Dim tnsAll As SqlClient.SqlTransaction

            'strSQL = "UPDATE tTable_Info SET nStatus=0 WHERE nTable_Id=" + CStr(txtTableId.Text) + ""
            'cmdUpdate = New SqlClient.SqlCommand
            'tnsAll = mdDBConnection.connRestuarant.BeginTransaction()
            'cmdUpdate.Transaction = tnsAll
            'cmdUpdate.Connection = mdDBConnection.connRestuarant
            'cmdUpdate.CommandText = strSQL
            'cmdUpdate.ExecuteNonQuery()
            'tnsAll.Commit()

        End If

        Dim ofrmTableStatus As New frmTableStatus
        ofrmTableStatus.ShowDialog()

        If strfindcode <> vbNullString Then
            txtTableId.Text = strfindDesc
            txtTableNo.Text = strfindcode
            ShowSelectOrderInfo()
        End If

        strfindcode = vbNullString
        strfindDesc = vbNullString


    End Sub

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
        CalculateTotalPrice()
        calculatetotalItem()
        FillInstructionCombo()

    End Sub
    ' Dish Menu
    Public Sub AddXpndrtoPnl()
        Dim strSQL As String
        Dim icount As Integer 'For count the number of rows in Category Dataset 
        Dim ds As DataSet
        Dim da As SqlClient.SqlDataAdapter

        Try
            ds = New DataSet("DishMenu")
            strSQL = "SELECT * FROM tCategory WHERE nCtgyActive=1"
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

    'Function to add Labels to the Main Panel Xpanders " Type menu"
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
                    .Width = 165  ''First xpander Label width 180
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
            rXpanderTemp.Height = 40
        End If

        'Dim XPanderTemp As New XPanderControl.XPander
        'XPanderTemp.Width = 187
        'XPanderTemp.Height = 0
        'xpndLstScnd.Controls.Add(XPanderTemp)
    End Sub

    'Function to add Labels to the Secondary Panel Xpander Items colour
    Public Sub AddLabeltoXpander(ByRef rXpanderTemp As XPanderControl.XPander, ByVal Flag As Char, ByVal aTypeId As Integer)
        Dim ds As DataSet
        Dim strSQL As String
        Dim icount As Integer 'For count the number of rows in Category Dataset 
        Dim iColumn As Integer = 0
        Dim iRow As Integer = 0

        strSQL = "SELECT I.nItem_Id,I.cItem_Name,I.cItem_SC,I.nItem_Stock,I.mDinePrice,I.cItem_ServeLoc,I.nType_Id,T.nCtgry_Id " & _
                 " FROM tItem I,tType T WHERE I.nType_Id= " & aTypeId & " AND I.nType_Id=T.nType_Id AND I.nItemActive=1 ORDER BY  I.nItem_Id"  'nType_Id added for type print 26.01.09

        Try
            ds = New DataSet("DishMenu")
            da = New SqlClient.SqlDataAdapter(strSQL, connRestuarant)
            da.Fill(ds, "dsItem")
            icount = ds.Tables("dsItem").Rows.Count
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        ReDim strItemInfo(icount, 6)

        Dim i As Integer

        Dim Count As Integer
        If icount > 0 Then
            For i = 0 To icount - 1 'No_of_Items
                Dim btnType As New MACButtonLib.MACButton
                With btnType
                    .Width = 110 ''First xpander Label width  180
                    .Height = 40
                    .Top = 40 + 40 * iRow
                    .Left = 2 + 114 * iColumn

                    '.Width = 165    ''First xpander Label width  180
                    '.Height = 40
                    '.Top = 35 + 40 * Count
                    '.Left = 4

                    .ButtonColorNormal = Color.OliveDrab
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
                    .Width = 246    '187
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
                strItemInfo(i, 3) = Trim(ds.Tables(0).Rows(i).Item(4)) 'Item Dine In Price
                strItemInfo(i, 4) = Trim(ds.Tables(0).Rows(i).Item(5)) 'Item Serve location
                strItemInfo(i, 5) = Trim(ds.Tables(0).Rows(i).Item(6)) 'Type ID
                strItemInfo(i, 6) = Trim(ds.Tables(0).Rows(i).Item(7)) 'cat ID 'added for sorting on 15.02.09


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
            'XPanderTemp.Height = 0
            'xpndLstScnd.Controls.Add(XPanderTemp)
        Else
            Me.xpndrItems.Height = 30
            rXpanderTemp.Width = 258
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
            strNewClickType = Me.xpndrItems.CaptionText

            If iHeight > 424 Then
                Me.xpndLstScnd.AutoScroll = True
            Else
                Me.xpndLstScnd.AutoScroll = False
            End If

            If strClickTypeName = strNewClickType Then
                Me.xpndLstScnd.AutoScroll = False
                Me.xpnLstMain.Controls.Clear()
                AddXpndrtoPnl()
                Me.xpndrItems.Controls.Clear()
                Me.xpndrItems.Width = 258
                Me.xpndrItems.Left = 11
                Me.xpndrItems.Top = 9
                Me.xpndrItems.CaptionText = "No Dish Type selected"
                Me.xpndLstScnd.AutoScroll = False
                bClickedBefore = False
            Else
                bClickedBefore = True
            End If
        End If
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
            Me.lvOrder.Items(0).SubItems.Add(strItemInfo(iIndex, 5))
            Me.lvOrder.Items(0).SubItems.Add(strItemInfo(iIndex, 6))
            Me.lvOrder.Focus()    'new added for order highlight on london 12.1.08
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
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 5))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 6))
                        Me.lvOrder.Focus()                 'new added for order highlight on london 12.1.08
                        Me.lvOrder.Items(i).Selected = True   'new added for order highlight on london 12.1.08
                    Else
                        Me.lvOrder.Items(i).SubItems(1).Text = Val(Me.lvOrder.Items(i).SubItems(1).Text) + 1
                        Me.lvOrder.Items(i).SubItems(3).Text = FormatCurrency(Val(strItemInfo(iIndex, 3)) * Val(Me.lvOrder.Items(i).SubItems(1).Text))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 0))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 2))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 4))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strTypename)
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 5))
                        Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 6))
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
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 5))
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).SubItems.Add(strItemInfo(iIndex, 6))
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).EnsureVisible()
                    Me.lvOrder.Focus()             'new added for order highlight on london 12.1.08
                    Me.lvOrder.Items(lvOrder.Items.Count - 1).Selected = True    'new added for order highlight on london 12.1.08
                    If lvOrder.CheckBoxes = True Then
                        Dim NewQty As Integer
                        NewQty = CInt(lvOrder.Items(lvOrder.Items.Count - 2).SubItems(1).Text)
                        lvOrder.Items(lvOrder.Items.Count - 3).SubItems.Add(0)
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
    'need modify
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

    Private Sub frmTakeaway_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSQL As String
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

        mdConfiguration.GetPrinterSetting()
        txtCustomerNo.Text = "New Customer"

        Dim BackgroundBrush As New LinearGradientBrush(Me.stxtMain.ClientRectangle _
                           , Color.Honeydew, Color.White, LinearGradientMode.Horizontal)
        stxtMain.BackgroundBrush = BackgroundBrush

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            stxtMain.ScrollText = "UySys eRestuarant " & ": Dine In"
        Else
            stxtMain.ScrollText = mdConfiguration.strResturantName & ": Dine In"
        End If

        bCboLoad = True
        FillCardCombo()
        FillInstructionCombo()
        bCboLoad = False
    End Sub

    Private Sub cboInstruction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInstruction.SelectedIndexChanged
        'Dim i As Integer
        'Dim strtest As String
        'Dim lvOrderItem As ListViewItem
        'strtest = cboInstruction.Text
        'For Each lvOrderItem In Me.lvOrder.SelectedItems
        '    If IsNumeric(Trim(cboInstruction.Text)) Then
        '        lvOrderItem.SubItems(2).Text = cboInstruction.Text
        '    Else
        '        lvOrderItem.SubItems(4).Text = cboInstruction.Text
        '    End If
        'Next
    End Sub

    Private Sub cboInstruction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInstruction.Click
        cboInstruction.Text = vbNullString
        'Dim i As Integer
        'Dim lvOrderItem As ListViewItem
        'For Each lvOrderItem In Me.lvOrder.SelectedItems
        '    lvOrderItem.SubItems(4).Text = sender.Text
        'Next
    End Sub

    Private Sub txtTips_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTips.LostFocus
        If txtTips.Text <> vbNullString Then
            txtTips.Text = FormatCurrency(txtTips.Text)
        End If
    End Sub

    Private Sub txtCash_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashPay.LostFocus
        If txtCashPay.Text <> vbNullString Then
            txtCashPay.Text = FormatCurrency(txtCashPay.Text)
        End If
    End Sub

    Private Sub txtCard_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCardPay.LostFocus
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

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btnDot.Click, btn1.Click
        If mdValidation.IsTextEditableControl(conControlName) = True Then
            IsEnterPress(conControlName)
            conControlName.Text += sender.Text
        End If
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

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearAllField()
        txtNetPay.Text = ""
        cboDiscount.Text = ""
    End Sub

    Private Sub btnBckSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBckSpace.Click
        If conControlName.Text.Length > 0 Then
            conControlName.Text = conControlName.Text.Remove(conControlName.Text.Length - 1, 1)
        End If
    End Sub

    Public Sub clearInfo(ByVal tempgbCustomerInfo As Object)
        Dim ctl As Control

        For Each ctl In tempgbCustomerInfo.Controls
            If TypeName(ctl) = "TextBox" Then
                ctl.Text = vbNullString
            End If
        Next

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        conControlName.Text = vbNullString
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
                    InsertNewOrder()
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

    Private Sub btnTakeaway_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTakeaway.Click

        If lvOrder.Items.Count = 0 Then
            Dim ofrm As New frmTakeaway
            ofrm.Show()
            Me.Dispose()
        ElseIf btnPayBill.Enabled = False Then
            Dim ofrm As New frmTakeaway
            ofrm.Show()
            Me.Dispose()
        ElseIf btnPay.Enabled = False Then
            Dim ofrm As New frmTakeaway
            ofrm.Show()
            Me.Dispose()
        Else
            Dim Itype As Integer
            Itype = MsgBox("A Ordered is Remaninig!!if want to keep,Press YES", MsgBoxStyle.YesNo, "eRestuarant")
            If Itype = MsgBoxResult.Yes Then
                If lvOrder.CheckBoxes = False Then
                    Me.tabTakeaway.SelectedIndex = 2
                    InsertNewOrder()
                    Dim ofrm As New frmTakeaway
                    ofrm.Show()
                    Me.Dispose()
                ElseIf lvOrder.CheckBoxes = True Then
                    Me.tabTakeaway.SelectedIndex = 2
                    UpdateOrder()
                    Dim ofrm As New frmTakeaway
                    ofrm.Show()
                    Me.Dispose()
                End If
            Else
                Dim ofrm As New frmTakeaway
                ofrm.Show()
                Me.Dispose()

            End If
        End If

    End Sub

    Private Sub btnKitchPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKitchPrint.Click
        ' Me.lvOrder.Sorting = SortOrder.Ascending

        If Trim(txtTableNo.Text) = vbNullString Then
            MessageBox.Show("No Table is selected for order." & vbCrLf & "Please select one table.", "Dine In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Trim(txtGuestNumber.Text) = vbNullString Then
            MessageBox.Show("Please give number of guests.", "Dine In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf lvOrder.Items.Count = 0 Then
            MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "Dine In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            btnKitchPrint.Enabled = False
            If lvOrder.CheckBoxes = True Then                'If btnSubmit.Text = "Update" Then
                Me.tabTakeaway.SelectedIndex = 2
                UpdateOrder()
                If bPrint = True Then
                    PrintOrder()
                End If
            ElseIf lvOrder.CheckBoxes = False Then           'btnSubmit.Text = "Submit" Then
                Me.tabTakeaway.SelectedIndex = 2
                InsertNewOrder()
                If bPrint = True Then
                    PrintOrder()
                    btnSubmit.Text = "Update"
                End If
            End If
        End If
        Dim frmNew As New frmDine
        frmNew.Show()
        Me.Dispose()
    End Sub

    Private Function CalculateFixtServiceCharge()
        Dim dTotalPrice As Double

        If lblTotalOrderPrice.Text = vbNullString Then
            Exit Function
        Else
            If Decimal.Parse(Trim(lblTotalOrderPrice.Text), NumberStyles.Currency) = 0.0 Then
                Exit Function
            Else
                dTotalPrice = Decimal.Parse(Trim(lblTotalOrderPrice.Text), NumberStyles.Currency)
            End If
        End If

        If Trim(GetSetting("Restaurant", "FormSetting", "ServiceCharge")) <> vbNullString Then
            If Trim(GetSetting("Restaurant", "FormSetting", "ServiceCharge")) <> "." Then
                cboTips.Text = Trim(GetSetting("Restaurant", "FormSetting", "ServiceCharge"))
                txtTips.Text = FormatCurrency(dTotalPrice * Val(Trim(GetSetting("Restaurant", "FormSetting", "ServiceCharge"))) / 100)
            Else
                txtTips.Text = ""
            End If
        Else
            txtTips.Text = ""
        End If
    End Function

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

        If GetSetting("Restaurant", "FormSetting", "NumberOfGuest") = vbNullString Then
            If GetSetting("Restaurant", "FormSetting", "ServiceCharge") <> vbNullString Then
                CalculateFixtServiceCharge()
            End If
        Else
            If Val(Trim(GetSetting("Restaurant", "FormSetting", "NumberOfGuest"))) <= Val(Trim(txtGuestNumber.Text)) Then
                CalculateFixtServiceCharge()
            End If
        End If
    End Sub

    Private Sub txtCashPay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCashPay.TextChanged
        If Trim(txtCashPay.Text) <> vbNullString Then
            ValidationForNumaricData(txtCashPay)
        End If

        CalculateChangre()
    End Sub

    Private Sub txtCardPay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCardPay.TextChanged
        If Trim(txtCardPay.Text) <> vbNullString Then
            ValidationForNumaricData(txtCardPay)
        End If

        CalculateChangre()
    End Sub

    Private Sub txtChequePay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequePay.TextChanged
        If Trim(txtChequePay.Text) <> vbNullString Then
            ValidationForNumaricData(txtChequePay)
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

    Private Sub txtTips_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTips.TextChanged
        If Trim(txtTips.Text) <> vbNullString Then
            ValidationForNumaricData(txtTips)
            CalculateTips()
            CalculatePrice()
        End If
    End Sub

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

    Private Sub btCanceOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCanceOrder.Click
        'Dim frmNew As New frmDine
        'frmNew.Show()
        'Me.Dispose()
        'Me.lvOrder.Sorting = SortOrder.Ascending
        ListView_CatagorySort(lvOrder, 10, VariantType.Integer)
        ListView_TypeSort(lvOrder, 9, VariantType.Integer)
        If btnPayBill.Enabled = False Then
            Dim frmNew As New frmDine
            frmNew.Show()
            Me.Dispose()
        ElseIf btnPay.Enabled = False Then
            Dim frmNew As New frmDine
            frmNew.Show()
            Me.Dispose()
        ElseIf lvOrder.Items.Count = 0 Then
            Dim frmNew As New frmDine
            frmNew.Show()
            Me.Dispose()
        ElseIf lvOrder.CheckBoxes = False Then
            Me.tabTakeaway.SelectedIndex = 2
            InsertNewOrder()
            ' Dim frmNew As New frmDine
            'frmNew.Show()
            ' Me.Dispose()
        ElseIf lvOrder.CheckBoxes = True Then
            Me.tabTakeaway.SelectedIndex = 2
            UpdateOrder()
            Dim frmNew As New frmDine
            frmNew.Show()
            Me.Dispose()
        End If

    End Sub

    Public Sub btBillPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBillPrint.Click
        Me.lvOrder.Sorting = SortOrder.Ascending

        If Trim(txtTableNo.Text) = vbNullString Then
            MessageBox.Show("No Table is selected for order." & vbCrLf & "Please select one table.", "Dine In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Trim(txtGuestNumber.Text) = vbNullString Then
            MessageBox.Show("Please give number of guests.", "Dine In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf lvOrder.Items.Count = 0 Then
            MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "Dine In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            btBillPrint.Enabled = False
            If lvOrder.CheckBoxes = True Then           'If btnSubmit.Text = "Update" Then  "close for new buttom milton on london 31.01.08
                Call UpdateOrder()
                If bPrint = True Then
                    PrintBill()
                End If
            ElseIf lvOrder.CheckBoxes = False Then       'btnSubmit.Text = "Submit" Then        "close for new buttom milton on london 31.01.08  
                Call InsertNewOrder()
                If bPrint = True Then
                    PrintBill()
                    btnSubmit.Text = "Update"
                End If
            End If
        End If
        Dim frmNew As New frmDine
        frmNew.Show()
        Me.Dispose()
    End Sub

    'Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

    '    'If btnSubmit.Text = "Update" Then
    '    '    UpdateOrder()
    '    'ElseIf btnSubmit.Text = "Submit" Then
    '    '    InsertNewOrder()
    '    'End If

    '    'ClearAllField()
    '    'txtNetPay.Text = ""
    '    'cboDiscount.SelectedIndex = -1
    '    'iOrderId = 0

    '    'Dim frmNew As New frmDine
    '    'frmNew.Show()
    '    'Me.Dispose()

    'End Sub

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

    Private Function InsertNewOrder()

        Dim strSQLInsertCust_Info As String
        Dim strSQLInsertOrder_Info As String
        Dim strSQLInsertOrder_Payment As String
        Dim strSQLUpdateStock_Info As String
        Dim strSQLTable_Info As String
        Dim strSQL As String
        Dim sInstruction As String

        Dim iIndex As Integer
        Dim icountLVRow As Integer
        Dim iQuantity As Integer
        Dim iOrderStatus As Integer
        Dim iCustomerId As Integer
        Dim iQuantityInHand As Integer
        Dim iCurrentStock As Integer
        Dim iTableId As Integer
        Dim iNumberOfGuest As Integer
        Dim iItemId As Integer

        Dim dTotalPricePerItem As Double
        Dim dUnitPrice As Double
        Dim dTotalPrice As Double
        Dim dDiscount As Double
        Dim dTips As Double
        Dim dNetPrice As Double
        Dim dCash As Double
        Dim dCard As Double
        Dim dBalance As Double

        Dim blnTrans As Boolean

        Dim strImageName As String = "skin1.bmp"
        Dim strTitel As String = "Save Message"
        Dim strMessage As String = "Your order has been created Successfully"
        Dim recTitleRectangle As New Rectangle(148, 50, 200, 28)
        Dim recTextRectangle As New Rectangle(90, 92, 200, 55)
        Dim pClosingPoint As New Point(280, 58)

        Dim cmdInsertCust_Info As SqlClient.SqlCommand
        Dim tnsAll As SqlClient.SqlTransaction

        Me.lvOrder.Sorting = SortOrder.Ascending

        If CheckValidate() = False Then
            Exit Function
        End If

        iTableId = Val(Trim(txtTableId.Text))
        iNumberOfGuest = Val(Trim(txtGuestNumber.Text))
        dTotalPrice = GetTotalPrice()
        dDiscount = GetDiscount()
        dTips = GetTips()
        dNetPrice = GetNetpay()

        If Trim(txtCustomerNo.Text) = "New Customer" Then

            Try
                strSQLInsertCust_Info = "INSERT INTO tCust_Info(cCust_Name,cCompany,dCust_EntryDate,cEmail," & _
                                        "cComment,cUserId,cTermenal,dAccessTime) VALUES('" & Trim(txtName.Text) & _
                                        "','" & Trim(txtCompany.Text) & "',GETDATE(),'" & Trim(txtEmail.Text) & _
                                        "','" & Trim(txtComment.Text) & "','" & user & "','" & sTerminal & "',GETDATE())"

                cmdInsertCust_Info = New SqlClient.SqlCommand
                cmdInsertCust_Info.Connection = mdDBConnection.connRestuarant
                cmdInsertCust_Info.CommandText = strSQLInsertCust_Info
                tnsAll = mdDBConnection.connRestuarant.BeginTransaction
                blnTrans = True
                cmdInsertCust_Info.Transaction = tnsAll
                cmdInsertCust_Info.ExecuteNonQuery()

                'strSQLInsertOrder_Payment = "INSERT INTO tOrder_Payment(nCust_Id,dOrder_date,nTable_Id," & _
                '                            "nNumberofGuests,mTotalPrice,mDiscount,mService_Charge,mNetpay" & _
                '                            ",nOrderStatus,cUserId,cTerminal,dAccessTime) " & _
                '                            "SELECT MAX(tCust_Info.nCust_Id),GETDATE()," & CStr(iTableId) & _
                '                            "," & CStr(iNumberOfGuest) & "," & CStr(dTotalPrice) & _
                '                            "," & CStr(dDiscount) & "," & CStr(dTips) & "," & CStr(dNetPrice) & _
                '                            ",0,'" & user & "','" & sTerminal & "',GETDATE() FROM tCust_Info"

                strSQLInsertOrder_Payment = "INSERT INTO tOrder_Payment(nCust_Id,dOrder_date,nTable_Id," & _
                            "nNumberofGuests,mTotalPrice,mDiscount,mService_Charge,mNetpay" & _
                            ",nOrderStatus,cUserId,cTerminal,dAccessTime,perdiscount,perservice) " & _
                            "SELECT MAX(tCust_Info.nCust_Id),GETDATE()," & CStr(iTableId) & _
                            "," & CStr(iNumberOfGuest) & "," & CStr(dTotalPrice) & _
                            "," & CStr(dDiscount) & "," & CStr(dTips) & "," & CStr(dNetPrice) & _
                            ",0,'" & user & "','" & sTerminal & "',GETDATE(),'" & Trim(cboDiscount.Text) & "','" & Trim(cboTips.Text) & "' FROM tCust_Info"   'changed milton 25.08.07

                cmdInsertCust_Info.CommandText = strSQLInsertOrder_Payment
                cmdInsertCust_Info.ExecuteNonQuery()

                icountLVRow = lvOrder.Items.Count

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

                    cmdInsertCust_Info.CommandText = strSQLInsertOrder_Info
                    cmdInsertCust_Info.ExecuteNonQuery()

                    iCurrentStock = iQuantityInHand - iQuantity

                    strSQLUpdateStock_Info = "UPDATE tItem SET nItem_Stock=" & CStr(iCurrentStock) & _
                                             " WHERE nItem_Id=" & CStr(iItemId) & ""

                    cmdInsertCust_Info.CommandText = strSQLUpdateStock_Info
                    cmdInsertCust_Info.ExecuteNonQuery()
                Next
                strSQLTable_Info = "UPDATE tTable_Info SET nStatus=1 WHERE nTable_Id=" + CStr(iTableId) + ""
                cmdInsertCust_Info.CommandText = strSQLTable_Info
                cmdInsertCust_Info.ExecuteNonQuery()

            Catch ex As Exception
                If blnTrans = True Then
                    tnsAll.Rollback()
                    blnTrans = False
                    MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                End If
            Finally
                If blnTrans = True Then
                    'If MessageBox.Show("Do you want to submit the order.", "Takeaway", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    tnsAll.Commit()
                    bPrint = True
                    blnTrans = False
                    txtTableId.Tag = GetOrderId()
                    txtCustomerNo.Text = GetCustomerId()
                    'PutDataIntoOrderInfo(Trim(txtTableId.Tag))
                    'ShowTaskBarNotifire(strImageName, strTitel, strMessage, recTitleRectangle, recTextRectangle, pClosingPoint)
                    'Else
                    'tnsAll.Rollback()
                    'blnTrans = False
                    'End If
                End If
            End Try
        End If
    End Function

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
        Dim iTableId As Integer

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

        Dim cmdUpdate As SqlClient.SqlCommand
        Dim tnsAll As SqlClient.SqlTransaction

        Me.lvOrder.Sorting = SortOrder.Ascending

        If CheckValidate() = False Then
            Exit Function
        End If

        dTotalPrice = GetTotalPrice()
        dDiscount = GetDiscount()
        dTips = GetTips()
        dNetPrice = GetNetpay()
        iTableId = Trim(txtTableId.Text)

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


        strSQLUpdateCust_Info = "UPDATE tCust_Info SET cCust_Name='" & Trim(txtName.Text) & _
                                "',cCompany= '" & Trim(txtCompany.Text) & "',dCust_EntryDate=GETDATE()," & _
                                "cEmail='" & Trim(txtEmail.Text) & "',cComment='" & Trim(txtComment.Text) & _
                                "',cUserId= '" & user & "',cTermenal='" & sTerminal & _
                                "',dAccessTime=GETDATE()WHERE nCust_Id=" & CStr(txtCustomerNo.Text) & ""



        'strSQLUpdatePaymentInfo = "UPDATE tOrder_Payment SET dOrder_date=GETDATE(),nTable_Id=" & CStr(txtTableId.Text) & _
        '                          ",nNumberofGuests=" + CStr(txtGuestNumber.Text) + ",mTotalPrice=" & CStr(dTotalPrice) & _
        '                          ",mDiscount=" & CStr(dDiscount) & ",mService_Charge=" & CStr(dTips) & _
        '                          ",mNetpay=" & CStr(dNetPrice) & ",nOrderStatus=0,cUserId= '" & user & _
        '                          "',cTerminal='" & sTerminal & "' WHERE nOrder_Id=" & CStr(iOrderId) & _
        '                          " AND nCust_Id=" & CStr(Trim(txtCustomerNo.Text)) & ""

        strSQLUpdatePaymentInfo = "UPDATE tOrder_Payment SET dOrder_date=GETDATE(),nTable_Id=" & CStr(txtTableId.Text) & _
                                 ",nNumberofGuests=" + CStr(txtGuestNumber.Text) + ",mTotalPrice=" & CStr(dTotalPrice) & _
                                 ",mDiscount=" & CStr(dDiscount) & ",mService_Charge=" & CStr(dTips) & _
                                 ",mNetpay=" & CStr(dNetPrice) & ",nOrderStatus=0,cUserId= '" & user & _
                                 "',cTerminal='" & sTerminal & "',perdiscount='" & Trim(cboDiscount.Text) & "',perservice='" & Trim(cboTips.Text) & "' WHERE nOrder_Id=" & CStr(iOrderId) & _
                                 " AND nCust_Id=" & CStr(Trim(txtCustomerNo.Text)) & ""

        strSQLDeleteOrderedItem = "DELETE FROM tOrdered_Item WHERE nOrder_Id=" & CStr(iOrderId) & ""
        strSQLUpdateTableInfo = "UPDATE tTable_Info SET nStatus=0 WHERE nTable_Id=" & CStr(txtUpdate.Text) & ""
        strSQLTable_Info = "UPDATE tTable_Info SET nStatus=1 WHERE nTable_Id=" & CStr(Trim(iTableId)) & ""

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

                cmdUpdate.CommandText = strSQLUpdateTableInfo
                cmdUpdate.ExecuteNonQuery()

                cmdUpdate.CommandText = strSQLTable_Info
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
                txtTableId.Tag = iOrderId
                'PutDataIntoOrderInfo(Trim(txtTableId.Tag))
                'ShowTaskBarNotifire(strImageName, strTitel, strMessage, recTitleRectangle, recTextRectangle, pClosingPoint)
                'Else
                'tnsAll.Rollback()
                'blnTrans = False
                'End If
            End If
        End Try
    End Function

    Private Function CheckValidate() As Boolean
        Dim blnCheck As Boolean

        If Trim(txtTableId.Text) = vbNullString Then
            MessageBox.Show("Please select a free table", "Dine In Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnCheck = False
            btTblSelect.Focus()
            Exit Function
        ElseIf Trim(txtGuestNumber.Text) = vbNullString Or Trim(txtGuestNumber.Text) = "0" Then
            MessageBox.Show("Please give valid guest number", "Dine In Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtGuestNumber.Focus()
            blnCheck = False
            Exit Function
        ElseIf ValidationForEmailAddress(txtEmail) = False Then
            MessageBox.Show("Please give email address in right format", "Dine In Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnCheck = False
            txtEmail.Focus()
            Exit Function
        ElseIf lvOrder.Items.Count = 0 Then
            MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "Dine In Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnCheck = False
            Exit Function
        Else
            blnCheck = True
        End If
        CheckValidate = blnCheck
    End Function

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

    Private Function GetOrderId(ByVal tmpCustomerId As Integer) As Integer
        Dim strSQL As String

        Dim iDataSetRow As Integer

        Dim dsOrderId As DataSet
        Dim daOrderId As SqlClient.SqlDataAdapter

        If Trim(txtCustomerNo.Text) = vbNullString Then
            MessageBox.Show("There is no Order found to update Order." & vbCrLf & "Please select One order", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnPayment.Focus()
            Exit Function
        End If

        strSQL = "SELECT nOrder_Id FROM tOrder_Payment WHERE nCust_Id=" & tmpCustomerId & ""

        Try
            dsOrderId = New DataSet("OrderId")
            daOrderId = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daOrderId.Fill(dsOrderId, "OrderId")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        If IsDBNull(dsOrderId.Tables("OrderId").Rows(0).Item(0)) = False Then
            GetOrderId = dsOrderId.Tables("OrderId").Rows(0).Item(0)
        End If
    End Function

    'Private Function GetTableId() As Integer
    '    Dim strSQL As String

    '    Dim iDataSetRow As Integer

    '    Dim dsTableId As DataSet
    '    Dim daTableId As SqlClient.SqlDataAdapter

    '    If Trim(txtCustomerNo.Text) = vbNullString Then
    '        MessageBox.Show("There is no Order found to update Order." & vbCrLf & "Please select One order", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        btnPayment.Focus()
    '        Exit Function
    '    End If

    '    Dim iOrderId As Integer

    '    strSQL = "SELECT nTable_Id FROM tOrder_Payment WHERE nCust_Id=" + CStr(Trim(txtCustomerNo.Text)) + " AND nOrder_Id=" + CStr(txtCustomerNo.Tag) + ""

    '    Try
    '        dsTableId = New DataSet("TableId")
    '        daTableId = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
    '        daTableId.Fill(dsTableId, "TableId")
    '    Catch ex As Exception
    '        MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
    '    End Try

    '    iDataSetRow = dsTableId.Tables("TableId").Rows.Count

    '    If IsDBNull(dsTableId.Tables("TableId").Rows(0).Item(0)) = False Then
    '        GetTableId = dsTableId.Tables("TableId").Rows(0).Item(0)
    '    End If
    'End Function

    Public Sub ClearAllField()
        If btnSubmit.Text = "Update" Then
            btnSubmit.Text = "Submit"
        End If
        clearInfo(gbBasicInfo)
        clearInfo(gbPriceInformation)
        clearInfo(gbPaymentInformation)
        lvOrder.Items.Clear()
        cboTips.SelectedIndex = -1
        cboDiscount.SelectedIndex = -1
        lblTotalOrderPrice.Text = ""

        txtCustomerNo.Text = "New Customer"
        chkReprint.Enabled = False
        If chkReprint.Checked = True Then
            chkReprint.Checked = False
        End If

    End Sub

    Private Sub InsertItemsOrderedToDb(ByVal tmpSQL As String)

        Dim cmdInsertOrder_Info As SqlClient.SqlCommand

        Try
            cmdInsertOrder_Info = New SqlClient.SqlCommand
            cmdInsertOrder_Info.Connection = mdDBConnection.connRestuarant
            cmdInsertOrder_Info.CommandText = tmpSQL
            cmdInsertOrder_Info.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Sub

    Private Function GetCustomerId() As Integer
        Dim strSQL As String

        Dim iDataSetRow As Integer

        Dim iCustomerId As Integer
        Dim dsCustomerId As DataSet
        Dim daCustomerId As SqlClient.SqlDataAdapter

        strSQL = "SELECT MAX(nCust_Id) FROM tCust_Info"

        Try
            dsCustomerId = New DataSet("OrderId")
            daCustomerId = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCustomerId.Fill(dsCustomerId, "OrderId")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iDataSetRow = dsCustomerId.Tables("OrderId").Rows.Count

        If IsDBNull(dsCustomerId.Tables("OrderId").Rows(0).Item(0)) = False Then
            iCustomerId = dsCustomerId.Tables("OrderId").Rows(0).Item(0) + 1
        Else
            iCustomerId = 1
        End If
        GetCustomerId = iCustomerId
    End Function

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click

        Dim iCountDataSetRow As Integer
        Dim strSQL As String


        Dim dsDineInfo As DataSet
        Dim daDineInfo As SqlClient.SqlDataAdapter
        Dim objfrmPaymentStatus As New frmPaymentStatus

        ClearAllField()
        txtNetPay.Text = ""
        cboDiscount.Text = ""
        cboCardType.Text = ""
        cboTips.Text = ""
        txtChange.Text = ""
        lbQty.Text = ""
        btnPayBill.Enabled = True
        btnPay.Enabled = True
        Me.lvOrder.Columns(0).Width = 0
        Me.lvOrder.Columns(1).Width = 45

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
            objfrmPaymentStatus.pnlPassword.Visible = False
            objfrmPaymentStatus.btnLookUpOk.Visible = True
            objfrmPaymentStatus.btnCancel.Visible = True
            objfrmPaymentStatus.FillPaymentStatus(dsDineInfo)
            objfrmPaymentStatus.ShowDialog()

            If strfindcode <> vbNullString Then
                iOrderId = strfindcode
                iCustomerId = strfindDesc
                txtTableId.Tag = iOrderId
                PutDataIntoCustomerInfo(iCustomerId)
                PutDataIntoOrderInfo(strfindcode)
                PutDataIntoPaymentInfo(strfindcode)
                btnSubmit.Text = "Update"
                Call CalculateTotalPrice()
                Call CalculatePrice()
                Call calculatetotalItem()
                chkReprint.Enabled = True
                If chkReprint.Checked = True Then
                    chkReprint.Checked = False
                End If

                Me.tabTakeaway.SelectedIndex = 2

            End If
            'Me.lvOrder.Columns(0).Width = 30
            'Me.lvOrder.Columns(1).Width = 30
            strfindcode = vbNullString

        Else
            MessageBox.Show("There is no Due payment to show", "DineIn", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PutDataIntoCustomerInfo(ByVal tmpCustomerId As Integer)

        Dim strSQL As String
        Dim iCountDataSetRow As Integer

        Dim dsCustomerInfo As DataSet
        Dim daCustomerInfo As SqlClient.SqlDataAdapter

        strSQL = "SELECT * FROM tCust_Info WHERE nCust_Id=" + CStr(tmpCustomerId) + ""

        Try
            dsCustomerInfo = New DataSet("CustomerInfo")
            daCustomerInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCustomerInfo.Fill(dsCustomerInfo, "CustomerInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsCustomerInfo.Tables("CustomerInfo").Rows.Count
        If iCountDataSetRow > 0 Then
            txtCustomerNo.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(0) & vbNullString
            txtName.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(1) & vbNullString
            txtCompany.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(5) & vbNullString
            txtEmail.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(9) & vbNullString
            txtComment.Text = dsCustomerInfo.Tables("CustomerInfo").Rows(0).Item(13) & vbNullString
        Else
            MessageBox.Show("There is no customer information against this order", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dsCustomerInfo = Nothing
        daCustomerInfo = Nothing
    End Sub

    Private Sub PutDataIntoOrderInfo(ByVal tmpOrderId As Integer)

        Dim strSQL As String
        Dim iCountDataSetRow As Integer
        Dim iIndex As Integer
        Dim iItemQuantity As Integer

        Dim dUnitPrice As Double
        Dim dTotalPrice As Double

        Dim dsOrderInfo As DataSet
        Dim daOrderInfo As SqlClient.SqlDataAdapter

        strSQL = "SELECT O.nItem_Qty,I.cItem_SC,O.mUnitPrice,O.cInstruction,O.nItem_Id,I.nItem_Stock," & _
                 "I.cItem_ServeLoc,T.cType_Name,I.nType_Id,T.nCtgry_Id FROM tOrdered_Item O,tItem I, tType T " & _
                 "WHERE O.nOrder_Id=" + CStr(tmpOrderId) + " AND O.nItem_Id=I.nItem_Id AND " & _
                 "I.nType_Id=T.nType_Id ORDER BY O.nItem_Id"

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
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(8))) 'For adding Type Name
                lvOrder.Items(iIndex).SubItems.Add(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndex).Item(9))) 'For adding Type Name
                'lvOrder.Items(iIndex).Checked = False     'stop on 27.01.08 milton
                lvOrder.Items(iIndex).SubItems.Add(iItemQuantity)

            Next
            Me.lvOrder.Columns(0).Width = 30
            Me.lvOrder.Columns(1).Width = 30
            ListView_CatagorySort_pending(lvOrder, 10, VariantType.Integer)
            'Me.lvOrder.Columns (10). = SortOrder.Ascending
            'Me.lvOrder.ListViewItemSorter = New ListViewComparer(10, SortOrder.Ascending)
            'New ListViewComparer(e.Column, sort_order)
            ListView_TypeSort_pending(lvOrder, 9, VariantType.Integer)

        Else
            MessageBox.Show("There is no Order information against this order", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dsOrderInfo = Nothing
        daOrderInfo = Nothing
    End Sub

    Private Sub PutDataIntoPaymentInfo(ByVal tmpOrderId As Integer)
        Dim strSQL As String
        Dim iCountDataSetRow As Integer

        Dim dDiscount As Double
        Dim dTotalPrice As Double
        Dim CbodDiscount As Double
        Dim CbodTips As Double

        Dim dsPaymentInfo As DataSet
        Dim daPaymentInfo As SqlClient.SqlDataAdapter

        strSQL = "SELECT P.mTotalPrice,P.mDiscount,P.mService_Charge,P.mNetpay,P.nTable_Id,P.nNumberofGuests,T.cTableNumber,P.nOrder_Id,P.perdiscount,P.perservice " & _
                 "FROM tOrder_Payment P,tTable_Info T WHERE P.nOrder_Id=" + CStr(tmpOrderId) + " AND P.nTable_Id=T.nTable_Id"

        Try
            dsPaymentInfo = New DataSet("PaymentInfo")
            daPaymentInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daPaymentInfo.Fill(dsPaymentInfo, "PaymentInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsPaymentInfo.Tables("PaymentInfo").Rows.Count

        If iCountDataSetRow > 0 Then
            txtTotalPrice.Text = FormatCurrency(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(0))
            lblTotalOrderPrice.Text = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(0) & vbNullString
            txtDiscount.Text = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(1) & vbNullString

            If txtDiscount.Text <> vbNullString Then
                dDiscount = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(1)
                txtDiscount.Text = FormatCurrency(dDiscount)
            Else
                dDiscount = 0
            End If

            txtTips.Text = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(2) & vbNullString
            txtNetPay.Text = FormatCurrency(dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(3))
            txtTableId.Text = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(4) & vbNullString
            txtGuestNumber.Text = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(5) & vbNullString
            dTotalPrice = txtTotalPrice.Text

            'If dTotalPrice <> 0 Then
            '    dDiscount = (dDiscount * 100) / dTotalPrice
            'Else
            '    dDiscount = 0
            'End If
            ' cboDiscount.Text = Format(dDiscount, "##.##")
            txtTableNo.Text = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(6) & vbNullString
            txtnOrderId.Text = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(7) & vbNullString
            ' cboDiscount.Text = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(8) & vbNullString
            CbodDiscount = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(8) & vbNullString
            If CbodDiscount > 0 Then
                cboDiscount.Text = CbodDiscount
            End If
            ' cboTips.Text = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(9) & vbNullString
            CbodTips = dsPaymentInfo.Tables("PaymentInfo").Rows(0).Item(9) & vbNullString
            If CbodTips > 0 Then
                cboTips.Text = CbodTips
            End If
            txtUpdate.Text = txtTableId.Text
        Else
            MessageBox.Show("There is no Payment information against this order", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

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

        'If txtCashPay.Text > txtCardPay.Text And txtCashPay.Text > txtChequePay.Text Then

        '    dCashPay = GetCashPayAmount()
        '    dCardPay = GetCardPayAmount()
        '    dCheque = GetChequePayAmount()

        'ElseIf txtCardPay.Text > txtCashPay.Text And txtCardPay.Text > txtChequePay.Text Then

        '    dCardPay = GetCardPayAmount()
        '    dCashPay = GetCashPayAmount()
        '    dCheque = GetChequePayAmount()

        'ElseIf txtChequePay.Text > txtCashPay.Text And txtChequePay.Text > txtCardPay.Text Then

        '    dCheque = GetChequePayAmount()
        '    dCashPay = GetCashPayAmount()
        '    dCardPay = GetCardPayAmount()
        'Else

        dCashPay = GetCashPayAmount()
        dCardPay = GetCardPayAmount()
        dCheque = GetChequePayAmount()

        ' End If


        Try
            strSQL = "UPDATE tOrder_Payment SET nOrderStatus=1, mDiscount=" + CStr(dDiscount) + ",mService_Charge=" + _
                     CStr(dTips) + ",mNetpay=" + CStr(dNetPrice) + ",mCashPayAmount=" + CStr(dCashPay) + _
                     ",mCardPayAmount=" + CStr(dCardPay) + ",cCardType='" + Trim(cboCardType.Text) + _
                     "',mChequeAmount=" + CStr(dCheque) + ",cChequeNumber='" + Replace(Trim(txtChequeNo.Text), "'", "''") + "',cBankName='" + _
                     Replace(Trim(txtBankName.Text), "'", "''") + "',cUserId='" + user + "',cTerminal='" + sTerminal + _
                     "',dAccessTime=GETDATE() WHERE nOrder_Id=" + CStr(Trim(txtTableId.Tag)) + ""


            cmdUpdateStatus = New SqlClient.SqlCommand
            cmdUpdateStatus.Connection = mdDBConnection.connRestuarant
            cmdUpdateStatus.CommandText = strSQL
            cmdUpdateStatus.ExecuteNonQuery()

            strSQL = "UPDATE tTable_Info SET nStatus=0 WHERE nTable_Id=" + CStr(txtTableId.Text) + ""
            cmdUpdateStatus.CommandText = strSQL
            cmdUpdateStatus.ExecuteNonQuery()
            btnSubmit.Enabled = True
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        cmdUpdateStatus = Nothing
        txtCustomerNo.Tag = ""
    End Function

    Private Function OpenCashDrawer()
        Dim objPrintDirect As New PrintDirect
        objPrintDirect.OpenCashDrawer(mdConfiguration.sBillPrinter)
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
            btBillPrint.Enabled = False
            btnKitchPrint.Enabled = False
            btnAllPrint.Enabled = False
            btnPayBill.Enabled = False
            If btnPay.Enabled = False Then
                MsgBox("This Order Already Paid", MsgBoxStyle.Information)
                Exit Sub
            End If
            If lvOrder.CheckBoxes = True Then                 ' If btnSubmit.Text = "Update" Then
                UpdateOrder()
                If bPrint = True Then
                    UpdateOrderStatus()
                    OpenCashDrawer()
                End If
            Else
                If lvOrder.CheckBoxes = False Then            'If btnSubmit.Text = "Submit" Then
                    InsertNewOrder()
                    If bPrint = True Then
                        UpdateOrderStatus()
                        OpenCashDrawer()
                    End If
                End If
            End If
        End If
        ' End If

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
            btBillPrint.Enabled = False
            btnKitchPrint.Enabled = False
            btnAllPrint.Enabled = False
            btnPay.Enabled = False
            If btnPayBill.Enabled = False Then
                PrintBill()
                Exit Sub
            End If
            If lvOrder.CheckBoxes = True Then             'If btnSubmit.Text = "Update" Then
                UpdateOrder()
                If bPrint = True Then
                    UpdateOrderStatus()
                    PrintBill()
                    OpenCashDrawer()
                    btnPayBill.Enabled = False
                End If
            ElseIf lvOrder.CheckBoxes = False Then        'btnSubmit.Text = "Submit" Then
                InsertNewOrder()
                If bPrint = True Then
                    UpdateOrderStatus()
                    PrintBill()
                    OpenCashDrawer()
                    btnPayBill.Enabled = False
                End If
            End If
        End If
        ' End If
        Dim frmNew As New frmDine
        frmNew.Show()
        Me.Dispose()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ClearAllField()
    End Sub

    'print command for desktop

    Private Function PrintOrder()

        Dim i As Integer
        Dim PaperHeight As Integer
        Dim iMaxItemLen As Integer = 0
        Dim iMaxItemQtyLen As Integer = 0
        Dim iKitchenItem As Integer = 0
        Dim iKitchenItemMain As Integer = 0
        Dim iBarItem As Integer = 0
        Dim iItemInfoKitchenStarters As Integer = 0
        Dim iItemInfoKitchenStartersItalic As Integer = 0
        Dim iKitchenItemMainItalic As Integer = 0

        Dim strOrderDate As String = vbNewLine + "Date: " + DateTime.Parse(GetOrderDate()).ToString("dd/MM/yyyy") _
                                     + vbNewLine + "Time:" + DateTime.Parse(GetOrderDate()).ToString("hh:mm:ss tt") + vbNewLine
        Dim strCustInfo As String = "Table Id: " + txtTableNo.Text + vbNewLine
        Dim strGuestNumber As String = "Guest Number: " + Trim(txtGuestNumber.Text) + vbNewLine + vbNewLine

        Dim strItemInfoKitchenStarters As String
        Dim strItemInfoKitchenStartersItalic As String
        Dim strItemInfoKitchenMain As String
        Dim strItemInfoKitchenMainItalic As String
        Dim strItemInfoBar As String
        Dim tmptext As String
        Dim tmpTypeName As String

        Dim TotalQty As Integer
        Dim PendingQty As Integer
        Dim NewQty As Integer

        Dim tmpTypeNamePrefix As String
        tmpTypeNamePrefix = Trim(GetSetting("Restaurant", "FormSetting", "TypePrefix"))

        Dim tmpTypeNamePrefixItalic As String
        tmpTypeNamePrefixItalic = Trim(GetSetting("Restaurant", "FormSetting", "TypePrefixItalic"))

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
            If lvOrder.CheckBoxes = False Then
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
                    ObjrstPrinter.ItemText = strUser + strCustInfo + strGuestNumber + strItemInfoBar
                    ObjrstPrinter.Print()
                    objPrintDirect.OnCutter(mdConfiguration.sBarPrinter)
                    ObjrstPrinter.DateText = ""
                    ObjrstPrinter.DateHeight = 0
                    ObjrstPrinter.ItemStarterText = ""
                    ObjrstPrinter.ItemStarterHeight = 0
                    ObjrstPrinter.ItemStarterItalicText = ""
                    ObjrstPrinter.ItemStarterItalicHeight = 0
                    ObjrstPrinter.ItemText = ""
                    ObjrstPrinter.ItemHeight = 0
                    ObjrstPrinter.ItemTextItalic = ""
                    ObjrstPrinter.ItemItalicHeight = 0
                    ObjrstPrinter.FooterText = ""
                    ObjrstPrinter.FooterHeight = 0
                Else
                    'MsgBox("Please select a printer for Bar.", MsgBoxStyle.Information, "Takeaway")
                End If
            End If

            If iKitchenItem > 0 Then
                If mdConfiguration.sOrderPrinter <> vbNullString Then
                    ObjrstPrinter.PrinterSettings.PrinterName = mdConfiguration.sOrderPrinter
                    ObjrstPrinter.DateText = strOrderDate
                    ObjrstPrinter.ItemFont = New Font("Lucida Console", 12, FontStyle.Bold)
                    ObjrstPrinter.ItemStarterText = strUser + strCustInfo + strGuestNumber + strItemInfoKitchenStarters
                    ObjrstPrinter.ItemStarterItalicText = strItemInfoKitchenStartersItalic
                    ObjrstPrinter.ItemText = strItemInfoKitchenMain
                    ObjrstPrinter.ItemTextItalic = strItemInfoKitchenMainItalic
                    ObjrstPrinter.Print()
                    objPrintDirect.OnCutter(mdConfiguration.sOrderPrinter)
                Else
                    MsgBox("Please select a printer for kitchen.", MsgBoxStyle.Information, "Dine In")
                End If
                'new added  for KP1
                If mdConfiguration.sOrderPrinter1 <> vbNullString Then
                    ObjrstPrinter.PrinterSettings.PrinterName = mdConfiguration.sOrderPrinter1
                    ObjrstPrinter.DateText = strOrderDate
                    ObjrstPrinter.ItemFont = New Font("Lucida Console", 12, FontStyle.Bold)
                    ObjrstPrinter.ItemStarterText = strUser + strCustInfo + strGuestNumber + strItemInfoKitchenStarters
                    ObjrstPrinter.ItemStarterItalicText = strItemInfoKitchenStartersItalic
                    ObjrstPrinter.ItemText = strItemInfoKitchenMain
                    ObjrstPrinter.ItemTextItalic = strItemInfoKitchenMainItalic
                    ObjrstPrinter.Print()
                    objPrintDirect.OnCutter(mdConfiguration.sOrderPrinter1)
                Else
                    'MsgBox("Please select a printer for kitchen Printer2", MsgBoxStyle.Information, "Dine In")
                End If
            End If
        End If

    End Function

    Private Function SpaceCalculation(ByVal strText As String) As Integer
        Dim SpaceLength As Integer
        Dim wordlength As Integer = Len(strText)
        SpaceLength = (32 / 2 - wordlength / 2) - 2
        If SpaceLength < 0 Then
            SpaceCalculation = 0
        Else
            SpaceCalculation = SpaceLength
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
        Dim strwebAddress As String
        Dim strEmailAddress As String
        Dim strFooter As String
        Dim strItemInformation As String
        Dim strAfterDISandSER As String
        Dim strItemInfoHeader As String
        Dim strItemPrice As String
        Dim strDis As String
        Dim strTips As String
        Dim strOrderId As String
        Dim strTableId As String
        Dim strCash As String
        Dim strCard As String
        Dim srtCheque As String
        Dim srtChange As String

        strOrderDate = "Date: " + DateTime.Parse(GetOrderDate()).ToString("dd/MM/yyyy") _
                                     + vbNewLine + "Time:" + DateTime.Parse(GetOrderDate()).ToString("hh:mm:ss tt") + vbNewLine
        If Len(Trim(mdConfiguration.strResturantName)) > 0 Then
            strCompanyName = Space(SpaceCalculation(Trim(mdConfiguration.strResturantName)) - 4) _
                             + mdConfiguration.strResturantName 'To print Restaurant name
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
            strCompanyPhone = Space((SpaceCalculation(strPhone)) - 2) + "Tel:" _
                              + Trim(mdConfiguration.strRestuarantPhone) + vbNewLine  'To print Restaurant Phone

        Else
            strCompanyPhone = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantPhone)) > 0 Then
            strVatNumber = Space(SpaceCalculation(Trim(mdConfiguration.strVatNumber)) - 6) + "Vat Number: " _
                           + Trim(mdConfiguration.strVatNumber) + vbNewLine 'To print Restaurant VatNumber
        Else
            strVatNumber = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantWeb)) > 0 Then
            strwebAddress = Space(SpaceCalculation(Trim(mdConfiguration.strRestuarantWeb))) _
            + Trim(mdConfiguration.strRestuarantWeb) + vbNewLine                            'To print Restaurant VatNumber
        Else
            strwebAddress = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantEmail)) > 0 Then
            strEmailAddress = Space(SpaceCalculation(Trim(mdConfiguration.strRestuarantEmail))) _
            + Trim(mdConfiguration.strRestuarantEmail) + vbNewLine                          'To print Restaurant Email address
        Else
            strEmailAddress = ""
        End If

        strTableId = "Table Id: " + CStr(Trim(txtTableNo.Text)) + vbNewLine
        Dim strGuestNumber As String = "Guest Number: " + Trim(txtGuestNumber.Text) + vbNewLine + vbNewLine

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
            'Dim strDiscountPrice As String = IIf(strDis <> "", "Discount:" + Space(29 - (Len(Trim("Discount:")) + Len(Trim(strDis)) + 1)) + strDis, "")


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

            'Dim strTipsAmount As String = IIf(strTips <> "", "Service Charge:" + Space(29 - (Len(Trim("Service Charge:")) + Len(Trim(strTips)) + 1)) + strTips + vbNewLine, "")
            Dim strTipsAmount As String = IIf(strTips <> "", "s.charge:      " + Space(32 - (Len(Trim("Service Charge:")) + Len(Trim(strTips)) + 1)) + strTips + vbNewLine, "")

            'Dim strNetPay As String = "Grand Total:" + Space(29 - (Len(Trim("Grand Total:")) + Len(Trim(txtNetPay.Text)) + 1)) + txtNetPay.Text + vbNewLine + vbNewLine
            Dim strNetPay As String = "Total  :" + Space(30 - (Len(Trim("Grand Total:")) + Len(Trim(txtNetPay.Text)) + 1)) + txtNetPay.Text '+ vbNewLine
            Dim strCardType As String
            If Len(Trim(txtChange.Text)) > 0 Then
                strCash = IIf(Trim(txtCashPay.Text) <> "", "Cash given:" + Space(32 - (Len(Trim("Cash given:")) + _
                          Len(Trim(txtCashPay.Text)) + 1)) + Trim(txtCashPay.Text) + vbNewLine, "")
                strCard = IIf(Trim(txtCardPay.Text) = "", "", "Payment in card:" + _
                          Space(32 - (Len(Trim("Payment in card:")) + Len(Trim(txtCardPay.Text)) + 1)) + txtCardPay.Text + vbNewLine)
                If strCard <> "" Then
                    ' If Trim(cboCardType.Text) = vbNullString Then
                    ' MsgBox("Please select a card type.", MsgBoxStyle.Information, "Dine In")
                    'cboCardType.Focus()
                    ' Exit Function
                    ' Else
                    strCardType = "Card Type:" + Space(32 - (Len(Trim("Card Type:")) + Len(Trim(cboCardType.Text)) + 1)) + Trim(cboCardType.Text) + vbNewLine
                    strCard += strCardType
                    ' End If
                End If
                srtCheque = IIf(Trim(txtChequePay.Text) <> "", "Cheque Payment:" + Space(32 - (Len(Trim("Cheque Payment:")) + _
                            Len(Trim(txtChequePay.Text)) + 1)) + Trim(txtChequePay.Text) + vbNewLine, "")
                srtChange = IIf(Trim(txtChange.Text) <> "", "Change:" + Space(32 - (Len(Trim("Change: ")) + _
                            Len(Trim(txtChange.Text)) + 1)) + Trim(txtChange.Text) + vbNewLine, "")
            End If

            Dim strUser As String = Space(SpaceCalculation(struserName) - 6) + "Taken By: " + struserName

            Dim strPrintItem As String
            Dim strNetpayItem As String
            Dim strviapaid As String
            strAfterDISandSER = "                   ------------"

            strPrintItem = strItemInformation + strItemPrice + strDiscountPrice + strTipsAmount + strAfterDISandSER '+ strNetPay
            strNetpayItem = strNetPay  'added on requriment For netpaybold 23.10.07

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
                                            + vbNewLine + vbNewLine
                ObjbillrstPrinter.ItemText = strTableId + strGuestNumber + vbNewLine + strPrintItem '+ vbNewLine
                'ObjrstPrinter.ItemFo = New Font("Lucida Console", 12, FontStyle.Bold)
                ObjbillrstPrinter.NetpayText = strNetpayItem '+ vbNewLine
                ObjbillrstPrinter.ViaPaidText = strviapaid
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

        If Trim(txtTableNo.Text) = vbNullString Then
            MessageBox.Show("No Table is selected for order." & vbCrLf & "Please select one table.", "Dine In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Trim(txtGuestNumber.Text) = vbNullString Then
            MessageBox.Show("Please give number of guests.", "Dine In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf lvOrder.Items.Count = 0 Then
            MessageBox.Show("There is no Item For Order." & vbCrLf & "Please select one or more", "Dine In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            btBillPrint.Enabled = False
            btnKitchPrint.Enabled = False
            btnAllPrint.Enabled = False
            If lvOrder.CheckBoxes = True Then           'If btnSubmit.Text = "Update" Then "for new button milton 31.01.08" 
                Call UpdateOrder()
                If bPrint = True Then
                    PrintBill()
                    PrintOrder()
                End If
            ElseIf lvOrder.CheckBoxes = False Then     'btnSubmit.Text = "Submit" Then   "for new button milton 31.01.08"
                Call InsertNewOrder()
                If bPrint = True Then
                    PrintBill()
                    PrintOrder()
                    btnSubmit.Text = "Update"
                End If
            End If
        End If
        Dim frmNew As New frmDine
        frmNew.Show()
        Me.Dispose()
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

    Private Sub txtGuestNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGuestNumber.TextChanged
        If Trim(txtGuestNumber.Text) <> vbNullString Then
            ValidationForNumaricData(txtGuestNumber)
            If Trim(mdConfiguration.strResturantName) = vbNullString Then
                If Trim(txtTableNo.Text) <> vbNullString Then
                    stxtMain.ScrollText = "UySys eRestuarant " & ":Dine In, " & " Table- " & Trim(txtTableNo.Text) & ", Guest- " & Trim(txtGuestNumber.Text)
                Else
                    stxtMain.ScrollText = "UySys eRestuarant " & ": Dine In" & ", Guest- " & Trim(txtGuestNumber.Text)
                End If
            Else
                If Trim(txtTableNo.Text) <> vbNullString Then
                    stxtMain.ScrollText = mdConfiguration.strResturantName & ":Dine In, " & " Table- " & Trim(txtTableNo.Text) & ", Guest- " & Trim(txtGuestNumber.Text)
                Else
                    stxtMain.ScrollText = mdConfiguration.strResturantName & ": Dine In" & ", Guest- " & Trim(txtGuestNumber.Text)
                End If
            End If
        Else
            If Trim(mdConfiguration.strResturantName) = vbNullString Then
                If Trim(txtTableNo.Text) <> vbNullString Then
                    stxtMain.ScrollText = "UySys eRestuarant " & ":Dine In, " & " Table- " & Trim(txtTableNo.Text)
                Else
                    stxtMain.ScrollText = "UySys eRestuarant " & ": Dine In"
                End If
            Else
                If Trim(txtTableNo.Text) <> vbNullString Then
                    stxtMain.ScrollText = mdConfiguration.strResturantName & ":Dine In, " & " Table- " & Trim(txtTableNo.Text)
                Else
                    stxtMain.ScrollText = mdConfiguration.strResturantName & ": Dine In"
                End If
            End If
        End If
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        If Trim(txtTotalPrice.Text) <> vbNullString Then
            ValidationForNumaricData(txtDiscount)
            CalculateDiscount()
            CalculatePrice()
        End If
    End Sub

    Private Sub txtTotalPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalPrice.TextChanged

        If Trim(txtTotalPrice.Text) <> vbNullString Then
            CalculateTipsAmount()
            CalculateDiscoutAmount()
            CalculatePrice()

        End If
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
        'cboDiscount.Text = Format(dDiscountedValue, "00.00")
        'cboDiscount.Text = Format(dDiscountedValue, "00")
    End Function

    Private Sub cboDiscount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiscount.SelectedIndexChanged
        CalculateDiscoutAmount()
    End Sub

    Private Sub cboTips_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTips.SelectedIndexChanged
        CalculateTipsAmount()
    End Sub

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
        'cboTips.Text = Format(dTipsAmount, "00.00")

    End Function

    Private Sub txtTips_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTips.GotFocus
        conControlName = txtTips
        If Trim(txtTips.Text) <> vbNullString Then
            txtTips.Text = FormatNumber(txtTips.Text)
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtDiscount)
    End Sub

    Private Sub txtGuestNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuestNumber.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtGuestNumber)
    End Sub

    Private Sub cboDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDiscount.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, cboDiscount)
    End Sub

    Private Sub txtTips_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTips.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtTips)
    End Sub

    Private Sub txtCashPay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashPay.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtCashPay)
    End Sub

    Private Sub txtCardPay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardPay.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtCardPay)
    End Sub

    Private Sub txtChequePay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChequePay.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtChequePay)
    End Sub

    Private Sub btnRefreshMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshMenu.Click
        lvOrder.Items.Clear()
        lblTotalOrderPrice.Text = ""
    End Sub

    Private Sub txtChange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChange.TextChanged
        EnablePaymentButton()
    End Sub

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

    Private Sub frmDine_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub btntillOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntillOpen.Click
        Dim objPrintDirect As New PrintDirect
        objPrintDirect.OpenCashDrawer(mdConfiguration.sBillPrinter)
    End Sub

    Private Sub chkReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReprint.Click
        Dim iItemCount As Integer
        Dim iIndex As Integer
        iItemCount = lvOrder.Items.Count
        If iItemCount > 0 Then
            If lvOrder.CheckBoxes = True Then
                If chkReprint.Checked = True Then
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim Itype As Integer
        Itype = MsgBox("Do you want to Exit", MsgBoxStyle.YesNo, "eRestuarant")
        If Itype = MsgBoxResult.Yes Then
            Application.Exit()
            Dim thisProcess = Process.GetCurrentProcess
            thisProcess.Kill()
            'Application.Exit()
        End If
    End Sub

    Private Sub btnZeroToNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click, btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click, btnSix.Click, btnSeven.Click, btnEight.Click, btnNine.Click
        If Len(Trim(txtGuestNumber.Text)) < 4 Then
            If sender.Text = 0 Then
                If Len(Trim(txtGuestNumber.Text)) > 0 Then
                    txtGuestNumber.Text += sender.Text
                End If
            Else
                txtGuestNumber.Text += sender.Text
            End If
        End If
    End Sub

    Private Sub btnBackSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackSpace.Click
        If txtGuestNumber.Text.Length > 0 Then
            txtGuestNumber.Text = txtGuestNumber.Text.Remove(txtGuestNumber.Text.Length - 1, 1)
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

    Private Sub cboTips_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTips.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, cboTips)
    End Sub

    Private Function UpdateDateWithCurrentDate()
        Dim strSQL As String
        Dim cmdUpdateDate As New SqlClient.SqlCommand

        strSQL = "UPDATE tOrder_Payment SET dAccessTime=GETDATE() WHERE dAccessTime='1/1/1900' AND cTerminal LIKE '%PDA'"

        Try
            cmdUpdateDate.Connection = mdDBConnection.connRestuarant
            cmdUpdateDate.CommandText = strSQL
            cmdUpdateDate.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Function

    Private Sub txtPDAPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPDAPrint.Click
        Call PrintfromPDA()
    End Sub

    Public Function PrintfromPDA()
        Dim iCountDataSetRow As Integer
        Dim iCOunt As Integer
        Dim iIndex As Integer
        Dim iIndexforItem As Integer
        Dim iOrderId As Integer
        Dim iItemQuantity As Integer

        Dim dUnitPrice As Double
        Dim dTotalPrice As Double

        Dim strSQL As String
        Dim strStartingTime As String
        Dim strEndingTime As String


        Dim dsDineInfo As DataSet
        Dim dsTableInfo As DataSet
        Dim dsOrderInfo As DataSet

        Dim daDineInfo As SqlClient.SqlDataAdapter
        Dim Dptime As String
        Dim pdatime As String
        pdatime = DateTime.Parse(Date.Today.Now).ToString(" yyyy/MM/dd HH:mm:ss  ")

        Dptime = GetSetting("Restaurant", "DPStartTime", "StartTime")

        If Dptime = vbNullString Then
            Dim StartTime As String
            StartTime = DateTime.Parse(Date.Today.Now).ToString(" yyyy/MM/dd HH:mm:ss  ")
            SaveSetting("Restaurant", "DPStartTime", "StartTime", StartTime)

        Else
            strSQL = "SELECT nOrder_Id,dOrder_date FROM tOrder_Payment WHERE nOrderStatus=0 AND nTable_Id<>0 " & _
               " AND cTerminal LIKE '%PDA'AND dAccessTime BETWEEN '" + Dptime + "' AND '" + pdatime + "' "                         'AND dAccessTime ='1/1/1900'

            Try
                dsDineInfo = New DataSet("DineInfo")
                daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                daDineInfo.Fill(dsDineInfo, "DineInfo")
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
            iCountDataSetRow = dsDineInfo.Tables("DineInfo").Rows.Count

            If iCountDataSetRow > 0 Then
                For iIndex = 0 To iCountDataSetRow - 1
                    Dim strTableNumber As String
                    Dim strGuestNumber As String

                    Dim lvOrder As New System.Windows.Forms.ListView
                    Dim cQty As New System.Windows.Forms.ColumnHeader
                    Dim cItem As New System.Windows.Forms.ColumnHeader
                    Dim cPrice As New System.Windows.Forms.ColumnHeader
                    Dim cInstruction As New System.Windows.Forms.ColumnHeader
                    Dim cItemId As New System.Windows.Forms.ColumnHeader
                    Dim cStockInHand As New System.Windows.Forms.ColumnHeader
                    Dim cServeLocation As New System.Windows.Forms.ColumnHeader
                    Dim cTypeName As New System.Windows.Forms.ColumnHeader

                    iOrderId = dsDineInfo.Tables("DineInfo").Rows(iIndex).Item(0)

                    strSQL = "SELECT nTable_Id,nNumberofGuests FROM tOrder_Payment WHERE nOrder_Id=" & CStr(iOrderId) & ""

                    Try
                        dsTableInfo = New DataSet("TableInfo")
                        daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                        daDineInfo.Fill(dsTableInfo, "TableInfo")
                    Catch ex As Exception
                        MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                    End Try

                    iCOunt = dsTableInfo.Tables("TableInfo").Rows.Count

                    If iCOunt Then
                        strTableNumber = dsTableInfo.Tables("TableInfo").Rows(0).Item(0)
                        strGuestNumber = dsTableInfo.Tables("TableInfo").Rows(0).Item(1)
                    End If

                    strSQL = "SELECT cTableNumber FROM tTable_Info WHERE nTable_Id=" & CStr(strTableNumber) & ""

                    Try
                        dsTableInfo = New DataSet("TableInfo")
                        daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                        daDineInfo.Fill(dsTableInfo, "TableInfo")
                    Catch ex As Exception
                        MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                    End Try

                    strTableNumber = dsTableInfo.Tables("TableInfo").Rows(0).Item(0)

                    strSQL = "SELECT O.nItem_Qty,I.cItem_SC,I.mDinePrice,O.cInstruction,O.nItem_Id,I.nItem_Stock," & _
                             "I.cItem_ServeLoc,T.cType_Name FROM tOrdered_Item O,tItem I, tType T " & _
                             "WHERE O.nOrder_Id=" + CStr(iOrderId) + " AND O.nItem_Id=I.nItem_Id AND I.nType_Id=T.nType_Id"

                    Try
                        dsOrderInfo = New DataSet("OrderInfo")
                        daDineInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                        daDineInfo.Fill(dsOrderInfo, "OrderInfo")
                    Catch ex As Exception
                        MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                    End Try

                    iCOunt = dsOrderInfo.Tables("OrderInfo").Rows.Count

                    lvOrder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {cQty, cItem, cPrice, cInstruction, cItemId, cStockInHand, cServeLocation, cTypeName})

                    If iCOunt > 0 Then
                        For iIndexforItem = 0 To iCOunt - 1
                            lvOrder.Items.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(0))
                            lvOrder.Items(iIndexforItem).SubItems.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(1))

                            iItemQuantity = CInt(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(0))
                            dUnitPrice = CDbl(Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(2)))
                            dTotalPrice = iItemQuantity * dUnitPrice

                            lvOrder.Items(iIndexforItem).SubItems.Add(FormatCurrency(dTotalPrice))
                            If Trim(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(3)) <> vbNullString Then
                                lvOrder.Items(iIndexforItem).SubItems.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(3))
                            Else
                                lvOrder.Items(iIndexforItem).SubItems.Add("")
                            End If

                            lvOrder.Items(iIndexforItem).SubItems.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(4))
                            lvOrder.Items(iIndexforItem).SubItems.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(5))
                            lvOrder.Items(iIndexforItem).SubItems.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(6))
                            lvOrder.Items(iIndexforItem).SubItems.Add(dsOrderInfo.Tables("OrderInfo").Rows(iIndexforItem).Item(7))
                        Next
                    End If
                    PrintOrder(strTableNumber, strGuestNumber, lvOrder)
                    Dim StartTime As String
                    StartTime = DateTime.Parse(Date.Today.Now).ToString(" yyyy/MM/dd HH:mm:ss  ")
                    SaveSetting("Restaurant", "DPStartTime", "StartTime", StartTime) ', strEndingTime)
                    'UpdateDateWithCurrentDate()
                Next
            End If
        End If
    End Function

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
    'print order for PDA 
    Private Function PrintOrder(ByVal tmpTableNumber As String, ByVal tmpGuestNumber As String, ByVal tmplvOrder As System.Windows.Forms.ListView)

        Dim i As Integer
        Dim PaperHeight As Integer
        Dim iMaxItemLen As Integer = 0
        Dim iMaxItemQtyLen As Integer = 0
        Dim iKitchenItem As Integer = 0
        Dim iItemInfoKitchenStartersItalic As Integer = 0
        Dim iKitchenItemMain As Integer = 0
        Dim iKitchenItemMainItalic As Integer = 0

        Dim strItemInfoKitchenStartersItalic As String
        Dim strItemInfoKitchenMainItalic As String
        Dim iBarItem As Integer = 0
        Dim iItemInfoKitchenStarters As Integer = 0

        Dim strOrderDate As String = vbNewLine + "Date: " + DateTime.Parse(GetOrderDate()).ToString("dd/MM/yyyy") _
                                     + vbNewLine + "Time:" + DateTime.Parse(GetOrderDate()).ToString("hh:mm:ss tt") + vbNewLine
        Dim strCustInfo As String = "Table Id: " + tmpTableNumber + vbNewLine
        Dim strGuestNumber As String = "Guest Number: " + Trim(tmpGuestNumber) + vbNewLine + vbNewLine

        Dim strItemInfoKitchenStarters As String
        Dim strItemInfoKitchenMain As String
        Dim strItemInfoBar As String
        Dim tmptext As String
        Dim tmpTypeName As String

        Dim tmpTypeNamePrefix As String
        tmpTypeNamePrefix = Trim(GetSetting("Restaurant", "FormSetting", "TypePrefix"))

        If tmplvOrder.Items.Count > 0 Then
            For i = 0 To tmplvOrder.Items.Count - 1
                If Len(tmplvOrder.Items(i).SubItems(1).Text) > iMaxItemLen Then
                    iMaxItemLen = Len(tmplvOrder.Items(i).SubItems(1).Text)
                End If
                If Len(tmplvOrder.Items(i).SubItems(0).Text) > iMaxItemQtyLen Then
                    iMaxItemQtyLen = Len(tmplvOrder.Items(i).SubItems(0).Text)
                End If
            Next

            i = 0

            For i = 0 To tmplvOrder.Items.Count - 1
                tmptext = Trim(tmplvOrder.Items(i).SubItems(6).Text)
                tmpTypeName = Trim(tmplvOrder.Items(i).SubItems(7).Text).ToUpper
                If tmptext.ToUpper = "KITCHEN" Then
                    If strItemInfoKitchenStarters = vbNullString Then
                        strItemInfoKitchenStarters = "-----------------------" & vbNewLine
                    End If

                    If IsStarterType(tmpTypeName) = True Then
                        If IsItalicType(tmpTypeName) = True Then
                            strItemInfoKitchenStartersItalic += tmplvOrder.Items(i).SubItems(0).Text & Space((iMaxItemQtyLen - Len(tmplvOrder.Items(i).SubItems(0).Text)) + 2) & _
                                                                tmplvOrder.Items(i).SubItems(1).Text
                            If Trim(tmplvOrder.Items(i).SubItems(4).Text) <> "" Then
                                strItemInfoKitchenStartersItalic += Space((iMaxItemLen - Len(tmplvOrder.Items(i).SubItems(2).Text)) + 2) & vbNewLine & _
                                tmplvOrder.Items(i).SubItems(3).Text & vbNewLine & vbNewLine
                            Else
                                strItemInfoKitchenStartersItalic += vbNewLine & vbNewLine
                            End If
                            iItemInfoKitchenStartersItalic += 1
                        Else
                            strItemInfoKitchenStarters += tmplvOrder.Items(i).SubItems(0).Text & Space((iMaxItemQtyLen - Len(tmplvOrder.Items(i).SubItems(0).Text)) + 2) & _
                                                          tmplvOrder.Items(i).SubItems(1).Text
                            If Trim(tmplvOrder.Items(i).SubItems(4).Text) <> "" Then
                                strItemInfoKitchenStarters += Space((iMaxItemLen - Len(tmplvOrder.Items(i).SubItems(2).Text)) + 2) & vbNewLine & _
                                tmplvOrder.Items(i).SubItems(3).Text & vbNewLine & vbNewLine
                            Else
                                strItemInfoKitchenStarters += vbNewLine & vbNewLine
                            End If
                            iItemInfoKitchenStarters += 1
                        End If
                    Else
                        If IsItalicType(tmpTypeName) = True Then
                            strItemInfoKitchenMainItalic += tmplvOrder.Items(i).SubItems(0).Text & Space((iMaxItemQtyLen - Len(tmplvOrder.Items(i).SubItems(0).Text)) + 2) & _
                                                            tmplvOrder.Items(i).SubItems(1).Text
                            If Trim(tmplvOrder.Items(i).SubItems(4).Text) <> "" Then
                                strItemInfoKitchenMainItalic += Space((iMaxItemLen - Len(tmplvOrder.Items(i).SubItems(2).Text)) + 2) & vbNewLine & _
                                                               tmplvOrder.Items(i).SubItems(3).Text & vbNewLine & vbNewLine
                            Else
                                strItemInfoKitchenMainItalic += vbNewLine & vbNewLine
                            End If
                            iKitchenItemMainItalic += 1
                        Else
                            strItemInfoKitchenMain += tmplvOrder.Items(i).SubItems(0).Text & Space((iMaxItemQtyLen - Len(tmplvOrder.Items(i).SubItems(0).Text)) + 2) & _
                                                      tmplvOrder.Items(i).SubItems(1).Text
                            If Trim(tmplvOrder.Items(i).SubItems(4).Text) <> "" Then
                                strItemInfoKitchenMain += Space((iMaxItemLen - Len(tmplvOrder.Items(i).SubItems(2).Text)) + 2) & vbNewLine & _
                                                             tmplvOrder.Items(i).SubItems(3).Text & vbNewLine
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
                    strItemInfoBar += tmplvOrder.Items(i).SubItems(0).Text & Space((iMaxItemQtyLen - Len(tmplvOrder.Items(i).SubItems(0).Text)) + 2) & _
                                      tmplvOrder.Items(i).SubItems(1).Text
                    If Trim(tmplvOrder.Items(i).SubItems(4).Text) <> "" Then
                        strItemInfoBar += Space((iMaxItemLen - Len(tmplvOrder.Items(i).SubItems(2).Text)) + 2) & vbNewLine & _
                         tmplvOrder.Items(i).SubItems(3).Text & vbNewLine & vbNewLine
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
                    ObjrstPrinter.ItemText = strUser + strCustInfo + strGuestNumber + strItemInfoBar
                    ObjrstPrinter.Print()
                    objPrintDirect.OnCutter(mdConfiguration.sBarPrinter)
                    ObjrstPrinter.DateText = ""
                    ObjrstPrinter.DateHeight = 0
                    ObjrstPrinter.ItemStarterText = ""
                    ObjrstPrinter.ItemStarterHeight = 0
                    'ObjrstPrinter.ItemStarterItalicHeight = ""
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
                    MsgBox("Please select a printer for Bar.", MsgBoxStyle.Information, "Takeaway")
                End If
            End If

            If iKitchenItem > 0 Then
                If mdConfiguration.sOrderPrinter <> vbNullString Then
                    ObjrstPrinter.PrinterSettings.PrinterName = mdConfiguration.sOrderPrinter
                    ObjrstPrinter.DateText = strOrderDate
                    ObjrstPrinter.ItemFont = New Font("Lucida Console", 12, FontStyle.Bold)
                    ObjrstPrinter.ItemStarterText = strUser + strCustInfo + strGuestNumber + strItemInfoKitchenStarters
                    ObjrstPrinter.ItemStarterItalicText = strItemInfoKitchenStartersItalic
                    ObjrstPrinter.ItemText = strItemInfoKitchenMain
                    ObjrstPrinter.ItemTextItalic = strItemInfoKitchenMainItalic
                    ObjrstPrinter.Print()
                    objPrintDirect.OnCutter(mdConfiguration.sOrderPrinter)
                Else
                    MsgBox("Please select a printer for kitchen.", MsgBoxStyle.Information, "Takeaway")
                End If
                'new added  for KP1
                If mdConfiguration.sOrderPrinter1 <> vbNullString Then
                    ObjrstPrinter.PrinterSettings.PrinterName = mdConfiguration.sOrderPrinter1
                    ObjrstPrinter.DateText = strOrderDate
                    ObjrstPrinter.ItemFont = New Font("Lucida Console", 12, FontStyle.Bold)
                    ObjrstPrinter.ItemStarterText = strUser + strCustInfo + strGuestNumber + strItemInfoKitchenStarters
                    ObjrstPrinter.ItemStarterItalicText = strItemInfoKitchenStartersItalic
                    ObjrstPrinter.ItemText = strItemInfoKitchenMain
                    ObjrstPrinter.ItemTextItalic = strItemInfoKitchenMainItalic
                    ObjrstPrinter.Print()
                    objPrintDirect.OnCutter(mdConfiguration.sOrderPrinter1)
                End If
            End If
        End If
    End Function

    Private Sub txtTableNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTableNo.TextChanged
        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            If Trim(txtTableNo.Text) <> vbNullString Then
                stxtMain.ScrollText = "UySys eRestuarant " & ":Dine In, " & " Table- " & Trim(txtTableNo.Text)
            Else
                stxtMain.ScrollText = "UySys eRestuarant " & ": Dine In"
            End If
        Else
            If Trim(txtTableNo.Text) <> vbNullString Then
                stxtMain.ScrollText = mdConfiguration.strResturantName & ":Dine In, " & " Table- " & Trim(txtTableNo.Text)
            Else
                stxtMain.ScrollText = mdConfiguration.strResturantName & ": Dine In"
            End If
        End If
    End Sub

    'Private Sub btnUpItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim iUpYaxes As Integer
    '    If Me.xpndLstScnd.AutoScroll = True Then
    '        iUpYaxes = Math.Abs(Me.xpndLstScnd.AutoScrollPosition.Y)
    '        iUpYaxes -= 100
    '        Me.xpndLstScnd.AutoScrollPosition = New Point(0, iUpYaxes)
    '    End If
    'End Sub

    'Private Sub btnDownItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim iUpYaxes As Integer
    '    If Me.xpndLstScnd.AutoScroll = True Then
    '        iUpYaxes = Math.Abs(Me.xpndLstScnd.AutoScrollPosition.Y)
    '        iUpYaxes += 100
    '        Me.xpndLstScnd.AutoScrollPosition = New Point(0, iUpYaxes)
    '    End If
    'End Sub

    'Private Sub btnUpType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim iUpYaxes As Integer
    '    If Me.xpnLstMain.AutoScroll = True Then
    '        iUpYaxes = Math.Abs(Me.xpnLstMain.AutoScrollPosition.Y)
    '        iUpYaxes -= 100
    '        Me.xpnLstMain.AutoScrollPosition = New Point(0, iUpYaxes)
    '    End If
    'End Sub

    'Private Sub btnDownType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim iUpYaxes As Integer
    '    If Me.xpnLstMain.AutoScroll = True Then
    '        iUpYaxes = Math.Abs(Me.xpnLstMain.AutoScrollPosition.Y)
    '        iUpYaxes += 100
    '        Me.xpnLstMain.AutoScrollPosition = New Point(0, iUpYaxes)
    '    End If
    'End Sub

    Private Sub MacButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MacButton1.Click
        Dim ofrmAddMiscellaneousItemD As New frmAddMisD
        ofrmAddMiscellaneousItemD.Show()
    End Sub

    'Private Sub btnRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefund.Click
    '    Dim strSQL As String
    '    Dim iSelectedOrderId As Integer
    '    Dim cmdDelete As SqlClient.SqlCommand
    '    Dim cmdUpdate As SqlClient.SqlCommand
    '    Dim tnsAll As SqlClient.SqlTransaction

    '    If Trim(txtTableNo.Text) = vbNullString Then
    '        Exit Sub
    '    End If

    '    If Trim(txtnOrderId.Text) <> vbNullString Then
    '        iSelectedOrderId = Trim(txtnOrderId.Text)
    '        Try
    '            strSQL = "DELETE FROM tOrdered_Item WHERE nOrder_Id=" & CStr(iSelectedOrderId) & ""

    '            cmdDelete = New SqlClient.SqlCommand
    '            tnsAll = mdDBConnection.connRestuarant.BeginTransaction()
    '            cmdDelete.Transaction = tnsAll
    '            cmdDelete.Connection = mdDBConnection.connRestuarant
    '            cmdDelete.CommandText = strSQL
    '            cmdDelete.ExecuteNonQuery()

    '            strSQL = "DELETE FROM tOrder_Payment WHERE nOrder_Id=" & CStr(iSelectedOrderId) & ""
    '            cmdDelete.CommandText = strSQL
    '            cmdDelete.ExecuteNonQuery()

    '            strSQL = "UPDATE tTable_Info SET nStatus=0 WHERE nTable_Id=" + CStr(txtTableId.Text) + ""
    '            cmdUpdate.CommandText = strSQL
    '            cmdUpdate.ExecuteNonQuery()

    '            If Trim(txtNetPay.Tag) <> "0" Then
    '                strSQL = "DELETE FROM tCust_Info WHERE nCust_Id=" & CStr(Trim(txtCustomerNo.Text)) & ""
    '                cmdDelete.CommandText = strSQL
    '                cmdDelete.ExecuteNonQuery()
    '            End If
    '            tnsAll.Commit()
    '            Dim frmNew As New frmDine
    '            frmNew.Show()
    '            Me.Dispose()
    '        Catch ex As Exception
    '            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
    '            tnsAll.Rollback()
    '        End Try
    '    End If
    'End Sub

    Private Sub btnRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefund.Click

        Dim objfrm As New frmBillSplitting
        objfrm.Show()

    End Sub

    Public Function PaymentStatusPurpose()

        iOrderId = strfindcode
        iCustomerId = strfindDesc
        txtTableId.Tag = iOrderId
        PutDataIntoCustomerInfo(iCustomerId)
        PutDataIntoOrderInfo(strfindcode)
        PutDataIntoPaymentInfo(strfindcode)

    End Function

    Private Sub cboDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDiscount.TextChanged

        CalculateDiscoutAmount()

    End Sub

    Private Sub cboTips_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTips.TextChanged

        CalculateTipsAmount()

    End Sub

    'Private Sub lvOrder_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvOrder.DoubleClick

    '    'Dim ofrmTopping As New frmTopping
    '    'ofrmTopping.frmTopping(Me)
    '    'Dim b As String
    '    'Dim c As Double
    '    'Dim d As Integer

    '    'b = Me.lvOrder.SelectedItems(0).SubItems(2).Text
    '    'c = Me.lvOrder.SelectedItems(0).SubItems(3).Text
    '    'd = Me.lvOrder.SelectedItems(0).SubItems(5).Text
    '    'ofrmTopping.IteamCollect(b, c, d)
    '    'ofrmTopping.Show()
    '    'CalculateTopingPrice()

    'End Sub

    Public Function addtoping(ByVal TopIteam As String)

        Me.lvOrder.SelectedItems(0).SubItems(4).Text = TopIteam

    End Function

    Public Function CalculateTopingPrice()
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

        Dim g As String
        Dim h As String

        b = lblTotalOrderPrice.Text
        If btnKitchPrint.Enabled = True Then
            c = b
        ElseIf btBillPrint.Enabled = True Then
            g = b
        ElseIf btnAllPrint.Enabled = True Then
            h = b
        End If
        If c <> b Then
            btnKitchPrint.Enabled = True
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

    Private Sub btnDownType_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownType.Click
        Dim iUpYaxes As Integer
        If Me.xpnLstMain.AutoScroll = True Then
            iUpYaxes = Math.Abs(Me.xpnLstMain.AutoScrollPosition.Y)
            iUpYaxes += 100
            Me.xpnLstMain.AutoScrollPosition = New Point(0, iUpYaxes)
        End If
    End Sub

    Private Sub btnDownItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownItem.Click
        Dim iUpYaxes As Integer
        If Me.xpndLstScnd.AutoScroll = True Then
            iUpYaxes = Math.Abs(Me.xpndLstScnd.AutoScrollPosition.Y)
            iUpYaxes += 100
            Me.xpndLstScnd.AutoScrollPosition = New Point(0, iUpYaxes)
        End If
    End Sub

    Private Sub btnUpType_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpType.Click
        Dim iUpYaxes As Integer
        If Me.xpnLstMain.AutoScroll = True Then
            iUpYaxes = Math.Abs(Me.xpnLstMain.AutoScrollPosition.Y)
            iUpYaxes -= 100
            Me.xpnLstMain.AutoScrollPosition = New Point(0, iUpYaxes)
        End If
    End Sub

    Private Sub btnUpItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpItem.Click

        Dim iUpYaxes As Integer
        If Me.xpndLstScnd.AutoScroll = True Then
            iUpYaxes = Math.Abs(Me.xpndLstScnd.AutoScrollPosition.Y)
            iUpYaxes -= 100
            Me.xpndLstScnd.AutoScrollPosition = New Point(0, iUpYaxes)
        End If

    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        MsgBox("THIS PAGE UNDER DEVELOPMENT")
    End Sub

    Public Sub ListView_CatagorySort(ByRef lv As ListView, ByVal col As Integer, ByVal compareType As VariantType)
        'This will sort a list view by any passed column number, you will pass the listview object, the
        'column number, and the type of compare you want in the variant type, if you need more than the 
        '3 comparisons belowm just copy the sort code, add to the case statement, and change the Cxxx function
        'to use the correct one of choice.
        Dim lvTempItem As ListViewItem
        Dim i As Integer
        Select Case compareType
            Case VariantType.Integer
                For i = 0 To lv.Items.Count - 2 'only need to check up to the next to last in list
                    'compare current item to the next one
                    If CInt(lv.Items(i).SubItems(col).Text) < CInt(lv.Items(i + 1).SubItems(col).Text) Then
                        'save the current item
                        lvTempItem = lv.Items(i)
                        'remove the current item, has to be removed from collection before reinserting it
                        lv.Items(i).Remove()
                        'now add the item back in at its new location
                        lv.Items.Insert((i + 1), lvTempItem)
                        'start at first again to find next item needing moving
                        i = -1
                    End If
                Next i
                'string sort
        End Select
        'if you are calling this sort sub from another class other than where this sub resides, you will need to 
        'put the refresh in the calling sub after the sort call, otherwise you can uncomment the refresh, and
        'leave it here.
        'Me.lvEvents.Refresh()
    End Sub
    Public Sub ListView_CatagorySort_pending(ByRef lv As ListView, ByVal col As Integer, ByVal compareType As VariantType)
        'This will sort a list view by any passed column number, you will pass the listview object, the
        'column number, and the type of compare you want in the variant type, if you need more than the 
        '3 comparisons belowm just copy the sort code, add to the case statement, and change the Cxxx function
        'to use the correct one of choice.
        Dim lvTempItem As ListViewItem
        Dim i As Integer
        Select Case compareType
            Case VariantType.Integer
                For i = 0 To lv.Items.Count - 2 'only need to check up to the next to last in list
                    'compare current item to the next one
                    If CInt(lv.Items(i).SubItems(col).Text) > CInt(lv.Items(i + 1).SubItems(col).Text) Then
                        'save the current item
                        lvTempItem = lv.Items(i)
                        'remove the current item, has to be removed from collection before reinserting it
                        lv.Items(i).Remove()
                        'now add the item back in at its new location
                        lv.Items.Insert((i + 1), lvTempItem)
                        'start at first again to find next item needing moving
                        i = -1
                    End If
                Next i
                'string sort
        End Select
        'if you are calling this sort sub from another class other than where this sub resides, you will need to 
        'put the refresh in the calling sub after the sort call, otherwise you can uncomment the refresh, and
        'leave it here.
        'Me.lvEvents.Refresh()
    End Sub

    Public Sub ListView_TypeSort(ByRef lv As ListView, ByVal col As Integer, ByVal compareType As VariantType)
        'This will sort a list view by any passed column number, you will pass the listview object, the
        'column number, and the type of compare you want in the variant type, if you need more than the 
        '3 comparisons belowm just copy the sort code, add to the case statement, and change the Cxxx function
        'to use the correct one of choice.
        Dim lvTempItem As ListViewItem
        Dim i As Integer
        Select Case compareType
            Case VariantType.Integer
                For i = 0 To lv.Items.Count - 2 'only need to check up to the next to last in list
                    'compare current item to the next one
                    If CInt(lv.Items(i).SubItems(10).Text) = CInt(lv.Items(i + 1).SubItems(10).Text) Then
                        If CInt(lv.Items(i).SubItems(col).Text) < CInt(lv.Items(i + 1).SubItems(col).Text) Then
                            'save the current item
                            lvTempItem = lv.Items(i)
                            'remove the current item, has to be removed from collection before reinserting it
                            lv.Items(i).Remove()
                            'now add the item back in at its new location
                            lv.Items.Insert((i + 1), lvTempItem)
                            'start at first again to find next item needing moving
                            i = -1
                        End If
                    End If
                Next i
                'string sort
        End Select
        'if you are calling this sort sub from another class other than where this sub resides, you will need to 
        'put the refresh in the calling sub after the sort call, otherwise you can uncomment the refresh, and
        'leave it here.
        'Me.lvEvents.Refresh()
    End Sub
    Public Sub ListView_TypeSort_pending(ByRef lv As ListView, ByVal col As Integer, ByVal compareType As VariantType)
        'This will sort a list view by any passed column number, you will pass the listview object, the
        'column number, and the type of compare you want in the variant type, if you need more than the 
        '3 comparisons belowm just copy the sort code, add to the case statement, and change the Cxxx function
        'to use the correct one of choice.
        Dim lvTempItem As ListViewItem
        Dim i As Integer
        Select Case compareType
            Case VariantType.Integer
                For i = 0 To lv.Items.Count - 2 'only need to check up to the next to last in list
                    'compare current item to the next one
                    If CInt(lv.Items(i).SubItems(10).Text) = CInt(lv.Items(i + 1).SubItems(10).Text) Then
                        If CInt(lv.Items(i).SubItems(col).Text) > CInt(lv.Items(i + 1).SubItems(col).Text) Then
                            'save the current item
                            lvTempItem = lv.Items(i)
                            'remove the current item, has to be removed from collection before reinserting it
                            lv.Items(i).Remove()
                            'now add the item back in at its new location
                            lv.Items.Insert((i + 1), lvTempItem)
                            'start at first again to find next item needing moving
                            i = -1
                        End If
                    End If
                Next i
                'string sort
        End Select
        'if you are calling this sort sub from another class other than where this sub resides, you will need to 
        'put the refresh in the calling sub after the sort call, otherwise you can uncomment the refresh, and
        'leave it here.
        'Me.lvEvents.Refresh()
    End Sub


    'Public Sub ListViewSort(ByRef lv As ListView, ByVal col As Integer, ByVal compareType As VariantType)
    '    'This will sort a list view by any passed column number, you will pass the listview object, the
    '    'column number, and the type of compare you want in the variant type, if you need more than the 
    '    '3 comparisons belowm just copy the sort code, add to the case statement, and change the Cxxx function
    '    'to use the correct one of choice.
    '    Dim lvTempItem As ListViewItem
    '    Dim i As Integer
    '    Select Case compareType
    '        'sort by a date column
    '    Case VariantType.Date
    '            For i = 0 To lv.Items.Count - 2 'only need to check up to the next to last in list
    '                'compare current item to the next one
    '                If CDate(lv.Items(i).SubItems(col).Text) > CDate(lv.Items(i + 1).SubItems(col).Text) Then
    '                    'save the current item
    '                    lvTempItem = lv.Items(i)
    '                    'remove the current item, has to be removed from collection before reinserting it
    '                    lv.Items(i).Remove()
    '                    'now add the item back in at its new location
    '                    lv.Items.Insert((i + 1), lvTempItem)
    '                    'start at first again to find next item needing moving
    '                    i = -1
    '                End If
    '            Next i
    '            ' sort by a whole number
    '        Case VariantType.Integer
    '            For i = 0 To lv.Items.Count - 2 'only need to check up to the next to last in list
    '                'compare current item to the next one
    '                If CInt(lv.Items(i).SubItems(col).Text) > CInt(lv.Items(i + 1).SubItems(col).Text) Then
    '                    'save the current item
    '                    lvTempItem = lv.Items(i)
    '                    'remove the current item, has to be removed from collection before reinserting it
    '                    lv.Items(i).Remove()
    '                    'now add the item back in at its new location
    '                    lv.Items.Insert((i + 1), lvTempItem)
    '                    'start at first again to find next item needing moving
    '                    i = -1
    '                End If
    '            Next i
    '            'string sort
    '        Case VariantType.String
    '            For i = 0 To lv.Items.Count - 2 'only need to check up to the next to last in list
    '                'compare current item to the next one
    '                If CStr(lv.Items(i).SubItems(col).Text) > CStr(lv.Items(i + 1).SubItems(col).Text) Then
    '                    'save the current item
    '                    lvTempItem = lv.Items(i)
    '                    'remove the current item, has to be removed from collection before reinserting it
    '                    lv.Items(i).Remove()
    '                    'now add the item back in at its new location
    '                    lv.Items.Insert((i + 1), lvTempItem)
    '                    'start at first again to find next item needing moving
    '                    i = -1
    '                End If
    '            Next i
    '    End Select
    '    'if you are calling this sort sub from another class other than where this sub resides, you will need to 
    '    'put the refresh in the calling sub after the sort call, otherwise you can uncomment the refresh, and
    '    'leave it here.
    '    'Me.lvEvents.Refresh()
    'End Sub

End Class
Public Class ListViewComparer
    Implements IComparer

    Private m_ColumnNumber As Integer
    Private m_SortOrder As SortOrder

    Public Sub New(ByVal column_number As Integer, ByVal sort_order As SortOrder)
        m_ColumnNumber = column_number
        m_SortOrder = sort_order
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) _
     As Integer Implements System.Collections.IComparer.Compare
        Dim item_x As ListViewItem = DirectCast(x, ListViewItem)
        Dim item_y As ListViewItem = DirectCast(y, ListViewItem)

        ' Get the sub-item values.
        Dim string_x As String
        If item_x.SubItems.Count <= m_ColumnNumber Then
            string_x = ""
        Else
            string_x = item_x.SubItems(m_ColumnNumber).Text
        End If

        Dim string_y As String
        If item_y.SubItems.Count <= m_ColumnNumber Then
            string_y = ""
        Else
            string_y = item_y.SubItems(m_ColumnNumber).Text
        End If

        ' Compare them.
        If m_SortOrder = SortOrder.Ascending Then
            Return String.Compare(string_x, string_y)
        Else
            Return String.Compare(string_y, string_x)
        End If
    End Function
End Class