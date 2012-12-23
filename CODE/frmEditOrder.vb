Imports System.Globalization

Public Class frmEditOrder
    Inherits System.Windows.Forms.Form

    Public strFromDate As String
    Public strToDate As String
    Public iOrderId As Integer

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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents txtTips As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cItemName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cItemQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents cItemId As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnEdit As MACButtonLib.MACButton
    Friend WithEvents btnReduceItem As MACButtonLib.MACButton
    Friend WithEvents btnRemoveItem As MACButtonLib.MACButton
    Friend WithEvents btnNextOrder As MACButtonLib.MACButton
    Friend WithEvents btnPreviousOrder As MACButtonLib.MACButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboOrderId As System.Windows.Forms.ComboBox
    Friend WithEvents gbPriceInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefresh As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEditOrder))
        Me.gbPriceInfo = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboOrderId = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtNetPay = New System.Windows.Forms.TextBox
        Me.txtTips = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotalPrice = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnReduceItem = New MACButtonLib.MACButton
        Me.btnRemoveItem = New MACButtonLib.MACButton
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cItemName = New System.Windows.Forms.ColumnHeader
        Me.cItemQty = New System.Windows.Forms.ColumnHeader
        Me.cPrice = New System.Windows.Forms.ColumnHeader
        Me.cItemId = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnRefresh = New MACButtonLib.MACButton
        Me.btnNextOrder = New MACButtonLib.MACButton
        Me.btnPreviousOrder = New MACButtonLib.MACButton
        Me.btnExit = New MACButtonLib.MACButton
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnEdit = New MACButtonLib.MACButton
        Me.gbPriceInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPriceInfo
        '
        Me.gbPriceInfo.Controls.Add(Me.Label1)
        Me.gbPriceInfo.Controls.Add(Me.cboOrderId)
        Me.gbPriceInfo.Controls.Add(Me.Label16)
        Me.gbPriceInfo.Controls.Add(Me.Label38)
        Me.gbPriceInfo.Controls.Add(Me.Label17)
        Me.gbPriceInfo.Controls.Add(Me.txtNetPay)
        Me.gbPriceInfo.Controls.Add(Me.txtTips)
        Me.gbPriceInfo.Controls.Add(Me.txtDiscount)
        Me.gbPriceInfo.Controls.Add(Me.Label12)
        Me.gbPriceInfo.Controls.Add(Me.txtTotalPrice)
        Me.gbPriceInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbPriceInfo.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPriceInfo.ForeColor = System.Drawing.Color.Maroon
        Me.gbPriceInfo.Location = New System.Drawing.Point(11, 12)
        Me.gbPriceInfo.Name = "gbPriceInfo"
        Me.gbPriceInfo.Size = New System.Drawing.Size(252, 324)
        Me.gbPriceInfo.TabIndex = 2
        Me.gbPriceInfo.TabStop = False
        Me.gbPriceInfo.Text = "Price Information"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(20, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Order Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'cboOrderId
        '
        Me.cboOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrderId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrderId.Location = New System.Drawing.Point(128, 82)
        Me.cboOrderId.Name = "cboOrderId"
        Me.cboOrderId.Size = New System.Drawing.Size(104, 23)
        Me.cboOrderId.TabIndex = 64
        Me.cboOrderId.Visible = False
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(20, 185)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 22)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "Service Charge"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label38.BackColor = System.Drawing.Color.Ivory
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(20, 152)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(103, 22)
        Me.Label38.TabIndex = 62
        Me.Label38.Text = "Discount"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(20, 217)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 22)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Net Pay"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNetPay
        '
        Me.txtNetPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNetPay.BackColor = System.Drawing.Color.White
        Me.txtNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetPay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.Location = New System.Drawing.Point(128, 217)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(104, 21)
        Me.txtNetPay.TabIndex = 61
        Me.txtNetPay.Text = ""
        Me.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTips
        '
        Me.txtTips.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTips.BackColor = System.Drawing.Color.White
        Me.txtTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTips.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTips.Location = New System.Drawing.Point(128, 185)
        Me.txtTips.MaxLength = 8
        Me.txtTips.Name = "txtTips"
        Me.txtTips.Size = New System.Drawing.Size(104, 21)
        Me.txtTips.TabIndex = 60
        Me.txtTips.Text = ""
        Me.txtTips.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDiscount.BackColor = System.Drawing.Color.White
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(128, 152)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(104, 21)
        Me.txtDiscount.TabIndex = 59
        Me.txtDiscount.Text = ""
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(20, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 22)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Total Price"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalPrice.BackColor = System.Drawing.Color.White
        Me.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPrice.Location = New System.Drawing.Point(128, 117)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(104, 21)
        Me.txtTotalPrice.TabIndex = 57
        Me.txtTotalPrice.Text = ""
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReduceItem)
        Me.GroupBox2.Controls.Add(Me.btnRemoveItem)
        Me.GroupBox2.Controls.Add(Me.lvLookUp)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(277, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 324)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Information"
        '
        'btnReduceItem
        '
        Me.btnReduceItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReduceItem.BackColor = System.Drawing.Color.Transparent
        Me.btnReduceItem.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnReduceItem.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnReduceItem.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnReduceItem.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnReduceItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReduceItem.Location = New System.Drawing.Point(11, 273)
        Me.btnReduceItem.Name = "btnReduceItem"
        Me.btnReduceItem.Size = New System.Drawing.Size(136, 37)
        Me.btnReduceItem.TabIndex = 37
        Me.btnReduceItem.Text = "Reduce Item Qty"
        Me.btnReduceItem.TextColorDefault = System.Drawing.Color.Black
        Me.btnReduceItem.TextColorDisabled = System.Drawing.Color.Black
        Me.btnReduceItem.TextColorHover = System.Drawing.Color.White
        Me.btnReduceItem.TextColorNormal = System.Drawing.Color.White
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRemoveItem.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveItem.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnRemoveItem.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnRemoveItem.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnRemoveItem.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnRemoveItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.Location = New System.Drawing.Point(153, 273)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(138, 37)
        Me.btnRemoveItem.TabIndex = 36
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.TextColorDefault = System.Drawing.Color.Black
        Me.btnRemoveItem.TextColorDisabled = System.Drawing.Color.Black
        Me.btnRemoveItem.TextColorHover = System.Drawing.Color.White
        Me.btnRemoveItem.TextColorNormal = System.Drawing.Color.White
        '
        'lvLookUp
        '
        Me.lvLookUp.BackColor = System.Drawing.Color.Ivory
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cItemName, Me.cItemQty, Me.cPrice, Me.cItemId})
        Me.lvLookUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(11, 24)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(280, 236)
        Me.lvLookUp.TabIndex = 8
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cItemName
        '
        Me.cItemName.Text = "Item "
        Me.cItemName.Width = 140
        '
        'cItemQty
        '
        Me.cItemQty.Text = "Quantity"
        Me.cItemQty.Width = 70
        '
        'cPrice
        '
        Me.cPrice.Text = "Price"
        Me.cPrice.Width = 70
        '
        'cItemId
        '
        Me.cItemId.Text = ""
        Me.cItemId.Width = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnNextOrder)
        Me.Panel1.Controls.Add(Me.btnPreviousOrder)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Location = New System.Drawing.Point(11, 347)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 117)
        Me.Panel1.TabIndex = 12
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnRefresh.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnRefresh.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnRefresh.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnRefresh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(192, 56)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(136, 48)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextColorDefault = System.Drawing.Color.Black
        Me.btnRefresh.TextColorDisabled = System.Drawing.Color.Black
        Me.btnRefresh.TextColorHover = System.Drawing.Color.White
        Me.btnRefresh.TextColorNormal = System.Drawing.Color.White
        '
        'btnNextOrder
        '
        Me.btnNextOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNextOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnNextOrder.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnNextOrder.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnNextOrder.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnNextOrder.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnNextOrder.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextOrder.Location = New System.Drawing.Point(396, 16)
        Me.btnNextOrder.Name = "btnNextOrder"
        Me.btnNextOrder.Size = New System.Drawing.Size(156, 32)
        Me.btnNextOrder.TabIndex = 7
        Me.btnNextOrder.Text = "Next Order>>"
        Me.btnNextOrder.TextColorDefault = System.Drawing.Color.Black
        Me.btnNextOrder.TextColorDisabled = System.Drawing.Color.Black
        Me.btnNextOrder.TextColorHover = System.Drawing.Color.White
        Me.btnNextOrder.TextColorNormal = System.Drawing.Color.White
        '
        'btnPreviousOrder
        '
        Me.btnPreviousOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPreviousOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnPreviousOrder.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnPreviousOrder.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnPreviousOrder.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnPreviousOrder.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnPreviousOrder.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousOrder.Location = New System.Drawing.Point(237, 16)
        Me.btnPreviousOrder.Name = "btnPreviousOrder"
        Me.btnPreviousOrder.Size = New System.Drawing.Size(156, 32)
        Me.btnPreviousOrder.TabIndex = 6
        Me.btnPreviousOrder.Text = "<< Previous Order"
        Me.btnPreviousOrder.TextColorDefault = System.Drawing.Color.Black
        Me.btnPreviousOrder.TextColorDisabled = System.Drawing.Color.Black
        Me.btnPreviousOrder.TextColorHover = System.Drawing.Color.White
        Me.btnPreviousOrder.TextColorNormal = System.Drawing.Color.White
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
        Me.btnExit.Location = New System.Drawing.Point(164, 16)
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
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(84, 16)
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
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(4, 16)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 32)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextColorDefault = System.Drawing.Color.Black
        Me.btnEdit.TextColorDisabled = System.Drawing.Color.Black
        Me.btnEdit.TextColorHover = System.Drawing.Color.White
        Me.btnEdit.TextColorNormal = System.Drawing.Color.White
        '
        'frmEditOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbPriceInfo)
        Me.MaximizeBox = False
        Me.Name = "frmEditOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditOrder"
        Me.gbPriceInfo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        Dim iItemCount As Integer
        Dim lvOrderItem As ListViewItem

        iItemCount = lvLookUp.Items.Count

        If iItemCount > 1 Then
            For Each lvOrderItem In lvLookUp.SelectedItems
                Me.lvLookUp.Items.Remove(lvOrderItem)
                CalculateTotalPrice()
            Next
        End If
    End Sub

    Private Sub btnReduceItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReduceItem.Click
        Dim iItemCount As Integer
        Dim iItemQty As Integer
        Dim dTotalPrice As Double
        Dim dUnitPrice As Double
        Dim lvOrderItem As ListViewItem

        iItemCount = lvLookUp.Items.Count
        If iItemCount > 1 Then
            For Each lvOrderItem In lvLookUp.SelectedItems
                iItemQty = lvOrderItem.SubItems(1).Text
                dTotalPrice = Decimal.Parse(Trim(lvOrderItem.SubItems(2).Text), NumberStyles.Currency)
                dUnitPrice = dTotalPrice / iItemQty
                lvOrderItem.SubItems(1).Text = CStr(iItemQty - 1)
                lvOrderItem.SubItems(2).Text = Val(Trim(lvOrderItem.SubItems(1).Text)) * dUnitPrice
                If iItemQty = 1 Then
                    Me.lvLookUp.Items.Remove(lvOrderItem)
                End If
            Next
        Else
            For Each lvOrderItem In lvLookUp.SelectedItems
                iItemQty = lvOrderItem.SubItems(1).Text
                If iItemQty > 1 Then
                    dTotalPrice = Decimal.Parse(Trim(lvOrderItem.SubItems(2).Text), NumberStyles.Currency)
                    dUnitPrice = dTotalPrice / iItemQty
                    lvOrderItem.SubItems(1).Text = CStr(iItemQty - 1)
                    lvOrderItem.SubItems(2).Text = Val(Trim(lvOrderItem.SubItems(1).Text)) * dUnitPrice
                End If
            Next
        End If
        CalculateTotalPrice()
    End Sub

    Private Function CalculateDiscount() As Double
        Dim dTotalPrice As Double
        Dim dDiscount As Double
        Dim dDiscounInPercent As Double

        dTotalPrice = txtTotalPrice.Text
        dDiscount = txtDiscount.Text
        dDiscounInPercent = (dDiscount * 100) / dTotalPrice
        CalculateDiscount = dDiscounInPercent
    End Function

    Private Function CalculateTips() As Double
        Dim dTotalPrice As Double
        Dim dTips As Double
        Dim dTipsInPercent As Double

        dTotalPrice = txtTotalPrice.Text
        dTips = txtTips.Text
        dTipsInPercent = (dTips * 100) / dTotalPrice
        CalculateTips = dTipsInPercent
    End Function

    Private Function ShowPaymentInfo()
        Dim iItemCount As Integer
        Dim iIndex As Integer
        Dim strSQL As String
        Dim dsOrder As DataSet
        Dim daOrder As SqlClient.SqlDataAdapter

        strSQL = "SELECT mTotalPrice,mDiscount,mService_Charge,mNetpay,nCust_Id,nTable_Id FROM tOrder_Payment " & _
                 "WHERE nOrder_Id=" & CStr(Trim(cboOrderId.Text)) & ""
        Try
            dsOrder = New DataSet("Payment")
            daOrder = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daOrder.Fill(dsOrder, "Payment")
            iItemCount = dsOrder.Tables("Payment").Rows.Count
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        If iItemCount > 0 Then
            For iIndex = 0 To iItemCount - 1
                txtTotalPrice.Text = FormatCurrency(Trim(dsOrder.Tables("Payment").Rows(iIndex).Item(0)))
                txtDiscount.Text = FormatCurrency(Trim(dsOrder.Tables("Payment").Rows(iIndex).Item(1)))
                txtDiscount.Tag = CalculateDiscount()
                txtTips.Text = FormatCurrency(Trim(dsOrder.Tables("Payment").Rows(iIndex).Item(2)))
                txtTips.Tag = CalculateTips()
                txtNetPay.Text = FormatCurrency(Trim(dsOrder.Tables("Payment").Rows(iIndex).Item(3)))
                txtTotalPrice.Tag = Trim(dsOrder.Tables("Payment").Rows(iIndex).Item(4))
                txtNetPay.Tag = Trim(dsOrder.Tables("Payment").Rows(iIndex).Item(5))
            Next
        Else
            ClearTextProperty(gbPriceInfo)
            cboOrderId.SelectedIndex = -1
            Me.Dispose()
        End If
    End Function

    Private Function SetDiscount()
        Dim dTotalPrice As Double
        Dim dDiscout As Double
        Dim dDiscountedAmount As Double

        dTotalPrice = Trim(txtTotalPrice.Text)
        dDiscout = Trim(txtDiscount.Tag)
        If dDiscout > 0 Then
            dDiscountedAmount = dTotalPrice / dDiscout
        Else
            dDiscountedAmount = 0
        End If

        txtDiscount.Text = FormatCurrency(dDiscountedAmount)
    End Function

    Private Function SetTips()
        Dim dTotalPrice As Double
        Dim dTips As Double
        Dim dTipsAmount As Double

        dTotalPrice = Trim(txtTotalPrice.Text)
        dTips = Trim(txtTips.Tag)
        If dTips > 0 Then
            dTipsAmount = dTotalPrice / dTips
        Else
            dTipsAmount = 0
        End If

        txtTips.Text = FormatCurrency(dTipsAmount)
    End Function

    Private Function CalculateTotalPrice()
        Dim iIndex As Integer
        Dim iLVRowCount As Integer
        Dim dTotalPrice As Double
        Dim dDiscount As Double
        Dim dTips As Double
        Dim dNetPay As Double

        iLVRowCount = lvLookUp.Items.Count
        If iLVRowCount > 0 Then
            For iIndex = 0 To iLVRowCount - 1
                dTotalPrice += Val(Trim(lvLookUp.Items(iIndex).SubItems(2).Text))
            Next
        End If
        txtTotalPrice.Text = FormatCurrency(dTotalPrice)

        SetDiscount()
        SetTips()

        dDiscount = txtDiscount.Text
        dTips = txtTips.Text
        dNetPay = dTotalPrice + dTips - dDiscount
        txtNetPay.Text = FormatCurrency(dNetPay)

    End Function

    Private Function ShowOrderedItemInfo()
        Dim iItemCount As Integer
        Dim iIndex As Integer
        Dim strSQL As String
        Dim dsOrder As DataSet
        Dim daOrder As SqlClient.SqlDataAdapter

        strSQL = "SELECT I.cItem_Name,O.nItem_Qty,O.mUnitPrice,O.nItem_Id FROM tOrdered_Item AS O,tItem AS I " & _
                 "WHERE O.nOrder_Id=" & CStr(Trim(cboOrderId.Text)) & " AND I.nItem_Id=O.nItem_Id"

        Try
            dsOrder = New DataSet("Item")
            daOrder = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daOrder.Fill(dsOrder, "Item")
            iItemCount = dsOrder.Tables("Item").Rows.Count
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        lvLookUp.Items.Clear()

        If iItemCount > 0 Then
            For iIndex = 0 To iItemCount - 1
                lvLookUp.Items.Add(Trim(dsOrder.Tables("Item").Rows(iIndex).Item(0)))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsOrder.Tables("Item").Rows(iIndex).Item(1)))
                lvLookUp.Items(iIndex).SubItems.Add(Val(Trim(dsOrder.Tables("Item").Rows(iIndex).Item(1))) * Val(Trim(dsOrder.Tables("Item").Rows(iIndex).Item(2))))
                lvLookUp.Items(iIndex).SubItems.Add(Trim(dsOrder.Tables("Item").Rows(iIndex).Item(3)))
            Next
        End If

    End Function

    Private Function ShowControlInNormalMode()
        txtTotalPrice.Enabled = False
        txtDiscount.Enabled = False
        txtTips.Enabled = False
        txtNetPay.Enabled = False
        btnReduceItem.Enabled = False
        btnRemoveItem.Enabled = False
        lvLookUp.Enabled = False
        btnEdit.Text = "Edit"
        btnDelete.Text = "Delete"
    End Function

    Private Sub frmEditOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iItemCount As Integer
        Dim strSQL As String
        Dim dsOrderInfo As DataSet
        Dim daOrderInfo As SqlClient.SqlDataAdapter

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Edit Order"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Edit Order"
        End If

        strSQL = "SELECT nOrder_Id FROM tOrder_Payment WHERE  dOrder_date BETWEEN '" & strFromDate & "' AND '" & strToDate & "'"

        Try
            dsOrderInfo = New DataSet("OrderInfo")
            daOrderInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daOrderInfo.Fill(dsOrderInfo, "OrderInfo")
            iItemCount = dsOrderInfo.Tables("OrderInfo").Rows.Count
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        If iItemCount > 0 Then
            With cboOrderId
                .DataSource = dsOrderInfo.Tables("OrderInfo")
                .DisplayMember = "nOrder_Id"
                .Text = iOrderId
            End With
        End If
        ShowPaymentInfo()
        ShowOrderedItemInfo()
        ShowControlInNormalMode()
        iOrderId = 0
    End Sub

    Private Function ShowControlInEditMode()
        btnReduceItem.Enabled = True
        btnRemoveItem.Enabled = True
        lvLookUp.Enabled = True
        btnEdit.Text = "Save"
        btnDelete.Text = "Cancel"
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim strSQL As String

        Dim iSelectedOrderId As Integer
        Dim iIndex As Integer
        Dim iCountLVRow As Integer
        Dim iQuantity As Integer
        Dim iItemId As Integer


        Dim dTotalPricePerItem As Double
        Dim dUnitPrice As Double

        Dim cmdUpdate As SqlClient.SqlCommand
        Dim tnsAll As SqlClient.SqlTransaction

        If btnEdit.Text = "Edit" Then
            ShowControlInEditMode()
        ElseIf btnEdit.Text = "Save" Then
            If Trim(cboOrderId.Text) <> vbNullString Then

                iSelectedOrderId = Trim(cboOrderId.Text)
                iCountLVRow = lvLookUp.Items.Count

                Try
                    strSQL = "DELETE FROM tOrdered_Item WHERE nOrder_Id=" & CStr(iSelectedOrderId) & ""

                    cmdUpdate = New SqlClient.SqlCommand
                    tnsAll = mdDBConnection.connRestuarant.BeginTransaction()
                    cmdUpdate.Transaction = tnsAll
                    cmdUpdate.Connection = mdDBConnection.connRestuarant
                    cmdUpdate.CommandText = strSQL
                    cmdUpdate.ExecuteNonQuery()

                    For iIndex = 0 To iCountLVRow - 1
                        iQuantity = lvLookUp.Items(iIndex).SubItems(1).Text
                        dTotalPricePerItem = lvLookUp.Items(iIndex).SubItems(2).Text
                        dUnitPrice = dTotalPricePerItem / iQuantity
                        iItemId = lvLookUp.Items(iIndex).SubItems(3).Text

                        strSQL = "INSERT INTO tOrdered_Item(nOrder_Id,nItem_Id,mUnitPrice,nItem_Qty,cUserId,cTerminal,dAccessTime)" & _
                                 " VALUES(" & CStr(iSelectedOrderId) & "," & CStr(iItemId) & "," & CStr(dUnitPrice) & _
                                 "," & CStr(iQuantity) & ",'" & user & "','" & sTerminal & "',GETDATE())"

                        cmdUpdate.CommandText = strSQL
                        cmdUpdate.ExecuteNonQuery()
                    Next

                    strSQL = "UPDATE tOrder_Payment SET mTotalPrice=" & CStr(Trim(txtTotalPrice.Text)) & _
                             ",mDiscount=" & CStr(Trim(txtDiscount.Text)) & ",mService_Charge=" & CStr(Trim(txtTips.Text)) & _
                             ",mNetpay=" & CStr(Trim(txtNetPay.Text)) & " WHERE nOrder_Id=" & CStr(iSelectedOrderId) & ""

                    cmdUpdate.CommandText = strSQL
                    cmdUpdate.ExecuteNonQuery()
                    tnsAll.Commit()
                Catch ex As Exception
                    MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                    tnsAll.Rollback()
                End Try
                ShowControlInNormalMode()
            Else
                MsgBox("Please Select a Order to Edit.", MsgBoxStyle.Information, "Edit Order")
            End If
        End If
    End Sub

    Private Sub btnNextOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextOrder.Click
        If cboOrderId.SelectedIndex = (cboOrderId.Items.Count - 1) Then
            cboOrderId.SelectedIndex = 0
            ShowPaymentInfo()
            ShowOrderedItemInfo()
            ShowControlInNormalMode()
        Else
            cboOrderId.SelectedIndex = cboOrderId.SelectedIndex + 1
            ShowPaymentInfo()
            ShowOrderedItemInfo()
            ShowControlInNormalMode()
        End If
    End Sub

    Private Sub btnPreviousOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousOrder.Click
        If cboOrderId.SelectedIndex = 0 Then
            cboOrderId.SelectedIndex = cboOrderId.Items.Count - 1
            ShowPaymentInfo()
            ShowOrderedItemInfo()
            ShowControlInNormalMode()
        Else
            cboOrderId.SelectedIndex = cboOrderId.SelectedIndex - 1
            ShowPaymentInfo()
            ShowOrderedItemInfo()
            ShowControlInNormalMode()
        End If
    End Sub

    Private Function DeleteOrderInfo()
        Dim strSQL As String

        Dim iSelectedOrderId As Integer

        Dim cmdDelete As SqlClient.SqlCommand
        Dim tnsAll As SqlClient.SqlTransaction

        If Trim(cboOrderId.Text) <> vbNullString Then
            iSelectedOrderId = Trim(cboOrderId.Text)
            Try
                strSQL = "DELETE FROM tOrdered_Item WHERE nOrder_Id=" & CStr(iSelectedOrderId) & ""

                cmdDelete = New SqlClient.SqlCommand
                tnsAll = mdDBConnection.connRestuarant.BeginTransaction()
                cmdDelete.Transaction = tnsAll
                cmdDelete.Connection = mdDBConnection.connRestuarant
                cmdDelete.CommandText = strSQL
                cmdDelete.ExecuteNonQuery()

                strSQL = "DELETE FROM tOrder_Payment WHERE nOrder_Id=" & CStr(iSelectedOrderId) & ""
                cmdDelete.CommandText = strSQL
                cmdDelete.ExecuteNonQuery()

                If Trim(txtNetPay.Tag) <> "0" Then
                    strSQL = "DELETE FROM tCust_Info WHERE nCust_Id=" & CStr(Trim(txtTotalPrice.Tag)) & ""
                    cmdDelete.CommandText = strSQL
                    cmdDelete.ExecuteNonQuery()
                End If
                tnsAll.Commit()
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
                tnsAll.Rollback()
            End Try
        End If
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Delete" Then
            DeleteOrderInfo()
            ShowOrderedItemInfo()
            ShowPaymentInfo()
            ShowControlInNormalMode()
            Dim objfrmPaymentInfo As New frmPaymentStatus
            objfrmPaymentInfo.lvPaymentStatus.Items.Clear()
            objfrmPaymentInfo.ShowPaymentInfo(strFromDate, strToDate)
        ElseIf btnDelete.Text = "Cancel" Then
            ShowPaymentInfo()
            ShowOrderedItemInfo()
            ShowControlInNormalMode()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim strSQL As String
        Dim cmdDelete As SqlClient.SqlCommand
        Dim tnsAll As SqlClient.SqlTransaction
        Dim strFromDate As String
        Dim strToDate As String

        strFromDate = DateTime.Parse(Date.Today).ToString("MM/dd/yyyy 00:00:00")
        strToDate = DateTime.Parse(Trim(Date.Today)).ToString("MM/dd/yyyy 23:59:59")

        strSQL = "DELETE FROM tOrder_Payment WHERE dOrder_date between '" & strFromDate & "' AND '" & strToDate & "'"
        cmdDelete = New SqlClient.SqlCommand
        tnsAll = mdDBConnection.connRestuarant.BeginTransaction()
        cmdDelete.Transaction = tnsAll
        cmdDelete.Connection = mdDBConnection.connRestuarant
        cmdDelete.CommandText = strSQL
        cmdDelete.ExecuteNonQuery()
        tnsAll.Commit()
    End Sub
End Class
