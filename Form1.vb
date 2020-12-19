Public Class frmMain
    'Class variables
    Private _FILENAME = "c:\school\csc-139\chapter8\savings.txt"
    Private _SAVINGS(11, 1)

    Private Sub MakeVisible(sender As Object, e As EventArgs) Handles cmbMonths.SelectedIndexChanged
        'When an item from the combobox is selected make the button and relevant label visible
        btnStats.Visible = True
        'Update the label before making it visible
        lblSelectedMonthsSavings.Text = "The savings for " & _SAVINGS(cmbMonths.SelectedIndex, 0) & " are $" & _SAVINGS(cmbMonths.SelectedIndex, 1)
        lblSelectedMonthsSavings.Visible = True
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup StreamReader to read the file
        Dim objReader As IO.StreamReader
        objReader = IO.File.OpenText(_FILENAME)
        'Loop through the file and assign the Month's name and savings amount to the 2D array _SAVINGS
        For i = 0 To _SAVINGS.GetUpperBound(0)
            _SAVINGS(i, 0) = objReader.ReadLine
            _SAVINGS(i, 1) = objReader.ReadLine
            'Populate the combobox with the Month's name
            cmbMonths.Items.Add(_SAVINGS(i, 0))
        Next
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        Dim decTotalSavings As Decimal
        Dim decAvgSavings As Decimal
        Dim arrLargestSavings() = {"", 0.0}
        'Find the average savings and the month with the most savings
        For i = 0 To 11
            decTotalSavings += _SAVINGS(i, 1)

            'Check this month's savings to see if it is larger than what's stored in arrLargestSavings
            If _SAVINGS(i, 1) > arrLargestSavings(1) Then
                arrLargestSavings(0) = _SAVINGS(i, 0)
                arrLargestSavings(1) = _SAVINGS(i, 1)
            End If
        Next
        decAvgSavings = decTotalSavings / (_SAVINGS.GetUpperBound(0) + 1)

        'Update the labels and make them visible
        lblAverageMonthly.Text = "The average monthly savings: " & decAvgSavings.ToString("C2")
        lblGreatestSavings.Text = arrLargestSavings(0) & " has the most significant monthly savings - $" & arrLargestSavings(1)
        lblAverageMonthly.Visible = True
        lblGreatestSavings.Visible = True
    End Sub
End Class
