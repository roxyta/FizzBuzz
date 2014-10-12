using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using fizzBuzz;


namespace fizzBuzzTest
{
  public  class FizzBuzzTestt
    {
      //evalua cualquier numero

      [Test]
      public void NumerosaEvaluar()
      {
          var numero = new Numeros();
          var tipo = numero.tipo(99);
          Assert.AreEqual("Fizz", tipo);
      }


    
      /*Evaluacion de numero por cada tipo

      [Test]
      public void TestMultiploDeTres()
      {
          var numero = new Numeros();
          var tipo = numero.tipo(99);
          Assert.AreEqual("Fizz", tipo);

      }

      [Test]
      public void TestMultiploDeCinco()
      {
          var numero = new Numeros();
          var tipo = numero.tipo(100);
          Assert.AreEqual("Buzz", tipo);

      }


      [Test]
      public void TestGuarismos()
      {
          var numero = new Numeros();
          var tipo = numero.tipo(15);
          Assert.AreEqual("FizzBuzz", tipo);

      }
      [Test]
      public void TestOtroNumero()
      {
          var numero = new Numeros();
          var tipo = numero.tipo(4);
          Assert.AreEqual("4", tipo);

      }

      */

    }
}
