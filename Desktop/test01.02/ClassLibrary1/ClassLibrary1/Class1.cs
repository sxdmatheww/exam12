using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public static class OrderAnalyzer
    {
        public static List<DateTime> GetPopularMonths(List<DateTime> orderDates)
        {
            var groupedDates = orderDates.GroupBy(date => new { date.Year, date.Month });

            var monthlyOrderCounts = groupedDates.Select(group => new { Month = group.Key, Count = group.Count() });

            
            var sortedMonths = monthlyOrderCounts.OrderByDescending(month => month.Count);

           
            var result = sortedMonths.Select(month => new DateTime(month.Month.Year, month.Month.Month, 1));

            return result.ToList();
        }
    }
    public class Class1
    {
        static void Main(string[] args)
        {
            List<DateTime> orderDates = new List<DateTime>()
            {
                new DateTime(2019, 12, 12, 14, 43, 0),
                new DateTime(2019, 12, 1, 15, 5, 0),
                new DateTime(2019, 11, 4, 9, 1, 0)
            };

            List<DateTime> popularMonths = OrderAnalyzer.GetPopularMonths(orderDates);

            Console.WriteLine("Самые популярные месяцы заказов:");
            foreach (var month in popularMonths)
            {
                Console.WriteLine(month.ToString("yyyy-MM-01 00:00"));
            }

            Console.ReadLine();
        }


    }
}
