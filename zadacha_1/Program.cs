/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while ( index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(col[pos]);
        pos++;
    }
}
int [] array = new int[5];
FillArray(array);
PrintArray(array);
if (array[0]==array[4] || array[1]==array[3])
{
    Console.WriteLine("Число - палиндром");
}
else
{
    Console.WriteLine("Число - не палиндром");
}
