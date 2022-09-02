System.Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

 if (a > b && a > c){
     System.Console.WriteLine("Число а максимальное");
 }
 else if (b > c){
    System.Console.WriteLine("Число b максимальное");
 }
 else{
    System.Console.WriteLine("Число c максимальное");
 }    

