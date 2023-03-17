using System.Text.RegularExpressions;

namespace Assigment_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int eded = 0;
            //for(int i =0; i<1000;i++)
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
            //for (int i=0; i < 1000; i++)
            //{
            //    if(i%7==0 && i%8==0)
            //    {
            //        Console.WriteLine($"Hem 7-ye Hem de 8-e Bolunenler {i}");
            //    }    
            //}
            #endregion
            #region Task3
            //for(int i=0;i<1000;i++)
            //  {
            //     if(i%3==0)
            //      {
            //          Console.WriteLine(i);
            //      }
            //  }
            #endregion
            #region Task4
            //int eded;
            //for (int i = 0; i < 1000; i++)
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

            //for (int i = 0; i < 1000; i++)
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

            //for(int i=0;i<1000;i++)
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
            //for(int i=0;i<1000; i++)
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
            //for (int i = 0; i < 1000; i++)
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
            //for (int i = 0; i < 1000; i++)
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
            //for (int i = 0; i < 1000; i++)
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

            //1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
            // hem polindrom olsun,
            //hem ededin reqemleri daxilinde 3 olmasin
            //hem ededin reqemleri cemi 10 dan boyuk olsun
            

            for(int i=0;i<1000;i++)
            {
                int birinci = i / 100;
                int son = i % 10;
                int orta = i / 100;
                int orta1 = orta % 10;
                int cem = 0;

                int eded = i;
                while(eded>0)
                {
                    int qaliq = eded % 10;
                    eded /= 10;
                    cem = cem + qaliq;

                }
                int newnum = eded;
                int cem1 = 0;

                while(newnum>0)
                {
                    int qaliq1 = newnum % 10;
                    newnum /= 10;
                    cem1 = cem1*10+ qaliq1;
                }

                {
                    if (birinci != 3 && son != 3 && orta1 != 3 && cem > 10 && cem1 == eded)
                    {
                        Console.WriteLine(i);
                    }
                }
            }


        }
    }
}