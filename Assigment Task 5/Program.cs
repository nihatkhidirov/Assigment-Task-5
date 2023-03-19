using System.Text.RegularExpressions;

namespace Assigment_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int eded = 0;
            //for(int i =1; i<1000;i++)
            //{
            //    eded = eded + i;        
            //}
            //if(eded%7==0)
            //{
            //    Console.WriteLine("Ededlerin Cemi 7 ye bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("Ededlerin Cemi 7 ye bolunmur");
            //}
            #endregion
            #region Task2
            //for (int i=1; i < 1000; i++)
            //{
            //    if(i%7==0 && i%8==0)
            //    {
            //        Console.WriteLine($"Hem 7-ye Hem de 8-e Bolunenler {i}");
            //    }    
            //}
            #endregion
            #region Task3
            //for(int i=1;i<1000;i++)
            //  {
            //     if(i%3==0)
            //      {
            //          Console.WriteLine(i);
            //      }
            //  }
            #endregion
            #region Task4
            //int eded;
            //for (int i = 1; i < 1000; i++)
            //{
            //    eded =i%10;

            //    if (i % 3 == 0 && eded!=3)
            //    {   
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task5
            //int eded;
            //int cem;

            //for (int i = 1; i < 1000; i++)
            //{
            //    cem = 0;
            //    eded = i;

            //    while (eded > 0)
            //    {
            //        int qaliq = eded % 10;
            //        eded /= 10;
            //        cem = cem + qaliq;
            //    }
            //        if (i % 5 == 0 && cem % 5 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //}
            #endregion
            #region Task6
            //1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
            //hem ozu cut eded olsun,
            // hem reqemleri cemi tek eded olsun,
            //hem I reqemi tek eded olsun

            //for(int i=1;i<1000;i++)
            //{
            //    int eded = i;
            //    int cem = 0;
            //    int firstdigit = i / 100;
            //    while(eded>0)
            //    {
            //        int qaliq = eded % 10;
            //        eded /= 10; ;
            //        cem = cem + qaliq;

            //    }
            //    if (i % 2 == 0 && cem % 2 == 1 && firstdigit%2==1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task7
            //for(int i=1;i<1000; i++)
            //{
            //    int lastdigit = i % 10;
            //    int fisrdigit = i / 100;
            //    int mediumdigit = i / 10;
            //    int mediumdigitqaliq = mediumdigit % 10;
            //    if(lastdigit!=3 &&fisrdigit!=3 &&mediumdigitqaliq!=3)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task8
            //for (int i = 1; i < 1000; i++)
            //{
            //    int birincireqem = i / 100;
            //    int ortareqemesas = i / 10;
            //    int ortareqem1 = ortareqemesas % 10;
            //    int axirincireqem = i % 10;
            //    int eded = i;
            //    int cem = 0;
            //    while (eded > 0)
            //    {
            //        int qaliq = eded % 10;
            //        eded /= 10;
            //        cem = cem + qaliq;
            //    }
            //    if (birincireqem != 3 && ortareqem1 != 3 && axirincireqem != 3 && cem == 3)
            //    {
            //        Console.WriteLine(i);
            //    }
            #endregion
            #region Task9
            //int count = 0;
            //for (int i = 1; i < 1000; i++)
            //{
            //    int cem = 0;
            //    int eded = i;
            //    while (eded > 0)
            //    {
            //        int qaliq = eded % 10;
            //        eded = eded / 10;
            //        cem = cem + qaliq;

            //    }
            //    if (i % 11 == 0 && cem > 11)
            //    {
            //        count++;

            //        if (count == 11)
            //        {
            //            Console.WriteLine($"11-ci Eded: {i}");
            //            break;
            //        }
            //    }

            //}

            #endregion
            #region Task10
            //1 - 1000 qeder CUT ededlerin icerisinde
            //reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
            //int count = 0;
            //int max = -1;
            //for (int i = 1; i < 1000; i++)
            //{

            //    int cem = 0;
            //    int eded = i;
            //    int qaliq;
            //    while (eded > 0)
            //    {
            //        qaliq = eded % 10;
            //        eded /= 10;
            //        cem = cem + qaliq;

            //    }
            //    if (i % 2 == 0 && cem >= 5 && cem <= 7)
            //    {
            //        if (i > max)
            //        {
            //            max = i;
            //        }
            //    }

            //}
            //if(max==-1)
            //    {
            //        Console.WriteLine("Tapilmadi");
            //    }
            //    else
            //        Console.WriteLine(max);
            #endregion
            #region Task11
            //int sum, digit, temp, digitsum;
            //for (int i = 1; i < 1000; i++)
            //{
            //l1:
            //    sum = 0;
            //    digitsum = 0;
            //    temp = i;
            //    while (temp > 0)
            //    {
            //        digit = temp % 10;
            //        if (digit == 3)
            //        {
            //            i++;
            //            goto l1;
            //        }

            //        digitsum = digitsum + digit;
            //        sum = sum * 10 + digit;
            //        temp = temp / 10;

            //    }
            //    if (i == sum && digitsum > 10)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

            #endregion        }
            #region Task12
            //for (int i = 1; i < 100000; i++)
            //{
            //    int temp = i;
            //    int digit = temp % 10;
            //    int temp1 = temp / 10;
            //    while(temp1>0 && temp1%10==digit)
            //    {
            //        temp1 /= 10;
            //    }
            //    if(temp1 ==0)
            //    {
            //        int number2 = i;
            //        if(number2%10==5)
            //        {
            //            continue;
            //        }

            //        int sum = 0;

            //        while(number2>0)
            //        {
            //            sum += number2 % 10;
            //            number2 /= 10;
            //        }
            //        if(sum>5)
            //        {
            //            Console.WriteLine(i);
            //        }    
            //    }

            //}
            #endregion
            #region Task13
            //int sum, digit, temp, digitsum;
            //for (int i = 1; i < 100000; i++)
            //{
            //l1:
            //    sum = 0;
            //    digitsum = 0;
            //    temp = i;
            //    while (temp > 0)
            //    {
            //        digit = temp % 10;
            //        if (digit % 2 == 0)
            //        {
            //            i++;
            //            goto l1;
            //        }

            //        sum = sum * 10 + digit;
            //        temp = temp / 10;

            //    }
            //    int temp1 = temp;

            //    while (temp1 > 0)
            //    {
            //        int digit1 = temp1 % 10;
            //        temp1 = temp1 / 10;
            //        if (digit1 != 5)
            //        {
            //            i++;
            //            continue;
            //        }

            //    }

            //}
            #endregion
            #region Task14
            //int eded1, qaliq, counter, cem, eded2, counter1;
            //for(int i=1;i<100000;i++)
            //{
            //    counter1 = 0;
            //    counter = 0;
            //    qaliq = i % 10;
            //    eded1 = i;
            //    while(eded1>0)
            //    {
            //        if(eded1%10==6)
            //        {
            //            break;
            //        }
            //        if(eded1%100==11)
            //        {
            //            counter1 = 2;
            //        }
            //        if(eded1%10==5)
            //        {
            //            counter++;
            //        }
            //        eded1 /= 10;
            //    }
            //    if(counter1==2 && counter1==2)
            //    {
            //        eded2 = i;
            //        cem = 0;
            //        while(eded2>0)
            //        {
            //            cem += eded2 % 10;
            //            eded2 /= 10;

            //        }
            //        if(cem>7 && cem<15)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }

            //}
            #endregion
            #region Task15
            //int temp, digit, sum;
            //int[] exclude = { 0, 1, 5, 7, 9 };
            //for (int i = 1; i <= 10000; i++)
            //{
            //l1:
            //    sum = 0;
            //    if (i % 2 == 0 || (i % 3 == 0 && i != 3) || i % 5 == 0 || i % 7 == 0)
            //    {
            //        continue;

            //    }
            //    temp = i;
            //    while (temp > 0)
            //    {

            //        digit = temp % 10;
            //        if (Array.IndexOf(exclude, digit) != -1)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        sum += digit;
            //        temp /= 10;

            //    }
            //    while (sum > 0)
            //    {
            //        digit = sum % 10;

            //        if (digit == 2)
            //        {
            //            i++;
            //            goto l1;

            //        }
            //        sum /= 10;
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
        }
    } 
}