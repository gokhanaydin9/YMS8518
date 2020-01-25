using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ZarAtma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("Kaç kullanıcı zar atacak:");
            zarAtanSayisi = Convert.ToInt32(Console.ReadLine());

            new Thread(Referee).Start();

            for(int sayac = 1; sayac <= zarAtanSayisi; sayac++)
            {

                new Thread(Roll).Start(sayac);

            var rollstat = new RollStat()
            {
                Id = sayac,
                Value = 0,
                Count = 0
            };

               rollStats.Add(rollstat);

            }

        }

        public class RollStat
        {
            public int Id { get; set; }
            public int Count { get; set; }
            public int Value { get; set; }
        }

        private static bool CancelThreads = false;
        private static Random _random = new Random();
        private static List<RollStat> rollStats = new List<RollStat>();       
        private static int zarAtanSayisi;


        private static void Roll( object id)
        {
            while (true)
            {
                if (CancelThreads)
                {
                    break;
                }

                var selfStat = rollStats.Single(a => a.Id == (int)id);

                if (selfStat.Count < rollStats.OrderByDescending(a => a.Count).First().Count
                    || rollStats.Count(a => a.Count == selfStat.Count) == zarAtanSayisi)
                {

                    int result = _random.Next(1, 10);
                    selfStat.Count++;
                    selfStat.Value += result;

                }

               
                Thread.Sleep(1000);
            }            
        
        }

        private static void Referee()
        {
            int turn = 0;

            while (true)
            {
                if(rollStats.Count(a => a.Count == turn) == zarAtanSayisi)
                {

                    string stats = string.Empty;

                foreach(RollStat rollStat in rollStats)
                {
                    stats += rollStat.Id + " : " + rollStat.Value + "|";
                }

                    Console.WriteLine(stats);

                    if(rollStats.Any(a => a.Value >= 100))
                    {
                        CancelThreads = true;
                        Console.WriteLine("kazanan belli oldu");
                    }



                    turn++;

                }            
                

            }

        }
    }
}
