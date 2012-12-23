Public Class frmTopping
    Inherits System.Windows.Forms.Form
    Dim bCboLoad As Boolean
    Dim conControlName As Control
    Dim objfrmdine As frmDine
    Dim mainprice As Double
    Dim typeName As String
    Dim typePrice As Double
    Dim cboins As String
    Dim E As Integer



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
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cTypeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTypeSC As System.Windows.Forms.ColumnHeader
    Friend WithEvents cTypeId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboInstruction As System.Windows.Forms.ComboBox
    Friend WithEvents btnSelectItem As System.Windows.Forms.Button
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbTopping1 As System.Windows.Forms.Label
    Friend WithEvents pnlItem As System.Windows.Forms.Panel
    Friend WithEvents lbITem As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.txtTypeID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTypeName = New System.Windows.Forms.TextBox
        Me.lblMessage1 = New System.Windows.Forms.Label
        Me.btnSelectType = New System.Windows.Forms.Button
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cTypeName = New System.Windows.Forms.ColumnHeader
        Me.cTypeSC = New System.Windows.Forms.ColumnHeader
        Me.cTypeId = New System.Windows.Forms.ColumnHeader
        Me.cboInstruction = New System.Windows.Forms.ComboBox
        Me.btnSelectItem = New System.Windows.Forms.Button
        Me.txtItemId = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbTopping1 = New System.Windows.Forms.Label
        Me.pnlItem = New System.Windows.Forms.Panel
        Me.lbITem = New System.Windows.Forms.Label
        Me.pnlItem.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(244, 432)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 48)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextColorDefault = System.Drawing.Color.Black
        Me.btnExit.TextColorDisabled = System.Drawing.Color.Black
        Me.btnExit.TextColorHover = System.Drawing.Color.White
        Me.btnExit.TextColorNormal = System.Drawing.Color.White
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
        Me.btnAdd.Location = New System.Drawing.Point(155, 431)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 48)
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
        Me.Label3.Size = New System.Drawing.Size(72, 55)
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
        Me.lblMessage1.Size = New System.Drawing.Size(175, 48)
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
        Me.btnSelectType.Size = New System.Drawing.Size(48, 52)
        Me.btnSelectType.TabIndex = 2
        Me.btnSelectType.Text = "Select"
        Me.btnSelectType.Visible = False
        '
        'lvLookUp
        '
        Me.lvLookUp.BackColor = System.Drawing.Color.Ivory
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cTypeName, Me.cTypeSC, Me.cTypeId})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(2, 75)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(296, 328)
        Me.lvLookUp.TabIndex = 22
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cTypeName
        '
        Me.cTypeName.Text = "Type Name"
        Me.cTypeName.Width = 155
        '
        'cTypeSC
        '
        Me.cTypeSC.Text = "Type Price"
        Me.cTypeSC.Width = 140
        '
        'cTypeId
        '
        Me.cTypeId.Width = 0
        '
        'cboInstruction
        '
        Me.cboInstruction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstruction.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInstruction.ItemHeight = 15
        Me.cboInstruction.Items.AddRange(New Object() {"Kitchen", "Bar"})
        Me.cboInstruction.Location = New System.Drawing.Point(120, 48)
        Me.cboInstruction.Name = "cboInstruction"
        Me.cboInstruction.Size = New System.Drawing.Size(176, 23)
        Me.cboInstruction.TabIndex = 18
        '
        'btnSelectItem
        '
        Me.btnSelectItem.BackColor = System.Drawing.Color.Ivory
        Me.btnSelectItem.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSelectItem.Location = New System.Drawing.Point(424, 10)
        Me.btnSelectItem.Name = "btnSelectItem"
        Me.btnSelectItem.Size = New System.Drawing.Size(48, 20)
        Me.btnSelectItem.TabIndex = 5
        Me.btnSelectItem.Text = "Select"
        Me.btnSelectItem.Visible = False
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
        Me.Label11.BackColor = System.Drawing.Color.Ivory
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-160, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 20)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Item ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'lbTopping1
        '
        Me.lbTopping1.BackColor = System.Drawing.Color.Ivory
        Me.lbTopping1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTopping1.Location = New System.Drawing.Point(8, 48)
        Me.lbTopping1.Name = "lbTopping1"
        Me.lbTopping1.Size = New System.Drawing.Size(108, 17)
        Me.lbTopping1.TabIndex = 17
        Me.lbTopping1.Text = "Instruction"
        Me.lbTopping1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlItem
        '
        Me.pnlItem.BackColor = System.Drawing.Color.Ivory
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Controls.Add(Me.lvLookUp)
        Me.pnlItem.Controls.Add(Me.cboInstruction)
        Me.pnlItem.Controls.Add(Me.btnSelectItem)
        Me.pnlItem.Controls.Add(Me.txtItemId)
        Me.pnlItem.Controls.Add(Me.Label11)
        Me.pnlItem.Controls.Add(Me.lbTopping1)
        Me.pnlItem.Controls.Add(Me.lbITem)
        Me.pnlItem.Location = New System.Drawing.Point(22, 13)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(298, 411)
        Me.pnlItem.TabIndex = 2
        '
        'lbITem
        '
        Me.lbITem.BackColor = System.Drawing.Color.Ivory
        Me.lbITem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbITem.Location = New System.Drawing.Point(64, 8)
        Me.lbITem.Name = "lbITem"
        Me.lbITem.Size = New System.Drawing.Size(168, 24)
        Me.lbITem.TabIndex = 17
        Me.lbITem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTopping
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(330, 487)
        Me.Controls.Add(Me.btnSelectType)
        Me.Controls.Add(Me.lblMessage1)
        Me.Controls.Add(Me.txtTypeName)
        Me.Controls.Add(Me.txtTypeID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlItem)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTopping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Topping"
        Me.pnlItem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Function frmTopping(ByRef objDine As frmDine)
        objfrmdine = objDine
    End Function

    Private Sub frmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 2
        Me.Top = 30
        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Add Topping "
        Else
            Me.Text = mdConfiguration.strResturantName & ": Add Topping "
        End If

        bCboLoad = True
        FillInstructionCombo()
        ShowToppingInfoToGrid()
        bCboLoad = False
        'MoveButtonAtNormalMode(btnAdd, btnExit)
        'SetEnablePropertyFalse(pnlItem)
        'cboMeasurementUnit.Enabled = False
        'cboItemLocation.Enabled = False
    End Sub

    Public Function IteamCollect(ByRef Item As String, ByRef Price As Double, ByRef ItemId As Integer)
        Dim b As String
        b = Item
        lbITem.Text = b
        lbITem.ForeColor = Color.Green
        mainprice = Price
        E = ItemId
    End Function

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If mdValidation.IsTextEditableControl(conControlName) = True Then
            IsEnterPress(conControlName)
            conControlName.Text += sender.Text
        End If

    End Sub

    Public Function addtoping()

        Dim TopIteam As String
        Dim TopIns As String

        If typeName <> vbNullString Then
            'objfrmdine.lvOrder.SelectedItems(0).SubItems(3).Text = txtPrice.Text
            objfrmdine.lvOrder.SelectedItems(0).SubItems(3).Text = mainprice + typePrice
            If cboins = vbNullString Then
                objfrmdine.lvOrder.SelectedItems(0).SubItems(4).Text = typeName
            Else
                objfrmdine.lvOrder.SelectedItems(0).SubItems(4).Text = typeName + "& " + cboins
            End If
            objfrmdine.CalculateTopingPrice()
        Else
            MsgBox("Item not Selected")
            'objfrmdine.lvOrder.SelectedItems(0).SubItems(3).Text = mainprice
            'objfrmdine.CalculateTopingPrice()
        End If

    End Function

    Private Sub MacButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        conControlName.Text = vbNullString
    End Sub

    Private Sub MacButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If conControlName.Focus() = True And conControlName.Text <> vbNullString Then
            CalculateResult(conControlName)
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        addtoping()
        Me.Dispose()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Function FillInstructionCombo()
        Dim iCountDataSetRow As Integer
        Dim strSQL As String

        Dim dsInstruction As DataSet
        Dim daInstruction As SqlClient.SqlDataAdapter


        strSQL = "SELECT nInstruction_Id,cInstruction FROM tInstruction WHERE nItem_Id=0 AND nActiveInstruction=1 ORDER BY cInstruction"
        Try
            dsInstruction = New DataSet("Instruction")
            daInstruction = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daInstruction.Fill(dsInstruction, "Instruction")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        cboInstruction.DataSource = Nothing
        cboInstruction.Items.Clear()

        iCountDataSetRow = dsInstruction.Tables("Instruction").Rows.Count
        If iCountDataSetRow > 0 Then
            cboInstruction.DataSource = dsInstruction.Tables("Instruction")
            cboInstruction.DisplayMember = "cInstruction"
            cboInstruction.SelectedIndex = -1
        End If
    End Function

    Private Sub lvLookUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLookUp.Click

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

            '    txtTopId.Text = dsItemN.Tables("Itemmm").Rows(0).Item(0)
            typeName = dsItemN.Tables("Itemmm").Rows(0).Item(1)   'To Show Type Name
            typePrice = FormatCurrency(dsItemN.Tables("Itemmm").Rows(0).Item(2)) & vbNullString 'To Show Type Price

        End If

    End Sub

    Private Function ShowToppingInfoToGrid()
        Dim icount As Integer
        Dim iIndex As Integer

        Dim strSQL As String

        Dim dsTopping As DataSet
        Dim daToppingInfo As SqlClient.SqlDataAdapter


        Try
            dsTopping = New DataSet("Item")
            strSQL = "SELECT cTop_Name,cTop_Price,nTop_Id FROM tTopping WHERE tTopType_Id =" & E & " And nActiveTop=1 "
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

    Private Sub cboInstruction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInstruction.SelectedIndexChanged
        cboins = cboInstruction.Text
    End Sub

End Class

