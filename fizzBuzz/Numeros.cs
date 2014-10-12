using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
  public  class Numeros
    {
      public string tipo(int num)
      {
          var res = "";

          for (var i = 0; i < num; i++)
          {
              if (num % 5 == 0 & num % 3 == 0)
              {
                  res = "FizzBuzz";
              }
              else if (num % 3 == 0)
              {
                  res = "Fizz";
              }
              else if (num % 5 == 0)
              {
                  res = "Buzz";
              }
              else
              {
                  res = num.ToString();
              }
          }


          return res;
      }

    }
}
