using FamilyTreeOOP;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alex's Family
            Person person1 = new Person("Alex", "Mary", "Bob");
            Identity identity1 = new Identity(0001, "Alex", "Golden", "Mary", "Bob", 'G', "Newyork");

            person1.SetPartner("Steven");

            person1.AddChildren("David");
            person1.AddChildren("Susan");
            person1.AddChildren("Elise");

            person1.AddSiblings("Tom");
            person1.AddSiblings("Tinny");
            person1.AddSiblings("Joseph");

            person1.TurnToFamilyTree();

            identity1.TurnToFamilyTree();
            identity1.Print();

            // David's Family
            Person person2 = new Person("David", "Alex", "Steven");
            Identity identity2 = new Identity(0002, "David", "Golden", "Alex", "Steven", 'B', "Los Angeles", false);

            person2.AddSiblings("Susan");
            person2.AddSiblings("Elise");

            person2.TurnToFamilyTree();

            identity2.TurnToFamilyTree();
            identity2.Print();

            /* Eşi olmadan çocuk eklenmeye çalışırsa hata veriyor.
            // Susan's Family
            Person person3 = new Person("Susan", "Alex", "Steven");

            person3.AddSiblings("David");
            person3.AddSiblings("Elise");

            person3.AddChildren("Kenny");

            person3.TurnToFamilyTree();
            */

            Person person4 = new Person("Tom", "Mary", "Bob");
            Identity identity4 = new Identity(0004, "Tom", "Anderson", "Mary", "Bob", 'B', "Texas", true);

            person4.SetPartner("Fiora");

            person4.AddSiblings("Alex");
            person4.AddSiblings("Tinny");
            person4.AddSiblings("Joseph");

            person4.TurnToFamilyTree();

            identity4.TurnToFamilyTree();
            identity4.Print();

            Console.ReadKey();
        }
    }
}