'Author: Ravi SHah
'Date: 12/15/2018

Public Class FormRegisteration
    Public cakeMessage As String
    Public cusFName, cusLName, cusEmail As String
    Public cusPhone As String
    Public partyReason As String = ""
    Public validCoupon As Boolean



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        FormWelcome.Show()
    End Sub

    Private Sub txtBoxPhone_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPhone.TextChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtBoxFirstName.Text = ""
        txtBoxLastName.Text = ""
        txtBoxPhone.Text = ""
        txtBoxEmail.Text = ""
        cbAdult.SelectedIndex = 0
        cbNumberOfChildren.SelectedIndex = 0
        chkBirthday.Checked = False
        chkGettogether.Checked = False
        chkGraduation.Checked = False
        chkMarriage.Checked = False
        chkPromotion.Checked = True
        chkOthers.Checked = False
        rdbtnCakeNo.Checked = True
        rdCouponNo.Checked = True
    End Sub

    Private Sub rdCouponYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdCouponYes.CheckedChanged
        validCoupon = False
        If rdCouponYes.Checked = True Then
            Dim couponID(5) As String
            Dim customerCoupon As String
            couponID = {"1ABCD", "2BCDE", "3CDEF", "4DEFG", "5EFGH"}
            customerCoupon = InputBox("Please, Enter the coupon you have for Distcount?" & vbCrLf & vbCrLf & "Note: you have only one time to enter your coupon code.", "Coupon")
            Dim i, count As Integer
            count = 0
            On Error GoTo Handle
            If customerCoupon = "" Then
                MsgBox("No couon Applied.", MsgBoxStyle.Information)

            Else
                For i = 0 To 4

                    If couponID(i) = customerCoupon Then
                        validCoupon = True
                        count = +1
                    Else
                        MsgBox("Invalid Coupon")
                        Exit For

                    End If

                Next
            End If
            rdCouponYes.Enabled = False
            rdCouponNo.Checked = True
            Exit Sub

Handle:
            MsgBox((Err.Number))
        End If
    End Sub

    Private Sub rdbtnCakeYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnCakeYes.CheckedChanged
        cakeMessage = InputBox("Please type your Message on Cake for Celebration", "Cake Message")
    End Sub

    Private Sub FormRegisteration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy")
        cbNumberOfChildren.SelectedIndex = 0
        cbAdult.SelectedIndex = 1
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        cusFName = txtBoxFirstName.Text
        cusLName = txtBoxLastName.Text
        cusPhone = txtBoxPhone.Text
        cusEmail = txtBoxEmail.Text

        If cusFName = "" Then
            MsgBox("Please, Enter your First Name", MsgBoxStyle.Information)
            Exit Sub
        End If
        If cusLName = "" Then
            MsgBox("Please, Enter your Last Name", MsgBoxStyle.Information)
            Exit Sub
        End If
        If cusPhone = "" Then
            MsgBox("Please, Enter your Phone Number", MsgBoxStyle.Information)
            Exit Sub
        ElseIf Not IsNumeric(cusPhone) Then
            MsgBox("Phone number must in number", MsgBoxStyle.Information)
            Exit Sub
        ElseIf Len(cusPhone) <> 10 Then
            MsgBox("Phone Number must be of 10 digit", MsgBoxStyle.Information)
            Exit Sub
        End If
        If cusEmail = "" Then
            MsgBox("Please, Enter your Email-ID", MsgBoxStyle.Information)
            Exit Sub
        End If


        If chkBirthday.Checked = True Then
            partyReason += "Birth Day"
        End If
        If chkGettogether.Checked = True Then
            partyReason += "Get-Together"
        End If
        If chkGraduation.Checked = True Then
            partyReason += "Graduation"
        End If
        If chkMarriage.Checked = True Then
            partyReason += "Marriage Anniversery"
        End If
        If chkOthers.Checked = True Then
            partyReason += InputBox("Please, Spcify the Celebration Reason!")
        End If

        Me.Hide()
        FormMenu.Show()

    End Sub


End Class