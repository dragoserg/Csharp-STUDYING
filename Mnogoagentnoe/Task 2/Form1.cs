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
        public Form1()
        {
            InitializeComponent();
        }
        
        private static int totalPopulation = 1000;
        
        private int notSick = 0;
        private int latency = 0;
        private int infected = 0;
        private int recovered = 0;
        
        private const int INDEXOFNOTSICK = 0;
        private const int INDEXOFLATENCY = 1;
        private const int INDEXOFINFECTED = 2;
        private const int INDEXOFRECOVERED = 3;
        
        
        
        private void setTable()
        {
            dataGridView1.BeginInvoke(new Action(() =>
            {
                dataGridView1.SuspendLayout();
                dataGridView1.Rows.Insert(0);

                dataGridView1.Rows[0].Cells[INDEXOFNOTSICK].Value = notSick;
                dataGridView1.Rows[0].Cells[INDEXOFLATENCY].Value = latency;
                dataGridView1.Rows[0].Cells[INDEXOFINFECTED].Value = infected;
                dataGridView1.Rows[0].Cells[INDEXOFRECOVERED].Value = recovered;

                dataGridView1.ResumeLayout();
            }));
        }
        
        private void setPopulation()
        {
            notSick = totalPopulation - 1;
            infected = 1;
            setTable();
        }

        private void setPeople()
        {
            
        }

        private void iteration()
        {
            setPeople();
            setTable();
        }

        private async void btnStart_Click_1(object sender, EventArgs e)
        {
            populationError.Text = string.Empty;
            if (int.TryParse(textBox1.Text, out totalPopulation))
            {
                lblTest.Text = totalPopulation.ToString();
                if (dataGridView1.Rows.Count == 1)
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