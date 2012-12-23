Public Class frmType
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCatagoryID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTypeSC As System.Windows.Forms.TextBox
    Friend WithEvents txtDishTypeID As System.Windows.Forms.TextBox
    Friend WithEvents pnlType As System.Windows.Forms.Panel
    Friend WithEvents txtTypeName As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage2 As System.Windows.Forms.Label
    Friend WithEvents lblMessage1 As System.Windows.Forms.Label
    Friend WithEvents btnSelectCatagory As System.Windows.Forms.Button
    Friend WithEvents btnSelectType As System.Windows.Forms.Button
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cTypeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTypeSC As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTypeId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboCatagory As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCatagoryName As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmType))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.pnlType = New System.Windows.Forms.Panel
        Me.btnSelectType = New System.Windows.Forms.Button
        Me.txtDishTypeID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTypeName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTypeSC = New System.Windows.Forms.TextBox
        Me.lblMessage2 = New System.Windows.Forms.Label
        Me.txtCatagoryID = New System.Windows.Forms.TextBox
        Me.lblMessage1 = New System.Windows.Forms.Label
        Me.btnSelectCatagory = New System.Windows.Forms.Button
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cTypeName = New System.Windows.Forms.ColumnHeader
        Me.cTypeSC = New System.Windows.Forms.ColumnHeader
        Me.cTypeId = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboCatagory = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCatagoryName = New System.Windows.Forms.TextBox
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.Panel1.SuspendLayout()
        Me.pnlType.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnKeyBoard)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Location = New System.Drawing.Point(10, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 72)
        Me.Panel1.TabIndex = 11
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
        Me.btnExit.Location = New System.Drawing.Point(245, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 32)
        Me.btnExit.TabIndex = 15
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
        Me.btnDelete.Location = New System.Drawing.Point(168, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 32)
        Me.btnDelete.TabIndex = 14
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
        Me.btnEdit.Location = New System.Drawing.Point(88, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 32)
        Me.btnEdit.TabIndex = 13
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
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdd.TextColorHover = System.Drawing.Color.White
        Me.btnAdd.TextColorNormal = System.Drawing.Color.White
        '
        'pnlType
        '
        Me.pnlType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlType.Controls.Add(Me.btnSelectType)
        Me.pnlType.Controls.Add(Me.txtDishTypeID)
        Me.pnlType.Controls.Add(Me.Label3)
        Me.pnlType.Controls.Add(Me.txtTypeName)
        Me.pnlType.Controls.Add(Me.Label6)
        Me.pnlType.Controls.Add(Me.Label4)
        Me.pnlType.Controls.Add(Me.txtTypeSC)
        Me.pnlType.Controls.Add(Me.lblMessage2)
        Me.pnlType.Location = New System.Drawing.Point(10, 13)
        Me.pnlType.Name = "pnlType"
        Me.pnlType.Size = New System.Drawing.Size(326, 131)
        Me.pnlType.TabIndex = 3
        '
        'btnSelectType
        '
        Me.btnSelectType.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSelectType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectType.Location = New System.Drawing.Point(256, 11)
        Me.btnSelectType.Name = "btnSelectType"
        Me.btnSelectType.Size = New System.Drawing.Size(48, 20)
        Me.btnSelectType.TabIndex = 9
        Me.btnSelectType.Text = "Select"
        Me.btnSelectType.Visible = False
        '
        'txtDishTypeID
        '
        Me.txtDishTypeID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDishTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDishTypeID.Enabled = False
        Me.txtDishTypeID.Location = New System.Drawing.Point(136, 11)
        Me.txtDishTypeID.MaxLength = 10
        Me.txtDishTypeID.Name = "txtDishTypeID"
        Me.txtDishTypeID.ReadOnly = True
        Me.txtDishTypeID.Size = New System.Drawing.Size(143, 20)
        Me.txtDishTypeID.TabIndex = 8
        Me.txtDishTypeID.Text = ""
        Me.txtDishTypeID.Visible = False
        Me.txtDishTypeID.WordWrap = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dish Type ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'txtTypeName
        '
        Me.txtTypeName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTypeName.Enabled = False
        Me.txtTypeName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeName.Location = New System.Drawing.Point(116, 36)
        Me.txtTypeName.MaxLength = 35
        Me.txtTypeName.Name = "txtTypeName"
        Me.txtTypeName.Size = New System.Drawing.Size(192, 21)
        Me.txtTypeName.TabIndex = 7
        Me.txtTypeName.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Ivory
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Type Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Ivory
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Short Code"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTypeSC
        '
        Me.txtTypeSC.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTypeSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTypeSC.Enabled = False
        Me.txtTypeSC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeSC.Location = New System.Drawing.Point(116, 61)
        Me.txtTypeSC.MaxLength = 15
        Me.txtTypeSC.Name = "txtTypeSC"
        Me.txtTypeSC.Size = New System.Drawing.Size(192, 21)
        Me.txtTypeSC.TabIndex = 9
        Me.txtTypeSC.Text = ""
        '
        'lblMessage2
        '
        Me.lblMessage2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage2.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage2.Location = New System.Drawing.Point(24, 88)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(280, 32)
        Me.lblMessage2.TabIndex = 10
        Me.lblMessage2.Text = "* Please give Type Name"
        Me.lblMessage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage2.Visible = False
        '
        'txtCatagoryID
        '
        Me.txtCatagoryID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCatagoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatagoryID.Location = New System.Drawing.Point(160, -56)
        Me.txtCatagoryID.Name = "txtCatagoryID"
        Me.txtCatagoryID.ReadOnly = True
        Me.txtCatagoryID.Size = New System.Drawing.Size(48, 20)
        Me.txtCatagoryID.TabIndex = 2
        Me.txtCatagoryID.Text = ""
        Me.txtCatagoryID.Visible = False
        '
        'lblMessage1
        '
        Me.lblMessage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage1.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage1.Location = New System.Drawing.Point(155, -24)
        Me.lblMessage1.Name = "lblMessage1"
        Me.lblMessage1.Size = New System.Drawing.Size(173, 24)
        Me.lblMessage1.TabIndex = 5
        Me.lblMessage1.Text = "* Please Select Category Name"
        Me.lblMessage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage1.Visible = False
        '
        'btnSelectCatagory
        '
        Me.btnSelectCatagory.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSelectCatagory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectCatagory.Location = New System.Drawing.Point(210, -56)
        Me.btnSelectCatagory.Name = "btnSelectCatagory"
        Me.btnSelectCatagory.Size = New System.Drawing.Size(48, 37)
        Me.btnSelectCatagory.TabIndex = 3
        Me.btnSelectCatagory.Text = "Select"
        Me.btnSelectCatagory.Visible = False
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
        Me.lvLookUp.Location = New System.Drawing.Point(342, 48)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(300, 176)
        Me.lvLookUp.TabIndex = 2
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cTypeName
        '
        Me.cTypeName.Text = "Type Name"
        Me.cTypeName.Width = 180
        '
        'cTypeSC
        '
        Me.cTypeSC.Text = "ShortCode"
        Me.cTypeSC.Width = 120
        '
        'cTypeId
        '
        Me.cTypeId.Width = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(342, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Select  Category"
        '
        'cboCatagory
        '
        Me.cboCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCatagory.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCatagory.Location = New System.Drawing.Point(468, 13)
        Me.cboCatagory.Name = "cboCatagory"
        Me.cboCatagory.Size = New System.Drawing.Size(174, 23)
        Me.cboCatagory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dish Category"
        '
        'txtCatagoryName
        '
        Me.txtCatagoryName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCatagoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatagoryName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatagoryName.Location = New System.Drawing.Point(128, 25)
        Me.txtCatagoryName.Name = "txtCatagoryName"
        Me.txtCatagoryName.ReadOnly = True
        Me.txtCatagoryName.Size = New System.Drawing.Size(192, 21)
        Me.txtCatagoryName.TabIndex = 5
        Me.txtCatagoryName.Text = ""
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
        Me.btnKeyBoard.Location = New System.Drawing.Point(104, 40)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(118, 32)
        Me.btnKeyBoard.TabIndex = 69
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'frmType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(650, 248)
        Me.Controls.Add(Me.txtCatagoryName)
        Me.Controls.Add(Me.txtCatagoryID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCatagory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.btnSelectCatagory)
        Me.Controls.Add(Me.lblMessage1)
        Me.Controls.Add(Me.pnlType)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dish Type management in a Catagory"
        Me.Panel1.ResumeLayout(False)
        Me.pnlType.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function FillCatagoryCombo()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsCategory As DataSet
        Dim daCategoryInfo As SqlClient.SqlDataAdapter

        Try
            dsCategory = New DataSet("Category")
            strSQL = "SELECT cCtgry_Name,nCtgry_Id FROM tCategory WHERE nCtgyActive =1 ORDER By nCtgry_Id"
            daCategoryInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCategoryInfo.Fill(dsCategory, "Category")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsCategory.Tables("Category").Rows.Count

        If icount > 0 Then
            With cboCatagory
                .DataSource = dsCategory.Tables("Category")
                .DisplayMember = "cCtgry_Name"
                .ValueMember = "nCtgry_Id"
                .SelectedIndex = -1
            End With
        End If
    End Function

    Private Sub frmType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 4

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Dish Type management in a Catagory"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Dish Type management in a Catagory"
        End If

        SetEnablePropertyFalse(pnlType)
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        bCboLoad = True
        FillCatagoryCombo()
        bCboLoad = False
        If mdConfiguration.iMenuLevel = 2 Then
            Label1.Visible = False
            txtCatagoryName.Visible = False
            Label2.Visible = False
            cboCatagory.Visible = False
            lvLookUp.Top = 10
            lvLookUp.Width = 195
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim strSQLGenerateID As String
        Dim strSQLInsert As String
        Dim strSQLUpdate As String

        Dim cmdInsert As SqlClient.SqlCommand

        If btnAdd.Text = "Add" Then
            lblMessage2.Visible = False
            ClearTextProperty(pnlType)
            SetEnablePropertyTrue(pnlType)
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
            txtTypeName.Focus()
        ElseIf btnAdd.Text = "Save" Then

            If CheckEmptyTypeInfo() = False Then
                If mdConfiguration.iMenuLevel = 3 Then
                    If Trim(txtCatagoryID.Text) = vbNullString Then
                        lblMessage1.Visible = True
                        btnSelectCatagory.Focus()
                        Exit Sub
                    Else
                        strSQLInsert = "INSERT INTO tType(cType_Name,cType_SC,nTypeActive,nCtgry_Id," & _
                                       "cUserId,cTerminal,dAccessTime)" & _
                                       " VALUES('" + Replace(Trim(txtTypeName.Text), "'", "''") + "','" + Replace(Trim(txtTypeSC.Text), "'", "''") + _
                                       "',1," + CStr(txtCatagoryID.Text) + ",'" + user + "','" + sTerminal + "',GETDATE())"
                    End If

                ElseIf mdConfiguration.iMenuLevel = 2 Then

                    strSQLInsert = "INSERT INTO tType(cType_Name,cType_SC,nTypeActive,nCtgry_Id," & _
                                   "cUserId,cTerminal,dAccessTime)" & _
                                   " VALUES('" + Replace(Trim(txtTypeName.Text), "'", "''") + "','" + Replace(Trim(txtTypeSC.Text), "'", "''") + _
                                   "',1,1,'" + user + "','" + sTerminal + "',GETDATE())"
                End If

                strSQLUpdate = "UPDATE tType SET cType_Name='" + txtTypeName.Text + "',cType_SC='" + txtTypeSC.Text + "',cUserId='" + user + "',cTerminal='" + sTerminal + "',dAccessTime=GETDATE() WHERE nType_Id=" + CStr(txtDishTypeID.Text) + ""

                Try
                    cmdInsert = New SqlClient.SqlCommand
                    cmdInsert.Connection = mdDBConnection.connRestuarant

                    If Trim(txtDishTypeID.Text) <> vbNullString Then
                        cmdInsert.CommandText = strSQLUpdate
                    Else
                        cmdInsert.CommandText = strSQLInsert
                    End If
                    cmdInsert.ExecuteNonQuery()
                    ClearTextProperty(pnlType)
                    ShowTypeInfoToGrid()
                    lblMessage2.Visible = True
                    lblMessage2.ForeColor = Color.Green
                    lblMessage2.Text = "Your Information has been Saved Successfully."
                    MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                    SetEnablePropertyFalse(pnlType)
                Catch ex As Exception
                    MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                End Try
            End If
        End If
    End Sub

    Private Function CheckEmptyTypeInfo() As Boolean
        Dim bComtrolTextEmpty As Boolean

        If Trim(txtTypeName.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please give Type Name"
            bComtrolTextEmpty = True
        ElseIf Trim(txtTypeSC.Text) = vbNullString Then
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please give Type Short Code"
            bComtrolTextEmpty = True
        Else
            bComtrolTextEmpty = False
            lblMessage2.Visible = False
        End If
        CheckEmptyTypeInfo = bComtrolTextEmpty
    End Function

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Trim(txtDishTypeID.Text) <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                lblMessage2.Visible = False
                SetEnablePropertyTrue(Me)
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
                SetEnablePropertyTrue(pnlType)
                txtTypeName.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlType)   'To Clear All the information from Text Box
                SetEnablePropertyFalse(pnlType)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblMessage2.Visible = False
            End If
        Else
            If btnEdit.Text = "Edit" Then
                lblMessage2.Visible = True
                lblMessage2.ForeColor = Color.Maroon
                lblMessage2.Text = "* Please select a Type"
                lvLookUp.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlType)   'To Clear All the information from Text Box
                SetEnablePropertyFalse(pnlType)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblMessage2.Visible = False
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub txtTypeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTypeName.TextChanged
        lblMessage2.Visible = False
    End Sub

    Private Sub txtDishTypeID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDishTypeID.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtTypeName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTypeName.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtTypeSC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTypeSC.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblMessage2.Visible = False
        FillDataSetForUpDate()
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlType)
        ClearTextProperty(pnlType)
        ShowTypeInfoToGrid()
    End Sub

    Private Function FillDataSetForUpDate()
        Dim strTmpId As String
        Dim strSQLType As String
        Dim strSQLItem As String
        Dim strSQLInstruction As String
        Dim strMessage As String = "Your Information has been Deleted Successfully"

        Dim iIndex As Integer
        Dim iCountItem As Integer

        Dim daType As SqlClient.SqlDataAdapter
        Dim dsType As DataSet

        Dim daItem As SqlClient.SqlDataAdapter
        Dim dsItem As DataSet

        Dim daInstruction As SqlClient.SqlDataAdapter
        Dim dsInstruction As DataSet



        If Trim(txtDishTypeID.Text) <> vbNullString Then
            strSQLType = "SELECT nType_Id,nTypeActive FROM tType WHERE nType_Id=" & CStr(Trim(txtDishTypeID.Text)) & ""

            Try
                dsType = New DataSet("Type")
                daType = New SqlClient.SqlDataAdapter(strSQLType, mdDBConnection.connRestuarant)
                daType.Fill(dsType, "Type")


                strSQLItem = "SELECT nItem_Id,nItemActive FROM tItem WHERE nType_Id=" & CStr(Trim(txtDishTypeID.Text)) & ""

                dsItem = New DataSet("Item")
                daItem = New SqlClient.SqlDataAdapter(strSQLItem, mdDBConnection.connRestuarant)
                daItem.Fill(dsItem, "Item")


                iCountItem = dsItem.Tables("Item").Rows.Count

                If iCountItem > 0 Then
                    For iIndex = 0 To iCountItem - 1
                        If Trim(strTmpId) = vbNullString Then
                            strTmpId = "nItem_Id=" & CStr(dsItem.Tables("Item").Rows(iIndex).Item(0))
                        Else
                            strTmpId += " OR nItem_Id=" & CStr(dsItem.Tables("Item").Rows(iIndex).Item(0))
                        End If
                    Next

                    strSQLInstruction = "SELECT nInstruction_Id,nActiveInstruction FROM tInstruction WHERE " & strTmpId & ""

                    dsInstruction = New DataSet("Instruction")
                    daInstruction = New SqlClient.SqlDataAdapter(strSQLInstruction, mdDBConnection.connRestuarant)
                    daInstruction.Fill(dsInstruction, "Instruction")
                End If
                UpdateDataSet(dsType, dsItem, dsInstruction)
                UpdateDataBaseWithDataSet(daType, dsType, daItem, dsItem, iCountItem, daInstruction, dsInstruction)
                lblMessage2.Visible = True
                lblMessage2.ForeColor = Color.Green
                lblMessage2.Text = "Your Information has been Deleted Successfully."
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Function

    Private Function UpdateDataSet(ByVal tmpTypeDataSet As DataSet, ByVal tmpItemDataSet As DataSet, _
                                   ByVal tmpInstructionDataSet As DataSet)

        Dim iIndex As Integer

        Dim iCountItem As Integer
        Dim iCountInstruction As Integer

        tmpTypeDataSet.Tables("Type").Rows(0)("nTypeActive") = 0

        iCountItem = tmpItemDataSet.Tables("Item").Rows.Count
        If iCountItem > 0 Then
            For iIndex = 0 To iCountItem - 1
                tmpItemDataSet.Tables("Item").Rows(iIndex)("nItemActive") = 0
            Next

            iCountInstruction = tmpInstructionDataSet.Tables("Instruction").Rows.Count

            If iCountInstruction > 0 Then
                For iIndex = 0 To iCountInstruction - 1
                    tmpInstructionDataSet.Tables("Instruction").Rows(iIndex)("nActiveInstruction") = 0
                Next
            End If
        End If
    End Function

    Private Function UpdateDataBaseWithDataSet(ByVal tmpDAType As SqlClient.SqlDataAdapter, ByVal tmpDSType As DataSet, _
                                               ByVal tmpDAItem As SqlClient.SqlDataAdapter, ByVal tmpDSItem As DataSet, _
                                               ByVal tmpItemCount As Integer, ByVal tmpDAInstruction As SqlClient.SqlDataAdapter, _
                                               ByVal tmpDSInstruction As DataSet)

        Dim myDataRowsComBuilderType As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(tmpDAType)
        Dim myDataRowsComBuilderItem As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(tmpDAItem)
        Dim myDataRowsComBuilderInst As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(tmpDAInstruction)

        tmpDAType.Update(tmpDSType, "Type")
        tmpDAItem.Update(tmpDSItem, "Item")
        If tmpItemCount > 0 Then
            tmpDAInstruction.Update(tmpDSInstruction, "Instruction")
        End If
    End Function

    Private Sub Button_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdd.KeyPress, btnEdit.KeyPress, btnDelete.KeyPress, btnExit.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtTypeSC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTypeSC.TextChanged
        lblMessage2.Visible = False
    End Sub

    Private Function ShowTypeInfoToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsCategory As DataSet
        Dim daCategoryInfo As SqlClient.SqlDataAdapter

        If cboCatagory.SelectedIndex = -1 Then
            Exit Function
        End If

        Try
            dsCategory = New DataSet("Type")
            strSQL = "SELECT cType_Name,cType_SC,nType_Id FROM tType WHERE nCtgry_Id=" & CStr(Trim(cboCatagory.SelectedValue)) & " AND nTypeActive=1 "
            daCategoryInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCategoryInfo.Fill(dsCategory, "Category")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsCategory.Tables("Category").Rows.Count
        lvLookUp.Items.Clear()
        If icount > 0 Then
            For iIndex = 0 To icount - 1
                lvLookUp.Items.Add(Trim(dsCategory.Tables("Category").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsCategory.Tables("Category").Rows(iIndex).Item(1)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsCategory.Tables("Category").Rows(iIndex).Item(2)))
            Next
        End If
    End Function

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        txtCatagoryName.Text = cboCatagory.Text
        txtTypeName.Text = Trim(lvLookUp.SelectedItems(0).Text)
        txtTypeSC.Text = Trim(lvLookUp.SelectedItems(0).SubItems(1).Text)
        txtDishTypeID.Text = Trim(lvLookUp.SelectedItems(0).SubItems(2).Text)
    End Sub

    Private Sub cboCatagory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCatagory.SelectedIndexChanged
        If bCboLoad = False Then
            txtCatagoryName.Text = Trim(cboCatagory.Text)
            txtCatagoryID.Text = Trim(cboCatagory.SelectedValue)
            ShowTypeInfoToGrid()
            MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
            SetEnablePropertyFalse(pnlType)
            ClearTextProperty(pnlType)
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
