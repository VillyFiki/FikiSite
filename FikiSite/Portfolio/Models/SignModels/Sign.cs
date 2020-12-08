using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FikiSite.Models.SignModels
{
    public class Sign
    {
        public string Name { get; set; }
        public string Text { get; set; }


        public static List<Sign> Shuffle(List<Sign> list)
        {
            Random rand = new Random();
            List<Sign> listResult = new List<Sign>();

            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                Sign tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
            return list;
        }
    }
}
