Imports System.IO

Module CSVModule

    ' Function to read a CSV file and return a list of string arrays
    Public Function ReadCSV(filePath As String) As List(Of String())
        Dim lines As New List(Of String())
        
        Using reader As New StreamReader(filePath)
            Dim line As String
            While Not reader.EndOfStream
                line = reader.ReadLine()
                Dim values As String() = line.Split(","c)
                lines.Add(values)
            End While
        End Using
        
        Return lines
    End Function

    ' Subroutine to edit a specific value in the CSV file
    Public Sub EditCSV(filePath As String, rowIndex As Integer, columnIndex As Integer, newValue As String)
        Dim lines As List(Of String()) = ReadCSV(filePath)

        If rowIndex < lines.Count AndAlso columnIndex < lines(rowIndex).Length Then
            lines(rowIndex)(columnIndex) = newValue
        End If

        SaveCSV(filePath, lines)
    End Sub

    ' Subroutine to save the edited CSV file
    Public Sub SaveCSV(filePath As String, lines As List(Of String()))
        Using writer As New StreamWriter(filePath)
            For Each line As String() In lines
                writer.WriteLine(String.Join(",", line))
            Next
        End Using
    End Sub

End Module
