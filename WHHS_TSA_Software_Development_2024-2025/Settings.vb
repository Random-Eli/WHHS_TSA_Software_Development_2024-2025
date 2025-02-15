Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Returns API key for Weather API
    Public Function getAPIKey()
        Return txtAPIKey.Text
    End Function
End Class
