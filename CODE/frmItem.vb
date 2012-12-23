Public Class frmItem
    Inherits System.Windows.Forms.Form

    Dim bCboLoad As Boolean

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
    Friend WithEvents pnlCatagorybtn As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTypeID As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeName As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtItemSC As System.Windows.Forms.TextBox
    Friend WithEvents pnlItem As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage2 As System.Windows.Forms.Label
    Friend WithEvents btnSelectType As System.Windows.Forms.Button
    Friend WithEvents btnSelectItem As System.Windows.Forms.Button
    Friend WithEvents cboItemLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboMeasurementUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtTakeawayPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDineInPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cTypeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTypeSC As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTypeId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItem))
        Me.pnlItem = New System.Windows.Forms.Panel
        Me.cboMeasurementUnit = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDineInPrice = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTakeawayPrice = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboItemLocation = New System.Windows.Forms.ComboBox
        Me.btnSelectItem = New System.Windows.Forms.Button
        Me.lblMessage2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtItemId = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.txtItemSC = New System.Windows.Forms.TextBox
        Me.pnlCatagorybtn = New System.Windows.Forms.Panel
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.txtTypeID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTypeName = New System.Windows.Forms.TextBox
        Me.lblMessage1 = New System.Windows.Forms.Label
        Me.btnSelectType = New System.Windows.Forms.Button
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cTypeName = New System.Windows.Forms.ColumnHeader
        Me.cTypeSC = New System.Windows.Forms.ColumnHeader
        Me.cTypeId = New System.Windows.Forms.ColumnHeader
        Me.pnlItem.SuspendLayout()
        Me.pnlCatagorybtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlItem
        '
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Controls.Add(Me.cboMeasurementUnit)
        Me.pnlItem.Controls.Add(Me.Label7)
        Me.pnlItem.Controls.Add(Me.Label6)
        Me.pnlItem.Controls.Add(Me.Label5)
        Me.pnlItem.Controls.Add(Me.txtDineInPrice)
        Me.pnlItem.Controls.Add(Me.Label4)
        Me.pnlItem.Controls.Add(Me.txtTakeawayPrice)
        Me.pnlItem.Controls.Add(Me.Label2)
        Me.pnlItem.Controls.Add(Me.cboItemLocation)
        Me.pnlItem.Controls.Add(Me.btnSelectItem)
        Me.pnlItem.Controls.Add(Me.lblMessage2)
        Me.pnlItem.Controls.Add(Me.Label1)
        Me.pnlItem.Controls.Add(Me.Label8)
        Me.pnlItem.Controls.Add(Me.txtItemDesc)
        Me.pnlItem.Controls.Add(Me.Label9)
        Me.pnlItem.Controls.Add(Me.Label10)
        Me.pnlItem.Controls.Add(Me.txtItemId)
        Me.pnlItem.Controls.Add(Me.Label11)
        Me.pnlItem.Controls.Add(Me.txtItemName)
        Me.pnlItem.Controls.Add(Me.txtItemSC)
        Me.pnlItem.Location = New System.Drawing.Point(7, 13)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(321, 275)
        Me.pnlItem.TabIndex = 2
        '
        'cboMeasurementUnit
        '
        Me.cboMeasurementUnit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMeasurementUnit.Items.AddRange(New Object() {"Dish", "Peg", "Can", "Bottole"})
        Me.cboMeasurementUnit.Location = New System.Drawing.Point(134, 62)
        Me.cboMeasurementUnit.Name = "cboMeasurementUnit"
        Me.cboMeasurementUnit.Size = New System.Drawing.Size(174, 23)
        Me.cboMeasurementUnit.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(252, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "per unit"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "per unit"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "DineIn Price"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDineInPrice
        '
        Me.txtDineInPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDineInPrice.Enabled = False
        Me.txtDineInPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDineInPrice.Location = New System.Drawing.Point(134, 116)
        Me.txtDineInPrice.MaxLength = 15
        Me.txtDineInPrice.Name = "txtDineInPrice"
        Me.txtDineInPrice.Size = New System.Drawing.Size(112, 21)
        Me.txtDineInPrice.TabIndex = 13
        Me.txtDineInPrice.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Takeaway Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTakeawayPrice
        '
        Me.txtTakeawayPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTakeawayPrice.Enabled = False
        Me.txtTakeawayPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTakeawayPrice.Location = New System.Drawing.Point(134, 90)
        Me.txtTakeawayPrice.MaxLength = 15
        Me.txtTakeawayPrice.Name = "txtTakeawayPrice"
        Me.txtTakeawayPrice.Size = New System.Drawing.Size(112, 21)
        Me.txtTakeawayPrice.TabIndex = 10
        Me.txtTakeawayPrice.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Measurement Unit"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboItemLocation
        '
        Me.cboItemLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemLocation.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemLocation.Items.AddRange(New Object() {"Kitchen", "Bar"})
        Me.cboItemLocation.Location = New System.Drawing.Point(134, 190)
        Me.cboItemLocation.Name = "cboItemLocation"
        Me.cboItemLocation.Size = New System.Drawing.Size(168, 23)
        Me.cboItemLocation.TabIndex = 18
        '
        'btnSelectItem
        '
        Me.btnSelectItem.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectItem.Location = New System.Drawing.Point(424, 10)
        Me.btnSelectItem.Name = "btnSelectItem"
        Me.btnSelectItem.Size = New System.Drawing.Size(48, 20)
        Me.btnSelectItem.TabIndex = 5
        Me.btnSelectItem.Text = "Select"
        Me.btnSelectItem.Visible = False
        '
        'lblMessage2
        '
        Me.lblMessage2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage2.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage2.Location = New System.Drawing.Point(8, 225)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(304, 31)
        Me.lblMessage2.TabIndex = 19
        Me.lblMessage2.Text = "* Please give Item Name"
        Me.lblMessage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage2.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Short Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Item Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemDesc
        '
        Me.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemDesc.Enabled = False
        Me.txtItemDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc.Location = New System.Drawing.Point(134, 143)
        Me.txtItemDesc.MaxLength = 250
        Me.txtItemDesc.Multiline = True
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtItemDesc.Size = New System.Drawing.Size(174, 40)
        Me.txtItemDesc.TabIndex = 16
        Me.txtItemDesc.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Serve Location"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 40)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Description"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtItemId
        '
        Me.txtItemId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemId.Enabled = False
        Me.txtItemId.Location = New System.Drawing.Point(384, 10)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.ReadOnly = True
        Me.txtItemId.Size = New System.Drawing.Size(174, 20)
        Me.txtItemId.TabIndex = 4
        Me.txtItemId.Text = ""
        Me.txtItemId.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-160, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 20)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Item ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'txtItemName
        '
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Enabled = False
        Me.txtItemName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(134, 10)
        Me.txtItemName.MaxLength = 50
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(174, 21)
        Me.txtItemName.TabIndex = 4
        Me.txtItemName.Text = ""
        '
        'txtItemSC
        '
        Me.txtItemSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemSC.Enabled = False
        Me.txtItemSC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSC.Location = New System.Drawing.Point(134, 36)
        Me.txtItemSC.MaxLength = 20
        Me.txtItemSC.Name = "txtItemSC"
        Me.txtItemSC.Size = New System.Drawing.Size(174, 21)
        Me.txtItemSC.TabIndex = 6
        Me.txtItemSC.Text = ""
        '
        'pnlCatagorybtn
        '
        Me.pnlCatagorybtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCatagorybtn.Controls.Add(Me.btnKeyBoard)
        Me.pnlCatagorybtn.Controls.Add(Me.btnExit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnDelete)
        Me.pnlCatagorybtn.Controls.Add(Me.btnEdit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnAdd)
        Me.pnlCatagorybtn.Location = New System.Drawing.Point(7, 296)
        Me.pnlCatagorybtn.Name = "pnlCatagorybtn"
        Me.pnlCatagorybtn.Size = New System.Drawing.Size(321, 72)
        Me.pnlCatagorybtn.TabIndex = 20
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
        Me.btnKeyBoard.Location = New System.Drawing.Point(96, 40)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(118, 32)
        Me.btnKeyBoard.TabIndex = 70
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
        Me.btnExit.Location = New System.Drawing.Point(242, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 32)
        Me.btnExit.TabIndex = 24
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
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(162, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 32)
        Me.btnDelete.TabIndex = 23
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
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(82, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 32)
        Me.btnEdit.TabIndex = 22
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
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(8, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 32)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdd.TextColorHover = System.Drawing.Color.White
        Me.btnAdd.TextColorNormal = System.Drawing.Color.White
        '
        'txtTypeID
        '
        Me.txtTypeID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTypeID.Location = New System.Drawing.Point(156, -88)
        Me.txtTypeID.Name = "txtTypeID"
        Me.txtTypeID.ReadOnly = True
        Me.txtTypeID.Size = New System.Drawing.Size(46, 20)
        Me.txtTypeID.TabIndex = 1
        Me.txtTypeID.Text = ""
        Me.txtTypeID.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, -88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 38)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dish Type"
        Me.Label3.Visible = False
        '
        'txtTypeName
        '
        Me.txtTypeName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTypeName.Location = New System.Drawing.Point(252, -88)
        Me.txtTypeName.Name = "txtTypeName"
        Me.txtTypeName.ReadOnly = True
        Me.txtTypeName.Size = New System.Drawing.Size(120, 20)
        Me.txtTypeName.TabIndex = 3
        Me.txtTypeName.Text = ""
        Me.txtTypeName.Visible = False
        '
        'lblMessage1
        '
        Me.lblMessage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage1.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage1.Location = New System.Drawing.Point(137, -64)
        Me.lblMessage1.Name = "lblMessage1"
        Me.lblMessage1.Size = New System.Drawing.Size(175, 31)
        Me.lblMessage1.TabIndex = 4
        Me.lblMessage1.Text = "* Please Select Type Name"
        Me.lblMessage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage1.Visible = False
        '
        'btnSelectType
        '
        Me.btnSelectType.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSelectType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectType.Location = New System.Drawing.Point(203, -88)
        Me.btnSelectType.Name = "btnSelectType"
        Me.btnSelectType.Size = New System.Drawing.Size(48, 35)
        Me.btnSelectType.TabIndex = 2
        Me.btnSelectType.Text = "Select"
        Me.btnSelectType.Visible = False
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.Location = New System.Drawing.Point(432, 13)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(224, 23)
        Me.cboType.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(336, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Select  Type"
        '
        'lvLookUp
        '
        Me.lvLookUp.BackColor = System.Drawing.Color.Ivory
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cTypeName, Me.cTypeSC, Me.cTypeId})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(336, 48)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(320, 320)
        Me.lvLookUp.TabIndex = 20
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cTypeName
        '
        Me.cTypeName.Text = "Item Name"
        Me.cTypeName.Width = 180
        '
        'cTypeSC
        '
        Me.cTypeSC.Text = "ShortCode"
        Me.cTypeSC.Width = 140
        '
        'cTypeId
        '
        Me.cTypeId.Width = 0
        '
        'frmItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(658, 376)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.btnSelectType)
        Me.Controls.Add(Me.lblMessage1)
        Me.Controls.Add(Me.txtTypeName)
        Me.Controls.Add(Me.txtTypeID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlCatagorybtn)
        Me.Controls.Add(Me.pnlItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Management in a Type of dish"
        Me.pnlItem.ResumeLayout(False)
        Me.pnlCatagorybtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function FillTypeCombo()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsCategory As DataSet
        Dim daCategoryInfo As SqlClient.SqlDataAdapter

        Try
            dsCategory = New DataSet("Type")
            strSQL = "SELECT cType_Name,nType_Id FROM tType WHERE nTypeActive = 1"
            daCategoryInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCategoryInfo.Fill(dsCategory, "Type")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsCategory.Tables("Type").Rows.Count

        If icount > 0 Then
            With cboType
                .DataSource = dsCategory.Tables("Type")
                .DisplayMember = "cType_Name"
                .ValueMember = "nType_Id"
                .SelectedIndex = -1
            End With
        End If
    End Function

    Private Sub frmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 2
        Me.Top = 30
        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Item Management in a Type of dish"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Item Management in a Type of dish"
        End If

        bCboLoad = True
        FillTypeCombo()
        bCboLoad = False
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlItem)
        cboMeasurementUnit.Enabled = False
        cboItemLocation.Enabled = False
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dDineInPrice As Double
        Dim dTakeawayPrice As Double

        Dim strSQLGenerateID As String
        Dim strSQLInsert As String
        Dim strSQLUpdate As String
        Dim cmdInsert As SqlClient.SqlCommand

        If btnAdd.Text = "Add" Then
            lblMessage2.Visible = False
            ClearTextProperty(pnlItem)
            SetEnablePropertyTrue(pnlItem)
            cboMeasurementUnit.Enabled = True
            cboItemLocation.Enabled = True
            cboMeasurementUnit.SelectedIndex = -1
            cboItemLocation.SelectedIndex = -1
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
        ElseIf btnAdd.Text = "Save" Then
            If CheckEmptyItemInfo() = False Then
                dDineInPrice = FormatNumber(Trim(txtDineInPrice.Text))
                dTakeawayPrice = FormatNumber(Trim(txtTakeawayPrice.Text))

                strSQLInsert = "INSERT INTO tItem(cItem_Name,cItem_SC,cItem_ServeLoc,cMeasurUnit,cItem_Desc," & _
                               "nItem_Stock,mDinePrice,mTakeawayPrice,nItemActive,nType_Id,cUserId,cTerminal," & _
                               "dAccessTime) VALUES('" & Replace(Trim(txtItemName.Text), "'", "''") & "','" & Replace(Trim(txtItemSC.Text), "'", "''") & _
                               "','" & Replace(Trim(cboItemLocation.Text), "'", "''") & "','" & Replace(Trim(cboMeasurementUnit.Text), "'", "''") & _
                               "','" & Replace(Trim(txtItemDesc.Text), "'", "''") & "',0," & CStr(dDineInPrice) & "," & CStr(dTakeawayPrice) & _
                               ",1," & CStr(Trim(txtTypeID.Text)) & ",'" + user + "','" + sTerminal + "',GETDATE())"

                strSQLUpdate = "UPDATE tItem SET cItem_Name='" & Replace(Trim(txtItemName.Text), "'", "''") & "',cItem_SC='" & Replace(Trim(txtItemSC.Text), "'", "''") & _
                               "',cMeasurUnit='" & Replace(Trim(cboMeasurementUnit.Text), "'", "''") & "',cItem_ServeLoc='" & Replace(Trim(cboItemLocation.Text), "'", "''") & _
                               "',mDinePrice=" & CStr(dDineInPrice) & ",mTakeawayPrice=" & CStr(dTakeawayPrice) & _
                               ",cItem_Desc='" & Replace(Trim(txtItemDesc.Text), "'", "''") & "',cUserId='" & user & _
                               "',cTerminal='" & sTerminal & "',dAccessTime=GETDATE() WHERE nItem_Id=" & Trim(txtItemId.Text) & ""

                Try
                    cmdInsert = New SqlClient.SqlCommand
                    cmdInsert.Connection = mdDBConnection.connRestuarant
                    If Trim(txtItemId.Text) <> vbNullString Then
                        cmdInsert.CommandText = strSQLUpdate
                    Else
                        cmdInsert.CommandText = strSQLInsert
                    End If
                    cmdInsert.ExecuteNonQuery()
                    ClearTextProperty(pnlItem)
                    cboItemLocation.SelectedIndex = -1
                    cboMeasurementUnit.SelectedIndex = -1
                    SetEnablePropertyFalse(pnlItem)
                    cboItemLocation.Enabled = False
                    cboMeasurementUnit.Enabled = False
                    lblMessage2.Visible = True
                    lblMessage2.ForeColor = Color.Green
                    lblMessage2.Text = "Your Information has been Saved Successfully."
                    MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                    ShowItemInfoToGrid()
                Catch ex As Exception
                    MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                End Try
            End If
        End If
    End Sub

    Private Function CheckEmptyItemInfo() As Boolean
        Dim bComtrolTextEmpty As Boolean

        If Trim(txtItemName.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please give Item Name"
            txtItemName.Focus()
            bComtrolTextEmpty = True
        ElseIf Trim(txtItemSC.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please give Short Code"
            txtItemSC.Focus()
            bComtrolTextEmpty = True
        ElseIf Trim(cboMeasurementUnit.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please give a Measurement Unit"
            cboMeasurementUnit.Focus()
            bComtrolTextEmpty = True
        ElseIf Trim(txtTakeawayPrice.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please give Takeaway Price"
            txtTakeawayPrice.Focus()
            bComtrolTextEmpty = True
        ElseIf Trim(txtDineInPrice.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please give DineIn Price"
            txtDineInPrice.Focus()
            bComtrolTextEmpty = True
        ElseIf Trim(cboItemLocation.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please select Serve Location"
            cboItemLocation.Focus()
            bComtrolTextEmpty = True
        Else
            lblMessage2.Visible = False
            bComtrolTextEmpty = False
        End If
        CheckEmptyItemInfo = bComtrolTextEmpty
    End Function

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Trim(txtItemId.Text) <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                lblMessage2.Visible = False
                SetEnablePropertyTrue(Me)
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
                SetEnablePropertyTrue(pnlItem)
                cboMeasurementUnit.Enabled = True
                cboItemLocation.Enabled = True
                txtItemName.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlItem)   'To Clear All the information from Text Box
                SetEnablePropertyFalse(pnlItem)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                cboMeasurementUnit.Enabled = False
                cboItemLocation.Enabled = False
                lblMessage2.Visible = False
                cboMeasurementUnit.SelectedIndex = -1
                cboItemLocation.SelectedIndex = -1
            End If
        Else
            If btnEdit.Text = "Edit" Then
                lblMessage2.Visible = True
                lblMessage2.ForeColor = Color.Maroon
                lblMessage2.Text = "* Please select an Item"
                lvLookUp.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlItem)   'To Clear All the information from Text Box
                SetEnablePropertyFalse(pnlItem)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                cboMeasurementUnit.Enabled = False
                cboItemLocation.Enabled = False
                lblMessage2.Visible = False
                cboMeasurementUnit.SelectedIndex = -1
                cboItemLocation.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblMessage2.Visible = False
        FillDataSetForUpDate()
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlItem)
        cboMeasurementUnit.Enabled = False
        cboItemLocation.Enabled = False
        ClearTextProperty(pnlItem)
        cboMeasurementUnit.SelectedIndex = -1
        cboItemLocation.SelectedIndex = -1
        ShowItemInfoToGrid()
    End Sub

    Private Function FillDataSetForUpDate()
        Dim strSQLItem As String
        Dim strSQLInstruction As String
        Dim strMessage As String = "Your Information has been Deleted Successfully"

        Dim daItem As SqlClient.SqlDataAdapter
        Dim dsItem As DataSet

        Dim daInstruction As SqlClient.SqlDataAdapter
        Dim dsInstruction As DataSet

        If Trim(txtItemId.Text) <> vbNullString Then
            strSQLItem = "SELECT nItem_Id,nItemActive FROM tItem WHERE nItem_Id=" & CStr(Trim(txtItemId.Text)) & ""

            Try
                dsItem = New DataSet("Item")
                daItem = New SqlClient.SqlDataAdapter(strSQLItem, mdDBConnection.connRestuarant)
                daItem.Fill(dsItem, "Item")

                strSQLInstruction = "SELECT nInstruction_Id,nActiveInstruction FROM tInstruction WHERE nItem_Id=" & CStr(Trim(txtItemId.Text)) & ""

                dsInstruction = New DataSet("Instruction")
                daInstruction = New SqlClient.SqlDataAdapter(strSQLInstruction, mdDBConnection.connRestuarant)
                daInstruction.Fill(dsInstruction, "Instruction")

                UpdateDataSet(dsItem, dsInstruction)
                UpdateDataBaseWithDataSet(daItem, dsItem, daInstruction, dsInstruction)
                lblMessage2.Visible = True
                lblMessage2.ForeColor = Color.Green
                lblMessage2.Text = "Your Information has been Deleted Successfully."
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Function

    Private Function UpdateDataSet(ByVal tmpItemDataSet As DataSet, ByVal tmpInstructionDataSet As DataSet)

        Dim iIndex As Integer

        Dim iCountItem As Integer
        Dim iCountInstruction As Integer

        tmpItemDataSet.Tables("Item").Rows(0)("nItemActive") = 0

        iCountInstruction = tmpInstructionDataSet.Tables("Instruction").Rows.Count
        If iCountInstruction > 0 Then
            For iIndex = 0 To iCountInstruction - 1
                tmpInstructionDataSet.Tables("Instruction").Rows(iIndex)("nActiveInstruction") = 0
            Next
        End If
    End Function

    Private Function UpdateDataBaseWithDataSet(ByVal tmpDAItem As SqlClient.SqlDataAdapter, ByVal tmpDSItem As DataSet, _
                                               ByVal tmpDAInstruction As SqlClient.SqlDataAdapter, ByVal tmpDSInstruction As DataSet)

        Dim myDataRowsComBuilderItem As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(tmpDAItem)
        Dim myDataRowsComBuilderInst As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(tmpDAInstruction)

        tmpDAItem.Update(tmpDSItem, "Item")
        tmpDAInstruction.Update(tmpDSInstruction, "Instruction")
    End Function

    Private Sub txtItemName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemName.TextChanged
        lblMessage2.Visible = False
    End Sub

    Private Sub Event_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnSelectType.KeyPress, txtItemId.KeyPress, btnSelectItem.KeyPress, txtItemName.KeyPress, txtItemSC.KeyPress, cboMeasurementUnit.KeyPress, txtItemDesc.KeyPress, cboItemLocation.KeyPress, btnAdd.KeyPress, btnEdit.KeyPress, btnDelete.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtTakeawayPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTakeawayPrice.KeyPress, txtDineInPrice.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        Else
            ValidationForPositiveNumaricData(e, sender)
        End If
    End Sub

    Private Sub txtDineInPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDineInPrice.LostFocus
        If Trim(txtDineInPrice.Text) <> vbNullString Then
            txtDineInPrice.Text = FormatCurrency(txtDineInPrice.Text)
        End If
    End Sub

    Private Sub txtTakeawayPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTakeawayPrice.LostFocus
        If Trim(txtTakeawayPrice.Text) <> vbNullString Then
            txtTakeawayPrice.Text = FormatCurrency(txtTakeawayPrice.Text)
        End If
    End Sub

    Private Function ShowItemInfoToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsItem As DataSet
        Dim daItemInfo As SqlClient.SqlDataAdapter

        If cboType.SelectedIndex = -1 Then
            Exit Function
        End If

        Try
            dsItem = New DataSet("Item")
            strSQL = "SELECT cItem_Name,cItem_SC,nItem_Id FROM tItem WHERE nType_Id=" & CStr(Trim(cboType.SelectedValue)) & " AND nItemActive=1 "
            daItemInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daItemInfo.Fill(dsItem, "Item")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsItem.Tables("Item").Rows.Count
        lvLookUp.Items.Clear()
        If icount > 0 Then
            For iIndex = 0 To icount - 1
                lvLookUp.Items.Add(Trim(dsItem.Tables("Item").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsItem.Tables("Item").Rows(iIndex).Item(1)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsItem.Tables("Item").Rows(iIndex).Item(2)))
            Next
        End If
    End Function

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If bCboLoad = False Then
            txtTypeName.Text = Trim(cboType.Text)
            txtTypeID.Text = Trim(cboType.SelectedValue)
            ShowItemInfoToGrid()
            MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
            SetEnablePropertyFalse(pnlItem)
            ClearTextProperty(pnlItem)
            cboMeasurementUnit.Enabled = False
            cboItemLocation.Enabled = False
            cboMeasurementUnit.SelectedIndex = -1
            cboItemLocation.SelectedIndex = -1
        End If
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        Dim strSQL As String

        Dim icount As Integer 'For count the number of rows in Category Dataset 
        Dim iIndex As Integer

        Dim dsItem As DataSet
        Dim daItem As SqlClient.SqlDataAdapter

        strSQL = "SELECT nItem_Id,cItem_Name,cItem_SC,cItem_Desc,cMeasurUnit,mDinePrice,mTakeawayPrice," & _
                     "cItem_ServeLoc FROM tItem WHERE nItem_Id=" & CStr(Trim(lvLookUp.SelectedItems(0).SubItems(2).Text)) & " AND nItemActive = 1"

        Try
            dsItem = New DataSet("Item")
            daItem = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daItem.Fill(dsItem, "Item")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsItem.Tables("Item").Rows.Count

        If icount > 0 Then
            txtItemId.Text = dsItem.Tables("Item").Rows(0).Item(0)     'To Show Item ID
            txtItemName.Text = dsItem.Tables("Item").Rows(0).Item(1)   'To Show Item Name
            txtItemSC.Text = dsItem.Tables("Item").Rows(0).Item(2)     'To Show Item Short Code
            txtItemDesc.Text = dsItem.Tables("Item").Rows(0).Item(3) & vbNullString                        'To Show Item Description
            cboMeasurementUnit.Text = dsItem.Tables("Item").Rows(0).Item(4) & vbNullString                 'To Show Item Measurement Unit
            txtDineInPrice.Text = FormatCurrency(dsItem.Tables("Item").Rows(0).Item(5)) & vbNullString     'To Show Item DineIn Price
            txtTakeawayPrice.Text = FormatCurrency(dsItem.Tables("Item").Rows(0).Item(6)) & vbNullString   'To Show Item Takeaway Price
            cboItemLocation.Text = dsItem.Tables("Item").Rows(0).Item(7) & vbNullString                    'To Show Item Server Location
        End If
    End Sub

    Private Sub txtTakeawayPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTakeawayPrice.GotFocus
        If Trim(txtTakeawayPrice.Text) <> vbNullString Then
            txtTakeawayPrice.Text = FormatNumber(txtTakeawayPrice.Text)
        End If
    End Sub

    Private Sub txtDineInPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDineInPrice.GotFocus
        If Trim(txtDineInPrice.Text) <> vbNullString Then
            txtDineInPrice.Text = FormatNumber(txtDineInPrice.Text)
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


    
End Class

