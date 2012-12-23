Imports System.Windows.Forms
Imports System.Data.SqlServerCe
Imports System.Data.SqlServerCe.SqlCeException
Imports System.IO
Imports System.Text

Public Class frmMain
    Inherits System.Windows.Forms.Form
    Friend WithEvents mnuMain As System.Windows.Forms.MainMenu

    Dim strItemId As String
    Dim bLoad As Boolean

    'Local database connection
    'Close START [Jami]    
    'Dim connDishInfo As New SqlCeConnection( _
    '     "Data Source=\My Documents\dbeRestuarant.sdf")

    ' Connection string to Desktop SQL Server 2000
    'Dim rdaOleDbConnectString As String = _
    '        "Provider=sqloledb; Data Source=192.168.10.20;Initial" & _
    '        " Catalog=eRestuarant;User Id=sa;Password=jami31"

    'Dim rda As New SqlCeRemoteDataAccess

    ' Declaration of the RDA object.
    'Dim clinconn As New SqlConnection("Provider=SQLOLEDB.1;Password=habijabi;Persist Security Info=True;User ID=sa;Initial Catalog=D1Temp")

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tbMenu As System.Windows.Forms.TabControl
    Friend WithEvents tbCustinfo As System.Windows.Forms.TabPage
    Friend WithEvents tbDish As System.Windows.Forms.TabPage
    Friend WithEvents treeDish As System.Windows.Forms.TreeView
    Friend WithEvents tbOrder As System.Windows.Forms.TabPage
    Friend WithEvents lblTableID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents mnuItmCreate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItmSubmit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItmGetmenu As System.Windows.Forms.MenuItem
    Friend WithEvents lstOrder As System.Windows.Forms.ListView
    Friend WithEvents clmDish As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtCustAdd As System.Windows.Forms.TextBox
    Friend WithEvents mnuMainReset As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMainExit As System.Windows.Forms.MenuItem
    Friend WithEvents btnRmv As System.Windows.Forms.Button
    Friend WithEvents cboTblId As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents clmQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmInstruction As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmItemID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfGuest As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboQty As System.Windows.Forms.ComboBox
    Friend WithEvents txtCbo As System.Windows.Forms.TextBox
    Friend WithEvents clmStock As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboItemQty As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

    Private Sub InitializeComponent()
        Me.mnuMain = New System.Windows.Forms.MainMenu
        Me.mnuItmCreate = New System.Windows.Forms.MenuItem
        Me.mnuMainReset = New System.Windows.Forms.MenuItem
        Me.mnuItmSubmit = New System.Windows.Forms.MenuItem
        Me.mnuItmGetmenu = New System.Windows.Forms.MenuItem
        Me.mnuMainExit = New System.Windows.Forms.MenuItem
        Me.tbMenu = New System.Windows.Forms.TabControl
        Me.tbCustinfo = New System.Windows.Forms.TabPage
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboTblId = New System.Windows.Forms.ComboBox
        Me.txtNumberOfGuest = New System.Windows.Forms.TextBox
        Me.txtCustAdd = New System.Windows.Forms.TextBox
        Me.txtCustCompany = New System.Windows.Forms.TextBox
        Me.txtCustName = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblAdd = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblTableID = New System.Windows.Forms.Label
        Me.tbDish = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboItemQty = New System.Windows.Forms.ComboBox
        Me.treeDish = New System.Windows.Forms.TreeView
        Me.tbOrder = New System.Windows.Forms.TabPage
        Me.txtCbo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboQty = New System.Windows.Forms.ComboBox
        Me.btnRmv = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.txtTotalPrice = New System.Windows.Forms.TextBox
        Me.lstOrder = New System.Windows.Forms.ListView
        Me.clmDish = New System.Windows.Forms.ColumnHeader
        Me.clmPrice = New System.Windows.Forms.ColumnHeader
        Me.clmQty = New System.Windows.Forms.ColumnHeader
        Me.clmInstruction = New System.Windows.Forms.ColumnHeader
        Me.clmItemID = New System.Windows.Forms.ColumnHeader
        Me.clmStock = New System.Windows.Forms.ColumnHeader
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.Add(Me.mnuItmCreate)
        Me.mnuMain.MenuItems.Add(Me.mnuItmSubmit)
        Me.mnuMain.MenuItems.Add(Me.mnuItmGetmenu)
        Me.mnuMain.MenuItems.Add(Me.mnuMainExit)
        '
        'mnuItmCreate
        '
        Me.mnuItmCreate.MenuItems.Add(Me.mnuMainReset)
        Me.mnuItmCreate.Text = "|New|"
        '
        'mnuMainReset
        '
        Me.mnuMainReset.Text = "Reset"
        '
        'mnuItmSubmit
        '
        Me.mnuItmSubmit.Text = "|Submit|"
        '
        'mnuItmGetmenu
        '
        Me.mnuItmGetmenu.Text = "|Get Menu|"
        '
        'mnuMainExit
        '
        Me.mnuMainExit.Text = "|Exit|"
        '
        'tbMenu
        '
        Me.tbMenu.Controls.Add(Me.tbCustinfo)
        Me.tbMenu.Controls.Add(Me.tbDish)
        Me.tbMenu.Controls.Add(Me.tbOrder)
        Me.tbMenu.SelectedIndex = 0
        Me.tbMenu.Size = New System.Drawing.Size(240, 264)
        '
        'tbCustinfo
        '
        Me.tbCustinfo.Controls.Add(Me.txtEmail)
        Me.tbCustinfo.Controls.Add(Me.Label1)
        Me.tbCustinfo.Controls.Add(Me.cboTblId)
        Me.tbCustinfo.Controls.Add(Me.txtNumberOfGuest)
        Me.tbCustinfo.Controls.Add(Me.txtCustAdd)
        Me.tbCustinfo.Controls.Add(Me.txtCustCompany)
        Me.tbCustinfo.Controls.Add(Me.txtCustName)
        Me.tbCustinfo.Controls.Add(Me.lblEmail)
        Me.tbCustinfo.Controls.Add(Me.lblAdd)
        Me.tbCustinfo.Controls.Add(Me.lblCompany)
        Me.tbCustinfo.Controls.Add(Me.lblName)
        Me.tbCustinfo.Controls.Add(Me.lblTableID)
        Me.tbCustinfo.Location = New System.Drawing.Point(4, 4)
        Me.tbCustinfo.Size = New System.Drawing.Size(232, 238)
        Me.tbCustinfo.Text = "CustomerInfo"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(96, 162)
        Me.txtEmail.MaxLength = 20
        Me.txtEmail.Size = New System.Drawing.Size(120, 20)
        Me.txtEmail.Text = ""
        Me.txtEmail.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(5, 162)
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.Text = "E-mail"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Visible = False
        '
        'cboTblId
        '
        Me.cboTblId.Location = New System.Drawing.Point(96, 108)
        Me.cboTblId.Size = New System.Drawing.Size(88, 21)
        '
        'txtNumberOfGuest
        '
        Me.txtNumberOfGuest.Location = New System.Drawing.Point(96, 72)
        Me.txtNumberOfGuest.MaxLength = 8
        Me.txtNumberOfGuest.Size = New System.Drawing.Size(120, 20)
        Me.txtNumberOfGuest.Text = ""
        '
        'txtCustAdd
        '
        Me.txtCustAdd.Location = New System.Drawing.Point(96, 61)
        Me.txtCustAdd.MaxLength = 50
        Me.txtCustAdd.Size = New System.Drawing.Size(120, 20)
        Me.txtCustAdd.Text = ""
        Me.txtCustAdd.Visible = False
        '
        'txtCustCompany
        '
        Me.txtCustCompany.Location = New System.Drawing.Point(96, 34)
        Me.txtCustCompany.MaxLength = 50
        Me.txtCustCompany.Size = New System.Drawing.Size(120, 20)
        Me.txtCustCompany.Text = ""
        Me.txtCustCompany.Visible = False
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(96, 8)
        Me.txtCustName.MaxLength = 35
        Me.txtCustName.Size = New System.Drawing.Size(120, 20)
        Me.txtCustName.Text = ""
        Me.txtCustName.Visible = False
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(2, 73)
        Me.lblEmail.Size = New System.Drawing.Size(88, 20)
        Me.lblEmail.Text = "No Of Guests"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAdd
        '
        Me.lblAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdd.Location = New System.Drawing.Point(5, 61)
        Me.lblAdd.Size = New System.Drawing.Size(88, 20)
        Me.lblAdd.Text = "Address"
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblAdd.Visible = False
        '
        'lblCompany
        '
        Me.lblCompany.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompany.Location = New System.Drawing.Point(5, 34)
        Me.lblCompany.Size = New System.Drawing.Size(88, 20)
        Me.lblCompany.Text = "Company"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblCompany.Visible = False
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(5, 8)
        Me.lblName.Size = New System.Drawing.Size(88, 20)
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblName.Visible = False
        '
        'lblTableID
        '
        Me.lblTableID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTableID.Location = New System.Drawing.Point(5, 110)
        Me.lblTableID.Size = New System.Drawing.Size(88, 20)
        Me.lblTableID.Text = "Table ID"
        Me.lblTableID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbDish
        '
        Me.tbDish.Controls.Add(Me.Label3)
        Me.tbDish.Controls.Add(Me.cboItemQty)
        Me.tbDish.Controls.Add(Me.treeDish)
        Me.tbDish.Location = New System.Drawing.Point(4, 4)
        Me.tbDish.Size = New System.Drawing.Size(232, 238)
        Me.tbDish.Text = "Dishes"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 3)
        Me.Label3.Text = "Item Quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboItemQty
        '
        Me.cboItemQty.Items.Add("1")
        Me.cboItemQty.Items.Add("2")
        Me.cboItemQty.Items.Add("3")
        Me.cboItemQty.Items.Add("4")
        Me.cboItemQty.Items.Add("5")
        Me.cboItemQty.Items.Add("6")
        Me.cboItemQty.Items.Add("7")
        Me.cboItemQty.Items.Add("8")
        Me.cboItemQty.Items.Add("9")
        Me.cboItemQty.Items.Add("10")
        Me.cboItemQty.Location = New System.Drawing.Point(134, 1)
        Me.cboItemQty.Size = New System.Drawing.Size(40, 21)
        '
        'treeDish
        '
        Me.treeDish.ImageIndex = -1
        Me.treeDish.Location = New System.Drawing.Point(0, 28)
        Me.treeDish.SelectedImageIndex = -1
        Me.treeDish.Size = New System.Drawing.Size(200, 204)
        '
        'tbOrder
        '
        Me.tbOrder.Controls.Add(Me.txtCbo)
        Me.tbOrder.Controls.Add(Me.Label2)
        Me.tbOrder.Controls.Add(Me.cboQty)
        Me.tbOrder.Controls.Add(Me.btnRmv)
        Me.tbOrder.Controls.Add(Me.lblTotal)
        Me.tbOrder.Controls.Add(Me.txtTotalPrice)
        Me.tbOrder.Controls.Add(Me.lstOrder)
        Me.tbOrder.Location = New System.Drawing.Point(4, 4)
        Me.tbOrder.Size = New System.Drawing.Size(232, 238)
        Me.tbOrder.Text = "Order"
        '
        'txtCbo
        '
        Me.txtCbo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.txtCbo.Location = New System.Drawing.Point(140, 3)
        Me.txtCbo.Size = New System.Drawing.Size(72, 21)
        Me.txtCbo.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.Text = "Item Qty/Instruction"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboQty
        '
        Me.cboQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular)
        Me.cboQty.Location = New System.Drawing.Point(140, 3)
        Me.cboQty.Size = New System.Drawing.Size(88, 24)
        '
        'btnRmv
        '
        Me.btnRmv.Location = New System.Drawing.Point(4, 213)
        Me.btnRmv.Size = New System.Drawing.Size(88, 20)
        Me.btnRmv.Text = "RemoveItem"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(94, 216)
        Me.lblTotal.Size = New System.Drawing.Size(40, 20)
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(143, 212)
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalPrice.Text = ""
        '
        'lstOrder
        '
        Me.lstOrder.Columns.Add(Me.clmDish)
        Me.lstOrder.Columns.Add(Me.clmPrice)
        Me.lstOrder.Columns.Add(Me.clmQty)
        Me.lstOrder.Columns.Add(Me.clmInstruction)
        Me.lstOrder.Columns.Add(Me.clmItemID)
        Me.lstOrder.Columns.Add(Me.clmStock)
        Me.lstOrder.FullRowSelect = True
        Me.lstOrder.Location = New System.Drawing.Point(0, 30)
        Me.lstOrder.Size = New System.Drawing.Size(248, 178)
        Me.lstOrder.View = System.Windows.Forms.View.Details
        '
        'clmDish
        '
        Me.clmDish.Text = "Item Name"
        Me.clmDish.Width = 100
        '
        'clmPrice
        '
        Me.clmPrice.Text = "Unit Price"
        Me.clmPrice.Width = 60
        '
        'clmQty
        '
        Me.clmQty.Text = "Quantity"
        Me.clmQty.Width = 60
        '
        'clmInstruction
        '
        Me.clmInstruction.Text = "Instruction"
        Me.clmInstruction.Width = 200
        '
        'clmItemID
        '
        Me.clmItemID.Text = ""
        Me.clmItemID.Width = 0
        '
        'clmStock
        '
        Me.clmStock.Text = ""
        Me.clmStock.Width = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.Add("1")
        Me.ComboBox1.Items.Add("2")
        Me.ComboBox1.Items.Add("3")
        Me.ComboBox1.Items.Add("4")
        Me.ComboBox1.Items.Add("5")
        Me.ComboBox1.Items.Add("6")
        Me.ComboBox1.Items.Add("7")
        Me.ComboBox1.Items.Add("8")
        Me.ComboBox1.Items.Add("9")
        Me.ComboBox1.Items.Add("10")
        Me.ComboBox1.Items.Add("11")
        Me.ComboBox1.Items.Add("12")
        Me.ComboBox1.Items.Add("13")
        Me.ComboBox1.Items.Add("14")
        Me.ComboBox1.Items.Add("15")
        Me.ComboBox1.Items.Add("16")
        Me.ComboBox1.Items.Add("17")
        Me.ComboBox1.Items.Add("18")
        Me.ComboBox1.Location = New System.Drawing.Point(96, 184)
        Me.ComboBox1.Size = New System.Drawing.Size(96, 22)
        '
        'frmMain
        '
        Me.Controls.Add(Me.tbMenu)
        Me.Menu = Me.mnuMain
        Me.Text = "Menu Maker"

    End Sub

