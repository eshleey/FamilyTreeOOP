namespace FamilyTreeOOP
{
    internal class Identity : Person
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public char Gender { get; set; }
        public string Country { get; set; }
        public bool? IsMarried { get; set; }

        public Identity(int id, string name, string surname, string momName, string dadName, char gender, string country) : base(name, momName, dadName)
        {
            Id = id;
            Surname = surname;
            Gender = gender;
            Country = country;
        }

        public Identity(int id, string name, string surname, string momName, string dadName, char gender, string country, bool? isMarried) : base(name, momName, dadName)
        {
            Id = id;
            Surname = surname;
            Gender = gender;
            Country = country;
            IsMarried = isMarried;
        }

        public override void TurnToFamilyTree()
        {
            Console.WriteLine($"{Name} Family Tree\n\n{MomName} ─┬─ {DadName}");
            string prefix = new string(' ', MomName.Length);
            Console.WriteLine($"{prefix}{Name}\n");
        }

        public void Print()
        {
            Console.WriteLine($"{Name} Identity Information\n");
            Console.WriteLine($"ID: {Id}\nName: {Name}\nSurname: {Surname}\nMom Name: {MomName}\nDad Name: {DadName}\nGender: {Gender}\nCountry: {Country}");
            if (IsMarried != null)
            {
                Console.WriteLine($"Is Married: {IsMarried}");
            }
            Console.WriteLine("\n");
        }
    }
}
