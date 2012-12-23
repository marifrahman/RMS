Imports System.IO

Public Class frmSalesReportToExcel
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
    Friend WithEvents btnSalesReportCancel As MACButtonLib.MACButton
    Friend WithEvents btnSaveReport As MACButtonLib.MACButton
    Friend WithEvents gbSalesReport As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnDalySales As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMonthlySalary As System.Windows.Forms.RadioButton
    Friend WithEvents gbDate As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSalesReportCancel = New MACButtonLib.MACButton
        Me.btnSaveReport = New MACButtonLib.MACButton
        Me.gbSalesReport = New System.Windows.Forms.GroupBox
        Me.gbDate = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.rbtnDalySales = New System.Windows.Forms.RadioButton
        Me.rbtnMonthlySalary = New System.Windows.Forms.RadioButton
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.gbSalesReport.SuspendLayout()
        Me.gbDate.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnSalesReportCancel.Location = New System.Drawing.Point(158, 168)
        Me.btnSalesReportCancel.Name = "btnSalesReportCancel"
        Me.btnSalesReportCancel.Size = New System.Drawing.Size(80, 36)
        Me.btnSalesReportCancel.TabIndex = 10
        Me.btnSalesReportCancel.Text = "Cancel"
        Me.btnSalesReportCancel.TextColorDefault = System.Drawing.Color.Black
        Me.btnSalesReportCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.btnSalesReportCancel.TextColorHover = System.Drawing.Color.White
        Me.btnSalesReportCancel.TextColorNormal = System.Drawing.Color.White
        '
        'btnSaveReport
        '
        Me.btnSaveReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveReport.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveReport.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnSaveReport.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnSaveReport.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnSaveReport.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnSaveReport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveReport.Location = New System.Drawing.Point(68, 168)
        Me.btnSaveReport.Name = "btnSaveReport"
        Me.btnSaveReport.Size = New System.Drawing.Size(80, 36)
        Me.btnSaveReport.TabIndex = 9
        Me.btnSaveReport.Text = "Save"
        Me.btnSaveReport.TextColorDefault = System.Drawing.Color.Black
        Me.btnSaveReport.TextColorDisabled = System.Drawing.Color.Black
        Me.btnSaveReport.TextColorHover = System.Drawing.Color.White
        Me.btnSaveReport.TextColorNormal = System.Drawing.Color.White
        '
        'gbSalesReport
        '
        Me.gbSalesReport.Controls.Add(Me.gbDate)
        Me.gbSalesReport.Controls.Add(Me.rbtnDalySales)
        Me.gbSalesReport.Controls.Add(Me.rbtnMonthlySalary)
        Me.gbSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbSalesReport.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSalesReport.Location = New System.Drawing.Point(7, 5)
        Me.gbSalesReport.Name = "gbSalesReport"
        Me.gbSalesReport.Size = New System.Drawing.Size(292, 155)
        Me.gbSalesReport.TabIndex = 11
        Me.gbSalesReport.TabStop = False
        '
        'gbDate
        '
        Me.gbDate.Controls.Add(Me.Label2)
        Me.gbDate.Controls.Add(Me.Label1)
        Me.gbDate.Controls.Add(Me.dtpToDate)
        Me.gbDate.Controls.Add(Me.dtpFromDate)
        Me.gbDate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDate.Location = New System.Drawing.Point(7, 80)
        Me.gbDate.Name = "gbDate"
        Me.gbDate.Size = New System.Drawing.Size(278, 64)
        Me.gbDate.TabIndex = 12
        Me.gbDate.TabStop = False
        Me.gbDate.Text = "Select Date"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "To"
        '
        'dtpToDate
        '
        Me.dtpToDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpToDate.Location = New System.Drawing.Point(171, 29)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(100, 21)
        Me.dtpToDate.TabIndex = 15
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFromDate.Location = New System.Drawing.Point(48, 28)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(100, 21)
        Me.dtpFromDate.TabIndex = 13
        '
        'rbtnDalySales
        '
        Me.rbtnDalySales.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDalySales.Location = New System.Drawing.Point(64, 48)
        Me.rbtnDalySales.Name = "rbtnDalySales"
        Me.rbtnDalySales.Size = New System.Drawing.Size(180, 30)
        Me.rbtnDalySales.TabIndex = 6
        Me.rbtnDalySales.Text = "Daily Sales Report"
        '
        'rbtnMonthlySalary
        '
        Me.rbtnMonthlySalary.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMonthlySalary.Location = New System.Drawing.Point(64, 20)
        Me.rbtnMonthlySalary.Name = "rbtnMonthlySalary"
        Me.rbtnMonthlySalary.Size = New System.Drawing.Size(180, 25)
        Me.rbtnMonthlySalary.TabIndex = 5
        Me.rbtnMonthlySalary.Text = "Monthly Sales Report"
        '
        'frmSalesReportToExcel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(306, 206)
        Me.Controls.Add(Me.gbSalesReport)
        Me.Controls.Add(Me.btnSalesReportCancel)
        Me.Controls.Add(Me.btnSaveReport)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesReportToExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSalesReportToExcel"
        Me.gbSalesReport.ResumeLayout(False)
        Me.gbDate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public SaveFilename As String
    Public oexcel As Excel.Application
    Public obook As Excel.Workbook
    Public osheet As Excel.Worksheet
    Public R As Integer

    Private Sub btnSalesReportCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesReportCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSaveReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveReport.Click
        Dim SaveDialog As New SaveFileDialog
        With SaveDialog
            .Title = "Please Select Your To Save The File...."
            .Filter = "Excel Files(*.xls)|Excel Files(*.xls)"
            .AddExtension = True
            .ShowDialog()
            If .FileName <> "" Then
                SaveFilename = .FileName
            Else
                Exit Sub
            End If
        End With
        SaveDialog = Nothing
        If rbtnMonthlySalary.Checked = True Then
            CreateMonthlySalary()
        ElseIf rbtnDalySales.Checked = True Then
            CreateDailySalary()
        End If
    End Sub

    '------------------Monthly Sales Report----------------
    Private Sub Generate_Sheet(ByVal tmpDsSales As DataSet)
        osheet = oexcel.Worksheets(1)
        osheet.Name = "Excel Charts"
        osheet.Range("A1:AZ400").Interior.ColorIndex = 2
        osheet.Range("A1").Font.Size = 12
        osheet.Range("A1").Font.Bold = True
        osheet.Range("A1:I1").Merge()
        osheet.Range("A1").Value = "Monthly sales Report"
        osheet.Range("A1").EntireColumn.AutoFit()
        osheet.Range("A3:C3").Font.Color = RGB(255, 255, 255)
        osheet.Range("A3:C3").Interior.ColorIndex = 5
        osheet.Range("A3:C3").Font.Bold = True
        osheet.Range("A3:C3").Font.Size = 10
        osheet.Range("A3").Value = "Month"
        osheet.Range("A3").BorderAround(8)
        osheet.Range("A3:B3").Merge()
        osheet.Range("A3").EntireColumn.AutoFit()
        osheet.Range("C3").Value = "Sales"
        osheet.Range("C3").BorderAround(8)
        osheet.Range("C3:D3").Merge()
        osheet.Range("C3").EntireColumn.AutoFit()
        Dim R As Integer = 3
        Dim iIndex As Integer
        Dim srtSales As String
        For iIndex = 0 To tmpDsSales.Tables(tmpDsSales.DataSetName).Rows.Count - 1
            R = R + 1
            osheet.Range("A" & R).Value = tmpDsSales.Tables(tmpDsSales.DataSetName).Rows(iIndex).Item(0)
            osheet.Range("A" & R & ":B" & R).BorderAround(8)
            osheet.Range("A" & R).EntireColumn.AutoFit()
            osheet.Range("C" & R).Value = tmpDsSales.Tables(tmpDsSales.DataSetName).Rows(iIndex).Item(1)
            osheet.Range("C" & R & ":D" & R).BorderAround(8)
            osheet.Range("C" & R).EntireColumn.AutoFit()
            osheet.Range("C" & R).NumberFormat = FormatCurrency("0,00.00")
        Next
        Dim oChart As Excel.Chart
        Dim MyCharts As Excel.ChartObjects
        Dim MyCharts1 As Excel.ChartObject
        MyCharts = osheet.ChartObjects
        MyCharts1 = MyCharts.Add(200, 30, 450, 250)
        oChart = MyCharts1.Chart
        With oChart
            Dim chartRange As Excel.Range
            chartRange = osheet.Range("A3", "C" & R)
            .SetSourceData(chartRange)
            .PlotBy = Excel.XlRowCol.xlRows
            .Legend.Position = Excel.XlLegendPosition.xlLegendPositionRight
            .HasTitle = True
            .ChartTitle.Text = "Monthly Sales/Month Bar Chart"
            Dim xlAxisCategory, xlAxisValue As Excel.Axes
            xlAxisCategory = CType(oChart.Axes(, Excel.XlAxisGroup.xlPrimary), Excel.Axes)
            xlAxisCategory.Item(Excel.XlAxisType.xlCategory).HasTitle = True
            xlAxisCategory.Item(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Month"
            xlAxisValue = CType(oChart.Axes(, Excel.XlAxisGroup.xlPrimary), Excel.Axes)
            xlAxisValue.Item(Excel.XlAxisType.xlValue).HasTitle = True
            xlAxisValue.Item(Excel.XlAxisType.xlValue).AxisTitle.Characters.Text = "Sales in Pound"
        End With
        R = R + 3
        osheet.Range("A" & R & ":C" & R).Font.Bold = True
        osheet.Range("A" & R & ":C" & R).Font.Color = RGB(255, 255, 255)
        osheet.Range("A" & R).Value = "Total"
        osheet.Range("A" & R & ":C" & R).Interior.ColorIndex = 5
        osheet.Range("A" & R & ":C" & R).BorderAround(8)
        Dim columnno = 3

        Dim Htotal As String = 0
        Dim RowCount As Integer = 4
        Do While RowCount <= R
            Htotal = Htotal + osheet.Cells(RowCount, columnno).value
            RowCount = RowCount + 1
        Loop
        osheet.Cells(R, columnno).Value = Htotal
        With DirectCast(osheet.Columns(columnno), Excel.Range)
            .AutoFit()
            .NumberFormat = FormatCurrency("0,00.00")
        End With
    End Sub

    Private Function CreatExcelfileForMonthlySales(ByVal tmpDsSale As DataSet)
        oexcel = CreateObject("Excel.Application")
        obook = oexcel.Workbooks.Add
        oexcel.Application.DisplayAlerts = True
        Dim S As Integer = oexcel.Application.Sheets.Count()

        If S > 1 Then
            oexcel.Application.DisplayAlerts = False
            Dim J As Integer = S
            Do While J > 1
                oexcel.Application.Sheets(J).delete()
                J = oexcel.Application.Sheets.Count()
            Loop
        End If
        'oexcel.Visible = True
        Generate_Sheet(tmpDsSale)
        obook.SaveAs(SaveFilename)
        osheet = Nothing
        oexcel.Application.DisplayAlerts = False
        obook.Close()
        oexcel.Application.DisplayAlerts = True
        obook = Nothing
        oexcel.Quit()
        oexcel = Nothing
    End Function

    Private Function CreateMonthlySalary()
        Dim iCountDataSetRow As Integer
        Dim strSQL As String
        Dim strFromDate As Date
        Dim strToDate As Date

        Dim dsSale As DataSet
        Dim daSale As SqlClient.SqlDataAdapter

        strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy")
        strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy")

        strSQL = "SELECT  DATENAME(MONTH,dOrder_date),SUM(mNetpay) FROM tOrder_Payment WHERE MONTH(dOrder_date) " & _
                 " BETWEEN MONTH('" & strFromDate & "') AND MONTH('" & strToDate & "') GROUP BY " & _
                 "DATENAME(MONTH,dOrder_date)"
        Try
            dsSale = New DataSet("MonthlySales")
            daSale = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daSale.Fill(dsSale, "MonthlySales")

            iCountDataSetRow = dsSale.Tables("MonthlySales").Rows.Count

            If iCountDataSetRow > 0 Then
                CreatExcelfileForMonthlySales(dsSale)
            Else
                MsgBox("There is no order placed for your seleced month", MsgBoxStyle.Information, "Excel Convertion")
            End If

        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

    End Function

    '----------------For daily Sales Report---------------------

    Private Sub Generate_SheetDAily(ByVal tmpDsSales As DataSet)
        osheet = oexcel.Worksheets(1)
        osheet.Name = "Excel Charts"
        osheet.Range("A1:AZ400").Interior.ColorIndex = 2
        osheet.Range("A1").Font.Size = 12
        osheet.Range("A1").Font.Bold = True
        osheet.Range("A1:I1").Merge()
        osheet.Range("A1").Value = "Daily sales Report" & "Date: " & DateTime.Parse(GetOrderDate().Date).ToString("dd/MM/yyyy")
        osheet.Range("A1").EntireColumn.AutoFit()
        osheet.Range("A3:E3").Font.Color = RGB(255, 255, 255)
        osheet.Range("A3:E3").Interior.ColorIndex = 5
        osheet.Range("A3:E3").Font.Bold = True
        osheet.Range("A3:E3").Font.Size = 10

        osheet.Range("A3").Value = "Date"
        osheet.Range("A3").BorderAround(8)
        osheet.Range("A3").EntireColumn.AutoFit()
        osheet.Range("A4").Value = tmpDsSales.Tables(tmpDsSales.DataSetName).Rows(0).Item(0)
        osheet.Range("A4:B4").BorderAround(8)
        osheet.Range("A4").BorderAround(8)
        osheet.Range("A4").EntireColumn.AutoFit()

        osheet.Range("B3").Value = "Cash Amount"
        osheet.Range("B3").BorderAround(8)
        osheet.Range("B3").EntireColumn.AutoFit()
        osheet.Range("B4").Value = tmpDsSales.Tables(tmpDsSales.DataSetName).Rows(0).Item(1)
        osheet.Range("B4").BorderAround(8)
        osheet.Range("B4").EntireColumn.AutoFit()
        osheet.Range("B4").NumberFormat = FormatCurrency("0,00.00")

        osheet.Range("C3").Value = "Card Amount"
        osheet.Range("C3").BorderAround(8)
        osheet.Range("C3").EntireColumn.AutoFit()
        osheet.Range("C4").Value = tmpDsSales.Tables(tmpDsSales.DataSetName).Rows(0).Item(2)
        osheet.Range("C4").BorderAround(8)
        osheet.Range("C4").EntireColumn.AutoFit()
        osheet.Range("C4").NumberFormat = FormatCurrency("0,00.00")

        osheet.Range("D3").Value = "Cheque Amount"
        osheet.Range("D3").BorderAround(8)
        osheet.Range("D3").EntireColumn.AutoFit()
        osheet.Range("D4").Value = tmpDsSales.Tables(tmpDsSales.DataSetName).Rows(0).Item(3)
        osheet.Range("D4").BorderAround(8)
        osheet.Range("D4").EntireColumn.AutoFit()
        osheet.Range("D4").NumberFormat = FormatCurrency("0,00.00")
        
        Dim oChart As Excel.Chart
        Dim MyCharts As Excel.ChartObjects
        Dim MyCharts1 As Excel.ChartObject
        MyCharts = osheet.ChartObjects
        MyCharts1 = MyCharts.Add(10, 80, 450, 250)
        oChart = MyCharts1.Chart
        With oChart
            Dim chartRange As Excel.Range
            chartRange = osheet.Range("A3", "D4")
            .SetSourceData(chartRange)
            .PlotBy = Excel.XlRowCol.xlColumns
            .Legend.Position = Excel.XlLegendPosition.xlLegendPositionRight
            .HasTitle = True
            .ChartTitle.Text = "Daily Sales/Day Bar Chart"
            Dim xlAxisCategory, xlAxisValue As Excel.Axes
            xlAxisCategory = CType(oChart.Axes(, Excel.XlAxisGroup.xlPrimary), Excel.Axes)
            xlAxisCategory.Item(Excel.XlAxisType.xlCategory).HasTitle = True
            xlAxisCategory.Item(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Date"
            xlAxisValue = CType(oChart.Axes(, Excel.XlAxisGroup.xlPrimary), Excel.Axes)
            xlAxisValue.Item(Excel.XlAxisType.xlValue).HasTitle = True
            xlAxisValue.Item(Excel.XlAxisType.xlValue).AxisTitle.Characters.Text = "Sales"
        End With

        osheet.Range("E3").Value = "Total Amount"
        osheet.Range("E3").BorderAround(8)
        osheet.Range("E3").EntireColumn.AutoFit()
        osheet.Range("E4").Value = tmpDsSales.Tables(tmpDsSales.DataSetName).Rows(0).Item(4)
        osheet.Range("E4").BorderAround(8)
        osheet.Range("E4").EntireColumn.AutoFit()
        osheet.Range("E4").NumberFormat = FormatCurrency("0,00.00")
    End Sub

    Private Function CreatExcelfileForDailySales(ByVal tmpDsSale As DataSet)
        oexcel = CreateObject("Excel.Application")
        obook = oexcel.Workbooks.Add
        oexcel.Application.DisplayAlerts = True
        Dim S As Integer = oexcel.Application.Sheets.Count()

        If S > 1 Then
            oexcel.Application.DisplayAlerts = False
            Dim J As Integer = S
            Do While J > 1
                oexcel.Application.Sheets(J).delete()
                J = oexcel.Application.Sheets.Count()
            Loop
        End If
        'oexcel.Visible = True
        Generate_SheetDAily(tmpDsSale)
        obook.SaveAs(SaveFilename)
        osheet = Nothing
        oexcel.Application.DisplayAlerts = False
        obook.Close()
        oexcel.Application.DisplayAlerts = True
        obook = Nothing
        oexcel.Quit()
        oexcel = Nothing
    End Function

    Private Function CreateDailySalary()
        Dim iCountDataSetRow As Integer
        Dim strSQL As String
        Dim strFromDate As String
        Dim strToDate As String

        Dim dsSale As DataSet
        Dim daSale As SqlClient.SqlDataAdapter

        strFromDate = DateTime.Parse(Trim(dtpFromDate.Text)).ToString("MM/dd/yyyy 00:00:00")
        strToDate = DateTime.Parse(Trim(dtpToDate.Text)).ToString("MM/dd/yyyy 23:59:59")

        strSQL = "SELECT  convert(varchar,dOrder_date,103),SUM(mCashPayAmount),SUM(mCardPayAmount),SUM(mChequeAmount)" & _
                 ",SUM(mCashPayAmount)+SUM(mCardPayAmount)+SUM(mChequeAmount) " & " FROM " & _
                 "tOrder_Payment WHERE dOrder_date BETWEEN '" & strFromDate & "' AND '" & strToDate & _
                 "' GROUP BY convert(varchar,dOrder_date,103)"
        Try
            dsSale = New DataSet("MonthlySales")
            daSale = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daSale.Fill(dsSale, "MonthlySales")

            iCountDataSetRow = dsSale.Tables("MonthlySales").Rows.Count

            If iCountDataSetRow > 0 Then
                CreatExcelfileForDailySales(dsSale)
            End If

        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
    End Function

    Private Sub frmSalesReportToExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbtnMonthlySalary.Checked = True
        gbDate.Text = "Select months"

    End Sub

    Private Sub rbtnMonthlySalary_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnMonthlySalary.Click
        gbDate.Text = "Select months"
    End Sub

    Private Sub rbtnDalySales_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnDalySales.Click
        gbDate.Enabled = False
        dtpFromDate.Value = GetOrderDate().Date
        dtpToDate.Value = GetOrderDate().Date
    End Sub
End Class
