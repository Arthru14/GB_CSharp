// Задача 2. Определеяем, какое из двух чисел больше какое меньше

// Console.WriteLine("Введите два числа");

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b) Console.WriteLine($"max = {a} min = {b}");
// else Console.WriteLine($"max = {b} min = {a}");

// Задача 4. Определяем макисмальное из трех чисел

// Console.WriteLine("Введите три числа");

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b > max) {max = b;}
// if (c > max ) {max = c;}

// Console.WriteLine($"max({a}, {b}, {c}) = {max}");

// Задача 6. Определяем четное число
Console.WriteLine("Введите целое число");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} -> {(a % 2 == 0 ? "да" : "нет")}");

// Задача 8. Определяем четные числа до N
Console.WriteLine("Введите целое число");

int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= N; i++) {
    if(i % 2 == 0) {Console.Write($"{i} ");}
}
Console.WriteLine();