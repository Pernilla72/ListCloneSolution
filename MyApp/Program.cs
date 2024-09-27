using MyClassLibrary;

namespace MyApp;
public class Program
{
    static void Main(string[] args)
    {
        //MyList<int> list = new();
        //list.Add(1962);
        //list.Add(2026);
        //list.Add(2024);
        //list.Add(1945);

        //foreach (int year in list)
        //{
        //    Console.WriteLine(year);
        //}


        MyList<Fruit> fruits = new();

        fruits.Add(new Fruit("Apple", "Red", true));
        fruits.Add(new Fruit("Banana", "Yellow", false));
        fruits.Add(new Fruit("Orange", "Orange", false));
        fruits.Add(new Fruit("Pear", "Green", false));
        fruits.Add(new Fruit("Grapes", "Purple", true));



        foreach (var fruit in fruits)
        {
            if (fruit.IsRipe == true)
            {
                Console.WriteLine($" Today {fruit.Name} are ripe");
            }
        }

        //Här är Lambdauttrycket plaverat direkt inne i metodanropet
        fruits.Sort((Fruit fruitA, Fruit fruitB) =>

        // ? betyder: Tenär operator enligt syntax:
        // condition                    ?  resultIfTrue : resultIfFalse;
        fruitA.IsRipe && !fruitB.IsRipe ? -1 :
        fruitA.IsRipe && fruitB.IsRipe ? 1 :
        string.Compare(fruitA.Colour, fruitB.Colour) != 0 ? string.Compare(fruitA.Colour, fruitB.Colour) :
        string.Compare(fruitA.Name, fruitB.Name));


        //Metodanropet
        //fruits.Sort(SortFruit);
        //foreach (var fruit in fruits)
        //{
        //    Console.WriteLine($"{fruit.Name}, {fruit.Colour} is Ripe: {fruit.IsRipe}\n ");
        //}




        //static int SortFruit(Fruit fruitA, Fruit fruitB)
        //{
        //    if (fruitA.IsRipe && !fruitB.IsRipe)  // Jämför om frukterna är mogna
        //    {
        //        return -1;
        //    }
        //    else if (fruitA.IsRipe && fruitB.IsRipe)
        //    {
        //        return 1;                           // Frukt B kommer före
        //    }
        //    else
        //    {               // Om båda har samma mognadsgrad, sortera på färger
        //        int AlphabeticColour = string.Compare(fruitA.Colour, fruitB.Colour);

        //        if (AlphabeticColour != 0)
        //        {
        //            return AlphabeticColour;
        //        }
        //        else
        //        {
        //            return string.Compare(fruitA.Name, fruitB.Name);
        //        }
        //    }
        //}

        //Metoden ovan ersatt av Lambdauttryck: 

        static int SortFruit(Fruit fruitA, Fruit fruitB) =>
        fruitA.IsRipe && !fruitB.IsRipe ? -1 :  // Jämför om en av frukterna är mogen

        fruitA.IsRipe && fruitB.IsRipe ? 1 :    // Jämför om båda frukterna är mogna

        // Om båda har samma mognadsgrad, sortera på färger
        string.Compare(fruitA.Colour, fruitB.Colour) != 0 ? string.Compare(fruitA.Colour, fruitB.Colour) :

        string.Compare(fruitA.Name, fruitB.Name);    // sista sorteras de i alfabetisk ordning





        //list.Sort((a, b) => a < b);  //Ersatt nedan metod med ett Lambdauttryck

        //list.Sort(Compare);

        //static bool Compare(int a, int b)
        //{
        //return a < b;
        //}
        //list.Sort(FirstIntIsLessThanSecondInt);
        //}
        //static bool FirstIntIsLessThanSecondInt(int a, int b) => a < b;

    }
}

