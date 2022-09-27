
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



// int n = 10;

// for (int i = 0; i <= n; i++)
// {
//     System.Console.WriteLine(Math.Pow(i, 3));
// }




 // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
 // 6, 1, 33 -> [6, 1, 33]


//   int[] GetArray()
//   {
//       int[] result = new int[8];

//       for (int i = 0; i < result.Length; i++)
//       {
//           result[i] = new Random().Next(100);
//       }

//       return result;
//   }

//   void PrintArray(int[] arr)
//   {
//       int i = 0;
//       Console.Write("[");
//       while (i < arr.Length)
//       {
//           Console.Write(arr[i]);
//           i++;
//           if (i < arr.Length)
//           {
//               Console.Write(", ");
//           }
//       }
//      Console.Write("]");
//   }

//   PrintArray(GetArray());


//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 // [3, 7, 23, 12] -> 19
 // [-4, -6, 89, 6] -> 0


//  int[] GetArray()
//  {
//      int[] array = new int[5];
//      for (int i = 0; i < array.Length; i++)
//      {
//          array[i] = new Random().Next(-100, 100);
//      }
//      return array;
//  }

//  void PrintArray(int[] array)
//  {
//  System.Console.Write("[");
//      for (int i = 0; i < array.Length - 1; i++)
//      {
//          System.Console.Write(array[i] + ", ");
//      }
//      System.Console.WriteLine(array[array.Length-1] + "]");
//  }

//  int SumOddIndexNumbers(int[] array){
//      int sum = 0;
//      for (int i = 0; i < array.Length; i++)
//      {
//          if(i % 2 != 0 ){
//              sum += array[i];
//          }
//      }
//      return sum;
//  }

//  int[] array = GetArray();
//  PrintArray(array);
//  System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве равна {SumOddIndexNumbers(array)}");





 /* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

 /* const int X_COORD = 0;
 const int Y_COORD = 1;
 const int K_DATA = 0;
 const int B_DATA = 1;

 int[] GetCrossPoint(int[] dataLine1, int[] dataLine2)
 {
     int[] point = new int[2];
     point[X_COORD] = (dataLine1[B_DATA] - dataLine2[B_DATA]) / (dataLine2[K_DATA] - dataLine1[K_DATA]);
     point[Y_COORD] = (dataLine2[K_DATA]  * dataLine1[B_DATA] - dataLine1[K_DATA] * dataLine2[B_DATA]) / (dataLine2[K_DATA] - dataLine1[K_DATA]);
     return point;
 }

 bool Validate(int k1, int k2)
 {
     if (k1 == k2)
     {
         Console.Write("Заданные прямые не пересекаются");
         return false;
     }
     return true;
 }
 int[] InputDataLine(int number)
 {
     int[] dataLine = new int[2];
     Console.WriteLine($"Введите b{number}: ");
     dataLine[B_DATA] = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine($"Введите k{number}: ");
     dataLine[K_DATA] = Convert.ToInt32(Console.ReadLine());
     return dataLine;
 }

 int[] lineData1 = InputDataLine(1);
 int[] lineData2 = InputDataLine(2);

 if (Validate(lineData1[K_DATA], lineData2[K_DATA]))
 {
     int[] crossPoint = GetCrossPoint(lineData1, lineData2);
     Console.Write($"Точка пересечения прямых: ({crossPoint[X_COORD]}; {crossPoint[Y_COORD]})");
 }
  */

 
 //     return array;
 // }

 // void PrintArray(int[,] matrix)
 // {
 //     for (int i = 0; i < matrix.GetLength(0); i++)
 //     {
 //         for (int j = 0; j < matrix.GetLength(1); j++)
 //         {
 //             System.Console.Write($"{matrix[i, j]}\t");
 //         }
 //         System.Console.WriteLine();
 //     }
 //     System.Console.WriteLine();
 // }

 // int Prompt(string message)
 // {
 //     System.Console.Write(message);
 //     int result = Convert.ToInt32(Console.ReadLine());
 //     return result;
 // }

 // (int, int) FindDigitOnArray(int[,] array, int num)
 // {
 //     for (int i = 0; i < array.GetLength(0); i++)
 //     {
 //         for (int j = 0; j < array.GetLength(1); j++)
 //         {
 //             if (array[i, j] == num)
 //             {
 //                 return (i + 1, j + 1);
 //             }
 //         }
 //     }
 //     return (0, 0);
 // }

 // int[,] NewArray = GenerateArray(3);
 // PrintArray(NewArray);
 // int number = Prompt("Введите число, которое нужно найти в массиве: ");
 // (int row, int colum) = FindDigitOnArray(NewArray, number);
 // if (row == 0)
 // {
 //     System.Console.WriteLine("Числа нет в массиве");
 // }
 // else
 // {
 //     System.Console.WriteLine($"{row} {colum}");



