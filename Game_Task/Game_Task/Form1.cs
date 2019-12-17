using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Task
{
    public partial class Form1 : Form
    {
        private List<int> arrayOfUsedSymbols = new List<int>() { };
        private Random rnd = new Random();
        private int randomNumber;
        private int countOfRemainingAttempts = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartNewGame()
        {
            arrayOfUsedSymbols.Clear();
            this.textBox1.Clear();
            this.usedDigitsLabel.Text = "";
            this.countOfRemainingAttemptsLabel.Text = "3";
            countOfRemainingAttempts = 3;
            randomNumber = rnd.Next(10);
            tipLabel.Text = "";
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.textBox1.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int inputNumber;

            //если формат ввода правильный
            bool isParsedSuccessfully = int.TryParse(this.textBox1.Text, out inputNumber);
            if (!isParsedSuccessfully) {
                ShowError("Ошибка: неверый формат ввода");
                return;
            }
            if (inputNumber < 0 || inputNumber >= 10) {
                ShowError("Ошибка: число " + inputNumber + " находится вне диапазона [0; 9]");
            }
            
            //если число совпадает с загаданным
            if(inputNumber == randomNumber)
            {
                MessageBox.Show("Вы победили", "Победа", MessageBoxButtons.OK);
                StartNewGame();
                return;
            }
            //проверяем, вводили ли число до этого
            bool inputted_earlier = arrayOfUsedSymbols.Contains(inputNumber);
            if (inputted_earlier) {
                ShowError("Вы уже вводили число " + inputNumber);
                return;
            }

            this.textBox1.Clear();

            arrayOfUsedSymbols.Add(inputNumber);
            usedDigitsLabel.Text = usedDigitsLabel.Text + inputNumber + " ";

            countOfRemainingAttempts--;
            this.countOfRemainingAttemptsLabel.Text = Convert.ToString(countOfRemainingAttempts);

            if(inputNumber < randomNumber)
            {
                tipLabel.Text = "Загаданное число больше";
            }
            else
            {
                tipLabel.Text = "Загаданное число меньше";
            }

            //если это 4-я попытка
            if (countOfRemainingAttempts == 0)
            {
                var result = MessageBox.Show("Вы проиграли.\nНачать новую игру?", "Поражение",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //если решили не продолжать игру
                if (result == DialogResult.No)
                    this.Close();

                //иначе начинаем игру заново
                StartNewGame();
            }
        }
    }
}
