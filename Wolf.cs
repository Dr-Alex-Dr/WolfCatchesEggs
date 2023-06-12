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
    /// Класс, представляющий волка.
    /// </summary>
    public class Wolf
    {
        private Sprite[] pictures { get; set; } = new Sprite[4]; // Массив изображений волка
        public int Position { get; set; } // Позиция волка
        public int Level { get; set; } // Уровень 
        public int CurrentExp { get; set; } // Прогресс бар 
        public int MaxExp { get; set; } // Максимальное количество очков на уровне

        /// <summary>
        /// Создает новый экземпляр класса Wolf.
        /// </summary>
        public Wolf()
        {
            Position = 0;
            Level = 0;
            CurrentExp = 0;
            MaxExp = 10;

            // Заполняем массив картинками
            pictures[0] = new Sprite(225, 240, Resources.Wolf1);
            pictures[1] = new Sprite(205, 240, Resources.Wolf3);
            pictures[2] = new Sprite(580, 240, Resources.Wolf2);
            pictures[3] = new Sprite(580, 240, Resources.Wolf4);
        }

        /// <summary>
        /// Отображает волка на pictureBox.
        /// </summary>
        /// <param name="g">e.Graphics, на котором будет отображаться волк.</param>
        public void Draw(Graphics g)
        {
            g.DrawImage(pictures[Position].Picture, pictures[Position].X, pictures[Position].Y);
            g.DrawRectangle(new Pen(Color.Black, 2), 15, 50, 200, 15);
            g.FillRectangle(new SolidBrush(Color.Blue), 16, 51, 201 / MaxExp * CurrentExp - 2, 13);
            g.DrawString("Уровень: " + Level.ToString(), new Font("ARIAL", 15), new SolidBrush(Color.Black), 15, 15);
        }

        /// <summary>
        /// Передвигает волка на указанную позицию.
        /// </summary>
        /// <param name="position">Новая позиция волка.</param>
        public void Move(int position)
        {
            Position = position;
        }
    }
}
