using System.Collections;
using System.Collections.Generic;

namespace CollectionClassConcept
{
  public class CollectionClass
  {
    private string _parameter;

    public CollectionClass(string parameter)
    {
      _parameter = parameter;
    }
    public IEnumerator GetEnumerator()
    {
      return new CollectionEnumerator(_parameter);
    }
  }
}
