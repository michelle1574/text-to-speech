Public Class Form1
    Dim SAPI
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SAPI = CreateObject("SAPI.spvoice")
        If CheckBox1.Checked = False Then
            SAPI.Speak(TextBox1.Text)
        Else
            Do
                SAPI.Speak(TextBox1.Text)
            Loop
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If
    End Sub
End Class
