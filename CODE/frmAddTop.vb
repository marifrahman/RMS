Public Class frmAddTop
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTypeID As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeName As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage1 As System.Windows.Forms.Label
    Friend WithEvents btnSelectType As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTopPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTopping As System.Windows.Forms.TextBox
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents pnlItem As System.Windows.Forms.Panel
    Friend WithEvents txtTopId As System.Windows.Forms.TextBox
    Friend WithEvents cTypeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTypeSC As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTypeId As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlCatagorybtn As System.Windows.Forms.Panel
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMessage2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAddTop))
        Me.txtTypeID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTypeName = New System.Windows.Forms.TextBox
        Me.lblMessage1 = New System.Windows.Forms.Label
        Me.btnSelectType = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cTypeName = New System.Windows.Forms.ColumnHeader
        Me.cTypeSC = New System.Windows.Forms.ColumnHeader
        Me.cTypeId = New System.Windows.Forms.ColumnHeader
        Me.pnlCatagorybtn = New System.Windows.Forms.Panel
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.pnlItem = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblMessage2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTopPrice = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTopping = New System.Windows.Forms.TextBox
        Me.txtTopId = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.pnlCatagorybtn.SuspendLayout()
        Me.pnlItem.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label3.Size = New System.Drawing.Size(72, 61)
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
        Me.lblMessage1.Size = New System.Drawing.Size(175, 54)
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
        Me.btnSelectType.Size = New System.Drawing.Size(48, 58)
        Me.btnSelectType.TabIndex = 2
        Me.btnSelectType.Text = "Select"
        Me.btnSelectType.Visible = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(368, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Select  Type"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.Location = New System.Drawing.Point(464, 24)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(176, 23)
        Me.cboType.TabIndex = 23
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
        Me.lvLookUp.Location = New System.Drawing.Point(368, 56)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(272, 264)
        Me.lvLookUp.TabIndex = 22
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cTypeName
        '
        Me.cTypeName.Text = "Type Name"
        Me.cTypeName.Width = 139
        '
        'cTypeSC
        '
        Me.cTypeSC.Text = "Type Price"
        Me.cTypeSC.Width = 130
        '
        'cTypeId
        '
        Me.cTypeId.Width = 0
        '
        'pnlCatagorybtn
        '
        Me.pnlCatagorybtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCatagorybtn.Controls.Add(Me.btnKeyBoard)
        Me.pnlCatagorybtn.Controls.Add(Me.btnExit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnDelete)
        Me.pnlCatagorybtn.Controls.Add(Me.btnEdit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnAdd)
        Me.pnlCatagorybtn.Location = New System.Drawing.Point(16, 248)
        Me.pnlCatagorybtn.Name = "pnlCatagorybtn"
        Me.pnlCatagorybtn.Size = New System.Drawing.Size(344, 72)
        Me.pnlCatagorybtn.TabIndex = 21
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
        Me.btnKeyBoard.Location = New System.Drawing.Point(108, 40)
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
        Me.btnExit.Location = New System.Drawing.Point(254, 8)
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
        Me.btnDelete.Location = New System.Drawing.Point(174, 8)
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
        Me.btnEdit.Location = New System.Drawing.Point(94, 8)
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
        'pnlItem
        '
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Controls.Add(Me.Button1)
        Me.pnlItem.Controls.Add(Me.lblMessage2)
        Me.pnlItem.Controls.Add(Me.Label4)
        Me.pnlItem.Controls.Add(Me.TextBox1)
        Me.pnlItem.Controls.Add(Me.Label5)
        Me.pnlItem.Controls.Add(Me.txtTopPrice)
        Me.pnlItem.Controls.Add(Me.ComboBox1)
        Me.pnlItem.Controls.Add(Me.Label9)
        Me.pnlItem.Controls.Add(Me.txtTopping)
        Me.pnlItem.Controls.Add(Me.txtTopId)
        Me.pnlItem.Controls.Add(Me.Label10)
        Me.pnlItem.Location = New System.Drawing.Point(16, 32)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(344, 201)
        Me.pnlItem.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(424, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 20)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Select"
        Me.Button1.Visible = False
        '
        'lblMessage2
        '
        Me.lblMessage2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage2.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage2.Location = New System.Drawing.Point(16, 152)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(304, 31)
        Me.lblMessage2.TabIndex = 19
        Me.lblMessage2.Text = "* Please give Item Name"
        Me.lblMessage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage2.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Type Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(384, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = ""
        Me.TextBox1.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-160, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Item ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'txtTopPrice
        '
        Me.txtTopPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTopPrice.Enabled = False
        Me.txtTopPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopPrice.Location = New System.Drawing.Point(136, 104)
        Me.txtTopPrice.MaxLength = 20
        Me.txtTopPrice.Name = "txtTopPrice"
        Me.txtTopPrice.Size = New System.Drawing.Size(144, 21)
        Me.txtTopPrice.TabIndex = 6
        Me.txtTopPrice.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"DP", "TC", "SC"})
        Me.ComboBox1.Location = New System.Drawing.Point(264, 240)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 23)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Type Name"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTopping
        '
        Me.txtTopping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTopping.Enabled = False
        Me.txtTopping.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopping.Location = New System.Drawing.Point(136, 64)
        Me.txtTopping.MaxLength = 20
        Me.txtTopping.Name = "txtTopping"
        Me.txtTopping.Size = New System.Drawing.Size(170, 21)
        Me.txtTopping.TabIndex = 6
        Me.txtTopping.Text = ""
        '
        'txtTopId
        '
        Me.txtTopId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTopId.Enabled = False
        Me.txtTopId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopId.Location = New System.Drawing.Point(136, 64)
        Me.txtTopId.MaxLength = 15
        Me.txtTopId.Name = "txtTopId"
        Me.txtTopId.Size = New System.Drawing.Size(112, 21)
        Me.txtTopId.TabIndex = 10
        Me.txtTopId.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(248, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Thickness Type"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'frmAddTop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(650, 327)
        Me.Controls.Add(Me.btnSelectType)
        Me.Controls.Add(Me.lblMessage1)
        Me.Controls.Add(Me.txtTypeName)
        Me.Controls.Add(Me.txtTypeID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.pnlItem)
        Me.Controls.Add(Me.pnlCatagorybtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddTop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Toping"
        Me.pnlCatagorybtn.ResumeLayout(False)
        Me.pnlItem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 2
        Me.Top = 30
        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Add Topping Management"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Add Topping Management"
        End If

        bCboLoad = True
        'FillToppingCombo()
        ShowToppingInfoToGrid()
        FillTypeCombo()
        bCboLoad = False
        'MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        'SetEnablePropertyFalse(pnlItem)
        'cboMeasurementUnit.Enabled = False
        'cboItemLocation.Enabled = False
    End Sub

    Private Function FillTypeCombo()

        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsCategory As DataSet
        Dim daCategoryInfo As SqlClient.SqlDataAdapter

        Try
            dsCategory = New DataSet("Type")
            strSQL = "SELECT cItem_Name,nItem_Id FROM tItem WHERE  nItemActive=1"
            daCategoryInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCategoryInfo.Fill(dsCategory, "Type")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsCategory.Tables("Type").Rows.Count

        If icount > 0 Then
            With cboType
                .DataSource = dsCategory.Tables("Type")
                .DisplayMember = "cItem_Name"
                .ValueMember = "nItem_Id"
                .SelectedIndex = -1
            End With
        End If

    End Function

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If bCboLoad = False Then
            txtTypeName.Text = Trim(cboType.Text)
            txtTypeID.Text = Trim(cboType.SelectedValue)
            ShowToppingInfoToGrid()
            MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
            SetEnablePropertyFalse(pnlItem)
            ClearTextProperty(pnlItem)
            ' cboMeasurementUnit.Enabled = False
            ' cboItemLocation.Enabled = False
            'cboMeasurementUnit.SelectedIndex = -1
            'cboItemLocation.SelectedIndex = -1
        End If
    End Sub

    Private Function CheckEmptyItemInfo() As Boolean

        Dim bComtrolTextEmpty As Boolean

        If Trim(txtTopping.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please Put Type Name"
            txtTopping.Focus()
            bComtrolTextEmpty = True
        ElseIf Trim(txtTopPrice.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please Put Type Price"
            txtTopPrice.Focus()
            bComtrolTextEmpty = True

        Else
            lblMessage2.Visible = False
            bComtrolTextEmpty = False
        End If
        CheckEmptyItemInfo = bComtrolTextEmpty
    End Function

    Private Function FillDataSetForUpDate()

        Dim strMessage As String = "Your Information has been Deleted Successfully"
        Dim strSQLUpdate As String
        Dim cmdUpdate As SqlClient.SqlCommand

        If Trim(txtTopId.Text) <> vbNullString Then



            strSQLUpdate = "UPDATE tTopping SET nActiveTop= 0 where nTop_Id=" & CStr(Trim(txtTopId.Text)) & " "
            cmdUpdate = New SqlClient.SqlCommand
            cmdUpdate.Connection = mdDBConnection.connRestuarant
            Try
                cmdUpdate.CommandText = strSQLUpdate
                cmdUpdate.ExecuteNonQuery()
                ClearTextProperty(pnlItem)
                lblMessage2.Visible = True
                lblMessage2.ForeColor = Color.Green
                lblMessage2.Text = "Your Information has been Deleted Successfully."

            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Function

    Private Function ShowToppingInfoToGrid()

        Dim icount As Integer
        Dim iIndex As Integer
        Dim strSQL As String
        Dim dsTopping As DataSet
        Dim daToppingInfo As SqlClient.SqlDataAdapter

        If cboType.SelectedIndex = -1 Then
            Exit Function
        End If


        Try
            dsTopping = New DataSet("Item")
            strSQL = "SELECT cTop_Name,cTop_Price,nTop_Id FROM tTopping WHERE tTopType_Id = " & CStr(Trim(cboType.SelectedValue)) & " AND nActiveTop=1 "
            daToppingInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daToppingInfo.Fill(dsTopping, "Item")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsTopping.Tables("Item").Rows.Count
        lvLookUp.Items.Clear()

        If icount > 0 Then
            For iIndex = 0 To icount - 1
                lvLookUp.Items.Add(Trim(dsTopping.Tables("Item").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsTopping.Tables("Item").Rows(iIndex).Item(1)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsTopping.Tables("Item").Rows(iIndex).Item(2)))
            Next
        End If

    End Function

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim strSQLGenerateID As String
        Dim strSQLInsert As String
        Dim strSQLUpdate As String
        Dim cmdInsert As SqlClient.SqlCommand
        Dim dTopPrice As Double

        If btnAdd.Text = "Add" Then
            lblMessage2.Visible = False
            ClearTextProperty(pnlItem)
            SetEnablePropertyTrue(pnlItem)
            'cboMeasurementUnit.Enabled = True
            ' cboItemLocation.Enabled = True
            'cboMeasurementUnit.SelectedIndex = -1
            ' cboItemLocation.SelectedIndex = -1
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
        ElseIf btnAdd.Text = "Save" Then
            If CheckEmptyItemInfo() = False Then

                dTopPrice = FormatNumber(Trim(txtTopPrice.Text))


                strSQLInsert = "INSERT INTO tTopping(cTop_Name,cTop_Price,nActiveTop,tTopType_Id) VALUES( '" & Replace(Trim(txtTopping.Text), "'", "''") & "'," & CStr(dTopPrice) & ",1," & CStr(Trim(txtTypeID.Text)) & ")"

                strSQLUpdate = "UPDATE tTopping SET cTop_Name='" & Trim(txtTopping.Text) & "',cTop_Price = " & CStr(dTopPrice) & ",tTopType_Id=" & CStr(Trim(txtTypeID.Text)) & " WHERE nTop_Id= " & Trim(txtTopId.Text) & " and nActiveTop= 1"



                Try
                    cmdInsert = New SqlClient.SqlCommand
                    cmdInsert.Connection = mdDBConnection.connRestuarant
                    If Trim(txtTopId.Text) <> vbNullString Then
                        cmdInsert.CommandText = strSQLUpdate
                    Else
                        cmdInsert.CommandText = strSQLInsert
                    End If
                    cmdInsert.ExecuteNonQuery()
                    ClearTextProperty(pnlItem)
                    'cboItemLocation.SelectedIndex = -1
                    'cboMeasurementUnit.SelectedIndex = -1
                    SetEnablePropertyFalse(pnlItem)
                    'cboItemLocation.Enabled = False
                    'cboMeasurementUnit.Enabled = False
                    lblMessage2.Visible = True
                    lblMessage2.ForeColor = Color.Green
                    lblMessage2.Text = "Your Information has been Saved Successfully."
                    MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                    ShowToppingInfoToGrid()

                Catch ex As Exception
                    MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                End Try
            End If
        End If

    End Sub

    Private Sub btnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If Trim(txtTopId.Text) <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                lblMessage2.Visible = False
                SetEnablePropertyTrue(Me)
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
                SetEnablePropertyTrue(pnlItem)
                'cboMeasurementUnit.Enabled = True
                'cboItemLocation.Enabled = True
                txtTopping.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlItem)   'To Clear All the information from Text Box
                SetEnablePropertyFalse(pnlItem)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                'cboMeasurementUnit.Enabled = False
                'cboItemLocation.Enabled = False
                lblMessage2.Visible = False
                'cboMeasurementUnit.SelectedIndex = -1
                ' cboItemLocation.SelectedIndex = -1
            End If
        Else
            If btnEdit.Text = "Edit" Then
                lblMessage2.Visible = True
                lblMessage2.ForeColor = Color.Maroon
                lblMessage2.Text = "* Please Pick an Toppi"
                lvLookUp.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlItem)   'To Clear All the information from Text Box
                SetEnablePropertyFalse(pnlItem)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                'cboMeasurementUnit.Enabled = False
                'cboItemLocation.Enabled = False
                lblMessage2.Visible = False
                'cboMeasurementUnit.SelectedIndex = -1
                'cboItemLocation.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        lblMessage2.Visible = False
        FillDataSetForUpDate()
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlItem)
        'cboMeasurementUnit.Enabled = False
        'cboItemLocation.Enabled = False
        ClearTextProperty(pnlItem)
        'cboMeasurementUnit.SelectedIndex = -1
        ' cboItemLocation.SelectedIndex = -1
        ShowToppingInfoToGrid()

    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub lvLookUp_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click

        Dim strSQL As String

        Dim icount As Integer 'For count the number of rows in Category Dataset 
        Dim iIndex As Integer

        Dim dsItemN As DataSet
        Dim daItem As SqlClient.SqlDataAdapter

        strSQL = "SELECT nTop_Id,cTop_Name,cTop_Price FROM tTopping WHERE nTop_Id=" & CStr(Trim(lvLookUp.SelectedItems(0).SubItems(2).Text)) & " AND nActiveTop = 1"

        Try
            dsItemN = New DataSet("Itemmm")
            daItem = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daItem.Fill(dsItemN, "Itemmm")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsItemN.Tables("Itemmm").Rows.Count

        If icount > 0 Then

            txtTopId.Text = dsItemN.Tables("Itemmm").Rows(0).Item(0)
            txtTopping.Text = dsItemN.Tables("Itemmm").Rows(0).Item(1)   'To Show Type Name
            txtTopPrice.Text = FormatCurrency(dsItemN.Tables("Itemmm").Rows(0).Item(2)) & vbNullString 'To Show Type Price

        End If

    End Sub

    Private Sub btnKeyBoard_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyBoard.Click

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

