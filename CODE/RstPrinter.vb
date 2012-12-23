Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Drawing.Bitmap

Public Class RstPrinter
    Public Class printdoc
        Inherits Printing.PrintDocument

        Private strDate As String
        Private strHeader As String
        Private strAddress As String
        Private strItemStater As String
        Private strItemStaterItalic As String
        Private strItem As String
        Private strNetpay As String
        Private strviapaid As String
        Private strItemItalic As String
        Private strCustomerAddress As String
        Private strFooter As String

        Private fntDateFont As Font
        Private fntHeaderFont As Font
        Private fntAddressFont As Font
        Private fntItemStarterFont As Font
        Private fntItemStarterItalicFont As Font
        Private fntItemFont As Font
        Private fntNetpay As Font  'new added
        Private fntviapaid As Font 'new added
        Private fntItemFontItalic As Font
        Private fntCustomerAddress As Font
        Private fntFooterFont As Font

        Private iDateHeight As Integer
        Private iHeaderHeight As Integer
        Private iAddressHeight As Integer
        Private iItemStarterHeight As Integer
        Private iItemStarterItalicHeight As Integer
        Private iItemHeight As Integer
        Private iNetpayHeight As Integer
        Private iViapaidHeight As Integer
        Private iItemHeightItalic As Integer
        Private iCustomerAddressHeight As Integer
        Private iFooterHeight As Integer

        Private bmpLogo As Bitmap

        Public Sub New()
            MyBase.New()
        End Sub

        Public Property DateText() As String
            Get
                Return strDate
            End Get
            Set(ByVal Value As String)
                strDate = Value
            End Set
        End Property

        Public Property HeaderText() As String
            Get
                Return strHeader
            End Get
            Set(ByVal Value As String)
                strHeader = Value
            End Set
        End Property

        Public Property AddressText() As String
            Get
                Return strAddress
            End Get
            Set(ByVal Value As String)
                strAddress = Value
            End Set
        End Property

        Public Property ItemStarterText() As String
            Get
                Return strItemStater
            End Get
            Set(ByVal Value As String)
                strItemStater = Value
            End Set
        End Property

        Public Property ItemStarterItalicText() As String
            Get
                Return strItemStaterItalic
            End Get
            Set(ByVal Value As String)
                strItemStaterItalic = Value
            End Set
        End Property

        Public Property ItemText() As String
            Get
                Return strItem
            End Get
            Set(ByVal Value As String)
                strItem = Value
            End Set
        End Property
        Public Property NetpayText() As String
            Get
                Return strNetpay
            End Get
            Set(ByVal Value As String)
                strNetpay = Value
            End Set
        End Property

        Public Property ViaPaidText() As String
            Get
                Return strviapaid
            End Get
            Set(ByVal Value As String)
                strviapaid = Value
            End Set
        End Property

        Public Property ItemTextItalic() As String
            Get
                Return strItemItalic
            End Get
            Set(ByVal Value As String)
                strItemItalic = Value
            End Set
        End Property

        Public Property CustomerAddressText() As String
            Get
                Return strCustomerAddress
            End Get
            Set(ByVal Value As String)
                strCustomerAddress = Value
            End Set
        End Property

        Public Property FooterText() As String
            Get
                Return strFooter
            End Get
            Set(ByVal Value As String)
                strFooter = Value
            End Set
        End Property

        Public Property DateFont() As Font
            Get
                Return fntDateFont
            End Get
            Set(ByVal Value As Font)
                fntDateFont = Value
            End Set
        End Property

        Public Property HeaderFont() As Font
            Get
                Return fntHeaderFont
            End Get
            Set(ByVal Value As Font)
                fntHeaderFont = Value
            End Set
        End Property

        Public Property AddressFont() As Font
            Get
                Return fntAddressFont
            End Get
            Set(ByVal Value As Font)
                fntAddressFont = Value
            End Set
        End Property

        Public Property ItemStarterFont() As Font
            Get
                Return fntItemStarterFont
            End Get
            Set(ByVal Value As Font)
                fntItemStarterFont = Value
            End Set
        End Property

        Public Property ItemStarterItalicFont() As Font
            Get
                Return fntItemStarterItalicFont
            End Get
            Set(ByVal Value As Font)
                fntItemStarterItalicFont = Value
            End Set
        End Property

        Public Property ItemFont() As Font
            Get
                Return fntItemFont
            End Get
            Set(ByVal Value As Font)
                fntItemFont = Value
            End Set
        End Property
        Public Property NetpayFont() As Font
            Get
                Return fntNetpay
            End Get
            Set(ByVal Value As Font)
                fntNetpay = Value
            End Set
        End Property

        Public Property ViaPaidFont() As Font
            Get
                Return fntviapaid
            End Get
            Set(ByVal Value As Font)
                fntviapaid = Value
            End Set
        End Property
        Public Property ItemFontItalic() As Font
            Get
                Return fntItemFontItalic
            End Get
            Set(ByVal Value As Font)
                fntItemFontItalic = Value
            End Set
        End Property

        Public Property CustomerAddressFont() As Font
            Get
                Return fntCustomerAddress
            End Get
            Set(ByVal Value As Font)
                fntCustomerAddress = Value
            End Set
        End Property

        Public Property FooterFont() As Font
            Get
                Return fntFooterFont
            End Get
            Set(ByVal Value As Font)
                fntFooterFont = Value
            End Set
        End Property

        Public Property DateHeight() As Integer
            Get
                Return iDateHeight
            End Get
            Set(ByVal Value As Integer)
                iDateHeight = Value * fntDateFont.Height
            End Set
        End Property

        Public Property HeaderHeight() As Integer
            Get
                Return iHeaderHeight
            End Get
            Set(ByVal Value As Integer)
                iHeaderHeight = Value * fntHeaderFont.Height
            End Set
        End Property

        Public Property AddressHeight() As Integer
            Get
                Return iAddressHeight
            End Get
            Set(ByVal Value As Integer)
                iAddressHeight = Value * fntAddressFont.Height
            End Set
        End Property

        Public Property ItemStarterHeight() As Integer
            Get
                Return iItemStarterHeight
            End Get
            Set(ByVal Value As Integer)
                iItemStarterHeight = Value * fntItemStarterFont.Height
            End Set
        End Property

        Public Property ItemStarterItalicHeight() As Integer
            Get
                Return iItemStarterItalicHeight
            End Get
            Set(ByVal Value As Integer)
                iItemStarterItalicHeight = Value * fntItemStarterItalicFont.Height
            End Set
        End Property

        Public Property ItemHeight() As Integer
            Get
                Return iItemHeight
            End Get
            Set(ByVal Value As Integer)
                iItemHeight = Value * fntItemFont.Height
            End Set
        End Property
        Public Property NetpayHeight() As Integer
            Get
                Return iNetpayHeight
            End Get
            Set(ByVal Value As Integer)
                iNetpayHeight = Value * fntNetpay.Height
            End Set
        End Property

        Public Property ViaPaidHeight() As Integer
            Get
                Return iViapaidHeight
            End Get
            Set(ByVal Value As Integer)
                iViapaidHeight = Value * fntviapaid.Height
            End Set
        End Property
        Public Property ItemItalicHeight() As Integer
            Get
                Return iItemHeightItalic
            End Get
            Set(ByVal Value As Integer)
                iItemHeightItalic = Value * fntItemFontItalic.Height
            End Set
        End Property

        Public Property CustomerAddressHeight() As Integer
            Get
                Return iCustomerAddressHeight
            End Get
            Set(ByVal Value As Integer)
                iCustomerAddressHeight = Value * fntCustomerAddress.Height
            End Set
        End Property

        Public Property FooterHeight() As Integer
            Get
                Return iFooterHeight
            End Get
            Set(ByVal Value As Integer)
                iFooterHeight = Value * fntFooterFont.Height
            End Set
        End Property

        Public Property LogoImage() As Bitmap
            Get
                Return bmpLogo
            End Get
            Set(ByVal Value As Bitmap)
                bmpLogo = Value
            End Set
        End Property

        Protected Overrides Sub OnBeginPrint(ByVal ev As Printing.PrintEventArgs)
            MyBase.OnBeginPrint(ev)

            Dim strTmpText As String()

            If strDate Is Nothing Then
                strDate = ""
            End If

            If strHeader Is Nothing Then
                strHeader = ""
            End If

            If strAddress Is Nothing Then
                strAddress = ""
            End If

            If strItemStater Is Nothing Then
                strItemStater = ""
            End If

            If strItemStaterItalic Is Nothing Then
                strItemStaterItalic = ""
            End If

            If strItem Is Nothing Then
                strItem = ""
            End If

            'new added on 23.10.07
            If strNetpay Is Nothing Then
                strNetpay = ""
            End If

            'new added on 24.10.07
            If strviapaid Is Nothing Then
                strviapaid = ""
            End If



            If strItemItalic Is Nothing Then
                strItemItalic = ""
            End If

            If strCustomerAddress Is Nothing Then
                strCustomerAddress = ""
            End If

            If strFooter Is Nothing Then
                'strFooter = vbNewLine + vbNewLine + vbNewLine + vbNewLine + vbNewLine + vbNewLine + "."
                strFooter = vbNewLine + vbNewLine + vbNewLine + vbNewLine + "."
            Else
                strFooter += vbNewLine + vbNewLine + vbNewLine + vbNewLine + "."
            End If

            If fntDateFont Is Nothing Then
                fntDateFont = New Font("Lucida Console", 10)
            End If

            If fntHeaderFont Is Nothing Then
                fntHeaderFont = New Font("Lucida Console", 15, FontStyle.Bold)
            End If

            If fntAddressFont Is Nothing Then
                fntAddressFont = New Font("Lucida Console", 10)
            End If

            If fntItemStarterFont Is Nothing Then
                fntItemStarterFont = New Font("Lucida Console", 10)
            End If

            If fntItemStarterItalicFont Is Nothing Then
                fntItemStarterItalicFont = New Font("Lucida Console", 10, FontStyle.Italic)
            End If

            If fntItemFont Is Nothing Then
                fntItemFont = New Font("Lucida Console", 10)
            End If
            'new added on 23.10.07
            If fntNetpay Is Nothing Then
                fntNetpay = New Font("Lucida Console", 12, FontStyle.Bold)
            End If
            'new added on 24.10.07
            If fntviapaid Is Nothing Then
                fntviapaid = New Font("Lucida Console", 10)
            End If

            If fntItemFontItalic Is Nothing Then
                fntItemFontItalic = New Font("Lucida Console", 10, FontStyle.Italic)
            End If

            If fntCustomerAddress Is Nothing Then
                fntCustomerAddress = New Font("Lucida Console", 12, FontStyle.Bold)
            End If

            If fntFooterFont Is Nothing Then
                fntFooterFont = New Font("Lucida Console", 10)
            End If

            If iDateHeight = 0 Then
                strTmpText = strDate.Split(vbNewLine)
                iDateHeight = strTmpText.Length * fntDateFont.Height
            End If

            If iHeaderHeight = 0 Then
                strTmpText = strHeader.Split(vbNewLine)
                iHeaderHeight = strTmpText.Length * fntHeaderFont.Height
            End If

            If iAddressHeight = 0 Then
                strTmpText = strAddress.Split(vbNewLine)
                iAddressHeight = strTmpText.Length * fntAddressFont.Height
            End If

            If iItemStarterHeight = 0 Then
                strTmpText = strItemStater.Split(vbNewLine)
                iItemStarterHeight = strTmpText.Length * fntItemStarterFont.Height
            End If

            If iItemStarterItalicHeight = 0 Then
                strTmpText = strItemStaterItalic.Split(vbNewLine)
                iItemStarterItalicHeight = strTmpText.Length * fntItemStarterItalicFont.Height
            End If

            If iItemHeight = 0 Then
                strTmpText = strItem.Split(vbNewLine)
                iItemHeight = strTmpText.Length * fntItemFont.Height
            End If
            'new added 23.10.07
            If iNetpayHeight = 0 Then
                strTmpText = strNetpay.Split(vbNewLine)
                iNetpayHeight = strTmpText.Length * fntNetpay.Height
            End If
            'new added 24.10.07
            If iViapaidHeight = 0 Then
                strTmpText = strviapaid.Split(vbNewLine)
                iViapaidHeight = strTmpText.Length * fntviapaid.Height
            End If

            If iItemHeightItalic = 0 Then
                strTmpText = strItemItalic.Split(vbNewLine)
                iItemHeightItalic = strTmpText.Length * fntItemFontItalic.Height
            End If

            If iCustomerAddressHeight = 0 Then
                strTmpText = strCustomerAddress.Split(vbNewLine)
                iCustomerAddressHeight = strTmpText.Length * fntCustomerAddress.Height
            End If

            If iFooterHeight = 0 Then
                strTmpText = strFooter.Split(vbNewLine)
                iFooterHeight = strTmpText.Length * fntFooterFont.Height
            End If
        End Sub

        Protected Overrides Sub OnPrintPage(ByVal ev As Printing.PrintPageEventArgs)
            MyBase.OnPrintPage(ev)
            Static intCurrentChar As Integer
            Dim intPrintAreaHeight, intPrintAreaWidth, intMarginLeft, intMarginTop As Integer

            With MyBase.DefaultPageSettings
                intPrintAreaHeight = 0
                intPrintAreaWidth = 275
                intMarginLeft = 0
                intMarginTop = 0
            End With

            If MyBase.DefaultPageSettings.Landscape Then
                Dim intTemp As Integer
                intTemp = intPrintAreaHeight
                intPrintAreaHeight = intPrintAreaWidth
                intPrintAreaWidth = intTemp
            End If

            Dim rectPrintingAreaDate As New RectangleF(intMarginLeft, intMarginTop, intPrintAreaWidth, _
                                     intPrintAreaHeight) 'To set Date Printable area

            Dim rectPrintingAreaHeaader As New RectangleF(intMarginLeft, intMarginTop + iDateHeight, _
                                        intPrintAreaWidth, intPrintAreaHeight) 'To set Header Printable area

            Dim rectPrintingAreaAddress As New RectangleF(intMarginLeft, intMarginTop + iDateHeight _
                                        + iHeaderHeight, intPrintAreaWidth, intPrintAreaHeight) 'To set Address Printable area

            Dim rectPrintingAreaItemStarter As New RectangleF(intMarginLeft, intMarginTop + iDateHeight _
                                     + iHeaderHeight + iAddressHeight, intPrintAreaWidth, intPrintAreaHeight) 'To set Starter Item Printable area

            Dim rectPrintingAreaItemStarterItalic As New RectangleF(intMarginLeft, intMarginTop + iDateHeight _
                                     + iHeaderHeight + iAddressHeight + iItemStarterHeight, intPrintAreaWidth, intPrintAreaHeight) 'To set Starter Italic Item Printable area

            Dim rectPrintingAreaItem As New RectangleF(intMarginLeft, intMarginTop + iDateHeight _
                                     + iHeaderHeight + iAddressHeight + iItemStarterHeight + iItemStarterItalicHeight, intPrintAreaWidth, intPrintAreaHeight) 'To set Item Printable area

            Dim rectPrintingAreaItemItalic As New RectangleF(intMarginLeft, intMarginTop + iDateHeight _
                                     + iHeaderHeight + iAddressHeight + iItemStarterHeight + iItemStarterItalicHeight + iItemHeight, intPrintAreaWidth, intPrintAreaHeight) 'To set Italic Item Printable area

            Dim rectPrintingAreaCustomerAddress As New RectangleF(intMarginLeft, intMarginTop + iDateHeight _
                                     + iHeaderHeight + iAddressHeight + iItemStarterHeight + iItemStarterItalicHeight + iItemHeight + iItemHeightItalic, intPrintAreaWidth, intPrintAreaHeight) 'To set Customer Address Printable area

            Dim rectPrintingAreaFooter As New RectangleF(intMarginLeft, intMarginTop + iDateHeight + iHeaderHeight _
                                       + iAddressHeight + iItemHeight + iItemHeightItalic + iItemStarterHeight + iItemStarterItalicHeight + iCustomerAddressHeight, intPrintAreaWidth, intPrintAreaHeight) 'To set Header Printable area

            Dim objSF As New StringFormat(StringFormatFlags.LineLimit)

            Dim intLinesFilled, intCharsFitted As Int32

            '-----------------------To Print Order Date---------------------------------------------------------------
            'If strDate <> "" Then
            ev.Graphics.MeasureString(Mid(strDate, UpgradeZeros(intCurrentChar)), fntDateFont, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, intCharsFitted, intLinesFilled)

            ev.Graphics.DrawString(Mid(strDate, UpgradeZeros(intCurrentChar)), fntDateFont, _
                        Brushes.Black, rectPrintingAreaDate, objSF)
            'End If

            '---------------------------To Print Logo-----------------------------------------------------------
            If IsNothing(bmpLogo) = False Then
                ev.Graphics.DrawImage(bmpLogo, 10, iDateHeight - 5, 230, 60)
            End If

            '-----------------------To Print Header---------------------------------------------------------------
            'If strHeader <> "" Then
            ev.Graphics.MeasureString(Mid(strHeader, UpgradeZeros(intCurrentChar)), fntHeaderFont, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, intCharsFitted, intLinesFilled)

            ev.Graphics.DrawString(Mid(strHeader, UpgradeZeros(intCurrentChar)), fntHeaderFont, _
                        Brushes.Black, rectPrintingAreaHeaader, objSF)
            'End If
            '-----------------------To Print Address---------------------------------------------------------------
            'If strAddress <> "" Then
            ev.Graphics.MeasureString(Mid(strAddress, UpgradeZeros(intCurrentChar)), fntAddressFont, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, intCharsFitted, intLinesFilled)

            ev.Graphics.DrawString(Mid(strAddress, UpgradeZeros(intCurrentChar)), fntAddressFont, _
                        Brushes.Black, rectPrintingAreaAddress, objSF)
            'End If
            '-----------------------To Print Item---------------------------------------------------------------
            'If strItem <> "" Then
            ev.Graphics.MeasureString(Mid(strItemStater, UpgradeZeros(intCurrentChar)), fntItemStarterFont, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, intCharsFitted, intLinesFilled)

            ev.Graphics.DrawString(Mid(strItemStater, UpgradeZeros(intCurrentChar)), fntItemFont, _
                        Brushes.Black, rectPrintingAreaItemStarter, objSF)

            ev.Graphics.MeasureString(Mid(strItemStaterItalic, UpgradeZeros(intCurrentChar)), fntItemStarterItalicFont, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, intCharsFitted, intLinesFilled)

            ev.Graphics.DrawString(Mid(strItemStaterItalic, UpgradeZeros(intCurrentChar)), fntItemStarterItalicFont, _
                        Brushes.Black, rectPrintingAreaItemStarterItalic, objSF)

            ev.Graphics.MeasureString(Mid(strItem, UpgradeZeros(intCurrentChar)), fntItemFont, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, intCharsFitted, intLinesFilled)

            ev.Graphics.DrawString(Mid(strItem, UpgradeZeros(intCurrentChar)), fntItemFont, _
                        Brushes.Black, rectPrintingAreaItem, objSF)

            ev.Graphics.MeasureString(Mid(strItemItalic, UpgradeZeros(intCurrentChar)), fntItemFontItalic, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, intCharsFitted, intLinesFilled)

            ev.Graphics.DrawString(Mid(strItemItalic, UpgradeZeros(intCurrentChar)), fntItemFontItalic, _
                        Brushes.Black, rectPrintingAreaItemItalic, objSF)
            'End If
            '-----------------------To Print Customer Address---------------------------------------------------------------
            'If strCustomerAddress <> "" Then
            ev.Graphics.MeasureString(Mid(strCustomerAddress, UpgradeZeros(intCurrentChar)), fntCustomerAddress, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, intCharsFitted, intLinesFilled)

            ev.Graphics.DrawString(Mid(strCustomerAddress, UpgradeZeros(intCurrentChar)), fntCustomerAddress, _
                        Brushes.Black, rectPrintingAreaCustomerAddress, objSF)
            'End If
            '-----------------------To Print Footer---------------------------------------------------------------
            'If strFooter <> "" Then
            ev.Graphics.MeasureString(Mid(strFooter, UpgradeZeros(intCurrentChar)), fntFooterFont, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), objSF, intCharsFitted, intLinesFilled)

            ev.Graphics.DrawString(Mid(strFooter, UpgradeZeros(intCurrentChar)), fntFooterFont, _
                        Brushes.Black, rectPrintingAreaFooter, objSF)
            'End If
        End Sub

        Public Function UpgradeZeros(ByVal Input As Integer) As Integer
            If Input = 0 Then
                Return 1
            Else
                Return Input
            End If
        End Function

    End Class
