Public Class frmKeyBoard
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
    Friend WithEvents btncifttirnak As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btncarpi As System.Windows.Forms.Button
    Friend WithEvents btneksi As System.Windows.Forms.Button
    Friend WithEvents btnbackspace As System.Windows.Forms.Button
    Friend WithEvents btntab As System.Windows.Forms.Button
    Friend WithEvents btnq As System.Windows.Forms.Button
    Friend WithEvents btnw As System.Windows.Forms.Button
    Friend WithEvents btne As System.Windows.Forms.Button
    Friend WithEvents btnr As System.Windows.Forms.Button
    Friend WithEvents btnt As System.Windows.Forms.Button
    Friend WithEvents btny As System.Windows.Forms.Button
    Friend WithEvents btnu As System.Windows.Forms.Button
    Friend WithEvents btno As System.Windows.Forms.Button
    Friend WithEvents btnp As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnlock As System.Windows.Forms.Button
    Friend WithEvents btna As System.Windows.Forms.Button
    Friend WithEvents btns As System.Windows.Forms.Button
    Friend WithEvents btnd As System.Windows.Forms.Button
    Friend WithEvents btnf As System.Windows.Forms.Button
    Friend WithEvents btng As System.Windows.Forms.Button
    Friend WithEvents btnh As System.Windows.Forms.Button
    Friend WithEvents btnj As System.Windows.Forms.Button
    Friend WithEvents btnk As System.Windows.Forms.Button
    Friend WithEvents btnl As System.Windows.Forms.Button
    Friend WithEvents btnenter As System.Windows.Forms.Button
    Friend WithEvents btnsolshift As System.Windows.Forms.Button
    Friend WithEvents btnz As System.Windows.Forms.Button
    Friend WithEvents btnx As System.Windows.Forms.Button
    Friend WithEvents btnc As System.Windows.Forms.Button
    Friend WithEvents btnv As System.Windows.Forms.Button
    Friend WithEvents btnb As System.Windows.Forms.Button
    Friend WithEvents btnn As System.Windows.Forms.Button
    Friend WithEvents btnm As System.Windows.Forms.Button
    Friend WithEvents btnnokta As System.Windows.Forms.Button
    Friend WithEvents btnyukari As System.Windows.Forms.Button
    Friend WithEvents btnsolctrl As System.Windows.Forms.Button
    Friend WithEvents btnsolalt As System.Windows.Forms.Button
    Friend WithEvents btnspace As System.Windows.Forms.Button
    Friend WithEvents btnasagi As System.Windows.Forms.Button
    Friend WithEvents btnsol As System.Windows.Forms.Button
    Friend WithEvents btnsag As System.Windows.Forms.Button
    Friend WithEvents btnvirgul As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btni As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKeyBoard))
        Me.btncifttirnak = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn4 = New System.Windows.Forms.Button
        Me.btn5 = New System.Windows.Forms.Button
        Me.btn6 = New System.Windows.Forms.Button
        Me.btn7 = New System.Windows.Forms.Button
        Me.btn8 = New System.Windows.Forms.Button
        Me.btn9 = New System.Windows.Forms.Button
        Me.btn0 = New System.Windows.Forms.Button
        Me.btncarpi = New System.Windows.Forms.Button
        Me.btneksi = New System.Windows.Forms.Button
        Me.btnbackspace = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btntab = New System.Windows.Forms.Button
        Me.btnq = New System.Windows.Forms.Button
        Me.btnw = New System.Windows.Forms.Button
        Me.btne = New System.Windows.Forms.Button
        Me.btnr = New System.Windows.Forms.Button
        Me.btnt = New System.Windows.Forms.Button
        Me.btny = New System.Windows.Forms.Button
        Me.btnu = New System.Windows.Forms.Button
        Me.btni = New System.Windows.Forms.Button
        Me.btno = New System.Windows.Forms.Button
        Me.btnp = New System.Windows.Forms.Button
        Me.btnvirgul = New System.Windows.Forms.Button
        Me.btndel = New System.Windows.Forms.Button
        Me.btnlock = New System.Windows.Forms.Button
        Me.btna = New System.Windows.Forms.Button
        Me.btns = New System.Windows.Forms.Button
        Me.btnd = New System.Windows.Forms.Button
        Me.btnf = New System.Windows.Forms.Button
        Me.btng = New System.Windows.Forms.Button
        Me.btnh = New System.Windows.Forms.Button
        Me.btnj = New System.Windows.Forms.Button
        Me.btnk = New System.Windows.Forms.Button
        Me.btnl = New System.Windows.Forms.Button
        Me.btnenter = New System.Windows.Forms.Button
        Me.btnsolshift = New System.Windows.Forms.Button
        Me.btnz = New System.Windows.Forms.Button
        Me.btnx = New System.Windows.Forms.Button
        Me.btnc = New System.Windows.Forms.Button
        Me.btnv = New System.Windows.Forms.Button
        Me.btnb = New System.Windows.Forms.Button
        Me.btnn = New System.Windows.Forms.Button
        Me.btnm = New System.Windows.Forms.Button
        Me.btnnokta = New System.Windows.Forms.Button
        Me.btnyukari = New System.Windows.Forms.Button
        Me.btnsolctrl = New System.Windows.Forms.Button
        Me.btnsolalt = New System.Windows.Forms.Button
        Me.btnspace = New System.Windows.Forms.Button
        Me.btnasagi = New System.Windows.Forms.Button
        Me.btnsol = New System.Windows.Forms.Button
        Me.btnsag = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnDivide = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btncifttirnak
        '
        Me.btncifttirnak.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btncifttirnak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btncifttirnak.Location = New System.Drawing.Point(9, 8)
        Me.btncifttirnak.Name = "btncifttirnak"
        Me.btncifttirnak.Size = New System.Drawing.Size(48, 32)
        Me.btncifttirnak.TabIndex = 16
        Me.btncifttirnak.Text = """"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn1.Location = New System.Drawing.Point(57, 8)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(48, 32)
        Me.btn1.TabIndex = 17
        Me.btn1.Text = "1 !"
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn2.Location = New System.Drawing.Point(105, 8)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(48, 32)
        Me.btn2.TabIndex = 18
        Me.btn2.Text = "2 @"
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn3.Location = New System.Drawing.Point(153, 8)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(48, 32)
        Me.btn3.TabIndex = 19
        Me.btn3.Text = "3 #"
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn4.Location = New System.Drawing.Point(201, 8)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(48, 32)
        Me.btn4.TabIndex = 20
        Me.btn4.Text = "4 $"
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn5.Location = New System.Drawing.Point(249, 8)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(48, 32)
        Me.btn5.TabIndex = 21
        Me.btn5.Text = "5 %"
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn6.Location = New System.Drawing.Point(297, 8)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(48, 32)
        Me.btn6.TabIndex = 22
        Me.btn6.Text = "6 ^"
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn7.Location = New System.Drawing.Point(345, 8)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(48, 32)
        Me.btn7.TabIndex = 23
        Me.btn7.Text = "7 &&"
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn8.Location = New System.Drawing.Point(393, 8)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(48, 32)
        Me.btn8.TabIndex = 24
        Me.btn8.Text = "8 *"
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn9.Location = New System.Drawing.Point(441, 8)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(48, 32)
        Me.btn9.TabIndex = 25
        Me.btn9.Text = "9 ("
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn0.Location = New System.Drawing.Point(489, 8)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(48, 32)
        Me.btn0.TabIndex = 26
        Me.btn0.Text = "0 )"
        '
        'btncarpi
        '
        Me.btncarpi.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btncarpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btncarpi.Location = New System.Drawing.Point(633, 8)
        Me.btncarpi.Name = "btncarpi"
        Me.btncarpi.Size = New System.Drawing.Size(48, 32)
        Me.btncarpi.TabIndex = 27
        Me.btncarpi.Text = "*"
        '
        'btneksi
        '
        Me.btneksi.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btneksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btneksi.Location = New System.Drawing.Point(585, 8)
        Me.btneksi.Name = "btneksi"
        Me.btneksi.Size = New System.Drawing.Size(48, 32)
        Me.btneksi.TabIndex = 28
        Me.btneksi.Text = "-"
        '
        'btnbackspace
        '
        Me.btnbackspace.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnbackspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnbackspace.ImageIndex = 2
        Me.btnbackspace.ImageList = Me.ImageList1
        Me.btnbackspace.Location = New System.Drawing.Point(705, 40)
        Me.btnbackspace.Name = "btnbackspace"
        Me.btnbackspace.Size = New System.Drawing.Size(80, 32)
        Me.btnbackspace.TabIndex = 29
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btntab
        '
        Me.btntab.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btntab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btntab.Location = New System.Drawing.Point(9, 40)
        Me.btntab.Name = "btntab"
        Me.btntab.Size = New System.Drawing.Size(48, 32)
        Me.btntab.TabIndex = 33
        Me.btntab.Text = "tab"
        '
        'btnq
        '
        Me.btnq.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnq.Location = New System.Drawing.Point(57, 40)
        Me.btnq.Name = "btnq"
        Me.btnq.Size = New System.Drawing.Size(48, 32)
        Me.btnq.TabIndex = 34
        Me.btnq.Text = "Q"
        '
        'btnw
        '
        Me.btnw.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnw.Location = New System.Drawing.Point(105, 40)
        Me.btnw.Name = "btnw"
        Me.btnw.Size = New System.Drawing.Size(48, 32)
        Me.btnw.TabIndex = 35
        Me.btnw.Text = "W"
        '
        'btne
        '
        Me.btne.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btne.Location = New System.Drawing.Point(153, 40)
        Me.btne.Name = "btne"
        Me.btne.Size = New System.Drawing.Size(48, 32)
        Me.btne.TabIndex = 36
        Me.btne.Text = "E"
        '
        'btnr
        '
        Me.btnr.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnr.Location = New System.Drawing.Point(201, 40)
        Me.btnr.Name = "btnr"
        Me.btnr.Size = New System.Drawing.Size(48, 32)
        Me.btnr.TabIndex = 37
        Me.btnr.Text = "R"
        '
        'btnt
        '
        Me.btnt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnt.Location = New System.Drawing.Point(249, 40)
        Me.btnt.Name = "btnt"
        Me.btnt.Size = New System.Drawing.Size(48, 32)
        Me.btnt.TabIndex = 38
        Me.btnt.Text = "T"
        '
        'btny
        '
        Me.btny.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btny.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btny.Location = New System.Drawing.Point(297, 40)
        Me.btny.Name = "btny"
        Me.btny.Size = New System.Drawing.Size(48, 32)
        Me.btny.TabIndex = 39
        Me.btny.Text = "Y"
        '
        'btnu
        '
        Me.btnu.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnu.Location = New System.Drawing.Point(345, 40)
        Me.btnu.Name = "btnu"
        Me.btnu.Size = New System.Drawing.Size(48, 32)
        Me.btnu.TabIndex = 40
        Me.btnu.Text = "U"
        '
        'btni
        '
        Me.btni.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btni.Location = New System.Drawing.Point(393, 40)
        Me.btni.Name = "btni"
        Me.btni.Size = New System.Drawing.Size(48, 32)
        Me.btni.TabIndex = 41
        Me.btni.Text = "I"
        '
        'btno
        '
        Me.btno.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btno.Location = New System.Drawing.Point(441, 40)
        Me.btno.Name = "btno"
        Me.btno.Size = New System.Drawing.Size(48, 32)
        Me.btno.TabIndex = 42
        Me.btno.Text = "O"
        '
        'btnp
        '
        Me.btnp.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnp.Location = New System.Drawing.Point(489, 40)
        Me.btnp.Name = "btnp"
        Me.btnp.Size = New System.Drawing.Size(48, 32)
        Me.btnp.TabIndex = 43
        Me.btnp.Text = "P"
        '
        'btnvirgul
        '
        Me.btnvirgul.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnvirgul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnvirgul.Location = New System.Drawing.Point(537, 40)
        Me.btnvirgul.Name = "btnvirgul"
        Me.btnvirgul.Size = New System.Drawing.Size(48, 32)
        Me.btnvirgul.TabIndex = 46
        Me.btnvirgul.Text = ","
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btndel.Location = New System.Drawing.Point(625, 40)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(80, 32)
        Me.btndel.TabIndex = 47
        Me.btndel.Text = "del"
        '
        'btnlock
        '
        Me.btnlock.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnlock.Location = New System.Drawing.Point(9, 72)
        Me.btnlock.Name = "btnlock"
        Me.btnlock.Size = New System.Drawing.Size(64, 32)
        Me.btnlock.TabIndex = 50
        Me.btnlock.Text = "Caps lock"
        '
        'btna
        '
        Me.btna.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btna.Location = New System.Drawing.Point(73, 72)
        Me.btna.Name = "btna"
        Me.btna.Size = New System.Drawing.Size(48, 32)
        Me.btna.TabIndex = 51
        Me.btna.Text = "A"
        '
        'btns
        '
        Me.btns.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btns.Location = New System.Drawing.Point(121, 72)
        Me.btns.Name = "btns"
        Me.btns.Size = New System.Drawing.Size(48, 32)
        Me.btns.TabIndex = 52
        Me.btns.Text = "S"
        '
        'btnd
        '
        Me.btnd.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnd.Location = New System.Drawing.Point(169, 72)
        Me.btnd.Name = "btnd"
        Me.btnd.Size = New System.Drawing.Size(48, 32)
        Me.btnd.TabIndex = 53
        Me.btnd.Text = "D"
        '
        'btnf
        '
        Me.btnf.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnf.Location = New System.Drawing.Point(217, 72)
        Me.btnf.Name = "btnf"
        Me.btnf.Size = New System.Drawing.Size(48, 32)
        Me.btnf.TabIndex = 54
        Me.btnf.Text = "F"
        '
        'btng
        '
        Me.btng.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btng.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btng.Location = New System.Drawing.Point(265, 72)
        Me.btng.Name = "btng"
        Me.btng.Size = New System.Drawing.Size(48, 32)
        Me.btng.TabIndex = 55
        Me.btng.Text = "G"
        '
        'btnh
        '
        Me.btnh.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnh.Location = New System.Drawing.Point(313, 72)
        Me.btnh.Name = "btnh"
        Me.btnh.Size = New System.Drawing.Size(48, 32)
        Me.btnh.TabIndex = 56
        Me.btnh.Text = "H"
        '
        'btnj
        '
        Me.btnj.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnj.Location = New System.Drawing.Point(361, 72)
        Me.btnj.Name = "btnj"
        Me.btnj.Size = New System.Drawing.Size(48, 32)
        Me.btnj.TabIndex = 57
        Me.btnj.Text = "J"
        '
        'btnk
        '
        Me.btnk.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnk.Location = New System.Drawing.Point(409, 72)
        Me.btnk.Name = "btnk"
        Me.btnk.Size = New System.Drawing.Size(48, 32)
        Me.btnk.TabIndex = 58
        Me.btnk.Text = "K"
        '
        'btnl
        '
        Me.btnl.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnl.Location = New System.Drawing.Point(457, 72)
        Me.btnl.Name = "btnl"
        Me.btnl.Size = New System.Drawing.Size(48, 32)
        Me.btnl.TabIndex = 59
        Me.btnl.Text = "L"
        '
        'btnenter
        '
        Me.btnenter.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnenter.Location = New System.Drawing.Point(505, 72)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.Size = New System.Drawing.Size(136, 32)
        Me.btnenter.TabIndex = 62
        Me.btnenter.Text = "Enter"
        '
        'btnsolshift
        '
        Me.btnsolshift.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsolshift.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsolshift.Location = New System.Drawing.Point(9, 104)
        Me.btnsolshift.Name = "btnsolshift"
        Me.btnsolshift.Size = New System.Drawing.Size(80, 32)
        Me.btnsolshift.TabIndex = 63
        Me.btnsolshift.Text = "shift"
        '
        'btnz
        '
        Me.btnz.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnz.Location = New System.Drawing.Point(89, 104)
        Me.btnz.Name = "btnz"
        Me.btnz.Size = New System.Drawing.Size(48, 32)
        Me.btnz.TabIndex = 64
        Me.btnz.Text = "Z"
        '
        'btnx
        '
        Me.btnx.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnx.Location = New System.Drawing.Point(137, 104)
        Me.btnx.Name = "btnx"
        Me.btnx.Size = New System.Drawing.Size(48, 32)
        Me.btnx.TabIndex = 65
        Me.btnx.Text = "X"
        '
        'btnc
        '
        Me.btnc.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnc.Location = New System.Drawing.Point(185, 104)
        Me.btnc.Name = "btnc"
        Me.btnc.Size = New System.Drawing.Size(48, 32)
        Me.btnc.TabIndex = 66
        Me.btnc.Text = "C"
        '
        'btnv
        '
        Me.btnv.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnv.Location = New System.Drawing.Point(233, 104)
        Me.btnv.Name = "btnv"
        Me.btnv.Size = New System.Drawing.Size(48, 32)
        Me.btnv.TabIndex = 67
        Me.btnv.Text = "V"
        '
        'btnb
        '
        Me.btnb.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnb.Location = New System.Drawing.Point(281, 104)
        Me.btnb.Name = "btnb"
        Me.btnb.Size = New System.Drawing.Size(48, 32)
        Me.btnb.TabIndex = 68
        Me.btnb.Text = "B"
        '
        'btnn
        '
        Me.btnn.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnn.Location = New System.Drawing.Point(329, 104)
        Me.btnn.Name = "btnn"
        Me.btnn.Size = New System.Drawing.Size(48, 32)
        Me.btnn.TabIndex = 69
        Me.btnn.Text = "N"
        '
        'btnm
        '
        Me.btnm.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnm.Location = New System.Drawing.Point(377, 104)
        Me.btnm.Name = "btnm"
        Me.btnm.Size = New System.Drawing.Size(48, 32)
        Me.btnm.TabIndex = 70
        Me.btnm.Text = "M"
        '
        'btnnokta
        '
        Me.btnnokta.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnnokta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnnokta.Location = New System.Drawing.Point(585, 40)
        Me.btnnokta.Name = "btnnokta"
        Me.btnnokta.Size = New System.Drawing.Size(48, 32)
        Me.btnnokta.TabIndex = 73
        Me.btnnokta.Text = "."
        '
        'btnyukari
        '
        Me.btnyukari.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnyukari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnyukari.ImageIndex = 3
        Me.btnyukari.ImageList = Me.ImageList1
        Me.btnyukari.Location = New System.Drawing.Point(689, 72)
        Me.btnyukari.Name = "btnyukari"
        Me.btnyukari.Size = New System.Drawing.Size(48, 32)
        Me.btnyukari.TabIndex = 75
        '
        'btnsolctrl
        '
        Me.btnsolctrl.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsolctrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsolctrl.Location = New System.Drawing.Point(545, 104)
        Me.btnsolctrl.Name = "btnsolctrl"
        Me.btnsolctrl.Size = New System.Drawing.Size(48, 32)
        Me.btnsolctrl.TabIndex = 76
        Me.btnsolctrl.Text = "ctrl"
        '
        'btnsolalt
        '
        Me.btnsolalt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsolalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsolalt.Location = New System.Drawing.Point(593, 104)
        Me.btnsolalt.Name = "btnsolalt"
        Me.btnsolalt.Size = New System.Drawing.Size(48, 32)
        Me.btnsolalt.TabIndex = 78
        Me.btnsolalt.Text = "alt"
        '
        'btnspace
        '
        Me.btnspace.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnspace.Location = New System.Drawing.Point(425, 104)
        Me.btnspace.Name = "btnspace"
        Me.btnspace.Size = New System.Drawing.Size(128, 32)
        Me.btnspace.TabIndex = 79
        '
        'btnasagi
        '
        Me.btnasagi.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnasagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnasagi.ImageIndex = 0
        Me.btnasagi.ImageList = Me.ImageList1
        Me.btnasagi.Location = New System.Drawing.Point(689, 104)
        Me.btnasagi.Name = "btnasagi"
        Me.btnasagi.Size = New System.Drawing.Size(48, 32)
        Me.btnasagi.TabIndex = 84
        '
        'btnsol
        '
        Me.btnsol.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsol.ImageIndex = 2
        Me.btnsol.ImageList = Me.ImageList1
        Me.btnsol.Location = New System.Drawing.Point(641, 104)
        Me.btnsol.Name = "btnsol"
        Me.btnsol.Size = New System.Drawing.Size(48, 32)
        Me.btnsol.TabIndex = 85
        '
        'btnsag
        '
        Me.btnsag.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnsag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnsag.ImageIndex = 1
        Me.btnsag.ImageList = Me.ImageList1
        Me.btnsag.Location = New System.Drawing.Point(737, 104)
        Me.btnsag.Name = "btnsag"
        Me.btnsag.Size = New System.Drawing.Size(48, 32)
        Me.btnsag.TabIndex = 86
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(537, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(48, 32)
        Me.btnAdd.TabIndex = 94
        Me.btnAdd.Text = "+"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(681, 8)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(48, 32)
        Me.btnDivide.TabIndex = 88
        Me.btnDivide.Text = "/"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnExit.Location = New System.Drawing.Point(729, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 32)
        Me.btnExit.TabIndex = 95
        Me.btnExit.Text = "Exit"
        '
        'frmKeyBoard
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(794, 144)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnsag)
        Me.Controls.Add(Me.btnsol)
        Me.Controls.Add(Me.btnasagi)
        Me.Controls.Add(Me.btnspace)
        Me.Controls.Add(Me.btnsolalt)
        Me.Controls.Add(Me.btnsolctrl)
        Me.Controls.Add(Me.btnyukari)
        Me.Controls.Add(Me.btnnokta)
        Me.Controls.Add(Me.btnm)
        Me.Controls.Add(Me.btnn)
        Me.Controls.Add(Me.btnb)
        Me.Controls.Add(Me.btnv)
        Me.Controls.Add(Me.btnc)
        Me.Controls.Add(Me.btnx)
        Me.Controls.Add(Me.btnz)
        Me.Controls.Add(Me.btnsolshift)
        Me.Controls.Add(Me.btnenter)
        Me.Controls.Add(Me.btnl)
        Me.Controls.Add(Me.btnk)
        Me.Controls.Add(Me.btnj)
        Me.Controls.Add(Me.btnh)
        Me.Controls.Add(Me.btng)
        Me.Controls.Add(Me.btnf)
        Me.Controls.Add(Me.btnd)
        Me.Controls.Add(Me.btns)
        Me.Controls.Add(Me.btna)
        Me.Controls.Add(Me.btnlock)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnvirgul)
        Me.Controls.Add(Me.btnp)
        Me.Controls.Add(Me.btno)
        Me.Controls.Add(Me.btni)
        Me.Controls.Add(Me.btnu)
        Me.Controls.Add(Me.btny)
        Me.Controls.Add(Me.btnt)
        Me.Controls.Add(Me.btnr)
        Me.Controls.Add(Me.btne)
        Me.Controls.Add(Me.btnw)
        Me.Controls.Add(Me.btnq)
        Me.Controls.Add(Me.btntab)
        Me.Controls.Add(Me.btnbackspace)
        Me.Controls.Add(Me.btneksi)
        Me.Controls.Add(Me.btncarpi)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btncifttirnak)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 432)
        Me.MaximumSize = New System.Drawing.Size(800, 168)
        Me.MinimumSize = New System.Drawing.Size(800, 168)
        Me.Name = "frmKeyBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "API fonction"
    'Public Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As Long
    'this function gets active window identify number == (8975651603260375040)
    Public Declare Function SetActiveWindow Lib "user32" Alias "SetActiveWindow" _
    (ByVal hwnd As Long) As Long

    Declare Function keybd_event Lib "user32" Alias "keybd_event" _
    (ByVal bVk As Byte, ByVal bScan _
    As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long) As Long

#End Region

#Region "constraints"
    Const KEYEVENTF_KEYUP = &H2 ' Release key 
    Const VK_LBUTTON = &H1 'Left mouse button. 
    Const VK_RBUTTON = &H2 'Right mouse button. 
    Const VK_CANCEL = &H3 'Used for control-break processing. 
    Const VK_MBUTTON = &H4 '''Middle mouse button (3-button mouse). 
    Const VK_BACK = &H8
    Const VK_TAB = &H9
    Const VK_CLEAR = &HC
    Const VK_PRINT = &H2A
    Const VK_RETURN = &HD   'enter
    Const VK_SHIFT = &H10
    Const VK_CONTROL = &H11
    Const VK_SCROLL = &H91
    Const VK_MENU = &H12   'Alt (either one)
    Const VK_PAUSE = &H13
    Const VK_CAPITAL = &H14
    Const VK_ESCAPE = &H1B
    Const VK_STARTKEY = &H5B 'Start Menu key
    Const VK_SPACE = &H20
    Const VK_PRIOR = &H21 'Page up. 
    Const VK_NEXT = &H22 'Page down. 
    Const VK_END = &H23
    Const VK_HOME = &H24
    Const VK_LEFT = &H25
    Const VK_UP = &H26
    Const VK_RIGHT = &H27
    Const VK_DOWN = &H28
    Const VK_SELECT = &H29
    Const VK_INSERT = &H2D
    Const VK_DELETE = &H2E
    Const VK_HELP = &H2F
    Const VK_OEM_COMMA = &HBC     ',  comma
    Const VK_NUMLOCK = &H90 '      Num Lock
    Const KEYEVENTF_EXTENDEDKEY = &H1
    Const VK_0 = &H30
    Const VK_1 = &H31
    Const VK_2 = &H32
    Const VK_3 = &H33
    Const VK_4 = &H34
    Const VK_5 = &H35
    Const VK_6 = &H36
    Const VK_7 = &H37
    Const VK_8 = &H38
    Const VK_9 = &H39
    Const VK_A = &H41
    Const VK_B = &H42
    Const VK_C = &H43
    Const VK_D = &H44
    Const VK_E = &H45
    Const VK_F = &H46
    Const VK_G = &H47
    Const VK_H = &H48
    Const VK_I = &H49
    Const VK_J = &H4A
    Const VK_K = &H4B
    Const VK_L = &H4C
    Const VK_M = &H4D
    Const VK_N = &H4E
    Const VK_O = &H4F
    Const VK_P = &H50
    Const VK_Q = &H51
    Const VK_R = &H52
    Const VK_S = &H53
    Const VK_T = &H54
    Const VK_U = &H55
    Const VK_V = &H56
    Const VK_W = &H57
    Const VK_X = &H58
    Const VK_Y = &H59
    Const VK_Z = &H5A
    Const VK_NUMPAD0 = &H60
    Const VK_NUMPAD1 = &H61
    Const VK_NUMPAD2 = &H62
    Const VK_NUMPAD3 = &H63
    Const VK_NUMPAD4 = &H64
    Const VK_NUMPAD5 = &H65
    Const VK_NUMPAD6 = &H66
    Const VK_NUMPAD7 = &H67
    Const VK_NUMPAD8 = &H68
    Const VK_NUMPAD9 = &H69
    Const VK_MULTIPLY = &H6A    '     * (keypad)
    Const VK_ADD = &H6B
    Const VK_SEPARATER = &H6C
    Const VK_SEPARATOR = &H6C
    Const VK_SUBTRACT = &H6D
    Const VK_DECIMAL = &H6E
    Const VK_DIVIDE = &H6F
    Const VK_OEM_2 = &HBF  '      /
    Const VK_OEM_PERIOD = &HBE '.
    Const VK_F1 = &H70
    Const VK_F2 = &H71
    Const VK_F3 = &H72
    Const VK_F4 = &H73
    Const VK_F5 = &H74
    Const VK_F6 = &H75
    Const VK_F7 = &H76
    Const VK_F8 = &H77
    Const VK_F9 = &H78
    Const VK_F10 = &H79
    Const VK_F11 = &H7A
    Const VK_F12 = &H7B
    Const VK_F13 = &H7C
    Const VK_F14 = &H7D
    Const VK_F15 = &H7E
    Const VK_F16 = &H7F
    Const VK_F17 = &H80
    Const VK_F18 = &H81
    Const VK_F19 = &H82
    Const VK_F20 = &H83
    Const VK_F21 = &H84
    Const VK_F22 = &H85
    Const VK_F23 = &H86
    Const VK_F24 = &H87
    '****************
    Const VK_CRSEL = &HF7
    Const VK_EREOF = &HF9
    Const VK_EXECUTE = &H2B
    Const VK_EXSEL = &HF8
    Const VK_NONAME = &HFC
    Const VK_OEM_CLEAR = &HFE
    Const VK_PA1 = &HFD
    Const VK_PROCESSKEY = &HE5
    Const CAPSLOCK_ON = &H80    '  the capslock light is on.
    '****************
    Dim lockbool, numlockbool, ctrlbool As Boolean
    Dim onoff As Boolean
#End Region

#Region "which button pushed function"
    Public Function whichbuttonpushed(ByVal _sender As String) As String
        Try
            SetActiveWindow(8975651603260375040) 'Set focus Active window
            'I found this number("8975651603260375040") via getactivewindow method.
            Select Case _sender
                Case "btna"
                    keybd_event(VK_A, 0, 0, 0)
                    keybd_event(VK_A, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnb"
                    keybd_event(VK_B, 0, 0, 0)
                    keybd_event(VK_B, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnc"
                    keybd_event(VK_C, 0, 0, 0)
                    keybd_event(VK_C, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnd"
                    keybd_event(VK_D, 0, 0, 0)
                    keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btne"
                    keybd_event(VK_E, 0, 0, 0)
                    keybd_event(VK_E, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnf"
                    keybd_event(VK_F, 0, 0, 0)
                    keybd_event(VK_F, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btng"
                    keybd_event(VK_G, 0, 0, 0)
                    keybd_event(VK_G, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnh"
                    keybd_event(VK_H, 0, 0, 0)
                    keybd_event(VK_H, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btni"
                    keybd_event(VK_I, 0, 0, 0)
                    keybd_event(VK_I, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnj"
                    keybd_event(VK_J, 0, 0, 0)
                    keybd_event(VK_J, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnk"
                    keybd_event(VK_K, 0, 0, 0)
                    keybd_event(VK_K, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnl"
                    keybd_event(VK_L, 0, 0, 0)
                    keybd_event(VK_L, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnm"
                    keybd_event(VK_M, 0, 0, 0)
                    keybd_event(VK_M, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnn"
                    keybd_event(VK_N, 0, 0, 0)
                    keybd_event(VK_N, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btno"
                    keybd_event(VK_O, 0, 0, 0)
                    keybd_event(VK_O, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnp"
                    keybd_event(VK_P, 0, 0, 0)
                    keybd_event(VK_P, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnq"
                    keybd_event(VK_Q, 0, 0, 0)
                    keybd_event(VK_Q, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnr"
                    keybd_event(VK_R, 0, 0, 0)
                    keybd_event(VK_R, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btns"
                    keybd_event(VK_S, 0, 0, 0)
                    keybd_event(VK_S, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnt"
                    keybd_event(VK_T, 0, 0, 0)
                    keybd_event(VK_T, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnu"
                    keybd_event(VK_U, 0, 0, 0)
                    keybd_event(VK_U, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnv"
                    keybd_event(VK_V, 0, 0, 0)
                    keybd_event(VK_V, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btny"
                    keybd_event(VK_Y, 0, 0, 0)
                    keybd_event(VK_Y, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnz"
                    keybd_event(VK_Z, 0, 0, 0)
                    keybd_event(VK_Z, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnw"
                    keybd_event(VK_W, 0, 0, 0)
                    keybd_event(VK_W, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnx"
                    keybd_event(VK_X, 0, 0, 0)
                    keybd_event(VK_X, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                    '***************************************************************************************
                Case "btnnokta" '"."
                    keybd_event(VK_OEM_PERIOD, 0, 0, 0)
                    keybd_event(VK_OEM_PERIOD, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btncifttirnak"  '  "
                    'I used this(') mark two times. 
                    keybd_event(VK_SHIFT, 0, 0, 0)
                    keybd_event(VK_2, 0, 0, 0)
                    keybd_event(VK_2, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_2, 0, 0, 0)
                    keybd_event(VK_2, 0, KEYEVENTF_KEYUP, 0)
                    keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btntab"  'tab
                    keybd_event(VK_TAB, 0, 0, 0)
                    keybd_event(VK_TAB, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnlock"    'capslock
                    lockbool = Not lockbool
                    keybd_event(VK_CAPITAL, &H45S, KEYEVENTF_EXTENDEDKEY Or 0, 0)
                    keybd_event(VK_CAPITAL, &H45S, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
                    If lockbool = True Then
                        btnlock.BackColor = Color.White
                    Else
                        btnlock.BackColor = Color.FromArgb(224, 224, 224)
                    End If
                    shiftrelease()
                    leftaltrelease()
                Case "btnsolshift"   'left shift
                    keybd_event(VK_SHIFT, 0, 0, 0)
                    btnsolshift.BackColor = Color.White
                    leftaltrelease()
                Case "btnsolctrl"  'left ctrl
                    ctrlbool = Not ctrlbool
                    If ctrlbool = True Then
                        keybd_event(VK_CONTROL, 0, 0, 0)
                        btnsolctrl.BackColor = Color.White
                    Else
                        keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0)
                        btnsolctrl.BackColor = Color.FromArgb(224, 224, 224)
                    End If
                    shiftrelease()
                    leftaltrelease()
                Case "btnsolwindows"    'left start key
                    keybd_event(VK_STARTKEY, 0, 0, 0)
                    keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnsolalt"   'left alt
                    keybd_event(VK_MENU, 0, 0, 0)
                    btnsolalt.BackColor = Color.White
                    shiftrelease()
                Case "btnspace"   'space
                    keybd_event(VK_SPACE, 0, 0, 0)
                    keybd_event(VK_SPACE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnsagtus"
                    keybd_event(VK_RBUTTON, 0, 0, 0)
                    keybd_event(VK_RBUTTON, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnenter"   'enter
                    keybd_event(VK_RETURN, 0, 0, 0)
                    keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnvirgul"    'comma
                    keybd_event(VK_OEM_COMMA, 0, 0, 0)
                    keybd_event(VK_OEM_COMMA, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnbackspace"   'back space
                    keybd_event(VK_BACK, 0, 0, 0)
                    keybd_event(VK_BACK, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btndel"    'delete
                    keybd_event(VK_DELETE, 0, 0, 0)
                    keybd_event(VK_DELETE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnyukari"   'up
                    keybd_event(VK_UP, 0, 0, 0)
                    keybd_event(VK_UP, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnasagi"   'down
                    keybd_event(VK_DOWN, 0, 0, 0)
                    keybd_event(VK_DOWN, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnsol"  'left
                    keybd_event(VK_LEFT, 0, 0, 0)
                    keybd_event(VK_LEFT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnsag"   'right
                    keybd_event(VK_RIGHT, 0, 0, 0)
                    keybd_event(VK_RIGHT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn0"
                    keybd_event(VK_0, 0, 0, 0)
                    keybd_event(VK_0, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn1"
                    keybd_event(VK_1, 0, 0, 0)
                    keybd_event(VK_1, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn2"
                    keybd_event(VK_2, 0, 0, 0)
                    keybd_event(VK_2, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn3"
                    keybd_event(VK_3, 0, 0, 0)
                    keybd_event(VK_3, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn4"
                    keybd_event(VK_4, 0, 0, 0)
                    keybd_event(VK_4, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn5"
                    keybd_event(VK_5, 0, 0, 0)
                    keybd_event(VK_5, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn6"
                    keybd_event(VK_6, 0, 0, 0)
                    keybd_event(VK_6, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn7"
                    keybd_event(VK_7, 0, 0, 0)
                    keybd_event(VK_7, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn8"
                    keybd_event(VK_8, 0, 0, 0)
                    keybd_event(VK_8, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btn9"
                    keybd_event(VK_9, 0, 0, 0)
                    keybd_event(VK_9, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btncarpi"    '    *
                    keybd_event(VK_MULTIPLY, 0, 0, 0)
                    keybd_event(VK_MULTIPLY, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btneksi"     '    -
                    keybd_event(VK_SUBTRACT, 0, 0, 0)
                    keybd_event(VK_SUBTRACT, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnAdd"     '    +
                    keybd_event(VK_ADD, 0, 0, 0)
                    keybd_event(VK_ADD, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
                Case "btnDivide"     '    +
                    keybd_event(VK_DIVIDE, 0, 0, 0)
                    keybd_event(VK_DIVIDE, 0, KEYEVENTF_KEYUP, 0)
                    shiftrelease()
                    leftaltrelease()
            End Select
            Exit Function
        Catch ex As Exception
            Exit Function
        End Try
    End Function
#End Region

#Region "buttons click"
    Private Sub btnesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btna.Click, btnasagi.Click, btnb.Click, btnbackspace.Click, btnc.Click, btncarpi.Click, btncifttirnak.Click, btnd.Click, btndel.Click, btne.Click, btneksi.Click, btnenter.Click, btnf.Click, btng.Click, btnh.Click, btnj.Click, btnk.Click, btnl.Click, btnlock.Click, btnm.Click, btnn.Click, btnnokta.Click, btno.Click, btnp.Click, btnq.Click, btnr.Click, btns.Click, btnsag.Click, btnsol.Click, btnsolalt.Click, btnsolctrl.Click, btnsolshift.Click, btnspace.Click, btnt.Click, btntab.Click, btnu.Click, btnv.Click, btnw.Click, btnx.Click, btny.Click, btnyukari.Click, btnz.Click, btnvirgul.Click, btni.Click, btnAdd.Click, btnDivide.Click
        Try
            Dim key As Button = CType(sender, Button)
            whichbuttonpushed(key.Name)
            SetActiveWindow(8975651603260375040) 'This Line Very Impportant
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        Finally
            SetActiveWindow(8975651603260375040)
        End Try
    End Sub
#End Region

#Region "shift ,altgr and alt release sub"
    Sub shiftrelease()
        btnsolshift.BackColor = Color.FromArgb(224, 224, 224)
        keybd_event(VK_SHIFT, 0, 2, 0)
    End Sub

    Sub leftaltrelease()
        keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0)
        btnsolalt.BackColor = Color.FromArgb(224, 224, 224)
    End Sub
#End Region

#Region "form1 finalize Overrides"
    Protected Overrides Sub Finalize()
        Try
            'release shift,alt and leftalt
            shiftrelease()
            leftaltrelease()
            keybd_event(VK_CANCEL, 0, 0, 0)
            Timer1.Enabled = False
            Me.Dispose()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "form1 load"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
#End Region

#Region "timer 1 ve 2 tick"
    Dim processes() As Process
    Dim process As New Process
    Dim processstring As String
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim mycoll As New Collection
            processes = process.GetProcesses
            For Each process In processes
                mycoll.Add(process, process.Id.ToString)
                If process.ProcessName = "winamp" Then
                    processstring = process.MainWindowTitle
                    'gets song name from winamp window's title(MainWindowTitle)
                    Exit For
                End If
            Next

            If Trim(mdConfiguration.strResturantName) = vbNullString Then
                Me.Text = "UySys eRestuarant" & Space(55) & DateTime.Now & Space(20) & processstring
            Else
                Me.Text = mdConfiguration.strResturantName & Space(55) & DateTime.Now & Space(20) & processstring
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
#End Region

#Region "form1 top most property"
    Public Sub formtopmost()

    End Sub
#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class
