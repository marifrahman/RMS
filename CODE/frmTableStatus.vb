Public Class frmTableStatus

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTableno As System.Windows.Forms.Label
    Friend WithEvents txtTblNo As System.Windows.Forms.TextBox
    Friend WithEvents lblTblstat As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblOrdertime As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtCapacity As System.Windows.Forms.TextBox
    Friend WithEvents btnTable As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTableStatus))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnTable = New System.Windows.Forms.Button
        Me.lblOrdertime = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCapacity = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.lblTblstat = New System.Windows.Forms.Label
        Me.txtTblNo = New System.Windows.Forms.TextBox
        Me.lblTableno = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTable)
        Me.GroupBox2.Controls.Add(Me.lblOrdertime)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCapacity)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtStatus)
        Me.GroupBox2.Controls.Add(Me.lblTblstat)
        Me.GroupBox2.Controls.Add(Me.txtTblNo)
        Me.GroupBox2.Controls.Add(Me.lblTableno)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Table Status Details"
        '
        'btnTable
        '
        Me.btnTable.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnTable.Enabled = False
        Me.btnTable.Location = New System.Drawing.Point(430, -72)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(94, 54)
        Me.btnTable.TabIndex = 14
        Me.btnTable.Text = "Creat Order"
        '
        'lblOrdertime
        '
        Me.lblOrdertime.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblOrdertime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrdertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdertime.Location = New System.Drawing.Point(104, -168)
        Me.lblOrdertime.Name = "lblOrdertime"
        Me.lblOrdertime.Size = New System.Drawing.Size(144, 23)
        Me.lblOrdertime.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, -168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Order time"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCapacity
        '
        Me.txtCapacity.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapacity.Location = New System.Drawing.Point(336, -144)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.ReadOnly = True
        Me.txtCapacity.Size = New System.Drawing.Size(144, 21)
        Me.txtCapacity.TabIndex = 10
        Me.txtCapacity.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, -144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Capacity"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus.Location = New System.Drawing.Point(336, -168)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(144, 21)
        Me.txtStatus.TabIndex = 6
        Me.txtStatus.Text = ""
        '
        'lblTblstat
        '
        Me.lblTblstat.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTblstat.Location = New System.Drawing.Point(264, -168)
        Me.lblTblstat.Name = "lblTblstat"
        Me.lblTblstat.Size = New System.Drawing.Size(63, 23)
        Me.lblTblstat.TabIndex = 5
        Me.lblTblstat.Text = "Status"
        Me.lblTblstat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTblNo
        '
        Me.txtTblNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTblNo.Location = New System.Drawing.Point(104, -144)
        Me.txtTblNo.Name = "txtTblNo"
        Me.txtTblNo.ReadOnly = True
        Me.txtTblNo.Size = New System.Drawing.Size(144, 21)
        Me.txtTblNo.TabIndex = 4
        Me.txtTblNo.Text = ""
        '
        'lblTableno
        '
        Me.lblTableno.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableno.Location = New System.Drawing.Point(8, -144)
        Me.lblTableno.Name = "lblTableno"
        Me.lblTableno.Size = New System.Drawing.Size(88, 23)
        Me.lblTableno.TabIndex = 0
        Me.lblTableno.Text = "Table No."
        Me.lblTableno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(32, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 46)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.IndianRed
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(366, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 23)
        Me.Label5.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(184, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(411, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Not Free"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Free"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 288)
        Me.Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(24, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Table Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTableStatus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(736, 392)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTableStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table Status"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim WithEvents btnTableInfo As dblClickButton

    Dim dsTableInfo As DataSet
    Dim daTableInfo As SqlClient.SqlDataAdapter

    Private Sub frmTableStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strSQL As String

        lblOrdertime.Text = DateTime.Parse(GetOrderDate()).ToString("hh:mm:ss tt") 'For setting time in order time

        '----------TO Fill DataSet with Data From DB----------------------- 
        strSQL = "SELECT nTable_Id,nTable_Capacity,nStatus,nTableActive,cUserId,cTerminal,dAccessTime,cTableNumber " & _
                 "From tTable_Info WHERE nTableActive=1 ORDER BY nTable_Id "

        Try
            dsTableInfo = New DataSet("Table")
            daTableInfo = New SqlClient.SqlDataAdapter(strSQL, mdDBConnection.connRestuarant)
            daTableInfo.Fill(dsTableInfo, "Table")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try

        '------------ TO Fill MFGrid With The Table ID---------------------- 
        fillTableStatus()
    End Sub

    Private Sub fillTableStatus()
        Dim iDataSetRow As Integer
        Dim iNumberOfButtonInARow As Integer
        Dim iIndex As Integer
        Dim iColumn As Integer
        Dim iRow As Integer

        iDataSetRow = dsTableInfo.Tables("Table").Rows.Count

        If iDataSetRow > 0 Then
            iColumn = 0
            iRow = 0
            For iIndex = 0 To iDataSetRow - 1
                btnTableInfo = New dblClickButton
                With btnTableInfo
                    .Size = New System.Drawing.Size(115, 60)
                    .Location = New System.Drawing.Point((115 * iColumn) + 10, (60 * iRow) + 10)
                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    .FlatStyle = FlatStyle.Flat
                    .Text = dsTableInfo.Tables("Table").Rows(iIndex).Item(7)
                    .Tag = dsTableInfo.Tables("Table").Rows(iIndex).Item(0)
                    Me.Panel1.Controls.Add(btnTableInfo)
                    .BringToFront()
                    If dsTableInfo.Tables("Table").Rows(iIndex).Item(2) = 0 Then
                        .BackColor = Color.LightGreen
                    Else
                        .BackColor = Color.IndianRed
                        '.Enabled = False
                    End If
                End With

                iColumn += 1
                If iColumn = 6 Then
                    iColumn = 0
                    iRow += 1
                End If
                AddHandler btnTableInfo.Click, AddressOf btnTableInfo_ClickEvent
            Next
        End If
    End Sub

    Private Sub btnTableInfo_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs)
        'If sender.Clicks = 1 Then
        Dim iTableNumber As Integer
        Dim iIndex As Integer
        Dim iDataSetRow As Integer
        Dim tmpButton As Button = sender
        iDataSetRow = dsTableInfo.Tables("Table").Rows.Count
        iTableNumber = Val(Trim(tmpButton.Tag))
        putTableInfo(iTableNumber)
        'ElseIf sender.Clicks = 2 Then
        strfindcode = vbNullString
        strfindDesc = vbNullString
        strfindcode = txtTblNo.Text
        strfindDesc = txtTblNo.Tag
        Me.Dispose()
        'End If
    End Sub

    Private Sub putTableInfo(ByVal tmpTableNumber As Integer)
        '------Use to put the table information in to Table Status Details GroupBox------

        Dim iDataSetRow As Integer
        Dim i As Integer

        iDataSetRow = dsTableInfo.Tables("Table").Rows.Count

        For i = 0 To iDataSetRow - 1
            If tmpTableNumber = dsTableInfo.Tables("Table").Rows(i).Item(0) Then
                txtTblNo.Text = dsTableInfo.Tables("Table").Rows(i).Item(7)
                txtTblNo.Tag = dsTableInfo.Tables("Table").Rows(i).Item(0)
                txtCapacity.Text = dsTableInfo.Tables("Table").Rows(i).Item(1) & " Persons"

                If dsTableInfo.Tables("Table").Rows(i).Item(2) = 1 Then
                    txtStatus.Text = "Not Free"
                    btnTable.Enabled = False
                ElseIf dsTableInfo.Tables("Table").Rows(i).Item(2) = 0 Then
                    txtStatus.Text = "Free"
                    btnTable.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub btnTable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnTable.KeyDown
        btnTable.ForeColor = Color.Orange
    End Sub

    Private Sub btnTable_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnTable.KeyUp
        btnTable.ForeColor = Color.Black
    End Sub

    Private Sub btnTable_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnTable.MouseDown
        btnTable.ForeColor = Color.Orange
    End Sub

    Private Sub btnTable_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnTable.MouseUp
        btnTable.ForeColor = Color.Black
    End Sub

    Private Class dblClickButton
        Inherits System.Windows.Forms.Button

        Public noOfClicks As Integer = 0

        Public ReadOnly Property [Clicks]() As Integer
            Get
                Return noOfClicks
            End Get
        End Property

        Protected Overrides Sub WndProc(ByRef m As Message)
            If m.Msg = &H201 Then
                noOfClicks = 1
            End If

            If m.Msg = &H203 Then
                noOfClicks = 2
            End If
            MyBase.WndProc(m)
        End Sub
    End Class
End Class
