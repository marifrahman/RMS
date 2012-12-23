Public Class frmCustomerInfo
    Inherits System.Windows.Forms.Form

    Dim bCboLoad As Boolean

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        txtTitle.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        cboCity.Text = "(Select a City)"
        txtPostCode.Text = ""
        txtPhoneNumber.Text = ""
        txtFaxNumber.Text = ""
        txtSearchName.Text = ""
        cboSearchCity.Text = "(Select a City)"
        txtSearchPostCode.Text = ""
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboCity As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtFaxNumber As System.Windows.Forms.TextBox
    Friend WithEvents gpCustInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cCustomerName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCustPhone As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents cFirstName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cLastName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCity As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPostCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents cFaxNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As MACButtonLib.MACButton
    Friend WithEvents txtPeopleId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSearchPostCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchName As System.Windows.Forms.TextBox
    Friend WithEvents cboSearchCity As System.Windows.Forms.ComboBox
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents cPeopleId As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustomerInfo))
        Me.gpCustInfo = New System.Windows.Forms.GroupBox
        Me.lblmessage = New System.Windows.Forms.Label
        Me.txtPeopleId = New System.Windows.Forms.TextBox
        Me.txtFaxNumber = New System.Windows.Forms.TextBox
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox
        Me.txtPostCode = New System.Windows.Forms.TextBox
        Me.cboCity = New System.Windows.Forms.ComboBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cPeopleId = New System.Windows.Forms.ColumnHeader
        Me.cCustomerName = New System.Windows.Forms.ColumnHeader
        Me.cTitle = New System.Windows.Forms.ColumnHeader
        Me.cFirstName = New System.Windows.Forms.ColumnHeader
        Me.cLastName = New System.Windows.Forms.ColumnHeader
        Me.cAddress = New System.Windows.Forms.ColumnHeader
        Me.cCity = New System.Windows.Forms.ColumnHeader
        Me.cPostCode = New System.Windows.Forms.ColumnHeader
        Me.cCustPhone = New System.Windows.Forms.ColumnHeader
        Me.cFaxNumber = New System.Windows.Forms.ColumnHeader
        Me.gbSearch = New System.Windows.Forms.GroupBox
        Me.btnClear = New MACButtonLib.MACButton
        Me.cboSearchCity = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSearchName = New System.Windows.Forms.TextBox
        Me.btnSearch = New MACButtonLib.MACButton
        Me.txtSearchPostCode = New System.Windows.Forms.TextBox
        Me.gpCustInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpCustInfo
        '
        Me.gpCustInfo.Controls.Add(Me.lblmessage)
        Me.gpCustInfo.Controls.Add(Me.txtPeopleId)
        Me.gpCustInfo.Controls.Add(Me.txtFaxNumber)
        Me.gpCustInfo.Controls.Add(Me.txtPhoneNumber)
        Me.gpCustInfo.Controls.Add(Me.txtPostCode)
        Me.gpCustInfo.Controls.Add(Me.cboCity)
        Me.gpCustInfo.Controls.Add(Me.txtAddress)
        Me.gpCustInfo.Controls.Add(Me.txtLastName)
        Me.gpCustInfo.Controls.Add(Me.txtFirstName)
        Me.gpCustInfo.Controls.Add(Me.txtTitle)
        Me.gpCustInfo.Controls.Add(Me.Label8)
        Me.gpCustInfo.Controls.Add(Me.Label7)
        Me.gpCustInfo.Controls.Add(Me.Label6)
        Me.gpCustInfo.Controls.Add(Me.Label5)
        Me.gpCustInfo.Controls.Add(Me.Label4)
        Me.gpCustInfo.Controls.Add(Me.Label3)
        Me.gpCustInfo.Controls.Add(Me.Label2)
        Me.gpCustInfo.Controls.Add(Me.Label1)
        Me.gpCustInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gpCustInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpCustInfo.ForeColor = System.Drawing.Color.Maroon
        Me.gpCustInfo.Location = New System.Drawing.Point(10, 12)
        Me.gpCustInfo.Name = "gpCustInfo"
        Me.gpCustInfo.Size = New System.Drawing.Size(322, 350)
        Me.gpCustInfo.TabIndex = 0
        Me.gpCustInfo.TabStop = False
        Me.gpCustInfo.Text = "People Information Details"
        '
        'lblmessage
        '
        Me.lblmessage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.ForeColor = System.Drawing.Color.Maroon
        Me.lblmessage.Location = New System.Drawing.Point(14, 313)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(294, 25)
        Me.lblmessage.TabIndex = 115
        Me.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblmessage.Visible = False
        '
        'txtPeopleId
        '
        Me.txtPeopleId.BackColor = System.Drawing.Color.White
        Me.txtPeopleId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPeopleId.Enabled = False
        Me.txtPeopleId.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeopleId.Location = New System.Drawing.Point(128, -40)
        Me.txtPeopleId.MaxLength = 25
        Me.txtPeopleId.Name = "txtPeopleId"
        Me.txtPeopleId.ReadOnly = True
        Me.txtPeopleId.Size = New System.Drawing.Size(168, 23)
        Me.txtPeopleId.TabIndex = 114
        Me.txtPeopleId.TabStop = False
        Me.txtPeopleId.Text = "txtPeopleId"
        '
        'txtFaxNumber
        '
        Me.txtFaxNumber.BackColor = System.Drawing.Color.White
        Me.txtFaxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFaxNumber.Enabled = False
        Me.txtFaxNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaxNumber.Location = New System.Drawing.Point(128, 281)
        Me.txtFaxNumber.MaxLength = 30
        Me.txtFaxNumber.Name = "txtFaxNumber"
        Me.txtFaxNumber.Size = New System.Drawing.Size(168, 21)
        Me.txtFaxNumber.TabIndex = 8
        Me.txtFaxNumber.TabStop = False
        Me.txtFaxNumber.Text = "txtFaxNumber"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.Color.White
        Me.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNumber.Enabled = False
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(128, 251)
        Me.txtPhoneNumber.MaxLength = 30
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(168, 21)
        Me.txtPhoneNumber.TabIndex = 7
        Me.txtPhoneNumber.TabStop = False
        Me.txtPhoneNumber.Text = "txtPhoneNumber"
        '
        'txtPostCode
        '
        Me.txtPostCode.BackColor = System.Drawing.Color.White
        Me.txtPostCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostCode.Enabled = False
        Me.txtPostCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostCode.Location = New System.Drawing.Point(128, 221)
        Me.txtPostCode.MaxLength = 20
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(168, 21)
        Me.txtPostCode.TabIndex = 6
        Me.txtPostCode.TabStop = False
        Me.txtPostCode.Text = "txtPostCode"
        '
        'cboCity
        '
        Me.cboCity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboCity.BackColor = System.Drawing.Color.White
        Me.cboCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCity.Location = New System.Drawing.Point(128, 188)
        Me.cboCity.MaxLength = 20
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(168, 23)
        Me.cboCity.TabIndex = 5
        Me.cboCity.Text = "cboCity"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(128, 120)
        Me.txtAddress.MaxLength = 250
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(168, 62)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.TabStop = False
        Me.txtAddress.Text = "txtAddress"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Enabled = False
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(128, 88)
        Me.txtLastName.MaxLength = 20
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(168, 21)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.TabStop = False
        Me.txtLastName.Text = "txtLastName"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(128, 56)
        Me.txtFirstName.MaxLength = 20
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(168, 21)
        Me.txtFirstName.TabIndex = 2
        Me.txtFirstName.TabStop = False
        Me.txtFirstName.Text = "txtFirstName"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.White
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Enabled = False
        Me.txtTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(128, 24)
        Me.txtTitle.MaxLength = 10
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(168, 21)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.TabStop = False
        Me.txtTitle.Text = "txtTitle"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Fax"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Phone Number"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Post Code"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "City"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(10, 370)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 56)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnExit.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnExit.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnExit.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnExit.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(244, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 32)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextColorDefault = System.Drawing.Color.Black
        Me.btnExit.TextColorDisabled = System.Drawing.Color.Black
        Me.btnExit.TextColorHover = System.Drawing.Color.White
        Me.btnExit.TextColorNormal = System.Drawing.Color.White
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnDelete.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnDelete.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnDelete.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(164, 15)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 32)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextColorDefault = System.Drawing.Color.Black
        Me.btnDelete.TextColorDisabled = System.Drawing.Color.Black
        Me.btnDelete.TextColorHover = System.Drawing.Color.White
        Me.btnDelete.TextColorNormal = System.Drawing.Color.White
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnEdit.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnEdit.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnEdit.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(84, 15)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 32)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextColorDefault = System.Drawing.Color.Black
        Me.btnEdit.TextColorDisabled = System.Drawing.Color.Black
        Me.btnEdit.TextColorHover = System.Drawing.Color.White
        Me.btnEdit.TextColorNormal = System.Drawing.Color.White
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnAdd.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnAdd.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnAdd.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(7, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 32)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdd.TextColorHover = System.Drawing.Color.White
        Me.btnAdd.TextColorNormal = System.Drawing.Color.White
        '
        'lvLookUp
        '
        Me.lvLookUp.BackColor = System.Drawing.Color.Ivory
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cPeopleId, Me.cCustomerName, Me.cTitle, Me.cFirstName, Me.cLastName, Me.cAddress, Me.cCity, Me.cPostCode, Me.cCustPhone, Me.cFaxNumber})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(344, 152)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(336, 274)
        Me.lvLookUp.TabIndex = 17
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cPeopleId
        '
        Me.cPeopleId.Text = ""
        Me.cPeopleId.Width = 0
        '
        'cCustomerName
        '
        Me.cCustomerName.Text = "Customer Name"
        Me.cCustomerName.Width = 206
        '
        'cTitle
        '
        Me.cTitle.Text = ""
        Me.cTitle.Width = 0
        '
        'cFirstName
        '
        Me.cFirstName.Text = ""
        Me.cFirstName.Width = 0
        '
        'cLastName
        '
        Me.cLastName.Text = ""
        Me.cLastName.Width = 0
        '
        'cAddress
        '
        Me.cAddress.Text = ""
        Me.cAddress.Width = 0
        '
        'cCity
        '
        Me.cCity.Text = ""
        Me.cCity.Width = 0
        '
        'cPostCode
        '
        Me.cPostCode.Text = ""
        Me.cPostCode.Width = 0
        '
        'cCustPhone
        '
        Me.cCustPhone.Text = "Phone"
        Me.cCustPhone.Width = 130
        '
        'cFaxNumber
        '
        Me.cFaxNumber.Text = ""
        Me.cFaxNumber.Width = 0
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.btnClear)
        Me.gbSearch.Controls.Add(Me.cboSearchCity)
        Me.gbSearch.Controls.Add(Me.Label11)
        Me.gbSearch.Controls.Add(Me.Label10)
        Me.gbSearch.Controls.Add(Me.Label9)
        Me.gbSearch.Controls.Add(Me.txtSearchName)
        Me.gbSearch.Controls.Add(Me.btnSearch)
        Me.gbSearch.Controls.Add(Me.txtSearchPostCode)
        Me.gbSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSearch.ForeColor = System.Drawing.Color.Maroon
        Me.gbSearch.Location = New System.Drawing.Point(344, 12)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(336, 126)
        Me.gbSearch.TabIndex = 114
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "People Search Option"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnClear.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnClear.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnClear.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnClear.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(244, 68)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 47)
        Me.btnClear.TabIndex = 121
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColorDefault = System.Drawing.Color.Black
        Me.btnClear.TextColorDisabled = System.Drawing.Color.Black
        Me.btnClear.TextColorHover = System.Drawing.Color.White
        Me.btnClear.TextColorNormal = System.Drawing.Color.White
        '
        'cboSearchCity
        '
        Me.cboSearchCity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSearchCity.BackColor = System.Drawing.Color.White
        Me.cboSearchCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchCity.Location = New System.Drawing.Point(92, 55)
        Me.cboSearchCity.MaxLength = 20
        Me.cboSearchCity.Name = "cboSearchCity"
        Me.cboSearchCity.Size = New System.Drawing.Size(144, 23)
        Me.cboSearchCity.TabIndex = 14
        Me.cboSearchCity.Text = "cboSearchCity"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 23)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "Post Code"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "City"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "Name"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSearchName
        '
        Me.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchName.Location = New System.Drawing.Point(92, 23)
        Me.txtSearchName.MaxLength = 50
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(144, 21)
        Me.txtSearchName.TabIndex = 13
        Me.txtSearchName.TabStop = False
        Me.txtSearchName.Text = "txtSearchName"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnSearch.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnSearch.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnSearch.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(244, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(82, 47)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextColorDefault = System.Drawing.Color.Black
        Me.btnSearch.TextColorDisabled = System.Drawing.Color.Black
        Me.btnSearch.TextColorHover = System.Drawing.Color.White
        Me.btnSearch.TextColorNormal = System.Drawing.Color.White
        '
        'txtSearchPostCode
        '
        Me.txtSearchPostCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchPostCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPostCode.Location = New System.Drawing.Point(92, 90)
        Me.txtSearchPostCode.MaxLength = 20
        Me.txtSearchPostCode.Name = "txtSearchPostCode"
        Me.txtSearchPostCode.Size = New System.Drawing.Size(144, 21)
        Me.txtSearchPostCode.TabIndex = 15
        Me.txtSearchPostCode.TabStop = False
        Me.txtSearchPostCode.Text = "txtSearchPostCode"
        '
        'frmCustomerInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(692, 438)
        Me.Controls.Add(Me.gbSearch)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpCustInfo)
        Me.Name = "frmCustomerInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCustomerInfo"
        Me.gpCustInfo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function FillCityCombo()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsCity As DataSet
        Dim daCityInfo As SqlClient.SqlDataAdapter

        Try
            dsCity = New DataSet("City")
            strSQL = "SELECT cCity,nCityId FROM tCity WHERE nActiveCity = 1"
            daCityInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCityInfo.Fill(dsCity, "City")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsCity.Tables("City").Rows.Count

        If icount > 0 Then
            With cboCity
                .DataSource = dsCity.Tables("City")
                .DisplayMember = "cCity"
                .ValueMember = "nCityId"
                .SelectedIndex = -1
            End With

            With cboSearchCity
                .DataSource = dsCity.Tables("City")
                .DisplayMember = "cCity"
                .ValueMember = "nCityId"
                .SelectedIndex = -1
            End With
        End If
    End Function

    Private Sub frmCustomerInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": People Entry Form"
        Else
            Me.Text = mdConfiguration.strResturantName & ": People Entry Form"
        End If

        bCboLoad = False
        FillCityCombo()
        bCboLoad = True

        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(gpCustInfo)
        cboCity.Enabled = False
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        txtPeopleId.Text = lvLookUp.SelectedItems(0).Text                   'Id
        txtTitle.Text = lvLookUp.SelectedItems(0).SubItems(2).Text          'People Title 
        txtFirstName.Text = lvLookUp.SelectedItems(0).SubItems(3).Text      'First Name
        txtLastName.Text = lvLookUp.SelectedItems(0).SubItems(4).Text       'Last Name
        txtAddress.Text = lvLookUp.SelectedItems(0).SubItems(5).Text        'Address
        cboCity.Text = lvLookUp.SelectedItems(0).SubItems(6).Text           'City
        txtPostCode.Text = lvLookUp.SelectedItems(0).SubItems(7).Text       'Post Code
        txtPhoneNumber.Text = lvLookUp.SelectedItems(0).SubItems(8).Text    'Phone Number
        txtFaxNumber.Text = lvLookUp.SelectedItems(0).SubItems(8).Text      'Fax Number
        lblmessage.Visible = False
    End Sub


    Private Sub Event_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdd.KeyPress, btnEdit.KeyPress, btnDelete.KeyPress, btnExit.KeyPress, cboCity.KeyPress, txtPostCode.KeyPress, txtPhoneNumber.KeyPress, txtFaxNumber.KeyPress, txtSearchName.KeyPress, cboSearchCity.KeyPress, txtSearchPostCode.KeyPress, btnSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub NameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress, txtFirstName.KeyPress, txtLastName.KeyPress
        Dim tmpTextBox As TextBox
        tmpTextBox = sender

        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        Else
            ValidationForCharacter(e, tmpTextBox)
        End If
    End Sub

    Private Function CheckEmptyItemInfo() As Boolean
        Dim bComtrolTextEmpty As Boolean
        Dim strFullName As String
        strFullName = Trim(txtTitle.Text) & Trim(txtFirstName.Text) & Trim(txtLastName.Text)

        If Len(Trim(strFullName)) <= 0 Then
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please give Name."
            txtTitle.Focus()
            bComtrolTextEmpty = True
        ElseIf Len(Trim(txtAddress.Text)) <= 0 Then
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please give Address."
            txtAddress.Focus()
            bComtrolTextEmpty = True
        ElseIf Len(Trim(cboCity.Text)) <= 0 Then
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please select City."
            cboCity.Focus()
            bComtrolTextEmpty = True
        ElseIf Len(Trim(txtPostCode.Text)) <= 0 Then
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please give Post Code."
            txtPostCode.Focus()
            bComtrolTextEmpty = True
        ElseIf Len(Trim(txtPhoneNumber.Text)) <= 0 Then
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please give Phone Number."
            txtPhoneNumber.Focus()
            bComtrolTextEmpty = True
        Else
            bComtrolTextEmpty = False
        End If

        CheckEmptyItemInfo = bComtrolTextEmpty

    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim strSQLInsert As String
        Dim strSQLUpdate As String

        Dim cmdInsert As SqlClient.SqlCommand

        If btnAdd.Text = "Add" Then
            lblmessage.Visible = False
            ClearTextProperty(gpCustInfo)
            SetEnablePropertyTrue(gpCustInfo)
            cboCity.Enabled = True
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)

        ElseIf btnAdd.Text = "Save" Then
            If CheckEmptyItemInfo() = False Then

                strSQLInsert = "INSERT INTO tPeopleInfo(cTitle,cFirstName,cLastName,cAddress,cCity,cPostCode,cPhoneNumber,cFax,nActivePeople) " & _
                               "VALUES('" & Trim(txtTitle.Text) & "','" & Trim(txtFirstName.Text) & "','" & Trim(txtLastName.Text) & _
                               "','" & Trim(txtAddress.Text) & "','" & Trim(cboCity.Text) & "','" & Trim(txtPostCode.Text) & _
                               "','" & Trim(txtPhoneNumber.Text) & "','" & Trim(txtFaxNumber.Text) & "',1)"

                strSQLUpdate = "UPDATE tPeopleInfo SET cTitle='" & Trim(txtTitle.Text) & _
                               "',cFirstName='" & Trim(txtFirstName.Text) & "',cLastName='" & Trim(txtLastName.Text) & _
                               "',cAddress='" & Trim(txtAddress.Text) & "',cCity='" & Trim(cboCity.Text) & _
                               "',cPostCode='" & Trim(txtPostCode.Text) & "',cPhoneNumber='" & Trim(txtPhoneNumber.Text) & _
                               "',cFax='" & Trim(txtFaxNumber.Text) & _
                               "' WHERE nPeopleId=" & CStr(Trim(txtPeopleId.Text)) & ""

                Try
                    cmdInsert = New SqlClient.SqlCommand
                    cmdInsert.Connection = mdDBConnection.connRestuarant
                    If Trim(txtPeopleId.Text) <> vbNullString Then
                        cmdInsert.CommandText = strSQLUpdate
                    Else
                        cmdInsert.CommandText = strSQLInsert
                    End If

                    cmdInsert.ExecuteNonQuery()
                    MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                    SetEnablePropertyFalse(gpCustInfo)
                    ClearTextProperty(gpCustInfo)
                    cboCity.SelectedIndex = -1
                    cboCity.Enabled = False
                    lblmessage.Visible = True
                    lblmessage.ForeColor = Color.Green
                    lblmessage.Text = "Your Information has been Saved Successfully."
                Catch ex As Exception
                    MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Trim(txtPeopleId.Text) <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                lblmessage.Visible = False
                SetEnablePropertyTrue(gpCustInfo)
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
                cboCity.Enabled = True
                txtTitle.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(gpCustInfo)   'To Clear All the information from Text Box
                SetEnablePropertyFalse(gpCustInfo)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblmessage.Visible = False
                cboCity.Enabled = False
                cboCity.SelectedIndex = -1
            End If
        Else
            If btnEdit.Text = "Edit" Then
                lblmessage.Visible = True
                lblmessage.ForeColor = Color.Maroon
                lblmessage.Text = "* Please select People"
                lvLookUp.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(gpCustInfo)   'To Clear All the information from Text Box
                SetEnablePropertyFalse(gpCustInfo)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblmessage.Visible = False
                cboCity.Enabled = False
                cboCity.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Function UpdateCardActivation()
        Dim strSQLTable As String
        Dim cmdUpdateTableInfo As SqlClient.SqlCommand

        If Trim(txtPeopleId.Text) <> vbNullString Then
            strSQLTable = "UPDATE tPeopleInfo SET nActivePeople = 0 WHERE nPeopleId=" & CStr(Trim(txtPeopleId.Text)) & ""
            Try
                cmdUpdateTableInfo = New SqlClient.SqlCommand
                cmdUpdateTableInfo.Connection = mdDBConnection.connRestuarant
                cmdUpdateTableInfo.CommandText = strSQLTable
                cmdUpdateTableInfo.ExecuteNonQuery()
                lblmessage.Visible = True
                lblmessage.ForeColor = Color.Green
                lblmessage.Text = "Your Information has been Deleted Successfully."
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        Else
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "Please select People."
        End If
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        UpdateCardActivation()
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(gpCustInfo)
        ClearTextProperty(gpCustInfo)
        cboCity.Enabled = False
        cboCity.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String
        Dim strFullName As String
        Dim dsPeople As DataSet
        Dim daPeopleInfo As SqlClient.SqlDataAdapter

        If Len(Trim(txtSearchName.Text)) <> 0 Or Len(Trim(txtSearchPostCode.Text)) <> 0 Or Len(Trim(cboSearchCity.Text)) <> 0 Then
            strSQL = "SELECT nPeopleId,cTitle,cFirstName,cLastName,cAddress,cCity,cPostCode,cPhoneNumber,cFax FROM tPeopleInfo WHERE nActivePeople=1"
            strSQL += IIf(Len(Trim(txtSearchName.Text)) <= 0, "", " AND (cTitle+cFirstName+cLastName) LIKE '%" & Trim(txtSearchName.Text) & "%'")
            strSQL += IIf(Len(Trim(cboSearchCity.Text)) <= 0, "", " AND cCity LIKE '" & Trim(cboSearchCity.Text) & "%'")
            strSQL += IIf(Len(Trim(txtSearchPostCode.Text)) <= 0, "", " AND cPostCode LIKE '" & Trim(txtSearchPostCode.Text) & "%'")
        Else
            Exit Sub
        End If

        Try
            dsPeople = New DataSet("People")
            daPeopleInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daPeopleInfo.Fill(dsPeople, "People")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsPeople.Tables("People").Rows.Count

        lvLookUp.Items.Clear()
        If icount > 0 Then
            For iIndex = 0 To icount - 1
                strFullName = Trim(dsPeople.Tables("People").Rows(iIndex).Item(1)) & " " & Trim(dsPeople.Tables("People").Rows(iIndex).Item(2)) & " " & Trim(dsPeople.Tables("People").Rows(iIndex).Item(3))
                lvLookUp.Items.Add(Trim(dsPeople.Tables("People").Rows(iIndex).Item(0)))                  'People Id
                lvLookUp.Items(iIndex).SubItems.Add(strFullName)                                          'FullName
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsPeople.Tables("People").Rows(iIndex).Item(1))) 'Title
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsPeople.Tables("People").Rows(iIndex).Item(2))) 'First Name
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsPeople.Tables("People").Rows(iIndex).Item(3))) 'Last Name
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsPeople.Tables("People").Rows(iIndex).Item(4))) 'Address
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsPeople.Tables("People").Rows(iIndex).Item(5))) 'City
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsPeople.Tables("People").Rows(iIndex).Item(6))) 'Post Code
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsPeople.Tables("People").Rows(iIndex).Item(7))) 'Phone Number
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsPeople.Tables("People").Rows(iIndex).Item(8))) 'Fax Number
            Next
        Else
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "There is no People Found to Show."
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSearchName.Text = ""
        txtSearchPostCode.Text = ""
        cboSearchCity.Text = ""
        lvLookUp.Items.Clear()
        txtSearchName.Focus()
    End Sub
End Class
