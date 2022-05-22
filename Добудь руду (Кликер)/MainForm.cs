using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Развиваемся
{
    public partial class FormCklicker : Form
    {
        double AllClickedOnPict; // Регистер общего счета
        double UpgrDbl = 0.01; // Клик по картинке = прибавка к пенсии
        double PassUpgr = 0.00; // Регистр пассивного заработка
        int PhasePictureBox = 0; // Переключает фазы изображения
        int FBought = 1; int SBought = 0; int TBought = 0; int FoBought = 0; int FivBought = 0; int SixBought = 0; // Считает кол-во улучшений
        public FormCklicker()
        {
            InitializeComponent();
        }

        private void ExitClick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClickBox_Click(object sender, EventArgs e) /* Регестирует нажатие и выводит; Также отвечает за фазу изображения */
        {
            AllClickedOnPict = AllClickedOnPict + UpgrDbl;
            // Ниже данные, отвечающие за изменение картинки
            PhasePictureBox++;
            switch (PhasePictureBox)
            {
                case 1: ClickerPicture.Image = Properties.Resources.РудаФ2; break;
                case 2: ClickerPicture.Image = Properties.Resources.РудаФ3; break;
                case 3: ClickerPicture.Image = Properties.Resources.РудаФ4; break;
                default: PhasePictureBox = 0; ClickerPicture.Image = Properties.Resources.РудаФ1; break;
            }
        }

        private void OpenMenuButt_Click(object sender, EventArgs e) /* Открывает магазин */
        {
            PanelShopPage1.Show();
        }

        private void PassiveMatPlus_Tick(object sender, EventArgs e) /* Таймер отвечающий за пассивынй заработок */
        {
            if(PassUpgr >= 0.1) AllClickedOnPict += PassUpgr;
        }
        private void FstUpgrade_Click(object sender, EventArgs e) /* Первое улучшение */
        {
            if (AllClickedOnPict >= 0.1)
            {
                AllClickedOnPict -= 0.1;
                UpgrDbl += 0.01;
                FBought++;
            }
            
        }
        private void BoughtTenButt_Click(object sender, EventArgs e)/* Покупка 10-ти улучшений */
        {
            if(AllClickedOnPict >= 1) 
            { 
                AllClickedOnPict -= 1;
                UpgrDbl += 0.1;
                FBought += 10;
            }
        }
        private void ScndUpgrade_Click(object sender, EventArgs e) /* Второе улучшение */
        {
            if(AllClickedOnPict >= 10.0)
            { 
                PassUpgr += 0.1;
                AllClickedOnPict = AllClickedOnPict + PassUpgr;
                AllClickedOnPict -= 10;
                //
                PassiveMatLabel.Text = PassUpgr.ToString();
                SBought++;
            }

        }
        private void ThirtyUpgradePic_Click(object sender, EventArgs e)/* Третье улучшение */
        {
            if (AllClickedOnPict >= 129.0)
            {
                // Увеличение обоих показателей
                PassUpgr += 0.25;
                UpgrDbl += 1.15;
                // Вычитат из общей и увеличивает пассивынй показатель
                AllClickedOnPict = AllClickedOnPict + PassUpgr;
                AllClickedOnPict -= 129;
                // Выводит 
                PassiveMatLabel.Text = PassUpgr.ToString();
                TBought++;
            }
        }
        private void FrtUpgradePic_Click(object sender, EventArgs e)/* Четвертое улучшение */
        {
            if (AllClickedOnPict >= 250)
            {
                AllClickedOnPict -= 250;
                UpgrDbl += 3.25;
                FoBought++;
                
            }
        }
        private void FivUpgradePic_Click(object sender, EventArgs e)/* Пятое улучшение */
        {
            if (AllClickedOnPict >= 1750.0)
            {
                AllClickedOnPict -= 1750;
                UpgrDbl += 1.5;
                PassUpgr += 7.25;
                FivBought++;
                PassiveMatLabel.Text = PassUpgr.ToString();
            }
        }
        private void SixUpgradePic_Click(object sender, EventArgs e)/* Шестое улучшение */
        {
            if (AllClickedOnPict >= 15000)
            {
                AllClickedOnPict -= 15000;
                UpgrDbl += 12.5;
                PassUpgr += 125.5;
                SixBought++;
                PassiveMatLabel.Text = PassUpgr.ToString();
            }
        }
        private void QuitButt_Click(object sender, EventArgs e) /* Кнопка выхода */
        {
            Application.Exit();
        }

        private void FAQButt_Click(object sender, EventArgs e) /* Если возникли вопросы - открывает форму с пояснениями */
        {
            Form frm = new FAQForm();
            frm.Show();
        }

        private void EditActiveMaterialsTimer_Tick(object sender, EventArgs e) /* Выводит обновленные счетчики */
        {
            ActiveMatLabel.Text = AllClickedOnPict.ToString("0.00");
            FstLabel.Text = FBought.ToString();
            ScdLabel.Text = SBought.ToString();
            ThrLabel.Text = TBought.ToString();
            FrtLabel.Text = FoBought.ToString();
            FivLabel.Text = FivBought.ToString();
            SixLabel.Text = SixBought.ToString();
            InfoOutputLabel.Text = UpgrDbl.ToString();
        }

        private void NextPageButt_Click(object sender, EventArgs e)/* Открывает следующую страницу магазина */
        {
            PanelShopPage2.Show();
            PanelShopPage1.Hide();
        }

        private void LastPageButt_Click(object sender, EventArgs e)/* Открывает прошлую страницу магазина */
        {
            PanelShopPage1.Show();
            PanelShopPage2.Hide();
        }

        private void CloseMenuButt2_Click(object sender, EventArgs e)/* Закрывает магазин (1) */
        {
            PanelShopPage2.Hide();
        }
        private void CloseMenuButt_Click(object sender, EventArgs e) /* Закрывает магазин (2) */
        {
            PanelShopPage1.Hide();
        }
    }
}
