Imports System.Data.SqlServerCe
Imports System.Data.SqlServerCe.SqlCeException
Imports System.IO
Imports System.Reflection
Imports System.Text

Module mdConfiguration
    Public applicationPath As String = Path.GetDirectoryName([Assembly].GetExecutingAssembly().GetModules(0).FullyQualifiedName)
    Public ConfigFile As String = applicationPath + "\ConfigFile.txt"

    'for connection string
    Public ServerIP As String
    Public ServerName As String
    Public dbUser As String
    Public dbPwd As String
    Public Database As String
    Public sysUser As String
    Public sysPwd As String

    'Local database connection
    Public connDishInfo As New SqlCeConnection( _
         "Data Source=" + applicationPath + "\dbeRestuarant.sdf")

    ' Connection string to Desktop SQL Server 2000
    Public rdaOleDbConnectString As String 
    'Dim clinconn As New SqlConnection("Provider=SQLOLEDB.1;Password=habijabi;Persist Security Info=True;User ID=sa;Initial Catalog=D1Temp")

    ' Declaration of the RDA object.
    Public rda As New SqlCeRemoteDataAccess

    Public Function SetOledbParameters()
        rdaOleDbConnectString = _
            "Provider=sqloledb; Data Source=" + ServerIP + " ;Initial" & _
            " Catalog=" + Database + ";User Id=" + dbUser + ";Password=" + dbPwd + ""
    End Function

    Public Function initRDA()
        '
        'Initialization of RDA obj

        '            Dim sqlStr As String
        rda.InternetUrl = "http://" + ServerIP + "/ceserver/sscesa20.dll"
        rda.LocalConnectionString = _
             "Provider=Microsoft.SQLSERVER." & _
                   "OLEDB.CE.2.0;Data Source=" + mdConfiguration.applicationPath + "\dbeRestuarant.sdf"
    End Function

    Public Function ClearControl(ByRef aForm As Form)
        Dim ctrl As Control
        For Each ctrl In aForm.Controls
            If TypeName(ctrl) = "TextBox" Then  'Or TypeName(ctrl) = "RichTextBox")And DonotClearText = False
                ctrl.Text = vbNullString
            End If
        Next
    End Function

    Public Sub ValidationForNumaricData(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal tmpTextBox As TextBox)

        Dim txt As String
        Dim txtnew As String
        Dim s, t As Integer

        'save current text
        txt = tmpTextBox.Text
        'if something was selected in the textbox, overwrite it with the new char
        s = tmpTextBox.SelectionStart + tmpTextBox.SelectionLength
        t = tmpTextBox.Text.Length - tmpTextBox.SelectionStart - tmpTextBox.SelectionLength
        txtnew = tmpTextBox.Text.Substring(0, tmpTextBox.SelectionStart) & e.KeyChar & tmpTextBox.Text.Substring(s, t)

        'handle numeric chars
        If Char.IsControl(e.KeyChar) Then Return
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "." And e.KeyChar <> "-" Then
            tmpTextBox.Text = txt
            e.Handled = True
        End If

        'handle decimal point
        If e.KeyChar = "." Then
            If Not IsNumeric(txtnew) Then
                tmpTextBox.Text = txt
                e.Handled = True
            End If
        End If

        'handle negative numbers
        If e.KeyChar = "-" Then
            If Not IsNumeric(txtnew) Then
                tmpTextBox.Text = txt
                e.Handled = True
            End If
        End If

    End Sub

    Public Function ValidationForEmailAddress(ByVal tmpTextBox As TextBox) As Boolean

        'e-mail validation 
        Dim FirstPart As String
        Dim SecondPirt As String
        Dim ThirdPart As String
        Dim tmpText As String
        Dim tmpText1 As String
        Dim temString As String

        Dim bemailAddressCorrect As Boolean

        Dim i, p As Integer
        If Len(tmpTextBox.Text) > 0 Then
            For i = 1 To Len(tmpTextBox.Text)
                tmpText = Mid(tmpTextBox.Text, i, 1)
                If tmpText <> "@" Then
                    temString = temString & tmpText
                Else
                    FirstPart = temString
                    temString = ""
                    tmpText = Mid(tmpTextBox.Text, i + 1, Len(tmpTextBox.Text) - 1)
                    Exit For
                End If
            Next

            If Len(tmpText) > 0 Then
                For i = 1 To Len(tmpText)
                    tmpText1 = Mid(tmpText, i, 1)
                    If tmpText1 <> "." Then
                        temString = temString & tmpText1
                    Else
                        SecondPirt = temString
                        ThirdPart = Mid(tmpText, i + 1, Len(tmpText) - 1)
                        Exit For
                    End If
                Next
            End If
            If Len(FirstPart) = 0 Or Len(SecondPirt) = 0 Or Len(ThirdPart) = 0 Then
                bemailAddressCorrect = False
            Else
                bemailAddressCorrect = True
            End If
        Else
            bemailAddressCorrect = True
        End If
        ValidationForEmailAddress = bemailAddressCorrect
    End Function

    Public Sub ValidationForCharacter(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal tmpTextBox As TextBox)
        Dim txt As String
        Dim txtnew As String
        Dim s, t As Integer

        'save current text
        txt = tmpTextBox.Text
        'if something was selected in the textbox, overwrite it with the new char
        s = tmpTextBox.SelectionStart + tmpTextBox.SelectionLength
        t = tmpTextBox.Text.Length - tmpTextBox.SelectionStart - tmpTextBox.SelectionLength
        txtnew = tmpTextBox.Text.Substring(0, tmpTextBox.SelectionStart) & e.KeyChar & tmpTextBox.Text.Substring(s, t)

        'handle numeric chars
        If Char.IsControl(e.KeyChar) Then Return
        If IsNumeric(e.KeyChar) Then
            tmpTextBox.Text = txt
            e.Handled = True
        End If

    End Sub
#Region "Error Messages"

    Public Sub ShowErrors(ByVal e As SqlCeException)
        Dim errorCollection As SqlCeErrorCollection = e.Errors

        Dim bld As New StringBuilder
        Dim inner As Exception = e.InnerException

        If Not inner Is Nothing Then
            MessageBox.Show(("Inner Exception: " & inner.ToString()))
        End If
        Dim err As SqlCeError
        ' Enumerate each error to a message box.
        For Each err In errorCollection
            bld.Append((ControlChars.Cr & _
                        " Error Code: " & _
                        err.HResult.ToString("X")))
            bld.Append((ControlChars.Cr & _
                        " Message   : " & _
                        err.Message))
            bld.Append((ControlChars.Cr & _
                        " Minor Err.: " & _
                        err.NativeError))
            bld.Append((ControlChars.Cr & _
                        " Source    : " & _
                        err.Source))
            ' Retrieve the error parameter 
            ' numbers for each error.
            Dim numPar As Integer
            For Each numPar In err.NumericErrorParameters
                If 0 <> numPar Then
                    bld.Append((ControlChars.Cr & _
                                " Num. Par. : " & _
                                numPar))
                End If
            Next numPar
            ' Retrieve the error parameters for each error.
            Dim errPar As String
            For Each errPar In err.ErrorParameters
                If [String].Empty <> errPar Then
                    bld.Append((ControlChars.Cr & _
                                " Err. Par. : " & _
                                errPar))
                End If
            Next errPar
            MessageBox.Show(bld.ToString())
            bld.Remove(0, bld.Length)
        Next err
    End Sub
#End Region
End Module
