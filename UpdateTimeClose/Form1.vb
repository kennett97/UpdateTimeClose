Public Class frmUpdateTimeClose
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnUpdateTime_Click(sender As Object, e As EventArgs) Handles btnUpdateTime.Click
        lblCurrentTime.Text = TimeOfDay
    End Sub

    Private Sub frmUpdateTimeClose_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblCurrentTime.Text = TimeOfDay
    End Sub
End Class
