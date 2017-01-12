Module Module1

    Public Function StructPassing(ByRef StudentName As Student)
        Console.WriteLine("Name : {0} , ID : {1} , Age : {2}", StudentName.Name, StudentName.ID, StudentName.Age)
        StudentName.Age = 24
        StudentName.Name = "BH"
        StudentName.ID = 451029
        Console.WriteLine("Name : {0} , ID : {1} , Age : {2}", StudentName.Name, StudentName.ID, StudentName.Age)
        Return True
    End Function

    Sub Main()

        Dim Bing As New Student

        Bing.Age = 23
        Bing.Name = "BingHeng"
        Bing.ID = 11048

        Console.WriteLine("Name : {0} , ID : {1} , Age : {2}", Bing.Name, Bing.ID, Bing.Age)
        StructPassing(Bing)
        Console.WriteLine("Name : {0} , ID : {1} , Age : {2}", Bing.Name, Bing.ID, Bing.Age)
        Console.Read()
    End Sub

End Module
