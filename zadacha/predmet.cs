using System;

namespace zadacha
{
   class Predmet
   {
      public string Name { get; set; }
      public int W { get; set; } // вес
      public int P { get; set; } // цена
      public bool V { get; set; }

      public Predmet(String name, int w, int p)
      {
         Name = name;
         W = w;
         P = p;
      }
   }
}
