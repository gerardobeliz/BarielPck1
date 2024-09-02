Public Class editarCliente

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBarelPackDataSet)

    End Sub

    Private Sub editarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbBarelPackDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DbBarelPackDataSet.cliente)

    End Sub

  
    Private Sub Buttonvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonvolver.Click
        Me.Close()
    End Sub
End Class