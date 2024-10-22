namespace Propertys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new('@', 5, 5);
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.Write(player.Symbol);
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
}
