public class inventory {
    public string types;
    public int Weight;
    public int Durability;
    public int Armor;

    public inventory(string type, int weight, int armor) {
        types = type;
        Weight = weight;
        Durability = 100;
        Armor = armor;
    }
}

