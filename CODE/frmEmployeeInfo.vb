Public Class frmEmployeeInfo
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        cboDesignation.Text = "(Select Employee Designation)"
        cboDesignation.Tag = vbNullString
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
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents pnlCardInfo As System.Windows.Forms.Panel
    Friend WithEvents btnSelectType As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cEmployeeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDesignation As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboDesignation As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents cEmployeeId As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmployeeInfo))
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cEmployeeName = New System.Windows.Forms.ColumnHeader
        Me.cDesignation = New System.Windows.Forms.ColumnHeader
        Me.cEmployeeId = New System.Windows.Forms.ColumnHeader
        Me.pnlCardInfo = New System.Windows.Forms.Panel
        Me.cboDesignation = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSelectType = New System.Windows.Forms.Button
        Me.lblmessage = New System.Windows.Forms.Label
        Me.txtEmployeeName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtEmployeeId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.pnlCardInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvLookUp
        '
        Me.lvLookUp.BackColor = System.Drawing.Color.Ivory
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cEmployeeName, Me.cDesignation, Me.cEmployeeId})
        Me.lvLookUp.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(347, 10)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(300, 214)
        Me.lvLookUp.TabIndex = 0
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cEmployeeName
        '
        Me.cEmployeeName.Text = "Employee Name"
        Me.cEmployeeName.Width = 180
        '
        'cDesignation
        '
        Me.cDesignation.Text = "Designation"
        Me.cDesignation.Width = 120
        '
        'cEmployeeId
        '
        Me.cEmployeeId.Text = ""
        Me.cEmployeeId.Width = 0
        '
        'pnlCardInfo
        '
        Me.pnlCardInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardInfo.Controls.Add(Me.cboDesignation)
        Me.pnlCardInfo.Controls.Add(Me.Label2)
        Me.pnlCardInfo.Controls.Add(Me.btnSelectType)
        Me.pnlCardInfo.Controls.Add(Me.lblmessage)
        Me.pnlCardInfo.Controls.Add(Me.txtEmployeeName)
        Me.pnlCardInfo.Controls.Add(Me.Label3)
        Me.pnlCardInfo.Controls.Add(Me.txtEmployeeId)
        Me.pnlCardInfo.Controls.Add(Me.Label1)
        Me.pnlCardInfo.Location = New System.Drawing.Point(10, 10)
        Me.pnlCardInfo.Name = "pnlCardInfo"
        Me.pnlCardInfo.Size = New System.Drawing.Size(325, 126)
        Me.pnlCardInfo.TabIndex = 1
        '
        'cboDesignation
        '
        Me.cboDesignation.Enabled = False
        Me.cboDesignation.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDesignation.Items.AddRange(New Object() {"(Select Designation)", "Cook", "Driver ", "Waiter"})
        Me.cboDesignation.Location = New System.Drawing.Point(128, 46)
        Me.cboDesignation.MaxLength = 50
        Me.cboDesignation.Name = "cboDesignation"
        Me.cboDesignation.Size = New System.Drawing.Size(184, 23)
        Me.cboDesignation.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Designation"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSelectType
        '
        Me.btnSelectType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectType.Location = New System.Drawing.Point(268, -64)
        Me.btnSelectType.Name = "btnSelectType"
        Me.btnSelectType.Size = New System.Drawing.Size(60, 40)
        Me.btnSelectType.TabIndex = 3
        Me.btnSelectType.Text = "Select"
        '
        'lblmessage
        '
        Me.lblmessage.BackColor = System.Drawing.Color.Ivory
        Me.lblmessage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.ForeColor = System.Drawing.Color.Maroon
        Me.lblmessage.Location = New System.Drawing.Point(9, 79)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(305, 35)
        Me.lblmessage.TabIndex = 6
        Me.lblmessage.Text = "* Please give Employee Name"
        Me.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblmessage.Visible = False
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeName.Enabled = False
        Me.txtEmployeeName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(128, 16)
        Me.txtEmployeeName.MaxLength = 50
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(184, 21)
        Me.txtEmployeeName.TabIndex = 3
        Me.txtEmployeeName.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeId.Location = New System.Drawing.Point(160, -48)
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.ReadOnly = True
        Me.txtEmployeeId.Size = New System.Drawing.Size(104, 23)
        Me.txtEmployeeId.TabIndex = 2
        Me.txtEmployeeId.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, -48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Card Type Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnKeyBoard)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Location = New System.Drawing.Point(10, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 80)
        Me.Panel1.TabIndex = 7
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
        Me.btnExit.TabIndex = 11
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
        Me.btnDelete.Location = New System.Drawing.Point(164, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 32)
        Me.btnDelete.TabIndex = 10
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
        Me.btnEdit.Location = New System.Drawing.Point(85, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 32)
        Me.btnEdit.TabIndex = 9
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
        Me.btnAdd.Location = New System.Drawing.Point(12, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 32)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdd.TextColorHover = System.Drawing.Color.White
        Me.btnAdd.TextColorNormal = System.Drawing.Color.White
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
        Me.btnKeyBoard.TabIndex = 74
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'frmEmployeeInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(656, 246)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.pnlCardInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEmployeeInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeInfo"
        Me.pnlCardInfo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function ShowEmployeeInfoToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsEmployee As DataSet
        Dim daEmployeeInfo As SqlClient.SqlDataAdapter

        Try
            dsEmployee = New DataSet("Employee")

            strSQL = "SELECT cEmployeeName,cDesignation,nEmployeeId FROM tEmployee WHERE nActiveEmployee =1 ORDER By nEmployeeId"

            daEmployeeInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daEmployeeInfo.Fill(dsEmployee, "Employee")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsEmployee.Tables("Employee").Rows.Count

        lvLookUp.Items.Clear()
        If icount > 0 Then
            For iIndex = 0 To icount - 1
                lvLookUp.Items.Add(Trim(dsEmployee.Tables("Employee").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsEmployee.Tables("Employee").Rows(iIndex).Item(1)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsEmployee.Tables("Employee").Rows(iIndex).Item(2)))
            Next
        End If
    End Function

    Private Sub frmEmployeeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Employee Entry Form"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Employee Entry Form"
        End If

        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlCardInfo)
        ShowEmployeeInfoToGrid()
        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 6
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        txtEmployeeName.Text = lvLookUp.SelectedItems(0).Text
        cboDesignation.Text = lvLookUp.SelectedItems(0).SubItems(1).Text
        txtEmployeeId.Text = lvLookUp.SelectedItems(0).SubItems(2).Text
        lblmessage.Visible = False
    End Sub

    Private Sub Event_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdd.KeyPress, btnEdit.KeyPress, btnDelete.KeyPress, btnExit.KeyPress, txtEmployeeName.KeyPress, cboDesignation.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Function IsEmptyField() As Boolean
        Dim bIsEmpty As Boolean
        If Trim(txtEmployeeName.Text) = vbNullString Then
            bIsEmpty = True
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please give Employee Name."
            txtEmployeeName.Focus()
        ElseIf Trim(cboDesignation.Tag) = vbNullString Then
            bIsEmpty = True
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please Select Employee Designation."
            cboDesignation.Focus()
        Else
            bIsEmpty = False
            lblmessage.Visible = False
        End If
        IsEmptyField = bIsEmpty
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim strSQLInsert As String
        Dim strSQLUpdate As String

        Dim cmdInsert As SqlClient.SqlCommand

        If btnAdd.Text = "Add" Then
            lblmessage.Visible = False
            ClearTextProperty(pnlCardInfo)
            SetEnablePropertyTrue(pnlCardInfo)
            cboDesignation.Enabled = True
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
        ElseIf btnAdd.Text = "Save" Then
            If IsEmptyField() = False Then

                strSQLInsert = "INSERT INTO tEmployee(cEmployeeName,cDesignation,nActiveEmployee,cUserId,cTerminal,dAccessTime) " & _
                               "VALUES('" & Replace(Trim(txtEmployeeName.Text), "'", "''") & "','" & Replace(Trim(cboDesignation.Text), "'", "''") _
                               & "',1,'" & user & "','" & sTerminal & "',GETDATE())"

                strSQLUpdate = "UPDATE tEmployee SET cEmployeeName='" & Replace(Trim(txtEmployeeName.Text), "'", "''") _
                               & "',cDesignation='" & Replace(Trim(cboDesignation.Text), "'", "''") & "' ,cUserId='" & user _
                               & "',cTerminal='" & sTerminal & "',dAccessTime=GETDATE() " & _
                               " WHERE nEmployeeId=" & CStr(txtEmployeeId.Text) & ""

                Try
                    cmdInsert = New SqlClient.SqlCommand
                    cmdInsert.Connection = mdDBConnection.connRestuarant
                    If Trim(txtEmployeeId.Text) <> vbNullString Then
                        cmdInsert.CommandText = strSQLUpdate
                    Else
                        cmdInsert.CommandText = strSQLInsert
                    End If

                    cmdInsert.ExecuteNonQuery()
                    MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                    SetEnablePropertyFalse(pnlCardInfo)
                    cboDesignation.Enabled = False
                    cboDesignation.Text = "(Select Employee Designation)"
                    ClearTextProperty(pnlCardInfo)
                    lblmessage.Visible = True
                    lblmessage.ForeColor = Color.Green
                    lblmessage.Text = "Your Information has been Saved Successfully."
                    ShowEmployeeInfoToGrid()
                Catch ex As Exception
                    MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Trim(txtEmployeeId.Text) <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                SetEnablePropertyTrue(pnlCardInfo)
                cboDesignation.Enabled = True
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlCardInfo)
                SetEnablePropertyFalse(pnlCardInfo)
                cboDesignation.Enabled = False
                cboDesignation.Text = "(Select Employee Designation)"
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblmessage.Visible = False
            End If
        Else
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please select Employee."
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        UpdateCardActivation()
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlCardInfo)
        cboDesignation.Enabled = False
        cboDesignation.Text = "(Select Employee Designation)"
        ClearTextProperty(pnlCardInfo)
    End Sub

    Private Function UpdateCardActivation()
        Dim strSQLTable As String
        Dim cmdUpdateTableInfo As SqlClient.SqlCommand

        If Trim(txtEmployeeId.Text) <> vbNullString Then

            strSQLTable = "UPDATE tEmployee SET nActiveEmployee = 0 WHERE nEmployeeId=" & CStr(Trim(txtEmployeeId.Text)) & ""

            Try
                cmdUpdateTableInfo = New SqlClient.SqlCommand
                cmdUpdateTableInfo.Connection = mdDBConnection.connRestuarant
                cmdUpdateTableInfo.CommandText = strSQLTable
                cmdUpdateTableInfo.ExecuteNonQuery()
                ShowEmployeeInfoToGrid()
                lblmessage.Visible = True
                lblmessage.ForeColor = Color.Green
                lblmessage.Text = "Your Information has been Deleted Successfully."
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        Else
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "Please select Employee."
        End If
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub cboDesignation_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignation.TextChanged
        If Trim(cboDesignation.Text) <> vbNullString Then
            cboDesignation.Tag = "Selected"
        ElseIf Trim(cboDesignation.Text) = vbNullString Or Trim(cboDesignation.Text) = "(Select Employee Designation)" Then
            cboDesignation.Tag = vbNullString
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
