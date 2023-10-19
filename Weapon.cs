using System.Runtime.CompilerServices;

class Weapon
{
    string name;
    float baseDamage;
    float wear = 1;
    public Weapon(string newName, float newDamage)
    {
        name = newName;
        baseDamage = newDamage;
    }
    public float damage()
    {
        float d = baseDamage * wear;
        wear *= .8f;
        return d;
    }
}