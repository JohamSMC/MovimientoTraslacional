Public Class Form1
    Dim k1, k2, k3, b1, b2, b3, b4 As Double
    Dim m1, m2 As Double
    Dim pInfo As New ProcessStartInfo
    Dim p As Process
    Dim vectorx1(10) As Double
    Dim vectorx2(10) As Double
    Dim vectort(10) As Double
    Dim posx1, posx2 As Integer
    Dim posr1, posr2, posr3 As Integer
    Dim posa1, posa2, posa3, posa4 As Integer
    Dim can_elementos, ganancia As Integer
    Dim tami1, tami2, tami3, tami4, tami5 As Integer
    Dim aux As Integer = 0
    Dim ruta As String = "C:\Octave\Octave-5.2.0\mingw64\bin\octave-cli-5.2.0.exe"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_start.Click
        k1 = TB_k1.Text
        k2 = TB_k2.Text
        k3 = TB_k3.Text
        b1 = TB_b1.Text
        b2 = TB_b2.Text
        b3 = TB_b3.Text
        b4 = TB_b4.Text
        m1 = TB_m1.Text
        m2 = TB_m2.Text
        'can_elementos = TCantElem.Text
        'ganancia = TGanacia.Text

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

        sendOctave("subplot{(}4,1,1{)}")
        sendOctave("step{(}G1{)}")
        sendOctave("subplot{(}4,1,2{)}")
        sendOctave("step{(}G2{)}")
        sendOctave("subplot{(}4,1,3{)}")
        sendOctave("impulse{(}G1{)}")
        sendOctave("subplot{(}4,1,4{)}")
        sendOctave("impulse{(}G2{)}")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pInfo.FileName = ruta
        pInfo.WindowStyle = ProcessWindowStyle.Minimized
        p = Process.Start(pInfo)

    End Sub

    Sub sendOctave(cadena As String)
        AppActivate(ruta)
        SendKeys.SendWait(cadena & Chr(13))
        System.Threading.Thread.Sleep(50)
    End Sub

End Class
