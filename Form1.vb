Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text += "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text += "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text += "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text += "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text += "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text += "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text += "0"
    End Sub

    Private Sub ButtonDot_Click(sender As Object, e As EventArgs) Handles ButtonDot.Click
        TextBox1.Text += "."
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        ' 计算表达式
        Try
            Dim ret = New DataTable().Compute(TextBox1.Text, Nothing)
            TextBox1.Text = ret
        Catch ex As Exception
            Console.WriteLine("发生错误" & ex.Message)
            MessageBox.Show("输入的表达式有误", "出错了")
        End Try
    End Sub

    Private Sub ButtonSub_Click(sender As Object, e As EventArgs) Handles ButtonSub.Click
        TextBox1.Text += "-"
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        TextBox1.Text += "/"
    End Sub

    Private Sub ButtonMul_Click(sender As Object, e As EventArgs) Handles ButtonMul.Click
        TextBox1.Text += "*"
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        TextBox1.Text += "+"
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ' 清空
        TextBox1.Text = ""
    End Sub


    Private Sub ButtonLeftPar_Click(sender As Object, e As EventArgs) Handles ButtonLeftPar.Click
        TextBox1.Text += "("
    End Sub

    Private Sub ButtonRightPar_Click(sender As Object, e As EventArgs) Handles ButtonRightPar.Click
        TextBox1.Text += ")"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 设置禁止窗口最大化
        Me.MaximizeBox = False
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        '回退一个字符
        Try
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        Catch ex As Exception
            Console.WriteLine("发生错误" & ex.Message)
            TextBox1.Text = ""
        End Try
    End Sub
End Class
