
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<DataGridViewCell> dock = new List<DataGridViewCell>(); //Ячейки пристани
        private List<DataGridViewCell> water = new List<DataGridViewCell>(); //Ячейки воды
        private List<DataGridViewCell> raftPath = new List<DataGridViewCell>(); //Ячейки пути плота
        private List<DataGridViewCell> peoplePath = new List<DataGridViewCell>(); //Ячейки пути плота
        DataGridViewCell peopleOutput; //Ячейка для ухода людей на левой пристани
        DataGridViewCell peopleInput; //Ячейка для прихода людей на правой пристани
        DataGridViewCell currentRaftLocation; //Текущее местоположение плота
        DataGridViewCell currentPeopleLocation; //Текущее местоположение людей на плоту
        DataGridViewCell startPeopleLocation; //Текущее местоположение людей на плоту
        private int currentPeopleOnInput = 0;
        private int currentPeopleOnRaft = 0;
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void setDock()
        {
            for (int i = 11; i <= 20; i++)
            {
                dock.Add(dataGridView1.Rows[i].Cells[0]);
                dock.Add(dataGridView1.Rows[i].Cells[9]);
            }

            foreach (DataGridViewCell cell in dock)
            {
                cell.Style.BackColor = Color.Black;
                cell.Style.SelectionBackColor = Color.Black;
            }
        }//Метод для установки пристаней

        private void setWater() //Метод для установки воды
        {
            for (int i = 12; i <= 20; i++)
            {
                for (int j = 1; j < 9; j++)
                    water.Add(dataGridView1.Rows[i].Cells[j]);
            }

            foreach (DataGridViewCell cell in water)
                cell.Style.BackColor = Color.Blue;
        } 
        private void setRaftPath() //Метод для установки пути плота
        {
            for (int i = 1; i < 9; i++)
            {
                raftPath.Add(dataGridView1.Rows[11].Cells[i]);
            }
        }
        private void setPeoplePath() //Метод для установки пути плота
        {
            for (int i = 1; i < 9; i++)
            {
                peoplePath.Add(dataGridView1.Rows[10].Cells[i]);
            }
        }
        private void setPeopleOnInput()
        {
            switch (currentPeopleOnInput)
            {
                case 0:
                    peopleInput.Value = "";
                    break;
                case 1:
                    peopleInput.Value = "😀";
                    break;
                case 2:
                    peopleInput.Value = "😀😀";
                    break;
                case 3:
                    peopleInput.Value = "😀😀😀";
                    break;
                case 4:
                    peopleInput.Value = "😀😀😀😀";
                    break;
                default:
                    peopleInput.Value = "ERROR";
                    break;
            }
        }

        private void setPeopleOnRaft()
        {
            switch (currentPeopleOnRaft)
            {
                case 0:
                    peopleInput.Value = "";
                    break;
                case 1:
                    currentPeopleLocation.Value = "😀";
                    break;
                case 2:
                    currentPeopleLocation.Value = "😀😀";
                    break;
                case 3:
                    currentPeopleLocation.Value = "😀😀😀";
                    break;
                case 4:
                    currentPeopleLocation.Value = "😀😀😀😀";
                    break;
                default:
                    currentPeopleLocation.Value = "ERROR";
                    break;
            }
        }

        private void setPeopleOnOutput()
        {
            switch (currentPeopleOnRaft)
            {
                case 0:
                    peopleOutput.Value = "";
                    break;
                case 1:
                    peopleOutput.Value = "😀";
                    break;
                case 2:
                    peopleOutput.Value = "😀😀";
                    break;
                case 3:
                    peopleOutput.Value = "😀😀😀";
                    break;
                case 4:
                    peopleOutput.Value = "😀😀😀😀";
                    break;
                default:
                    peopleOutput.Value = "ERROR";
                    break;
            }
        }

        private void peopleOnDock()
        {
            int onDock = rnd.Next(1, 4 - currentPeopleOnInput);
            currentPeopleOnInput += onDock;
            setPeopleOnInput();
        }

        private void peopleOnRaft()
        {
            int onRaft = rnd.Next(1, currentPeopleOnInput);
            currentPeopleLocation = startPeopleLocation;
            currentPeopleOnInput -= onRaft;
            currentPeopleOnRaft = onRaft;
            setPeopleOnRaft();
            setPeopleOnInput();
        }

        private void peopleOutRaft()
        {
            setPeopleOnOutput();
            currentPeopleLocation.Value = string.Empty;
            Thread.Sleep(200);
            peopleOutput.Value = string.Empty;
        }

        private void toTheLeft()
        {
            DataGridViewCell previousRaftLacation = currentRaftLocation;
            DataGridViewCell previousPeopleLacation = currentRaftLocation;
            for (int i = raftPath.Count - 1; i >= 0; i--)
            {
                DataGridViewCell raftCell = (DataGridViewCell)raftPath[i];
                DataGridViewCell peopleCell = (DataGridViewCell)peoplePath[i];
                currentRaftLocation = raftCell;
                currentPeopleLocation = peopleCell;
                currentRaftLocation.Style.BackColor = Color.Gray;
                setPeopleOnRaft();
                if (currentRaftLocation != previousRaftLacation)
                    previousPeopleLacation.Value = string.Empty;
                    previousRaftLacation.Style.BackColor = Color.White;
                previousRaftLacation = currentRaftLocation;
                previousPeopleLacation = currentPeopleLocation;
                Thread.Sleep(100);
            }


        }

        private void toTheRight()
        {
            DataGridViewCell previousRaftLacation = currentRaftLocation;
            for (int i = 0; i < raftPath.Count; i++)
            {
                DataGridViewCell cell = raftPath[i];
                currentRaftLocation = cell;
                currentRaftLocation.Style.BackColor = Color.Gray;
                if (currentRaftLocation != previousRaftLacation)
                    previousRaftLacation.Style.BackColor = Color.White;
                previousRaftLacation = currentRaftLocation;
                Thread.Sleep(100);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            start();

        }

        async private void start()
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                label2.Text = string.Empty;
                for (int i = 0; i < value; i++)
                {
                    await Task.Run(() => peopleOnDock());
                    Thread.Sleep(200);
                    await Task.Run(() => peopleOnRaft());
                    Thread.Sleep(200);
                    await Task.Run(() => toTheLeft());
                    Thread.Sleep(200);
                    await Task.Run(() => peopleOutRaft());
                    Thread.Sleep(200);
                    await Task.Run(() => toTheRight());
                }
            }
            else
            {
                label2.Text = "Повторите ввод";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(20);
            dataGridView1.ForeColor = Color.Black;
            peopleOutput = dataGridView1.Rows[10].Cells[0]; //Ячейка для ухода людей на левой пристани
            peopleInput = dataGridView1.Rows[10].Cells[9]; //Ячейка для прихода людей на правой пристани
            currentRaftLocation = dataGridView1.Rows[11].Cells[8]; //Текущее местоположение плота
            startPeopleLocation = dataGridView1.Rows[10].Cells[8]; //Текущее местоположение плота
            currentRaftLocation.Style.BackColor = Color.Gray; //Цвет плота серый
            //😀
            setDock();
            setWater();
            setRaftPath();
            setPeoplePath();
        }


        
    }
}
