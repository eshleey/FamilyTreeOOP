# FamilyTreeOOP
- An object-oriented family tree and identity system modeling parent-sibling-child-partner relationships using inheritance and custom printing logic.  
- A system that turns your name and the names of your family members into a family tree or where you can see your own identification information.

## Family Tree System
- You must provide your own name, your mother's name and your father's name to the system to create a basic family tree.  
- If you have siblings, you can add their names to the family tree using the `AddSibling` method.  
- If you have partner, you can set his/her name to the family tree using the `SetPartner` method.  
- If you have childs, you can add their names to the family tree using the `AddChild` method. However, this method will fail if you don't have a partner in the family tree.

### Example
```csharp
Person person = new Person("Alex", "Mary", "Bob");
person.SetPartner("Steven");

person.AddChildren("David");
person.AddChildren("Susan");
person.AddChildren("Elise");

person.AddSiblings("Tom");
person.AddSiblings("Tinny");
person.AddSiblings("Joseph");

person.TurnToFamilyTree();
```
### Output
```
Alex's Family

Mary ─┬─ Bob
      │└─ Tom
      │└─ Tinny
      │└─ Joseph
      └── Alex ─┬─ Steven
                │└─ David
                │└─ Susan
                └── Elise
```

## Identity System
- When you enter your own ID, name, surname, mother's name, father's name, gender, where you are from and your marital status; this information creates a small family tree consisting of only your name, mother's name and father's name and allows you to see your identity information.  
- You don't have to specify your marital status in this system. But you must specify your other information.

### Example
```csharp
Identity identity = new Identity(0001, "Alex", "Golden", "Mary", "Bob", 'G', "Newyork");

identity.TurnToFamilyTree();
identity.Print();
```
### Output
```
Alex Family Tree

Mary ─┬─ Bob
    Alex

Alex Identity Information

ID: 1
Name: Alex
Surname: Golden
Mom Name: Mary
Dad Name: Bob
Gender: G
Country: Newyork
```
