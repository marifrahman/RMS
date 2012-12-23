Public Class frmInvoice
    Inherits System.Windows.Forms.Form
    Dim iIndex As Integer
    Dim tmpReportViewr As New CrystalDecisions.Windows.Forms.CrystalReportViewer

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
    Friend WithEvents gbSalesReport As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnSpecificCustInfo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAllCustInfo As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCustId As System.Windows.Forms.ComboBox
    Friend WithEvents dtpSelectedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSalesReportCancel As MACButtonLib.MACButton
    Friend WithEvents btnShowReport As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbSalesReport = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboCustId = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpSelectedDate = New System.Windows.Forms.DateTimePicker
        Me.rbtnSpecificCustInfo = New System.Windows.Forms.RadioButton
        Me.rbtnAllCustInfo = New System.Windows.Forms.RadioButton
        Me.btnSalesReportCancel = New MACButtonLib.MACButton
        Me.btnShowReport = New MACButtonLib.MACButton
        Me.gbSalesReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSalesReport
        '
        Me.gbSalesReport.Controls.Add(Me.Label2)
        Me.gbSalesReport.Controls.Add(Me.cboCustId)
        Me.gbSalesReport.Controls.Add(Me.Label1)
        Me.gbSalesReport.Controls.Add(Me.dtpSelectedDate)
        Me.gbSalesReport.Controls.Add(Me.rbtnSpecificCustInfo)
        Me.gbSalesReport.Controls.Add(Me.rbtnAllCustInfo)
        Me.gbSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbSalesReport.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSalesReport.Location = New System.Drawing.Point(16, 9)
        Me.gbSalesReport.Name = "gbSalesReport"
        Me.gbSalesReport.Size = New System.Drawing.Size(240, 143)
        Me.gbSalesReport.TabIndex = 0
        Me.gbSalesReport.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select Customer Id "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboCustId
        '
        Me.cboCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustId.Enabled = False
        Me.cboCustId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustId.Location = New System.Drawing.Point(152, 103)
        Me.cboCustId.Name = "cboCustId"
        Me.cboCustId.Size = New System.Drawing.Size(72, 23)
        Me.cboCustId.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpSelectedDate
        '
        Me.dtpSelectedDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpSelectedDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSelectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpSelectedDate.Location = New System.Drawing.Point(114, 19)
        Me.dtpSelectedDate.Name = "dtpSelectedDate"
        Me.dtpSelectedDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpSelectedDate.TabIndex = 2
        Me.dtpSelectedDate.Value = New Date(2006, 3, 28, 15, 19, 13, 0)
        '
        'rbtnSpecificCustInfo
        '
        Me.rbtnSpecificCustInfo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSpecificCustInfo.Location = New System.Drawing.Point(59, 69)
        Me.rbtnSpecificCustInfo.Name = "rbtnSpecificCustInfo"
        Me.rbtnSpecificCustInfo.Size = New System.Drawing.Size(153, 24)
        Me.rbtnSpecificCustInfo.TabIndex = 4
        Me.rbtnSpecificCustInfo.Text = "Specific Customer"
        '
        'rbtnAllCustInfo
        '
        Me.rbtnAllCustInfo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAllCustInfo.Location = New System.Drawing.Point(59, 45)
        Me.rbtnAllCustInfo.Name = "rbtnAllCustInfo"
        Me.rbtnAllCustInfo.Size = New System.Drawing.Size(133, 24)
        Me.rbtnAllCustInfo.TabIndex = 3
        Me.rbtnAllCustInfo.Text = "All Customer"
        '
        'btnSalesReportCancel
        '
        Me.btnSalesReportCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSalesReportCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnSalesReportCancel.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnSalesReportCancel.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnSalesReportCancel.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnSalesReportCancel.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnSalesReportCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReportCancel.Location = New System.Drawing.Point(138, 165)
        Me.btnSalesReportCancel.Name = "btnSalesReportCancel"
        Me.btnSalesReportCancel.Size = New System.Drawing.Size(80, 36)
        Me.btnSalesReportCancel.TabIndex = 8
        Me.btnSalesReportCancel.Text = "Cancel"
        Me.btnSalesReportCancel.TextColorDefault = System.Drawing.Color.Black
        Me.btnSalesReportCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.btnSalesReportCancel.TextColorHover = System.Drawing.Color.White
        Me.btnSalesReportCancel.TextColorNormal = System.Drawing.Color.White
        '
        'btnShowReport
        '
        Me.btnShowReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShowReport.BackColor = System.Drawing.Color.Transparent
        Me.btnShowReport.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnShowReport.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnShowReport.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnShowReport.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnShowReport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowReport.Location = New System.Drawing.Point(48, 165)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(80, 36)
        Me.btnShowReport.TabIndex = 7
        Me.btnShowReport.Text = "Show"
        Me.btnShowReport.TextColorDefault = System.Drawing.Color.Black
        Me.btnShowReport.TextColorDisabled = System.Drawing.Color.Black
        Me.btnShowReport.TextColorHover = System.Drawing.Color.White
        Me.btnShowReport.TextColorNormal = System.Drawing.Color.White
        '
        'frmInvoice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(272, 208)
        Me.Controls.Add(Me.btnSalesReportCancel)
        Me.Controls.Add(Me.btnShowReport)
        Me.Controls.Add(Me.gbSalesReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoice"
        Me.Text = "Invoice Option"
        Me.gbSalesReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub rbtnSpecificCustInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnSpecificCustInfo.Click
        PutValuIntoCustmomerCombo()
    End Sub

    Private Sub rbtnAllCustInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnAllCustInfo.Click
        If rbtnAllCustInfo.Checked = True Then
            cboCustId.Enabled = False
        End If
    End Sub

    Private Sub btnSalesReportCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesReportCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click

        Dim iCountDataSetRow As Integer
        Dim strSQL As String
        Dim strSelectedDate As String
        Dim strTodate As String
        Dim i As Integer

        Dim dsInvoice As dsReport
        Dim daInvoice As SqlClient.SqlDataAdapter
        Dim objrInvoice As New rInvoice


        strSelectedDate = DateTime.Parse(Trim(dtpSelectedDate.Text)).ToString("MM/dd/yyyy 00:00:00")
        strTodate = DateTime.Parse(Trim(dtpSelectedDate.Text)).ToString("MM/dd/yyyy 23:59:59")


        If rbtnAllCustInfo.Checked = True Then

            strSQL = "SELECT C.cCust_Name,C.cAddress,C.cPhnNo,C.cCust_Mobile,I.cItem_Name,O.nOrder_Id," & _
                     "O.nItem_Qty,P.dOrder_date,P.mTotalPrice,P.mDiscount,P.mService_Charge,P.mNetpay " & _
                     "FROM tCust_Info C,tItem I,tOrdered_Item O,tOrder_Payment P " & _
                     "WHERE O.nOrder_Id=P.nOrder_Id AND P.nCust_Id=C.nCust_Id AND " & _
                     "O.nItem_Id=I.nItem_Id AND P.dOrder_date BETWEEN '" + strSelectedDate + "' AND '" + strTodate + "'"


        Else
            If cboCustId.Text <> vbNullString Then

                strSQL = "SELECT C.cCust_Name,C.cAddress,C.cPhnNo,C.cCust_Mobile,I.cItem_Name,O.nOrder_Id," & _
                         "O.nItem_Qty,P.dOrder_date,P.mTotalPrice,P.mDiscount,P.mService_Charge,P.mNetpay " & _
                         "FROM tCust_Info C,tItem I,tOrdered_Item O,tOrder_Payment P " & _
                         "WHERE O.nOrder_Id=P.nOrder_Id AND P.nCust_Id= " + Trim(cboCustId.Text) + " " & _
                         "AND P.nCust_Id=C.nCust_Id AND O.nItem_Id=I.nItem_Id AND " & _
                         "P.dOrder_date BETWEEN '" + strSelectedDate + "' AND '" + strTodate + "'"
            Else
                MsgBox("Please select your desire customer", MsgBoxStyle.Information, "Invoice")
                cboCustId.Focus()
                Exit Sub

            End If

        End If

        Try
            dsInvoice = New dsReport
            daInvoice = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daInvoice.Fill(dsInvoice, "tCust_Info")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        iCountDataSetRow = dsInvoice.Tables("tCust_Info").Rows.Count

        If iCountDataSetRow > 0 Then
            objrInvoice.SetDataSource(dsInvoice)
            tmpReportViewr.Visible = True
            tmpReportViewr.ReportSource = objrInvoice
            Me.Dispose()
        Else
            MessageBox.Show("There is no information ", "ERestuarant", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dsInvoice = Nothing
    End Sub

    Private Sub frmInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbtnAllCustInfo.Checked = True
        dtpSelectedDate.Value = GetOrderDate().Date
        Dim objAdmin As New frmAdmin
        Me.Left = (objAdmin.Width - Me.Width) / 2
        Me.Top = (objAdmin.Height - Me.Height) / 2
    End Sub

    Public Function SetReportViewer(ByRef aReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer)
        tmpReportViewr = aReportViewer
    End Function

    Private Sub dtpSelectedDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpSelectedDate.TextChanged
        If iIndex = 0 Then
            iIndex = 1
        Else
            PutValuIntoCustmomerCombo()
        End If
    End Sub

    Private Function PutValuIntoCustmomerCombo()
        Dim strSelectedDate As String
        Dim strToDate As String

        Dim strSQL As String
        Dim iCountDatasetRow As Integer
        Dim dsCustInfo As dsReport
        Dim daCustInfo As SqlClient.SqlDataAdapter

        If rbtnSpecificCustInfo.Checked = True Then
            cboCustId.Enabled = True
        End If

        strSelectedDate = DateTime.Parse(Trim(dtpSelectedDate.Text)).ToString("MM/dd/yyyy 00:00:00")
        strToDate = DateTime.Parse(Trim(dtpSelectedDate.Text)).ToString("MM/dd/yyyy 23:59:59")

        strSQL = "SELECT nCust_Id FROM tOrder_Payment WHERE dOrder_Date BETWEEN '" + strSelectedDate _
                 + "' AND '" + strToDate + "'"

        Try

            dsCustInfo = New dsReport
            daCustInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daCustInfo.Fill(dsCustInfo, "tCust_Info")
        Catch ex As Exception
            MessageBox.Show("There is no customer information to show.", "ERestuarant", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        iCountDatasetRow = dsCustInfo.Tables("tCust_Info").Rows.Count

        If iCountDatasetRow > 0 Then
            cboCustId.DataSource = dsCustInfo.Tables("tCust_Info")
            cboCustId.DisplayMember = "nCust_Id"
        Else
            cboCustId.DataSource = Nothing
            cboCustId.Items.Clear()
        End If
        dsCustInfo = Nothing
        daCustInfo = Nothing
    End Function

    Private Sub Event_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnShowReport.KeyPress, btnSalesReportCancel.KeyPress, dtpSelectedDate.KeyPress, cboCustId.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
