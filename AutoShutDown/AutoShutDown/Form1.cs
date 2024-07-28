using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShutDown
{
    public partial class Form1 : Form
    {
        //Процесс для выключения или ввода в сон/гипернацию пк
        private ProcessStartInfo process = new ProcessStartInfo("shutdown", $"/s /t {seconds}");
        private Process activeProcess;

        //секунды до выключения
        private static float seconds = 0;

        //Флаг активности процесса
        bool isActive = false; 

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            changeLabel4();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Смена надписи, которая показывает активность процесса
        private void changeLabel4()
        {
            label4.Text = isActive.ToString();
        }

        //Перевод минут в секунды
        private float toSeconds()
        {
            float minutes;
            if (float.TryParse(textBox1.Text, out minutes))
                return seconds = minutes * 60;
            return seconds = - 1;
        }

        //Метод для выключения пк
        private void shutDown()
        { 
            label3.Text = $"Shutdown {toSeconds()}";
            if (seconds < 0) // Проверка что введены секунды
                return;
            
            isActive = true;
            Process.Start( process );
            //activeProcess = Process.Start( process );
        }

        //Метод для ввода пк в сон
        private void sleep()
        {
            label3.Text = $"sleep {toSeconds()}";
        }

        //Метод для ввода пк в гипернацию
        private void hypernate()
        {
            label3.Text = $"hypernate {toSeconds()}";

        }

        
        //Проверка на корректный ввод данных при нажании кнопки
        private async void button1_Click(object sender, EventArgs e)
        {


            if (isActive) //Если процесс активен, то его нужно закрыть
            {
                activeProcess.Kill();
                return;
            }

            if (radioButton1.Checked) //Если выбран пункт shutdown, то выключить пк
            {
                shutDown();
            }

            if (radioButton2.Checked)
            {
                sleep(); //Если выбран пункт sleep, то ввести пк в сон
            }

            if (radioButton3.Checked)
            {
                hypernate(); //Если выбран пункт hypernate, то ввести пк в нмпернацию
            }
            changeLabel4();


        }
    }
}
