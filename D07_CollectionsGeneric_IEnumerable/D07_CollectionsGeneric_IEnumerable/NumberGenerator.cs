using System.Collections.Generic;

namespace D07_CollectionsGeneric_IEnumerable
{

    internal class NumberGenerator
    {

        public IEnumerable<int> GetNumbers_IEnumerable(int max)
        {

            for (int i = 0; i <= max; i++)
            {
                
                yield return i; // não necessito de guardar o valor uma vez que tenho o iterador

            }

        }

        public IList<int> GetNumbers_IList(int max)
        {

            IList<int> numbers = new List<int>();
            
            for (int i = 0; i <= max; i++)
            {
            
                numbers.Add(i); // sou 'obrigada' a criar uma coleção para reter o valor

            }

            return numbers;

        }

    }

}
