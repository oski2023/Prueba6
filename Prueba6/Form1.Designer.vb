<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PruebaDataSet = New Prueba6.pruebaDataSet()
        Me.Copia_de_Tabla1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Copia_de_Tabla1TableAdapter = New Prueba6.pruebaDataSetTableAdapters.Copia_de_Tabla1TableAdapter()
        Me.TableAdapterManager = New Prueba6.pruebaDataSetTableAdapters.TableAdapterManager()
        Me.Copia_de_Tabla1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Copia_de_Tabla1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Copia_de_Tabla1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PruebaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copia_de_Tabla1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copia_de_Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Copia_de_Tabla1BindingNavigator.SuspendLayout()
        CType(Me.Copia_de_Tabla1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PruebaDataSet
        '
        Me.PruebaDataSet.DataSetName = "pruebaDataSet"
        Me.PruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Copia_de_Tabla1BindingSource
        '
        Me.Copia_de_Tabla1BindingSource.DataMember = "Copia de Tabla1"
        Me.Copia_de_Tabla1BindingSource.DataSource = Me.PruebaDataSet
        '
        'Copia_de_Tabla1TableAdapter
        '
        Me.Copia_de_Tabla1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Copia_de_Tabla1TableAdapter = Me.Copia_de_Tabla1TableAdapter
        Me.TableAdapterManager.Tabla1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Prueba6.pruebaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Copia_de_Tabla1BindingNavigator
        '
        Me.Copia_de_Tabla1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Copia_de_Tabla1BindingNavigator.BindingSource = Me.Copia_de_Tabla1BindingSource
        Me.Copia_de_Tabla1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Copia_de_Tabla1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Copia_de_Tabla1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Copia_de_Tabla1BindingNavigatorSaveItem})
        Me.Copia_de_Tabla1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Copia_de_Tabla1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Copia_de_Tabla1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Copia_de_Tabla1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Copia_de_Tabla1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Copia_de_Tabla1BindingNavigator.Name = "Copia_de_Tabla1BindingNavigator"
        Me.Copia_de_Tabla1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Copia_de_Tabla1BindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Copia_de_Tabla1BindingNavigator.TabIndex = 0
        Me.Copia_de_Tabla1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Copia_de_Tabla1BindingNavigatorSaveItem
        '
        Me.Copia_de_Tabla1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Copia_de_Tabla1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Copia_de_Tabla1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Copia_de_Tabla1BindingNavigatorSaveItem.Name = "Copia_de_Tabla1BindingNavigatorSaveItem"
        Me.Copia_de_Tabla1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Copia_de_Tabla1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Copia_de_Tabla1DataGridView
        '
        Me.Copia_de_Tabla1DataGridView.AutoGenerateColumns = False
        Me.Copia_de_Tabla1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Copia_de_Tabla1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Copia_de_Tabla1DataGridView.DataSource = Me.Copia_de_Tabla1BindingSource
        Me.Copia_de_Tabla1DataGridView.Location = New System.Drawing.Point(220, 110)
        Me.Copia_de_Tabla1DataGridView.Name = "Copia_de_Tabla1DataGridView"
        Me.Copia_de_Tabla1DataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Copia_de_Tabla1DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Campo1"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Campo1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Campo2"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Campo2"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Campo3"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Campo3"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Copia_de_Tabla1DataGridView)
        Me.Controls.Add(Me.Copia_de_Tabla1BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PruebaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copia_de_Tabla1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copia_de_Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Copia_de_Tabla1BindingNavigator.ResumeLayout(False)
        Me.Copia_de_Tabla1BindingNavigator.PerformLayout()
        CType(Me.Copia_de_Tabla1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PruebaDataSet As pruebaDataSet
    Friend WithEvents Copia_de_Tabla1BindingSource As BindingSource
    Friend WithEvents Copia_de_Tabla1TableAdapter As pruebaDataSetTableAdapters.Copia_de_Tabla1TableAdapter
    Friend WithEvents TableAdapterManager As pruebaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Copia_de_Tabla1BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Copia_de_Tabla1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Copia_de_Tabla1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
