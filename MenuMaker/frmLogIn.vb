Imports System
Imports System.IO
Imports System.Data.SqlServerCe
Imports System.Data.SqlServerCe.SqlCeException
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Public Class frmLogIn
    Inherits System.Windows.Forms.Form
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

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
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents InputPanel1 As Microsoft.WindowsCE.Forms.InputPanel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.btnLogIn = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.InputPanel1 = New Microsoft.WindowsCE.Forms.InputPanel
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.lblStatus = New System.Windows.Forms.Label
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.Text = "UserId"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtUser.Location = New System.Drawing.Point(88, 48)
        Me.txtUser.Size = New System.Drawing.Size(136, 22)
        Me.txtUser.Text = ""
        '
        'txtPwd
        '
        Me.txtPwd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPwd.Location = New System.Drawing.Point(88, 80)
        Me.txtPwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(136, 22)
        Me.txtPwd.Text = ""
        '
        'btnLogIn
        '
        Me.btnLogIn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogIn.Location = New System.Drawing.Point(160, 120)
        Me.btnLogIn.Size = New System.Drawing.Size(64, 24)
        Me.btnLogIn.Text = "LogIn"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(88, 120)
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.Text = "Cancel"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.IndianRed
        Me.lblStatus.Location = New System.Drawing.Point(16, 176)
        Me.lblStatus.Size = New System.Drawing.Size(208, 24)
        Me.lblStatus.Text = "Wrong UserID or Password!!"
        Me.lblStatus.Visible = False
        '
        'frmLogIn
        '
        Me.ControlBox = False
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.MainMenu1
        Me.Text = "Log in panel"

    End Sub

#End Region

    Private Sub frmLogIn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not File.Exists(mdConfiguration.ConfigFile) Then
            Dim frm As New frmInitialSetup
            frm.ShowDialog()

        Else

            Dim fr As StreamReader
            Dim FileString As String
            FileString = ""

            Try
                fr = New StreamReader(mdConfiguration.ConfigFile)
                FileString = fr.ReadLine

                While Not FileString Is Nothing
                    Dim strKey As String
                    strKey = FileString.Substring(0, FileString.IndexOf("="))
                    Select Case strKey
                        Case "ServerIP"
                            mdConfiguration.ServerIP = FileString.Substring(strKey.Length + 1)
                        Case "ServerName"
                            mdConfiguration.ServerName = FileString.Substring(strKey.Length + 1)
                        Case "dbUser"
                            mdConfiguration.dbUser = FileString.Substring(strKey.Length + 1)
                        Case "dbPwd"
                            mdConfiguration.dbPwd = FileString.Substring(strKey.Length + 1)
                        Case "Database"
                            mdConfiguration.Database = FileString.Substring(strKey.Length + 1)
                        Case "sysUser"
                            mdConfiguration.sysUser = FileString.Substring(strKey.Length + 1)
                        Case "sysPwd"
                            mdConfiguration.sysPwd = FileString.Substring(strKey.Length + 1)
                    End Select
                    FileString = fr.ReadLine
                End While
            Finally
                fr.Close()
                mdConfiguration.SetOledbParameters()
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click

        If authenticateUser(txtUser.Text, txtPwd.Text) = True Then
            lblStatus.Text = "Initializing database...."
            Dim ofrm As New frmMain
            ofrm.Show()
            Me.Hide()
        Else
            lblStatus.Visible = True
        End If
    End Sub

    Private Function authenticateUser(ByRef strUser As String, ByRef strPwd As String) As Boolean
        If strUser = mdConfiguration.sysUser And strPwd = mdConfiguration.sysPwd Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
