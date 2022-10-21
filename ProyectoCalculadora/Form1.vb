Public Class Form1

    'Declaracion de Varibles'

    Dim operador As String
    Dim acumResultado As Double
    Dim segundoNum As Double
    Dim borrarNumero As Boolean = False

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        SegundoValor()
        TextBox.Text &= 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SegundoValor()
        TextBox.Text &= 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SegundoValor()
        TextBox.Text &= 2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SegundoValor()
        TextBox.Text &= 3
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SegundoValor()
        TextBox.Text &= 4
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SegundoValor()
        TextBox.Text &= 5
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        SegundoValor()
        TextBox.Text &= 6
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        SegundoValor()
        TextBox.Text &= 7
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        SegundoValor()
        TextBox.Text &= 8
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        SegundoValor()
        TextBox.Text &= 9
    End Sub

    Private Sub ButtonDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDivision.Click
        SaberOperacion()
        operador = "/"

    End Sub

    Private Sub ButtonMultiplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMultiplicacion.Click
        SaberOperacion()
        operador = "x"
    End Sub

    Private Sub ButtonResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonResta.Click
        SaberOperacion()
        operador = "-"

    End Sub

    Private Sub ButtonSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSuma.Click
        SaberOperacion()
        operador = "+"
    End Sub

    Private Sub ButtonResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonResultado.Click
        SaberOperacion()
        operador = ""
    End Sub

    Private Sub ButtonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBorrar.Click
        acumResultado = 0
        segundoNum = 0
        TextBox.Text = ""
    End Sub

    'Hace la operacion -con un acumulador- dependiendo del boton (+,-,*,/)'

    Public Sub SaberOperacion()
        borrarNumero = True
        segundoNum = Val(TextBox.Text)
        If acumResultado > 0 Then
            Select Case operador
                Case "+"
                    acumResultado += segundoNum
                Case "-"
                    acumResultado -= segundoNum
                Case "x"
                    acumResultado *= segundoNum
                Case "/"
                    acumResultado /= segundoNum
            End Select
            TextBox.Text = acumResultado
        Else
            acumResultado = segundoNum
        End If

    End Sub

    'Borra el valor anterior ingresado para que no se muestre con el siguiente valor'

    Public Sub SegundoValor()
        If borrarNumero = True Then
            TextBox.Text = ""
            borrarNumero = False
        End If
    End Sub
End Class