
// int a = 11;
// int b = 50;

// if (a > b){ 
//     System.Console.WriteLine("Число А больше числа Б");
// }
// else{
// if (b > a){
//      System.Console.WriteLine("Число Б больше числа А");
// }
// else{
//  System.Console.WriteLine("Числа рывны");
// }
// }


// int a = 5;
// int b = 3;
// int c = 7;

// int max =0;

// if(max < a){
//     max = a;
// }
// if (max < b){
//     max = b;
// }
// if(max < c){
//     max =c;
// }
// System.Console.WriteLine(max);



// int n = 648;
 
// System.Console.WriteLine(n / 10 % 10);




// int n = new Random().Next(100, 10000);

// if (n < 100){

//  System.Console.WriteLine("Третьей цифры нет");
// }
// else{
//     int result = n / 100 % 10;
//     System.Console.WriteLine($"Третья цифра числа {n} -> {result}");

// }


// int day =3;

// if (day < 1 || day > 7){
// System.Console.WriteLine("Неверный день недели");
// }
// else if (day > 5 && day < 8){
//     System.Console.WriteLine("Это выходной");
// }



// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int d1 = n / 10000;
// n -= d1 * 10000;

//  int d2 = n / 1000;
//  n -= d2 * 1000;

// int d3 = n / 100;
// n -= d3 * 100;

// int d4 = n / 10;
// n -= d4 * 10;

// int d5 = n % 10;

// if (d1 == d5 && d2 == d4){
//     System.Console.WriteLine("палиндром");
// }
// else{
//     System.Console.WriteLine("не палиндром");
    


// int x1 = 3;
// int y1 = 6;
// int z1 = 8;

// int x2 =2;
// int y2 =1;
// int z2 = -7;

// double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

// System.Console.WriteLine(distance);



int n = 10;

for (int i = 0; i <= n; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}
