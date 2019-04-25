'Author: Ravi SHah
'Date: 12/15/2018

Public Class FormWelcome
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As Integer = MessageBox.Show("Do you want to quit?", "Quit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If


    End Sub

    Private Sub btnOrderNow_Click(sender As Object, e As EventArgs) Handles btnOrderNow.Click
        'FormMenu.Show()
        FormRegisteration.Show()
        Me.Hide()
    End Sub
End Class
