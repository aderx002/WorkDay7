Option Strict On

Public Class Form1
    
    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim population As Double = 7000.0
        Dim exactYear As Integer = 2014

        Do While population >= 6

            population = population / 2
            exactYear = exactYear - 50

        Loop

        MessageBox.Show("The year was " & exactYear)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
