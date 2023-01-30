// Задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

PrintArrey(GetRandomArrey(8));
int[] GetRandomArrey(int length)
{
    int [] result = new int [length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random(). Next(0, 100); 
    }
    return result;
}
void PrintArrey(int[] arr)
{
    foreach (int item in arr)
    {
       System.Console.WriteLine(item); 
    }
}
