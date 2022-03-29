﻿' Name:         Numbers Project
' Purpose:      Display a list of numbers using various loops.
' Programmer:   <Bailey Nichols> on <3/17/2022>
' Notes:        I changed literally nothing, all that needed done was already done when I opened the file, not trying to pagerize but idk what to do

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' Display a list of numbers.

        Dim intFrom As Integer
        Dim intTo As Integer

        Integer.TryParse(txtFrom.Text, intFrom)
        Integer.TryParse(txtTo.Text, intTo)
        lstNumbers.Items.Clear()

        If intFrom < intTo Then
            For intNum As Integer = intFrom To intTo
                lstNumbers.Items.Add(intNum)
            Next intNum
        End If
    End Sub

    Private Sub btnDoPretest_Click(sender As Object, e As EventArgs) Handles btnDoPretest.Click
        ' Display a list of numbers.

        Dim intFrom As Integer
        Dim intTo As Integer

        Integer.TryParse(txtFrom.Text, intFrom)
        Integer.TryParse(txtTo.Text, intTo)
        lstNumbers.Items.Clear()

        If intFrom < intTo Then
            Do While intFrom <= intTo
                lstNumbers.Items.Add(intFrom)
                intFrom += 1
            Loop
        End If
    End Sub

    Private Sub btnDoPosttest_Click(sender As Object, e As EventArgs) Handles btnDoPosttest.Click
        ' Display a list of numbers.

        Dim intFrom As Integer
        Dim intTo As Integer

        Integer.TryParse(txtFrom.Text, intFrom)
        Integer.TryParse(txtTo.Text, intTo)
        lstNumbers.Items.Clear()

        If intFrom < intTo Then
            Do
                lstNumbers.Items.Add(intFrom)
                intFrom += 1
            Loop While intFrom <= intTo
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrom.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTo.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFrom_Enter(sender As Object, e As EventArgs) Handles txtFrom.Enter
        txtFrom.SelectAll()
    End Sub

    Private Sub txtTo_Enter(sender As Object, e As EventArgs) Handles txtTo.Enter
        txtTo.SelectAll()
    End Sub

    Private Sub txtFrom_TextChanged(sender As Object, e As EventArgs) Handles txtFrom.TextChanged
        lstNumbers.Items.Clear()
    End Sub

    Private Sub txtTo_TextChanged(sender As Object, e As EventArgs) Handles txtTo.TextChanged
        lstNumbers.Items.Clear()
    End Sub
End Class