End Class

Public Class PrintDirect
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> Structure DOCINFOW
        <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
    End Structure

    <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal data As String, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    Public Function OnCutter(ByVal tmpPrinterName As String) As Boolean
        Dim lhPrinter As New System.IntPtr
        Dim di As DOCINFOW
        Dim pcWritten As Integer
        Dim st1 As String = Microsoft.VisualBasic.ChrW(27) + Microsoft.VisualBasic.ChrW(105)
        di.pDocName = "Uysys_Cutter"
        di.pDataType = "RAW"

        PrintDirect.OpenPrinter(tmpPrinterName, lhPrinter, 0)
        PrintDirect.StartDocPrinter(lhPrinter, 1, di)
        PrintDirect.StartPagePrinter(lhPrinter)
        Try
            PrintDirect.WritePrinter(lhPrinter, st1, st1.Length, pcWritten)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        PrintDirect.EndPagePrinter(lhPrinter)
        PrintDirect.EndDocPrinter(lhPrinter)
        PrintDirect.ClosePrinter(lhPrinter)
    End Function

    Public Function OpenCashDrawer(ByVal tmpPrinterName As String) As Boolean
        Dim lhPrinter As New System.IntPtr
        Dim di As DOCINFOW
        Dim pcWritten As Integer
        Dim st2 As String = Microsoft.VisualBasic.ChrW(27) + Microsoft.VisualBasic.ChrW(112) + "0" + "50" + "40"

        di.pDocName = "Uysys_CashDrawerOpen"
        di.pDataType = "RAW"

        PrintDirect.OpenPrinter(tmpPrinterName, lhPrinter, 0)
        PrintDirect.StartDocPrinter(lhPrinter, 1, di)
        PrintDirect.StartPagePrinter(lhPrinter)
        Try
            PrintDirect.WritePrinter(lhPrinter, st2, st2.Length, pcWritten)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        PrintDirect.EndPagePrinter(lhPrinter)
        PrintDirect.EndDocPrinter(lhPrinter)
        PrintDirect.ClosePrinter(lhPrinter)
    End Function

    Public Function LevelPrint(ByVal tmpPrinterName As String, ByVal tmpItem As String) As Boolean
        Dim lhPrinter As New System.IntPtr
        Dim di As DOCINFOW
        Dim pcWritten As Integer
        Dim st1 As String = Microsoft.VisualBasic.ChrW(27) + Microsoft.VisualBasic.ChrW(105)
        di.pDocName = "Uysys_LevelPrint"
        di.pDataType = "RAW"

        PrintDirect.OpenPrinter(tmpPrinterName, lhPrinter, 0)
        PrintDirect.StartDocPrinter(lhPrinter, 1, di)
        PrintDirect.StartPagePrinter(lhPrinter)
        Try
            PrintDirect.WritePrinter(lhPrinter, tmpItem, tmpItem.Length, pcWritten)
            PrintDirect.WritePrinter(lhPrinter, st1, st1.Length, pcWritten)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        PrintDirect.EndPagePrinter(lhPrinter)
        PrintDirect.EndDocPrinter(lhPrinter)
        PrintDirect.ClosePrinter(lhPrinter)
    End Function

End Class
