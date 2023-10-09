// void myPow(int x, int y) {
//     int xy = x;
//     for(int i = 1; i < y; i++) {
//         xy *= x;
//     }
//     Console.WriteLine($"{x}^{y} = {xy}");
// }

// Console.WriteLine("Введите два числа");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// myPow(x, y);

// void sumOfDigOutput(int x) {
//     int sum = 0;
//     Console.Write($"Сумма цифр {x} -> ");
//     while (x > 0) {
//         sum += x % 10;
//         x /= 10;
//     }
//     Console.WriteLine($"{sum}");
// }

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// sumOfDigOutput(x);

// int[] getNewArray() {
//     int[] array = new int[8];
//     Random rnd = new();

//     for(int i = 0; i < 8; i++) {
//         array[i] = rnd.Next(1, 100);
//     }
//     return array;
// }

// void printArray(int[] array) {
//     for(int i = 0; i < array.Length; i ++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// printArray(getNewArray());

using System.Threading.Channels;

int number = 14212;
bool isPali = (number / 10000 == number % 10) && (number / 1000 % 10 == number / 10 % 10);
Console.WriteLine(isPali);
Console.WriteLine(Math.Pow(3, 2));
Math.Sqrt