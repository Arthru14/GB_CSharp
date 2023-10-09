int[] generateArray(int size = 1) {
    int[] array = new int[size];
    Random rnd = new();
    for(int i = 0; i < size; i++) {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

void printArray(int[] array) {
    for(int i = 0; i< array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

int getCountEvenNums(int[] array) {
    int countEven = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            countEven++;
        }
    }
    return countEven;
}

int size = 4;
int[] array = new int[size];
array = generateArray(size);
printArray(array);
Console.WriteLine($" -> {getCountEvenNums(array)}");


