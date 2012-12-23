Public Class frmAdmin
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
    Friend WithEvents tlbrReport As System.Windows.Forms.ToolBar
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnReportStock As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnSalesReport As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnInvoice As System.Windows.Forms.ToolBarButton
    Friend WithEvents imglAdmin As System.Windows.Forms.ImageList
    Friend WithEvents btnDbSetting As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnEntry As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnGlobalSetting As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnPrinter As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnUsr As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnPaymentStatus As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnReports As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnLogin As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnChngUsr As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbrAdmin As System.Windows.Forms.ToolBar
    Friend WithEvents btnPeopleEntry As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnConvertReportToExcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnCategory As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnType As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnItem As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnInstruction As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnTbl As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnCardType As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnStock As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnEmployee As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbrSubEntry As System.Windows.Forms.ToolBar
    Friend WithEvents btnAddTop As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAdmin))
        Me.tlbrReport = New System.Windows.Forms.ToolBar
        Me.btnReportStock = New System.Windows.Forms.ToolBarButton
        Me.btnSalesReport = New System.Windows.Forms.ToolBarButton
        Me.btnInvoice = New System.Windows.Forms.ToolBarButton
        Me.btnConvertReportToExcel = New System.Windows.Forms.ToolBarButton
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.imglAdmin = New System.Windows.Forms.ImageList(Me.components)
        Me.tlbrAdmin = New System.Windows.Forms.ToolBar
        Me.btnDbSetting = New System.Windows.Forms.ToolBarButton
        Me.btnEntry = New System.Windows.Forms.ToolBarButton
        Me.btnPeopleEntry = New System.Windows.Forms.ToolBarButton
        Me.btnGlobalSetting = New System.Windows.Forms.ToolBarButton
        Me.btnPrinter = New System.Windows.Forms.ToolBarButton
        Me.btnUsr = New System.Windows.Forms.ToolBarButton
        Me.btnPaymentStatus = New System.Windows.Forms.ToolBarButton
        Me.btnReports = New System.Windows.Forms.ToolBarButton
        Me.btnLogin = New System.Windows.Forms.ToolBarButton
        Me.btnChngUsr = New System.Windows.Forms.ToolBarButton
        Me.btnExit = New System.Windows.Forms.ToolBarButton
        Me.btnCategory = New System.Windows.Forms.ToolBarButton
        Me.btnType = New System.Windows.Forms.ToolBarButton
        Me.btnItem = New System.Windows.Forms.ToolBarButton
        Me.btnInstruction = New System.Windows.Forms.ToolBarButton
        Me.btnTbl = New System.Windows.Forms.ToolBarButton
        Me.btnCardType = New System.Windows.Forms.ToolBarButton
        Me.btnStock = New System.Windows.Forms.ToolBarButton
        Me.btnEmployee = New System.Windows.Forms.ToolBarButton
        Me.tlbrSubEntry = New System.Windows.Forms.ToolBar
        Me.btnAddTop = New System.Windows.Forms.ToolBarButton
        Me.SuspendLayout()
        '
        'tlbrReport
        '
        Me.tlbrReport.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.btnReportStock, Me.btnSalesReport, Me.btnInvoice, Me.btnConvertReportToExcel})
        Me.tlbrReport.ButtonSize = New System.Drawing.Size(120, 38)
        Me.tlbrReport.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlbrReport.DropDownArrows = True
        Me.tlbrReport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbrReport.Location = New System.Drawing.Point(130, 482)
        Me.tlbrReport.Name = "tlbrReport"
        Me.tlbrReport.ShowToolTips = True
        Me.tlbrReport.Size = New System.Drawing.Size(670, 44)
        Me.tlbrReport.TabIndex = 2
        Me.tlbrReport.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        Me.tlbrReport.Visible = False
        '
        'btnReportStock
        '
        Me.btnReportStock.Enabled = False
        Me.btnReportStock.Text = "Stock Report"
        Me.btnReportStock.Visible = False
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Text = "Sales Report"
        '
        'btnInvoice
        '
        Me.btnInvoice.Text = "Invoice"
        Me.btnInvoice.Visible = False
        '
        'btnConvertReportToExcel
        '
        Me.btnConvertReportToExcel.Text = "Save to Excel"
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.DisplayGroupTree = False
        Me.CRViewer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRViewer.Location = New System.Drawing.Point(132, 0)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.ReportSource = Nothing
        Me.CRViewer.Size = New System.Drawing.Size(668, 600)
        Me.CRViewer.TabIndex = 3
        Me.CRViewer.Visible = False
        '
        'imglAdmin
        '
        Me.imglAdmin.ImageSize = New System.Drawing.Size(32, 32)
        Me.imglAdmin.ImageStream = CType(resources.GetObject("imglAdmin.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglAdmin.TransparentColor = System.Drawing.Color.Transparent
        '
        'tlbrAdmin
        '
        Me.tlbrAdmin.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.btnDbSetting, Me.btnEntry, Me.btnPeopleEntry, Me.btnGlobalSetting, Me.btnPrinter, Me.btnUsr, Me.btnPaymentStatus, Me.btnReports, Me.btnLogin, Me.btnChngUsr, Me.btnExit})
        Me.tlbrAdmin.ButtonSize = New System.Drawing.Size(130, 40)
        Me.tlbrAdmin.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlbrAdmin.DropDownArrows = True
        Me.tlbrAdmin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbrAdmin.ImageList = Me.imglAdmin
        Me.tlbrAdmin.Location = New System.Drawing.Point(0, 0)
        Me.tlbrAdmin.Name = "tlbrAdmin"
        Me.tlbrAdmin.ShowToolTips = True
        Me.tlbrAdmin.Size = New System.Drawing.Size(130, 526)
        Me.tlbrAdmin.TabIndex = 4
        Me.tlbrAdmin.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'btnDbSetting
        '
        Me.btnDbSetting.ImageIndex = 0
        Me.btnDbSetting.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me.btnDbSetting.Text = "DB Setting"
        '
        'btnEntry
        '
        Me.btnEntry.ImageIndex = 1
        Me.btnEntry.Text = "DataEntry"
        '
        'btnPeopleEntry
        '
        Me.btnPeopleEntry.ImageIndex = 2
        Me.btnPeopleEntry.Text = "People Info."
        '
        'btnGlobalSetting
        '
        Me.btnGlobalSetting.ImageIndex = 3
        Me.btnGlobalSetting.Text = "GlobalSetting"
        '
        'btnPrinter
        '
        Me.btnPrinter.ImageIndex = 4
        Me.btnPrinter.Text = "Printer"
        '
        'btnUsr
        '
        Me.btnUsr.ImageIndex = 5
        Me.btnUsr.Text = "Manage user"
        '
        'btnPaymentStatus
        '
        Me.btnPaymentStatus.ImageIndex = 6
        Me.btnPaymentStatus.Text = "Order Status"
        '
        'btnReports
        '
        Me.btnReports.ImageIndex = 7
        Me.btnReports.Text = "Reports"
        '
        'btnLogin
        '
        Me.btnLogin.ImageIndex = 8
        Me.btnLogin.Text = "ReLogIn"
        '
        'btnChngUsr
        '
        Me.btnChngUsr.ImageIndex = 9
        Me.btnChngUsr.Text = "Change user"
        '
        'btnExit
        '
        Me.btnExit.ImageIndex = 10
        Me.btnExit.Text = "Exit"
        '
        'btnCategory
        '
        Me.btnCategory.Text = "Category"
        '
        'btnType
        '
        Me.btnType.Text = "Type"
        '
        'btnItem
        '
        Me.btnItem.Text = "Item"
        '
        'btnInstruction
        '
        Me.btnInstruction.Text = "Instruction"
        '
        'btnTbl
        '
        Me.btnTbl.Text = "Table"
        '
        'btnCardType
        '
        Me.btnCardType.Text = "CardType"
        '
        'btnStock
        '
        Me.btnStock.Enabled = False
        Me.btnStock.Text = "Stock"
        Me.btnStock.Visible = False
        '
        'btnEmployee
        '
        Me.btnEmployee.Text = "Employee"
        '
        'tlbrSubEntry
        '
        Me.tlbrSubEntry.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbrSubEntry.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.btnCategory, Me.btnType, Me.btnItem, Me.btnInstruction, Me.btnTbl, Me.btnCardType, Me.btnStock, Me.btnEmployee, Me.btnAddTop})
        Me.tlbrSubEntry.ButtonSize = New System.Drawing.Size(74, 38)
        Me.tlbrSubEntry.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlbrSubEntry.DropDownArrows = True
        Me.tlbrSubEntry.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlbrSubEntry.Location = New System.Drawing.Point(130, 438)
        Me.tlbrSubEntry.Name = "tlbrSubEntry"
        Me.tlbrSubEntry.ShowToolTips = True
        Me.tlbrSubEntry.Size = New System.Drawing.Size(670, 44)
        Me.tlbrSubEntry.TabIndex = 1
        Me.tlbrSubEntry.Visible = False
        '
        'btnAddTop
        '
        Me.btnAddTop.Enabled = False
        Me.btnAddTop.Text = "Topping"
        Me.btnAddTop.Visible = False
        '
        'frmAdmin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 526)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlbrSubEntry)
        Me.Controls.Add(Me.tlbrReport)
        Me.Controls.Add(Me.tlbrAdmin)
        Me.Controls.Add(Me.CRViewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function SetRestaurantInformation()

        Dim iRowCount As Integer

        Dim strSQL As String

        Dim dsRestuarantInformation As DataSet
        Dim daRestuarantInformation As SqlClient.SqlDataAdapter

        Try
            dsRestuarantInformation = New DataSet("RestuarantInformation")
            strSQL = "SELECT cRestName,cRestType,cResAddress1,cResAddress2,cResAddress3,cResPhoneNumber,cResFaxNumber," & _
                     "cResEmaiAddress,cResWebAddress,cGreetinMsg,cVatNumber,nMenuLevel,nVat,awaytime,collectiontime,waitingtime FROM tMasterInfo"

            daRestuarantInformation = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daRestuarantInformation.Fill(dsRestuarantInformation, "RestuarantInformation")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iRowCount = dsRestuarantInformation.Tables("RestuarantInformation").Rows.Count
        If iRowCount > 0 Then
            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(0)) Then
                mdConfiguration.strResturantName = ""
            Else
                mdConfiguration.strResturantName = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(0)       ' Restaurant Name
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(1)) Then
                mdConfiguration.strRestuarantType = ""
            Else
                mdConfiguration.strRestuarantType = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(1)      ' Restaurant Type
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(2)) Then
                mdConfiguration.strResturantAddress1 = ""
            Else
                mdConfiguration.strResturantAddress1 = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(2)   ' Restaurant Address
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(3)) Then
                mdConfiguration.strRestuantAddress2 = ""
            Else
                mdConfiguration.strRestuantAddress2 = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(3)    ' Restaurant Address
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(4)) Then
                mdConfiguration.strRestuantAddress3 = ""
            Else
                mdConfiguration.strRestuantAddress3 = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(4)    ' Restaurant Address
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(5)) Then
                mdConfiguration.strRestuarantPhone = ""
            Else
                mdConfiguration.strRestuarantPhone = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(5)     ' Restaurant Phone
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(6)) Then
                mdConfiguration.strRestuarantFaxNumber = ""
            Else
                mdConfiguration.strRestuarantFaxNumber = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(6) ' Restaurant Fax
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(7)) Then
                mdConfiguration.strRestuarantEmail = ""
            Else
                mdConfiguration.strRestuarantEmail = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(7)     ' Restaurant Email
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(8)) Then
                mdConfiguration.strRestuarantWeb = ""
            Else
                mdConfiguration.strRestuarantWeb = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(8)       ' Restaurant URL
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(9)) Then
                mdConfiguration.strGreetingMsg = ""
            Else
                mdConfiguration.strGreetingMsg = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(9)         ' Greeting Message
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(10)) = False Then
                mdConfiguration.strVatNumber = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(10)            ' Vat number
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(11)) = False Then
                mdConfiguration.iMenuLevel = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(11)            ' Menu Level
            End If

            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(12)) = False Then
                mdConfiguration.iVat = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(12)                  ' Vat
            End If
            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(13)) = False Then
                mdConfiguration.awaytime = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(13)              ' takeawaytime
            End If
            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(14)) = False Then
                mdConfiguration.collectiontime = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(14)         ' collectiontime
            End If
            If IsDBNull(dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(15)) = False Then
                mdConfiguration.waitingtime = dsRestuarantInformation.Tables("RestuarantInformation").Rows(0).Item(15)          ' waitingtime
            End If
        End If
    End Function

    Private Function ReLogin()
        If GetSetting("Restaurant", "FormSetting", "StartUp") = vbNullString Then
            Dim ofrfirstOpen As New frmTakeaway
            ofrfirstOpen.Show()
        ElseIf GetSetting("Restaurant", "FormSetting", "StartUp") = 2 Then
            Dim ofrfirstOpen As New frmTakeaway
            ofrfirstOpen.Show()
        ElseIf GetSetting("Restaurant", "FormSetting", "StartUp") = 1 Then
            Dim ofrfirstOpen As New frmDine
            ofrfirstOpen.Show()
        End If
        SetRestaurantInformation()
    End Function

    Private Sub tlbrSubEntry_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlbrSubEntry.ButtonClick

        Select Case tlbrSubEntry.Buttons.IndexOf(e.Button)
            Case 0      '----------------For Show Category Entry, Edit Form--------------------------    
                Dim ofrmCategory As New frmCatagory
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                ofrmCategory.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 1       '----------------For Show Type Entry, Edit Form--------------------------    
                Dim ofrmType As New frmType
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                ofrmType.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 2      '----------------For Show Item Entry, Edit Form--------------------------    
                Dim ofrmItem As New frmItem
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                ofrmItem.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 3      '---------------- For Show Instruction Information Entry, Edit Form--------------------------    
                Dim ofrmInstructtionInfo As New frmInstructtionInfo
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                ofrmInstructtionInfo.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 4      '----------------For Show Item Table Information Entry, Edit Form--------------------------    
                Dim ofrmTbleInfo As New frmTbleInfo
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                ofrmTbleInfo.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 5      '----------------For Show Card Type Information Entry, Edit Form--------------------------    
                Dim ofrmCardInfo As New frmCardType
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                ofrmCardInfo.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 6      '---------------- For Show Item Stock Entry, Edit Form--------------------------    
                Dim ofrmItemStock As New frmItemStck
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                ofrmItemStock.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 7      '---------------- For Show Employee Entry, Edit Form--------------------------    
                Dim ofrmEmployee As New frmEmployeeInfo
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                ofrmEmployee.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 8   '----------------------For Show Topping Entry,Edit Form-------------------------
                Dim ofrmAddTopp As New frmAddTop
                ofrmAddTopp.ShowDialog()

        End Select
    End Sub

    Private Function LdtlbrEntry()
        'If GetSetting("Restaurant", "FormSetting", "MenuLevel") = 2 Then    
        '    btnCategory.Visible = False
        'Else
        '    btnCategory.Visible = True
        'End If
        Me.btnEntry.Enabled = False
        Me.tlbrSubEntry.Visible = True
    End Function

    Private Function LdtlbrReport()
        btnReports.Enabled = False
        tlbrReport.Visible = True
    End Function

    Private Function doEnableOrDisable(ByVal iCase As Integer)
        If Not iCase = 0 Then
            Me.btnEntry.Enabled = True
            Me.tlbrSubEntry.Visible = False
        End If

        If Not iCase = 5 Then
            Me.btnReports.Enabled = True
            Me.tlbrReport.Visible = False
            Me.CRViewer.Visible = False
        End If

    End Function

    Private Sub frmAdmin_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'If connRestuarant.State = 1 Then
        '    connRestuarant.Close()
        '    Dispose()
        'End If
        'connRestuarant = Nothing

    End Sub

    Private Sub tlbrReport_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlbrReport.ButtonClick
        CRViewer.Visible = True
        Select Case tlbrReport.Buttons.IndexOf(e.Button)
            Case 0
                CreatStockReport()
            Case 1
                Dim objfrmSalesReport As New frmSalesReport
                CRViewer.Visible = False
                objfrmSalesReport.SetReportViewer(CRViewer)
                objfrmSalesReport.ShowDialog()
            Case 2
                Dim objfrmInvoice As New frmInvoice
                CRViewer.Visible = False
                objfrmInvoice.SetReportViewer(CRViewer)
                objfrmInvoice.ShowDialog()
            Case 3
                Dim objFrmSaveToExcel As New frmSalesReportToExcel
                CRViewer.Visible = False
                objFrmSaveToExcel.ShowDialog()
        End Select
    End Sub

    Private Sub CreatStockReport()
        Dim strSQL As String
        Dim iIndex As Integer
        Dim dsStock As DataSet
        Dim daStock As SqlClient.SqlDataAdapter
        Dim objrStock As New rStock

        strSQL = "SELECT nItem_Id, cItem_Name, nItem_Stock FROM tItem WHERE nItemActive=1"
        Try
            dsStock = New DataSet("Stock")
            daStock = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daStock.Fill(dsStock, "Stock")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iIndex = dsStock.Tables("Stock").Rows.Count

        If iIndex > 0 Then
            objrStock.SetDataSource(dsStock.Tables("Stock"))
            CRViewer.ReportSource = objrStock
        Else
            MessageBox.Show("There is no information in stock", "ERestuarant", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        dsStock = Nothing
        daStock = Nothing
    End Sub

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnPeopleEntry.Visible = False
        If mdConfiguration.iMenuLevel > 0 Then
            btnEntry.Visible = True
        Else
            btnEntry.Visible = False
            MsgBox("Please set the menu level.", MsgBoxStyle.Information, "Administration Panel")
        End If

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Administration Panel"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Administration Panel"
        End If
    End Sub

    Private Sub tlbrAdmin_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlbrAdmin.ButtonClick

        doEnableOrDisable(tlbrAdmin.Buttons.IndexOf(e.Button))

        Select Case tlbrAdmin.Buttons.IndexOf(e.Button)
            Case 0
                Dim tmpfrmDBSetUp As New frmDBSetUp
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                tmpfrmDBSetUp.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 1
                LdtlbrEntry()
            Case 2
                Dim objFrmCustInfo As New frmCustomerInfo
                objFrmCustInfo.ShowDialog()
            Case 3
                Dim frm As New frmGlobalInfo
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                frm.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 4
                Dim frm As New frmSetPrinter
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                frm.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 5
                Dim frm As New frmUsrMng
                'Dim objfrmKeyBoard As New frmKeyBoard
                'objfrmKeyBoard.Show()
                frm.ShowDialog()
                'objfrmKeyBoard.Dispose()
            Case 6
                Dim objfrmPaymentStatus As New frmPaymentStatus
                objfrmPaymentStatus.ShowDialog()
            Case 7
                LdtlbrReport()
            Case 8
                ReLogin()
                Me.Dispose()
            Case 9
                mdConfiguration.frmEntryPoint.Show()
                mdConfiguration.frmEntryPoint.txtPasswd.Clear()
                Me.Dispose()
            Case 10
                Dim Itype As Integer
                Itype = MsgBox("Do U Want to Exit", MsgBoxStyle.YesNo, "eRestuarant")
                If Itype = MsgBoxResult.Yes Then
                    Application.Exit()
                    Dim thisProcess = Process.GetCurrentProcess
                    thisProcess.Kill()
                End If


        End Select
    End Sub

    Private Sub CRViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRViewer.Load

    End Sub
End Class
