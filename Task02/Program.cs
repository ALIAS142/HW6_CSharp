// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

{
System.Console.Write("Enter Point's b1 of first line:  ");
double b1 = int.Parse(Console.ReadLine());
System.Console.Write("Enter Point's b2 of first line:  ");
double b2 = int.Parse(Console.ReadLine());


System.Console.Write("Enter Point's k1 of second line:  ");
double k1 = int.Parse(Console.ReadLine());
System.Console.Write("Enter Point's k2 of second line:  ");
double k2 = int.Parse(Console.ReadLine());



  double x = (b2 - b1) / (k1 - k2);
  double y = k2 * x + b2;


  if ((y != k1 * x + b1) || (k1 - k2 == 0)) System.Console.WriteLine("No solution");
  else
  {
    System.Console.WriteLine($"Coordinates, x, y: ({x}); ({y})");
  }
}
