Public Class frmUsrMng
    Inherits System.Windows.Forms.Form

    Dim dsUser As DataSet
    Dim daUser As SqlClient.SqlDataAdapter

    Dim strPermission As String = "Limited" ' It's the default permission for a user

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
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents txtConfPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtUsr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlCatagorybtn As System.Windows.Forms.Panel
    Friend WithEvents grpPermission As System.Windows.Forms.GroupBox
    Friend WithEvents rdoLimited As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents lblConfPwd As System.Windows.Forms.Label
    Friend WithEvents lblPwd As System.Windows.Forms.Label
    Friend WithEvents pnlUser As System.Windows.Forms.Panel
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cUserId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cUserPassword As System.Windows.Forms.ColumnHeader
    Friend WithEvents cUserPermission As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUsrMng))
        Me.pnlUser = New System.Windows.Forms.Panel
        Me.btnSelect = New System.Windows.Forms.Button
        Me.grpPermission = New System.Windows.Forms.GroupBox
        Me.rdoLimited = New System.Windows.Forms.RadioButton
        Me.rdoAdmin = New System.Windows.Forms.RadioButton
        Me.lblMsg = New System.Windows.Forms.Label
        Me.txtConfPwd = New System.Windows.Forms.TextBox
        Me.lblConfPwd = New System.Windows.Forms.Label
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.txtUsr = New System.Windows.Forms.TextBox
        Me.lblPwd = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlCatagorybtn = New System.Windows.Forms.Panel
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cUserId = New System.Windows.Forms.ColumnHeader
        Me.cUserPermission = New System.Windows.Forms.ColumnHeader
        Me.cUserPassword = New System.Windows.Forms.ColumnHeader
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.pnlUser.SuspendLayout()
        Me.grpPermission.SuspendLayout()
        Me.pnlCatagorybtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUser
        '
        Me.pnlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUser.Controls.Add(Me.btnSelect)
        Me.pnlUser.Controls.Add(Me.grpPermission)
        Me.pnlUser.Controls.Add(Me.lblMsg)
        Me.pnlUser.Controls.Add(Me.txtConfPwd)
        Me.pnlUser.Controls.Add(Me.lblConfPwd)
        Me.pnlUser.Controls.Add(Me.txtPwd)
        Me.pnlUser.Controls.Add(Me.txtUsr)
        Me.pnlUser.Controls.Add(Me.lblPwd)
        Me.pnlUser.Controls.Add(Me.Label2)
        Me.pnlUser.Location = New System.Drawing.Point(8, 8)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(320, 232)
        Me.pnlUser.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelect.Location = New System.Drawing.Point(280, -48)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(70, 33)
        Me.btnSelect.TabIndex = 101
        Me.btnSelect.Text = "SelectUser"
        '
        'grpPermission
        '
        Me.grpPermission.Controls.Add(Me.rdoLimited)
        Me.grpPermission.Controls.Add(Me.rdoAdmin)
        Me.grpPermission.Enabled = False
        Me.grpPermission.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpPermission.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPermission.Location = New System.Drawing.Point(12, 120)
        Me.grpPermission.Name = "grpPermission"
        Me.grpPermission.Size = New System.Drawing.Size(292, 64)
        Me.grpPermission.TabIndex = 7
        Me.grpPermission.TabStop = False
        Me.grpPermission.Text = "User Permission"
        '
        'rdoLimited
        '
        Me.rdoLimited.BackColor = System.Drawing.Color.Ivory
        Me.rdoLimited.Checked = True
        Me.rdoLimited.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLimited.Location = New System.Drawing.Point(108, 36)
        Me.rdoLimited.Name = "rdoLimited"
        Me.rdoLimited.Size = New System.Drawing.Size(128, 24)
        Me.rdoLimited.TabIndex = 9
        Me.rdoLimited.TabStop = True
        Me.rdoLimited.Text = "Limited"
        '
        'rdoAdmin
        '
        Me.rdoAdmin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAdmin.Location = New System.Drawing.Point(108, 10)
        Me.rdoAdmin.Name = "rdoAdmin"
        Me.rdoAdmin.Size = New System.Drawing.Size(128, 24)
        Me.rdoAdmin.TabIndex = 8
        Me.rdoAdmin.Text = "Administrative"
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Brown
        Me.lblMsg.Location = New System.Drawing.Point(12, 187)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(284, 32)
        Me.lblMsg.TabIndex = 10
        Me.lblMsg.Text = "Please put necessary Information!!"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsg.Visible = False
        '
        'txtConfPwd
        '
        Me.txtConfPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfPwd.Enabled = False
        Me.txtConfPwd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfPwd.Location = New System.Drawing.Point(155, 80)
        Me.txtConfPwd.MaxLength = 25
        Me.txtConfPwd.Name = "txtConfPwd"
        Me.txtConfPwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPwd.Size = New System.Drawing.Size(136, 21)
        Me.txtConfPwd.TabIndex = 6
        Me.txtConfPwd.Text = ""
        '
        'lblConfPwd
        '
        Me.lblConfPwd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfPwd.Location = New System.Drawing.Point(25, 80)
        Me.lblConfPwd.Name = "lblConfPwd"
        Me.lblConfPwd.Size = New System.Drawing.Size(124, 23)
        Me.lblConfPwd.TabIndex = 5
        Me.lblConfPwd.Text = "Confirm Password"
        Me.lblConfPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPwd
        '
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd.Enabled = False
        Me.txtPwd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(155, 48)
        Me.txtPwd.MaxLength = 25
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(136, 21)
        Me.txtPwd.TabIndex = 4
        Me.txtPwd.Text = ""
        '
        'txtUsr
        '
        Me.txtUsr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsr.Enabled = False
        Me.txtUsr.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsr.Location = New System.Drawing.Point(155, 16)
        Me.txtUsr.MaxLength = 25
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Size = New System.Drawing.Size(136, 21)
        Me.txtUsr.TabIndex = 2
        Me.txtUsr.Text = ""
        '
        'lblPwd
        '
        Me.lblPwd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPwd.Location = New System.Drawing.Point(25, 48)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(124, 23)
        Me.lblPwd.TabIndex = 3
        Me.lblPwd.Text = "Password"
        Me.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Id"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlCatagorybtn
        '
        Me.pnlCatagorybtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCatagorybtn.Controls.Add(Me.btnKeyBoard)
        Me.pnlCatagorybtn.Controls.Add(Me.btnExit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnDelete)
        Me.pnlCatagorybtn.Controls.Add(Me.btnEdit)
        Me.pnlCatagorybtn.Controls.Add(Me.btnAdd)
        Me.pnlCatagorybtn.Location = New System.Drawing.Point(8, 249)
        Me.pnlCatagorybtn.Name = "pnlCatagorybtn"
        Me.pnlCatagorybtn.Size = New System.Drawing.Size(320, 103)
        Me.pnlCatagorybtn.TabIndex = 11
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
        Me.btnExit.Location = New System.Drawing.Point(248, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 40)
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
        Me.btnDelete.Size = New System.Drawing.Size(68, 40)
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
        Me.btnEdit.Size = New System.Drawing.Size(67, 40)
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
        Me.btnAdd.Location = New System.Drawing.Point(16, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(66, 40)
        Me.btnAdd.TabIndex = 12
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
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cUserId, Me.cUserPermission, Me.cUserPassword})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(337, 8)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(376, 344)
        Me.lvLookUp.TabIndex = 16
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cUserId
        '
        Me.cUserId.Text = "User Id"
        Me.cUserId.Width = 120
        '
        'cUserPermission
        '
        Me.cUserPermission.Text = "Permission"
        Me.cUserPermission.Width = 120
        '
        'cUserPassword
        '
        Me.cUserPassword.Width = 0
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
        Me.btnKeyBoard.Location = New System.Drawing.Point(99, 56)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(120, 44)
        Me.btnKeyBoard.TabIndex = 77
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'frmUsrMng
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(722, 368)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.pnlCatagorybtn)
        Me.Controls.Add(Me.pnlUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUsrMng"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User Panel"
        Me.pnlUser.ResumeLayout(False)
        Me.grpPermission.ResumeLayout(False)
        Me.pnlCatagorybtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function CheckIfUserExists(ByVal strUser As String) As Boolean

        Dim i As Integer
        For i = 0 To dsUser.Tables("User").Rows.Count - 1
            If dsUser.Tables("User").Rows(i).Item(0) = strUser Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function ShowUserInfoToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        icount = dsUser.Tables("User").Rows.Count

        lvLookUp.Items.Clear()
        If icount > 0 Then
            For iIndex = 0 To icount - 1
                lvLookUp.Items.Add(Trim(dsUser.Tables("User").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsUser.Tables("User").Rows(iIndex).Item(2)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsUser.Tables("User").Rows(iIndex).Item(1)))
            Next
        End If
    End Function

    Private Sub frmUsrMng_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlUser)
        FillUserDataSet()
        ShowUserInfoToGrid()
        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 4

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Add User Panel"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Add User Panel"
        End If
    End Sub

    Private Sub FillUserDataSet()
        Dim strSQl As String
        Try
            dsUser = New DataSet("User")
            strSQl = "SELECT cUser,cPassword,cPermission,nLoginStatus,cTerminal,cAccessTime FROM tUser" '
            daUser = New SqlClient.SqlDataAdapter(strSQl, mdDBConnection.connRestuarant)
            daUser.Fill(dsUser, "User")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        strSQl = vbNullString
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim strSQL As String
        Dim cmdUpdate As SqlClient.SqlCommand

        If btnAdd.Text = "Add" Then
            lblMsg.Visible = False
            ClearTextProperty(pnlUser)
            SetEnablePropertyTrue(pnlUser)
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
            txtUsr.Focus()
        ElseIf btnAdd.Text = "Save" Then
            If Trim(txtUsr.Text) = vbNullString Then
                lblMsg.Visible = True
                lblMsg.ForeColor = Color.Maroon
                lblMsg.Text = "Please put necessary Information!!"
                Exit Sub
            Else
                If txtUsr.Enabled = True Then
                    If CheckIfUserExists(txtUsr.Text) = True Then
                        lblMsg.Visible = True
                        lblMsg.ForeColor = Color.Maroon
                        lblMsg.Text = "User already exists!!"
                        txtUsr.Focus()
                        txtPwd.Clear()
                        txtConfPwd.Clear()
                        Exit Sub
                    Else
                        If Trim(txtPwd.Text) <> vbNullString Or Trim(txtConfPwd.Text) <> vbNullString Then
                            If Trim(txtPwd.Text) = Trim(txtConfPwd.Text) Then
                                strSQL = "Insert into tUser (cUser,cPassword,cPermission,cTerminal,cAccessTime) values('" & CStr(txtUsr.Text) & "','" & CStr(txtPwd.Text) & "','" & strPermission & "','" & sTerminal & "',GETDATE())"
                            Else
                                MsgBox("Password and Confirm Password is not same" & vbCrLf & "Please give the same Password", MsgBoxStyle.Information, "Admin User Panel")
                                Exit Sub
                            End If
                        Else
                            strSQL = "Insert into tUser (cUser,cPassword,cPermission,cTerminal,cAccessTime) values('" & CStr(txtUsr.Text) & "','" & CStr(txtPwd.Text) & "','" & strPermission & "','" & sTerminal & "',GETDATE())"
                        End If
                    End If
                Else
                    strSQL = "UPDATE tUser SET cUser='" & txtUsr.Text & "',cPassword='" + txtConfPwd.Text + "',cPermission='" + strPermission + "',cTerminal='" & sTerminal & "', cAccessTime=GETDATE() WHERE cUser='" & Trim(txtUsr.Text) & "'"
                End If
            End If
            Try
                cmdUpdate = New SqlClient.SqlCommand
                cmdUpdate.Connection = mdDBConnection.connRestuarant
                cmdUpdate.CommandText = strSQL
                cmdUpdate.ExecuteNonQuery()
                FillUserDataSet()
                ShowUserInfoToGrid()
                ClearTextProperty(pnlUser)
                lblMsg.Visible = True
                lblMsg.ForeColor = Color.Green
                lblMsg.Text = "User Successfully added!!"
                txtUsr.Clear()
                txtPwd.Clear()
                txtConfPwd.Clear()
                txtUsr.Enabled = True
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                SetEnablePropertyFalse(pnlUser)
                strUser = vbNewLine
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Trim(txtUsr.Text) <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
                SetEnablePropertyTrue(pnlUser)
                Me.lblPwd.Text = "Old Password:"
                Me.lblConfPwd.Text = "New Password"
                txtUsr.Enabled = False
                txtPwd.Enabled = False
                txtUsr.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlUser)   'To Clear All the information from Text Box
                SetEnablePropertyFalse(pnlUser)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
            End If
        Else
            lblMsg.Visible = True
            lblMsg.ForeColor = Color.Maroon
            lblMsg.Text = "* Please select a User"
            lvLookUp.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub rdoAdmin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoAdmin.CheckedChanged
        strPermission = "Administrator"
    End Sub
    Private Sub rdoLimited_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoLimited.CheckedChanged
        strPermission = "Limited"
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim strSQL As String
        Dim cmdDelete As SqlClient.SqlCommand

        If Trim(txtUsr.Text) <> vbNullString Then
            strSQL = "DELETE FROM tUser WHERE cUser='" & Trim(txtUsr.Text) & "'"
            Try
                cmdDelete = New SqlClient.SqlCommand
                cmdDelete.Connection = mdDBConnection.connRestuarant
                cmdDelete.CommandText = strSQL
                If MessageBox.Show("Do you want to delete the user?", "Manage User", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    cmdDelete.ExecuteNonQuery()
                    FillUserDataSet()
                    ShowUserInfoToGrid()
                    ClearTextProperty(pnlUser)
                    MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                    SetEnablePropertyFalse(pnlUser)
                    rdoLimited.Checked = True
                    lblMsg.Visible = True
                    lblMsg.ForeColor = Color.Green
                    lblMsg.Text = "Your Information has been Deleted Successfully."
                End If
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        txtUsr.Text = lvLookUp.SelectedItems(0).Text
        txtPwd.Text = lvLookUp.SelectedItems(0).SubItems(2).Text & vbNullString
        If Trim(lvLookUp.SelectedItems(0).SubItems(1).Text) = "Administrator" Then
            rdoAdmin.Checked = True
        Else
            rdoLimited.Checked = True
        End If
        lblMsg.Visible = False
    End Sub

    Private Sub Event_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsr.KeyPress, txtPwd.KeyPress, txtConfPwd.KeyPress, rdoAdmin.KeyPress, rdoLimited.KeyPress, btnAdd.KeyPress, btnEdit.KeyPress, btnDelete.KeyPress, btnExit.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
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
