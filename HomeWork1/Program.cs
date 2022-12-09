/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да*/





Console.WriteLine("Введите число :");
int num = int.Parse(Console.ReadLine());
CheckForPolindrom (num);
void CheckForPolindrom (int num){
int rem; 
int sum = 0;
int temp = num;
    while (num>0)
    {
        rem = num % 10;
        num = num / 10; 
        sum = sum * 10 + rem; 
    }
        if (temp == sum)
    {
        Console.WriteLine("Это число полиндром");
    }
        else
    {
        Console.WriteLine("Это число не полиндром");
    }
}
