double[] crossPointOfLine(double[] line1, double[] line2){
    double[] crossPoint = new double[2];
    crossPoint[0] = (line2[0] - line1[0]) / (line1[1] - line2[1]);
    crossPoint[1] = line1[1] * crossPoint[0] + line1[0];
    return crossPoint;
}

Console.WriteLine("Введите константы первой прямой:");
double[] lineParam1 = new double[2];
lineParam1[0] = Convert.ToDouble(Console.ReadLine());
lineParam1[1] = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите константы второй прямой:");
double[] lineParam2 = new double[2];
lineParam2[0] = Convert.ToDouble(Console.ReadLine());
lineParam2[1] = Convert.ToDouble(Console.ReadLine());

if (lineParam1[1] != lineParam2[1]) {
    double[] crossPoint = new double[2];
    crossPoint = crossPointOfLine(lineParam1, lineParam2);
    Console.WriteLine($"Точка пересечения прямых:[{crossPoint[0]}, {crossPoint[1]}]");
} else {
    Console.WriteLine("Прямые параллельны друг другу");
}