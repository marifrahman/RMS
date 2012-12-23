Public Class frmInstructtionInfo
    Inherits System.Windows.Forms.Form

    Dim iInstructionId As Integer

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents pnlInstruction As System.Windows.Forms.Panel
    Friend WithEvents txtInstructionId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSelectCatagory As System.Windows.Forms.Button
    Friend WithEvents btnInstruction As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbDefaultInst As System.Windows.Forms.RadioButton
    Friend WithEvents rbItemInstt As System.Windows.Forms.RadioButton
    Friend WithEvents txtInstruction As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cInstruction As System.Windows.Forms.ColumnHeader
    Friend WithEvents cInstructionId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInstructtionInfo))
        Me.pnlCatagorybtn = New System.Windows.Forms.Panel
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.pnlInstruction = New System.Windows.Forms.Panel
        Me.lblMessage2 = New System.Windows.Forms.Label
        Me.txtItemId = New System.Windows.Forms.TextBox
        Me.txtInstruction = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.rbItemInstt = New System.Windows.Forms.RadioButton
        Me.rbDefaultInst = New System.Windows.Forms.RadioButton
        Me.btnInstruction = New System.Windows.Forms.Button
        Me.btnSelectCatagory = New System.Windows.Forms.Button
        Me.txtInstructionId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboItem = New System.Windows.Forms.ComboBox
        Me.lblItem = New System.Windows.Forms.Label
        Me.cInstruction = New System.Windows.Forms.ColumnHeader
        Me.cInstructionId = New System.Windows.Forms.ColumnHeader
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.pnlCatagorybtn.SuspendLayout()
        Me.pnlInstruction.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCatagorybtn
        '
        Me.pnlCatagorybtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCatagorybtn.Controls.Add(Me.btnKeyBoard)
        Me.pnlCatagorybtn.Controls.Add(Me.btnExit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnDelete)
        Me.pnlCatagorybtn.Controls.Add(Me.btnEdit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnAdd)
        Me.pnlCatagorybtn.Location = New System.Drawing.Point(9, 206)
        Me.pnlCatagorybtn.Name = "pnlCatagorybtn"
        Me.pnlCatagorybtn.Size = New System.Drawing.Size(319, 82)
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
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(240, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 32)
        Me.btnExit.TabIndex = 14
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
        Me.btnDelete.Location = New System.Drawing.Point(160, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 32)
        Me.btnDelete.TabIndex = 13
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
        Me.btnEdit.Location = New System.Drawing.Point(80, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 32)
        Me.btnEdit.TabIndex = 12
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
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdd.TextColorHover = System.Drawing.Color.White
        Me.btnAdd.TextColorNormal = System.Drawing.Color.White
        '
        'pnlInstruction
        '
        Me.pnlInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInstruction.Controls.Add(Me.lblMessage2)
        Me.pnlInstruction.Controls.Add(Me.txtItemId)
        Me.pnlInstruction.Controls.Add(Me.txtInstruction)
        Me.pnlInstruction.Controls.Add(Me.Label4)
        Me.pnlInstruction.Controls.Add(Me.rbItemInstt)
        Me.pnlInstruction.Controls.Add(Me.rbDefaultInst)
        Me.pnlInstruction.Controls.Add(Me.btnInstruction)
        Me.pnlInstruction.Controls.Add(Me.btnSelectCatagory)
        Me.pnlInstruction.Controls.Add(Me.txtInstructionId)
        Me.pnlInstruction.Controls.Add(Me.Label2)
        Me.pnlInstruction.Controls.Add(Me.txtItemName)
        Me.pnlInstruction.Controls.Add(Me.Label1)
        Me.pnlInstruction.Controls.Add(Me.Label3)
        Me.pnlInstruction.Location = New System.Drawing.Point(9, 8)
        Me.pnlInstruction.Name = "pnlInstruction"
        Me.pnlInstruction.Size = New System.Drawing.Size(316, 184)
        Me.pnlInstruction.TabIndex = 3
        '
        'lblMessage2
        '
        Me.lblMessage2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage2.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage2.Location = New System.Drawing.Point(10, 145)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(294, 32)
        Me.lblMessage2.TabIndex = 8
        Me.lblMessage2.Text = "* Please give Instrection"
        Me.lblMessage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemId
        '
        Me.txtItemId.Location = New System.Drawing.Point(-152, 144)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(111, 20)
        Me.txtItemId.TabIndex = 28
        Me.txtItemId.Text = ""
        Me.txtItemId.Visible = False
        '
        'txtInstruction
        '
        Me.txtInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInstruction.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstruction.Location = New System.Drawing.Point(88, 43)
        Me.txtInstruction.MaxLength = 250
        Me.txtInstruction.Multiline = True
        Me.txtInstruction.Name = "txtInstruction"
        Me.txtInstruction.Size = New System.Drawing.Size(216, 93)
        Me.txtInstruction.TabIndex = 7
        Me.txtInstruction.Text = ""
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(0, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 1)
        Me.Label4.TabIndex = 26
        '
        'rbItemInstt
        '
        Me.rbItemInstt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbItemInstt.Location = New System.Drawing.Point(152, 4)
        Me.rbItemInstt.Name = "rbItemInstt"
        Me.rbItemInstt.Size = New System.Drawing.Size(155, 24)
        Me.rbItemInstt.TabIndex = 5
        Me.rbItemInstt.Text = "Item wise Instruction "
        '
        'rbDefaultInst
        '
        Me.rbDefaultInst.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDefaultInst.Location = New System.Drawing.Point(8, 4)
        Me.rbDefaultInst.Name = "rbDefaultInst"
        Me.rbDefaultInst.Size = New System.Drawing.Size(144, 24)
        Me.rbDefaultInst.TabIndex = 4
        Me.rbDefaultInst.Text = "Default Instruction"
        '
        'btnInstruction
        '
        Me.btnInstruction.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnInstruction.Location = New System.Drawing.Point(289, -64)
        Me.btnInstruction.Name = "btnInstruction"
        Me.btnInstruction.Size = New System.Drawing.Size(48, 34)
        Me.btnInstruction.TabIndex = 6
        Me.btnInstruction.Text = "Select"
        Me.btnInstruction.Visible = False
        '
        'btnSelectCatagory
        '
        Me.btnSelectCatagory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectCatagory.Location = New System.Drawing.Point(-304, 44)
        Me.btnSelectCatagory.Name = "btnSelectCatagory"
        Me.btnSelectCatagory.Size = New System.Drawing.Size(62, 20)
        Me.btnSelectCatagory.TabIndex = 3
        Me.btnSelectCatagory.Text = "Select"
        Me.btnSelectCatagory.Visible = False
        '
        'txtInstructionId
        '
        Me.txtInstructionId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtInstructionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInstructionId.Location = New System.Drawing.Point(130, -64)
        Me.txtInstructionId.Name = "txtInstructionId"
        Me.txtInstructionId.ReadOnly = True
        Me.txtInstructionId.Size = New System.Drawing.Size(156, 20)
        Me.txtInstructionId.TabIndex = 5
        Me.txtInstructionId.Text = ""
        Me.txtInstructionId.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-152, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Instruction"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Location = New System.Drawing.Point(-464, 44)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(170, 20)
        Me.txtItemName.TabIndex = 2
        Me.txtItemName.Text = ""
        Me.txtItemName.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-592, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Instruction"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(153, -25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 25)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Select  Type"
        '
        'cboItem
        '
        Me.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItem.Location = New System.Drawing.Point(432, 8)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(224, 23)
        Me.cboItem.TabIndex = 0
        '
        'lblItem
        '
        Me.lblItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(336, 8)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(91, 20)
        Me.lblItem.TabIndex = 1
        Me.lblItem.Text = "Select  Item"
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cInstruction
        '
        Me.cInstruction.Text = "Instruction"
        Me.cInstruction.Width = 320
        '
        'cInstructionId
        '
        Me.cInstructionId.Width = 0
        '
        'lvLookUp
        '
        Me.lvLookUp.BackColor = System.Drawing.Color.Ivory
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cInstruction, Me.cInstructionId})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(336, 41)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(320, 247)
        Me.lvLookUp.TabIndex = 2
        Me.lvLookUp.View = System.Windows.Forms.View.Details
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
        Me.btnKeyBoard.Location = New System.Drawing.Point(99, 40)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(118, 32)
        Me.btnKeyBoard.TabIndex = 71
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'frmInstructtionInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(658, 312)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.pnlInstruction)
        Me.Controls.Add(Me.pnlCatagorybtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInstructtionInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instruction Entry"
        Me.pnlCatagorybtn.ResumeLayout(False)
        Me.pnlInstruction.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function FillItemCombo()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsItem As DataSet
        Dim daItemInfo As SqlClient.SqlDataAdapter

        Try
            dsItem = New DataSet("Item")
            strSQL = "SELECT nItem_Id,cItem_Name FROM tItem WHERE nItemActive=1"
            daItemInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daItemInfo.Fill(dsItem, "Item")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsItem.Tables("Item").Rows.Count

        If icount > 0 Then
            With cboItem
                .DataSource = dsItem.Tables("Item")
                .DisplayMember = "cItem_Name"
                .ValueMember = "nItem_Id"
                .SelectedIndex = -1
            End With
        End If
    End Function

    Private Sub frmInstructtionInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 2

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Instruction Entry"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Instruction Entry"
        End If
        bCboLoad = True
        FillItemCombo()
        bCboLoad = False
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlInstruction)
        rbItemInstt.Checked = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If rbDefaultInst.Checked = True Then
            AddDefaultInstruction()
        Else
            AddItemWiseInstruction()
        End If
        txtInstruction.Focus()
    End Sub

    Private Function AddDefaultInstruction()

        Dim strSQLInsertuctionAdd As String
        Dim strSQLInsertuctionUpdate As String

        Dim cmdInstruction As SqlClient.SqlCommand

        If btnAdd.Text = "Add" Then
            lblMessage2.Visible = False
            ClearTextProperty(pnlInstruction)
            txtInstruction.Enabled = True
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
        ElseIf btnAdd.Text = "Save" Then
            If Trim(txtInstruction.Text) <> vbNullString Then

                strSQLInsertuctionAdd = "INSERT INTO tInstruction(cInstruction,nItem_Id,nActiveInstruction)" & _
                                        " VALUES('" & Replace(Trim(txtInstruction.Text), "'", "''") & "',0,1)"

                strSQLInsertuctionUpdate = "UPDATE tInstruction SET cInstruction='" & Replace(Trim(txtInstruction.Text), "'", "''") & _
                                           "' WHERE nInstruction_Id=" & CStr(Trim(txtInstructionId.Text)) & ""
                Try
                    cmdInstruction = New SqlClient.SqlCommand
                    cmdInstruction.Connection = mdDBConnection.connRestuarant
                    If Trim(txtInstructionId.Text) <> vbNullString Then
                        cmdInstruction.CommandText = strSQLInsertuctionUpdate
                    Else
                        cmdInstruction.CommandText = strSQLInsertuctionAdd
                    End If
                    cmdInstruction.ExecuteNonQuery()
                    ShowInstructionToGrid()
                    MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                    SetEnablePropertyFalse(pnlInstruction)
                    txtInstructionId.Text = vbNullString
                    txtInstruction.Text = vbNullString
                    lblMessage2.Visible = True
                    lblMessage2.ForeColor = Color.Green
                    lblMessage2.Text = "Your Information has been Saved Successfully."
                Catch ex As Exception
                    MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                End Try
            Else
                lblMessage2.Visible = True
                lblMessage2.ForeColor = Color.Maroon
                lblMessage2.Text = "* Please give Instruction."
            End If
        End If
    End Function

    Private Function AddItemWiseInstruction()

        Dim strSQLInsertuctionAdd As String
        Dim strSQLInsertuctionUpdate As String

        Dim cmdInstruction As SqlClient.SqlCommand

        If Trim(txtItemName.Text) <> vbNullString Then
            If btnAdd.Text = "Add" Then
                lblMessage2.Visible = False
                txtInstructionId.Text = vbNullString
                txtInstruction.Text = vbNullString
                txtInstruction.Enabled = True
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
            ElseIf btnAdd.Text = "Save" Then
                If Trim(txtInstruction.Text) <> vbNullString Then

                    strSQLInsertuctionAdd = "INSERT INTO tInstruction(cInstruction,nItem_Id,nActiveInstruction)" & _
                                        " VALUES('" & Replace(Trim(txtInstruction.Text), "'", "''") & "'," & CStr(Trim(txtItemId.Text)) & ",1)"

                    strSQLInsertuctionUpdate = "UPDATE tInstruction SET cInstruction='" & Replace(Trim(txtInstruction.Text), "'", "''") & _
                                               "' WHERE nInstruction_Id=" & CStr(txtInstructionId.Text) & " AND nItem_Id=" & CStr(Trim(txtItemId.Text)) & ""

                    Try
                        cmdInstruction = New SqlClient.SqlCommand
                        cmdInstruction.Connection = mdDBConnection.connRestuarant
                        If Trim(txtInstructionId.Text) <> vbNullString Then
                            cmdInstruction.CommandText = strSQLInsertuctionUpdate
                        Else
                            cmdInstruction.CommandText = strSQLInsertuctionAdd
                        End If
                        cmdInstruction.ExecuteNonQuery()
                        ShowInstructionToGrid()
                        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                        SetEnablePropertyFalse(pnlInstruction)
                        txtInstructionId.Text = vbNullString
                        txtInstruction.Text = vbNullString
                        lblMessage2.Visible = True
                        lblMessage2.ForeColor = Color.Green
                        lblMessage2.Text = "Your Information has been Saved Successfully."
                    Catch ex As Exception
                        MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                    End Try
                Else
                    lblMessage2.Visible = True
                    lblMessage2.ForeColor = Color.Maroon
                    lblMessage2.Text = "* Please give Instruction."
                End If
            End If
        Else
            lblMessage2.Visible = True
            lblMessage2.ForeColor = Color.Maroon
            lblMessage2.Text = "* Please select item."
            cboItem.Focus()
        End If
    End Function

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            lblMessage2.Visible = False
            SetEnablePropertyTrue(Me)
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
            SetEnablePropertyTrue(pnlInstruction)
            txtInstruction.Focus()
        ElseIf btnEdit.Text = "Cancel" Then
            txtInstruction.Text = vbNullString
            SetEnablePropertyFalse(pnlInstruction)
            MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
            lblMessage2.Visible = False
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        UpdateTableActivation()
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlInstruction)
        txtInstruction.Text = vbNullString
        txtInstructionId.Text = vbNullString
        ShowInstructionToGrid()
    End Sub

    Private Function UpdateTableActivation()
        Dim strSQLInstruction As String
        Dim strMessage As String = "Your Information has been Deleted Successfully"

        Dim cmdUpdateInstruction As SqlClient.SqlCommand

        If Trim(txtInstructionId.Text) <> vbNullString Then
            strSQLInstruction = "UPDATE tInstruction SET nActiveInstruction = 0 WHERE nInstruction_Id=" & CStr(Trim(txtInstructionId.Text)) & ""
            Try
                cmdUpdateInstruction = New SqlClient.SqlCommand
                cmdUpdateInstruction.Connection = mdDBConnection.connRestuarant
                cmdUpdateInstruction.CommandText = strSQLInstruction
                cmdUpdateInstruction.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Function

    Private Sub txtInstruction_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInstruction.TextChanged
        lblMessage2.Visible = False
    End Sub

    Private Sub rbDefaultInst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbDefaultInst.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rbItemInstt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbItemInstt.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnAdd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdd.KeyPress, btnEdit.KeyPress, btnDelete.KeyPress, btnExit.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtInstruction_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInstruction.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub rbDefaultInst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDefaultInst.Click
        lvLookUp.Height = 260
        lvLookUp.Top = 9
        cboItem.Visible = False
        lblItem.Visible = False
        lblMessage2.Visible = False
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlInstruction)
        ClearTextProperty(pnlInstruction)
        ShowInstructionToGrid()
    End Sub

    Private Sub rbItemInstt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbItemInstt.Click
        lvLookUp.Height = 228
        lvLookUp.Top = 41
        cboItem.Visible = True
        lblItem.Visible = True
        lblMessage2.Visible = False
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlInstruction)
        ClearTextProperty(pnlInstruction)
        lvLookUp.Items.Clear()
    End Sub

    Private Function ShowInstructionToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsItem As DataSet
        Dim daItemInfo As SqlClient.SqlDataAdapter

        Try
            dsItem = New DataSet("Item")

            If rbDefaultInst.Checked = True Then
                strSQL = "SELECT cInstruction,nInstruction_Id FROM tInstruction WHERE nItem_Id=0 AND nActiveInstruction=1 "
                daItemInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                daItemInfo.Fill(dsItem, "Item")
            Else
                If Trim(txtItemId.Text) <> vbNullString Then
                    strSQL = "SELECT cInstruction,nInstruction_Id FROM tInstruction WHERE nItem_Id=" & CStr(Trim(cboItem.SelectedValue)) & " AND nActiveInstruction=1 "
                    daItemInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
                    daItemInfo.Fill(dsItem, "Item")
                End If
            End If
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsItem.Tables("Item").Rows.Count

        lvLookUp.Items.Clear()

        If icount > 0 Then
            For iIndex = 0 To icount - 1
                lvLookUp.Items.Add(Trim(dsItem.Tables("Item").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsItem.Tables("Item").Rows(iIndex).Item(1)))
            Next
        End If
    End Function

    Private Sub cboItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItem.SelectedIndexChanged
        If bCboLoad = False Then
            txtItemName.Text = Trim(cboItem.Text)
            txtItemId.Text = Trim(cboItem.SelectedValue)
            ShowInstructionToGrid()
        End If
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        txtInstruction.Text = lvLookUp.SelectedItems(0).Text
        txtInstructionId.Text = lvLookUp.SelectedItems(0).SubItems(1).Text
        lblMessage2.Visible = False
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
