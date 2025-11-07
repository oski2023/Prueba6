Public Class Form1
    Private Sub Copia_de_Tabla1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Copia_de_Tabla1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Copia_de_Tabla1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PruebaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebaDataSet.Copia_de_Tabla1' Puede moverla o quitarla según sea necesario.
        Me.Copia_de_Tabla1TableAdapter.Fill(Me.PruebaDataSet.Copia_de_Tabla1)

    End Sub
End Class
