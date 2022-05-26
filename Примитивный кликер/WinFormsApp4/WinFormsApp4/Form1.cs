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
            InitializeComponent(); // метод инициализации компонентов
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money = money + multi;
            label1.Text = $"Деньги: {money}$"; // добавляет количество кликов к счёту
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money > upgradecost - 1) // отвечает за то если купленно улучшение
            {
                money = money - upgradecost;
                label1.Text = $"Деньги: {money}$"; // добавляет количество кликов к счёту
                upgradecount++;
                label2.Text = $"Количество Апгрейдов: {upgradecount}"; // показывает сколько купленно улучшений
                upgradecost = upgradecost * 2;
                label3.Text = $"Цена Апгрейда {upgradecost}$"; // показывает сколько стоит следующее улучшение
                multi++;
                label4.Text = $"За Один Клик: {multi}$"; // показывает сколько начисляется валюты за один клик
            } else
            {
                MessageBox.Show("У вас недостаточно Денег!", "Ошибка"); // показывает ошибку если не хватает денег на улучшение
            }
        }
    }
}