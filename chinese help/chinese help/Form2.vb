Public Class Form2

    Dim ch1 As 
    Dim ch2 As VariantType
    Dim ch3 As VariantType
    Dim ch4 As VariantType


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ch1 =
        Label1.Text = "Hello"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        If Label1.Text = "Hello" And TextBox1.Text = "nihao" Then
            Label1.ForeColor = Color.Green
        Else : Label1.ForeColor = Color.Red
        End If




        If Label1.Text = "How Are You?" And TextBox1.Text = "nihao ma?" Then
            Label1.ForeColor = Color.Green
        Else : Label1.ForeColor = Color.Red
        End If





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label1.ForeColor = Color.Black

        If Label1.Text = "Hello" Then
            Label1.Text = "How Are You?" and 
        ElseIf Label1.Text = "How Are You?" Then
            Label1.Text = "Good"
        ElseIf Label1.Text = "Good" Then
            Label1.Text = "Bad"
        End If
    End Sub
End Class