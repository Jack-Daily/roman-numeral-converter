Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRange.Clear()
        lblEquivalentNumeral.Text = String.Empty


    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decUserInput As Integer
        '  Dim intNum As Integer

        Try
            'Convert number to roman numeral
            decUserInput = CDec(txtRange.Text)

            'Determine Roman numeral
            Select Case decUserInput
                Case Is = 1
                    lblEquivalentNumeral.Text = "I"

                Case Is = 2
                    lblEquivalentNumeral.Text = "II"

                Case Is = 3
                    lblEquivalentNumeral.Text = "III"

                Case Is = 4
                    lblEquivalentNumeral.Text = "IV"

                Case Is = 5
                    lblEquivalentNumeral.Text = "V"

                Case Is = 6
                    lblEquivalentNumeral.Text = "VI"

                Case Is = 7
                    lblEquivalentNumeral.Text = "VII"

                Case Is = 8
                    lblEquivalentNumeral.Text = "VIII"

                Case Is = 9
                    lblEquivalentNumeral.Text = "IX"

                Case Is = 10
                    lblEquivalentNumeral.Text = "X"



            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class
