using System;
using System.Security.AccessControl;

namespace CollectionClassConcept
{
  class Program
  {
    static void Main(string[] args)
    {
      CollectionClass collectionClass=new CollectionClass("We know what is a collection class.");
      foreach (string  collection in collectionClass)
      {
        Console.WriteLine(collection);
      }
      Console.ReadLine();
    }
  }
}
