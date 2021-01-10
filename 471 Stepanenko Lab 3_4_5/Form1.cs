using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _471_Stepanenko_Lab_3_4_5
{
    public partial class Form1 : Form
    {
        string dragObject;
        int count = 0;
        int mark = 0;
        int done = 0;
        public Form1()
        {
            InitializeComponent();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");

            fileItem.DropDownItems.Add("Закрити");
            fileItem.DropDownItems[0].Click += aboutItem_Click;
            menuStrip1.Items.Add(fileItem);

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.DropDownItems.Add("Автор: Степаненко М.І. 471");
            menuStrip1.Items.Add(aboutItem);
            containerDollar.AllowDrop = false;
            containerShip.AllowDrop = false;
            containerFactory.AllowDrop = false;
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Dollar Drag
        private void containerDollar_DragDrop(object sender, DragEventArgs e)
        {
            if(dragObject.Equals("dollar"))
            {
                Console.Beep();
                containerDollar.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                count++;
                done++;
                progressBar1.Value += 33;
                MessageBox.Show("Правильно! Ви перемістили долар");
                if (count == 3)
                {
                    timer1.Stop();
                    progressBar1.Value = 100;

                    switch (mark)
                    {
                        case 3:
                            label5.Text = "Успішність тесту: 0%";
                            label5.ForeColor = Color.Red;
                            MessageBox.Show("Ви завалили тест. Ви зробили 3 помилки", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            label5.Text = "Успішність тесту: 33%";
                            label5.ForeColor = Color.FromArgb(204, 149, 0);
                            MessageBox.Show("Ви завалили тест. Ви зробили 2 помилки із 3", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 1:
                            label5.Text = "Успішність тесту: 66%";
                            label5.ForeColor = Color.YellowGreen;
                            MessageBox.Show("Вітаю, ви пройшли тест, але ви зробили 1 помилку", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 0:
                            label5.Text = "Успішність тесту: 100%";
                            label5.ForeColor = Color.Green;
                            MessageBox.Show("Вітаю, ви успішно пройшли тест, без помилок!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            else
            {
                mark++;
                label4.Text = "Кількість спроб: " + (3 - mark);
                MessageBox.Show("Ви перемістили неправильну картинку", "Помика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (count == 0)
                {
                    label5.ForeColor = Color.Red;
                }
            }
            if(mark == 3)
            {
                MessageBox.Show("Ви завалили тест. Ви зробили 3 помилки із 3", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void containerDollar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        //Factory Drag
        private void containerFactory_DragDrop(object sender, DragEventArgs e)
        {
            if (dragObject.Equals("factory"))
            {
                Console.Beep();
                containerFactory.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                count++;
                done++;
                progressBar1.Value += 33;
                MessageBox.Show("Правильно! Ви перемістили фабрику"); 
                if (count == 3)
                {
                    timer1.Stop();
                    progressBar1.Value = 100;
                    switch (mark)
                    {
                        case 3:
                            label5.Text = "Успішність тесту: 0%";
                            label5.ForeColor = Color.Red;
                            MessageBox.Show("Ви завалили тест. Ви зробили 3 помилки", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            label5.Text = "Успішність тесту: 33%";
                            label5.ForeColor = Color.FromArgb(204, 149, 0);
                            MessageBox.Show("Ви завалили тест. Ви зробили 2 помилки із 3", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 1:
                            label5.Text = "Успішність тесту: 66%";
                            label5.ForeColor = Color.YellowGreen;
                            MessageBox.Show("Вітаю, ви пройшли тест, але ви зробили 1 помилку", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 0:
                            label5.Text = "Успішність тесту: 100%";
                            label5.ForeColor = Color.Green;
                            MessageBox.Show("Вітаю, ви успішно пройшли тест, без помилок!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            else
            {
                mark++;
                label4.Text = "Кількість спроб: " + (3 - mark);
                MessageBox.Show("Ви перемістили неправильну картинку", "Помика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (count == 0)
                {
                    label5.ForeColor = Color.Red;
                }
            }
            if (mark == 3)
            {
                MessageBox.Show("Ви завалили тест. Ви зробили 3 помилки із 3", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void containerFactory_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        //Ship Drag
        private void containerShip_DragDrop(object sender, DragEventArgs e)
        {
            if (dragObject.Equals("ship"))
            {
                Console.Beep();
                containerShip.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                count++;
                done++;
                progressBar1.Value += 33;
                MessageBox.Show("Правильно! Ви перемістили корабель");
                if (count == 3)
                {
                    timer1.Stop();
                    progressBar1.Value = 100;
                    switch (mark)
                    {
                        case 3:
                            label5.Text = "Успішність тесту: 0%";
                            label5.ForeColor = Color.Red;
                            MessageBox.Show("Ви завалили тест. Ви зробили 3 помилки", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            label5.Text = "Успішність тесту: 33%";
                            label5.ForeColor = Color.FromArgb(204, 149, 0);
                            MessageBox.Show("Ви завалили тест. Ви зробили 2 помилки із 3", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 1:
                            label5.Text = "Успішність тесту: 66%";
                            label5.ForeColor = Color.YellowGreen;
                            MessageBox.Show("Вітаю, ви пройшли тест, але ви зробили 1 помилку", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 0:
                            label5.Text = "Успішність тесту: 100%";
                            label5.ForeColor = Color.Green;
                            MessageBox.Show("Вітаю, ви успішно пройшли тест, без помилок!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            else
            {
                mark++;
                label4.Text = "Кількість спроб: " + (3 - mark);
                MessageBox.Show("Ви перемістили неправильну картинку", "Помика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(count == 0)
                {
                    label5.ForeColor = Color.Red;
                }
            }
            if (mark == 3)
            {
                MessageBox.Show("Ви завалили тест. Ви зробили 3 помилки із 3", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void containerShip_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        //dollar Mouse
        private void dollar_MouseDown(object sender, MouseEventArgs e)
        {
            dragObject = (sender as PictureBox).Name;
            dollar.DoDragDrop(dollar.Image, DragDropEffects.Copy);
            if (containerDollar.AllowDrop == false)
            {
                MessageBox.Show("Ти не розпочав тест. Натисни кнопку \"Розпочати тест\"");
            }
        }
        //factory Mouse
        private void factory_MouseDown(object sender, MouseEventArgs e)
        {
            dragObject = (sender as PictureBox).Name;
            factory.DoDragDrop(factory.Image, DragDropEffects.Copy);
            if(containerDollar.AllowDrop == false)
            {
                MessageBox.Show("Ти не розпочав тест. Натисни кнопку \"Розпочати тест\"");
            }
        }
        //ship Mouse
        private void ship_MouseDown(object sender, MouseEventArgs e)
        {
            dragObject = (sender as PictureBox).Name;
            ship.DoDragDrop(ship.Image, DragDropEffects.Copy);
            if (containerDollar.AllowDrop == false)
            {
                MessageBox.Show("Ти не розпочав тест. Натисни кнопку \"Розпочати тест\"");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            containerDollar.AllowDrop = true;
            containerShip.AllowDrop = true;
            containerFactory.AllowDrop = true;
            MessageBox.Show("Час пішов! Перемісти малюнки під їх назву");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(time.Text);
            if(num == 0)
            {
                timer1.Stop();
                MessageBox.Show("Час вичерпано");
                containerDollar.AllowDrop = false;
                containerShip.AllowDrop = false;
                containerFactory.AllowDrop = false; 
                switch (done)
                {
                    case 0:
                        label5.Text = "Успішність тесту: 0%";
                        label5.ForeColor = Color.Red;
                        MessageBox.Show("Ви завалили тест. Ви не перемістили жодну картинку", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 1:
                        label5.Text = "Успішність тесту: 33%";
                        label5.ForeColor = Color.FromArgb(204, 149, 0);
                        MessageBox.Show("Ви завалили тест. Ви перемістили 1 картинку із 3", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 2:
                        label5.Text = "Успішність тесту: 66%";
                        label5.ForeColor = Color.YellowGreen;
                        MessageBox.Show("Вітаю, ви пройшли тест, але ви перемістили 2 картинки із 3", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 3:
                        label5.Text = "Успішність тесту: 100%";
                        label5.ForeColor = Color.Green;
                        MessageBox.Show("Вітаю, ви успішно пройшли тест, без помилок!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            else
            {
                num--;
                time.Text = num.ToString();
            }
        }
    }
}
