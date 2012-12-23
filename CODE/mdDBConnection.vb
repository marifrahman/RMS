Module mdDBConnection
    Public connRestuarant As SqlClient.SqlConnection
    Public strConncetion As String

    '##HAVE TO CHANGE as used just for generating the menu##
    'HAVE TO FIND SOME ALTERNATIVE WAY
    Public ds As DataSet
    Public da As SqlClient.SqlDataAdapter
    '#####################################

    Dim strWorkStation As String
    Dim strDataSource As String
    Public strUser As String       'To keep the logged in user ID from Login screen
    Public strTerminal As String   'To keep the computer name from which user has logged in
    Public dLogindate As Date      'To keep login date and time 
    Dim strPassword As String
    'new variable declaration
    Public strCompName As String
    Public strDBUser As String
    Public strDBPass As String
    Public strDataBase As String
    Public strInitCat As String




    Public Sub DBConnection()
        'On Error GoTo errHandler
        Call getDBSettings()
        strConncetion = "workstation id=" & strCompName & ";packet size=4096;user id=" & strDBUser & ";data source=" & strDataBase & ";persist security info=True;initial catalog=" & strInitCat & ";password=" & strDBPass & ""
        'strConncetion = "Provider=SQLOLEDB.1;Password==" & strDBPass & ";Persist Security Info=True;User ID=" & strDBUser & ";Initial Catalog=" & strInitCat & ""
        connRestuarant = New SqlClient.SqlConnection(strConncetion)
        DBConnectionOpen()
        'Exit Sub
        'errHandler:
        'Dim frm As New frmDBSetUp
        'frm.Show()
    End Sub

    Private Sub getDBSettings()
        strCompName = GetSetting("Restaurant", "DBsetup", "ComputerName")
        strDBUser = GetSetting("Restaurant", "DBsetup", "DBUser")
        strDBPass = GetSetting("Restaurant", "DBsetup", "DBPass")
        strInitCat = GetSetting("Restaurant", "DBsetup", "InitCat")
        strDataBase = GetSetting("Restaurant", "DBsetup", "DataBase")
    End Sub

    Public Sub DBConnectionOpen()
        connRestuarant.Open()
    End Sub

    'Public Sub DBConnectionClose()
    '    connRestuarant.Close()
    'End Sub

End Module
