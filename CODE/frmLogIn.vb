Imports System.Threading

Public Class frmLogIn
    Inherits System.Windows.Forms.Form

    Private CapsFlag As Boolean = False
    Dim strSQL As String
    Dim icount As Integer 'For count the number of rows in Category Dataset 
    Dim ds As DataSet
    Dim da As SqlClient.SqlDataAdapter

    Dim dsRestuarantInformation As DataSet
    Dim daRestuarantInformation As SqlClient.SqlDataAdapter

    Dim iTempUserNameIndexNumber As Integer

    Dim t As Thread


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
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboUsername As System.Windows.Forms.ComboBox
    Friend WithEvents txtPasswd As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btLogin As MACButtonLib.MACButton
    Friend WithEvents btnCancel As MACButtonLib.MACButton
    Friend WithEvents btnKeyBoard As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogIn))
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPasswd = New System.Windows.Forms.TextBox
        Me.cboUsername = New System.Windows.Forms.ComboBox
        Me.lblMsg = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCancel = New MACButtonLib.MACButton
        Me.btLogin = New MACButtonLib.MACButton
        Me.btnKeyBoard = New MACButtonLib.MACButton
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Coral
        Me.Label30.Location = New System.Drawing.Point(40, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(88, 26)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "User"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(40, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPasswd
        '
        Me.txtPasswd.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswd.Location = New System.Drawing.Point(136, 54)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswd.Size = New System.Drawing.Size(124, 22)
        Me.txtPasswd.TabIndex = 4
        Me.txtPasswd.Text = ""
        '
        'cboUsername
        '
        Me.cboUsername.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cboUsername.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsername.Location = New System.Drawing.Point(136, 24)
        Me.cboUsername.Name = "cboUsername"
        Me.cboUsername.Size = New System.Drawing.Size(124, 24)
        Me.cboUsername.TabIndex = 2
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Coral
        Me.lblMsg.Location = New System.Drawing.Point(112, 89)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(184, 16)
        Me.lblMsg.TabIndex = 7
        Me.lblMsg.Text = "Wrong information!!  try again !!"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsg.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btLogin)
        Me.Panel1.Controls.Add(Me.txtPasswd)
        Me.Panel1.Controls.Add(Me.cboUsername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.lblMsg)
        Me.Panel1.Location = New System.Drawing.Point(400, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 112)
        Me.Panel1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnCancel.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnCancel.ButtonColorHover = System.Drawing.Color.IndianRed
        Me.btnCancel.ButtonColorNormal = System.Drawing.Color.Maroon
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(264, 53)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 32)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.TextColorDefault = System.Drawing.Color.Black
        Me.btnCancel.TextColorDisabled = System.Drawing.Color.Black
        Me.btnCancel.TextColorHover = System.Drawing.Color.White
        Me.btnCancel.TextColorNormal = System.Drawing.Color.White
        '
        'btLogin
        '
        Me.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btLogin.BackColor = System.Drawing.Color.Transparent
        Me.btLogin.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btLogin.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btLogin.ButtonColorHover = System.Drawing.Color.IndianRed
        Me.btLogin.ButtonColorNormal = System.Drawing.Color.Maroon
        Me.btLogin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogin.Location = New System.Drawing.Point(264, 22)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(96, 32)
        Me.btLogin.TabIndex = 5
        Me.btLogin.Text = "Login"
        Me.btLogin.TextColorDefault = System.Drawing.Color.Black
        Me.btLogin.TextColorDisabled = System.Drawing.Color.Black
        Me.btLogin.TextColorHover = System.Drawing.Color.White
        Me.btLogin.TextColorNormal = System.Drawing.Color.White
        '
        'btnKeyBoard
        '
        Me.btnKeyBoard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnKeyBoard.BackColor = System.Drawing.Color.Transparent
        Me.btnKeyBoard.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnKeyBoard.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnKeyBoard.ButtonColorHover = System.Drawing.Color.IndianRed
        Me.btnKeyBoard.ButtonColorNormal = System.Drawing.Color.Maroon
        Me.btnKeyBoard.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyBoard.Location = New System.Drawing.Point(656, 530)
        Me.btnKeyBoard.Name = "btnKeyBoard"
        Me.btnKeyBoard.Size = New System.Drawing.Size(131, 56)
        Me.btnKeyBoard.TabIndex = 8
        Me.btnKeyBoard.Text = "KeyBoard"
        Me.btnKeyBoard.TextColorDefault = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorDisabled = System.Drawing.Color.Black
        Me.btnKeyBoard.TextColorHover = System.Drawing.Color.White
        Me.btnKeyBoard.TextColorNormal = System.Drawing.Color.White
        '
        'frmLogIn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnKeyBoard)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        Call Login()

        If Trim(GetSetting("Restaurant", "PrintStartTime", "StartTime")) = vbNullString Then
            SaveSetting("Restaurant", "PrintStartTime", "StartTime", DateTime.Parse(GetOrderDate()).ToString("MM/dd/yyyy hh:mm:ss tt"))
        End If
        t = New Thread(AddressOf Me.BackgroundProcess)
        t.Start()
    End Sub

    Private Function Login()
        If Authenticate(cboUsername.Text, txtPasswd.Text) = True Then
            mdConfiguration.frmEntryPoint = Me
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
            Me.Hide()
        End If
    End Function

    Private Sub PutTextIntoControlBox(ByVal temText As String)
        'If objfrmLogin Is Nothing Then
        If CapsFlag = False Then
            Me.txtPasswd.Text += temText.ToLower
        ElseIf CapsFlag = True Then
            Me.txtPasswd.Text += temText
        End If
    End Sub

    Private Function SetRestaurantInformation()
        Dim iRowCount As Integer
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

    Private Function Authenticate(ByVal aUser As String, ByVal aPasswd As String) As Boolean
        Dim i As Integer
        For i = 0 To ds.Tables("dsUser").Rows.Count - 1
            If ds.Tables("dsUser").Rows(i).Item(0) = aUser And ds.Tables("dsUser").Rows(i).Item(1) = aPasswd Then
                mdConfiguration.user = ds.Tables("dsUser").Rows(i).Item(2)        'User Level
                mdConfiguration.struserName = ds.Tables("dsUser").Rows(i).Item(0) 'User Name
                SetRestaurantInformation()
                Return True
            End If
        Next
        lblMsg.Visible = True
        txtPasswd.Focus()
        txtPasswd.Clear()
        Return False
    End Function

    Private Sub frmLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSQL1 As String
        cboUsername.Focus()
        Try
            ds = New DataSet("User")

            DBConnection()
            strSQL = "SELECT cUser,cPassword,cPermission,nLoginStatus,cTerminal,cAccessTime FROM tUser"
            da = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            da.Fill(ds, "dsUser")

            icount = ds.Tables("dsUser").Rows.Count

            Dim dv As DataView = ds.Tables("dsUser").DefaultView
            Me.cboUsername.DataSource = dv
            Me.cboUsername.DisplayMember = "cUser"

            dsRestuarantInformation = New DataSet("RestuarantInformation")
            strSQL1 = "SELECT cRestName,cRestType,cResAddress1,cResAddress2,cResAddress3,cResPhoneNumber,cResFaxNumber," & _
                      "cResEmaiAddress,cResWebAddress,cGreetinMsg,cVatNumber,nMenuLevel,nVat,awaytime,collectiontime,waitingtime FROM tMasterInfo"

            daRestuarantInformation = New SqlClient.SqlDataAdapter(strSQL1, mdDBConnection.connRestuarant)
            daRestuarantInformation.Fill(dsRestuarantInformation, "RestuarantInformation")


        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            Dim frm As New frmDBSetUp
            frm.ShowDialog()
        End Try

        If mdConfiguration.strResturantName = "" Then
            Me.Text = "UySys eRestuarant " & ": Login"
        Else
            Me.Text = mdConfiguration.strResturantName
        End If
    End Sub

    Private Sub frmLogIn_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If connRestuarant.State = 1 Then
            connRestuarant.Close()
            Dispose()
        End If
        connRestuarant = Nothing
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If connRestuarant.State = 1 Then
            connRestuarant.Close()
            Dispose()
            Dim thisProcess = Process.GetCurrentProcess
            thisProcess.Kill()
        End If
        connRestuarant = Nothing
    End Sub

    Private Sub cboUsername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUsername.SelectedIndexChanged
        If cboUsername.SelectedIndex <> iTempUserNameIndexNumber Then
            txtPasswd.Text = ""
        End If
    End Sub

    Private Sub cboUsername_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUsername.Click
        iTempUserNameIndexNumber = cboUsername.SelectedIndex
    End Sub

    Private Sub txtPasswd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPasswd.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            'SendKeys.Send("{tab}")
            Login()
        End If
    End Sub

    Private Sub btnKeyBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyBoard.Click

        objfrmKeyBoard.Left = Me.Left

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
    'this funtion for threading purpose and use for PDA 
    Private Sub BackgroundProcess()
        Dim objDine As New frmDine
        Do While True
            objDine.PrintfromPDA()
            Thread.CurrentThread.Sleep(100000)
        Loop
    End Sub

    'Private Function ThreadClose()
    '    t.Abort()
    'End Function

    Private Sub txtPasswd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswd.TextChanged

    End Sub
End Class
