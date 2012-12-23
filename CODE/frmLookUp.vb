Public Class frmLookUp
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
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lvLookUp As System.Windows.Forms.ListView
    Friend WithEvents cId As System.Windows.Forms.ColumnHeader
    Friend WithEvents cName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSC As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lvLookUp = New System.Windows.Forms.ListView
        Me.cId = New System.Windows.Forms.ColumnHeader
        Me.cName = New System.Windows.Forms.ColumnHeader
        Me.cSC = New System.Windows.Forms.ColumnHeader
        Me.lblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(72, 363)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 39)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(200, 363)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 39)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'lvLookUp
        '
        Me.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLookUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cId, Me.cName, Me.cSC})
        Me.lvLookUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLookUp.FullRowSelect = True
        Me.lvLookUp.GridLines = True
        Me.lvLookUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLookUp.Location = New System.Drawing.Point(0, 0)
        Me.lvLookUp.MultiSelect = False
        Me.lvLookUp.Name = "lvLookUp"
        Me.lvLookUp.Size = New System.Drawing.Size(380, 328)
        Me.lvLookUp.TabIndex = 0
        Me.lvLookUp.View = System.Windows.Forms.View.Details
        '
        'cId
        '
        Me.cId.Text = "ID"
        Me.cId.Width = 90
        '
        'cName
        '
        Me.cName.Text = "Name"
        Me.cName.Width = 170
        '
        'cSC
        '
        Me.cSC.Text = "ShortCode"
        Me.cSC.Width = 120
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Brown
        Me.lblMessage.Location = New System.Drawing.Point(56, 336)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(264, 16)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage.Visible = False
        '
        'frmLookUp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(380, 416)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lvLookUp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLookUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Look Up Form"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub FillListView(ByVal tmpDataSet As DataSet, ByVal tmpID As String, ByVal tmpIDLen As Integer, _
                            ByVal tmpName As String, ByVal tmpNameLen As Integer, ByVal tmpSC As String, ByVal tmpSCLen As Integer)

        Dim icount As Integer 'For count the number of rows in Category Dataset 
        Dim iIndex As Integer
        Dim i As Integer

        cId.Text = tmpID
        cId.Width = tmpIDLen

        cName.Text = tmpName
        cName.Width = tmpNameLen

        cSC.Text = tmpSC
        cSC.Width = tmpSCLen

        icount = tmpDataSet.Tables(tmpDataSet.DataSetName).Rows.Count
        For iIndex = 0 To icount - 1
            Me.lvLookUp.Items.Add(tmpDataSet.Tables(tmpDataSet.DataSetName).Rows(iIndex).Item(0))
            Me.lvLookUp.Items(iIndex).SubItems.Add(Trim(tmpDataSet.Tables(tmpDataSet.DataSetName).Rows(iIndex).Item(1)))
            Me.lvLookUp.Items(iIndex).SubItems.Add(Trim(tmpDataSet.Tables(tmpDataSet.DataSetName).Rows(iIndex).Item(2)))
        Next

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If lvLookUp.SelectedItems.Count = 1 Then
            strfindcode = Me.lvLookUp.SelectedItems(0).Text
            strfindDesc = Me.lvLookUp.SelectedItems(0).SubItems(1).Text
            strfindSC = Me.lvLookUp.SelectedItems(0).SubItems(2).Text
            Me.Dispose()
            lblMessage.Visible = True
        Else
            lblMessage.Visible = True
            lblMessage.Text = "Please Select " & cId.Text & " from above List"
        End If
    End Sub

    Private Sub lvLookUp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.DoubleClick
        strfindcode = Me.lvLookUp.SelectedItems(0).Text
        strfindDesc = Me.lvLookUp.SelectedItems(0).SubItems(1).Text
        strfindSC = Me.lvLookUp.SelectedItems(0).SubItems(2).Text
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnOk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOk.KeyDown
        btnOk.ForeColor = Color.Orange
    End Sub

    Private Sub btnOk_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOk.KeyUp
        btnOk.ForeColor = Color.Black
    End Sub

    Private Sub btnOk_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnOk.MouseDown
        btnOk.ForeColor = Color.Orange
    End Sub

    Private Sub btnOk_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnOk.MouseUp
        btnOk.ForeColor = Color.Black
    End Sub

    Private Sub btnCancel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCancel.KeyDown
        btnCancel.ForeColor = Color.Orange
    End Sub

    Private Sub btnCancel_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCancel.KeyUp
        btnCancel.ForeColor = Color.Black
    End Sub

    Private Sub btnCancel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCancel.MouseDown
        btnCancel.ForeColor = Color.Orange
    End Sub

    Private Sub btnCancel_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCancel.MouseUp
        btnCancel.ForeColor = Color.Black
    End Sub

    Private Sub lvLookUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLookUp.Click
        lblMessage.Visible = False
    End Sub

    Private Sub frmLookUp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMessage.Visible = False
    End Sub
End Class
