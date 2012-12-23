Module mdValidation
    '-------------------------------------------------------------------
    ' Purpose          : Following sub procedures are used For all kind of validation 
    ' Author           : 'Monjur Morshed Jami' Under The Supervision of 'Md. Arifur Rahman' 
    ' Created on       : 05-APRIL-2006
    ' Last Modification: 
    ' N.B              :

    '------------------------------------------------------------------- 

    Public ch As String
    Public strTextBeforeClick As String


    Public Sub ValidationForNumaricDataFromKeyBoaer(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal tmpTextBox As TextBox)

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

    Public Sub ValidationForPositiveNumaricData(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal tmpTextBox As TextBox)

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
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "." Then
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
    End Sub

    Public Sub ValidationForPositiveRoundNumaricData(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal tmpTextBox As TextBox)

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
        If Not IsNumeric(e.KeyChar) Then
            tmpTextBox.Text = txt
            e.Handled = True
        End If
    End Sub

    Public Sub ValidationForNumaricDataFromKeyBoaer(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal tmpComboBox As ComboBox)

        Dim txt As String
        Dim txtnew As String
        Dim s, t As Integer

        'save current text
        txt = tmpComboBox.Text
        'if something was selected in the textbox, overwrite it with the new char
        s = tmpComboBox.SelectionStart + tmpComboBox.SelectionLength
        t = tmpComboBox.Text.Length - tmpComboBox.SelectionStart - tmpComboBox.SelectionLength
        txtnew = tmpComboBox.Text.Substring(0, tmpComboBox.SelectionStart) & e.KeyChar & tmpComboBox.Text.Substring(s, t)

        'handle numeric chars
        If Char.IsControl(e.KeyChar) Then Return
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "." And e.KeyChar <> "-" Then
            tmpComboBox.Text = txt
            e.Handled = True
        End If

        'handle decimal point
        If e.KeyChar = "." Then
            If Not IsNumeric(txtnew) Then
                tmpComboBox.Text = txt
                e.Handled = True
            End If
        End If

        'handle negative numbers
        If e.KeyChar = "-" Then
            If Not IsNumeric(txtnew) Then
                tmpComboBox.Text = txt
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub ValidationForNumaricData(ByVal tmpTextBox As TextBox)

        If ch = Nothing Then
            Exit Sub
        End If

        If Not IsNumeric(ch) And ch <> "." Then
            tmpTextBox.Text = strTextBeforeClick
        End If

        If ch = "." Then
            If Not IsNumeric(Trim(tmpTextBox.Text)) Then
                tmpTextBox.Text = strTextBeforeClick
            End If
        End If
    End Sub

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

    Public Sub ValidationForCharacter(ByVal tmpTextBox As TextBox)

        If ch = Nothing Then
            Exit Sub
        End If

        If IsNumeric(ch) Then
            tmpTextBox.Text = strTextBeforeClick
        End If
    End Sub

    Public Sub ValidationForPhoneNumber(ByVal tmpTextBox As TextBox)

        If ch = Nothing Then
            Exit Sub
        End If

        If Not IsNumeric(ch) And ch <> "(" And ch <> "+" And ch <> ")" And ch <> "-" Then
            tmpTextBox.Text = strTextBeforeClick
        End If

        'handle First ( 
        If ch = "(" Then
            If InStr(1, strTextBeforeClick, "(") Or Len(strTextBeforeClick) > 0 Then
                tmpTextBox.Text = strTextBeforeClick
            End If
        End If

        'handle First +
        If ch = "+" Then
            If InStr(1, strTextBeforeClick, "+") Or Len(strTextBeforeClick) > 1 Then
                tmpTextBox.Text = strTextBeforeClick
            End If
        End If

        'handle First )
        If ch = ")" Then
            If InStr(1, strTextBeforeClick, ")") Or Len(strTextBeforeClick) > 2 Then
                tmpTextBox.Text = strTextBeforeClick
            End If
        End If

        If ch = "-" Then
            If Len(strTextBeforeClick) < 2 Then
                tmpTextBox.Text = strTextBeforeClick
            End If
        End If
        'End If
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

    Public Function IsTextEditableControl(ByVal tmpControl As Control) As Boolean

        Dim blnEditableControl As Boolean = False
        Dim tbTempbox As TextBox
        Dim cbTemComboBox As ComboBox

        If TypeName(tmpControl) = "TextBox" Then
            tbTempbox = tmpControl
            If tbTempbox.ReadOnly = False Then
                blnEditableControl = True
            Else
                blnEditableControl = False
            End If
        ElseIf TypeName(tmpControl) = "ComboBox" Then
            cbTemComboBox = tmpControl
            If cbTemComboBox.DropDownStyle = ComboBoxStyle.Simple Then
                blnEditableControl = True
            ElseIf cbTemComboBox.DropDownStyle = ComboBoxStyle.DropDown Then
                blnEditableControl = True
            Else
                blnEditableControl = False
            End If
        Else
            blnEditableControl = False
        End If
        IsTextEditableControl = blnEditableControl
    End Function
End Module
