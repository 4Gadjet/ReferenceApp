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

        //��������� �������� �������  Q = 0,33 * sint - 1,08 * cosp + g
        //��� t, p, g - ����� ��������� �������� �, � � �, ��������������,
        //�������� ������� ������ ��������� D.

        public void Generation(ref int []smth, int count) //��������� ��������� ���������
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

        private void button2_Click(object sender, EventArgs e) //�������
        {
            int count = 0;
            if (Convert.ToInt32(textBox1.TextLength) <= 0 || Convert.ToInt32(textBox2.TextLength) <= 0 || Convert.ToInt32(textBox3.TextLength) <= 0)
            {
                
                MessageBox.Show("���� ��������� �����������!\n�������� ������ ���� ������ 0!", "������!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox2.Text) <= 0 || Convert.ToInt32(textBox3.Text) <= 0)
                {
                    MessageBox.Show("���� ��������� �����������!\n�������� ������ ���� ������ 0!", "������!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    double Sum_t = 0, Sum_p = 0, Sum_g = 0;
                    count = Convert.ToInt32(textBox1.Text); //�������� ���������� ��������� � ����������
                    Generation(ref A, count); 
                    for (int i = 0; i < count; i++) //������� ����� 
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
            MessageBox.Show("��������� ������� � ������ ������� ��������." +
              "\n�����: ��������� ���������, ������: �����-21" +
              "\n������������: �������� ������� ����������",
              "�������", MessageBoxButtons.OK);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(textBox4, "����� ����� ������� ��������� ����������");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(button2, "������� ��� �������");
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(textBox3, "������� ����������� ������� �");
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(textBox2, "������� ����������� ������� �");
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(textBox1, "������� ����������� ������� �");
        }

       
    }
}