#End Region
    Sub createDB()

        Try
            If File.Exists( _
              mdConfiguration.applicationPath + "\dbeRestuarant.sdf") Then
                File.Delete( _
                  mdConfiguration.applicationPath + "\dbeRestuarant.sdf")
            End If

            Dim sqlEngine As New SqlCeEngine( _
              "Data Source=" & _
              mdConfiguration.applicationPath + "\dbeRestuarant.sdf")

            sqlEngine.CreateDatabase()
        Catch ex As Exception
            ShowErrors(ex)
        End Try
    End Sub

#Region "Error Messages"
    Public Shared Sub ShowErrors(ByVal e As SqlCeException)
        Dim errorCollection As SqlCeErrorCollection = e.Errors

        Dim bld As New StringBuilder
        Dim inner As Exception = e.InnerException

        If Not inner Is Nothing Then
            MessageBox.Show(("Inner Exception: " & inner.ToString()))
        End If
        Dim err As SqlCeError
        ' Enumerate each error to a message box.
        For Each err In errorCollection
            bld.Append((ControlChars.Cr & _
                        " Error Code: " & _
                        err.HResult.ToString("X")))
            bld.Append((ControlChars.Cr & _
                        " Message   : " & _
                        err.Message))
            bld.Append((ControlChars.Cr & _
                        " Minor Err.: " & _
                        err.NativeError))
            bld.Append((ControlChars.Cr & _
                        " Source    : " & _
                        err.Source))
            ' Retrieve the error parameter 
            ' numbers for each error.
            Dim numPar As Integer
            For Each numPar In err.NumericErrorParameters
                If 0 <> numPar Then
                    bld.Append((ControlChars.Cr & _
                                " Num. Par. : " & _
                                numPar))
                End If
            Next numPar
            ' Retrieve the error parameters for each error.
            Dim errPar As String
            For Each errPar In err.ErrorParameters
                If [String].Empty <> errPar Then
                    bld.Append((ControlChars.Cr & _
                                " Err. Par. : " & _
                                errPar))
                End If
            Next errPar
            MessageBox.Show(bld.ToString())
            bld.Remove(0, bld.Length)
        Next err
    End Sub
