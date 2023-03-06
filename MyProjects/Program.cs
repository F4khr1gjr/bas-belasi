#region tek ve ya cut olma elameti
//int number = 100;
//if (number % 2 == 0)
//{
//    Console.WriteLine("Even");
//}
//else
//{
//    Console.WriteLine("Odd");
//}
#endregion
#region en boyuk ededi tapmaq
//int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8 };
//int enboyuk = Array[0];
//for (int i = 0; i < Array.Length; i++)
//{
//	if (Array[i] > enboyuk) ;
//	{
//		enboyuk	= Array[i];
//	}
//}
//Console.WriteLine(enboyuk);

//int[] array = { 1, 5, 8, 2, 7, 3 };
//bool status = false;
//for(int i = 0;i<)
#endregion
#region sade yoxsa murekkeb eded
//int a = int.Parse(Console.ReadLine());
//int count = 0;
//for (int i = 0; i < a; i++)
//{
//    count++;
//}
//if (count == 2)
//{
//    Console.WriteLine(a + "is Prime Number");
//}
//else
//{
//    Console.WriteLine(a + "is not Prime Number");
//}
#endregion
#region en kicik ededi tapmaq
//int[] array = { 3, 5, 2, 6, 9 };
//int smallest = array[0];
//for (int i = 0; i < array.Length; i++)
//{
//	if (array[i] < smallest)
//	{
//		smallest = array[i];
//	}
//}
//Console.WriteLine(smallest);
#endregion
#region en boyuk ededi tapmaq
//int[] array = {58, 2, 5, 2, 7, 9, 3, 5};
//int biggest = array[0];
//for (int i = 0; i < array.Length; i++)
//{
//	if (array[i] > biggest)
//	{
//		biggest = array[i];
//	}
//}
//Console.WriteLine(biggest);
#endregion
#region artan sira ile duzmek
//int[] array = { 5, 17, 82, 98, 102, 45, 36, 23, 52 };
//int temp;
//for (int i = 0; i < array.Length-1; i++)
//{
//	for (int j = 0; j  < array.Length-i-1; j++)
//	{
//		if (array[j] > array[j + 1]) 
//		{
//			int temp = array[j];
//			array[j]= array[j + 1];
//			array[j+1]= temp;
//		}
//	}
//	Console.WriteLine(array[i]);
//}
#endregion
#region ededlerin azalan sira ile duzulmesi
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//for (int i = 0; i < array.Length-1; i++)
//{
//	for (int j = 0; j < array.Length-i-1; j++)
//	{
//		if (array[j] > array[j + 1])
//		{
//			int temp = array[j];
//			array[j] = array[j + 1];
//			array[j + 1] = temp;
//		}
//	}
//	Console.WriteLine(array[i]);
//}
#endregion
#region ededlerden cutlerin hasilinin tapilmasi
//int[] arr = { 34, 31, 23, 55, 38, 42, 46 };
//int sum = 1;
//for (int i = 0; i < arr.Length;i++)
//{
//	if (arr[i]%2==0)
//	{
//		sum *= arr[i];	
//	}
//}
//Console.WriteLine(sum);
#endregion
#region ededlerin artan sira ile duzulmesi
//int[] number = { 34, 31, 23, 55, 38, 42, 46 };
//for (int i = 0; i < number.Length - 1; i++)
//{
//	for (int j = 0; j < number.Length-i-1; j++)
//	{
//		if (number[j] > number[j + 1]) 
//		{
//			int temp = number[j];
//			number[j] = number[j + 1];
//			number[j + 1] = temp;
//		}
//	}
//	Console.WriteLine(number[i]);
//}
#endregion
#region imtahan qiymetlerinin daxil olunmasi
//Console.WriteLine("Imtahan qiymetinizi daxil edin");
//int number = int.Parse(Console.ReadLine());
//if (number >= 91 && number <= 100)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:A");
//}
//else if (number >= 81 && number <= 90)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:B");
//}
//else if (number >= 71 && number <= 80)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:C");
//}
//else if (number >= 61 && number <= 70)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:D");
//}
//else if (number >= 51 && number <= 60)
//{
//    Console.WriteLine("Imtahan Qiymetiniz:E");
//}
//else if (number <= 51)
//{
//    Console.WriteLine("Imtahandan Kesildiniz");
//}
//Console.WriteLine(number);
#endregion
#region 3e ve 7e bolunme elameti
//int num = 63;
//if (num % 3 == 0 && num % 7 == 0)
//{
//    Console.WriteLine("bolunur");
//}
//else
//{
//    Console.WriteLine("bolunmur");
//}
#endregion
#region en boyuk ededi tapmaq
//int[] arr = { 2, 5, 9, 34, 75, 13312, 436, 213 };
//int biggest = arr[0];
//for (int i = 0;i < arr.Length; i++)
//{
//    if (arr[i] > biggest)
//    {
//        biggest= arr[i];
//    }
//}
//Console.WriteLine(biggest);
#endregion
#region n ededin arrayda olmasini gostermek
//int[] arr = { 3, 6, 1, 7, 9, 2 };
//bool status = false;
//for (int i = 0; i < arr.Length; i++)
//{
//	if (arr[i] == 7)
//	{
//	status=true;
//	}
//}
//Console.WriteLine(status);
#endregion
#region a+b
//int a = 10;
//int b = 29;
//Console.Write(a+=b);
#endregion
#region 2 ededin kvadratlari cemi
//int num1, num2;
//int sum = 0;
//Console.Write("1.Sayiyi Giriniz = ");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("2.Sayiyi Giriniz = ");
//num2 = Convert.ToInt32(Console.ReadLine());
//sum =(num1*num1) + (num2*num2);
//Console.Write("sum="+sum);
//Console.ReadLine();
#endregion
#region positive and negative
//int[] arr = { 2, 3, -9, 8, -10, 12, 35, -20 };
//int p = 0;
//int f = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > 0)
//    {
//        p++;
//    }
//    else
//    {
//        f++;
//    }
//}
//Console.WriteLine(p + "Positive");
//Console.WriteLine(f + "Negative");
#endregion
#region reverse elemek
//string Test = "Hello World";
//string reverse = "";
//for (int i = Test.Length-1; i >= 0; i--)
//{
//	reverse+= Test[i];
//}
//Console.WriteLine(reverse);
#endregion
#region reverse elemek
//string Test = "Hello World";
//string[] reverse = Test.Split(' ');
//string result = string.Empty;
//foreach (var item in Test)
//{
//    for (int i = Test.Length - 1; i >= 0; i--)
//    {
//        result += Test[i];
//    }
//    result += " ";
//}
//Console.WriteLine(result);
#endregion
#region cut ededlerin ededi ortasi
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int even = 0;
//int count = 0;
//for (int i = 0;i < arr.Length; i++)
//{
//	if (arr[i]%2==0)
//	{
//        even += arr[i];
//        count++;
//    }
//}
//Console.WriteLine(even /= count);
#endregion
#region faktorial tapmaq
//int number = 5;
//int factorial = 1;
//for (int i = 1; i <= number; i++)
//{
//    factorial *= i;
//}
//Console.WriteLine(factorial);
#endregion
#region murekkeb ededlerin cemi
//int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 15, 16, 18, 19 };
//int result = 0;
//for (int i = 0; i < array.Length; i++)
//{
//	for (int j = 2; j < array[i]; j++)
//	{
//		if (array[i] % j == 0)  
//		{
//			result += array[i];
//			break;
//		}
//	}
//}
//Console.WriteLine(result);
#endregion
#region mail ve password
//Console.WriteLine("mail daxil edin");
//string mail = Console.ReadLine();
//Console.WriteLine("password daxil edin");
//string password = Console.ReadLine();
//if (mail == "cavid@code.edu.az" && password == "12345")
//{
//    Console.WriteLine("Giris olundu");
//}
//else
//{
//    Console.WriteLine("Mail ve yaxud password sehvdir");
//}
#endregion
#region atm
//Console.WriteLine("Select operation");
//int choose = int.Parse(Console.ReadLine());
//int balance = 1000;
//if (choose == 1)
//{
//    balance = 1000;
//    Console.WriteLine("Balance:" + balance);
//}
//else if (choose == 2)
//{
//    Console.WriteLine("Select number to plus");
//    int plus = int.Parse(Console.ReadLine());
//    balance += plus;
//    Console.WriteLine("Result:");
//}
//else if (choose == 3)
//{
//    Console.WriteLine("Select number to minus");
//    int minus = int.Parse(Console.ReadLine());
//    if (minus > balance)
//    {
//        Console.WriteLine("Result:you don't have enough money");
//    }
//    else
//    {
//        balance -= minus;
//        Console.WriteLine("Result:");

