Imports Microsoft.VisualBasic
Public Class frmItemStck
    Inherits System.Windows.Forms.Form

    Dim iItemId As Integer
    Dim sItemName As String

    Dim conControlName As Control
    Dim WithEvents objfrmKeyBoard As frmKeyBoard

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbItemStock As System.Windows.Forms.GroupBox
    Friend WithEvents cName As System.Windows.Forms.ColumnHeader
    Friend WithEvents mTakeawayPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents mDynePrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents cStck As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtDinePrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantityAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtTakeAwayPrice As System.Windows.Forms.TextBox
    Friend WithEvents lvItemStock As System.Windows.Forms.ListView
    Friend WithEvents nId As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    Friend WithEvents btnUpdateStock As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItemStck))
        Me.txtTakeAwayPrice = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDinePrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtQuantityAdd = New System.Windows.Forms.TextBox
        Me.gbItemStock = New System.Windows.Forms.GroupBox
        Me.lvItemStock = New System.Windows.Forms.ListView
        Me.cName = New System.Windows.Forms.ColumnHeader
        Me.mTakeawayPrice = New System.Windows.Forms.ColumnHeader
        Me.mDynePrice = New System.Windows.Forms.ColumnHeader
        Me.cStck = New System.Windows.Forms.ColumnHeader
        Me.nId = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New MACButtonLib.MACButton
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.btnUpdateStock = New MACButtonLib.MACButton
        Me.gbItemStock.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTakeAwayPrice
        '
        Me.txtTakeAwayPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTakeAwayPrice.Enabled = False
        Me.txtTakeAwayPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTakeAwayPrice.Location = New System.Drawing.Point(138, 398)
        Me.txtTakeAwayPrice.MaxLength = 8
        Me.txtTakeAwayPrice.Name = "txtTakeAwayPrice"
        Me.txtTakeAwayPrice.TabIndex = 3
        Me.txtTakeAwayPrice.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Takeaway Price"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DineIn Price"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDinePrice
        '
        Me.txtDinePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDinePrice.Enabled = False
        Me.txtDinePrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDinePrice.Location = New System.Drawing.Point(138, 424)
        Me.txtDinePrice.MaxLength = 8
        Me.txtDinePrice.Name = "txtDinePrice"
        Me.txtDinePrice.TabIndex = 7
        Me.txtDinePrice.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(242, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity in hand"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(394, 397)
        Me.txtQuantity.MaxLength = 10
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.TabIndex = 5
        Me.txtQuantity.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantity to be added"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantityAdd
        '
        Me.txtQuantityAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantityAdd.Enabled = False
        Me.txtQuantityAdd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantityAdd.Location = New System.Drawing.Point(394, 423)
        Me.txtQuantityAdd.MaxLength = 10
        Me.txtQuantityAdd.Name = "txtQuantityAdd"
        Me.txtQuantityAdd.TabIndex = 9
        Me.txtQuantityAdd.Text = ""
        '
        'gbItemStock
        '
        Me.gbItemStock.Controls.Add(Me.lvItemStock)
        Me.gbItemStock.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbItemStock.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbItemStock.Location = New System.Drawing.Point(8, 6)
        Me.gbItemStock.Name = "gbItemStock"
        Me.gbItemStock.Size = New System.Drawing.Size(508, 386)
        Me.gbItemStock.TabIndex = 0
        Me.gbItemStock.TabStop = False
        Me.gbItemStock.Text = "Item Stock"
        '
        'lvItemStock
        '
        Me.lvItemStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvItemStock.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cName, Me.mTakeawayPrice, Me.mDynePrice, Me.cStck, Me.nId})
        Me.lvItemStock.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvItemStock.FullRowSelect = True
        Me.lvItemStock.GridLines = True
        Me.lvItemStock.HideSelection = False
        Me.lvItemStock.Location = New System.Drawing.Point(8, 26)
        Me.lvItemStock.MultiSelect = False
        Me.lvItemStock.Name = "lvItemStock"
        Me.lvItemStock.Size = New System.Drawing.Size(492, 350)
        Me.lvItemStock.TabIndex = 1
        Me.lvItemStock.View = System.Windows.Forms.View.Details
        '
        'cName
        '
        Me.cName.Text = "Name"
        Me.cName.Width = 180
        '
        'mTakeawayPrice
        '
        Me.mTakeawayPrice.Text = "TakeawayPrice"
        Me.mTakeawayPrice.Width = 110
        '
        'mDynePrice
        '
        Me.mDynePrice.Text = "DyneInPrice"
        Me.mDynePrice.Width = 110
        '
        'cStck
        '
        Me.cStck.Text = "Stock"
        Me.cStck.Width = 90
        '
        'nId
        '
        Me.nId.Text = ""
        Me.nId.Width = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnCancel.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnCancel.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnCancel.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(324, 456)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 40)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextColorDefault = System.Drawing.Color.Black
        Me.btnCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.btnCancel.TextColorHover = System.Drawing.Color.White
        Me.btnCancel.TextColorNormal = System.Drawing.Color.White
        '
        'btnKeyBoard
        '
        Me.btnKeyBoard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeyBoard.BackColor = System.Drawing.Color.Transparent
        Me.btnKeyBoard.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnKeyBoard.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnKeyBoard.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnKeyBoard.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnKeyBoard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyBoard.Location = New System.Drawing.Point(196, 456)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(120, 40)
        Me.btnKeyBoard.TabIndex = 11
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateStock.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateStock.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnUpdateStock.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnUpdateStock.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnUpdateStock.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnUpdateStock.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStock.Location = New System.Drawing.Point(68, 456)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(120, 40)
        Me.btnUpdateStock.TabIndex = 10
        Me.btnUpdateStock.Text = "Update Stock"
        Me.btnUpdateStock.TextColorDefault = System.Drawing.Color.Black
        Me.btnUpdateStock.TextColorDisabled = System.Drawing.Color.Black
        Me.btnUpdateStock.TextColorHover = System.Drawing.Color.White
        Me.btnUpdateStock.TextColorNormal = System.Drawing.Color.White
        '
        'frmItemStck
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(522, 504)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnKeyBoard)
        Me.Controls.Add(Me.btnUpdateStock)
        Me.Controls.Add(Me.gbItemStock)
        Me.Controls.Add(Me.txtQuantityAdd)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtDinePrice)
        Me.Controls.Add(Me.txtTakeAwayPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemStck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Stock Entry"
        Me.gbItemStock.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmItemStck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillItemStock()

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Item Stock Entry"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Item Stock Entry"
        End If

    End Sub

    Private Sub lvItemStock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvItemStock.Click

        txtTakeAwayPrice.Enabled = True
        txtDinePrice.Enabled = True
        txtQuantityAdd.Enabled = True

        sItemName = lvItemStock.SelectedItems(0).Text
        iItemId = lvItemStock.SelectedItems(0).SubItems(4).Text

        If lvItemStock.SelectedItems(0).SubItems(1).Text <> "" Then
            txtTakeAwayPrice.Text = lvItemStock.SelectedItems(0).SubItems(1).Text
        Else
            txtTakeAwayPrice.Text = ""
        End If

        If lvItemStock.SelectedItems(0).SubItems(2).Text <> "" Then
            txtDinePrice.Text = lvItemStock.SelectedItems(0).SubItems(2).Text
        Else
            txtDinePrice.Text = ""
        End If

        If lvItemStock.SelectedItems(0).SubItems(3).Text <> "" Then
            txtQuantity.Text = lvItemStock.SelectedItems(0).SubItems(3).Text
        Else
            txtQuantity.Text = ""
        End If
        txtQuantityAdd.Text = ""
        txtQuantityAdd.Focus()
    End Sub

    Private Function CheckEmptyItemInfo() As Boolean
        'This method is use to find out the Empty Field for Category Information 
        Dim bComtrolTextEmpty As Boolean

        If txtTakeAwayPrice.Text = vbNullString Then
            MessageBox.Show("Please give Takeaway Price", "Item Stock Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bComtrolTextEmpty = True
            txtTakeAwayPrice.Focus()
        ElseIf txtDinePrice.Text = vbNullString Then
            MessageBox.Show("Please give Dining Price", "Item Stock Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bComtrolTextEmpty = True
            txtDinePrice.Focus()
        Else
            bComtrolTextEmpty = False
        End If
        CheckEmptyItemInfo = bComtrolTextEmpty
    End Function

    Private Sub btnUpdateStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateStock.Click
        Dim strSQL As String

        Dim iStockInHand As Integer
        Dim iQuantityAdd As Integer
        Dim iCurrentStock As Integer

        Dim cmdUpdate As SqlClient.SqlCommand


        If txtQuantity.Text = vbNullString Then
            iStockInHand = 0
        Else
            iStockInHand = txtQuantity.Text
        End If

        If txtQuantityAdd.Text = vbNullString Then
            iQuantityAdd = 0
        Else
            iQuantityAdd = txtQuantityAdd.Text
        End If

        iCurrentStock = iStockInHand + iQuantityAdd

        strSQL = "UPDATE tItem SET mTakeawayPrice=" + CStr(txtTakeAwayPrice.Text) + ",mDinePrice=" + CStr(txtDinePrice.Text) + ",nItem_Stock=" + CStr(iCurrentStock) + " WHERE nItem_Id= " + CStr(iItemId) + ""

        If CheckEmptyItemInfo() Then
            Exit Sub
        End If

        Try
            cmdUpdate = New SqlClient.SqlCommand
            cmdUpdate.Connection = mdDBConnection.connRestuarant
            cmdUpdate.CommandText = strSQL
            cmdUpdate.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        lvItemStock.Items.Clear()
        FillItemStock()
        clearTextField()

        txtTakeAwayPrice.Enabled = False
        txtDinePrice.Enabled = False
        txtQuantityAdd.Enabled = False

    End Sub

    Private Sub FillItemStock()
        Dim strSQL As String
        Dim iIndex As Integer
        Dim iCount As Integer

        Dim dsItem As DataSet
        Dim daItem As SqlClient.SqlDataAdapter

        strSQL = "SELECT nItem_Id,cItem_Name,mTakeawayPrice,mDinePrice,nItem_Stock FROM tItem"
        Try
            dsItem = New DataSet("Item")
            daItem = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daItem.Fill(dsItem, "Item")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCount = dsItem.Tables("Item").Rows.Count

        If iCount > 0 Then
            For iIndex = 0 To iCount - 1
                Me.lvItemStock.Items.Add(Trim(dsItem.Tables("Item").Rows(iIndex).Item(1)))
                If IsDBNull(dsItem.Tables("Item").Rows(iIndex).Item(2)) = True Then
                    lvItemStock.Items(iIndex).SubItems.Add("")
                    lvItemStock.Items(iIndex).SubItems.Add("")
                    lvItemStock.Items(iIndex).SubItems.Add("")
                    lvItemStock.Items(iIndex).SubItems.Add(dsItem.Tables("Item").Rows(iIndex).Item(0))
                Else
                    lvItemStock.Items(iIndex).SubItems.Add(FormatCurrency(Trim(dsItem.Tables("Item").Rows(iIndex).Item(2))))
                    lvItemStock.Items(iIndex).SubItems.Add(FormatCurrency(Trim(dsItem.Tables("Item").Rows(iIndex).Item(3))))
                    lvItemStock.Items(iIndex).SubItems.Add(dsItem.Tables("Item").Rows(iIndex).Item(4))
                    lvItemStock.Items(iIndex).SubItems.Add(dsItem.Tables("Item").Rows(iIndex).Item(0))
                End If
            Next
        Else
            MsgBox("There is no Item in Item List", "Item Stock Entry", MsgBoxStyle.Information)
        End If
        daItem = Nothing
        dsItem = Nothing
    End Sub

    Private Sub clearTextField()
        txtTakeAwayPrice.Text = vbNullString
        txtDinePrice.Text = vbNullString
        txtQuantity.Text = vbNullString
        txtQuantityAdd.Text = vbNullString
    End Sub

    Private Sub txtTakeAwayPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTakeAwayPrice.LostFocus
        If Trim(txtTakeAwayPrice.Text) <> vbNullString Then
            txtTakeAwayPrice.Text = FormatCurrency(txtTakeAwayPrice.Text)
        End If
    End Sub

    Private Sub txtDinePrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDinePrice.LostFocus
        If Trim(txtDinePrice.Text) <> vbNullString Then
            txtDinePrice.Text = FormatCurrency(txtDinePrice.Text)
        End If
    End Sub

    Private Sub btnKeyBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyBoard.Click
        If Not IsNothing(objfrmKeyBoard) Then
            If Not objfrmKeyBoard.IsDisposed Then
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

    Private Sub txtTakeAwayPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTakeAwayPrice.TextChanged
        If Trim(txtTakeAwayPrice.Text) <> vbNullString Then
            ValidationForNumaricData(txtTakeAwayPrice)
        End If
    End Sub

    Private Sub txtDinePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDinePrice.TextChanged
        If Trim(txtDinePrice.Text) <> vbNullString Then
            ValidationForNumaricData(txtDinePrice)
        End If
    End Sub

    Private Sub txtQuantityAdd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantityAdd.TextChanged
        Dim iItemQty As Integer
        If Trim(txtQuantityAdd.Text) <> vbNullString Then
            ValidationForNumaricData(txtQuantityAdd)
            If Val(Trim(txtQuantity.Text)) > 0 Then
                If (Val(Trim(txtQuantityAdd.Text)) + Val(Trim(txtQuantity.Text))) < 0 Then
                    txtQuantityAdd.Text = ""
                    txtQuantityAdd.Focus()
                    MsgBox("Your add quantity can't be smaller then " & txtQuantityAdd.Text & "." & vbCrLf & "Please give the valid quantity", MsgBoxStyle.Information, "Item Stock Update")
                End If
            End If
        End If
    End Sub

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtQuantityAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantityAdd.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        Else
            ValidationForNumaricDataFromKeyBoaer(e, txtQuantityAdd)
            If Val(Trim(txtQuantity.Text)) > 0 Then
                If (Val(Trim(txtQuantityAdd.Text)) + Val(Trim(txtQuantity.Text))) < 0 Then
                    txtQuantityAdd.Text = ""
                    txtQuantityAdd.Focus()
                    MsgBox("Your add quantity can't be smaller then " & txtQuantityAdd.Text & "." & vbCrLf & "Please give the valid quantity", MsgBoxStyle.Information, "Item Stock Update")
                End If
            End If
        End If
    End Sub

    Private Sub txtTakeAwayPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTakeAwayPrice.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        Else
            ValidationForPositiveNumaricData(e, txtTakeAwayPrice)
        End If
    End Sub

    Private Sub txtDinePrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDinePrice.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        Else
            ValidationForPositiveNumaricData(e, txtDinePrice)
        End If
    End Sub

    Private Sub Enent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnUpdateStock.KeyPress, btnKeyBoard.KeyPress, btnCancel.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
