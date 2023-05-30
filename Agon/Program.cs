using Raylib_cs;

namespace Agon
{
    static class Program
    {
        public static void Main()
        {
            Raylib.InitWindow(800, 480, "Hello World");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);



                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}