Module mdConfiguration

    Public frmEntryPoint As frmLogIn
    Public strCompanyName As String
    Public sOrderPrinter As String
    Public sOrderPrinter1 As String
    Public sBillPrinter As String
    Public sBarPrinter As String
    Public sLevelPrinter As String
    Public user As String
    Public struserName As String
    Public passwd As String
    Public sTerminal As String = SystemInformation.ComputerName
    Public strfindcode As String
    Public strfindDesc As String
    Public strfindSC As String
    Public dblFirstValue As Double = 1
    Public dblSecondValue As Double = 1
    Public blnEnterPress As Boolean
    Public dblResult As Double
    Public objfrmKeyBoard As New frmKeyBoard        'new added
    '***----- Restaurant Information -------***
    Public strResturantName As String
    Public strRestuarantType As String
    Public strResturantAddress1 As String
    Public strRestuantAddress2 As String
    Public strRestuantAddress3 As String
    Public strRestuarantPhone As String
    Public strRestuarantFaxNumber As String
    Public strRestuarantEmail As String
    Public strRestuarantWeb As String
    Public strGreetingMsg As String
    Public strVatNumber As String
    Public iMenuLevel As Integer
    Public iVat As Integer
    Public awaytime As Integer
    Public collectiontime As Integer
    Public waitingtime As Integer


    Public Sub CalculateResult(ByVal tmpControl As Control)

        If blnEnterPress = False Then
            dblSecondValue = tmpControl.Text
            dblResult = dblSecondValue * dblFirstValue
            tmpControl.Text = dblResult
            dblFirstValue = 1
            dblSecondValue = 1
            blnEnterPress = True
        Else
            blnEnterPress = False
        End If
    End Sub

    Public Sub IsMultiplyButtonPress(ByVal tmpControl As Control)
        dblFirstValue = tmpControl.Text
        tmpControl.Text = ""
    End Sub
    Public Sub IsEnterPress(ByVal tmpControl As Control)
        If blnEnterPress = True Then
            tmpControl.Text = ""
            blnEnterPress = False
        End If
    End Sub

    '/*--------This procedure is used to move buttons into Save mode. so that Add Button 
    'will become Save button, and Edit Button become Cancel Button and rest of the 
    'button become disable.-----------*/

    Public Sub MoveButtonAtSaveMode(ByVal tmpbtnAdd As MACButtonLib.MACButton, ByVal tmpbtnEdit As MACButtonLib.MACButton, ByVal tmpbtnDelete As MACButtonLib.MACButton, ByVal tmpbtnExit As MACButtonLib.MACButton)
        tmpbtnAdd.Enabled = True
        tmpbtnAdd.Text = "Save"
        tmpbtnEdit.Enabled = True
        tmpbtnEdit.Text = "Cancel"
        tmpbtnDelete.Enabled = False
        tmpbtnExit.Enabled = True
    End Sub

    '/*--------This procedure is used to move buttons into Edit mode. so that Add Button 
    'will become disable and rest of the Button will be Enable.-----------*/'  

    Public Sub MoveButtonAtEditMode(ByVal tmpbtnAdd As MACButtonLib.MACButton, ByVal tmpbtnEdit As MACButtonLib.MACButton, ByVal tmpbtnDelete As MACButtonLib.MACButton, ByVal tmpbtnExit As MACButtonLib.MACButton)
        tmpbtnAdd.Text = "Add"
        tmpbtnAdd.Enabled = False
        tmpbtnEdit.Text = "Edit"
        tmpbtnEdit.Enabled = True
        tmpbtnDelete.Enabled = True
        tmpbtnExit.Text = "Cancel"
        tmpbtnExit.Enabled = True
    End Sub

    '/*--------This procedure is used to move buttons into Normal mode. so that Add Button 
    'will be Enable, and Edit Button and Delete Button Will be Disable Exit Button will be Enadle---------*/

    Public Sub MoveButtonAtNormalMode(ByVal tmpbtnAdd As MACButtonLib.MACButton, ByVal tmpbtnEdit As MACButtonLib.MACButton, ByVal tmpbtnDelete As MACButtonLib.MACButton, ByVal tmpbtnExit As MACButtonLib.MACButton)
        tmpbtnAdd.Text = "Add"
        tmpbtnAdd.Enabled = True
        tmpbtnEdit.Text = "Edit"
        tmpbtnEdit.Enabled = True
        tmpbtnDelete.Enabled = True
        tmpbtnExit.Text = "Exit"
        tmpbtnExit.Enabled = True
    End Sub


    Public Sub SetEnablePropertyTrue(ByVal tempgbCustomerInfo As Object)
        '-------------------------------------------------------------------
        ' Purpose          : Following sub procedure is used to Set All Control Enable property True 
        ' Author           : Humayun Kabir Foysol/ Monjur Morshed Jami
        ' Created on       : 16-NOV-2005
        ' Last Modification: 02-Mar-2006
        ' N.B              :
        '-------------------------------------------------------------------
        Dim ctl As Control

        For Each ctl In tempgbCustomerInfo.Controls
            If TypeName(ctl) = "TextBox" Or (TypeName(ctl) = "Combobox") Or (TypeName(ctl) = "GroupBox") Then
                ctl.Enabled = True
            End If
        Next
    End Sub

    Public Sub SetEnablePropertyFalse(ByVal tempgbCustomerInfo As Object)
        '-------------------------------------------------------------------
        ' Purpose          : Following sub procedure is used to Set All Control Enable property False 
        ' Author           : Humayun Kabir Foysol/ Monjur Morshed Jami
        ' Created on       : 16-NOV-2005
        ' Last Modification: 02-Mar-2006
        ' N.B              :
        '-------------------------------------------------------------------
        Dim ctl As Control

        For Each ctl In tempgbCustomerInfo.Controls
            If TypeName(ctl) = "TextBox" Or (TypeName(ctl) = "Combobox") Or (TypeName(ctl) = "GroupBox") Then
                ctl.Enabled = False
            End If
        Next
    End Sub

    Public Sub ClearTextProperty(ByVal tempgbCustomerInfo As Object)
        '-------------------------------------------------------------------
        ' Purpose          : Following sub procedure is used to put Text Property = vbnullstring  
        ' Author           : Humayun Kabir Foysol/ Monjur Morshed Jami
        ' Created on       : 16-NOV-2005
        ' Last Modification: 05-Mar-2006
        ' N.B              :
        '-------------------------------------------------------------------
        Dim ctl As Control

        For Each ctl In tempgbCustomerInfo.Controls
            If (TypeName(ctl) = "TextBox") Or (TypeName(ctl) = "Combobox") Then
                ctl.Text = vbNullString
            End If
        Next
    End Sub

    Public Sub GenerateID(ByVal tmpSQL As String, ByVal tmpTextBox As TextBox)

        Dim dsKey As DataSet
        Dim daKey As SqlClient.SqlDataAdapter
        Dim iCount As Integer

        Try
            'DBConnection()
            dsKey = New DataSet("Key")
            daKey = New SqlClient.SqlDataAdapter(tmpSQL, mdDBConnection.connRestuarant)
            daKey.Fill(dsKey, "Key")
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            'Finally
            'DBConnectionClose()
        End Try
        iCount = dsKey.Tables("Key").Rows.Count
        If IsDBNull(dsKey.Tables("Key").Rows(0).Item(0)) Then
            tmpTextBox.Text = "1"
        Else
            tmpTextBox.Text = dsKey.Tables("Key").Rows(0).Item(0) + 1
        End If

        'If iCount = 0 Then
        '    tmpTextBox.Text = "1"
        'Else
        '    tmpTextBox.Text = dsKey.Tables("Key").Rows(0).Item(0) + 1
        'End If
    End Sub
    Public Sub GetPrinterSetting()
        sOrderPrinter = GetSetting("Restaurant", "PrintSetting", "KitchnPrinter")
        sOrderPrinter1 = GetSetting("Restaurant", "PrintSetting", "KitchnPrinter1")
        sBillPrinter = GetSetting("Restaurant", "PrintSetting", "BillPrinter")
        sBarPrinter = GetSetting("Restaurant", "PrintSetting", "BarPrinter")
        sLevelPrinter = GetSetting("Restaurant", "PrintSetting", "LevelPrinter")
    End Sub

    Public Function GetOrderDate() As Date
        Dim dOrderDate As Date
        Dim strSQL As String

        Dim cmdDate As SqlClient.SqlCommand
        Dim drDate As SqlClient.SqlDataReader

        strSQL = "SELECT GETDATE()"
        Try
            cmdDate = New SqlClient.SqlCommand
            cmdDate.Connection = mdDBConnection.connRestuarant
            cmdDate.CommandText = strSQL
            drDate = cmdDate.ExecuteReader()
            While drDate.Read
                dOrderDate = drDate.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox("This error Occurred for: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        GetOrderDate = dOrderDate
        cmdDate = Nothing
        drDate = Nothing
        mdDBConnection.connRestuarant.Close()
        mdDBConnection.connRestuarant.Open()
    End Function


End Module
