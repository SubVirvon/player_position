using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(10, 10);
            Renderer renderer = new Renderer();

            renderer.RenderPlayer(player.PositonX, player.PositonY);
        }
    }

    class Player
    {
        public int PositonX { get; private set; }
        public int PositonY { get; private set; }

        public Player (int positionX, int positionY)
        {
            PositonX = positionX;
            PositonY = positionY;
        }
    }

    class Renderer
    {
        public void RenderPlayer(int positionX, int positionY, char playerIcon = 'O')
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(playerIcon);
            Console.ReadKey(true);
        }
    }
}
