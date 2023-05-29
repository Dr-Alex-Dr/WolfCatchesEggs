using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfCatchesEggs.Properties;

namespace WolfCatchesEggs
{
    public class Egg
    {
        private static Sprite[,] Rails { get; set; } = new Sprite[4, 10];
        private static Random random = new Random();
        public int Step { get; set; } = -1; // шаг яйца 
        public static int MaxDelay = 6; // Максимальная задержка между появлением нового яйца
        public static int Delay = MaxDelay; // задержка между появлением нового яйца
        public int RailNumber { get; } // номер рельсы на которой будут появляться яйца

        static Egg()
        {
            // левая верхняя
            Rails[0, 0] = new Sprite(85, 192, Resources.egg1);
            Rails[0, 1] = new Sprite(122, 220, Resources.egg2);
            Rails[0, 2] = new Sprite(160, 238, Resources.egg3);
            Rails[0, 3] = new Sprite(190, 260, Resources.egg4);
            Rails[0, 4] = new Sprite(255, 322, Resources.egg5);
            Rails[0, 5] = new Sprite(146, 560, Resources.cheek1);
            Rails[0, 6] = new Sprite(126, 515, Resources.cheek2);
            Rails[0, 7] = new Sprite(83, 554, Resources.cheek3);
            Rails[0, 8] = new Sprite(36, 553, Resources.cheek4);
            Rails[0, 9] = new Sprite(0, 555, Resources.cheek5);

            Rails[1, 0] = new Sprite(85, 362, Resources.egg1);
            Rails[1, 1] = new Sprite(122, 390, Resources.egg2);
            Rails[1, 2] = new Sprite(160, 408, Resources.egg3);
            Rails[1, 3] = new Sprite(190, 430, Resources.egg4);
            Rails[1, 4] = new Sprite(255, 492, Resources.egg5);
            Rails[1, 5] = new Sprite(146, 560, Resources.cheek1);
            Rails[1, 6] = new Sprite(126, 515, Resources.cheek2);
            Rails[1, 7] = new Sprite(83, 554, Resources.cheek3);
            Rails[1, 8] = new Sprite(36, 553, Resources.cheek4);
            Rails[1, 9] = new Sprite(0, 555, Resources.cheek5);

            Rails[2, 0] = new Sprite(1106, 192, Resources.egg6);
            Rails[2, 1] = new Sprite(1062, 220, Resources.egg7);
            Rails[2, 2] = new Sprite(1033, 238, Resources.egg8);
            Rails[2, 3] = new Sprite(990, 264, Resources.egg9);
            Rails[2, 4] = new Sprite(940, 322, Resources.egg10);
            Rails[2, 5] = new Sprite(870, 560, Resources.cheek6);
            Rails[2, 6] = new Sprite(1000, 515, Resources.cheek7);
            Rails[2, 7] = new Sprite(950, 554, Resources.cheek8);
            Rails[2, 8] = new Sprite(1060, 553, Resources.cheek9);
            Rails[2, 9] = new Sprite(1130, 555, Resources.cheek10);

            Rails[3, 0] = new Sprite(1106, 362, Resources.egg6);
            Rails[3, 1] = new Sprite(1062, 390, Resources.egg7);
            Rails[3, 2] = new Sprite(1033, 408, Resources.egg8);
            Rails[3, 3] = new Sprite(990, 434, Resources.egg9);
            Rails[3, 4] = new Sprite(940, 492, Resources.egg10);
            Rails[3, 5] = new Sprite(870, 560, Resources.cheek6);
            Rails[3, 6] = new Sprite(1000, 515, Resources.cheek7);
            Rails[3, 7] = new Sprite(950, 554, Resources.cheek8);
            Rails[3, 8] = new Sprite(1060, 553, Resources.cheek9);
            Rails[3, 9] = new Sprite(1130, 555, Resources.cheek10);
        }

        /// <summary>
        /// Создает новый экземпляр класса Egg.
        /// </summary>
        public Egg()
        {
            RailNumber = random.Next(4);
        }

        /// <summary>
        /// Отображает яйцо на графическом контексте.
        /// </summary>
        /// <param name="g">Графический контекст, на котором будет отображаться яйцо.</param>
        public void Draw(Graphics g)
        {
            g.DrawImage(Rails[RailNumber, Step].Picture, Rails[RailNumber, Step].X, Rails[RailNumber, Step].Y);
        }
    }
}
