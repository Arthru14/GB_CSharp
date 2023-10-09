// void printSecondNum(int num = 123) {
//     Console.WriteLine($"Вторая цифра числа {num} есть {num % 100 / 10}");
// }

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// printSecondNum(num);

// void printThirdNum(int num = 123) {
//     if (num < 100 ) 
//     {
//         Console.WriteLine($"Число {num} состоит из менее, чем трех цифр");
//         return;
//     }

//     Console.Write($"Третья цифра числа {num}");

//     while (num > 999) {
//         num /= 10;
//     }
//     Console.WriteLine($" есть {num % 10}");
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// printThirdNum(num);

static Boolean checkWeekend( int numOfDay = 7) {
    while (numOfDay > 7) {numOfDay -= 7;}
    if (numOfDay == 6 || numOfDay == 7) {return true;}
    return false;
}

Console.WriteLine("Введите день недели:");
int numOfDay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"День недели {numOfDay} - {(checkWeekend(numOfDay)? "выходной":"будень")}");
