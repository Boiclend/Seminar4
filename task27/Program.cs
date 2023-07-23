int Zapros(string message) {
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int num1 = Zapros("Введите число");
int result = 0;
int result2 = 0;
int COUNT = num1;
int PROMPT = num1;

int GetResult(int count, int prompt ) {
while (count > 999) {
     count = count % 10;
     result = result + count;
     prompt = prompt / 10;
     count = prompt;
}
int res1;
int res2;
int res3;

res1 = count % 10;
res2 = count / 100;
res3 = count / 10;
res3 = res3 % 10;
result2 = result2 + result + res1 + res2 + res3;
    return result2;
}



Console.WriteLine(GetResult(COUNT,PROMPT));