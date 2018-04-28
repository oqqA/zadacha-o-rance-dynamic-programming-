using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
   class Predmet
   {
      public string Name { get; set; }
      public int W { get; set; }
      public int C { get; set; }
      public bool V { get; set; }

      public Predmet(String name, int w, int c)
      {
         Name = name;
         W = w;
         C = c;
      }
   }
}
