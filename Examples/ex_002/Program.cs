Console.WriteLine ("Введите число a: ");
int number_a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число b: ");
int number_b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число с: ");
int number_с = Convert.ToInt32 (Console.ReadLine());
int max=number_a;

if (number_a>max) max=number_a;
if (number_b>max) max=number_b;
if (number_с>max) max=number_с;

Console.Write ("max=");
Console.WriteLine (max);




