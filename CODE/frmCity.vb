Public Class frmCity
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
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents pnlCardInfo As System.Windows.Forms.Panel
    Friend WithEvents btnSelectType As System.Windows.Forms.Button
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCardTypeId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents cCityName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCityId As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCity))
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cCityName = New System.Windows.Forms.ColumnHeader
        Me.cCityId = New System.Windows.Forms.ColumnHeader
        Me.pnlCardInfo = New System.Windows.Forms.Panel
        Me.btnSelectType = New System.Windows.Forms.Button
        Me.lblmessage = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCardTypeId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.pnlCardInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvLookUp
        '
        Me.lvLookUp.BackColor = System.Drawing.Color.Ivory
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cCityName, Me.cCityId})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(350, 10)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(180, 166)
        Me.lvLookUp.TabIndex = 12
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cCityName
        '
        Me.cCityName.Text = "City"
        Me.cCityName.Width = 180
        '
        'cCityId
        '
        Me.cCityId.Text = ""
        Me.cCityId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cCityId.Width = 0
        '
        'pnlCardInfo
        '
        Me.pnlCardInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardInfo.Controls.Add(Me.btnSelectType)
        Me.pnlCardInfo.Controls.Add(Me.lblmessage)
        Me.pnlCardInfo.Controls.Add(Me.txtCity)
        Me.pnlCardInfo.Controls.Add(Me.Label3)
        Me.pnlCardInfo.Controls.Add(Me.txtCardTypeId)
        Me.pnlCardInfo.Controls.Add(Me.Label1)
        Me.pnlCardInfo.Location = New System.Drawing.Point(11, 10)
        Me.pnlCardInfo.Name = "pnlCardInfo"
        Me.pnlCardInfo.Size = New System.Drawing.Size(322, 94)
        Me.pnlCardInfo.TabIndex = 13
        '
        'btnSelectType
        '
        Me.btnSelectType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectType.Location = New System.Drawing.Point(268, -64)
        Me.btnSelectType.Name = "btnSelectType"
        Me.btnSelectType.Size = New System.Drawing.Size(60, 36)
        Me.btnSelectType.TabIndex = 3
        Me.btnSelectType.Text = "Select"
        '
        'lblmessage
        '
        Me.lblmessage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.ForeColor = System.Drawing.Color.Maroon
        Me.lblmessage.Location = New System.Drawing.Point(10, 50)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(294, 37)
        Me.lblmessage.TabIndex = 8
        Me.lblmessage.Text = "* Please give City"
        Me.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblmessage.Visible = False
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Enabled = False
        Me.txtCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(102, 16)
        Me.txtCity.MaxLength = 25
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(210, 21)
        Me.txtCity.TabIndex = 1
        Me.txtCity.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "City "
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
        Me.Label1.Size = New System.Drawing.Size(136, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Card Type Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Location = New System.Drawing.Point(11, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 56)
        Me.Panel1.TabIndex = 14
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
        Me.btnExit.Location = New System.Drawing.Point(243, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 32)
        Me.btnExit.TabIndex = 5
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
        Me.btnDelete.Location = New System.Drawing.Point(163, 10)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 32)
        Me.btnDelete.TabIndex = 4
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
        Me.btnEdit.Location = New System.Drawing.Point(83, 10)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 32)
        Me.btnEdit.TabIndex = 3
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
        Me.btnAdd.Location = New System.Drawing.Point(6, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 32)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdd.TextColorHover = System.Drawing.Color.White
        Me.btnAdd.TextColorNormal = System.Drawing.Color.White
        '
        'frmCity
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(544, 186)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.pnlCardInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCity"
        Me.Text = "frmCity"
        Me.pnlCardInfo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function ShowCardIntoToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsCity As DataSet
        Dim daCityInfo As SqlClient.SqlDataAdapter

        Try
            dsCity = New DataSet("City")
            strSQL = "SELECT cCity,nCityId FROM tCity WHERE nActiveCity =1 ORDER By nCityId"
            daCityInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCityInfo.Fill(dsCity, "City")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        icount = dsCity.Tables("City").Rows.Count

        lvLookUp.Items.Clear()
        If icount > 0 Then
            For iIndex = 0 To icount - 1
                lvLookUp.Items.Add(Trim(dsCity.Tables("City").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsCity.Tables("City").Rows(iIndex).Item(1)))
            Next
        End If
    End Function

    Private Sub frmCardType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": City Entry Form"
        Else
            Me.Text = mdConfiguration.strResturantName & ": City Entry Form"
        End If

        MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
        SetEnablePropertyFalse(pnlCardInfo)
        ShowCardIntoToGrid()
        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 16
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        txtCity.Text = lvLookUp.SelectedItems(0).Text
        txtCardTypeId.Text = lvLookUp.SelectedItems(0).SubItems(1).Text
        lblmessage.Visible = False
    End Sub

    Private Sub Button_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnAdd.KeyPress, btnEdit.KeyPress, btnDelete.KeyPress, btnExit.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCardTypeName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCity.KeyPress
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
        ElseIf btnAdd.Text = "Save" Then
            If Trim(txtCity.Text) <> vbNullString Then

                strSQLInsert = "INSERT INTO tCity(cCity,nActiveCity,cUserId,cTerminal,dAccessTime) " & _
                               "VALUES('" & Trim(txtCity.Text) & "',1,'" & user & "','" & sTerminal & "',GETDATE())"

                strSQLUpdate = "UPDATE tCity SET cCity='" & Trim(txtCity.Text) & "' ,cUserId='" & user _
                               & "',cTerminal='" & sTerminal & "',dAccessTime=GETDATE() " & _
                               " WHERE nCityId=" & CStr(txtCardTypeId.Text) & ""

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
                txtCity.Focus()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Trim(txtCardTypeId.Text) <> vbNullString Then
            If btnEdit.Text = "Edit" Then
                SetEnablePropertyTrue(pnlCardInfo)
                MoveButtonAtSaveMode(btnAdd, btnEdit, btnDelete, btnExit)
            ElseIf btnEdit.Text = "Cancel" Then
                ClearTextProperty(pnlCardInfo)
                SetEnablePropertyFalse(pnlCardInfo)
                MoveButtonAtNormalMode(btnAdd, btnEdit, btnDelete, btnExit)
                lblmessage.Visible = False
            End If
        Else
            lblmessage.Visible = True
            lblmessage.ForeColor = Color.Maroon
            lblmessage.Text = "* Please select City."
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

            strSQLTable = "UPDATE tCity SET nActiveCity = 0 WHERE nCityId=" & CStr(Trim(txtCardTypeId.Text)) & ""

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
End Class
