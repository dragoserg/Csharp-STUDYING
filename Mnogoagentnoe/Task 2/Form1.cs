// ReSharper disable All
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private int totalPopulation = 0;
        private int notSick = 0;
        private int latency = 0;
        private int infected = 0;
        private int recovered = 0;

        private List<DataGridViewCell> notSickList = new List<DataGridViewCell>();
        private List<DataGridViewCell> latencyList = new List<DataGridViewCell>();
        private List<DataGridViewCell> infectedList = new List<DataGridViewCell>();
        private List<DataGridViewCell> recoveredList = new List<DataGridViewCell>();
        
        private const int INDEXOFNOTSICK = 0;
        private const int INDEXOFLATENCY = 1;
        private const int INDEXOFINFECTED = 2;
        private const int INDEXOFRECOVERED = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void setTable()
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[INDEXOFNOTSICK].Value = notSick;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[INDEXOFLATENCY].Value = latency;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[INDEXOFINFECTED].Value = infected;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[INDEXOFRECOVERED].Value = recovered;
        }
        
        private void setPopulation()
        {
            notSick = totalPopulation - 1;
            setTable();
        }

        private void iteration()
        {
            
        }

        private async void btnStart_Click_1(object sender, EventArgs e)
        {
            populationError.Text = string.Empty;
            if (int.TryParse(textBox1.Text, out totalPopulation))
            {
                lblTest.Text = totalPopulation.ToString();
                await Task.Run(() => setPopulation());
                await Task.Run(() => iteration());
            }
            else
            {
                populationError.Text = "Неверный ввод";
                return;
            }
        }
    }
}