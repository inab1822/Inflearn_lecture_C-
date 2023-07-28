using System;

public class Example
{
    public static void Main()
    {
        // 배열을 초기화 하는 첫 번째 방법
        int[] array1 = new int[3];
        array1[0] = 10;
        array1[1] = 20;
        array1[2] = 30;

        Console.WriteLine(array1);
        for(int i = 0;i< array1.Length;i++)
        {
            Console.WriteLine(array1[i]);
        }

        // 배열을 초기화하는 두번째 방법
        int[] array2 = new int[] {1,2,3};

        int[] array3 = {100,200,300};

        foreach(int i in array3)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(array2);
        Console.WriteLine(array3);
    }
}
