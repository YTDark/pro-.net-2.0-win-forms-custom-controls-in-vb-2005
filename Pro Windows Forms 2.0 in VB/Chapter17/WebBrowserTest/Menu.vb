Public Class Menu

    Private Sub button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click, button5.Click, button4.Click, button3.Click, button2.Click, button1.Click
        Dim ctrl As Control = CType(sender, Control)
        Dim Asm As System.Reflection.Assembly
        Asm = System.Reflection.Assembly.GetAssembly(GetType(Menu))
        Dim frm As Form = CType( _
          Asm.CreateInstance("WebBrowserTest." & ctrl.Text), Form)
        frm.ShowDialog()
    End Sub

End Class
