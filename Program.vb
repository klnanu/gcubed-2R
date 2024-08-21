Module Program
    Sub Main()
        ' Set the path to your CSV file here
        Dim filePath As String = "path\to\your\csvfile.csv"
        
        ' Example: Edit the CSV file at row 1, column 2 (index starts at 0)
        CSVModule.EditCSV(filePath, 1, 2, "New Value")
        
        ' Optional: Read and print the edited CSV file to the console
        Dim editedLines As List(Of String()) = CSVModule.ReadCSV(filePath)
        For Each line As String() In editedLines
            Console.WriteLine(String.Join(",", line))
        Next
    End Sub
End Module
