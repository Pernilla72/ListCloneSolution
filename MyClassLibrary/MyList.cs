using System.Collections;
using System.Security.Cryptography;

namespace MyClassLibrary;
// * Skapa en valfri klass i MyApp. Låt klassen få två till fyra egenskaper.
// * Skapa en instans av MyList med din klass. Exempelvis MyList<Car> cars = new();
// * Lägg till minst 5 element i MyList med hjälp av metoden Add.
// * Anropa metoden Sort med en namngiven metod som sorterar elementen i listan på valfri egenskap.
// * Gör om den namngivna metoden till ett Lambda-uttryck och kontrollera att
//   sorteringen fungerar på samma sätt som med den namngivna metoden. 

public class MyList<T> : IEnumerable<T>
{
    T[] collection;

    public int Count { get; set; } = 0;

    public MyList() : this(3)
    {
    }

    public MyList(int capacity)
    {
        collection = new T[capacity];
    }


    public void Add(T item)
    {

        if (Count == collection.Length)
        {
            T[] temp = new T[collection.Length *2];
            for (int i = 0; i < collection.Length; i++)
            {
                temp[i] = collection[i];
            }
            collection = temp;
        }
        collection[Count] = item;
        Count++;
    }
    //Nedan ser man en XML-kommentar som visas i VS
    /// <summary>
    /// Ska jämföra det första elementet med det andra. Om det första Elementet kommer före det andra i sorteringsordnignen, ska det returnera true, annars false
    /// </summary>
    /// <param name="SortFruit">Som man också kan kommentera</param>
    public void Sort(Func<T, T, int>SortFruit)
    { 
        for (int i = 0; i < Count; i++)
        {
            int lowValue = i;

            for (int j = i+1; j < Count; j++)
            {
                if (SortFruit(collection[j], collection[lowValue]) <0) 
                    lowValue = j;
            }
            if (lowValue != i)
            {
                T temp = collection[lowValue];
                collection[lowValue] = collection[i]; 
                collection[i] = temp;
            }
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return collection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return collection[i];
        }
    }
}
