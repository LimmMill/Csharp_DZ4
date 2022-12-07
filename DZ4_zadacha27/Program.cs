//  27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// 452 -> 11    82 -> 10     9012 -> 12
{
  Console.Writline("Введите целое число");
  int num = Convert.ToInt32(Console.ReadLine());
  int sum = 0;
  int amount(int num);
    { 
    
       for (int i=num; i >0; i=i /10);
        {
          num = i % 10;
          sum = sum + num;
        }
       return sum;
    }
    
    Console.Writline($"{amount(num)}");
}    
catch
{
    Console.Writline("Ошибка, введите целое число");
    
}




