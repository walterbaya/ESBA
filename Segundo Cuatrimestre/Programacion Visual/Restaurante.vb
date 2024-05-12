Public Class Form1
    'Tengo un restaurante
    '4 tipos de menú
    'Cada menú $7000
    'Se puede elegir un sólo tipo de menú
    'Si paga con tarjeta + 10%
    'Si paga en efectivo - 10%
    'Necesito:
    'IVA 21% 
    'Total sin descuento y sin recargo
    'Total a pagar + 21%
    'significa que solo hay  4 checkbox 
    'y luego dos tipos de pagos con radio button 
    'finalmente agregarle onda con stiles


    Private Sub calcular_precio_final_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcular_precio_final.Click
        Dim checked_menues As Integer
        Dim total_con_descuento As Single
        Dim descuento As Single
        checked_menues = 0

        For Each control As Control In Tipos_menues.Controls
            If TypeOf control Is CheckBox Then
                Dim checkBox As CheckBox = DirectCast(control, CheckBox)
                If checkBox.Checked Then
                    checked_menues = checked_menues + 1
                End If
            End If
        Next

        If Not (checked_menues = 0) Then
            If Efectivo.Checked Then
                descuento = -10
            Else
                descuento = 10
            End If


            total_con_descuento = checked_menues * 7000 + (descuento * checked_menues * 70)
            Resultado.Text = total_con_descuento + (total_con_descuento * 21 / 100)
        Else
            MsgBox("Debe seleccionar al menos un tipo de menu")
        End If


        

    End Sub

End Class