//    }
//}
//Console.WriteLine("Current Balance:" + balance);
#endregion
#region iki ededin kvadratlari cemi
//Console.WriteLine("1ci ededi daxil edin:");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("2ci ededi daxil edin:");
//int num2 = int.Parse(Console.ReadLine());
//int result = 0;
//if (num1 % 2 == 0 || num1 % 2 == 1) 
//{
//    num1 = num1 * num1;
//}
//if (num2 %2 == 0 || num2 %2 == 1)
//{
//    num2 = num2 * num2;
//}
//Console.WriteLine(result = num1 * num2);
#endregion
#region factorial tapmaq
//Console.WriteLine("eded daxil edin");
//int number = int.Parse(Console.ReadLine());
//int factorial = 1;
//for (int i = 1; i <= number; i++)
//{
//    factorial *= i;

//}
//Console.WriteLine(factorial);
#endregion
#region arrayin icinde olub olmama(metod)
//int[] array = { 1, 2, 3, 4, 5, 6, 7 };
//int num = 8;
//Search(array, num);
//void Search(int[] array, int num)
//{
//    bool status = false;
//    foreach (var item in array)
//    {
//        if (item == num)
//        {
//            status = true;
//            break;
//        }
//    }
//    if (status)
//    {
//        Console.WriteLine("verilmis ededin arrayin icinde var");
//    }
//    else
//    {
//        Console.WriteLine("verilmis eded arrayin icinde yoxdur");
//    }
//}


#endregion
#region kublarin arrayda olmasi
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//for (int i = 0; i < array.Length; i++)
//{
//	array[i] *= array[i];
//	if (array[i] < array[array.Length - 1])
//	{
//		Console.WriteLine(array[i]);
//	}
//}
#endregion

using System.Text.RegularExpressions;


Console.WriteLine("User Name daxil edin");
string UserName = Console.ReadLine();
Console.WriteLine("Password daxil edin");
string Password= Console.ReadLine();
User user = new User(UserName,Password);

if (user.Password != null && user.UserName != null)
{
    Console.WriteLine("Dogrudur");
}
else
{
    Console.WriteLine("Yanlisdir");
}
