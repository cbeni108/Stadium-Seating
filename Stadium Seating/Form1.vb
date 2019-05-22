Public Class Form1
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form'
        Me.Close()
    End Sub

    Private Sub BtnCalculateRv_Click(sender As Object, e As EventArgs) Handles btnCalculateRv.Click
        'Declare variables for calculation'
        Dim decclassA As Decimal
        Dim decclassB As Decimal
        Dim decclassC As Decimal
        Dim decTotalRev As Decimal

        txtClassARG.Enabled = True
        txtClassBRG.Enabled = True
        txtClassCRG.Enabled = True
        txtTotalRev.Enabled = True

        Try
            'Calculate and display the Revenue Generated'
            decclassA = CDec(txtClassATS.Text) * 15
            txtClassARG.Text = decclassA.ToString("c")
            decclassB = CDec(txtClassBTS.Text) * 12
            txtClassBRG.Text = decclassB.ToString("c")
            decclassC = CDec(txtClassCTS.Text) * 9
            txtClassCRG.Text = decclassC.ToString("c")
            decTotalRev = CDec(txtClassARG.Text) + CDec(txtClassBRG.Text) + CDec(txtClassCRG.Text)

            txtTotalRev.Text = decTotalRev.ToString("c")




        Catch ex As Exception
            'Error Message'
            MessageBox.Show("All input must be valid numeric value")
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the controls'
        txtClassATS.Clear()
        txtClassBTS.Clear()
        txtClassCTS.Clear()
        txtClassARG.Clear()
        txtClassBRG.Clear()
        txtClassCRG.Clear()
        txtTotalRev.Clear()
        txtClassATS.Focus()
    End Sub
End Class
