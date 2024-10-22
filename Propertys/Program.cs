namespace Propertys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new('@', 5, 5);
            Renderer renderer = new();
            renderer.DrawPlayer(player);
            Console.ReadKey();
        }
    }

    public class Player
    {
        public Player(char symbol, int positionX, int positionY)
        {
            Symbol = symbol;
            PositionX = positionX;
            PositionY = positionY;
        }

        public char Symbol { get; private set; }

        public int PositionX { get; private set; }

        public int PositionY { get; private set; }
    }

    public class Renderer
    {
        public void DrawPlayer(Player player)
        {
            Console.Clear();

            if (player.PositionX >= 0 && player.PositionY >= 0)
            {
                Console.SetCursorPosition(player.PositionX, player.PositionY);
                Console.Write(player.Symbol);
            }
        }
    }
}
