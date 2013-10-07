Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
     
        Dim a As Double
        Dim b As Double
        Dim z As Double

        a = CDbl(txtSideOne.Text)
        b = CDbl(txtSideTwo.Text)
        z = hypotenuse(a, b)

        txtHyp.Text = CStr(z)

    End Sub

    Function hypotenuse(ByVal a As Double, b As Double) As Double
        Dim c As Double
        c = Math.Sqrt(a ^ 2 + b ^ 2)

        Return c
    End Function

End Class
