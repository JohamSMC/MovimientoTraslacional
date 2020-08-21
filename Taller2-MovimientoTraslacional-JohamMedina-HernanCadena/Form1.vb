Imports System.IO

Public Class Form1
    'Note: The next path should be a path of octave cli
    'C:\Octave\Octave-5.2.0\mingw64\bin\octave-cli-5.2.0.exe
    Dim path As String
    Dim pInfo As New ProcessStartInfo
    Dim p As Process

    Dim k1, k2, k3 As Double
    Dim b1, b2, b3, b4 As Double
    Dim m1, m2 As Double

    Dim x1(10), x2(10) As Double
    Dim t1(10), t2(10) As Double
    Dim posx1, posx2 As Integer

    Dim posr1, posr2, posr3 As Integer
    Dim posa3, posa4 As Integer
    Dim tami1, tami2, tami3, tami4, tami5 As Integer

    Dim can_elementos, ganancia As Integer
    Dim aux As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        path = "C:\Octave\Octave-5.2.0\mingw64\bin\octave-cli-5.2.0.exe"
        pInfo.FileName = path
        pInfo.WindowStyle = ProcessWindowStyle.Minimized
        p = Process.Start(pInfo)
        posx1 = PB_m2.Location.X
        posx2 = PB_m1.Location.X

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_start.Click

        Dim pathFile As String = Application.StartupPath
        k1 = TB_k1.Text
        k2 = TB_k2.Text
        k3 = TB_k3.Text
        b1 = TB_b1.Text
        b2 = TB_b2.Text
        b3 = TB_b3.Text
        b4 = TB_b4.Text
        m1 = TB_m1.Text
        m2 = TB_m2.Text
        can_elementos = TB_Cantidad.Text
        ganancia = TB_Ganancia.Text

        sendOctave("clc")
        sendOctave("clear")
        sendOctave("pkg load control")
        sendOctave("s=tf{(}'s'{)};")

        sendOctave("k1=" & k1 & ";")
        sendOctave("k2=" & k2 & ";")
        sendOctave("k3=" & k3 & ";")

        sendOctave("b1=" & b1 & ";")
        sendOctave("b2=" & b2 & ";")
        sendOctave("b3=" & b3 & ";")
        sendOctave("b4=" & b4 & ";")

        sendOctave("m1=" & m1 & ";")
        sendOctave("m2=" & m2 & ";")

        sendOctave("a1=m1*s*s{+}b1*s{+}b2*s{+}b3*s{+}k1{+}k2;")
        sendOctave("a2=b3*s{+}k1{+}k2;")
        sendOctave("a3=m2*s*s{+}b3*s{+}b4*s{+}k1{+}k2{+}k3;")

        sendOctave("G1=a3/{(}a1*a3-a2*a2{)};")
        sendOctave("G2=a2/{(}a1*a3-a2*a2{)};")

        sendOctave("[x2,t2]=impulse{(}G1{)};")
        sendOctave("[x1,t1]=impulse{(}G2{)};")

        sendOctave("c=length{(}t2{)};")
        sendOctave("tiempo=t2{(}c{)}*1.1;")
        sendOctave("[x2,t2]=impulse{(}G1,tiempo,tiempo/" & can_elementos & "{)};")
        sendOctave("dlmwrite{(}'" + pathFile + "\t2.txt',t2,'\n'{)};")
        sendOctave("dlmwrite{(}'" + pathFile + "\x2.txt',x2,'\n'{)};")

        sendOctave("c=length{(}t1{)};")
        sendOctave("tiempo=t1{(}c{)}*1.1;")
        sendOctave("[x1,t1]=impulse{(}G2,tiempo,tiempo/" & can_elementos & "{)};")
        sendOctave("dlmwrite{(}'" + pathFile + "\t1.txt',t1,'\n'{)};")
        sendOctave("dlmwrite{(}'" + pathFile + "\x1.txt',x1,'\n'{)};")
        sendOctave("exit")
        loadData()
    End Sub

    Sub loadData()
        Dim t1_file, x1_file As StreamReader
        Dim t2_file, x2_file As StreamReader
        ReDim x1(can_elementos)
        ReDim x2(can_elementos)
        ReDim t1(can_elementos)
        ReDim t2(can_elementos)
        '----------------------------------------------------------------
        x1_file = New StreamReader(Application.StartupPath & "\x1.txt")
        For x1i = 0 To can_elementos - 1
            x1(x1i) = Val(x1_file.ReadLine) * ganancia
        Next
        x1_file.Close()
        '----------------------------------------------------------------
        t1_file = New StreamReader(Application.StartupPath & "\t1.txt")
        For t1i = 0 To can_elementos - 1
            t1(t1i) = Val(t1_file.ReadLine)
        Next
        t1_file.Close()
        '-------------------------------------------------
        x2_file = New StreamReader(Application.StartupPath & "\x2.txt")
        For x2i = 0 To can_elementos - 1
            x2(x2i) = Val(x2_file.ReadLine) * ganancia
        Next
        x2_file.Close()
        '----------------------------------------------------------------
        t2_file = New StreamReader(Application.StartupPath & "\x2.txt")
        For t2i = 0 To can_elementos - 1
            t2(t2i) = Val(t2_file.ReadLine)
        Next
        t2_file.Close()
        '-------------------------------------------------
    End Sub
    Sub sendOctave(cadena As String)
        AppActivate(path)
        SendKeys.SendWait(cadena & Chr(13))
        System.Threading.Thread.Sleep(50)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        PB_m1.Location = New Point(posx2 + x2(aux), PB_m1.Location.Y)
        PB_m2.Location = New Point(posx1 + x1(aux), PB_m2.Location.Y)
        aux += 1
    End Sub

End Class
