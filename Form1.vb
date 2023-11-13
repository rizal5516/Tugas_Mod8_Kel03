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

        TextBox2.Text = objConv.cToReamur(c)


    End Sub



    Private Sub button2_Click(sender As Object, e As EventArgs) Handles CtoF.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim c As Double

        c = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.cToF(c)


    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles CtoK.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim c As Double

        c = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.cToKelvin(c)


    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles RtoC.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim reamur As Double

        reamur = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.reamurToC(reamur)


    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles RtoF.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim reamur As Double

        reamur = CDbl(TextBox1.Text)

        TextBox2.Text = objConv.reamurToF(reamur)


    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles RtoK.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim reamur As Double
        reamur = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.reamurToKelvin(reamur)

    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles FtoC.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim f As Double
        f = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.fToC(f)

    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles FtoR.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim f As Double
        f = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.fToReamur(f)

    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles FtoK.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim f As Double
        f = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.fToKelvin(f)

    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles KtoC.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim kelvin As Double
        kelvin = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.kelvinToC(kelvin)

    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles KtoR.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim kelvin As Double
        kelvin = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.kelvinToC(kelvin)

    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles KtoF.Click

        Dim objConv As New Mod8_Tugas_GUI.TempConvComp

        Dim kelvin As Double
        kelvin = CDbl(TextBox1.Text)
        TextBox2.Text = objConv.kelvinToF(kelvin)

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class