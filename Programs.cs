// Написать программу, которая из имеющегося массива строк, формирует массив из строк, 
// длинна которых < либо равна 3 символам.

string [] arraynew = new string [] { "Friend", "Sam", "Bob", "Kate", "Tom", "Alice", "777777" };
int len = arraynew.Length;

for (int i = 0; i < len; i++)
{
      int n = arraynew[i].Length;
      if (n<=3)
      {
           Console.Write($"{arraynew[i]}_");
      }
}init