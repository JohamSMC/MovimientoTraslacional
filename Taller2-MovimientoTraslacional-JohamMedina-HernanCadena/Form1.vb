Imports System.IO

Public Class Form1

    Dim path As String
    Dim pInfo As New ProcessStartInfo
    Dim p As Process
    Dim k1, k2, k3 As Double
    Dim b1, b2, b3, b4 As Double
    Dim m1, m2 As Double
    Dim x1(10), x2(10) As Double
    Dim t1(10), t2(10) As Double
    Dim X1max, X1t_max As Double
    Dim X2max, X2t_max As Double
    Dim posx1, posx2 As Integer
    Dim poslm1, poslm2 As Integer
    Dim postm1, postm2 As Integer
    Dim posI_k1, posI_k2, posI_k3 As Integer
    Dim pos_b1, pos_b2, posI_b3, posI_b4 As Integer
    Dim can_elementos, ganancia As Integer
    Dim aux As Integer = 0
    Dim posI_label_b1, posI_label_b2, posI_label_b3, posI_label_b4 As Integer
    Dim posI_label_k1, posI_label_k2, posI_label_k3 As Integer
    Dim iniWidth_k1, iniWidth_k2, iniWidth_k3 As Integer
    Dim iniWidth_b1, iniWidth_b2, iniWidth_b3, iniWidth_b4 As Integer

    Private Sub TB_m2_TextChanged(sender As Object, e As EventArgs) Handles TB_m2.TextChanged
        If IsNumeric(TB_m2.Text) = False Or Val(TB_m2.Text) < 0 Then
            TB_m2.Text = 10
        End If
    End Sub
    Private Sub TB_m1_TextChanged(sender As Object, e As EventArgs) Handles TB_m1.TextChanged
        If IsNumeric(TB_m1.Text) = False Or Val(TB_m1.Text) < 0 Then
            TB_m1.Text = 10
        End If
    End Sub
    Private Sub TB_b1_TextChanged(sender As Object, e As EventArgs) Handles TB_b1.TextChanged
        If IsNumeric(TB_b1.Text) = False Or Val(TB_b1.Text) < 0 Then
            TB_b1.Text = 0
        End If
    End Sub

    Private Sub TB_b2_TextChanged(sender As Object, e As EventArgs) Handles TB_b2.TextChanged
        If IsNumeric(TB_b2.Text) = False Or Val(TB_b2.Text) < 0 Then
            TB_b2.Text = 0
        End If
    End Sub

    Private Sub TB_b3_TextChanged(sender As Object, e As EventArgs) Handles TB_b3.TextChanged
        If IsNumeric(TB_b3.Text) = False Or Val(TB_b3.Text) < 0 Then
            TB_b3.Text = 0
        End If
    End Sub

    Private Sub TB_b4_TextChanged(sender As Object, e As EventArgs) Handles TB_b4.TextChanged
        If IsNumeric(TB_b4.Text) = False Or Val(TB_b4.Text) < 0 Then
            TB_b4.Text = 0
        End If
    End Sub

    Private Sub TB_k1_TextChanged(sender As Object, e As EventArgs) Handles TB_k1.TextChanged
        If IsNumeric(TB_k1.Text) = False Or Val(TB_k1.Text) < 0 Then
            TB_k1.Text = 0
        End If
    End Sub

    Private Sub TB_k2_TextChanged(sender As Object, e As EventArgs) Handles TB_k2.TextChanged
        If IsNumeric(TB_k2.Text) = False Or Val(TB_k2.Text) < 0 Then
            TB_k2.Text = 0
        End If
    End Sub

    Private Sub TB_k3_TextChanged(sender As Object, e As EventArgs) Handles TB_k3.TextChanged
        If IsNumeric(TB_k3.Text) = False Or Val(TB_k3.Text) < 0 Then
            TB_k3.Text = 0
        End If
    End Sub

    Private Sub TB_Cantidad_TextChanged(sender As Object, e As EventArgs) Handles TB_Cantidad.TextChanged
        If IsNumeric(TB_Cantidad.Text) = False Or Val(TB_Cantidad.Text) < 0 Then
            TB_Cantidad.Text = 0
        End If
    End Sub

    Private Sub TB_Ganancia_TextChanged(sender As Object, e As EventArgs) Handles TB_Ganancia.TextChanged
        If IsNumeric(TB_Ganancia.Text) = False Or Val(TB_Ganancia.Text) < 0 Then
            TB_Ganancia.Text = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initOctave()
        posx1 = PB_m2.Location.X
        posx2 = PB_m1.Location.X
        poslm1 = label_masa1.Location.X
        poslm2 = label_masa2.Location.X
        postm1 = TB_m1.Location.X
        postm2 = TB_m2.Location.X

        posI_label_b1 = label_B1.Location.X
        posI_label_b2 = label_B2.Location.X
        posI_label_b3 = label_B3.Location.X
        posI_label_b4 = label_B4.Location.X

        posI_label_k1 = label_K1.Location.X
        posI_label_k2 = label_K2.Location.X
        posI_label_k3 = label_K3.Location.X

        pos_b1 = PB_b1.Location.X - 2
        pos_b2 = PB_b2.Location.X - 2

        posI_k1 = PB_m1.Location.X + PB_m2.Width
        posI_b3 = PB_m1.Location.X + PB_m2.Width
        posI_k2 = PB_m1.Location.X + PB_m2.Width

        posI_k3 = PB_m2.Location.X + PB_m2.Width
        posI_b4 = PB_m2.Location.X + PB_m2.Width

        iniWidth_k1 = PB_k1.Width
        iniWidth_k2 = PB_k2.Width
        iniWidth_k3 = PB_k3.Width

        iniWidth_b1 = PB_b1.Width
        iniWidth_b2 = PB_b2.Width
        iniWidth_b3 = PB_b3.Width
        iniWidth_b4 = PB_b4.Width

        paso.Checked = True
        B_restart.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_start.Click
        label_B1.Visible = False
        label_B2.Visible = False
        label_B3.Visible = False
        label_B4.Visible = False
        label_K1.Visible = False
        label_K2.Visible = False
        label_K3.Visible = False
        TB_Cantidad.Enabled = False
        TB_Ganancia.Enabled = False
        TB_b1.Enabled = False
        TB_b2.Enabled = False
        TB_b3.Enabled = False
        TB_b4.Enabled = False
        TB_k1.Enabled = False
        TB_k2.Enabled = False
        TB_k3.Enabled = False
        B_start.Enabled = False
        B_restart.Enabled = False
        paso.Enabled = False
        impulso.Enabled = False
        Cursor = System.Windows.Forms.Cursors.WaitCursor

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

        L_procesar.Text = "Procesando datos..."

        sendOctave("clc")
        sendOctave("clear")
        sendOctave("pkg load control")
        sendOctave("s=tf{(}'s'{)};")

        L_procesar.Text = "Procesando 14%..."

        sendOctave("k1=" & k1 & ";")
        sendOctave("k2=" & k2 & ";")
        sendOctave("k3=" & k3 & ";")

        sendOctave("b1=" & b1 & ";")
        sendOctave("b2=" & b2 & ";")
        sendOctave("b3=" & b3 & ";")
        sendOctave("b4=" & b4 & ";")

        L_procesar.Text = "Procesando 37%..."

        sendOctave("m1=" & m1 & ";")
        sendOctave("m2=" & m2 & ";")

        sendOctave("a1=m1*s*s{+}b1*s{+}b2*s{+}b3*s{+}k1{+}k2;")
        sendOctave("a2=b3*s{+}k1{+}k2;")
        sendOctave("a3=m2*s*s{+}b3*s{+}b4*s{+}k1{+}k2{+}k3;")

        sendOctave("G1=a3/{(}a1*a3-a2*a2{)};")
        sendOctave("G2=a2/{(}a1*a3-a2*a2{)};")

        L_procesar.Text = "Procesando 60%..."

        If paso.Checked = True Then
            sendOctave("[x2,t2]=step{(}G1{)};")
            sendOctave("[x1,t1]=step{(}G2{)};")
        ElseIf impulso.Checked = True Then
            sendOctave("[x2,t2]=impulse{(}G1{)};")
            sendOctave("[x1,t1]=impulse{(}G2{)};")
        End If

        L_procesar.Text = "Procesando 66%..."

        sendOctave("c=length{(}t2{)};")
        sendOctave("tiempo=t2{(}c{)}*1.1;")
        If paso.Checked = True Then
            sendOctave("[x2,t2]=step{(}G1,tiempo,tiempo/" & can_elementos & "{)};")
        ElseIf impulso.Checked = True Then
            sendOctave("[x2,t2]=impulse{(}G1,tiempo,tiempo/" & can_elementos & "{)};")
        End If
        sendOctave("dlmwrite{(}'" + pathFile + "\t2.txt',t2,'\n'{)};")
        sendOctave("dlmwrite{(}'" + pathFile + "\x2.txt',x2,'\n'{)};")

        L_procesar.Text = "Procesando 83%..."

        sendOctave("c=length{(}t1{)};")
        sendOctave("tiempo=t1{(}c{)}*1.1;")
        If paso.Checked = True Then
            sendOctave("[x1,t1]=step{(}G2,tiempo,tiempo/" & can_elementos & "{)};")
            Form2.L_title.Text += " G1 y G2 simulación con la respuesta al paso"
        ElseIf impulso.Checked = True Then
            sendOctave("[x1,t1]=impulse{(}G2,tiempo,tiempo/" & can_elementos & "{)};")
            Form2.L_title.Text += " G1 y G2 simulación con respuesta al impulso"
        End If
        sendOctave("dlmwrite{(}'" + pathFile + "\t1.txt',t1,'\n'{)};")
        sendOctave("dlmwrite{(}'" + pathFile + "\x1.txt',x1,'\n'{)};")

        L_procesar.Text = "Procesando 99%..."

        sendOctave("exit")

        L_procesar.Text = "Procesado 100%"

        loadData()
        Timer1.Enabled = True

    End Sub
    Sub initOctave()
        pInfo.FileName = path
        pInfo.WindowStyle = ProcessWindowStyle.Minimized
        p = Process.Start(pInfo)
        System.Threading.Thread.Sleep(3000)
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
        '----------------------------------------------------------------
        x2_file = New StreamReader(Application.StartupPath & "\x2.txt")
        For x2i = 0 To can_elementos - 1
            x2(x2i) = Val(x2_file.ReadLine) * ganancia
        Next
        x2_file.Close()
        '----------------------------------------------------------------
        t2_file = New StreamReader(Application.StartupPath & "\t2.txt")
        For t2i = 0 To can_elementos - 1
            t2(t2i) = Val(t2_file.ReadLine)
        Next
        t2_file.Close()
        '----------------------------------------------------------------
        X1max = x1.Max
        X2max = x2.Max

    End Sub
    Sub sendOctave(cadena As String)
        AppActivate(path)
        SendKeys.SendWait(cadena & Chr(13))
        System.Threading.Thread.Sleep(50)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '-------------------------------------------------------------------------
        PB_m1.Location = New Point(posx2 + x2(aux), PB_m1.Location.Y)
        PB_m2.Location = New Point(posx1 + x1(aux), PB_m2.Location.Y)
        label_masa1.Location = New Point(poslm1 + x2(aux), label_masa1.Location.Y)
        label_masa2.Location = New Point(poslm2 + x1(aux), label_masa2.Location.Y)
        TB_m1.Location = New Point(postm1 + x2(aux), TB_m1.Location.Y)
        TB_m2.Location = New Point(postm2 + x1(aux), TB_m2.Location.Y)
        '-------------------------------------------------------------------------
        PB_k1.Location = New Point(posI_k1 + x2(aux) - 1, PB_k1.Location.Y)
        PB_b3.Location = New Point(posI_b3 + x2(aux) - 1, PB_b3.Location.Y)
        PB_k2.Location = New Point(posI_k2 + x2(aux) - 1, PB_k2.Location.Y)
        '-------------------------------------------------------------------------
        PB_k3.Location = New Point(posI_k3 + x1(aux) - 1, PB_k3.Location.Y)
        PB_b4.Location = New Point(posI_b4 + x1(aux) - 1, PB_b4.Location.Y)
        '-------------------------------------------------------------------------
        PB_b1.Width = PB_m1.Location.X - pos_b1 + 3
        PB_b2.Width = PB_m1.Location.X - pos_b2 + 3
        '-------------------------------------------------------------------------
        PB_k1.Width = PB_m2.Location.X - (PB_m1.Location.X + PB_m2.Width) + 3
        PB_b3.Width = PB_m2.Location.X - (PB_m1.Location.X + PB_m2.Width) + 3
        PB_k2.Width = PB_m2.Location.X - (PB_m1.Location.X + PB_m2.Width) + 3
        '-------------------------------------------------------------------------
        PB_k3.Width = PB_limDE.Location.X - (PB_m2.Location.X + PB_m2.Width) + 3
        PB_b4.Width = PB_limDE.Location.X - (PB_m2.Location.X + PB_m2.Width) + 3
        '-------------------------------------------------------------------------
        Dim pointG1 As Int32 = Form2.Chart_G1.Series(0).Points.AddXY(t2(aux), x2(aux))
        Dim pointG2 As Int32 = Form2.Chart_G2.Series(0).Points.AddXY(t1(aux), x1(aux))
        '-------------------------------------------------------------------------
        If X2max = x2(aux) Then
            X2t_max = t2(aux)
            Form2.Chart_G1.Series(0).Points.Item(pointG1).Label = "T=" + Str(Math.Round(X2t_max, 1)) + "--X=" + Str(Math.Round(X2max, 1))
        End If

        If X1max = x1(aux) Then
            X1t_max = t1(aux)
            Form2.Chart_G2.Series(0).Points.Item(pointG2).Label = "T=" + Str(Math.Round(X1t_max, 1)) + "--X=" + Str(Math.Round(X1max, 1))
            'Form2.Chart_G2.ChartAreas(0).AxisX
        End If

        aux += 1
        If aux = (can_elementos - 1) Then
            Timer1.Enabled = False
            L_procesar.Text = "Graficas y Simulacion terminadas"
            Form2.Chart_G1.Series(0).Points.Item(pointG1).Label = "T=" + Str(Math.Round(t2(aux), 1)) + "--X=" + Str(Math.Round(x2(aux), 1))
            Form2.Chart_G2.Series(0).Points.Item(pointG2).Label = "T=" + Str(Math.Round(t1(aux), 1)) + "--X=" + Str(Math.Round(x1(aux), 1))
            Form2.Show()

            aux = 0
            B_start.Cursor = System.Windows.Forms.Cursors.Default
            Cursor = System.Windows.Forms.Cursors.Default
            B_restart.Enabled = True
        End If
    End Sub

    Private Sub B_restart_Click(sender As Object, e As EventArgs) Handles B_restart.Click
        Cursor = System.Windows.Forms.Cursors.Default
        B_restart.Enabled = False
        paso.Enabled = True
        impulso.Enabled = True
        restartSimulation()
        initOctave()
        TB_k1.Text = 10
        TB_k2.Text = 10
        TB_k3.Text = 10
        TB_b1.Text = 1
        TB_b2.Text = 1
        TB_b3.Text = 1
        TB_b4.Text = 1
        TB_m1.Text = 10
        TB_m2.Text = 10
        TB_Cantidad.Text = 100
        TB_Ganancia.Text = 1000
        label_B1.Visible = True
        label_B2.Visible = True
        label_B3.Visible = True
        label_B4.Visible = True
        label_K1.Visible = True
        label_K2.Visible = True
        label_K3.Visible = True
        TB_b1.Enabled = True
        TB_b2.Enabled = True
        TB_b3.Enabled = True
        TB_b4.Enabled = True
        TB_k1.Enabled = True
        TB_k2.Enabled = True
        TB_k3.Enabled = True
        TB_Cantidad.Enabled = True
        TB_Ganancia.Enabled = True
        B_start.Enabled = True
    End Sub

    Sub setPath(pathin As String)
        path = pathin
    End Sub

    Sub restartSimulation()
        PB_m2.Location = New Point(posx1, PB_m2.Location.Y)
        PB_m1.Location = New Point(posx2, PB_m2.Location.Y)
        label_masa1.Location = New Point(poslm1, label_masa1.Location.Y)
        label_masa2.Location = New Point(poslm2, label_masa2.Location.Y)
        TB_m1.Location = New Point(postm1, TB_m1.Location.Y)
        TB_m2.Location = New Point(postm2, TB_m2.Location.Y)

        label_B1.Location = New Point(posI_label_b1, label_B1.Location.Y)
        label_B2.Location = New Point(posI_label_b2, label_B2.Location.Y)
        label_B3.Location = New Point(posI_label_b3, label_B3.Location.Y)
        label_B4.Location = New Point(posI_label_b4, label_B4.Location.Y)

        label_K1.Location = New Point(posI_label_k1, label_K1.Location.Y)
        label_K2.Location = New Point(posI_label_k2, label_K2.Location.Y)
        label_K3.Location = New Point(posI_label_k3, label_K3.Location.Y)

        PB_b1.Location = New Point(pos_b1, PB_b1.Location.Y)
        PB_b2.Location = New Point(pos_b2, PB_b2.Location.Y)

        PB_k1.Location = New Point(posI_k1, PB_k1.Location.Y)
        PB_b3.Location = New Point(posI_b3, PB_b3.Location.Y)
        PB_k2.Location = New Point(posI_k2, PB_k2.Location.Y)

        PB_k3.Location = New Point(posI_k3, PB_k3.Location.Y)
        PB_b4.Location = New Point(posI_b4, PB_b4.Location.Y)

        PB_k1.Width = iniWidth_k1
        PB_k2.Width = iniWidth_k2
        PB_k3.Width = iniWidth_k3

        PB_b1.Width = iniWidth_b1
        PB_b2.Width = iniWidth_b2
        PB_b3.Width = iniWidth_b3
        PB_b4.Width = iniWidth_b4
    End Sub

End Class