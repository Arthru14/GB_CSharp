int[] generateArray(int size = 1) {
    int[] array = new int[size];
    Random rnd = new();
    for(int i = 0; i < size; i++) {
        array[i] = rnd.Next(-99, 99);
    }
    return array;
}

void printArray(int[] array) {
    for(int i = 0; i< array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

int getSumOddNums(int[] array) {
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) {
        sum += array[i];
    }
    return sum;
}

int size = 4;
int[] array = new int[size];
array = generateArray(size);
printArray(array);
Console.WriteLine($" -> {getSumOddNums(array)}");