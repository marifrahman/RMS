Imports System.IO

Public Class frmGlobalInfo
    Inherits System.Windows.Forms.Form

    Dim bIsDataExist As Boolean

    Dim strSecCode As String
    Dim strWorkingDirectoy As String = "C:\Program Files\UYSYS\Logo"
    Dim sttCopyLogo As String = strWorkingDirectoy + "\logo.bmp"

    Public bSecCodeOk As Boolean

    
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        txtRestaurantName.Text = ""
        txtRestuarantType.Text = ""
        txtRestaurantAddress1.Text = ""
        txtRestaurantAddress2.Text = ""
        txtRestaurantAddress3.Text = ""
        txtPhoneNumber.Text = ""
        txtFaxNumber.Text = ""
        txtEmailAddress.Text = ""
        txtUrl.Text = ""
        txtGreetingMsg.Text = ""
        txtVat.Text = ""
        txtVatNumber.Text = ""
        txtSecurityCode.Text = ""
        txtSecurityCode.PasswordChar = "#"
        cbChangeSecurityCode.Text = "Change Security Code"
        btnEdit.Text = "Save"
        btnExit.Text = "Exit"
        txtImagelocation.Text = ""
        btnImagepath.Text = "Logo Path"
        txtTypeItalic.Text = ""
        txtTypePrefix.Text = ""
        txtNumberofGuest.Text = ""
        txtServiceCharge.Text = ""
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbMenuLevel As System.Windows.Forms.GroupBox
    Friend WithEvents rbThreeLevelMenu As System.Windows.Forms.RadioButton
    Friend WithEvents rbTwoLevelMenu As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRestaurantName As System.Windows.Forms.TextBox
    Friend WithEvents txtRestaurantAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRestaurantAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFaxNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents txtVatNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtSecurityCode As System.Windows.Forms.TextBox
    Friend WithEvents cbChangeSecurityCode As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gbRestaurantInfo As System.Windows.Forms.GroupBox
    Friend WithEvents gbVatInfo As System.Windows.Forms.GroupBox
    Friend WithEvents gbSecurityInfo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoDinein As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTakeaway As System.Windows.Forms.RadioButton
    Friend WithEvents txtGreetingMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents txtRestaurantAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRestuarantType As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTypePrefix As System.Windows.Forms.TextBox
    Friend WithEvents gbTypeName As System.Windows.Forms.GroupBox
    Friend WithEvents btnImagepath As MACButtonLib.MACButton
    Friend WithEvents txtImagelocation As System.Windows.Forms.TextBox
    Friend WithEvents gbLogo As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumberofGuest As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtServiceCharge As System.Windows.Forms.TextBox
    Friend WithEvents gbTips As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTypeItalic As System.Windows.Forms.TextBox
    Friend WithEvents gbItalic As System.Windows.Forms.GroupBox
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_collectiontime As System.Windows.Forms.TextBox
    Friend WithEvents txt_awaytime As System.Windows.Forms.TextBox
    Friend WithEvents txt_waitingtime As System.Windows.Forms.TextBox
    Friend WithEvents gbordertimeset As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGlobalInfo))
        Me.gbRestaurantInfo = New System.Windows.Forms.GroupBox
        Me.txtRestuarantType = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtGreetingMsg = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtUrl = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEmailAddress = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFaxNumber = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRestaurantAddress3 = New System.Windows.Forms.TextBox
        Me.txtRestaurantAddress2 = New System.Windows.Forms.TextBox
        Me.txtRestaurantAddress1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRestaurantName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbMenuLevel = New System.Windows.Forms.GroupBox
        Me.rbThreeLevelMenu = New System.Windows.Forms.RadioButton
        Me.rbTwoLevelMenu = New System.Windows.Forms.RadioButton
        Me.gbVatInfo = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtVatNumber = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtVat = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.gbSecurityInfo = New System.Windows.Forms.GroupBox
        Me.cbChangeSecurityCode = New System.Windows.Forms.CheckBox
        Me.txtSecurityCode = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdoDinein = New System.Windows.Forms.RadioButton
        Me.rdoTakeaway = New System.Windows.Forms.RadioButton
        Me.gbTypeName = New System.Windows.Forms.GroupBox
        Me.txtTypePrefix = New System.Windows.Forms.TextBox
        Me.gbLogo = New System.Windows.Forms.GroupBox
        Me.btnImagepath = New MACButtonLib.MACButton
        Me.txtImagelocation = New System.Windows.Forms.TextBox
        Me.gbTips = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtServiceCharge = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtNumberofGuest = New System.Windows.Forms.TextBox
        Me.gbItalic = New System.Windows.Forms.GroupBox
        Me.txtTypeItalic = New System.Windows.Forms.TextBox
        Me.gbordertimeset = New System.Windows.Forms.GroupBox
        Me.txt_waitingtime = New System.Windows.Forms.TextBox
        Me.txt_collectiontime = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_awaytime = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.gbRestaurantInfo.SuspendLayout()
        Me.gbMenuLevel.SuspendLayout()
        Me.gbVatInfo.SuspendLayout()
        Me.gbSecurityInfo.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbTypeName.SuspendLayout()
        Me.gbLogo.SuspendLayout()
        Me.gbTips.SuspendLayout()
        Me.gbItalic.SuspendLayout()
        Me.gbordertimeset.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRestaurantInfo
        '
        Me.gbRestaurantInfo.Controls.Add(Me.txtRestuarantType)
        Me.gbRestaurantInfo.Controls.Add(Me.Label11)
        Me.gbRestaurantInfo.Controls.Add(Me.txtGreetingMsg)
        Me.gbRestaurantInfo.Controls.Add(Me.Label10)
        Me.gbRestaurantInfo.Controls.Add(Me.txtUrl)
        Me.gbRestaurantInfo.Controls.Add(Me.Label5)
        Me.gbRestaurantInfo.Controls.Add(Me.txtEmailAddress)
        Me.gbRestaurantInfo.Controls.Add(Me.Label6)
        Me.gbRestaurantInfo.Controls.Add(Me.txtFaxNumber)
        Me.gbRestaurantInfo.Controls.Add(Me.Label3)
        Me.gbRestaurantInfo.Controls.Add(Me.txtPhoneNumber)
        Me.gbRestaurantInfo.Controls.Add(Me.Label4)
        Me.gbRestaurantInfo.Controls.Add(Me.txtRestaurantAddress3)
        Me.gbRestaurantInfo.Controls.Add(Me.txtRestaurantAddress2)
        Me.gbRestaurantInfo.Controls.Add(Me.txtRestaurantAddress1)
        Me.gbRestaurantInfo.Controls.Add(Me.Label2)
        Me.gbRestaurantInfo.Controls.Add(Me.txtRestaurantName)
        Me.gbRestaurantInfo.Controls.Add(Me.Label1)
        Me.gbRestaurantInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbRestaurantInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRestaurantInfo.ForeColor = System.Drawing.Color.Maroon
        Me.gbRestaurantInfo.Location = New System.Drawing.Point(8, 8)
        Me.gbRestaurantInfo.Name = "gbRestaurantInfo"
        Me.gbRestaurantInfo.Size = New System.Drawing.Size(408, 328)
        Me.gbRestaurantInfo.TabIndex = 6
        Me.gbRestaurantInfo.TabStop = False
        Me.gbRestaurantInfo.Text = "Restaurant Information"
        '
        'txtRestuarantType
        '
        Me.txtRestuarantType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRestuarantType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestuarantType.Location = New System.Drawing.Point(156, 45)
        Me.txtRestuarantType.MaxLength = 100
        Me.txtRestuarantType.Name = "txtRestuarantType"
        Me.txtRestuarantType.Size = New System.Drawing.Size(240, 21)
        Me.txtRestuarantType.TabIndex = 2
        Me.txtRestuarantType.Text = "txtRestuarantType"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Ivory
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(12, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 21)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Restaurant Type"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGreetingMsg
        '
        Me.txtGreetingMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGreetingMsg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGreetingMsg.Location = New System.Drawing.Point(156, 259)
        Me.txtGreetingMsg.MaxLength = 100
        Me.txtGreetingMsg.Multiline = True
        Me.txtGreetingMsg.Name = "txtGreetingMsg"
        Me.txtGreetingMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGreetingMsg.Size = New System.Drawing.Size(240, 61)
        Me.txtGreetingMsg.TabIndex = 10
        Me.txtGreetingMsg.Text = "txtGreetingMsg"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Ivory
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(12, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 21)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Greeting Message"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUrl
        '
        Me.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUrl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUrl.Location = New System.Drawing.Point(156, 231)
        Me.txtUrl.MaxLength = 100
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(240, 21)
        Me.txtUrl.TabIndex = 9
        Me.txtUrl.Text = "txtUrl"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Ivory
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Web Address"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.Location = New System.Drawing.Point(156, 204)
        Me.txtEmailAddress.MaxLength = 50
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(240, 21)
        Me.txtEmailAddress.TabIndex = 8
        Me.txtEmailAddress.Text = "txtEmailAddress"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Email-Address"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFaxNumber
        '
        Me.txtFaxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFaxNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaxNumber.Location = New System.Drawing.Point(156, 177)
        Me.txtFaxNumber.MaxLength = 20
        Me.txtFaxNumber.Name = "txtFaxNumber"
        Me.txtFaxNumber.Size = New System.Drawing.Size(240, 21)
        Me.txtFaxNumber.TabIndex = 7
        Me.txtFaxNumber.Text = "txtFaxNumber"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Ivory
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fax number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(156, 150)
        Me.txtPhoneNumber.MaxLength = 50
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(240, 21)
        Me.txtPhoneNumber.TabIndex = 6
        Me.txtPhoneNumber.Text = "txtPhoneNumber"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Phone Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRestaurantAddress3
        '
        Me.txtRestaurantAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRestaurantAddress3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestaurantAddress3.Location = New System.Drawing.Point(156, 123)
        Me.txtRestaurantAddress3.MaxLength = 100
        Me.txtRestaurantAddress3.Name = "txtRestaurantAddress3"
        Me.txtRestaurantAddress3.Size = New System.Drawing.Size(240, 21)
        Me.txtRestaurantAddress3.TabIndex = 5
        Me.txtRestaurantAddress3.Text = "txtRestaurantAddress3"
        '
        'txtRestaurantAddress2
        '
        Me.txtRestaurantAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRestaurantAddress2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestaurantAddress2.Location = New System.Drawing.Point(156, 96)
        Me.txtRestaurantAddress2.MaxLength = 100
        Me.txtRestaurantAddress2.Name = "txtRestaurantAddress2"
        Me.txtRestaurantAddress2.Size = New System.Drawing.Size(240, 21)
        Me.txtRestaurantAddress2.TabIndex = 4
        Me.txtRestaurantAddress2.Text = "txtRestaurantAddress2"
        '
        'txtRestaurantAddress1
        '
        Me.txtRestaurantAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRestaurantAddress1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestaurantAddress1.Location = New System.Drawing.Point(156, 70)
        Me.txtRestaurantAddress1.MaxLength = 100
        Me.txtRestaurantAddress1.Name = "txtRestaurantAddress1"
        Me.txtRestaurantAddress1.Size = New System.Drawing.Size(240, 21)
        Me.txtRestaurantAddress1.TabIndex = 3
        Me.txtRestaurantAddress1.Text = "txtRestaurantAddress1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Ivory
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Restaurant Address"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRestaurantName
        '
        Me.txtRestaurantName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRestaurantName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestaurantName.Location = New System.Drawing.Point(156, 18)
        Me.txtRestaurantName.MaxLength = 50
        Me.txtRestaurantName.Name = "txtRestaurantName"
        Me.txtRestaurantName.Size = New System.Drawing.Size(240, 21)
        Me.txtRestaurantName.TabIndex = 1
        Me.txtRestaurantName.Text = "txtRestaurantName"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restaurant Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbMenuLevel
        '
        Me.gbMenuLevel.Controls.Add(Me.rbThreeLevelMenu)
        Me.gbMenuLevel.Controls.Add(Me.rbTwoLevelMenu)
        Me.gbMenuLevel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbMenuLevel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMenuLevel.ForeColor = System.Drawing.Color.Maroon
        Me.gbMenuLevel.Location = New System.Drawing.Point(422, 8)
        Me.gbMenuLevel.Name = "gbMenuLevel"
        Me.gbMenuLevel.Size = New System.Drawing.Size(290, 50)
        Me.gbMenuLevel.TabIndex = 8
        Me.gbMenuLevel.TabStop = False
        Me.gbMenuLevel.Text = "Menu Level"
        '
        'rbThreeLevelMenu
        '
        Me.rbThreeLevelMenu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbThreeLevelMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbThreeLevelMenu.Location = New System.Drawing.Point(141, 18)
        Me.rbThreeLevelMenu.Name = "rbThreeLevelMenu"
        Me.rbThreeLevelMenu.Size = New System.Drawing.Size(140, 24)
        Me.rbThreeLevelMenu.TabIndex = 12
        Me.rbThreeLevelMenu.Text = "Three Level Menu"
        '
        'rbTwoLevelMenu
        '
        Me.rbTwoLevelMenu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTwoLevelMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbTwoLevelMenu.Location = New System.Drawing.Point(6, 18)
        Me.rbTwoLevelMenu.Name = "rbTwoLevelMenu"
        Me.rbTwoLevelMenu.Size = New System.Drawing.Size(130, 24)
        Me.rbTwoLevelMenu.TabIndex = 11
        Me.rbTwoLevelMenu.Text = "Two Level Menu "
        '
        'gbVatInfo
        '
        Me.gbVatInfo.Controls.Add(Me.Label9)
        Me.gbVatInfo.Controls.Add(Me.txtVatNumber)
        Me.gbVatInfo.Controls.Add(Me.Label8)
        Me.gbVatInfo.Controls.Add(Me.txtVat)
        Me.gbVatInfo.Controls.Add(Me.Label7)
        Me.gbVatInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbVatInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVatInfo.ForeColor = System.Drawing.Color.Maroon
        Me.gbVatInfo.Location = New System.Drawing.Point(422, 63)
        Me.gbVatInfo.Name = "gbVatInfo"
        Me.gbVatInfo.Size = New System.Drawing.Size(290, 81)
        Me.gbVatInfo.TabIndex = 9
        Me.gbVatInfo.TabStop = False
        Me.gbVatInfo.Text = "Vat Information"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(253, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 23)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVatNumber
        '
        Me.txtVatNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVatNumber.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatNumber.Location = New System.Drawing.Point(152, 49)
        Me.txtVatNumber.MaxLength = 15
        Me.txtVatNumber.Name = "txtVatNumber"
        Me.txtVatNumber.Size = New System.Drawing.Size(117, 23)
        Me.txtVatNumber.TabIndex = 14
        Me.txtVatNumber.Text = "txtVatNumber"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Vat Reg.  Number #"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVat
        '
        Me.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVat.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.Location = New System.Drawing.Point(152, 20)
        Me.txtVat.MaxLength = 8
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(94, 23)
        Me.txtVat.TabIndex = 13
        Me.txtVat.Text = "txtVat"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Vat"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbSecurityInfo
        '
        Me.gbSecurityInfo.Controls.Add(Me.cbChangeSecurityCode)
        Me.gbSecurityInfo.Controls.Add(Me.txtSecurityCode)
        Me.gbSecurityInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbSecurityInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSecurityInfo.ForeColor = System.Drawing.Color.Maroon
        Me.gbSecurityInfo.Location = New System.Drawing.Point(422, 153)
        Me.gbSecurityInfo.Name = "gbSecurityInfo"
        Me.gbSecurityInfo.Size = New System.Drawing.Size(290, 57)
        Me.gbSecurityInfo.TabIndex = 11
        Me.gbSecurityInfo.TabStop = False
        Me.gbSecurityInfo.Text = "Security Code"
        '
        'cbChangeSecurityCode
        '
        Me.cbChangeSecurityCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChangeSecurityCode.Location = New System.Drawing.Point(118, 21)
        Me.cbChangeSecurityCode.Name = "cbChangeSecurityCode"
        Me.cbChangeSecurityCode.Size = New System.Drawing.Size(164, 24)
        Me.cbChangeSecurityCode.TabIndex = 16
        Me.cbChangeSecurityCode.Text = "cbChangeSecurityCode"
        '
        'txtSecurityCode
        '
        Me.txtSecurityCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecurityCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityCode.Location = New System.Drawing.Point(8, 21)
        Me.txtSecurityCode.MaxLength = 10
        Me.txtSecurityCode.Name = "txtSecurityCode"
        Me.txtSecurityCode.Size = New System.Drawing.Size(104, 21)
        Me.txtSecurityCode.TabIndex = 15
        Me.txtSecurityCode.Text = "txtSecurityCode"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnKeyBoard)
        Me.GroupBox4.Controls.Add(Me.btnExit)
        Me.GroupBox4.Controls.Add(Me.btnEdit)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 504)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(704, 72)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
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
        Me.btnKeyBoard.Location = New System.Drawing.Point(280, 24)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(130, 40)
        Me.btnKeyBoard.TabIndex = 75
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
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
        Me.btnExit.Location = New System.Drawing.Point(440, 24)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 40)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "btnExit"
        Me.btnExit.TextColorDefault = System.Drawing.Color.Black
        Me.btnExit.TextColorDisabled = System.Drawing.Color.Black
        Me.btnExit.TextColorHover = System.Drawing.Color.White
        Me.btnExit.TextColorNormal = System.Drawing.Color.White
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnEdit.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnEdit.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnEdit.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(112, 24)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(130, 40)
        Me.btnEdit.TabIndex = 19
        Me.btnEdit.Text = "btnEdit"
        Me.btnEdit.TextColorDefault = System.Drawing.Color.Black
        Me.btnEdit.TextColorDisabled = System.Drawing.Color.Black
        Me.btnEdit.TextColorHover = System.Drawing.Color.White
        Me.btnEdit.TextColorNormal = System.Drawing.Color.White
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoDinein)
        Me.GroupBox1.Controls.Add(Me.rdoTakeaway)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(422, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 57)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Open Mode"
        '
        'rdoDinein
        '
        Me.rdoDinein.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDinein.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoDinein.Location = New System.Drawing.Point(153, 21)
        Me.rdoDinein.Name = "rdoDinein"
        Me.rdoDinein.Size = New System.Drawing.Size(128, 22)
        Me.rdoDinein.TabIndex = 18
        Me.rdoDinein.Text = "In house Mode"
        '
        'rdoTakeaway
        '
        Me.rdoTakeaway.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTakeaway.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTakeaway.Location = New System.Drawing.Point(6, 21)
        Me.rdoTakeaway.Name = "rdoTakeaway"
        Me.rdoTakeaway.Size = New System.Drawing.Size(128, 24)
        Me.rdoTakeaway.TabIndex = 17
        Me.rdoTakeaway.Text = "Takeaway Mode"
        '
        'gbTypeName
        '
        Me.gbTypeName.Controls.Add(Me.txtTypePrefix)
        Me.gbTypeName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbTypeName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTypeName.ForeColor = System.Drawing.Color.Maroon
        Me.gbTypeName.Location = New System.Drawing.Point(424, 288)
        Me.gbTypeName.Name = "gbTypeName"
        Me.gbTypeName.Size = New System.Drawing.Size(290, 56)
        Me.gbTypeName.TabIndex = 14
        Me.gbTypeName.TabStop = False
        Me.gbTypeName.Text = "Separated Type Name (Full Name Ex:Type1,Type2)"
        '
        'txtTypePrefix
        '
        Me.txtTypePrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTypePrefix.Enabled = False
        Me.txtTypePrefix.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypePrefix.Location = New System.Drawing.Point(18, 20)
        Me.txtTypePrefix.MaxLength = 250
        Me.txtTypePrefix.Name = "txtTypePrefix"
        Me.txtTypePrefix.Size = New System.Drawing.Size(246, 23)
        Me.txtTypePrefix.TabIndex = 15
        Me.txtTypePrefix.Text = "txtTypePrefix"
        '
        'gbLogo
        '
        Me.gbLogo.Controls.Add(Me.btnImagepath)
        Me.gbLogo.Controls.Add(Me.txtImagelocation)
        Me.gbLogo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbLogo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLogo.ForeColor = System.Drawing.Color.Maroon
        Me.gbLogo.Location = New System.Drawing.Point(422, 431)
        Me.gbLogo.Name = "gbLogo"
        Me.gbLogo.Size = New System.Drawing.Size(290, 64)
        Me.gbLogo.TabIndex = 15
        Me.gbLogo.TabStop = False
        Me.gbLogo.Text = "Logo location (must be 60 X 230 pix)"
        '
        'btnImagepath
        '
        Me.btnImagepath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnImagepath.BackColor = System.Drawing.Color.Transparent
        Me.btnImagepath.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnImagepath.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnImagepath.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnImagepath.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnImagepath.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagepath.Location = New System.Drawing.Point(183, 20)
        Me.btnImagepath.Name = "btnImagepath"
        Me.btnImagepath.Size = New System.Drawing.Size(101, 36)
        Me.btnImagepath.TabIndex = 21
        Me.btnImagepath.Text = "btnImagepath"
        Me.btnImagepath.TextColorDefault = System.Drawing.Color.Black
        Me.btnImagepath.TextColorDisabled = System.Drawing.Color.Black
        Me.btnImagepath.TextColorHover = System.Drawing.Color.White
        Me.btnImagepath.TextColorNormal = System.Drawing.Color.White
        '
        'txtImagelocation
        '
        Me.txtImagelocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImagelocation.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagelocation.Location = New System.Drawing.Point(13, 27)
        Me.txtImagelocation.MaxLength = 15
        Me.txtImagelocation.Name = "txtImagelocation"
        Me.txtImagelocation.Size = New System.Drawing.Size(163, 23)
        Me.txtImagelocation.TabIndex = 16
        Me.txtImagelocation.Text = "txtImagelocation"
        '
        'gbTips
        '
        Me.gbTips.Controls.Add(Me.Label15)
        Me.gbTips.Controls.Add(Me.txtServiceCharge)
        Me.gbTips.Controls.Add(Me.Label14)
        Me.gbTips.Controls.Add(Me.Label13)
        Me.gbTips.Controls.Add(Me.Label12)
        Me.gbTips.Controls.Add(Me.txtNumberofGuest)
        Me.gbTips.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbTips.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTips.ForeColor = System.Drawing.Color.Maroon
        Me.gbTips.Location = New System.Drawing.Point(8, 336)
        Me.gbTips.Name = "gbTips"
        Me.gbTips.Size = New System.Drawing.Size(408, 72)
        Me.gbTips.TabIndex = 16
        Me.gbTips.TabStop = False
        Me.gbTips.Text = "Guest Number And Service Charge "
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(283, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "%"
        '
        'txtServiceCharge
        '
        Me.txtServiceCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServiceCharge.Enabled = False
        Me.txtServiceCharge.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceCharge.Location = New System.Drawing.Point(248, 43)
        Me.txtServiceCharge.MaxLength = 15
        Me.txtServiceCharge.Name = "txtServiceCharge"
        Me.txtServiceCharge.Size = New System.Drawing.Size(29, 23)
        Me.txtServiceCharge.TabIndex = 20
        Me.txtServiceCharge.Text = "txtServiceCharge"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(144, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Service Charge"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(283, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 23)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Persons."
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(56, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(186, 23)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Service Charge applicable for"
        '
        'txtNumberofGuest
        '
        Me.txtNumberofGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumberofGuest.Enabled = False
        Me.txtNumberofGuest.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberofGuest.Location = New System.Drawing.Point(248, 19)
        Me.txtNumberofGuest.MaxLength = 15
        Me.txtNumberofGuest.Name = "txtNumberofGuest"
        Me.txtNumberofGuest.Size = New System.Drawing.Size(29, 23)
        Me.txtNumberofGuest.TabIndex = 16
        Me.txtNumberofGuest.Text = "txtNumberofGuest"
        '
        'gbItalic
        '
        Me.gbItalic.Controls.Add(Me.txtTypeItalic)
        Me.gbItalic.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbItalic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbItalic.ForeColor = System.Drawing.Color.Maroon
        Me.gbItalic.Location = New System.Drawing.Point(422, 352)
        Me.gbItalic.Name = "gbItalic"
        Me.gbItalic.Size = New System.Drawing.Size(290, 64)
        Me.gbItalic.TabIndex = 17
        Me.gbItalic.TabStop = False
        Me.gbItalic.Text = "Make Type Name Italic (Full Name Ex: Type1,Type2)"
        '
        'txtTypeItalic
        '
        Me.txtTypeItalic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTypeItalic.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeItalic.Location = New System.Drawing.Point(18, 24)
        Me.txtTypeItalic.MaxLength = 250
        Me.txtTypeItalic.Name = "txtTypeItalic"
        Me.txtTypeItalic.Size = New System.Drawing.Size(246, 23)
        Me.txtTypeItalic.TabIndex = 15
        Me.txtTypeItalic.Text = "txtTypeItalic"
        '
        'gbordertimeset
        '
        Me.gbordertimeset.Controls.Add(Me.Label16)
        Me.gbordertimeset.Controls.Add(Me.txt_waitingtime)
        Me.gbordertimeset.Controls.Add(Me.txt_collectiontime)
        Me.gbordertimeset.Controls.Add(Me.Label17)
        Me.gbordertimeset.Controls.Add(Me.Label18)
        Me.gbordertimeset.Controls.Add(Me.Label19)
        Me.gbordertimeset.Controls.Add(Me.txt_awaytime)
        Me.gbordertimeset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbordertimeset.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbordertimeset.ForeColor = System.Drawing.Color.Maroon
        Me.gbordertimeset.Location = New System.Drawing.Point(9, 415)
        Me.gbordertimeset.Name = "gbordertimeset"
        Me.gbordertimeset.Size = New System.Drawing.Size(408, 81)
        Me.gbordertimeset.TabIndex = 18
        Me.gbordertimeset.TabStop = False
        Me.gbordertimeset.Text = "Order Print Time Setting"
        '
        'txt_waitingtime
        '
        Me.txt_waitingtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_waitingtime.Enabled = False
        Me.txt_waitingtime.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_waitingtime.Location = New System.Drawing.Point(262, 49)
        Me.txt_waitingtime.MaxLength = 15
        Me.txt_waitingtime.Name = "txt_waitingtime"
        Me.txt_waitingtime.Size = New System.Drawing.Size(93, 23)
        Me.txt_waitingtime.TabIndex = 21
        Me.txt_waitingtime.Text = ""
        '
        'txt_collectiontime
        '
        Me.txt_collectiontime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_collectiontime.Enabled = False
        Me.txt_collectiontime.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_collectiontime.Location = New System.Drawing.Point(137, 49)
        Me.txt_collectiontime.MaxLength = 15
        Me.txt_collectiontime.Name = "txt_collectiontime"
        Me.txt_collectiontime.Size = New System.Drawing.Size(93, 23)
        Me.txt_collectiontime.TabIndex = 20
        Me.txt_collectiontime.Text = ""
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(143, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 23)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Collection"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(262, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 23)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Waiting"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(14, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 23)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Takwaway"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_awaytime
        '
        Me.txt_awaytime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_awaytime.Enabled = False
        Me.txt_awaytime.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_awaytime.Location = New System.Drawing.Point(14, 49)
        Me.txt_awaytime.MaxLength = 15
        Me.txt_awaytime.Name = "txt_awaytime"
        Me.txt_awaytime.Size = New System.Drawing.Size(93, 23)
        Me.txt_awaytime.TabIndex = 16
        Me.txt_awaytime.Text = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(361, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 23)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "min"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmGlobalInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(738, 622)
        Me.Controls.Add(Me.gbItalic)
        Me.Controls.Add(Me.gbTips)
        Me.Controls.Add(Me.gbLogo)
        Me.Controls.Add(Me.gbTypeName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbSecurityInfo)
        Me.Controls.Add(Me.gbVatInfo)
        Me.Controls.Add(Me.gbMenuLevel)
        Me.Controls.Add(Me.gbRestaurantInfo)
        Me.Controls.Add(Me.gbordertimeset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGlobalInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGlobalInfo"
        Me.gbRestaurantInfo.ResumeLayout(False)
        Me.gbMenuLevel.ResumeLayout(False)
        Me.gbVatInfo.ResumeLayout(False)
        Me.gbSecurityInfo.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbTypeName.ResumeLayout(False)
        Me.gbLogo.ResumeLayout(False)
        Me.gbTips.ResumeLayout(False)
        Me.gbItalic.ResumeLayout(False)
        Me.gbordertimeset.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmGlobalInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showAllInformation()
        DisableAllField()

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Global Setting"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Global Setting"
        End If

        If bIsDataExist = False Then
            rbThreeLevelMenu.Checked = True
            txtSecurityCode.Enabled = True
            cbChangeSecurityCode.Enabled = False
            btnEdit.Text = "Add"
        Else
            btnEdit.Text = "Edit"
        End If
    End Sub

    Private Function showAllInformation()
        Dim strSQL As String
        Dim iDataSetRow As Integer
        Dim dsGlobalInfo As DataSet
        Dim daGlobalInfo As SqlClient.SqlDataAdapter

        Try
            dsGlobalInfo = New DataSet("GlobalInfo")
            strSQL = "SELECT cRestName,cResAddress1,cResAddress2,cResAddress3,cResPhoneNumber," & _
                     " cResFaxNumber,cResEmaiAddress,cResWebAddress,nVat,cVatNumber,cSecurityCode, " & _
                     " nMenuLevel,cGreetinMsg,cRestType,awaytime,collectiontime,waitingtime FROM tMasterInfo"
            daGlobalInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daGlobalInfo.Fill(dsGlobalInfo, "GlobalInfo")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iDataSetRow = dsGlobalInfo.Tables("GlobalInfo").Rows.Count

        If iDataSetRow > 0 Then
            bIsDataExist = True
            txtRestaurantName.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(0) & vbNullString 'To show Restaurant Name
            txtRestaurantAddress1.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(1) & vbNullString 'To show Restaurant Address
            txtRestaurantAddress2.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(2) & vbNullString 'To show Restaurant Address
            txtRestaurantAddress3.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(3) & vbNullString 'To show Restaurant Address
            txtPhoneNumber.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(4) & vbNullString 'To show Restaurant Phone Number
            txtFaxNumber.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(5) & vbNullString 'To show Restaurant Fax Number
            txtEmailAddress.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(6) & vbNullString 'To show Restaurant Email Address
            txtUrl.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(7) & vbNullString 'To show Restaurant Web Address
            txtVat.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(8) & vbNullString 'To show Restaurant Vat  
            txtVatNumber.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(9) & vbNullString 'To show Restaurant Vat Number  
            txt_awaytime.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(14) & vbNullString 'To show takeaway order print time
            txt_collectiontime.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(15) & vbNullString 'To show takeaway order print time
            txt_waitingtime.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(16) & vbNullString 'To show takeaway order print time


            If IsDBNull(dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(10)) = False Then
                txtSecurityCode.Enabled = False
                cbChangeSecurityCode.Enabled = True
                strSecCode = CStr(Trim(dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(10)))
            End If

            If Val(dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(11)) = 2 Then
                rbTwoLevelMenu.Checked = True
            ElseIf Val(dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(11)) = 3 Then
                rbThreeLevelMenu.Checked = True
            End If
            txtGreetingMsg.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(12) & vbNullString 'To show Restaurant Greeting Message
            txtRestuarantType.Text = dsGlobalInfo.Tables("GlobalInfo").Rows(0).Item(13) & vbNullString 'To show Restaurant Type
            bIsDataExist = True
        Else
            bIsDataExist = False
        End If

        If GetSetting("Restaurant", "FormSetting", "StartUp") = vbNullString Then
            rdoTakeaway.Checked = True
        ElseIf GetSetting("Restaurant", "FormSetting", "StartUp") = 2 Then
            rdoTakeaway.Checked = True
        ElseIf GetSetting("Restaurant", "FormSetting", "StartUp") = 1 Then
            rdoDinein.Checked = True
        End If

        If GetSetting("Restaurant", "FormSetting", "TypePrefix") = vbNullString Then
            txtTypePrefix.Text = vbNullString
        Else
            txtTypePrefix.Text = Trim(GetSetting("Restaurant", "FormSetting", "TypePrefix"))
        End If

        If GetSetting("Restaurant", "FormSetting", "TypePrefixItalic") = vbNullString Then
            txtTypeItalic.Text = vbNullString
        Else
            txtTypeItalic.Text = Trim(GetSetting("Restaurant", "FormSetting", "TypePrefixItalic"))
        End If

        If GetSetting("Restaurant", "FormSetting", "NumberOfGuest") = vbNullString Then
            txtNumberofGuest.Text = vbNullString
        Else
            txtNumberofGuest.Text = Trim(GetSetting("Restaurant", "FormSetting", "NumberOfGuest"))
        End If

        If GetSetting("Restaurant", "FormSetting", "ServiceCharge") = vbNullString Then
            txtServiceCharge.Text = vbNullString
        Else
            txtServiceCharge.Text = GetSetting("Restaurant", "FormSetting", "ServiceCharge")
        End If

        If File.Exists(sttCopyLogo) Then
            txtImagelocation.Text = sttCopyLogo
        Else
            txtImagelocation.Text = ""
        End If
    End Function

    Private Sub cbChangeSecurityCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbChangeSecurityCode.Click
        If cbChangeSecurityCode.Checked = True Then
            txtSecurityCode.Enabled = True
        Else
            txtSecurityCode.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim strSecurityCode As String
        Dim strSQL As String
        Dim iManuLevel As Integer

        Dim objfrmSecurityCode As New frmSecurityCode

        If rbTwoLevelMenu.Checked = True Then
            iManuLevel = 2
        Else
            iManuLevel = 3
        End If

        If btnEdit.Text = "Edit" Or btnEdit.Text = "Add" Then
            btnEdit.Text = "Save"
            EnableAllField()
        Else
            If bIsDataExist = False Then
                strSQL = "INSERT INTO tMasterInfo(cRestName,cRestType,cResAddress1,cResAddress2,cResAddress3,cResPhoneNumber," & _
                         "cResFaxNumber,cResEmaiAddress,cResWebAddress,nVat,cVatNumber,cSecurityCode,nMenuLevel,cGreetinMsg,awaytime) " & _
                         "VALUES('" & Replace(Trim(txtRestaurantName.Text), "'", "''") & "','" & Replace(Trim(txtRestuarantType.Text), "'", "''") & _
                         "','" & Replace(Trim(txtRestaurantAddress1.Text), "'", "''") & "','" & Replace(Trim(txtRestaurantAddress2.Text), "'", "''") & _
                         "','" & Replace(Trim(txtRestaurantAddress3.Text), "'", "''") & "','" & Replace(Trim(txtPhoneNumber.Text), "'", "''") & _
                         "','" & Replace(Trim(txtFaxNumber.Text), "'", "''") & "','" & Replace(Trim(txtEmailAddress.Text), "'", "''") & _
                         "','" & Replace(Trim(txtUrl.Text), "'", "''") & "'," & CStr(Trim(txtVat.Text)) & ",'" & Replace(Trim(txtVatNumber.Text), "'", "''") & _
                         "','" & Replace(Trim(txtSecurityCode.Text), "'", "''") & "'," & CStr(iManuLevel) & ",'" & Replace(Trim(txtGreetingMsg.Text), "'", "''") & _
                         "','" & Replace(Trim(txt_awaytime.Text), "'", "''") & "','" & Replace(Trim(txt_collectiontime.Text), "'", "''") & "','" & Replace(Trim(txt_waitingtime.Text), "'", "''") & "'"


                objfrmSecurityCode.lblCaption.Text = "Confirm Security Code"
                objfrmSecurityCode.strSecurityCode = Trim(txtSecurityCode.Text)
                bIsDataExist = True
            Else
                strSQL = "UPDATE tMasterInfo SET cRestName='" & Replace(Trim(txtRestaurantName.Text), "'", "''") & _
                         "',cResAddress1='" & Replace(Trim(txtRestaurantAddress1.Text), "'", "''") & _
                         "',cResAddress2='" & Replace(Trim(txtRestaurantAddress2.Text), "'", "''") & _
                         "',cResAddress3='" & Replace(Trim(txtRestaurantAddress3.Text), "'", "''") & _
                         "',cResPhoneNumber='" & Replace(Trim(txtPhoneNumber.Text), "'", "''") & _
                         "',cResFaxNumber='" & Replace(Trim(txtFaxNumber.Text), "'", "''") & _
                         "',cResEmaiAddress='" & Replace(Trim(txtEmailAddress.Text), "'", "''") & _
                         "',cResWebAddress='" & Replace(Trim(txtUrl.Text), "'", "''") & "',nVat=" & CStr(Trim(txtVat.Text)) & _
                         ",cVatNumber='" & Replace(Trim(txtVatNumber.Text), "'", "''") & "',cRestType='" & Replace(Trim(txtRestuarantType.Text), "'", "''") & _
                         "',cGreetinMsg='" & Replace(txtGreetingMsg.Text, "'", "''") & "',awaytime='" & Replace(txt_awaytime.Text, "'", "''") & "',collectiontime='" & Replace(txt_collectiontime.Text, "'", "''") & "',waitingtime='" & Replace(txt_waitingtime.Text, "'", "''") & "'"
                If cbChangeSecurityCode.Checked = True Then
                    If Trim(txtSecurityCode.Text) <> vbNullString Then
                        strSQL += ",cSecurityCode='" & Trim(txtSecurityCode.Text) & "',nMenuLevel=" & CStr(iManuLevel) & ""
                        strSecurityCode = Trim(txtSecurityCode.Text)
                        objfrmSecurityCode.lblCaption.Text = "Give Old Security Code"
                        objfrmSecurityCode.strSecurityCode = strSecCode
                    Else
                        MsgBox("Please give the Security Code.", MsgBoxStyle.Information, "Global Setting")
                        txtSecurityCode.Focus()
                        Exit Sub
                    End If
                Else
                    strSQL += ",nMenuLevel=" & CStr(iManuLevel) & ""
                    objfrmSecurityCode.lblCaption.Text = "Give Security Code"
                    objfrmSecurityCode.strSecurityCode = strSecCode
                End If
            End If

            If CheckValidation() = False Then
                objfrmSecurityCode.strSQLGlobalSetting = strSQL
                objfrmSecurityCode.Show()
                If rdoDinein.Checked = True Then
                    SaveSetting("Restaurant", "FormSetting", "StartUp", "1")
                ElseIf rdoTakeaway.Checked = True Then
                    SaveSetting("Restaurant", "FormSetting", "StartUp", "2")
                End If

                If Trim(txtTypePrefix.Text) <> vbNullString Then
                    SaveSetting("Restaurant", "FormSetting", "TypePrefix", Trim(txtTypePrefix.Text))
                Else
                    MsgBox("Please give a Type Name(Prefix).", MsgBoxStyle.Information, "Global Setting")
                End If

                If Trim(txtTypeItalic.Text) <> vbNullString Then
                    SaveSetting("Restaurant", "FormSetting", "TypePrefixItalic", Trim(txtTypeItalic.Text))
                End If

                If Trim(txtNumberofGuest.Text) <> vbNullString Then
                    If (Trim(txtServiceCharge.Text)) <> vbNullString Then
                        SaveSetting("Restaurant", "FormSetting", "NumberOfGuest", Trim(txtNumberofGuest.Text))
                        SaveSetting("Restaurant", "FormSetting", "ServiceCharge", Trim(txtServiceCharge.Text))
                    End If
                Else
                    If Trim(txtServiceCharge.Text) <> vbNullString Then
                        SaveSetting("Restaurant", "FormSetting", "NumberOfGuest", Trim(txtNumberofGuest.Text))
                        SaveSetting("Restaurant", "FormSetting", "ServiceCharge", Trim(txtServiceCharge.Text))
                    Else
                        SaveSetting("Restaurant", "FormSetting", "NumberOfGuest", Trim(txtNumberofGuest.Text))
                        SaveSetting("Restaurant", "FormSetting", "ServiceCharge", Trim(txtServiceCharge.Text))
                    End If
                End If

                If Trim(txtImagelocation.Text) <> vbNullString Then
                    If Directory.Exists(strWorkingDirectoy) = False Then
                        Directory.CreateDirectory(strWorkingDirectoy)
                        File.Copy(Trim(txtImagelocation.Text), sttCopyLogo)
                    Else
                        File.Delete(sttCopyLogo)
                        File.Copy(Trim(txtImagelocation.Text), sttCopyLogo)
                    End If
                Else
                    If Directory.Exists(strWorkingDirectoy) = True Then
                        File.Delete(sttCopyLogo)
                        Directory.Delete(strWorkingDirectoy)
                    End If
                End If

            Else
                Exit Sub
            End If
            DisableAllField()
            btnEdit.Text = "Edit"
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Function CheckValidation() As Boolean
        Dim bComtrolTextEmpty As Boolean
        If Trim(txtRestaurantName.Text) = vbNullString Then
            txtRestaurantName.Focus()
            bComtrolTextEmpty = True
        ElseIf Trim(txtVat.Text) = vbNullString Then
            txtVat.Focus()
            bComtrolTextEmpty = True
        ElseIf ValidationForEmailAddress(txtEmailAddress) = False Then
            MessageBox.Show("Please give email address in right format", "Takeaway", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmailAddress.Focus()
            bComtrolTextEmpty = True
        ElseIf Trim(txtNumberofGuest.Text) <> vbNullString Then
            If Trim(txtServiceCharge.Text) = vbNullString Then
                MsgBox("Please give Service Charge.", MsgBoxStyle.Information, "Global Setting")
                bComtrolTextEmpty = True
                txtServiceCharge.Focus()
            End If
        Else
            bComtrolTextEmpty = False
        End If
        CheckValidation = bComtrolTextEmpty
    End Function

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRestaurantName.KeyPress, txtRestuarantType.KeyPress, txtRestaurantAddress2.KeyPress, txtRestaurantAddress3.KeyPress, txtPhoneNumber.KeyPress, txtFaxNumber.KeyPress, txtEmailAddress.KeyPress, txtUrl.KeyPress, txtVatNumber.KeyPress, txtSecurityCode.KeyPress, txtRestaurantAddress1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtVat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVat.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        Else
            ValidationForNumaricDataFromKeyBoaer(e, txtVat)
        End If
    End Sub

    Private Sub RadioButton_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbThreeLevelMenu.KeyPress, rbTwoLevelMenu.KeyPress, rdoDinein.KeyPress, rdoTakeaway.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Function DisableAllField()
        SetEnablePropertyFalse(gbRestaurantInfo)
        SetEnablePropertyFalse(gbMenuLevel)
        SetEnablePropertyFalse(gbVatInfo)
        SetEnablePropertyFalse(gbSecurityInfo)
        SetEnablePropertyFalse(gbTypeName)
        SetEnablePropertyFalse(gbLogo)
        btnImagepath.Enabled = False
        SetEnablePropertyFalse(gbTips)
        SetEnablePropertyFalse(gbItalic)
    End Function

    Private Function EnableAllField()
        SetEnablePropertyTrue(gbRestaurantInfo)
        SetEnablePropertyTrue(gbMenuLevel)
        SetEnablePropertyTrue(gbVatInfo)
        SetEnablePropertyTrue(gbSecurityInfo)
        SetEnablePropertyTrue(gbTypeName)
        SetEnablePropertyTrue(gbLogo)
        SetEnablePropertyTrue(gbItalic)
        btnImagepath.Enabled = True
        SetEnablePropertyTrue(gbTips)
        SetEnablePropertyTrue(gbordertimeset)
    End Function

    Private Sub btnImagepath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagepath.Click
        Dim OpenImagePath As New OpenFileDialog



        With OpenImagePath
            .Title = "Please Select Your Logo...."
            .Filter = "BitMap(*.bmp)|"
            .AddExtension = True
            .ShowDialog()
            If .FileName <> "" Then
                txtImagelocation.Text = .FileName
                'If Directory.Exists(strWorkingDirectoy) = False Then
                '    Directory.CreateDirectory(strWorkingDirectoy)
                '    File.Copy(Trim(txtImagelocation.Text), sttCopyLogo)
                'Else
                '    File.Delete(sttCopyLogo)
                '    File.Copy(Trim(txtImagelocation.Text), sttCopyLogo)
                'End If
            Else
                Exit Sub
            End If
        End With
        OpenImagePath = Nothing
    End Sub

    Private Sub txtNumberofGuest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumberofGuest.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtNumberofGuest)
    End Sub

    Private Sub txtServiceCharge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServiceCharge.KeyPress
        ValidationForNumaricDataFromKeyBoaer(e, txtServiceCharge)
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

   


End Class
