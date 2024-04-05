Imports System

' Define Student class
Public Class Student
    ' Properties
    Public Property Name As String
    Public Property Age As Integer

    ' Constructor
    Public Sub New(name As String, age As Integer)
        Me.Name = name
        Me.Age = age
    End Sub

    ' Function to display student details
    Public Function DisplayDetails() As String
        Return $"Name: {Name}, Age: {Age}"
    End Function
End Class

Module Program
    Sub Main(args As String())
        ' Declare variables
        Dim students As New List(Of Student)()
        Dim choice As Integer

        ' Menu-driven interface
        Do
            Console.WriteLine("1. Add Student")
            Console.WriteLine("2. Display Students")
            Console.WriteLine("3. Exit")
            Console.Write("Enter your choice: ")
            choice = Convert.ToInt32(Console.ReadLine())

            Select Case choice
                Case 1
                    ' Add Student
                    Console.Write("Enter student name: ")
                    Dim name As String = Console.ReadLine()
                    Console.Write("Enter student age: ")
                    Dim age As Integer = Convert.ToInt32(Console.ReadLine())
                    Dim student As New Student(name, age)
                    students.Add(student)
                    Console.WriteLine("Student added successfully.")
                Case 2
                    ' Display Students
                    Console.WriteLine("Student Details:")
                    For Each student In students
                        Console.WriteLine(student.DisplayDetails())
                    Next
                Case 3
                    ' Exit
                    Console.WriteLine("Exiting...")
                Case Else
                    ' Invalid choice
                    Console.WriteLine("Invalid choice. Please enter a valid option.")
            End Select

            Console.WriteLine()
        Loop While choice <> 3
    End Sub
End Module