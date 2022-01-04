Imports modEntities

Public Class FrmPrueba2
    Dim cls As New ClsEstilo

    Private Sub FrmPrueba2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = ClsEnumerados.Instancia.lst_iva
        DataGridView2.DataSource = ClsEnumerados.Instancia.lst_iva
        If cls.lstEstiloControl.Count = 0 Then cls.lstEstiloControl = ClsEnumerados.Instancia.lst_estilo_control
        If cls.lstEstiloPropiedad.Count = 0 Then cls.lstEstiloPropiedad = ClsEnumerados.Instancia.lst_estilo_propiedad
        cls.EstiloAControl(TabControl1)
        cls.EstiloAControl(GroupBox2)
        cls.EstiloAControl(DataGridView2)
    End Sub
End Class