using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05122022linq
{
    internal class Pohori
    {
        private string name;
        List<Hora> pohori = new List<Hora>();

        public Pohori(string name, string hory)
        {
            this.name = name;
            addfromstring(hory);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool addfromstring(String x)
        {
            String[] hold = x.Split(" • ");
            String[] h2 = null;
            List<string> returner_height = new List<string>();
            List<string> returner_name = new List<string>();
            string ss;
            foreach (String s in hold)
            {
                h2 = s.Split("(");
                returner_name.Add(h2[0]);
                Console.WriteLine(h2[0]);
                ss = h2[1].Replace("m", "");
                ss = ss.Replace(")", "");
                returner_height.Add(ss);
                Console.WriteLine(ss);
            }
            for (int i = 0; i < returner_name.Count; i++)
            {
                Console.WriteLine(returner_name[i] + ":" + returner_height[i]);
                Hora h = new Hora(returner_name[i].Replace(" ",""), int.Parse(returner_height[i].Replace(" ","")));
                pohori.Add(h);
            }
            return true;
        }

    }
}
