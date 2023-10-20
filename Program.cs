using System.Runtime.Intrinsics.X86;
using Raylib_cs;

Raylib.InitWindow(1200, 600, "Slagsmålsspelet II: Electric Boogaloo");
Raylib.SetTargetFPS(30);

Person p1 = new Person("Erik. A");
p1.AddWeapon(new Weapon("Svärd", 3));
Person p2 = new Person("Frej", 80);
p2.AddWeapon(new Weapon("Yxa", 5));
List<Person> personList = new(){p1, p2};

while (!Raylib.WindowShouldClose())
{
    if (p1.isAlive() && p2.isAlive())
    {
        FightLoop();
    }
}

void FightLoop()
{
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
    {
        Console.WriteLine("Attacking");
        p1.Hurt(p2.Attack());
        p2.Hurt(p1.Attack());
    }
    DrawFight();
}

void DrawFight()
{
    Raylib.ClearBackground(Color.BEIGE);
    Raylib.BeginDrawing();
    p1.Draw(256, Raylib.GetScreenHeight()/2, Color.RED);
    p2.Draw(Raylib.GetScreenWidth()-256, Raylib.GetScreenHeight()/2, Color.BLUE, -1);
    DrawStats();
    Raylib.EndDrawing();
}

void DrawStats()
{
    int posX = 256;
    foreach (Person p in personList)
    {
        Raylib.DrawText($"{p.GetHealth().ToString()} HP", posX, (Raylib.GetScreenHeight()/5), 32, Color.BLACK);
        
        int posY = (Raylib.GetScreenHeight()/10)*8;
        foreach (Weapon w in p.weapons)
        {
            Raylib.DrawText(w.GetStats(), posX-192, posY, 20, Color.BLACK);
            posY += 64;
        }
        
        
        posX = Raylib.GetScreenWidth() - 256;
    }
}