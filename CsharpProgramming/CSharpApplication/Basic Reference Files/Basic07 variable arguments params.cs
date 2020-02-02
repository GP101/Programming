using System;

public class MyClass
{
    public static void VariableArguments(int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    public static void UseParams(params int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    public static void UseParams2(params object[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        VariableArguments(new int[] { 11, 22, 33, 44 });
        UseParams(1, 2, 3, 4);
        UseParams2(1, 'a', "test");

        UseParams2();

        int[] myIntArray = { 5, 6, 7, 8, 9 };
        UseParams(myIntArray);

        object[] myObjArray = { 2, 'b', "hello", "world" };
        UseParams2(myObjArray);

        UseParams2(myIntArray);
    }
    /** output:
        11 22 33 44
        1 2 3 4
        1 a test

        5 6 7 8 9
        2 b hello world
        System.Int32[]
    */
}
