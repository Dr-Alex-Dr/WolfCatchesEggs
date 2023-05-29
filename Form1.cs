using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolfCatchesEggs.Properties;

namespace WolfCatchesEggs
{
    /// <summary>
    /// Основная форма приложения.
    /// </summary>
    public partial class Form1 : Form
    {
        private Wolf wolf = new Wolf();
        private Hp hp = new Hp();
        private List<Egg> eggs = new List<Egg>();

        private bool stateGame = false;

        /// <summary>
        /// Создает новый экземпляр класса Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Начинает новую игру.
        /// </summary>
        private void StartGame()
        {
            wolf.Level = 0;
            wolf.MaxExp = 10;
            wolf.CurrentExp = 0;
            Egg.MaxDelay = 6;
            Egg.Delay = 0;
            hp.health = 3;
            timer.Enabled = true;
            wolf.Move(0);
            stateGame = false;
        }

        /// <summary>
        /// Останавливает игру.
        /// </summary>
        private void StopGame()
        {
            timer.Enabled = false;
            stateGame = true;
        }

        /// <summary>
        /// Обработчик события Paint для pictureBox1.
        /// Отрисовывает персонажа, яйца и состояние игры.
        /// </summary>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            wolf.Draw(e.Graphics);
            hp.Draw(e.Graphics);

            foreach (Egg egg in eggs)
            {
                egg.Draw(e.Graphics);
            }

            if (stateGame)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Gray), 0, 0, 1260, 850);
                e.Graphics.DrawString("Нажмите «Пробел», чтобы начать: ", new Font("ARIAL", 23), new SolidBrush(Color.Black), 375, 380);
            }
        }

        /// <summary>
        /// Обработчик события KeyPress для формы Form1.
        /// Обрабатывает нажатия клавиш для управления персонажем и начала игры.
        /// </summary>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    wolf.Move(0);
                    break;
                case 'z':
                    wolf.Move(1);
                    break;
                case 's':
                    wolf.Move(2);
                    break;
                case 'x':
                    wolf.Move(3);
                    break;
                case 'ф':
                    wolf.Move(0);
                    break;
                case 'я':
                    wolf.Move(1);
                    break;
                case 'ы':
                    wolf.Move(2);
                    break;
                case 'ч':
                    wolf.Move(3);
                    break;
                case ' ':
                    StartGame();
                    break;
            }
            pictureBox1.Invalidate();
        }

        /// <summary>
        /// Обработчик события Tick для таймера.
        /// Обновляет положение яиц, проверяет столкновения с волком и обновляет состояние игры.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            List<Egg> temp = new List<Egg>();
            Egg.Delay++;

            if (Egg.Delay >= Egg.MaxDelay)
            {
                eggs.Add(new Egg());
                Egg.Delay = 0;
            }

            foreach (Egg egg in eggs)
            {
                if (egg.Step == 9)
                {
                    continue;
                }
                else if (egg.RailNumber == wolf.Position && egg.Step == 4)
                {
                    wolf.CurrentExp++;
                    if (wolf.CurrentExp > wolf.MaxExp)
                    {
                        wolf.Level++;
                        wolf.CurrentExp = 1;
                        wolf.MaxExp += 10;
                        Egg.MaxDelay--;
                    }
                    continue;
                }
                else if (egg.Step == 5)
                {
                    hp.health--;
                    if (hp.health == 0)
                    {
                        StopGame();
                    }
                }

                egg.Step++;
                temp.Add(egg);
            }

            eggs = temp;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Добавьте код, если необходимо обработать событие щелчка на pictureBox1.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавьте код, если необходимо выполнить действия при загрузке формы.
        }
    }
}
