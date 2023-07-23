int Zapros(string message) {
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int N = Zapros("Введите длину массива");
int[] arr = new int[N];

int[] GetResult(int[] mass) {

for(int i = 0; i < mass.Length; i++) {
    mass[i] = Convert.ToInt32(Console.ReadLine());
}
    return arr;
}

void PrintArray(int[] mass) {
    int count = 1;
    for(int i = 0; i < mass.Length; i++) {
        if (i == 0) {
            Console.Write($"{count} символ массива = {mass[i]}");
        } else {
            Console.Write(", " + $"{count} символ массива = {mass[i]}");
        }
        count++;
    }

}

GetResult(arr);
PrintArray(arr);