namespace FamilyTreeOOP
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public string MomName { get; set; } = string.Empty;
        public string DadName { get; set; } = string.Empty;
        public string PartnerName { get; set; } = string.Empty;
        public List<string> Siblings { get; set; } = new List<string>();
        public List<string> Childs { get; set; } = new List<string>();

        public Person(string name, string momName, string dadName)
        {
            Name = name;
            MomName = momName;
            DadName = dadName;
        }

        public void SetPartner(string partnerName)
        {
            PartnerName = partnerName;
        }

        public void AddSiblings(string sibling)
        {
            Siblings.Add(sibling);
        }

        public void AddChildren(string child)
        {
            if (string.IsNullOrWhiteSpace(PartnerName))
            {
                throw new InvalidOperationException("Partner adı belirtilmeden çocuklar eklenemez.");
            }

            Childs.Add(child);
        }

        public virtual void TurnToFamilyTree()
        {
            Console.WriteLine($"{Name}'s Family\n");
            Console.WriteLine($"{MomName} ─┬─ {DadName}");

            for (int i = 0; i < Siblings.Count; i++)
            {
                string parentPrefix = new string(' ', MomName.Length + 2);
                string parentConnector = (i == Siblings.Count) ? "" : "│└─";
                Console.WriteLine($"{parentPrefix}{parentConnector} {Siblings[i]}");
            }

            string prefix = new string(' ', MomName.Length + 2);
            string connector = "└──";
            string partnerStr = string.IsNullOrWhiteSpace(PartnerName) ? "" : (Childs.Count == 0 ? " ─── " : $" ─┬─ ");
            Console.WriteLine($"{prefix}{connector} {Name}{partnerStr}{PartnerName}");

            for (int i = 0; i < Childs.Count; i++)
            {
                string childPrefix = new string(' ', MomName.Length + Name.Length + 8);
                string childConnector = (i == Childs.Count - 1) ? "└──" : "│└─";
                Console.WriteLine($"{childPrefix}{childConnector} {Childs[i]}");
            }

            Console.WriteLine("\n");
        }
    }
}
