Imports System.Drawing.Printing

Public Class frmSetPrinter
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboKitchnPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents cboBillPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents cboBarPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSaveSettings As MACButtonLib.MACButton
    Friend WithEvents btnCancel As MACButtonLib.MACButton
    Friend WithEvents cboLevelPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCallerIDPort As System.Windows.Forms.ComboBox
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    Friend WithEvents cboKitchnPrinter1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboKitchnPrinter = New System.Windows.Forms.ComboBox
        Me.cboBillPrinter = New System.Windows.Forms.ComboBox
        Me.cboBarPrinter = New System.Windows.Forms.ComboBox
        Me.btnCancel = New MACButtonLib.MACButton
        Me.cmdSaveSettings = New MACButtonLib.MACButton
        Me.cboLevelPrinter = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboCallerIDPort = New System.Windows.Forms.ComboBox
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.cboKitchnPrinter1 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kitchen Printer1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bill Printer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bar Printer"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(80, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(328, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Example:      192.168.10.15\myprinter"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'cboKitchnPrinter
        '
        Me.cboKitchnPrinter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKitchnPrinter.Location = New System.Drawing.Point(128, 8)
        Me.cboKitchnPrinter.Name = "cboKitchnPrinter"
        Me.cboKitchnPrinter.Size = New System.Drawing.Size(343, 23)
        Me.cboKitchnPrinter.TabIndex = 1
        '
        'cboBillPrinter
        '
        Me.cboBillPrinter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBillPrinter.Location = New System.Drawing.Point(128, 144)
        Me.cboBillPrinter.Name = "cboBillPrinter"
        Me.cboBillPrinter.Size = New System.Drawing.Size(343, 23)
        Me.cboBillPrinter.TabIndex = 3
        '
        'cboBarPrinter
        '
        Me.cboBarPrinter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBarPrinter.Location = New System.Drawing.Point(128, 104)
        Me.cboBarPrinter.Name = "cboBarPrinter"
        Me.cboBarPrinter.Size = New System.Drawing.Size(343, 23)
        Me.cboBarPrinter.TabIndex = 5
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
        Me.btnCancel.Location = New System.Drawing.Point(348, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 44)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextColorDefault = System.Drawing.Color.Black
        Me.btnCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.btnCancel.TextColorHover = System.Drawing.Color.White
        Me.btnCancel.TextColorNormal = System.Drawing.Color.White
        '
        'cmdSaveSettings
        '
        Me.cmdSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSaveSettings.BackColor = System.Drawing.Color.Transparent
        Me.cmdSaveSettings.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.cmdSaveSettings.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.cmdSaveSettings.ButtonColorHover = System.Drawing.Color.Maroon
        Me.cmdSaveSettings.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.cmdSaveSettings.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveSettings.Location = New System.Drawing.Point(52, 224)
        Me.cmdSaveSettings.Name = "cmdSaveSettings"
        Me.cmdSaveSettings.Size = New System.Drawing.Size(120, 44)
        Me.cmdSaveSettings.TabIndex = 8
        Me.cmdSaveSettings.Text = "Save Settings"
        Me.cmdSaveSettings.TextColorDefault = System.Drawing.Color.Black
        Me.cmdSaveSettings.TextColorDisabled = System.Drawing.Color.Black
        Me.cmdSaveSettings.TextColorHover = System.Drawing.Color.White
        Me.cmdSaveSettings.TextColorNormal = System.Drawing.Color.White
        '
        'cboLevelPrinter
        '
        Me.cboLevelPrinter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLevelPrinter.Location = New System.Drawing.Point(128, 72)
        Me.cboLevelPrinter.Name = "cboLevelPrinter"
        Me.cboLevelPrinter.Size = New System.Drawing.Size(343, 23)
        Me.cboLevelPrinter.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Level Printer"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Caller Id Port"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboCallerIDPort
        '
        Me.cboCallerIDPort.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCallerIDPort.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboCallerIDPort.Location = New System.Drawing.Point(128, 184)
        Me.cboCallerIDPort.Name = "cboCallerIDPort"
        Me.cboCallerIDPort.Size = New System.Drawing.Size(343, 23)
        Me.cboCallerIDPort.TabIndex = 11
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
        Me.btnKeyBoard.Location = New System.Drawing.Point(204, 224)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(120, 44)
        Me.btnKeyBoard.TabIndex = 76
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'cboKitchnPrinter1
        '
        Me.cboKitchnPrinter1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKitchnPrinter1.Location = New System.Drawing.Point(128, 40)
        Me.cboKitchnPrinter1.Name = "cboKitchnPrinter1"
        Me.cboKitchnPrinter1.Size = New System.Drawing.Size(343, 23)
        Me.cboKitchnPrinter1.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 23)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Kitchen Printer2"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSetPrinter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(498, 280)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboKitchnPrinter1)
        Me.Controls.Add(Me.btnKeyBoard)
        Me.Controls.Add(Me.cboCallerIDPort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboLevelPrinter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cmdSaveSettings)
        Me.Controls.Add(Me.cboBarPrinter)
        Me.Controls.Add(Me.cboBillPrinter)
        Me.Controls.Add(Me.cboKitchnPrinter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetPrinter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printer Setting"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSetPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objAdmin As New frmAdmin
        Me.Left = objAdmin.tlbrAdmin.Width + 20

        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Printer Setting"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Printer Setting"
        End If

        Call PopulateInstalledPrintersCombo()

        cboBillPrinter.Text = GetSetting("Restaurant", "PrintSetting", "BillPrinter")
        cboKitchnPrinter.Text = GetSetting("Restaurant", "PrintSetting", "KitchnPrinter")
        cboKitchnPrinter1.Text = GetSetting("Restaurant", "PrintSetting", "KitchnPrinter1")
        cboBarPrinter.Text = GetSetting("Restaurant", "PrintSetting", "BarPrinter")
        cboLevelPrinter.Text = GetSetting("Restaurant", "PrintSetting", "LevelPrinter")
        cboCallerIDPort.Text = GetSetting("Restaurant", "PrintSetting", "SerialPort")
    End Sub

    Private Sub cmdSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveSettings.Click
        SaveSetting("Restaurant", "PrintSetting", "BillPrinter", cboBillPrinter.Text)
        SaveSetting("Restaurant", "PrintSetting", "KitchnPrinter", cboKitchnPrinter.Text)
        SaveSetting("Restaurant", "PrintSetting", "KitchnPrinter1", cboKitchnPrinter1.Text) 'new added for kp2
        SaveSetting("Restaurant", "PrintSetting", "BarPrinter", cboBarPrinter.Text)
        SaveSetting("Restaurant", "PrintSetting", "LevelPrinter", cboLevelPrinter.Text)
        SaveSetting("Restaurant", "PrintSetting", "SerialPort", cboCallerIDPort.Text)
        cboBillPrinter.SelectedIndex = -1
        cboKitchnPrinter.SelectedIndex = -1
        cboKitchnPrinter1.SelectedIndex = -1
        cboBarPrinter.SelectedIndex = -1
        cboLevelPrinter.SelectedIndex = -1
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub PopulateInstalledPrintersCombo()
        Dim i As Integer
        Dim pkInstalledPrinters As String
        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            cboBillPrinter.Items.Add(pkInstalledPrinters)
            cboKitchnPrinter.Items.Add(pkInstalledPrinters)
            cboKitchnPrinter1.Items.Add(pkInstalledPrinters)
            cboBarPrinter.Items.Add(pkInstalledPrinters)
            cboLevelPrinter.Items.Add(pkInstalledPrinters)
        Next
    End Sub

    Private Sub Event_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboBarPrinter.KeyPress, cboBillPrinter.KeyPress, cboKitchnPrinter.KeyPress, cboKitchnPrinter1.KeyPress, cboLevelPrinter.KeyPress, btnCancel.KeyPress, cmdSaveSettings.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
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
