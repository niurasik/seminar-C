System.Console.WriteLine("Введите трехзначное число: ");
// insert one 3 symb number
int n = Convert.ToInt32(Console.ReadLine());
int result = n /10 % 10;
System.Console.WriteLine($"{n} -> {result}");
