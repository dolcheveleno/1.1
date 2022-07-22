/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void C(int[] cube)
{
  int n = 1;
  int length = cube.Length;
  while (n <  length)
  {
    cube[n] = n*n*n;
    n++;
  }
}
void PrintN(int[] col)
{
  int count = col.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(col[index]+ " ");
    index++;
  }
} 
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

int[] A = new int[cube+1];
C(A);
PrintN(A);