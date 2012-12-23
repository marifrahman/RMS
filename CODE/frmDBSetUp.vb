Public Class frmDBSetUp
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
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDBServer As System.Windows.Forms.TextBox
    Friend WithEvents txtInitDatabase As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancel As MACButtonLib.MACButton
    Friend WithEvents cmdOk As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtInitDatabase = New System.Windows.Forms.TextBox
        Me.txtDBServer = New System.Windows.Forms.TextBox
        Me.cmdOk = New MACButtonLib.MACButton
        Me.cmdCancel = New MACButtonLib.MACButton
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(140, 24)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(168, 21)
        Me.txtUser.TabIndex = 1
        Me.txtUser.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(20, 27)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(104, 16)
        Me.Label30.TabIndex = 58
        Me.Label30.Text = "User"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPwd
        '
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(140, 55)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(168, 21)
        Me.txtPwd.TabIndex = 2
        Me.txtPwd.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Database Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Database Server"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInitDatabase
        '
        Me.txtInitDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInitDatabase.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitDatabase.Location = New System.Drawing.Point(140, 117)
        Me.txtInitDatabase.Name = "txtInitDatabase"
        Me.txtInitDatabase.Size = New System.Drawing.Size(168, 21)
        Me.txtInitDatabase.TabIndex = 4
        Me.txtInitDatabase.Text = ""
        '
        'txtDBServer
        '
        Me.txtDBServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDBServer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBServer.Location = New System.Drawing.Point(140, 86)
        Me.txtDBServer.Name = "txtDBServer"
        Me.txtDBServer.Size = New System.Drawing.Size(168, 21)
        Me.txtDBServer.TabIndex = 3
        Me.txtDBServer.Text = ""
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdOk.BackColor = System.Drawing.Color.Transparent
        Me.cmdOk.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.cmdOk.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.cmdOk.ButtonColorHover = System.Drawing.Color.Maroon
        Me.cmdOk.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(56, 168)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(118, 48)
        Me.cmdOk.TabIndex = 65
        Me.cmdOk.Text = "Save Setting"
        Me.cmdOk.TextColorDefault = System.Drawing.Color.Black
        Me.cmdOk.TextColorDisabled = System.Drawing.Color.Black
        Me.cmdOk.TextColorHover = System.Drawing.Color.White
        Me.cmdOk.TextColorNormal = System.Drawing.Color.White
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.cmdCancel.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.cmdCancel.ButtonColorHover = System.Drawing.Color.Maroon
        Me.cmdCancel.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(208, 168)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(118, 48)
        Me.cmdCancel.TabIndex = 66
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.TextColorDefault = System.Drawing.Color.Black
        Me.cmdCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.cmdCancel.TextColorHover = System.Drawing.Color.White
        Me.cmdCancel.TextColorNormal = System.Drawing.Color.White
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
        Me.btnKeyBoard.Location = New System.Drawing.Point(124, 224)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(118, 48)
        Me.btnKeyBoard.TabIndex = 67
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'frmDBSetUp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 18)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(394, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnKeyBoard)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtDBServer)
        Me.Controls.Add(Me.txtInitDatabase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label30)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDBSetUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Database setting screen"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim connTemp As SqlClient.SqlConnection
        Dim strConnTemp As String

        'strConnTemp = "workstation id=" & txtWorkstation.Text & ";packet size=4096;user id=" & txtUser.Text & ";data source=" & txtDBServer.Text & ";persist security info=True;initial catalog=" & txtInitDatabase.Text & ";password=" & txtPwd.Text & ""
        strConnTemp = "workstation id=" & SystemInformation.ComputerName & ";packet size=4096;user id=" & txtUser.Text & ";data source=" & txtDBServer.Text & ";persist security info=True;initial catalog=" & txtInitDatabase.Text & ";password=" & txtPwd.Text & ""

        connTemp = New SqlClient.SqlConnection(strConnTemp)
        connTemp.Open()

        If connTemp.State = 1 Then
            SaveSetting("Restaurant", "DBsetup", "ComputerName", SystemInformation.ComputerName)
            SaveSetting("Restaurant", "DBsetup", "DBUser", txtUser.Text)
            SaveSetting("Restaurant", "DBsetup", "DBPass", txtPwd.Text)
            SaveSetting("Restaurant", "DBsetup", "InitCat", txtInitDatabase.Text)
            SaveSetting("Restaurant", "DBsetup", "DataBase", txtDBServer.Text)
            DBConnection()
            MsgBox("Your Database Setting is update Successfully;Please Restart your Application")
            Application.Exit()
            'Me.Close()
        Else
            MsgBox("Not valid database settings", vbInformation, "Wrong Database settings")
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If IsNothing(frmEntryPoint) Then
            Application.Exit()
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmDBSetUp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Trim(mdConfiguration.strResturantName) = vbNullString Then
            Me.Text = "UySys eRestuarant " & ": Database setting screen"
        Else
            Me.Text = mdConfiguration.strResturantName & ": Database setting screen"
        End If
    End Sub

    Private Sub btnKeyBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnKeyBoard_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyBoard.Click
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
