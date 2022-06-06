using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Примитивный_Кликер
{
    public partial class Form1 : Form
    {
        int money = 0;
        int multi = 1;
        int upgradecost = 25;
        int upgradecount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money += multi;
            MoneyLabel.Text = $"Деньги: {money}$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money > upgradecost - 1) // отвечает за то если купленно улучшение
            {
                money = money - upgradecost;
                MoneyLabel.Text = $"Деньги: {money}$"; // добавляет количество кликов к счёту
                upgradecount++;
                ValueUpgrade.Text = $"Количество Апгрейдов: {upgradecount}"; // показывает сколько купленно улучшений
                upgradecost = upgradecost * 2;
                CostUpgrade.Text = $"Цена Апгрейда {upgradecost}$"; // показывает сколько стоит следующее улучшение
                multi++;
                CountUpgrade.Text = $"За Один Клик: {multi}$"; // показывает сколько начисляется валюты за один клик
            }
            else
            {
                MessageBox.Show("У вас недостаточно Денег!", "Ошибка"); // показывает ошибку если не хватает денег на улучшение
            }
        }
    }
}
