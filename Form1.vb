Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedItem = "Costa" Then
            ComboBox3.Items.Clear()
            ComboBox3.Visible = True
            ComboBox3.Items.Add("Esmeraldas")
            ComboBox3.Items.Add("Santo Domingo")
            ComboBox3.Items.Add("Manabi­")
            ComboBox3.Items.Add("Los Rios")
            ComboBox3.Items.Add("Guayas ")
            ComboBox3.Items.Add("Santa Elena ")
            ComboBox3.Items.Add("El Oro")

        ElseIf ComboBox1.SelectedItem = "Sierra" Then
            ComboBox2.Items.Clear()
            ComboBox2.Visible = True

            ComboBox2.Items.Add("Carchi")
            ComboBox2.Items.Add("Imbabura")
            ComboBox2.Items.Add("Pichincha")
            ComboBox2.Items.Add("Loja")
            ComboBox2.Items.Add("Cotopaxi")
            ComboBox2.Items.Add("Tungurahua")
            ComboBox2.Items.Add("Bolivar")
        ElseIf ComboBox1.SelectedItem = "Oriente" Then

            ComboBox3.Items.Clear()
            ComboBox3.Visible = True

            ComboBox3.Items.Add("Morona Santiago")
            ComboBox3.Items.Add("Napo")
            ComboBox3.Items.Add("Orellana")
            ComboBox3.Items.Add("Pastaza")
            ComboBox3.Items.Add("Sucumbios ")
            ComboBox3.Items.Add("Zamora Chinchipe ")

        ElseIf ComboBox1.SelectedItem = "Seleccionar:" Then
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()

            ComboBox2.Visible = False
            ComboBox3.Visible = False

            Label3.Text = ""
            Label4.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""




        End If
    End Sub
    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.KeyUp




        If ComboBox1.SelectedItem = "Costa" Then
            ComboBox2.Items.Clear()
            ComboBox2.Visible = True
            ComboBox2.Items.Add("Esmeraldas")
            ComboBox2.Items.Add("Santo Domingo")
            ComboBox2.Items.Add("Manabi­")
            ComboBox2.Items.Add("Los Rios")
            ComboBox2.Items.Add("Guayas ")
            ComboBox2.Items.Add("Santa Elena ")
            ComboBox2.Items.Add("El Oro")

        ElseIf ComboBox1.SelectedItem = "Oriente" Then

            ComboBox3.Items.Clear()
            ComboBox3.Visible = True

            ComboBox3.Items.Add("Morona Santiago")
            ComboBox3.Items.Add("Napo")
            ComboBox3.Items.Add("Orellana")
            ComboBox3.Items.Add("Pastaza")
            ComboBox3.Items.Add("Sucumbios ")
            ComboBox3.Items.Add("Zamora Chinchipe ")

        ElseIf ComboBox1.SelectedItem = "Seleccionar:" Then
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()

            ComboBox2.Visible = False
            ComboBox3.Visible = False

            Label3.Text = ""
            Label4.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""




        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Button1.Visible = True


        TextBox4.Text = Convert.ToString(ComboBox3.SelectedItem)
        TextBox4.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = True

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox1.Text = Convert.ToString(ComboBox2.SelectedItem)
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True




    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numero1 As Decimal
        Dim numero2 As Decimal

        numero1 = CDec(TextBox3.Text)
        numero2 = CDec(TextBox6.Text)
        If numero1 > numero2 Then

            Label3.Text = TextBox1.Text
            Label4.Text = TextBox4.Text

        ElseIf numero1 < numero2 Then
            Label4.Text = TextBox1.Text
            Label3.Text = TextBox4.Text


        End If


    End Sub

End Class
