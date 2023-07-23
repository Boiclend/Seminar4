int Zapros(string message) {
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
double Num1 = Zapros("Введите число");
double Num2 = Zapros("Введите в какую степень возвести");

GetResult(Num1,Num2);

void GetResult(double num1, double num2) {
    double result = Math.Pow(num1,num2);
    Console.WriteLine($"число {num1} в степени {num2} = {result}");
}



