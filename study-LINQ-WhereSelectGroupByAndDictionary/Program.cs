using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_LINQ_WhereSelectGroupByAndDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "Первое",
                "Второе",
                "Второе"
            };

            //=============  WHERE ========== \\

            //without 
            string str = "";
            var newlist = new List<string>();
            foreach (var item in list)
            {
                if(item.Contains("П"))
                    newlist.Add(item);
            }

            str = string.Join(" ",newlist);
            Console.WriteLine(str); //Первое

            //with him

            var listTwo = list.Where(c => c.Contains("П"));
            Console.WriteLine(string.Join("", listTwo));//Первое


            //                      Select

            var newlistSelect = list.Select(x => x.Contains("П")); //Do U have 'П'??           
            Console.WriteLine(string.Join(" ", newlistSelect)); //True False 

            var newlistSelectTwo = list.Select(x => x + 1);
            Console.WriteLine(string.Join(" ", newlistSelectTwo)); //add number

            //                      OrderBy   sorted* 
            var newlistOrderBy = list.OrderBy(x => x).ThenBy(x => x.Contains("В"));
            Console.WriteLine(string.Join (" ", newlistOrderBy)); // Второе Первое

            //                      GroupBy

            var newlistGroupBy = list.GroupBy(q => q).Where(q => q.Count() > 1).Select(g => g.Key);
            Console.WriteLine(string.Join(" ", newlistGroupBy));    
        }
    }
}
