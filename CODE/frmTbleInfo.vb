Public Class frmTbleInfo
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnSelectType As System.Windows.Forms.Button
    Friend WithEvents txtTableCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTableSize As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTableId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlTableInfo As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cTableCapacity As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblmessage1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTableNo As System.Windows.Forms.TextBox
    Friend WithEvents cTableNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTableId As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTbleInfo))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.pnlTableInfo = New System.Windows.Forms.Panel
        Me.txtTableNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSelectType = New System.Windows.Forms.Button
        Me.lblmessage1 = New System.Windows.Forms.Label
        Me.txtTableCapacity = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTableSize = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTableId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cTableNo = New System.Windows.Forms.ColumnHeader
        Me.cTableCapacity = New System.Windows.Forms.ColumnHeader
        Me.cTableId = New System.Windows.Forms.ColumnHeader
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.Panel1.SuspendLayout()
        Me.pnlTableInfo.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(11, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 76)
        Me.Panel1.TabIndex = 8
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
        Me.btnExit.Location = New System.Drawing.Point(244, 8)
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
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(164, 8)
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
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(84, 8)
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
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(8, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 32)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdd.TextColorHover = System.Drawing.Color.White
        Me.btnAdd.TextColorNormal = System.Drawing.Color.White
        '
        'pnlTableInfo
        '
        Me.pnlTableInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTableInfo.Controls.Add(Me.txtTableNo)
        Me.pnlTableInfo.Controls.Add(Me.Label4)
        Me.pnlTableInfo.Controls.Add(Me.Label5)
        Me.pnlTableInfo.Controls.Add(Me.btnSelectType)
        Me.pnlTableInfo.Controls.Add(Me.lblmessage1)
        Me.pnlTableInfo.Controls.Add(Me.txtTableCapacity)
        Me.pnlTableInfo.Controls.Add(Me.Label3)
        Me.pnlTableInfo.Controls.Add(Me.txtTableSize)
        Me.pnlTableInfo.Controls.Add(Me.Label2)
        Me.pnlTableInfo.Controls.Add(Me.txtTableId)
        Me.pnlTableInfo.Controls.Add(Me.Label1)
        Me.pnlTableInfo.Location = New System.Drawing.Point(11, 13)
        Me.pnlTableInfo.Name = "pnlTableInfo"
        Me.pnlTableInfo.Size = New System.Drawing.Size(325, 112)
        Me.pnlTableInfo.TabIndex = 1
        '
        'txtTableNo
        '
        Me.txtTableNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTableNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTableNo.Enabled = False
        Me.txtTableNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableNo.Location = New System.Drawing.Point(158, 10)
        Me.txtTableNo.MaxLength = 20
        Me.txtTableNo.Name = "txtTableNo"
        Me.txtTableNo.Size = New System.Drawing.Size(56, 21)
        Me.txtTableNo.TabIndex = 3
        Me.txtTableNo.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Table No."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(222, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Persons"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSelectType
        '
        Me.btnSelectType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectType.Location = New System.Drawing.Point(272, -80)
        Me.btnSelectType.Name = "btnSelectType"
        Me.btnSelectType.Size = New System.Drawing.Size(60, 37)
        Me.btnSelectType.TabIndex = 3
        Me.btnSelectType.Text = "Select"
        '
        'lblmessage1
        '
        Me.lblmessage1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage1.ForeColor = System.Drawing.Color.Maroon
        Me.lblmessage1.Location = New System.Drawing.Point(10, 68)
        Me.lblmessage1.Name = "lblmessage1"
        Me.lblmessage1.Size = New System.Drawing.Size(304, 36)
        Me.lblmessage1.TabIndex = 7
        Me.lblmessage1.Text = "* Please give Table Capacity"
        Me.lblmessage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblmessage1.Visible = False
        '
        'txtTableCapacity
        '
        Me.txtTableCapacity.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTableCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTableCapacity.Enabled = False
        Me.txtTableCapacity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableCapacity.Location = New System.Drawing.Point(158, 37)
        Me.txtTableCapacity.MaxLength = 4
        Me.txtTableCapacity.Name = "txtTableCapacity"
        Me.txtTableCapacity.Size = New System.Drawing.Size(56, 21)
        Me.txtTableCapacity.TabIndex = 5
        Me.txtTableCapacity.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Table Capacity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTableSize
        '
        Me.txtTableSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTableSize.Enabled = False
        Me.txtTableSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableSize.Location = New System.Drawing.Point(160, -56)
        Me.txtTableSize.MaxLength = 4
        Me.txtTableSize.Name = "txtTableSize"
        Me.txtTableSize.Size = New System.Drawing.Size(110, 23)
        Me.txtTableSize.TabIndex = 5
        Me.txtTableSize.Text = ""
        Me.txtTableSize.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Table Size"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'txtTableId
        '
        Me.txtTableId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTableId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTableId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableId.Location = New System.Drawing.Point(158, -32)
        Me.txtTableId.Name = "txtTableId"
        Me.txtTableId.ReadOnly = True
        Me.txtTableId.Size = New System.Drawing.Size(56, 21)
        Me.txtTableId.TabIndex = 1
        Me.txtTableId.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, -32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Table Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lvLookUp
        '
        Me.lvLookUp.BackColor = System.Drawing.Color.Ivory
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cTableNo, Me.cTableCapacity, Me.cTableId})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(351, 14)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(180, 194)
        Me.lvLookUp.TabIndex = 0
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cTableNo
        '
        Me.cTableNo.Text = "Table No."
        Me.cTableNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cTableNo.Width = 79
        '
        'cTableCapacity
        '
        Me.cTableCapacity.Text = "Capacity"
        Me.cTableCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cTableCapacity.Width = 100
        '
        'cTableId
        '
        Me.cTableId.Text = ""
        Me.cTableId.Width = 0
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
        Me.btnKeyBoard.TabIndex = 72
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'frmTbleInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(538, 232)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.pnlTableInfo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTbleInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table information"
        Me.Panel1.ResumeLayout(False)
        Me.pnlTableInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim strSQLInsert As String
        Dim strSQLUpdate As String

        Dim cmdInsert As SqlClient.SqlCommand

        If btnAdd.Text = "Add" Then
            lblmessage1.Visible = False
            ClearTextProperty(pnlTableInfo)
            SetEnablePropertyTrue(pnlTableInfo)
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
            txtTableNo.Focus()
        ElseIf btnAdd.Text = "Save" Then
            If CheckEmptyTableInfo() Then
                Exit Sub
            End If

            strSQLInsert = "INSERT INTO tTable_Info(cTableNumber,nTable_Capacity,nStatus,nTableActive,cUserId,cTerminal,dAccessTime) " & _
                           "VALUES('" & Trim(txtTableNo.Text) & "'," & CStr(Trim(txtTableCapacity.Text)) & ",0,1,'" & user & _
                           "','" & sTerminal & "',GETDATE())"

            strSQLUpdate = "UPDATE tTable_Info SET cTableNumber='" & Trim(txtTableNo.Text) & "',nTable_Capacity=" & CStr(txtTableCapacity.Text) & " ,cUserId='" & user & _
                           "',cTerminal='" & sTerminal & "',dAccessTime=GETDATE()WHERE nTable_Id=" & CStr(txtTableId.Text) & ""

            Try
                cmdInsert = New SqlClient.SqlCommand
                cmdInsert.Connection = mdDBConnection.connRestuarant
                If Trim(txtTableId.Text) <> vbNullString Then
                    cmdInsert.CommandText = strSQLUpdate
                Else
                    cmdInsert.CommandText = strSQLInsert
                End If

                cmdInsert.ExecuteNonQuery()
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                SetEnablePropertyFalse(pnlTableInfo)
                ClearTextProperty(pnlTableInfo)
                lblmessage1.Visible = True
                lblmessage1.ForeColor = Color.Green
                lblmessage1.Text = "Your Information has been Saved Successfully."
                ShowTableIntoToGrid()
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Sub

    Private Function CheckEmptyTableInfo() As Boolean
        Dim bComtrolTextEmpty As Boolean
        If Trim(txtTableCapacity.Text) = vbNullString Then
            lblmessage1.ForeColor = Color.Maroon
            lblmessage1.Text = "Please give Table Capacity."
            lblmessage1.Visible = True
            txtTableCapacity.Focus()
            bComtrolTextEmpty = True
        ElseIf Val(Trim(txtTableCapacity.Text)) < 0 Then
            lblmessage1.ForeColor = Color.Maroon
            lblmessage1.Text = "Please give positive number."
            lblmessage1.Visible = True
            txtTableCapacity.Focus()
            bComtrolTextEmpty = True
        Else
            lblmessage1.Visible = False
            bComtrolTextEmpty = False
        End If
        CheckEmptyTableInfo = bComtrolTextEmpty
    End Function

    Private Function ShowTableIntoToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsTable As DataSet
        Dim daTableInfo As SqlClient.SqlDataAdapter

        Try
            dsTable = New DataSet("Table")
            strSQL = "SELECT cTableNumber,nTable_Capacity,nTable_Id FROM tTable_Info WHERE nTableActive =1 ORDER By nTable_Id"
            daTableInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daTableInfo.Fill(dsTable, "Table")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsTable.Tables("Table").Rows.Count

        lvLookUp.Items.Clear()
        If icount > 0 Then
            For iIndex = 0 To icount - 1
                lvLookUp.Items.Add(Trim(dsTable.Tables("Table").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsTable.Tables("Table").Rows(iIndex).Item(1)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsTable.Tables("Table").Rows(iIndex).Item(2)))
            Next
        End If
    End Function

    Private Sub frmTbleInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlTableInfo)
        ShowTableIntoToGrid()
        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 10

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Table information"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Table information"
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Trim(txtTableId.Text) <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                SetEnablePropertyTrue(pnlTableInfo)
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
                txtTableNo.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlTableInfo)
                SetEnablePropertyFalse(pnlTableInfo)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblmessage1.Visible = False
            End If
        Else
            lblmessage1.Visible = True
            lblmessage1.ForeColor = Color.Maroon
            lblmessage1.Text = "* Please select a Table."
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        UpdateTableActivation()
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlTableInfo)
        ClearTextProperty(pnlTableInfo)
    End Sub

    Private Function UpdateTableActivation()
        Dim strSQLTable As String
        Dim strMessage As String = "Your Information has been Deleted Successfully"

        Dim cmdUpdateTableInfo As SqlClient.SqlCommand

        If Trim(txtTableId.Text) <> vbNullString Then
            strSQLTable = "UPDATE tTable_Info SET nTableActive = 0 WHERE nTable_Id=" & CStr(Trim(txtTableId.Text)) & ""
            Try
                cmdUpdateTableInfo = New SqlClient.SqlCommand
                cmdUpdateTableInfo.Connection = mdDBConnection.connRestuarant
                cmdUpdateTableInfo.CommandText = strSQLTable
                cmdUpdateTableInfo.ExecuteNonQuery()
                ShowTableIntoToGrid()
                lblmessage1.Visible = True
                lblmessage1.ForeColor = Color.Green
                lblmessage1.Text = "Your Information has been Deleted Successfully."
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        End If
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub txtTableCapacity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTableCapacity.TextChanged
        lblmessage1.Visible = False
    End Sub

    Private Sub txtTableCapacity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTableCapacity.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        Else
            ValidationForPositiveRoundNumaricData(e, txtTableCapacity)
        End If
    End Sub

    Private Sub txtTableId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTableId.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdd.KeyPress, btnEdit.KeyPress, btnExit.KeyPress, btnDelete.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        txtTableNo.Text = lvLookUp.SelectedItems(0).Text
        txtTableCapacity.Text = lvLookUp.SelectedItems(0).SubItems(1).Text
        txtTableId.Text = Trim(lvLookUp.SelectedItems(0).SubItems(2).Text)
        lblmessage1.Visible = False
    End Sub

    Private Sub txtTableNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTableNo.KeyPress
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
