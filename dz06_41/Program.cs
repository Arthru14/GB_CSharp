bool checkPositiveNums(int num = 0){
    if (num > 0) {return true;}
    return false;
}

Console.WriteLine("Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());
int numOfPositive = 0;

Console.WriteLine("Введите числа для проверки на позитивность:");

for (int i = 0; i < M; i++) {
    int numFromUser = Convert.ToInt32(Console.ReadLine());
    numOfPositive += Convert.ToInt32(checkPositiveNums(numFromUser));
}
Console.WriteLine($"Вы ввели {numOfPositive} положительных чисел");