#End Region
    'Public Sub initRDA()
    '    rda.InternetUrl = "http://192.168.10.20/ceserver/sscesa20.dll"
    '    rda.LocalConnectionString = _
    '         "Provider=Microsoft.SQLSERVER." & _
    '               "OLEDB.CE.2.0;Data Source=\My Documents\dbeRestuarant.sdf"

    'End Sub

    Sub createOrder()

        Dim p As Integer
        Dim iIndex As Integer
        Dim iItemId As Integer
        Dim iRowCount As Integer

        Dim sItemPrice As String
        Dim sItemId As String
        Dim sTemp As String
        Dim sItemStock As String
        Dim strItemQty As String

        Dim dPrice As Double
        Dim dTotalPrice As Double

        Dim bitemExist As Boolean

        Dim tmpNode1 As TreeNode

        iRowCount = lstOrder.Items.Count

        For Each tmpNode1 In Me.treeDish.Nodes

            Dim tmpNode2 As TreeNode

            For Each tmpNode2 In tmpNode1.Nodes

                Dim tmpNode3 As TreeNode

                For Each tmpNode3 In tmpNode2.Nodes

                    If tmpNode3.Checked = True Then
                        Dim lstItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem
                        Dim lstSubItem1 As System.Windows.Forms.ListViewItem.ListViewSubItem = New System.Windows.Forms.ListViewItem.ListViewSubItem
                        Dim lstSubItem2 As System.Windows.Forms.ListViewItem.ListViewSubItem = New System.Windows.Forms.ListViewItem.ListViewSubItem
                        Dim lstSubItem3 As System.Windows.Forms.ListViewItem.ListViewSubItem = New System.Windows.Forms.ListViewItem.ListViewSubItem
                        Dim lstSubItem4 As System.Windows.Forms.ListViewItem.ListViewSubItem = New System.Windows.Forms.ListViewItem.ListViewSubItem
                        Dim lstSubItem5 As System.Windows.Forms.ListViewItem.ListViewSubItem = New System.Windows.Forms.ListViewItem.ListViewSubItem

                        p = InStr(tmpNode3.Tag, "@", CompareMethod.Binary)
                        sItemPrice = Mid(tmpNode3.Tag, 1, p - 1)
                        dPrice = sItemPrice
                        sTemp = Mid(tmpNode3.Tag, p + 1, Len(tmpNode3.Tag) - p)

                        p = InStr(sTemp, "#", CompareMethod.Binary)
                        sItemId = Mid(sTemp, 1, p - 1)
                        sTemp = Mid(sTemp, p + 1, Len(sTemp) - p)

                        p = InStr(sTemp, "$", CompareMethod.Binary)
                        sItemStock = Mid(sTemp, 1, p - 1)
                        strItemQty = Mid(sTemp, p + 1, Len(sTemp) - p)

                        For iIndex = 0 To iRowCount - 1
                            iItemId = lstOrder.Items(iIndex).SubItems(4).Text
                            If iItemId = CInt(sItemId) Then
                                bitemExist = True
                            End If
                        Next

                        If bitemExist = False Then

                            lstSubItem1.Text = dPrice
                            dTotalPrice += dPrice
                            txtTotalPrice.Text = dTotalPrice
                            lstItem1.SubItems.Add(lstSubItem1)
                            lstSubItem2.Text = strItemQty
                            lstItem1.SubItems.Add(lstSubItem2)
                            lstSubItem3.Text = ""
                            lstItem1.SubItems.Add(lstSubItem3)
                            lstSubItem4.Text = sItemId
                            lstItem1.SubItems.Add(lstSubItem4)
                            lstSubItem5.Text = sItemStock
                            lstItem1.SubItems.Add(lstSubItem5)
                            lstItem1.Text = tmpNode3.Text
                            lstOrder.Items.Add(lstItem1)
                        Else
                            bitemExist = False
                        End If
                        CalculateTotalPrice()
                    End If
                Next
            Next
        Next
        Me.lstOrder.View = System.Windows.Forms.View.Details
    End Sub

    Private Sub tbMenu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMenu.SelectedIndexChanged
        If Me.tbMenu.SelectedIndex = 2 Then

            createOrder()
            'ElseIf Me.tbMenu.SelectedIndex = 1 Or Me.tbMenu.SelectedIndex = 0 Then
            'lstOrder.Items.Clear()
        End If
    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboItemQty.SelectedIndex = 0
        bLoad = False
        createDB()
        Try
            initRDA()
            rda.Pull("tCategory", "SELECT nCtgry_Id,cCtgry_Name FROM tCategory WHERE nCtgyActive=1", rdaOleDbConnectString)
            rda.Pull("tType", "SELECT nType_Id,cType_Name,nCtgry_Id FROM tType WHERE nTypeActive=1", rdaOleDbConnectString)
            rda.Pull("tItem", "SELECT nItem_Id,cItem_SC,mDinePrice,nItem_Stock,nType_Id FROM tItem WHERE nItemActive=1", rdaOleDbConnectString)
            rda.Pull("tInstruction", "SELECT nInstruction_Id,cInstruction,nItem_Id FROM tInstruction WHERE nActiveInstruction=1", rdaOleDbConnectString)
            rda.Pull("tTable_Info", "SELECT nTable_Id,cTableNumber FROM tTable_Info", rdaOleDbConnectString)
            CreatcboTable()
        Catch ex As Exception
            ShowErrors(ex)
        End Try
        CreateMenuTree()
        bLoad = True
    End Sub

    Public Sub CreateMenuTree()

        Dim icountCategory As Integer
        Dim icountType As Integer
        Dim icountItem As Integer
        Dim iCategoryId As Integer
        Dim iTypeId As Integer

        Dim i As Integer

        Dim strSQL As String

        Dim dsCategory As DataSet
        Dim dsType As DataSet
        Dim dsItem As DataSet

        Dim daCategory As SqlServerCe.SqlCeDataAdapter
        Dim daType As SqlServerCe.SqlCeDataAdapter
        Dim daItem As SqlServerCe.SqlCeDataAdapter

        Try
            connDishInfo.Open()
            strSQL = "SELECT * From tCategory"
            dsCategory = New DataSet("tCategory")
            daCategory = New SqlServerCe.SqlCeDataAdapter(strSQL, connDishInfo)
            daCategory.Fill(dsCategory, "tCategory")
            icountCategory = dsCategory.Tables("tCategory").Rows.Count
            If icountCategory > 0 Then
                For i = 0 To icountCategory - 1
                    Dim tmpMnuCategory As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode
                    Me.treeDish.Nodes.Add(tmpMnuCategory)

                    iCategoryId = dsCategory.Tables("tCategory").Rows(i).Item(0)
                    tmpMnuCategory.Text = dsCategory.Tables("tCategory").Rows(i).Item(1)
                    'tmpMnuCategory.Text = "Category" & i

                    strSQL = "SELECT nType_Id,cType_Name From tType WHERE nCtgry_Id=" + CStr(iCategoryId) + ""
                    dsType = New DataSet("tType")
                    daType = New SqlServerCe.SqlCeDataAdapter(strSQL, connDishInfo)
                    daType.Fill(dsType, "tType")
                    icountType = dsType.Tables("tType").Rows.Count
                    If icountType > 0 Then
                        Dim j As Integer = 0
                        For j = 0 To icountType - 1

                            Dim tmpType As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode
                            tmpMnuCategory.Nodes.Add(tmpType)
                            iTypeId = dsType.Tables("tType").Rows(j).Item(0)
                            tmpType.Text = dsType.Tables("tType").Rows(j).Item(1)

                            strSQL = "SELECT nItem_Id,cItem_SC,mDinePrice,nItem_Stock From tItem WHERE nType_Id=" + CStr(iTypeId) + ""
                            dsItem = New DataSet("tItem")
                            daItem = New SqlServerCe.SqlCeDataAdapter(strSQL, connDishInfo)
                            daItem.Fill(dsItem, "tItem")
                            icountItem = dsItem.Tables("tItem").Rows.Count
                            If icountItem > 0 Then
                                Dim k As Integer
                                For k = 0 To icountItem - 1
                                    Dim tmpItem As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode
                                    tmpType.Nodes.Add(tmpItem)
                                    tmpItem.Text = dsItem.Tables("tItem").Rows(k).Item(1)
                                    tmpItem.Tag = dsItem.Tables("tItem").Rows(k).Item(2) & "@" & dsItem.Tables("tItem").Rows(k).Item(0) & "#" & dsItem.Tables("tItem").Rows(k).Item(3)
                                Next
                            End If
                        Next
                    End If
                Next
            End If
            Me.treeDish.SelectedImageIndex = -1
            Me.treeDish.CheckBoxes = True
            Me.treeDish.Size = New System.Drawing.Size(240, 256)

        Catch ex As Exception
            ShowErrors(ex)
            connDishInfo.Close()
        Finally
            connDishInfo.Close()
            dsCategory = Nothing
            dsType = Nothing
            dsItem = Nothing

            daCategory = Nothing
            daType = Nothing
            daItem = Nothing

        End Try
    End Sub

    Private Function CreatcboTable()

        Dim strSQL As String
        Dim icountTable As Integer

        Dim dsTableInfo As DataSet
        Dim daTableInfo As SqlServerCe.SqlCeDataAdapter
        Dim rda1 As New SqlCeRemoteDataAccess

        cboTblId.DataSource = Nothing
        cboTblId.Items.Clear()

        strSQL = "SELECT * From tTable_Info"
        dsTableInfo = New DataSet("tTable_Info")
        daTableInfo = New SqlServerCe.SqlCeDataAdapter(strSQL, connDishInfo)
        daTableInfo.Fill(dsTableInfo, "tTable_Info")
        icountTable = dsTableInfo.Tables("tTable_Info").Rows.Count

        If icountTable > 1 Then
            cboTblId.DataSource = dsTableInfo.Tables("tTable_Info")
            cboTblId.DisplayMember = "cTableNumber"
            cboTblId.ValueMember = "nTable_Id"
        End If
    End Function

    Private Sub btnRmv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRmv.Click

        Dim iIndex As Integer
        Dim iItemId As Integer
        Dim iRowCount As Integer

        iRowCount = lstOrder.Items.Count

        If iRowCount > 0 Then
            For iIndex = 0 To iRowCount - 1
                If lstOrder.Items(iIndex).Selected = True Then
                    iItemId = lstOrder.Items(iIndex).SubItems(4).Text
                    CreateMenuTreeAfterItemRemove(iItemId)
                    lstOrder.Items.RemoveAt(iIndex)
                    CalculateTotalPrice()
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Sub CreateMenuTreeAfterItemRemove(ByVal tmpItemId As Integer)

        Dim p As Integer
        Dim sItemPrice As String
        Dim sTemp As String
        Dim sItemStock As String

        Dim iItemId As Integer
        Dim dPrice As Double
        Dim dItemPrice As Double

        Dim tmpNode1 As TreeNode

        For Each tmpNode1 In Me.treeDish.Nodes
            Dim tmpNode2 As TreeNode
            For Each tmpNode2 In tmpNode1.Nodes
                Dim tmpNode3 As TreeNode
                For Each tmpNode3 In tmpNode2.Nodes
                    p = InStr(tmpNode3.Tag, "@", CompareMethod.Binary)
                    sItemPrice = Mid(tmpNode3.Tag, 1, p - 1)
                    dPrice = sItemPrice
                    sTemp = Mid(tmpNode3.Tag, p + 1, Len(tmpNode3.Tag) - p)

                    p = InStr(sTemp, "#", CompareMethod.Binary)
                    iItemId = Mid(sTemp, 1, p - 1)

                    If tmpNode3.Checked = True And iItemId = tmpItemId Then
                        'dItemPrice = txtTotalPrice.Text
                        'If (dItemPrice - dPrice) > 0 Then
                        'txtTotalPrice.Text = dItemPrice - dPrice
                        'Else
                        'txtTotalPrice.Text = vbNullString
                        'End If
                        tmpNode3.Checked = False
                        CalculateTotalPrice()
                        Exit Sub
                    End If
                Next
            Next
        Next
        Me.lstOrder.View = System.Windows.Forms.View.Details
    End Sub

    Private Sub cboQty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboQty.SelectedIndexChanged
        txtCbo.Text = cboQty.Text
    End Sub

    Private Sub lstOrder_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstOrder.ItemActivate

        Dim iIndex As Integer
        Dim iItemId As Integer
        Dim iRowCount As Integer
        iRowCount = lstOrder.Items.Count
        If iRowCount > 0 Then
            iIndex = lstOrder.SelectedIndices(0)
            iItemId = lstOrder.Items(iIndex).SubItems(4).Text
            PullInstructionCombo(iItemId)
        End If
    End Sub

    Private Function PullInstructionCombo(ByVal tmpItemId As Integer)
        Dim strSQL As String
        Dim icountTable As Integer

        Dim dsInsrtuction As DataSet
        Dim daInsrtuction As SqlServerCe.SqlCeDataAdapter

        cboQty.DataSource = Nothing
        cboQty.Items.Clear()

        strSQL = "SELECT cInstruction From tInstruction WHERE nItem_Id=" + CStr(tmpItemId) + ""
        dsInsrtuction = New DataSet("tInstruction")
        daInsrtuction = New SqlServerCe.SqlCeDataAdapter(strSQL, connDishInfo)
        daInsrtuction.Fill(dsInsrtuction, "tInstruction")
        icountTable = dsInsrtuction.Tables("tInstruction").Rows.Count

        If icountTable > 1 Then
            cboQty.DataSource = dsInsrtuction.Tables("tInstruction")
            cboQty.DisplayMember = "cInstruction"
        End If
    End Function

    Private Sub txtCbo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCbo.TextChanged
        Dim iIndex As Integer
        Dim iItemId As Integer
        Dim iRowCount As Integer
        Dim iItemStock As Integer


        iRowCount = lstOrder.Items.Count

        If iRowCount > 0 Then
            For iIndex = 0 To iRowCount - 1
                If lstOrder.Items(iIndex).Selected = True Then
                    'iItemStock = lstOrder.Items(iIndex).SubItems(5).Text
                    If IsNumeric(Trim(txtCbo.Text)) Then
                        'If iItemStock >= CStr(Trim(txtCbo.Text)) Then
                        lstOrder.Items(iIndex).SubItems(2).Text = Trim(txtCbo.Text)
                        CalculateTotalPrice()
                        ' End If
                ElseIf Not IsNumeric(Trim(txtCbo.Text)) Then
                    lstOrder.Items(iIndex).SubItems(3).Text = Trim(txtCbo.Text)
                End If
                Exit For
                End If
            Next
        End If
    End Sub

    Private Function CalculateTotalPrice()
        Dim iRowCount As Integer
        Dim iIndex As Integer
        Dim iItemQty As Integer

        Dim dUnitPrice As Double
        Dim dTotalPrice As Double

        iRowCount = lstOrder.Items.Count

        If iRowCount > 0 Then
            For iIndex = 0 To iRowCount - 1
                iItemQty = lstOrder.Items(iIndex).SubItems(2).Text
                dUnitPrice = lstOrder.Items(iIndex).SubItems(1).Text
                dTotalPrice += (iItemQty * dUnitPrice)
            Next
            txtTotalPrice.Text = dTotalPrice
        Else
            txtTotalPrice.Text = vbNullString
        End If
    End Function

    Private Sub lstOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstOrder.SelectedIndexChanged

        Dim iIndex As Integer
        Dim iRowCount As Integer
        Dim iItemStock As Integer

        iRowCount = lstOrder.Items.Count

        If iRowCount > 0 Then
            For iIndex = 0 To iRowCount - 1
                If lstOrder.Items(iIndex).Selected = True Then
                    If Trim(lstOrder.Items(iIndex).SubItems(3).Text) = vbNullString Then
                        txtCbo.Text = vbNullString
                        Exit For
                    ElseIf Trim(lstOrder.Items(iIndex).SubItems(3).Text) <> vbNullString Then
                        txtCbo.Text = Trim(lstOrder.Items(iIndex).SubItems(3).Text)
                        Exit For
                    End If
                End If
            Next
        End If

        cboQty.DataSource = Nothing
        cboQty.Items.Clear()
    End Sub

    'Private Function GetSystemDate() As Date
    '    Dim strSQL As String

    '    Dim cmdDate As SqlServerCe.SqlCeCommand
    '    Dim drDate As SqlServerCe.SqlCeDataReader

    '    rda.Pull("tSystemDate", "SELECT GETDATE() FROM tTable_Info", rdaOleDbConnectString)
    '    strSQL = "SELECT * From tSystemDate"

    '    Try
    '        cmdDate = New SqlServerCe.SqlCeCommand
    '        cmdDate.Connection = connDishInfo
    '        cmdDate.CommandText = strSQL
    '        drDate = cmdDate.ExecuteReader()
    '        While drDate.Read
    '            GetSystemDate = drDate.GetValue(0)
    '        End While
    '    Catch ex As Exception
    '        MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
    '    End Try

    '    cmdDate = Nothing
    '    drDate = Nothing
    '    connDishInfo.Close()
    '    connDishInfo.Open()
    'End Function

    Private Function IsTableEmpty() As Boolean
        Dim strSQL As String
        Dim strSelectedTable As String
        Dim icountTable As Integer
        Dim iIndex As Integer
        Dim bTabelIsEmpty As Boolean = False

        Dim dsTableInfo As DataSet
        Dim daTableInfo As SqlServerCe.SqlCeDataAdapter

        strSelectedTable = Trim(cboTblId.SelectedValue)

        rda.Pull("tTable_Info_Eampty", "SELECT nTable_Id,cTableNumber FROM tTable_Info WHERE nStatus=0 AND nTableActive=1", rdaOleDbConnectString)

        strSQL = "SELECT nTable_Id From tTable_Info_Eampty"
        dsTableInfo = New DataSet("tTable_Info_Eampty")
        daTableInfo = New SqlServerCe.SqlCeDataAdapter(strSQL, connDishInfo)
        daTableInfo.Fill(dsTableInfo, "tTable_Info_Eampty")
        icountTable = dsTableInfo.Tables("tTable_Info_Eampty").Rows.Count

        For iIndex = 0 To icountTable - 1
            If strSelectedTable = dsTableInfo.Tables("tTable_Info_Eampty").Rows(iIndex).Item(0) Then
                bTabelIsEmpty = True
            End If
        Next
        IsTableEmpty = bTabelIsEmpty
    End Function

    Private Sub mnuItmSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItmSubmit.Click

        Dim iOrderedItemCount As Integer
        Dim iIndex As Integer
        Dim iItemId As Integer
        Dim iItemQty As Integer
        Dim dUnitPrice As Double
        Dim iCustomerId As Integer
        Dim iOrderId As Integer

        Dim strOrderDate As String

        Dim strComputername As String = "uysysjami_PDA"
        Dim strUserName As String = sysUser
        Dim strSQLDropCust_Info As String
        Dim strSQLDropOrder_Info As String
        Dim strInstruction As String

        strOrderDate = DateTime.Parse(Date.Today.Now).ToString("MM/dd/yyyy hh:mm:ss tt")

        If txtNumberOfGuest.Text = vbNullString Then
            MessageBox.Show("Please give the guest number.", "eRestuarant")
            tbMenu.SelectedIndex = 0
            txtNumberOfGuest.Focus()
            Exit Sub
        End If

        If IsTableEmpty() = False Then
            MessageBox.Show("Selected Table is not Empty.", "eRestuarant")
            tbMenu.SelectedIndex = 0
            cboTblId.Focus()
            strSQLDropCust_Info = "DROP TABLE tTable_Info_Eampty"
            DropTable(strSQLDropCust_Info)
            Exit Sub
        End If

        Try
            iOrderedItemCount = lstOrder.Items.Count
            If iOrderedItemCount > 0 Then
                If connDishInfo.State <> ConnectionState.Closed Then
                    connDishInfo.Close()
                End If

                rda.SubmitSql("INSERT INTO tCust_Info(cCust_Name,cAddress,cCompany,cEmail,nIssueNo, cUserId,cTermenal,dAccessTime)" & _
                             " VALUES('PDA','" + Trim(txtCustAdd.Text) + _
                             "','" + Trim(txtCustCompany.Text) + "','" + Trim(txtEmail.Text) + _
                             "',0,'" + strUserName + "','" + strComputername + "','" + strOrderDate + "')", rdaOleDbConnectString)

                rda.Pull("tCust_Info", "SELECT nCust_Id FROM tCust_Info", rdaOleDbConnectString)
                iCustomerId = GetCustomerID()

                rda.SubmitSql("INSERT INTO tOrder_Payment(dOrder_date,nTable_Id,nCust_Id," & _
                              "nNumberofGuests,mTotalPrice,mDiscount,mService_Charge,mNetpay,nOrderStatus," & _
                              "cUserId,cTerminal,dAccessTime) VALUES('" + strOrderDate + "'," + CStr(Trim(cboTblId.SelectedValue)) + _
                              "," + CStr(iCustomerId) + "," + CStr(Trim(txtNumberOfGuest.Text)) + _
                              "," + CStr(Trim(txtTotalPrice.Text)) + ",0,0," + CStr(Trim(txtTotalPrice.Text)) + _
                              ",0,'" + strUserName + "','" + strComputername + "','" + strOrderDate + "')", rdaOleDbConnectString)

                rda.Pull("tOrder_Payment", "SELECT nOrder_Id FROM tOrder_Payment", rdaOleDbConnectString)

                iOrderId = GetOrderID()

                rda.SubmitSql("UPDATE tTable_Info SET nStatus=1 WHERE nTable_Id=" + CStr(Trim(cboTblId.SelectedValue)) + _
                              "", rdaOleDbConnectString)

                For iIndex = 0 To iOrderedItemCount - 1
                    iItemId = lstOrder.Items(iIndex).SubItems(4).Text
                    dUnitPrice = lstOrder.Items(iIndex).SubItems(1).Text
                    iItemQty = lstOrder.Items(iIndex).SubItems(2).Text
                    strInstruction = lstOrder.Items(iIndex).SubItems(3).Text

                    rda.SubmitSql("INSERT INTO tOrdered_Item(nOrder_Id,nItem_Id,mUnitPrice,nItem_Qty,cInstruction," & _
                                  "cUserId,cTerminal,dAccessTime) VALUES(" + CStr(iOrderId) + "," + CStr(iItemId) + _
                                  "," + CStr(dUnitPrice) + "," + CStr(iItemQty) + ",'" + strInstruction + _
                                  "','" + strUserName + "','" + strComputername + "','" + strOrderDate + "')", rdaOleDbConnectString)

                Next

                strSQLDropCust_Info = "DROP TABLE tCust_Info"
                strSQLDropOrder_Info = "DROP TABLE tOrder_Payment"
                clearAllFields()
                DropTable(strSQLDropCust_Info)
                DropTable(strSQLDropOrder_Info)
                MessageBox.Show("Your Order Saved Successfully", "eRestuarant")
            Else
                MessageBox.Show("Select Item to Order", "eRestuarant")
            End If
        Catch ex As Exception
            ShowErrors(ex)
            connDishInfo.Close()
        Finally
            connDishInfo.Close()
            Dim frmNew As New frmMain
            frmNew.Show()
            Me.Dispose()
        End Try
    End Sub

    Private Function clearAllFields()

        Dim tmpNode1 As TreeNode

        For Each tmpNode1 In Me.treeDish.Nodes
            Dim tmpNode2 As TreeNode
            For Each tmpNode2 In tmpNode1.Nodes
                Dim tmpNode3 As TreeNode
                For Each tmpNode3 In tmpNode2.Nodes
                    If tmpNode3.Checked = True Then
                        tmpNode3.Checked = False
                    End If
                Next
            Next
        Next
        treeDish.CollapseAll()
        ClearTextField(tbCustinfo)
        ClearTextField(tbOrder)
        lstOrder.Items.Clear()
        cboTblId.SelectedIndex = 0
        tbMenu.SelectedIndex = 0
    End Function

    Public Function ClearTextField(ByRef tmpTab As TabPage)
        Dim ctrl As Control
        For Each ctrl In tmpTab.Controls
            If TypeName(ctrl) = "TextBox" Then  'Or TypeName(ctrl) = "RichTextBox")And DonotClearText = False
                ctrl.Text = vbNullString
            End If
        Next
    End Function

    Private Function GetOrderDate() As Date

        Dim strSQL As String
        Dim iDataSetRow As String


        Dim dsOrderDate As DataSet
        Dim daOrderDate As SqlCeDataAdapter

        Try
            connDishInfo.Open()
            strSQL = "SELECT MAX(nCust_Id) FROM tCust_Info"
            dsOrderDate = New DataSet("Cust_Id")
            daOrderDate = New SqlCeDataAdapter(strSQL, connDishInfo)
            daOrderDate.Fill(dsOrderDate, "Order_Date")
        Catch ex As Exception
            ShowErrors(ex)
            connDishInfo.Close()
        Finally
            connDishInfo.Close()
        End Try

        iDataSetRow = dsOrderDate.Tables("Cust_Id").Rows.Count

        If iDataSetRow > 0 Then
            GetOrderDate = dsOrderDate.Tables("Cust_Id").Rows(0).Item(0)
        End If
        dsOrderDate = Nothing
        daOrderDate = Nothing
    End Function

    Private Function GetCustomerID() As Integer

        Dim strSQL As String
        Dim iCustomerId As Integer
        Dim iDataSetRow As Integer

        Dim dsCustomerId As DataSet
        Dim daCustomerId As SqlCeDataAdapter

        Try
            connDishInfo.Open()
            strSQL = "SELECT MAX(nCust_Id) FROM tCust_Info"
            dsCustomerId = New DataSet("Cust_Id")
            daCustomerId = New SqlCeDataAdapter(strSQL, connDishInfo)
            daCustomerId.Fill(dsCustomerId, "Cust_Id")
        Catch ex As Exception
            ShowErrors(ex)
            connDishInfo.Close()
        Finally
            connDishInfo.Close()
        End Try

        iDataSetRow = dsCustomerId.Tables("Cust_Id").Rows.Count

        If iDataSetRow > 0 Then
            iCustomerId = dsCustomerId.Tables("Cust_Id").Rows(0).Item(0)
        Else
            iCustomerId = 1
        End If
        GetCustomerID = iCustomerId
        dsCustomerId = Nothing
        daCustomerId = Nothing
    End Function

    Private Function GetOrderID() As Integer

        Dim strSQL As String
        Dim iOrderId As Integer
        Dim iDataSetRow As Integer

        Dim dsOrderId As DataSet
        Dim daOrderId As SqlCeDataAdapter

        Try
            connDishInfo.Open()
            strSQL = "SELECT MAX(nOrder_Id) FROM tOrder_Payment"
            dsOrderId = New DataSet("Order_Id")
            daOrderId = New SqlCeDataAdapter(strSQL, connDishInfo)
            daOrderId.Fill(dsOrderId, "Order_Id")
        Catch ex As Exception
            ShowErrors(ex)
            connDishInfo.Close()
        Finally
            connDishInfo.Close()
        End Try

        iDataSetRow = dsOrderId.Tables("Order_Id").Rows.Count

        If iDataSetRow > 0 Then
            iOrderId = dsOrderId.Tables("Order_Id").Rows(0).Item(0)
        Else
            iOrderId = 1
        End If
        GetOrderID = iOrderId
        dsOrderId = Nothing
        daOrderId = Nothing
    End Function

    Private Function DropTable(ByVal strSQLTemp As String)

        Dim cmdDropTable As New SqlCeCommand
        Try
            connDishInfo.Open()
            cmdDropTable.Connection = connDishInfo
            cmdDropTable.CommandText = strSQLTemp
            cmdDropTable.ExecuteNonQuery()
        Catch ex As Exception
            ShowErrors(ex)
            connDishInfo.Close()
        Finally
            connDishInfo.Close()
        End Try
    End Function

    Private Sub mnuMainExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainExit.Click
        Dim Itype As Integer
        Itype = MsgBox("Do you want to Exit", MsgBoxStyle.YesNo, "eRestuarant")
        If Itype = MsgBoxResult.Yes Then
            Application.Exit()
        End If
        'Me.Close()
    End Sub

    Private Sub txtNumberOfGuest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumberOfGuest.KeyPress
        mdConfiguration.ValidationForNumaricData(e, txtNumberOfGuest)
    End Sub

    Private Sub txtEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
        If txtEmail.Text <> vbNullString Then
            If mdConfiguration.ValidationForEmailAddress(txtEmail) = False Then
                MessageBox.Show("Please give valid Email address")
            End If
        End If
    End Sub

    Private Sub txtCustName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustName.KeyPress
        mdConfiguration.ValidationForCharacter(e, txtCustName)
    End Sub

    Private Sub treeDish_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeDish.AfterCheck
        Dim iRowCount As Integer
        Dim iIndex As Integer
        Dim iItemId As Integer
        Dim p As Integer
        Dim iNodePosition As Integer

        Dim sItemPrice As String
        Dim sItemId As String
        Dim sTemp As String
        Dim sItemStock As String

        Dim dPrice As Double
        Dim dTotalPrice As Double

        iRowCount = lstOrder.Items.Count
        iNodePosition = e.Node.GetNodeCount(True)

        If iNodePosition = 0 And e.Node.Tag <> vbNullString Then
            p = InStr(e.Node.Tag, "@", CompareMethod.Binary)
            sItemPrice = Mid(e.Node.Tag, 1, p - 1)
            dPrice = sItemPrice
            sTemp = Mid(e.Node.Tag, p + 1, Len(e.Node.Tag) - p)

            p = InStr(sTemp, "#", CompareMethod.Binary)
            sItemId = Mid(sTemp, 1, p - 1)
            sItemStock = Mid(sTemp, p + 1, Len(sTemp) - p)
            sTemp = sItemStock

            If e.Node.Checked = False Then
                p = InStr(sTemp, "$", CompareMethod.Binary)
                sItemStock = Mid(sTemp, 1, p - 1)
                e.Node.Tag = sItemPrice & "@" & sItemId & "#" & sItemStock
                If strItemId <> vbNullString Then
                    strItemId = vbNullString
                    cboItemQty.SelectedIndex = 0
                End If
                For iIndex = 0 To iRowCount - 1
                    iItemId = lstOrder.Items(iIndex).SubItems(4).Text
                    If iItemId = CInt(sItemId) Then
                        lstOrder.Items.RemoveAt(iIndex)
                        Exit For
                    End If
                Next
            Else
                strItemId = sItemId
                e.Node.Tag = ""
                e.Node.Tag = sItemPrice & "@" & sItemId & "#" & sItemStock & "$" & cboItemQty.Text
            End If
            CalculateTotalPrice()
        Else
            e.Node.Checked = False
        End If
    End Sub

    Private Sub cboItemQty_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItemQty.SelectedIndexChanged
        Dim p As Integer
        Dim sItemPrice As String
        Dim sTemp As String
        Dim sItemId As String
        Dim sItemStock As String
        Dim strItemQty As String

        If bLoad = True Then
            If Trim(strItemId) <> vbNullString Then
                Dim tmpNode1 As TreeNode

                For Each tmpNode1 In Me.treeDish.Nodes
                    Dim tmpNode2 As TreeNode
                    For Each tmpNode2 In tmpNode1.Nodes
                        Dim tmpNode3 As TreeNode
                        For Each tmpNode3 In tmpNode2.Nodes
                            p = InStr(tmpNode3.Tag, "@", CompareMethod.Binary)
                            sItemPrice = Mid(tmpNode3.Tag, 1, p - 1)
                            sTemp = Mid(tmpNode3.Tag, p + 1, Len(tmpNode3.Tag) - p)

                            p = InStr(sTemp, "#", CompareMethod.Binary)
                            sItemId = Mid(sTemp, 1, p - 1)
                            sTemp = Mid(sTemp, p + 1, Len(sTemp) - p)

                            If sItemId = strItemId Then
                                p = InStr(sTemp, "$", CompareMethod.Binary)
                                sItemStock = Mid(sTemp, 1, p - 1)
                                strItemQty = Mid(sTemp, p + 1, Len(sTemp) - p)

                                tmpNode3.Tag = sItemPrice & "@" & sItemId & "#" & sItemStock & "$" & cboItemQty.Text
                                strItemId = vbNullString
                                cboItemQty.SelectedIndex = 0
                                Exit Sub
                            End If
                        Next
                    Next
                Next
            End If
        Else
            bLoad = True
        End If
    End Sub

    'Private Sub treeDish_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeDish.AfterSelect
    '    Dim iRowCount As Integer
    '    Dim iIndex As Integer
    '    Dim iItemId As Integer
    '    Dim p As Integer
    '    Dim iNodePosition As Integer

    '    Dim sItemPrice As String
    '    Dim sItemId As String
    '    Dim sTemp As String
    '    Dim sItemStock As String

    '    Dim dPrice As Double
    '    Dim dTotalPrice As Double

    '    iRowCount = lstOrder.Items.Count
    '    iNodePosition = e.Node.GetNodeCount(True)

    '    If iNodePosition = 0 And e.Node.Tag <> vbNullString Then
    '        p = InStr(e.Node.Tag, "@", CompareMethod.Binary)
    '        sItemPrice = Mid(e.Node.Tag, 1, p - 1)
    '        dPrice = sItemPrice
    '        sTemp = Mid(e.Node.Tag, p + 1, Len(e.Node.Tag) - p)

    '        p = InStr(sTemp, "#", CompareMethod.Binary)
    '        sItemId = Mid(sTemp, 1, p - 1)
    '        If e.Node.Checked = True Then
    '            strItemId = sItemId    
    '        End If
    '    End If
    'End Sub

    'Private Sub treeDish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeDish.Click
    '    Dim p As Integer
    '    Dim sItemPrice As String
    '    Dim sTemp As String
    '    Dim sItemId As String
    '    Dim sItemStock As String
    '    Dim strItemQty As String

    '    If bLoad = True Then
    '        If Trim(strItemId) <> vbNullString Then
    '            Dim tmpNode1 As TreeNode

    '            For Each tmpNode1 In Me.treeDish.Nodes
    '                Dim tmpNode2 As TreeNode
    '                For Each tmpNode2 In tmpNode1.Nodes
    '                    Dim tmpNode3 As TreeNode
    '                    For Each tmpNode3 In tmpNode2.Nodes
    '                        p = InStr(tmpNode3.Tag, "@", CompareMethod.Binary)
    '                        sItemPrice = Mid(tmpNode3.Tag, 1, p - 1)
    '                        sTemp = Mid(tmpNode3.Tag, p + 1, Len(tmpNode3.Tag) - p)

    '                        p = InStr(sTemp, "#", CompareMethod.Binary)
    '                        sItemId = Mid(sTemp, 1, p - 1)
    '                        If tmpNode3.Checked = True Then
    '                            strItemId = sItemId
    '                        End If
    '                    Next
    '                Next
    '            Next
    '        End If
    '    Else
    '        bLoad = True
    '    End If
    'End Sub

    Private Sub mnuMainReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainReset.Click
        Dim frmNew As New frmMain
        frmNew.Show()
        Me.Dispose()
    End Sub



    
End Class
