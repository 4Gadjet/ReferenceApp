namespace ReferenceApp
{
    public partial class Form1 : Form
    {
        int[] A = { 0 };
        int[] B = { 0 };
        int[] C = { 0 };
       
        public Form1()
        {
            InitializeComponent();
        }

        //Вычислить значение функции  Q = 0,33 * sint - 1,08 * cosp + g
        //где t, p, g - суммы элементов массивов А, В и С, соответственно,
        //значения которых меньше заданного D.

        public void Generation(ref int []smth, int count) //Генерация случайных элементов
        {
            Random rng = new Random();
            Array.Resize(ref smth, count);
            for (int i = 0; i < count; i++) 
            {
                smth[i] = rng.Next();
            }
        }

        public double Function_Q(double t, double p, double g) 
        {
            double Q = 0;
            Q = (0.33 * Math.Sin(t)) - (1.08 * Math.Cos(p)) + g;
            return Q;
        }

        private void button2_Click(object sender, EventArgs e) //Рассчет
        {
            int count = 0;
            if (Convert.ToInt32(textBox1.TextLength) <= 0 || Convert.ToInt32(textBox2.TextLength) <= 0 || Convert.ToInt32(textBox3.TextLength) <= 0)
            {
                
                MessageBox.Show("Поля заполнены некорректно!\nЗначения должны быть больше 0!", "ОШИБКА!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox2.Text) <= 0 || Convert.ToInt32(textBox3.Text) <= 0)
                {
                    MessageBox.Show("Поля заполнены некорректно!\nЗначения должны быть больше 0!", "ОШИБКА!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    double Sum_t = 0, Sum_p = 0, Sum_g = 0;
                    count = Convert.ToInt32(textBox1.Text); //Получаем количество элементов с текстбокса
                    Generation(ref A, count); 
                    for (int i = 0; i < count; i++) //Рассчет суммы 
                    {
                        Sum_t += A[i];
                    }
                    count = Convert.ToInt32(textBox2.Text);
                    Generation(ref B, count);
                    for (int i = 0; i < count; i++)
                    {
                        Sum_p += B[i];
                    }
                    count = Convert.ToInt32(textBox3.Text);
                    Generation(ref C, count);
                    for (int i = 0; i < count; i++)
                    {
                        Sum_g += C[i];
                    }
                    textBox4.Text = Function_Q(Sum_t, Sum_p, Sum_g).ToString();


                }
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана в рамках учебной практики." +
              "\nАвтор: Камоликов Владислав, группа: ДИНРБ-21" +
              "\nРуководитель: Куркурин Николай Дмитриевич",
              "Справка", MessageBoxButtons.OK);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(textBox4, "Здесь будет выведен результат вычисления");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(button2, "Нажмите для расчета");
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(textBox3, "Введите размерность массива С");
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(textBox2, "Введите размерность массива В");
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(textBox1, "Введите размерность массива А");
        }

       
    }
}