Public Class frmSecurityCode
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        lblMessage.Text = ""
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
    Friend WithEvents txtSecurityCode As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents btnOk As MACButtonLib.MACButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtSecurityCode = New System.Windows.Forms.TextBox
        Me.lblCaption = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.btnOk = New MACButtonLib.MACButton
        Me.SuspendLayout()
        '
        'txtSecurityCode
        '
        Me.txtSecurityCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecurityCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityCode.Location = New System.Drawing.Point(184, 10)
        Me.txtSecurityCode.Name = "txtSecurityCode"
        Me.txtSecurityCode.PasswordChar = Microsoft.VisualBasic.ChrW(35)
        Me.txtSecurityCode.Size = New System.Drawing.Size(174, 21)
        Me.txtSecurityCode.TabIndex = 1
        Me.txtSecurityCode.Text = ""
        '
        'lblCaption
        '
        Me.lblCaption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(8, 9)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(168, 23)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "lblCaption"
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Brown
        Me.lblMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMessage.Location = New System.Drawing.Point(8, 48)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(256, 46)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "lblMessage"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.ButtonColorDefault = System.Drawing.Color.DarkOrange
        Me.btnOk.ButtonColorDisabled = System.Drawing.Color.SeaShell
        Me.btnOk.ButtonColorHover = System.Drawing.Color.Maroon
        Me.btnOk.ButtonColorNormal = System.Drawing.Color.Salmon
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(278, 48)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 40)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.TextColorDefault = System.Drawing.Color.Black
        Me.btnOk.TextColorDisabled = System.Drawing.Color.Black
        Me.btnOk.TextColorHover = System.Drawing.Color.White
        Me.btnOk.TextColorNormal = System.Drawing.Color.White
        '
        'frmSecurityCode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(370, 104)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtSecurityCode)
        Me.Controls.Add(Me.lblCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSecurityCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Security Code"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public strSecurityCode As String
    Public strSQLGlobalSetting As String

    Private Function ValidateSecurityCode()
        Dim objfrmGlobalInfo As New frmGlobalInfo
        Dim cmdGlobalSetting As SqlClient.SqlCommand
        If Trim(txtSecurityCode.Text) = strSecurityCode Then
            Try
                cmdGlobalSetting = New SqlClient.SqlCommand
                cmdGlobalSetting.Connection = mdDBConnection.connRestuarant
                cmdGlobalSetting.CommandText = strSQLGlobalSetting
                cmdGlobalSetting.ExecuteNonQuery()
                Me.Dispose()
            Catch ex As Exception
                MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End Try
        Else
            objfrmGlobalInfo.bSecCodeOk = False
            ShowMessage()
        End If
    End Function

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ValidateSecurityCode()
    End Sub

    Private Function ShowMessage()
        If lblCaption.Text = "Give Security Code" Then
            lblMessage.Text = "Your given security code is not correct."
            txtSecurityCode.Focus()
            Exit Function
        ElseIf lblCaption.Text = "Give Old Security Code" Then
            lblMessage.Text = "Your given security code is not correct. Conflict with old one."
            txtSecurityCode.Focus()
            Exit Function
        ElseIf lblCaption.Text = "Confirm Security Code" Then
            lblMessage.Text = "Your given security code is not correct. Conflict with the given one."
            txtSecurityCode.Focus()
            Exit Function
        End If
    End Function

    Private Sub txtSecurityCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSecurityCode.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnOk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnOk.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            ValidateSecurityCode()
        End If
    End Sub
End Class
