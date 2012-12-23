Imports System
Imports System.IO
Imports System.Reflection
Imports System.Text
Public Class frmInitialSetup
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtServerIP As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents InputPanel1 As Microsoft.WindowsCE.Forms.InputPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsysUser As System.Windows.Forms.TextBox
    Friend WithEvents txtsysPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtServerIP = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtDatabase = New System.Windows.Forms.TextBox
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.InputPanel1 = New Microsoft.WindowsCE.Forms.InputPanel
        Me.txtsysUser = New System.Windows.Forms.TextBox
        Me.txtsysPwd = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtServerName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(32, 177)
        Me.btnCancel.Size = New System.Drawing.Size(64, 24)
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(104, 177)
        Me.btnSave.Size = New System.Drawing.Size(104, 24)
        Me.btnSave.Text = "Save settings"
        '
        'txtServerIP
        '
        Me.txtServerIP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtServerIP.Location = New System.Drawing.Point(88, 8)
        Me.txtServerIP.Size = New System.Drawing.Size(136, 22)
        Me.txtServerIP.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(-13, 8)
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.Text = "ServerIP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(-13, 56)
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.Text = "DbUser"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(-13, 104)
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.Text = "Database"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtUser.Location = New System.Drawing.Point(88, 56)
        Me.txtUser.Size = New System.Drawing.Size(136, 22)
        Me.txtUser.Text = ""
        '
        'txtDatabase
        '
        Me.txtDatabase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtDatabase.Location = New System.Drawing.Point(88, 104)
        Me.txtDatabase.Size = New System.Drawing.Size(136, 22)
        Me.txtDatabase.Text = ""
        '
        'txtPwd
        '
        Me.txtPwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPwd.Location = New System.Drawing.Point(88, 80)
        Me.txtPwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(136, 22)
        Me.txtPwd.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(-13, 80)
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.Text = "Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'InputPanel1
        '
        '
        'txtsysUser
        '
        Me.txtsysUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtsysUser.Location = New System.Drawing.Point(88, 128)
        Me.txtsysUser.Size = New System.Drawing.Size(136, 22)
        Me.txtsysUser.Text = ""
        '
        'txtsysPwd
        '
        Me.txtsysPwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtsysPwd.Location = New System.Drawing.Point(88, 152)
        Me.txtsysPwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtsysPwd.Size = New System.Drawing.Size(136, 22)
        Me.txtsysPwd.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(-13, 128)
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.Text = "SysUser"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(-13, 152)
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(88, 32)
        Me.txtServerName.Size = New System.Drawing.Size(136, 22)
        Me.txtServerName.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(-13, 32)
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.Text = "ServerName"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmInitialSetup
        '
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsysPwd)
        Me.Controls.Add(Me.txtsysUser)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtServerIP)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.MainMenu1
        Me.Text = "Initial settings"

    End Sub

#End Region
    'Dim applicationPath As String = Path.GetDirectoryName([Assembly].GetExecutingAssembly().GetModules(0).FullyQualifiedName)
    'Dim ConfigFile As String = applicationPath + "\ConfigFile.txt"
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'If file already exists then delete it(Not necessary)
        If File.Exists(ConfigFile) Then
            File.Delete(ConfigFile)
        End If

        Dim fw As StreamWriter
        Dim ReadString As String
        Try
            'Pass the file path and name to the StreamWriter constructor.
            'Indicate that Append is False, so file will be overwritten.
            fw = New StreamWriter(ConfigFile, False)
            fw.WriteLine("ServerIP=" + txtServerIP.Text)
            fw.WriteLine("ServerName=" + txtServerName.Text)
            fw.WriteLine("dbUser=" + txtUser.Text)
            fw.WriteLine("dbPwd=" + txtPwd.Text)
            fw.WriteLine("Database=" + txtDatabase.Text)
            fw.WriteLine("sysUser=" + txtsysUser.Text)
            fw.WriteLine("sysPwd=" + txtsysPwd.Text)
        Finally
            'Close the file.
            fw.Close()
            mdConfiguration.ClearControl(Me)
            Me.Close()
        End Try
    End Sub

    Private Sub frmServerSetup_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        MsgBox("Your Database Setting is update Successfully;Please Restart your Application")
        Application.Exit()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub frmServerSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.InputPanel1.EnabledChange += New EventHandler(Me.InputPanel1.InputPanel1_EnabledChanged)
        'InputPanel1_EnabledChanged(Nothing, EventArgs.Empty)

    End Sub

    Private Sub InputPanel1_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputPanel1.EnabledChanged
        ' show VisibleDesktop value
        'Dim rect As Rectangle = Me.InputPanel1.VisibleDesktop

        '' show Bounds value
        'rect = Me.InputPanel1.Bounds


    End Sub
End Class
