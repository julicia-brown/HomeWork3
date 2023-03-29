Option Strict On
Option Explicit On


Public Class FrmCatering

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tboxPoints.Text = ""
        tboxPoints.Focus()
        radGourmetCheese.Checked = True
        radPinwheel.Checked = False
        radVeggie.Checked = False
        radSausage.Checked = False
        radFruit.Checked = False

        radPrePay.Checked = True
        radPickUp.Checked = False

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(tboxPoints.Text) Then
            intPoints = Convert.ToInt32(tboxPoints.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."
            MsgBox(intPoints)

            If radGourmetCheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf radPinwheel.Checked Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf radVeggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf radSausage.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radFruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            If radPrePay.Checked Then
                strPay = " using Pre-Pay"
            ElseIf radPickUp.Checked Then
                strPay = " with Pay upon Pickup"
            End If


            If intPoints > 10 Then
                intPoints = Convert.ToInt32((intPoints / 10I) - 0.5)

                MsgBox(intPoints)

            Else
                intPoints = Convert.ToInt32(intPoints / 10I)

                MsgBox(intPoints)
            End If

            decPoints = (intPoints * cdecDiscount) / 100
            MsgBox(decPoints)

            If decPoints > 1 Then
                decPoints = 1
            End If

            MsgBox(decPoints)

            decFinal = decCost * (1 - decPoints)
            MsgBox(decFinal)

            lblReturn.Visible = True
            lblReturn.Text = "Your Order " & strOrder & " platter costs " &
                decFinal.ToString("C") & strPay & strPoints
        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btnClear.PerformClick()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub

End Class
