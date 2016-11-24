Module Module1

    Sub Main()

        Dim D, L, X, mdot, Ts As Double

        Console.Write("Please enter length(m) : ")
        L = Console.ReadLine()
        Console.Write("Please enter tube diameter(m) : ")
        D = Console.ReadLine()
        Console.Write("Please enter quality : ")
        X = Console.ReadLine()
        Console.Write("Please enter mass flow rate(kg/s) : ")
        mdot = Console.ReadLine()
        Console.Write("Please enter Eavp temperature(k) : ")
        Ts = Console.ReadLine()

        Console.WriteLine("length(m) : {0} , diameter : {1} , quality : {2} , mass flow rate : {3} , Tevap : {4}", L, D, X, mdot, Ts)
        Console.Read()



    End Sub

End Module
