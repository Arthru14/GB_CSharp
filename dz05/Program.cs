using System.ComponentModel.DataAnnotations;

double[] generateArray(int size = 1) {
    double[] array = new double[size];
    Random rnd = new();
    for(int i = 0; i < size; i++) {
        array[i] = rnd.NextDouble() * 1000;
    }
    return array;
}

void printArray(double[] array) {
    for(int i = 0; i< array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

double getMaxElemOfArray(double[] array) {
    double max = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        }
    }
    return max;
}

double getMinElemOfArray(double[] array) {
    double min = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (array[i] < min) {
            min = array[i];
        }
    }
    return min;
}

int size = 4;
double[] array = new double[size];
double max = 0, min = 0;;
array = generateArray(size);
max = getMaxElemOfArray(array);
min = getMinElemOfArray(array);
printArray(array);
Console.WriteLine($" -> {max} - {min} = {max - min}");