/*Напишите программу, которая принимает на вход пятизначное число и 
проверяет,является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
int temp = n;
int rev = 0;
int dig = 0;
while(n > 0)
 {   dig = n % 10;
rev = rev * 10 + dig;
n = n / 10;
 }
if (temp == rev)
    Console.Write("Yes");
else
    Console.Write("No");
 