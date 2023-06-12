using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Класс, представляющий полоску здоровья.
    /// </summary>
    public class Hp
    {
        private Sprite[] pictures { get; set; } = new Sprite[3];
        public int health { get; set; } // количесво жизней  

        /// <summary>
        /// Создает новый экземпляр класса Hp.
        /// </summary>
        public Hp()
        {
            health = 3;

            pictures[0] = new Sprite(1180, 25, Resources.Hp);
            pictures[1] = new Sprite(1120, 25, Resources.Hp);
            pictures[2] = new Sprite(1060, 25, Resources.Hp);
        }

        /// <summary>
        /// Отображает полоску здоровья на графическом контексте.
        /// </summary>
        /// <param name="g">Графический контекст, на котором будет отображаться полоска здоровья.</param>
        public void Draw(Graphics g)
        {
            for (int i = 0; i < health; i++)
            {
                g.DrawImage(pictures[i].Picture, pictures[i].X, pictures[i].Y);
            }
        }
    }
}
