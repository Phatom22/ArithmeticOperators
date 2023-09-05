Public Class Form1
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim FirstNum As Integer
        Dim SecondNum As Integer
        Dim Answer As Double

        FirstNum = txtFirstNumber.Text
        SecondNum = txtSecondNumber.Text
        'for addition
        Answer = FirstNum + SecondNum
        MsgBox(FirstNum & " + " & SecondNum & " = " & Answer)

        'for subtraction
        'Answer = FirstNum - SecondNum
        MsgBox(FirstNum & " - " & SecondNum & " = " & Answer)

        'for multiplication
        Answer = FirstNum * SecondNum
        MsgBox(FirstNum & " * " & SecondNum & " = " & Answer)


        'for division
        Answer = FirstNum / SecondNum
        MsgBox(FirstNum & " / " & SecondNum & " = " & Answer)

        'to the power
        Answer = FirstNum ^ SecondNum
        MsgBox(FirstNum & " ^ " & SecondNum & " = " & Answer)


    End Sub
End Class
