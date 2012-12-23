Public Class frmCardType
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
    Friend WithEvents btnSelectType As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents txtCardTypeName As System.Windows.Forms.TextBox
    Friend WithEvents txtCardTypeId As System.Windows.Forms.TextBox
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cCardId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCardName As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlCardInfo As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCardType))
        Me.pnlCardInfo = New System.Windows.Forms.Panel
        Me.btnSelectType = New System.Windows.Forms.Button
        Me.lblmessage = New System.Windows.Forms.Label
        Me.txtCardTypeName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCardTypeId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cCardName = New System.Windows.Forms.ColumnHeader
        Me.cCardId = New System.Windows.Forms.ColumnHeader
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.pnlCardInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCardInfo
        '
        Me.pnlCardInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardInfo.Controls.Add(Me.btnSelectType)
        Me.pnlCardInfo.Controls.Add(Me.lblmessage)
        Me.pnlCardInfo.Controls.Add(Me.txtCardTypeName)
        Me.pnlCardInfo.Controls.Add(Me.Label3)
        Me.pnlCardInfo.Controls.Add(Me.txtCardTypeId)
        Me.pnlCardInfo.Controls.Add(Me.Label1)
        Me.pnlCardInfo.Location = New System.Drawing.Point(11, 10)
        Me.pnlCardInfo.Name = "pnlCardInfo"
        Me.pnlCardInfo.Size = New System.Drawing.Size(325, 99)
        Me.pnlCardInfo.TabIndex = 1
        '
        'btnSelectType
        '
        Me.btnSelectType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectType.Location = New System.Drawing.Point(268, -64)
        Me.btnSelectType.Name = "btnSelectType"
        Me.btnSelectType.Size = New System.Drawing.Size(60, 38)
        Me.btnSelectType.TabIndex = 3
        Me.btnSelectType.Text = "Select"
        '
        'lblmessage
        '
        Me.lblmessage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.ForeColor = System.Drawing.Color.Maroon
        Me.lblmessage.Location = New System.Drawing.Point(10, 50)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(294, 37)
        Me.lblmessage.TabIndex = 4
        Me.lblmessage.Text = "* Please give Card Type"
        Me.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblmessage.Visible = False
        '
        'txtCardTypeName
        '
        Me.txtCardTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardTypeName.Enabled = False
        Me.txtCardTypeName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardTypeName.Location = New System.Drawing.Point(102, 16)
        Me.txtCardTypeName.MaxLength = 25
        Me.txtCardTypeName.Name = "txtCardTypeName"
        Me.txtCardTypeName.Size = New System.Drawing.Size(210, 22)
        Me.txtCardTypeName.TabIndex = 3
        Me.txtCardTypeName.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Card Type"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCardTypeId
        '
        Me.txtCardTypeId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCardTypeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardTypeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardTypeId.Location = New System.Drawing.Point(160, -48)
        Me.txtCardTypeId.Name = "txtCardTypeId"
        Me.txtCardTypeId.ReadOnly = True
        Me.txtCardTypeId.Size = New System.Drawing.Size(104, 23)
        Me.txtCardTypeId.TabIndex = 2
        Me.txtCardTypeId.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, -48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 38)
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
        Me.Panel1.Location = New System.Drawing.Point(11, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 80)
        Me.Panel1.TabIndex = 5
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
        Me.btnExit.Location = New System.Drawing.Point(244, 12)
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
        Me.btnDelete.Location = New System.Drawing.Point(164, 12)
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
        Me.btnEdit.Location = New System.Drawing.Point(88, 12)
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
        Me.btnAdd.Location = New System.Drawing.Point(8, 12)
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
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cCardName, Me.cCardId})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(352, 10)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(180, 190)
        Me.lvLookUp.TabIndex = 0
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cCardName
        '
        Me.cCardName.Text = "Card Type"
        Me.cCardName.Width = 180
        '
        'cCardId
        '
        Me.cCardId.Text = "Table Id"
        Me.cCardId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cCardId.Width = 0
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
        Me.btnKeyBoard.TabIndex = 73
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'frmCardType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(544, 214)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.pnlCardInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCardType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Type Entry Form "
        Me.pnlCardInfo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function ShowCardIntoToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsCard As DataSet
        Dim daCardInfo As SqlClient.SqlDataAdapter

        Try
            dsCard = New DataSet("Card")
            strSQL = "SELECT cCardType,nCardId FROM tCard_Info WHERE nCardActive =1 ORDER By nCardId"
            daCardInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCardInfo.Fill(dsCard, "Card")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsCard.Tables("Card").Rows.Count

        lvLookUp.Items.Clear()
        If icount > 0 Then
            For iIndex = 0 To icount - 1
                lvLookUp.Items.Add(Trim(dsCard.Tables("Card").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsCard.Tables("Card").Rows(iIndex).Item(1)))
            Next
        End If
    End Function

    Private Sub frmCardType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Card Type Entry Form"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Card Type Entry Form"
        End If

        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlCardInfo)
        ShowCardIntoToGrid()
        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 16
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        txtCardTypeName.Text = lvLookUp.SelectedItems(0).Text
        txtCardTypeId.Text = lvLookUp.SelectedItems(0).SubItems(1).Text
        lblmessage.Visible = False
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
    End Sub

    Private Sub btnAdd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdd.KeyPress, btnEdit.KeyPress, btnDelete.KeyPress, btnExit.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCardTypeName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardTypeName.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim strSQLInsert As String
        Dim strSQLUpdate As String

        Dim cmdInsert As SqlClient.SqlCommand

        If btnAdd.Text = "Add" Then
            lblmessage.Visible = False
            ClearTextProperty(pnlCardInfo)
            SetEnablePropertyTrue(pnlCardInfo)
            MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
            txtCardTypeName.Focus()
        ElseIf btnAdd.Text = "Save" Then
            If Trim(txtCardTypeName.Text) <> vbNullString Then

                strSQLInsert = "INSERT INTO tCard_Info(cCardType,nCardActive,cUserId,cTerminal,dAccessTime) " & _
                               "VALUES('" & Replace(Trim(txtCardTypeName.Text), "'", "''") & "',1,'" & user & "','" & sTerminal & "',GETDATE())"

                strSQLUpdate = "UPDATE tCard_Info SET cCardType='" & Replace(Trim(txtCardTypeName.Text), "'", "''") & "' ,cUserId='" & user _
                               & "',cTerminal='" & sTerminal & "',dAccessTime=GETDATE() " & _
                               " WHERE nCardId=" & CStr(txtCardTypeId.Text) & ""

                Try
                    cmdInsert = New SqlClient.SqlCommand
                    cmdInsert.Connection = mdDBConnection.connRestuarant
                    If Trim(txtCardTypeId.Text) <> vbNullString Then
                        cmdInsert.CommandText = strSQLUpdate
                    Else
                        cmdInsert.CommandText = strSQLInsert
                    End If

                    cmdInsert.ExecuteNonQuery()
                    MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                    SetEnablePropertyFalse(pnlCardInfo)
                    ClearTextProperty(pnlCardInfo)
                    lblmessage.Visible = True
                    lblmessage.ForeColor = Color.Green
                    lblmessage.Text = "Your Information has been Saved Successfully."
                    ShowCardIntoToGrid()
                Catch ex As Exception
                    MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                End Try
            Else
                lblmessage.Visible = True
                lblmessage.ForeColor = Color.Maroon
                lblmessage.Text = "* Please give card type."
                txtCardTypeName.Focus()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Trim(txtCardTypeId.Text) <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                SetEnablePropertyTrue(pnlCardInfo)
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
                txtCardTypeName.Focus()
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlCardInfo)
                SetEnablePropertyFalse(pnlCardInfo)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblmessage.Visible = False
            End If
        Else
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please select Card Type."
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        UpdateCardActivation()
        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlCardInfo)
        ClearTextProperty(pnlCardInfo)
    End Sub

    Private Function UpdateCardActivation()
        Dim strSQLTable As String
        Dim cmdUpdateTableInfo As SqlClient.SqlCommand

        If Trim(txtCardTypeId.Text) <> vbNullString Then

            strSQLTable = "UPDATE tCard_Info SET nCardActive = 0 WHERE nCardId=" & CStr(Trim(txtCardTypeId.Text)) & ""

            Try
                cmdUpdateTableInfo = New SqlClient.SqlCommand
                cmdUpdateTableInfo.Connection = mdDBConnection.connRestuarant
                cmdUpdateTableInfo.CommandText = strSQLTable
                cmdUpdateTableInfo.ExecuteNonQuery()
                ShowCardIntoToGrid()
                lblmessage.Visible = True
                lblmessage.ForeColor = Color.Green
                lblmessage.Text = "Your Information has been Deleted Successfully."
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        Else
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "Please select a Card Type."
        End If
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
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
