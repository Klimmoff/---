namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public int money = 0;
        public int multi = 1;
        public int upgradecost = 25;
        public int upgradecount = 0;
        public Form1()
        {
            InitializeComponent(); // ����� ������������� �����������
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money = money + multi;
            label1.Text = $"������: {money}$"; // ��������� ���������� ������ � �����
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money > upgradecost - 1) // �������� �� �� ���� �������� ���������
            {
                money = money - upgradecost;
                label1.Text = $"������: {money}$"; // ��������� ���������� ������ � �����
                upgradecount++;
                label2.Text = $"���������� ���������: {upgradecount}"; // ���������� ������� �������� ���������
                upgradecost = upgradecost * 2;
                label3.Text = $"���� �������� {upgradecost}$"; // ���������� ������� ����� ��������� ���������
                multi++;
                label4.Text = $"�� ���� ����: {multi}$"; // ���������� ������� ����������� ������ �� ���� ����
            } else
            {
                MessageBox.Show("� ��� ������������ �����!", "������"); // ���������� ������ ���� �� ������� ����� �� ���������
            }
        }
    }
}