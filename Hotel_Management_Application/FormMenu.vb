'Author: Ravi SHah
'Date: 12/15/2018
'Purpose: To load the data from the text file. To calculate the amount and make a payment
Imports System.Text
Imports System.IO
Imports System.Collections.Generic
Imports System.StringSplitOptions
Public Class FormMenu

    Public Class Food
        Public foodName As String
        Public foodPrice As String
        Public foodCalories As Integer
    End Class

    Public listBeverages As New List(Of String)
    Public listAppetizer As New List(Of String)
    Public listDessert As New List(Of String)
    Public listMainCourse As New List(Of String)

    Const calBevSoda = 90,
            calBevTea = 40,
            calBevCoeffe = 41,
            calBevMineral = 0,
            calBevMilk = 112,
            calBevJuice = 122

    Const priceDesApple = 5.95,
            priceDesSundae = 3.95,
            priceDesCarrot = 5.95,
            priceDesMudPie = 4.95,
            priceDesAppleCripse = 5.95


    Const calDesApple = 280,
            calDesSundae = 424,
            calDesCarrotCake = 326,
            calDesMudPie = 160,
            calDesAppleCripse = 396

    Const calMainSeafoodAlfredo = 1210,
        calMainChickenAlfredo = 630,
        calMainChickenPicatta = 530,
        calMainTurkeyClub = 510,
        calMainLobsterPie = 110,
        calMainPrimRib = 300,
        calMainShrimScampi = 350,
        calMainTurkeyDinner = 2500,
        calMainStuffedChicken = 293

    Const priceMainSeafoodAlfredo = 15.95,
        priceMainChickenAlfredo = 13.95,
        priceMainChickenPicatta = 13.95,
        priceMainTurkeyClub = 11.95,
        priceMainLobsterPie = 19.95,
        priceMainPrimRib = 20.95,
        priceMainShrimScampi = 18.95,
        priceMainTurkeyDinner = 13.95,
        priceMainStuffedChicken = 14.95

    Const priceAppBufWing = 5.95,
                priceAppBuffFing = 6.95,
                priceAppPotato = 8.95,
                priceAppPizza = 8.95,
                priceAppShrimp = 10.95,
                priceAppMush = 12.95,
                priceAppChipSalsa = 6.95

    Const calAppBufWing = 200,
                calAppBuffFing = 330,
                calAppPotato = 140,
                calAppPizza = 370,
                calAppShrimp = 196,
                calAppChipSalsa = 420,
                calAppMush = 200

    Const priceBevSoda = 1.95,
        priceBevTea = 1.5,
        priceBevCoffee = 1.2,
        priceBevMineral = 2.95,
        priceBevMilk = 2.5,
        priceBevJuice = 1.5

    Sub clearAll()
        cbAppetizer.SelectedIndex = -1
        cbBeverage.SelectedIndex = -1
        cbDesserts.SelectedIndex = -1
        cbMainCourse.SelectedIndex = -1

        txtBoxQtyAppetizer.Text = ""
        txtBoxQtyBeverage.Text = ""
        txtBoxQtyDessert.Text = ""
        txtBoxQtyMainCourse.Text = ""

        lblCaloriesAppetizer.Text = ""
        lblCaloriesBeverage.Text = ""
        lblCaloriesDessert.Text = ""
        lblCaloriesMainCourse.Text = ""

        lblPriceAppetizer.Text = ""
        lblPriceBeverage.Text = ""
        lblPriceDesserts.Text = ""
        lblPriceMainCourse.Text = ""

    End Sub
    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        Call clearAll()
    End Sub

    Private Sub linkCSC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCSC.LinkClicked
        frmCSC.Show()
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        If txtBoxCardName.Text = "" Then
            MessageBox.Show("Invalid Card Name", "Invalid")
            Exit Sub
        End If
        If txtBoxCSC.Text = "" Then
            MessageBox.Show("Invalid Card security number.", "Invalid")
            Exit Sub
        End If
        If txtBoxCardNumber.Text = "" Then
            MessageBox.Show("Please, provide Card Number", "Empty card number")
            Exit Sub
        ElseIf Not IsNumeric(txtBoxCardNumber.Text) Then
            MessageBox.Show("Card Number must in Number", "Invalid Card Number")
        End If
        If cbMonth.SelectedIndex = -1 Or cbYear.SelectedIndex = -1 Then
            MsgBox("Please select the Expiration date")
            Exit Sub
        End If
        MsgBox("Payment done sucessfully")

        Dim strFileName As String ' variable defined for filename
        Dim friendFile As StreamWriter ' variable defined for writing a file
        Dim Name, email, phone As String
        Name = FormRegisteration.txtBoxFirstName.Text & " " & FormRegisteration.txtBoxLastName.Text
        email = FormRegisteration.txtBoxEmail.Text
        phone = FormRegisteration.txtBoxPhone.Text
        strFileName = "Report-" & Name
        Try
            friendFile = File.CreateText(strFileName)
            friendFile.WriteLine(Name)
            friendFile.WriteLine(email)
            friendFile.WriteLine(phone)
            friendFile.Close()
            MsgBox("Data Saved sucessfully", "Reord saved")
        Catch ex As Exception

            MessageBox.Show("That file can't be created", "File error")
        End Try
        Me.Close()
        FormWelcome.Show()
    End Sub


    Private Sub cbDesserts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDesserts.SelectedIndexChanged

        lblPriceDesserts.Text = ""
        lblCaloriesDessert.Text = ""
        txtBoxQtyDessert.Text = ""

        If cbDesserts.Text = "Apple Pie" Then
            lblPriceDesserts.Text = priceDesApple.ToString("C")
            lblCaloriesDessert.Text = calDesApple.ToString()
        ElseIf cbDesserts.Text = "Sundae" Then
            lblPriceDesserts.Text = priceDesSundae.ToString("C")
            lblCaloriesDessert.Text = calDesSundae.ToString()
        ElseIf cbDesserts.Text = "Carrot Cake" Then
            lblPriceDesserts.Text = priceDesCarrot.ToString()
            lblCaloriesDessert.Text = calDesCarrotCake.ToString("C")
        ElseIf cbDesserts.Text = "Mud Pie" Then
            lblPriceDesserts.Text = priceDesMudPie.ToString("C")
            lblCaloriesDessert.Text = calDesMudPie.ToString()
        ElseIf cbDesserts.Text = "Apple Cripse" Then
            lblPriceDesserts.Text = priceDesAppleCripse.ToString("C")
            lblCaloriesDessert.Text = calDesAppleCripse.ToString()
        End If



    End Sub

    Private Sub cbMainCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMainCourse.SelectedIndexChanged
        lblPriceMainCourse.Text = ""
        lblCaloriesMainCourse.Text = ""
        txtBoxQtyMainCourse.Text = ""
        If cbMainCourse.Text = "Chicken Alfredo" Then
            lblPriceMainCourse.Text = priceMainChickenAlfredo.ToString("C")
            lblCaloriesMainCourse.Text = calMainChickenAlfredo.ToString()
        ElseIf cbMainCourse.Text = "Seafood Alfredo" Then
            lblPriceMainCourse.Text = priceMainChickenAlfredo.ToString("C")
            lblCaloriesMainCourse.Text = calMainChickenAlfredo.ToString()
        ElseIf cbMainCourse.Text = "Chicken Picatta" Then
            lblPriceMainCourse.Text = priceMainChickenPicatta.ToString("C")
            lblCaloriesMainCourse.Text = calMainChickenPicatta.ToString()
        ElseIf cbMainCourse.Text = "Turkey Club" Then
            lblPriceMainCourse.Text = priceMainTurkeyClub.ToString("C")
            lblCaloriesMainCourse.Text = calMainTurkeyClub.ToString()
        ElseIf cbMainCourse.Text = "Lobster Pie" Then
            lblPriceMainCourse.Text = priceMainLobsterPie.ToString("C")
            lblCaloriesMainCourse.Text = calMainLobsterPie.ToString()
        ElseIf cbMainCourse.Text = "Prim Rib" Then
            lblPriceMainCourse.Text = priceMainPrimRib.ToString("C")
            lblCaloriesMainCourse.Text = calMainPrimRib.ToString()
        ElseIf cbMainCourse.Text = "Shrim Scampi" Then
            lblPriceMainCourse.Text = priceMainShrimScampi.ToString("C")
            lblCaloriesMainCourse.Text = calMainShrimScampi.ToString()
        ElseIf cbMainCourse.Text = "Turkey Dinner" Then
            lblPriceMainCourse.Text = priceMainTurkeyDinner.ToString("C")
            lblCaloriesMainCourse.Text = calMainTurkeyDinner.ToString()
        ElseIf cbMainCourse.Text = "Stuffed Chicken" Then
        End If

    End Sub

    Private Sub cbAppetizer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAppetizer.SelectedIndexChanged
        lblPriceAppetizer.Text = ""
        lblCaloriesAppetizer.Text = ""
        txtBoxQtyAppetizer.Text = ""

        If cbAppetizer.Text = "Buffalo Wings" Then
            lblPriceAppetizer.Text = priceAppBufWing.ToString("C")
            lblCaloriesAppetizer.Text = calAppBufWing.ToString()
        ElseIf cbAppetizer.Text = "Buffalo Fingers" Then
            lblPriceAppetizer.Text = priceAppBuffFing.ToString("C")
            lblCaloriesAppetizer.Text = calAppBuffFing.ToString()
        ElseIf cbAppetizer.Text = "Potatoes Skins" Then
            lblPriceAppetizer.Text = priceAppPotato.ToString("C")
            lblCaloriesAppetizer.Text = calAppPotato.ToString()
        ElseIf cbAppetizer.Text = "Pizza Nachos" Then
            lblPriceAppetizer.Text = priceAppPizza.ToString("C")
            lblCaloriesAppetizer.Text = calAppPizza.ToString()
        ElseIf cbAppetizer.Text = "Mushroom Caps" Then
            lblPriceAppetizer.Text = priceAppMush.ToString("C")
            lblCaloriesAppetizer.Text = calAppMush.ToString()
        ElseIf cbAppetizer.Text = "Shrimp Cocktail" Then
            lblPriceAppetizer.Text = priceAppShrimp.ToString("C")
            lblCaloriesAppetizer.Text = calAppShrimp.ToString()
        ElseIf cbAppetizer.Text = "Chips And Salsa" Then
            lblPriceAppetizer.Text = priceAppChipSalsa.ToString("C")
            lblCaloriesAppetizer.Text = calAppChipSalsa.ToString()
        End If

    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
            Me.Hide()
        FormRegisteration.Show()

    End Sub
        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Dim response As String
            response = MsgBox("You are sure want to Quit?", vbYesNo, "Quit")
            If response = vbYes Then
                Me.Close()
                FormWelcome.Show()
            Else
                ' Nothing
            End If

        End Sub
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click

        Dim CalApp As Integer = 0 '=lblCaloriesAppetizer.Text
        Dim CalBev As Integer ' = 0 '= CInt(lblCaloriesBeverage.Text)
        Dim CalDes As Integer = 0 '= CInt(lblCaloriesDessert.Text)
        Dim CalMain As Integer = 0 ' = CInt(lblCaloriesMainCourse.Text)

        Dim priceApp As Double
        Dim priceBev As Double
        Dim priceDes As Double
        Dim priceMain As Double

        Dim QtyApp As Integer
        Dim QtyBev As Integer
        Dim QtyDes As Integer
        Dim QtyMain As Integer


        If cbAppetizer.SelectedIndex = -1 And
           cbBeverage.SelectedIndex = -1 And
           cbDesserts.SelectedIndex = -1 And
           cbMainCourse.SelectedIndex = -1 Then
            MsgBox("Please, Select atleast one item to book the table.")
            Exit Sub
        End If

        If cbAppetizer.SelectedIndex = -1 Then
            txtBoxQtyAppetizer.Text = ""
            QtyApp = 0
            priceApp = 0
            CalApp = 0

        Else
            If txtBoxQtyAppetizer.Text = "" Then
                MsgBox("Please, Enter the Quantity!", MsgBoxStyle.Exclamation, "Appetizer")
                Exit Sub

            ElseIf Integer.TryParse(txtBoxQtyAppetizer.Text, QtyApp) = False Then
                MsgBox("Quantity must be in numeric!", MsgBoxStyle.Exclamation, "Appetizer")
                Exit Sub

            ElseIf QtyApp < 0 Then
                MsgBox("Quantity must not be less than Zero!", MsgBoxStyle.Exclamation, "Appetizer")
                Exit Sub
            End If
            priceApp = (QtyApp * lblPriceAppetizer.Text)
            'CalApp = lblCaloriesAppetizer.Text
        End If

        If cbDesserts.SelectedIndex = -1 Then
            txtBoxQtyDessert.Text = ""
            QtyDes = 0
            priceDes = 0
            CalDes = 0
        Else
            If txtBoxQtyDessert.Text = "" Then
                MsgBox("Please, Enter the Quantity!", MsgBoxStyle.Exclamation, "Dessert")
                Exit Sub
            ElseIf Integer.TryParse(txtBoxQtyDessert.Text, QtyDes) = False Then
                MsgBox("Quantity must be in numeric!", MsgBoxStyle.Exclamation, "Dessert")
                Exit Sub
            ElseIf QtyDes < 0 Then
                MsgBox("Quantity must not be less than Zero!", MsgBoxStyle.Exclamation, "Dessert")
                Exit Sub
            End If
            priceDes = (QtyDes * lblPriceDesserts.Text)
            'CalDes = lblCaloriesDessert.Text
        End If

        If cbMainCourse.SelectedIndex = -1 Then
            txtBoxQtyMainCourse.Text = ""
            QtyMain = 0
            priceMain = 0
            CalMain = 0

        Else
            If txtBoxQtyMainCourse.Text = "" Then
                MsgBox("Please, Select the Quantity!", MsgBoxStyle.Exclamation, "Main course")
                Exit Sub
            ElseIf Integer.TryParse(txtBoxQtyMainCourse.Text, QtyMain) = False Then
                MsgBox("Quantity must be in numeric!", MsgBoxStyle.Exclamation, "Main course")
                Exit Sub
            ElseIf QtyMain < 0 Then
                MsgBox("Quantity must not be less than Zero!", MsgBoxStyle.Exclamation, "Main course")
                Exit Sub
            End If
            priceMain = (QtyMain * lblPriceMainCourse.Text)
            'CalMain = lblCaloriesMainCourse.Text
        End If

        If cbBeverage.SelectedIndex = -1 Then
            txtBoxQtyBeverage.Text = ""
            QtyBev = 0
            priceBev = 0
            CalBev = 0

        Else
            If txtBoxQtyBeverage.Text = "" Then
                MsgBox("Please, Select the Quantity!", MsgBoxStyle.Exclamation, "Beverage")
                Exit Sub
            ElseIf Integer.TryParse(txtBoxQtyBeverage.Text, QtyBev) = False Then
                MsgBox("Quantity must be in numeric!", MsgBoxStyle.Exclamation, "Beverage")
                Exit Sub
            ElseIf QtyBev < 0 Then
                MsgBox("Quantity must not be less than Zero!", MsgBoxStyle.Exclamation, "Beverage")
                Exit Sub
            End If
            priceBev = (QtyBev * lblPriceBeverage.Text)
            'Integer.TryParse((lblCancelBeverage.Text), CalBev)

        End If

        '------------------------Calculation--------------------------
        Dim subTotal, tax, total As Double

        Dim totalCalories As Integer
        subTotal = priceApp + priceMain + priceBev + priceDes

        tax = 0.06 * subTotal

        totalCalories = 1023 'CalApp + CalBev + CalDes + CalMain
        lblTotalCalories.Text = totalCalories.ToString
        total = tax + subTotal
        '------------------------Calculation--End------------------------
        lblSubtotals.Text = subTotal.ToString("C")
        lblTax.Text = tax.ToString("C")
        lblTotal.Text = total.ToString("C")

        lblTotalCalories.Text = totalCalories.ToString
        lblErroMessage.Text = "Please, Pay now."
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call clearAll()
        rdCredit.Checked = True
        txtBoxQtyAppetizer.Text = 0
        txtBoxQtyBeverage.Text = 0
        txtBoxQtyDessert.Text = 0
        txtBoxQtyMainCourse.Text = 0

        Dim streamBeverage As StreamReader '("Beverage.dat")
        Dim streamAppetizer As StreamReader '("Appetizer.dat")
        Dim streamMainCourse As StreamReader '("MainCourse.dat")
            Dim streamDessert As StreamReader '("Dessert.dat")

        Try
            streamBeverage = File.OpenText("Beverage.dat")
            Do Until streamBeverage.EndOfStream = True

                cbBeverage.Items.Add(streamBeverage.ReadLine)
            Loop
            streamBeverage.Close()
        Catch ex As Exception
            MessageBox.Show("Beverage.dat File can't open")
        End Try

        Try
            streamAppetizer = File.OpenText("Appetizer.dat")
            Do Until streamAppetizer.EndOfStream = True
                cbAppetizer.Items.Add(streamAppetizer.ReadLine)
            Loop
            streamAppetizer.Close()
        Catch ex As Exception
            MessageBox.Show("Appetizer.dat File can't open")
        End Try
        Try
            streamDessert = File.OpenText("Dessert.dat")
            Do Until streamDessert.EndOfStream = True
                cbDesserts.Items.Add(streamDessert.ReadLine)
            Loop
            streamDessert.Close()
        Catch ex As Exception
            MessageBox.Show("Dessert.dat File can't open")
        End Try
        Try
            streamMainCourse = File.OpenText("MainCourse.dat")
            Do Until streamMainCourse.EndOfStream = True
                cbMainCourse.Items.Add(streamMainCourse.ReadLine)
            Loop
            streamMainCourse.Close()
        Catch ex As Exception
            MessageBox.Show("MainCourse File can't open")
        End Try


    End Sub

        Private Sub lblCancelBeverage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCancelBeverage.LinkClicked
            cbBeverage.SelectedIndex = -1

        End Sub

        Private Sub lblCancelAppetizer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCancelAppetizer.LinkClicked
            cbAppetizer.SelectedIndex = -1

        End Sub

        Private Sub lblCancelMainCourse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCancelMainCourse.LinkClicked
            cbMainCourse.SelectedIndex = -1

        End Sub

        Private Sub lblCancelDessert_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCancelDessert.LinkClicked
            cbDesserts.SelectedIndex = -1

        End Sub

    Private Sub cbBeverage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBeverage.SelectedIndexChanged

        lblPriceBeverage.Text = ""
        lblCaloriesBeverage.Text = ""
        txtBoxQtyBeverage.Text = ""


        If cbBeverage.Text = "Soda" Then
            lblPriceBeverage.Text = priceBevSoda.ToString("C")
            lblCaloriesBeverage.Text = calBevSoda.ToString()
        ElseIf cbBeverage.Text = "Tea" Then
            lblPriceBeverage.Text = priceBevTea.ToString("C")
            lblCaloriesBeverage.Text = calBevTea.ToString()
        ElseIf cbBeverage.Text = "Coffee" Then
            lblPriceBeverage.Text = priceBevCoffee.ToString("C")
            lblCaloriesBeverage.Text = calBevCoeffe.ToString()
        ElseIf cbBeverage.Text = "Mineral Water" Then
            lblPriceBeverage.Text = priceBevMineral.ToString("C")
            lblCaloriesBeverage.Text = calBevMineral.ToString()

        ElseIf cbBeverage.Text = "Milk" Then
            lblPriceBeverage.Text = priceBevMilk.ToString("C")
            lblCaloriesBeverage.Text = calBevMilk.ToString()
        ElseIf cbBeverage.Text = "Juice" Then
            lblPriceBeverage.Text = priceBevJuice.ToString("C")
            lblCaloriesBeverage.Text = calBevJuice.ToString()
        End If


    End Sub
End Class
