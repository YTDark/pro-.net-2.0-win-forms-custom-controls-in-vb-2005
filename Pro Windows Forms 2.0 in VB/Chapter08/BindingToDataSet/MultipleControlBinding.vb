Public Class MultipleControlBinding

    ' This is a CurrencyManager, but we don't need to perform a cast because
    ' the BindingManagerBase exposes all the properties we need to use.
    Private storeBinding As BindingManagerBase

    Private Sub MultipleControlBinding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Get the data object.
        Dim dt As DataTable = Program.StoreDB.GetProducts()

        ' Use complex binding.
        cboModelName.DataSource = dt
        cboModelName.DisplayMember = "ModelName"

        ' Use simple binding.
        lblModelNumber.DataBindings.Add("Text", dt, "ModelNumber")
        lblUnitCost.DataBindings.Add("Text", dt, "UnitCost", True, DataSourceUpdateMode.OnValidation, 0, "C")
        lblDescription.DataBindings.Add("Text", dt, "Description")

        ' Keep track of the currency manager.
        storeBinding = Me.BindingContext(dt)

        ' Handle movement from one record to next.
        AddHandler storeBinding.PositionChanged, AddressOf Binding_PositionChanged
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        storeBinding.Position += 1
    End Sub

    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        storeBinding.Position -= 1
    End Sub

    Private Sub Binding_PositionChanged(ByVal sender As Object, _
      ByVal e As System.EventArgs)
        If storeBinding.Position = storeBinding.Count - 1 Then
            cmdNext.Enabled = False
        Else
            cmdNext.Enabled = True
        End If

        If storeBinding.Position = 0 Then
            cmdPrev.Enabled = False
        Else
            cmdPrev.Enabled = True
        End If
    End Sub
End Class