using Raylib_cs;

Raylib.InitWindow(1200, 600, "Slagsmålsspelet II: Electric Boogaloo");
Raylib.SetTargetFPS(30);

Person p1 = new Person("Erik. A");
p1.AddWeapon(new Weapon("Svärd", 3));
Person p2 = new Person("Frej", 80);
p2.AddWeapon(new Weapon("Yxa", 5));

while (!Raylib.WindowShouldClose())
{
    if (p1.isAlive() && p2.isAlive())
    {
        FightLoop();
    }
}

void FightLoop()
{
    DrawFight();
}

void DrawFight()
{
    Raylib.ClearBackground(Color.BEIGE);
    Raylib.BeginDrawing();
    p1.Draw(256, Raylib.GetScreenHeight()/2, Color.RED);
    p2.Draw(Raylib.GetScreenWidth()-256, Raylib.GetScreenHeight()/2, Color.BLUE, -1);
    Raylib.EndDrawing();
}

// void DrawStats()
// {
//     Raylib.DrawText(p1.)
// }