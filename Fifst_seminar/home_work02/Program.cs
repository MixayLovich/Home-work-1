
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


int day =3;

if (day < 1 || day > 7){
System.Console.WriteLine("Неверный день недели");
}
else if (day > 5 && day < 8){
    System.Console.WriteLine("Это выходной");
}