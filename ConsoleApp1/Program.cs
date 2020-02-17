using System;
using System.Linq;

namespace GetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataModels.FIRSTDB())

            {
                var q =
                    from c in db.Departments
                    select c;

                foreach (var c in q)
                    Console.WriteLine(c.ID);
            }
        }
    }
}