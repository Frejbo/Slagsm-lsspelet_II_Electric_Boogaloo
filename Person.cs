using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

class Person
{
    public string name;
    private float health = 100;
    private Random rand = new();
    private float strengthMultiplier = 1;
    List<Weapon> weapons = new();
    int selectedWeapon = 0;
    Texture2D idle = Raylib.LoadTexture("C:/Users/Frej/Documents/Programmering/Slagsmålsspelet_II_Electric_Boogaloo/Assets/Enemy.png"); // TODO, lyckas inte med relativ path...

    public Person(string newName, int newHealth = 100)
    {
        name = newName;
        health = newHealth;
    }

    public float Attack()
    {
        float damage = weapons[selectedWeapon].damage() * strengthMultiplier;
        return (damage);
    }
    public void Hurt(float damage)
    {
        health -= damage;
    }
    public void AddWeapon(Weapon w)
    {
        weapons.Add(w);
    }
    public bool isAlive()
    {
        return health > 0;
    }
    public void Draw(int x, int y, Color color, int scaleX = 1) {
        Raylib.DrawTexturePro(
            idle,
            new Rectangle(0, 0, idle.width * scaleX, idle.height),
            new Rectangle(0, 0, idle.width, idle.height),
            new Vector2(-x+idle.width/2, -y+idle.height/2),
            0,
            color
        );
    }
}