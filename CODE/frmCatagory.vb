Public Class frmCatagory

    '-------------------------------------------------------------------
    ' Purpose          : To Add, Update, Delete Category Information. 
    ' Author           : Md.Monjur Morshed Jami(Under the supervision of Md. Arifur Rahman)
    ' Used Tables      : tCategory
    ' Used View        :
    ' Used SP          :
    ' Created on       : 05-MAR-2006
    ' Last Modification: 30-July-2006   
    '-------------------------------------------------------------------  

    Inherits System.Windows.Forms.Form

    Dim conControlName As Control
    'Dim objfrmKeyBoard As New frmKeyBoard

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlCatagory As System.Windows.Forms.Panel
    Friend WithEvents pnlCatagorybtn As System.Windows.Forms.Panel
    Friend WithEvents txtCatagoryID As System.Windows.Forms.TextBox
    Friend WithEvents txtCatagorySC As System.Windows.Forms.TextBox
    Friend WithEvents txtCatagoryName As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage1 As System.Windows.Forms.Label
    Friend WithEvents btnSelectCatagory As System.Windows.Forms.Button
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cCatagoryName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCatagorySC As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCatagoryId As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCatagory))
        Me.pnlCatagory = New System.Windows.Forms.Panel
        Me.txtCatagoryName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSelectCatagory = New System.Windows.Forms.Button
        Me.lblMessage1 = New System.Windows.Forms.Label
        Me.txtCatagoryID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCatagorySC = New System.Windows.Forms.TextBox
        Me.pnlCatagorybtn = New System.Windows.Forms.Panel
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cCatagoryName = New System.Windows.Forms.ColumnHeader
        Me.cCatagorySC = New System.Windows.Forms.ColumnHeader
        Me.cCatagoryId = New System.Windows.Forms.ColumnHeader
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.pnlCatagory.SuspendLayout()
        Me.pnlCatagorybtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCatagory
        '
        Me.pnlCatagory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCatagory.Controls.Add(Me.txtCatagoryName)
        Me.pnlCatagory.Controls.Add(Me.Label3)
        Me.pnlCatagory.Controls.Add(Me.btnSelectCatagory)
        Me.pnlCatagory.Controls.Add(Me.lblMessage1)
        Me.pnlCatagory.Controls.Add(Me.txtCatagoryID)
        Me.pnlCatagory.Controls.Add(Me.Label4)
        Me.pnlCatagory.Controls.Add(Me.txtCatagorySC)
        Me.pnlCatagory.Location = New System.Drawing.Point(8, 16)
        Me.pnlCatagory.Name = "pnlCatagory"
        Me.pnlCatagory.Size = New System.Drawing.Size(328, 120)
        Me.pnlCatagory.TabIndex = 0
        '
        'txtCatagoryName
        '
        Me.txtCatagoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatagoryName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatagoryName.Location = New System.Drawing.Point(120, 21)
        Me.txtCatagoryName.MaxLength = 50
        Me.txtCatagoryName.Name = "txtCatagoryName"
        Me.txtCatagoryName.Size = New System.Drawing.Size(192, 21)
        Me.txtCatagoryName.TabIndex = 5
        Me.txtCatagoryName.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Catagory Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSelectCatagory
        '
        Me.btnSelectCatagory.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSelectCatagory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectCatagory.Location = New System.Drawing.Point(264, 21)
        Me.btnSelectCatagory.Name = "btnSelectCatagory"
        Me.btnSelectCatagory.Size = New System.Drawing.Size(46, 20)
        Me.btnSelectCatagory.TabIndex = 3
        Me.btnSelectCatagory.Text = "Select"
        Me.btnSelectCatagory.Visible = False
        '
        'lblMessage1
        '
        Me.lblMessage1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage1.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage1.Location = New System.Drawing.Point(40, 85)
        Me.lblMessage1.Name = "lblMessage1"
        Me.lblMessage1.Size = New System.Drawing.Size(264, 24)
        Me.lblMessage1.TabIndex = 8
        Me.lblMessage1.Text = "* Please give Category Name"
        Me.lblMessage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage1.Visible = False
        '
        'txtCatagoryID
        '
        Me.txtCatagoryID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCatagoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatagoryID.Location = New System.Drawing.Point(144, -32)
        Me.txtCatagoryID.Name = "txtCatagoryID"
        Me.txtCatagoryID.ReadOnly = True
        Me.txtCatagoryID.Size = New System.Drawing.Size(143, 25)
        Me.txtCatagoryID.TabIndex = 2
        Me.txtCatagoryID.Text = ""
        Me.txtCatagoryID.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Short Code"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCatagorySC
        '
        Me.txtCatagorySC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatagorySC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatagorySC.Location = New System.Drawing.Point(120, 53)
        Me.txtCatagorySC.MaxLength = 20
        Me.txtCatagorySC.Name = "txtCatagorySC"
        Me.txtCatagorySC.Size = New System.Drawing.Size(192, 21)
        Me.txtCatagorySC.TabIndex = 7
        Me.txtCatagorySC.Text = ""
        '
        'pnlCatagorybtn
        '
        Me.pnlCatagorybtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCatagorybtn.Controls.Add(Me.btnKeyBoard)
        Me.pnlCatagorybtn.Controls.Add(Me.btnExit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnDelete)
        Me.pnlCatagorybtn.Controls.Add(Me.btnEdit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnAdd)
        Me.pnlCatagorybtn.Location = New System.Drawing.Point(8, 148)
        Me.pnlCatagorybtn.Name = "pnlCatagorybtn"
        Me.pnlCatagorybtn.Size = New System.Drawing.Size(328, 84)
        Me.pnlCatagorybtn.TabIndex = 9
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
        Me.btnExit.Location = New System.Drawing.Point(246, 16)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 32)
        Me.btnExit.TabIndex = 9
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
        Me.btnDelete.Location = New System.Drawing.Point(166, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 32)
        Me.btnDelete.TabIndex = 8
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
        Me.btnEdit.Location = New System.Drawing.Point(86, 16)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 32)
        Me.btnEdit.TabIndex = 7
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
        Me.btnAdd.Location = New System.Drawing.Point(9, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 32)
        Me.btnAdd.TabIndex = 6
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
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cCatagoryName, Me.cCatagorySC, Me.cCatagoryId})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(352, 16)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(300, 196)
        Me.lvLookUp.TabIndex = 10
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cCatagoryName
        '
        Me.cCatagoryName.Text = "Catagory Name"
        Me.cCatagoryName.Width = 180
        '
        'cCatagorySC
        '
        Me.cCatagorySC.Text = "ShortCode"
        Me.cCatagorySC.Width = 120
        '
        'cCatagoryId
        '
        Me.cCatagoryId.Width = 0
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
        Me.btnKeyBoard.Location = New System.Drawing.Point(96, 48)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(118, 32)
        Me.btnKeyBoard.TabIndex = 68
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'frmCatagory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 18)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 248)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.pnlCatagorybtn)
        Me.Controls.Add(Me.pnlCatagory)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCatagory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Dish Catagories"
        Me.pnlCatagory.ResumeLayout(False)
        Me.pnlCatagorybtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim strSQLInsert As String
        Dim strSQLUpdate As String
        Dim cmdInsert As SqlClient.SqlCommand

        If btnAdd.Text = "Add" Then
            lblMessage1.Visible = False
            ClearTextProperty(pnlCatagory)
            SetEnablePropertyTrue(pnlCatagory)
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
        ElseIf btnAdd.Text = "Save" Then

            If CheckEmptyCategoryInfo() Then
                Exit Sub
            End If


            strSQLInsert = "INSERT INTO tCategory(cCtgry_Name, cCtgry_SC, nCtgyActive, cUserId,cTerminal,dAccessTime	)" & _
                            " VALUES('" & Replace(Trim(txtCatagoryName.Text), "'", "''") & "','" & Replace(Trim(txtCatagorySC.Text), "'", "''") & _
                            "',1,'" & user & "','" & sTerminal & "',GETDATE())"

            strSQLUpdate = "UPDATE tCategory SET cCtgry_Name='" & Replace(Trim(txtCatagoryName.Text), "'", "''") & _
                           "',cCtgry_SC='" & Replace(Trim(txtCatagorySC.Text), "'", "''") & "',cUserId='" & user & _
                           "',cTerminal='" & sTerminal & "',dAccessTime=GETDATE() WHERE nCtgry_Id= " & CStr(Trim(txtCatagoryID.Text)) & ""

            Try
                cmdInsert = New SqlClient.SqlCommand
                cmdInsert.Connection = mdDBConnection.connRestuarant
                If Trim(txtCatagoryID.Text) <> vbNullString Then
                    cmdInsert.CommandText = strSQLUpdate
                Else
                    cmdInsert.CommandText = strSQLInsert
                End If
                cmdInsert.ExecuteNonQuery()
                ClearTextProperty(pnlCatagory)
                ShowCatagoryIntoToGrid()
                lblMessage1.Visible = True
                lblMessage1.ForeColor = Color.Green
                lblMessage1.Text = "Your Information has been Saved Successfully."
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                SetEnablePropertyFalse(pnlCatagory)
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtCatagoryID.Text <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                lblMessage1.Visible = False
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
                SetEnablePropertyTrue(pnlCatagory)
                txtCatagoryName.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlCatagory)
                SetEnablePropertyFalse(pnlCatagory)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblMessage1.Visible = False
            End If
        Else
            If btnEdit.Text = "Edit" Then
                lblMessage1.Visible = True
                lblMessage1.ForeColor = Color.Maroon
                lblMessage1.Text = "* Please select a Category"
                lvLookUp.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlCatagory)
                SetEnablePropertyFalse(pnlCatagory)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblMessage1.Visible = False
            End If
        End If
    End Sub

    Private Function CheckEmptyCategoryInfo() As Boolean
        Dim bComtrolTextEmpty As Boolean
        If txtCatagoryName.Text = vbNullString Then
            lblMessage1.ForeColor = Color.Maroon
            lblMessage1.Text = "* Please give Category Name"
            lblMessage1.Visible = True
            bComtrolTextEmpty = True
        Else
            bComtrolTextEmpty = False
            lblMessage1.Visible = False
        End If
        CheckEmptyCategoryInfo = bComtrolTextEmpty
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Function ShowCatagoryIntoToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsCategory As DataSet
        Dim daCategoryInfo As SqlClient.SqlDataAdapter

        Try
            dsCategory = New DataSet("Category")
            strSQL = "SELECT cCtgry_Name,cCtgry_SC,nCtgry_Id FROM tCategory WHERE nCtgyActive =1 ORDER By nCtgry_Id"
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

    Private Sub frmCatagory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Manage Dish Catagories"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Manage Dish Catagories"
        End If

        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlCatagory)
        ShowCatagoryIntoToGrid()
        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 4
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblMessage1.Visible = False
        FillDataSetForUpDate()
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlCatagory)
        ClearTextProperty(pnlCatagory)
        ShowCatagoryIntoToGrid()
    End Sub

    Private Function FillDataSetForUpDate()
        Dim strTmpId As String
        Dim strSQLCategory As String
        Dim strSQLType As String
        Dim strSQLItem As String
        Dim strSQLInstruction As String

        Dim iIndex As Integer
        Dim iCountType As Integer
        Dim iCountItem As Integer

        Dim daCategory As SqlClient.SqlDataAdapter
        Dim dsCategory As DataSet

        Dim daType As SqlClient.SqlDataAdapter
        Dim dsType As DataSet

        Dim daItem As SqlClient.SqlDataAdapter
        Dim dsItem As DataSet

        Dim daInstruction As SqlClient.SqlDataAdapter
        Dim dsInstruction As DataSet



        If Trim(txtCatagoryID.Text) <> vbNullString Then
            strSQLCategory = "SELECT nCtgry_Id,nCtgyActive From tCategory WHERE nCtgry_Id=" & CStr(Trim(txtCatagoryID.Text)) & ""
            Try
                dsCategory = New DataSet("Category")
                daCategory = New SqlClient.SqlDataAdapter(strSQLCategory, mdDBConnection.connRestuarant)
                daCategory.Fill(dsCategory, "Category")

                strSQLType = "SELECT nType_Id,nTypeActive FROM tType WHERE nCtgry_Id=" & CStr(Trim(txtCatagoryID.Text)) & ""

                dsType = New DataSet("Type")
                daType = New SqlClient.SqlDataAdapter(strSQLType, mdDBConnection.connRestuarant)
                daType.Fill(dsType, "Type")

                iCountType = dsType.Tables("Type").Rows.Count

                If iCountType > 0 Then
                    For iIndex = 0 To iCountType - 1
                        If Trim(strTmpId) = vbNullString Then
                            strTmpId = "nType_Id=" & CStr(dsType.Tables("Type").Rows(iIndex).Item(0))
                        Else
                            strTmpId += " OR nType_Id=" & CStr(dsType.Tables("Type").Rows(iIndex).Item(0))
                        End If
                    Next

                    strSQLItem = "SELECT nItem_Id,nItemActive FROM tItem WHERE " & strTmpId & ""

                    dsItem = New DataSet("Item")
                    daItem = New SqlClient.SqlDataAdapter(strSQLItem, mdDBConnection.connRestuarant)
                    daItem.Fill(dsItem, "Item")
                    strTmpId = vbNullString

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
                        strTmpId = vbNullString
                    End If
                End If

                UpdateDataSet(dsCategory, dsType, dsItem, dsInstruction)
                UpdateDataBaseWithDataSet(daCategory, dsCategory, daType, dsType, iCountType, _
                                         daItem, dsItem, iCountItem, daInstruction, dsInstruction)
                lblMessage1.Visible = True
                lblMessage1.ForeColor = Color.Green
                lblMessage1.Text = "Your Information has been Deleted Successfully."
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Function

    Private Function UpdateDataSet(ByVal tmpCategoryDataSet As DataSet, ByVal tmpTypeDataSet As DataSet, ByVal _
                                  tmpItemDataSet As DataSet, ByVal tmpInstructionDataSet As DataSet)

        Dim iIndex As Integer
        Dim iCountType As Integer
        Dim iCountItem As Integer
        Dim iCountInstruction As Integer

        tmpCategoryDataSet.Tables("Category").Rows(0)("nCtgyActive") = 0

        iCountType = tmpTypeDataSet.Tables("Type").Rows.Count
        If iCountType > 0 Then
            For iIndex = 0 To iCountType - 1
                tmpTypeDataSet.Tables("Type").Rows(iIndex)("nTypeActive") = 0
            Next

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

        End If
    End Function

    Private Function UpdateDataBaseWithDataSet(ByVal tmpDACategory As SqlClient.SqlDataAdapter, ByVal tmpDSCategory As DataSet, _
                                               ByVal tmpDAType As SqlClient.SqlDataAdapter, ByVal tmpDSType As DataSet, ByVal tmpTypeCount As Integer, _
                                               ByVal tmpDAItem As SqlClient.SqlDataAdapter, ByVal tmpDSItem As DataSet, ByVal tmpItemCount As Integer, _
                                               ByVal tmpDAInstruction As SqlClient.SqlDataAdapter, ByVal tmpDSInstruction As DataSet)

        Dim myDataRowsComBuilderCtg As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(tmpDACategory)
        Dim myDataRowsComBuilderType As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(tmpDAType)
        Dim myDataRowsComBuilderItem As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(tmpDAItem)
        Dim myDataRowsComBuilderInst As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(tmpDAInstruction)

        tmpDACategory.Update(tmpDSCategory, "Category")
        tmpDAType.Update(tmpDSType, "Type")
        If tmpTypeCount > 0 Then
            tmpDAItem.Update(tmpDSItem, "Item")
            If tmpItemCount > 0 Then
                tmpDAInstruction.Update(tmpDSInstruction, "Instruction")
            End If
        End If

    End Function

    Private Sub txtCatagoryName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCatagoryName.TextChanged
        lblMessage1.Visible = False
    End Sub

    Private Sub txtCatagoryName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCatagoryName.KeyPress, txtCatagorySC.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnAdd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdd.KeyPress, btnEdit.KeyPress, btnDelete.KeyPress, btnExit.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        txtCatagoryName.Text = lvLookUp.SelectedItems(0).Text
        txtCatagorySC.Text = lvLookUp.SelectedItems(0).SubItems(1).Text & vbNullString
        txtCatagoryID.Text = lvLookUp.SelectedItems(0).SubItems(2).Text
        lblMessage1.Visible = False
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