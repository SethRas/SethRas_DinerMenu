'Seth Rasmussen
'RCET 0268
'Spring 2022
'Diner Menu Program
'https://github.com/SethRas/SethRas_DinerMenu.git

Public Class DinerMenuForm
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "~Burgie's Beef and Cheese Stew~" & vbNewLine & vbNewLine &
            "Nothing is too good for us here at Burgie's." & vbNewLine &
            "That's why we use only the finest Grade B Beef" & vbNewLine &
            "Paired with the cheese from the Food n Stuff" & vbNewLine &
        "this bowl of goodness Is sure to satisfy" & vbNewLine &
            "$4.98" & vbNewLine
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "~Chiefs Special Cobb Salad~" & vbNewLine & vbNewLine &
            "A lighter Touch of Goodness" & vbNewLine &
            "Fresh Collerd Greens, beans, And corn still on the Cobb." & vbNewLine &
        "This Salad brings a whole New meaning to Cobb salad" & vbNewLine &
            "$.98" & vbNewLine
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "~Fresh Caught Krab~" & vbNewLine & vbNewLine &
            "Krab with a K? That's right, Why pay big city Crab prices," & vbNewLine &
            " when the stuff in the can works just a good!" & vbNewLine &
            "$14.97" & vbNewLine
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        End
    End Sub

End Class
