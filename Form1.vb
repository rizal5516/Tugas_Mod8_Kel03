Imports Mod8_Tugas_GUI
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CtoR.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim c As Double

        c = CDbl(TextBox1.Text)

        TextBox1.Text = objConv.cToReamur(c)
        Label1.Text = "Ini Celcius Ke Reamur"

    End Sub



    Private Sub button2_Click(sender As Object, e As EventArgs) Handles CtoF.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim c As Double

        c = CDbl(TextBox1.Text)

        TextBox1.Text = objConv.cToF(c)
        Label1.Text = "Ini Celcius Ke Kelvin"

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles CtoK.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim c As Double

        c = CDbl(TextBox1.Text)

        TextBox1.Text = objConv.cToKelvin(c)
        Label1.Text = "Celcius"

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles RtoC.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim reamur As Double

        reamur = CDbl(TextBox1.Text)

        TextBox1.Text = objConv.reamurToC(reamur)
        Label1.Text = "Ini Reamur Ke Celcius"

    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles RtoF.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim reamur As Double

        reamur = CDbl(TextBox1.Text)

        TextBox1.Text = objConv.reamurToF(reamur)
        Label1.Text = "Ini Reamur Ke Fahreinheit"

    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles RtoK.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim reamur As Double
        reamur = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.reamurToKelvin(reamur)
        Label1.Text = "Ini Reamur Ke Kelvin"
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles FtoC.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim f As Double
        f = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.fToC(f)
        Label1.Text = "Ini Fahreinheit Ke Celcius"
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles FtoR.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim f As Double
        f = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.fToReamur(f)
        Label1.Text = "Ini Fahreinheit Ke Reamur"
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles FtoK.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim f As Double
        f = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.fToKelvin(f)
        Label1.Text = "Ini Fahreinheit Ke Kelvin"
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles KtoC.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim kelvin As Double
        kelvin = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.kelvinToC(kelvin)
        Label1.Text = "Ini Kelvin Ke Celcius"
    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles KtoR.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim kelvin As Double
        kelvin = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.kelvinToC(kelvin)
        Label1.Text = "Ini Kelvin Ke Reamur"
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles KtoF.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim kelvin As Double
        kelvin = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.kelvinToF(kelvin)
        Label1.Text = "Ini Kelvin Ke Fahrenheit"
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class