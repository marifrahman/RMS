Imports System.Globalization
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmBillSplitting
    Inherits System.Windows.Forms.Form

    Dim iOrderId As Integer

    Dim dblFirstValue As Double
    Dim dblSecondValue As Double
    Dim blnEnterPress As Boolean

    Private bPrint As Boolean = False

    Dim strItemInfo(,) As String

    Dim conControlName As Control
    Dim objfrmKeyBoard As New frmKeyBoard
    Dim bCboLoad As Boolean
    Dim bClickedBefore As Boolean = False
    Dim strClickTypeName As String
    Dim strNewClickType As String
    Dim iCustomerId As Integer
    Dim bcash As String
    Dim bcard As String
    Dim fcash As String
    Dim fcard As String
    Dim fcheque As String



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
    Friend WithEvents gbPriceCalculation As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtGuestNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents btnClear As MACButtonLib.MACButton
    Friend WithEvents btn2 As MACButtonLib.MACButton
    Friend WithEvents btn4 As MACButtonLib.MACButton
    Friend WithEvents btn3 As MACButtonLib.MACButton
    Friend WithEvents btn8 As MACButtonLib.MACButton
    Friend WithEvents btn7 As MACButtonLib.MACButton
    Friend WithEvents btn6 As MACButtonLib.MACButton
    Friend WithEvents btn5 As MACButtonLib.MACButton
    Friend WithEvents btnDot As MACButtonLib.MACButton
    Friend WithEvents btn0 As MACButtonLib.MACButton
    Friend WithEvents btn9 As MACButtonLib.MACButton
    Friend WithEvents btnMultiply As MACButtonLib.MACButton
    Friend WithEvents btnAdd As MACButtonLib.MACButton
    Friend WithEvents btnDelete As MACButtonLib.MACButton
    Friend WithEvents btnBckSpace As MACButtonLib.MACButton
    Friend WithEvents btnCancel As MACButtonLib.MACButton
    Friend WithEvents btnMinimize As MACButtonLib.MACButton
    Friend WithEvents txtTableNo As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As MACButtonLib.MACButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkCash As System.Windows.Forms.CheckBox
    Friend WithEvents chkCard As System.Windows.Forms.CheckBox
    Friend WithEvents txtMealPay As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As MACButtonLib.MACButton
    Friend WithEvents chkBoth As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txtTableNo = New System.Windows.Forms.TextBox
        Me.btnClear = New MACButtonLib.MACButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblTable = New System.Windows.Forms.Label
        Me.txtGuestNumber = New System.Windows.Forms.TextBox
        Me.txtMealPay = New System.Windows.Forms.TextBox
        Me.gbPriceCalculation = New System.Windows.Forms.GroupBox
        Me.btnDelete = New MACButtonLib.MACButton
        Me.btnBckSpace = New MACButtonLib.MACButton
        Me.btnAdd = New MACButtonLib.MACButton
        Me.btnMultiply = New MACButtonLib.MACButton
        Me.btnDot = New MACButtonLib.MACButton
        Me.btn0 = New MACButtonLib.MACButton
        Me.btn9 = New MACButtonLib.MACButton
        Me.btn8 = New MACButtonLib.MACButton
        Me.btn7 = New MACButtonLib.MACButton
        Me.btn6 = New MACButtonLib.MACButton
        Me.btn5 = New MACButtonLib.MACButton
        Me.btn4 = New MACButtonLib.MACButton
        Me.btn3 = New MACButtonLib.MACButton
        Me.btn2 = New MACButtonLib.MACButton
        Me.btn1 = New MACButtonLib.MACButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnCancel = New MACButtonLib.MACButton
        Me.btnMinimize = New MACButtonLib.MACButton
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.chkCash = New System.Windows.Forms.CheckBox
        Me.chkCard = New System.Windows.Forms.CheckBox
        Me.btnPrint = New MACButtonLib.MACButton
        Me.chkBoth = New System.Windows.Forms.CheckBox
        Me.gbPriceCalculation.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTableNo
        '
        Me.txtTableNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTableNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTableNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableNo.Location = New System.Drawing.Point(160, 32)
        Me.txtTableNo.Name = "txtTableNo"
        Me.txtTableNo.Size = New System.Drawing.Size(96, 22)
        Me.txtTableNo.TabIndex = 1
        Me.txtTableNo.Text = ""
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnClear.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnClear.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnClear.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnClear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(14, 268)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 56)
        Me.btnClear.TabIndex = 102
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColorDefault = System.Drawing.Color.Black
        Me.btnClear.TextColorDisabled = System.Drawing.Color.Black
        Me.btnClear.TextColorHover = System.Drawing.Color.White
        Me.btnClear.TextColorNormal = System.Drawing.Color.White
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 22)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "No of Guests"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTable
        '
        Me.lblTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTable.Location = New System.Drawing.Point(16, 32)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(120, 22)
        Me.lblTable.TabIndex = 57
        Me.lblTable.Text = "Table No."
        Me.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGuestNumber
        '
        Me.txtGuestNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuestNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestNumber.Location = New System.Drawing.Point(160, 72)
        Me.txtGuestNumber.MaxLength = 4
        Me.txtGuestNumber.Name = "txtGuestNumber"
        Me.txtGuestNumber.Size = New System.Drawing.Size(96, 22)
        Me.txtGuestNumber.TabIndex = 47
        Me.txtGuestNumber.Text = ""
        '
        'txtMealPay
        '
        Me.txtMealPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMealPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMealPay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMealPay.Location = New System.Drawing.Point(160, 112)
        Me.txtMealPay.Name = "txtMealPay"
        Me.txtMealPay.Size = New System.Drawing.Size(96, 21)
        Me.txtMealPay.TabIndex = 77
        Me.txtMealPay.Text = ""
        '
        'gbPriceCalculation
        '
        Me.gbPriceCalculation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.gbPriceCalculation.Controls.Add(Me.btnDelete)
        Me.gbPriceCalculation.Controls.Add(Me.btnBckSpace)
        Me.gbPriceCalculation.Controls.Add(Me.btnAdd)
        Me.gbPriceCalculation.Controls.Add(Me.btnMultiply)
        Me.gbPriceCalculation.Controls.Add(Me.btnDot)
        Me.gbPriceCalculation.Controls.Add(Me.btn0)
        Me.gbPriceCalculation.Controls.Add(Me.btn9)
        Me.gbPriceCalculation.Controls.Add(Me.btn8)
        Me.gbPriceCalculation.Controls.Add(Me.btn7)
        Me.gbPriceCalculation.Controls.Add(Me.btn6)
        Me.gbPriceCalculation.Controls.Add(Me.btn5)
        Me.gbPriceCalculation.Controls.Add(Me.btn4)
        Me.gbPriceCalculation.Controls.Add(Me.btn3)
        Me.gbPriceCalculation.Controls.Add(Me.btn2)
        Me.gbPriceCalculation.Controls.Add(Me.btn1)
        Me.gbPriceCalculation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbPriceCalculation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPriceCalculation.ForeColor = System.Drawing.Color.Maroon
        Me.gbPriceCalculation.Location = New System.Drawing.Point(280, 40)
        Me.gbPriceCalculation.Name = "gbPriceCalculation"
        Me.gbPriceCalculation.Size = New System.Drawing.Size(248, 288)
        Me.gbPriceCalculation.TabIndex = 1
        Me.gbPriceCalculation.TabStop = False
        Me.gbPriceCalculation.Text = "Price Calculation"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnDelete.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnDelete.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnDelete.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(80, 224)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 40)
        Me.btnDelete.TabIndex = 117
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextColorDefault = System.Drawing.Color.Black
        Me.btnDelete.TextColorDisabled = System.Drawing.Color.Black
        Me.btnDelete.TextColorHover = System.Drawing.Color.White
        Me.btnDelete.TextColorNormal = System.Drawing.Color.White
        '
        'btnBckSpace
        '
        Me.btnBckSpace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBckSpace.BackColor = System.Drawing.Color.Transparent
        Me.btnBckSpace.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnBckSpace.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnBckSpace.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnBckSpace.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnBckSpace.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBckSpace.Location = New System.Drawing.Point(8, 224)
        Me.btnBckSpace.Name = "btnBckSpace"
        Me.btnBckSpace.Size = New System.Drawing.Size(66, 40)
        Me.btnBckSpace.TabIndex = 116
        Me.btnBckSpace.Text = "BSpace"
        Me.btnBckSpace.TextColorDefault = System.Drawing.Color.Black
        Me.btnBckSpace.TextColorDisabled = System.Drawing.Color.Black
        Me.btnBckSpace.TextColorHover = System.Drawing.Color.White
        Me.btnBckSpace.TextColorNormal = System.Drawing.Color.White
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnAdd.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnAdd.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnAdd.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(152, 224)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 56)
        Me.btnAdd.TabIndex = 115
        Me.btnAdd.Text = "Enter"
        Me.btnAdd.TextColorDefault = System.Drawing.Color.Black
        Me.btnAdd.TextColorDisabled = System.Drawing.Color.Black
        Me.btnAdd.TextColorHover = System.Drawing.Color.White
        Me.btnAdd.TextColorNormal = System.Drawing.Color.White
        '
        'btnMultiply
        '
        Me.btnMultiply.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMultiply.BackColor = System.Drawing.Color.Transparent
        Me.btnMultiply.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnMultiply.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnMultiply.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnMultiply.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnMultiply.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(168, 176)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(52, 48)
        Me.btnMultiply.TabIndex = 114
        Me.btnMultiply.Text = "X"
        Me.btnMultiply.TextColorDefault = System.Drawing.Color.Black
        Me.btnMultiply.TextColorDisabled = System.Drawing.Color.Black
        Me.btnMultiply.TextColorHover = System.Drawing.Color.White
        Me.btnMultiply.TextColorNormal = System.Drawing.Color.White
        '
        'btnDot
        '
        Me.btnDot.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDot.BackColor = System.Drawing.Color.Transparent
        Me.btnDot.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnDot.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnDot.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnDot.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btnDot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDot.Location = New System.Drawing.Point(96, 176)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(52, 48)
        Me.btnDot.TabIndex = 113
        Me.btnDot.Text = "."
        Me.btnDot.TextColorDefault = System.Drawing.Color.Black
        Me.btnDot.TextColorDisabled = System.Drawing.Color.Black
        Me.btnDot.TextColorHover = System.Drawing.Color.White
        Me.btnDot.TextColorNormal = System.Drawing.Color.White
        '
        'btn0
        '
        Me.btn0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn0.BackColor = System.Drawing.Color.Transparent
        Me.btn0.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn0.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn0.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn0.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn0.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(16, 176)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(52, 48)
        Me.btn0.TabIndex = 112
        Me.btn0.Text = "0"
        Me.btn0.TextColorDefault = System.Drawing.Color.Black
        Me.btn0.TextColorDisabled = System.Drawing.Color.Black
        Me.btn0.TextColorHover = System.Drawing.Color.White
        Me.btn0.TextColorNormal = System.Drawing.Color.White
        '
        'btn9
        '
        Me.btn9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn9.BackColor = System.Drawing.Color.Transparent
        Me.btn9.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn9.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn9.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn9.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(168, 125)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(52, 48)
        Me.btn9.TabIndex = 111
        Me.btn9.Text = "9"
        Me.btn9.TextColorDefault = System.Drawing.Color.Black
        Me.btn9.TextColorDisabled = System.Drawing.Color.Black
        Me.btn9.TextColorHover = System.Drawing.Color.White
        Me.btn9.TextColorNormal = System.Drawing.Color.White
        '
        'btn8
        '
        Me.btn8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn8.BackColor = System.Drawing.Color.Transparent
        Me.btn8.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn8.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn8.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn8.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(96, 125)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(52, 48)
        Me.btn8.TabIndex = 110
        Me.btn8.Text = "8"
        Me.btn8.TextColorDefault = System.Drawing.Color.Black
        Me.btn8.TextColorDisabled = System.Drawing.Color.Black
        Me.btn8.TextColorHover = System.Drawing.Color.White
        Me.btn8.TextColorNormal = System.Drawing.Color.White
        '
        'btn7
        '
        Me.btn7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn7.BackColor = System.Drawing.Color.Transparent
        Me.btn7.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn7.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn7.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn7.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn7.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(16, 125)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(52, 48)
        Me.btn7.TabIndex = 109
        Me.btn7.Text = "7"
        Me.btn7.TextColorDefault = System.Drawing.Color.Black
        Me.btn7.TextColorDisabled = System.Drawing.Color.Black
        Me.btn7.TextColorHover = System.Drawing.Color.White
        Me.btn7.TextColorNormal = System.Drawing.Color.White
        '
        'btn6
        '
        Me.btn6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn6.BackColor = System.Drawing.Color.Transparent
        Me.btn6.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn6.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn6.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn6.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(168, 72)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(52, 48)
        Me.btn6.TabIndex = 108
        Me.btn6.Text = "6"
        Me.btn6.TextColorDefault = System.Drawing.Color.Black
        Me.btn6.TextColorDisabled = System.Drawing.Color.Black
        Me.btn6.TextColorHover = System.Drawing.Color.White
        Me.btn6.TextColorNormal = System.Drawing.Color.White
        '
        'btn5
        '
        Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn5.BackColor = System.Drawing.Color.Transparent
        Me.btn5.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn5.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn5.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn5.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(96, 72)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(52, 48)
        Me.btn5.TabIndex = 107
        Me.btn5.Text = "5"
        Me.btn5.TextColorDefault = System.Drawing.Color.Black
        Me.btn5.TextColorDisabled = System.Drawing.Color.Black
        Me.btn5.TextColorHover = System.Drawing.Color.White
        Me.btn5.TextColorNormal = System.Drawing.Color.White
        '
        'btn4
        '
        Me.btn4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn4.BackColor = System.Drawing.Color.Transparent
        Me.btn4.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn4.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn4.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn4.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(16, 72)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(52, 48)
        Me.btn4.TabIndex = 106
        Me.btn4.Text = "4"
        Me.btn4.TextColorDefault = System.Drawing.Color.Black
        Me.btn4.TextColorDisabled = System.Drawing.Color.Black
        Me.btn4.TextColorHover = System.Drawing.Color.White
        Me.btn4.TextColorNormal = System.Drawing.Color.White
        '
        'btn3
        '
        Me.btn3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn3.BackColor = System.Drawing.Color.Transparent
        Me.btn3.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn3.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn3.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn3.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(168, 24)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(52, 48)
        Me.btn3.TabIndex = 105
        Me.btn3.Text = "3"
        Me.btn3.TextColorDefault = System.Drawing.Color.Black
        Me.btn3.TextColorDisabled = System.Drawing.Color.Black
        Me.btn3.TextColorHover = System.Drawing.Color.White
        Me.btn3.TextColorNormal = System.Drawing.Color.White
        '
        'btn2
        '
        Me.btn2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        Me.btn2.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn2.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn2.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn2.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(96, 24)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(52, 48)
        Me.btn2.TabIndex = 104
        Me.btn2.Text = "2"
        Me.btn2.TextColorDefault = System.Drawing.Color.Black
        Me.btn2.TextColorDisabled = System.Drawing.Color.Black
        Me.btn2.TextColorHover = System.Drawing.Color.White
        Me.btn2.TextColorNormal = System.Drawing.Color.White
        '
        'btn1
        '
        Me.btn1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn1.BackColor = System.Drawing.Color.Transparent
        Me.btn1.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btn1.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btn1.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btn1.ButtonColorNormal = System.Drawing.Color.DarkOliveGreen
        Me.btn1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(16, 24)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(52, 48)
        Me.btn1.TabIndex = 103
        Me.btn1.Text = "1"
        Me.btn1.TextColorDefault = System.Drawing.Color.Black
        Me.btn1.TextColorDisabled = System.Drawing.Color.Black
        Me.btn1.TextColorHover = System.Drawing.Color.White
        Me.btn1.TextColorNormal = System.Drawing.Color.White
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(16, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 22)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Meal Price"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(9894, 3953)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(124, 40)
        Me.btnRefresh.TabIndex = 39
        Me.btnRefresh.Text = "Refresh Order"
        Me.btnRefresh.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnCancel.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnCancel.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnCancel.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(464, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(48, 40)
        Me.btnCancel.TabIndex = 105
        Me.btnCancel.Text = "X"
        Me.btnCancel.TextColorDefault = System.Drawing.Color.Black
        Me.btnCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.btnCancel.TextColorHover = System.Drawing.Color.White
        Me.btnCancel.TextColorNormal = System.Drawing.Color.White
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnMinimize.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnMinimize.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnMinimize.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(400, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(48, 40)
        Me.btnMinimize.TabIndex = 119
        Me.btnMinimize.Text = "__"
        Me.btnMinimize.TextColorDefault = System.Drawing.Color.Black
        Me.btnMinimize.TextColorDisabled = System.Drawing.Color.Black
        Me.btnMinimize.TextColorHover = System.Drawing.Color.White
        Me.btnMinimize.TextColorNormal = System.Drawing.Color.White
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Qty"
        Me.ColumnHeader2.Width = 45
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Item"
        Me.ColumnHeader3.Width = 153
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Instruction"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = ""
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = ""
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = ""
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Qty"
        Me.ColumnHeader11.Width = 45
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Item"
        Me.ColumnHeader12.Width = 153
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Price"
        Me.ColumnHeader13.Width = 87
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Instruction"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 200
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = ""
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = ""
        Me.ColumnHeader16.Width = 0
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Width = 0
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Width = 0
        '
        'chkCash
        '
        Me.chkCash.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCash.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkCash.Location = New System.Drawing.Point(29, 168)
        Me.chkCash.Name = "chkCash"
        Me.chkCash.TabIndex = 0
        Me.chkCash.Text = "CASH"
        Me.chkCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkCard
        '
        Me.chkCard.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCard.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkCard.Location = New System.Drawing.Point(157, 168)
        Me.chkCard.Name = "chkCard"
        Me.chkCard.TabIndex = 1
        Me.chkCard.Text = "CARD"
        Me.chkCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnPrint.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnPrint.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnPrint.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(152, 264)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 56)
        Me.btnPrint.TabIndex = 120
        Me.btnPrint.Text = "print"
        Me.btnPrint.TextColorDefault = System.Drawing.Color.Black
        Me.btnPrint.TextColorDisabled = System.Drawing.Color.Black
        Me.btnPrint.TextColorHover = System.Drawing.Color.White
        Me.btnPrint.TextColorNormal = System.Drawing.Color.White
        '
        'chkBoth
        '
        Me.chkBoth.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoth.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkBoth.Location = New System.Drawing.Point(88, 200)
        Me.chkBoth.Name = "chkBoth"
        Me.chkBoth.TabIndex = 121
        Me.chkBoth.Text = "BOTH"
        Me.chkBoth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBillSplitting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(540, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkBoth)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbPriceCalculation)
        Me.Controls.Add(Me.txtMealPay)
        Me.Controls.Add(Me.txtGuestNumber)
        Me.Controls.Add(Me.txtTableNo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkCash)
        Me.Controls.Add(Me.chkCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmBillSplitting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBILL"
        Me.gbPriceCalculation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents objtaskbarNotifier As TaskBarNotifier


    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        IsMultiplyButtonPress(conControlName)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If conControlName.Focus() = True And conControlName.Text <> vbNullString Then
            CalculateResult(conControlName)
        End If
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btnDot.Click, btn1.Click
        If mdValidation.IsTextEditableControl(conControlName) = True Then
            IsEnterPress(conControlName)
            conControlName.Text += sender.Text
        End If
    End Sub

    Private Sub btnKeyBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtTableNo.Text = ""
        txtGuestNumber.Text = ""
        txtMealPay.Text = ""

    End Sub

    Private Sub btnBckSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBckSpace.Click
        If conControlName.Text.Length > 0 Then
            conControlName.Text = conControlName.Text.Remove(conControlName.Text.Length - 1, 1)
        End If
    End Sub

    Public Sub clearInfo(ByVal tempgbCustomerInfo As Object)
        Dim ctl As Control

        For Each ctl In tempgbCustomerInfo.Controls
            If TypeName(ctl) = "TextBox" Then
                ctl.Text = vbNullString
            End If
        Next

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        conControlName.Text = vbNullString
    End Sub

    Private Function SpaceCalculation(ByVal strText As String) As Integer
        Dim SpaceLength As Integer
        Dim wordlength As Integer = Len(strText)
        SpaceLength = (32 / 2 - wordlength / 2) - 2
        If SpaceLength < 0 Then
            SpaceCalculation = 0
        Else
            SpaceCalculation = SpaceLength
        End If

    End Function

    'print command for desktop

    Public Function PrintBill()
        Dim PaperHeight As Integer
        Dim i As Integer
        Dim iMaxItemLen As Integer = 0
        Dim iMaxItemQtyLen As Integer = 0
        Dim iStringLenCount As Integer
        Dim iPriceStringLen As Integer
        Dim iSpaceForPrice As Integer

        Dim strOrderDate As String
        Dim strCompanyName As String
        Dim strCompanyType As String
        Dim strCompanyAddress1 As String
        Dim strCompanyAddress2 As String
        Dim strCompanyAddress3 As String
        Dim strCompanyPhone As String
        Dim strVatNumber As String
        Dim strwebAddress As String
        Dim strEmailAddress As String
        Dim strFooter As String
        Dim strItemInformation As String
        Dim strItemInfoHeader As String
        Dim strItemPrice As String
        Dim strDis As String
        Dim strTips As String
        Dim strOrderId As String
        Dim strTableId As String
        Dim strCash As String
        Dim strCard As String
        Dim srtCheque As String
        Dim srtChange As String

        strOrderDate = "Date: " + DateTime.Parse(GetOrderDate()).ToString("dd/MM/yyyy") _
                                     + vbNewLine + "Time:" + DateTime.Parse(GetOrderDate()).ToString("hh:mm:ss tt") + vbNewLine
        If Len(Trim(mdConfiguration.strResturantName)) > 0 Then
            strCompanyName = Space(SpaceCalculation(Trim(mdConfiguration.strResturantName)) - 4) _
                             + mdConfiguration.strResturantName 'To print Restaurant name
        Else
            strCompanyName = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantType)) > 0 Then
            strCompanyType = Space(SpaceCalculation(Trim(mdConfiguration.strRestuarantType))) _
                             + Trim(mdConfiguration.strRestuarantType) + vbNewLine 'To print Restaurant Type
        Else
            strCompanyType = ""
        End If

        If Len(Trim(mdConfiguration.strResturantAddress1)) > 0 Then
            strCompanyAddress1 = Space(SpaceCalculation(Trim(mdConfiguration.strResturantAddress1))) _
                                 + Trim(mdConfiguration.strResturantAddress1) + vbNewLine 'To print Restaurant Address1
        Else
            strCompanyAddress1 = ""
        End If

        If Len(Trim(mdConfiguration.strRestuantAddress2)) > 0 Then
            strCompanyAddress2 = Space(SpaceCalculation(Trim(mdConfiguration.strRestuantAddress2))) _
                                 + Trim(mdConfiguration.strRestuantAddress2) + vbNewLine 'To print Restaurant Address2
        Else
            strCompanyAddress2 = ""
        End If

        If Len(Trim(mdConfiguration.strRestuantAddress3)) > 0 Then
            strCompanyAddress3 = Space(SpaceCalculation(Trim(mdConfiguration.strRestuantAddress3))) _
                                 + Trim(mdConfiguration.strRestuantAddress3) + vbNewLine 'To print Restaurant Address3
        Else
            strCompanyAddress3 = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantPhone)) > 0 Then
            Dim strPhone As String = Trim(mdConfiguration.strRestuarantPhone)
            strCompanyPhone = Space((SpaceCalculation(strPhone)) - 2) + "Tel:" _
                              + Trim(mdConfiguration.strRestuarantPhone) + vbNewLine  'To print Restaurant Phone

        Else
            strCompanyPhone = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantPhone)) > 0 Then
            strVatNumber = Space(SpaceCalculation(Trim(mdConfiguration.strVatNumber)) - 6) + "Vat Number: " _
                           + Trim(mdConfiguration.strVatNumber) + vbNewLine 'To print Restaurant VatNumber
        Else
            strVatNumber = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantWeb)) > 0 Then
            strwebAddress = Space(SpaceCalculation(Trim(mdConfiguration.strRestuarantWeb))) _
            + Trim(mdConfiguration.strRestuarantWeb) + vbNewLine                            'To print Restaurant VatNumber
        Else
            strwebAddress = ""
        End If

        If Len(Trim(mdConfiguration.strRestuarantEmail)) > 0 Then
            strEmailAddress = Space(SpaceCalculation(Trim(mdConfiguration.strRestuarantEmail))) _
            + Trim(mdConfiguration.strRestuarantEmail) + vbNewLine                          'To print Restaurant Email address
        Else
            strEmailAddress = ""
        End If

        strTableId = "Table Id: " + CStr(Trim(txtTableNo.Text)) + vbNewLine
        Dim strGuestNumber As String = "Guest Number: " + Trim(txtGuestNumber.Text)



        strItemPrice = vbNewLine + "Meal Price:" + Space(32 - (Len(Trim("Meal Price:")) + Len(Trim(txtMealPay.Text)) + 1)) + txtMealPay.Text + vbNewLine


        'Dim strNetPay As String = "Grand Total:" + Space(29 - (Len(Trim("Grand Total:")) + Len(Trim(txtNetPay.Text)) + 1)) + txtNetPay.Text + vbNewLine + vbNewLine
        Dim strNetPay As String = "Total : " + Space(30 - (Len(Trim("Grand Total:")) + Len(Trim(txtMealPay.Text)) + 1)) + txtMealPay.Text + vbNewLine


        Dim strUser As String = Space(SpaceCalculation(struserName) - 6) + "Taken By: " + struserName

        Dim strPrintItem As String
        Dim strNetpayItem As String
        Dim strviapaid As String

        strPrintItem = strItemInformation + strItemPrice
        strNetpayItem = strNetPay  'added on requriment For netpaybold 23.10.07

        If chkCash.Checked = True Then
            ' strPrintItem += strCash
            strviapaid = "PAID IN CASH"
        ElseIf chkCard.Checked = True Then
            'strPrintItem += strCard
            strviapaid = "PAID IN CARD"
        ElseIf chkBoth.Checked = True Then
            'strPrintItem += strCard
            strviapaid = "PAID IN CASH & CARD"
        Else
            strviapaid = ""
        End If


        strFooter += Space(SpaceCalculation(Trim(mdConfiguration.strGreetingMsg))) _
                     + IIf(Trim(mdConfiguration.strGreetingMsg) <> vbNullString, _
                     Trim(mdConfiguration.strGreetingMsg), " ") + vbNewLine ' To Print Greeting Message
        strFooter += strEmailAddress + strwebAddress

        Dim ObjbillrstPrinter As New BillRstPrinter.printdoc
        Dim objPrintDirect As New PrintDirectt
        Dim offPrintDialog As New StandardPrintController

        ObjbillrstPrinter.PrintController = offPrintDialog

        If mdConfiguration.sBillPrinter <> vbNullString Then
            ObjbillrstPrinter.PrinterSettings.PrinterName = mdConfiguration.sBillPrinter
            ObjbillrstPrinter.DateText = strOrderDate
            If File.Exists("C:\Program Files\UYSYS\Logo\logo.bmp") Then
                Dim strLogoPath As String
                strLogoPath = "C:\Program Files\UYSYS\Logo\logo.bmp"
                ObjbillrstPrinter.LogoImage = New Bitmap(strLogoPath)
                ObjbillrstPrinter.HeaderText = vbNewLine + vbNewLine
            Else
                ObjbillrstPrinter.HeaderText = vbNewLine + strCompanyName
            End If
            ObjbillrstPrinter.AddressText = strCompanyType + strCompanyAddress1 + strCompanyAddress2 _
                                        + strCompanyAddress3 + strCompanyPhone + strVatNumber + strUser _
                                        + vbNewLine + vbNewLine
            ObjbillrstPrinter.ItemText = strTableId + strGuestNumber + vbNewLine + strPrintItem '+ vbNewLine
            'ObjrstPrinter.ItemFo = New Font("Lucida Console", 12, FontStyle.Bold)
            ObjbillrstPrinter.NetpayText = strNetpayItem '+ vbNewLine
            ObjbillrstPrinter.ViaPaidText = strviapaid
            ObjbillrstPrinter.FooterText = strFooter
            ObjbillrstPrinter.Print()
            objPrintDirect.OnCutter(mdConfiguration.sBillPrinter)
        Else
            MsgBox("Please select a printer for printing bill.", MsgBoxStyle.Information, "Takeaway")
        End If

    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim Itype As Integer
        Itype = MsgBox("Do you want to Exit", MsgBoxStyle.YesNo, "eRestuarant")
        If Itype = MsgBoxResult.Yes Then
            Me.Dispose()
            'Application.Exit()
        End If
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintBill()
    End Sub

    Private Sub txtTableNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTableNo.GotFocus
        conControlName = txtTableNo

    End Sub

    Private Sub txtGuestNumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGuestNumber.GotFocus
        conControlName = txtGuestNumber
    End Sub

    Private Sub txtMealPay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMealPay.GotFocus
        conControlName = txtMealPay
    End Sub

End Class
