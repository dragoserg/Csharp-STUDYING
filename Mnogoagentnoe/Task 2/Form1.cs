// ReSharper disable All
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        Random random = new Random();

        private int day = 0;

        private static int totalPopulation;

        private double notSick = 0;
        private double latency = 0;
        private double infected = 0;
        private double recovered = 0;

        private const int INDEXOFNOTSICK = 0;
        private const int INDEXOFLATENCY = 1;
        private const int INDEXOFINFECTED = 2;
        private const int INDEXOFRECOVERED = 3;

        // Моделирование параметров
        private double beta = 0.6; // Коэффициент передачи вируса
        private double sigma = 0.3; // Коэффициент перехода из латентного состояния в заболевание
        private double gamma = 0.05; // Коэффициент выздоровления

        private double dt = 1; // Шаг интегрирования (в днях)

        private void InitializeChart()
        {
            // Инициализация графика
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            var chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Добавляем серии данных
            chart1.Series.Add(new Series("Not Sick") { ChartType = SeriesChartType.Line });
            chart1.Series.Add(new Series("Latency") { ChartType = SeriesChartType.Line });
            chart1.Series.Add(new Series("Infected") { ChartType = SeriesChartType.Line });
            chart1.Series.Add(new Series("Recovered") { ChartType = SeriesChartType.Line });

            // Названия осей
            chart1.ChartAreas[0].AxisX.Title = "Days";
            chart1.ChartAreas[0].AxisY.Title = "Count";
        }

        private void setTable()
        {
            dataGridView1.BeginInvoke(new Action(() =>
            {
                dataGridView1.SuspendLayout();
                dataGridView1.Rows.Insert(0);

                // Округление до целых чисел перед отображением
                dataGridView1.Rows[0].Cells[INDEXOFNOTSICK].Value = Math.Round(notSick);
                dataGridView1.Rows[0].Cells[INDEXOFLATENCY].Value = Math.Round(latency);
                dataGridView1.Rows[0].Cells[INDEXOFINFECTED].Value = Math.Round(infected);
                dataGridView1.Rows[0].Cells[INDEXOFRECOVERED].Value = Math.Round(recovered);

                dataGridView1.ResumeLayout();
            }));
        }

        private void setPopulation()
        {
            notSick = totalPopulation - 1;
            latency = 0;
            infected = 1;
            recovered = 0;
            setTable();
        }

        private void setPeople()
        {
            // Расчет новых значений
            double dS = -beta * notSick * infected / totalPopulation;
            double dE = beta * notSick * infected / totalPopulation - sigma * latency;
            double dI = sigma * latency - gamma * infected;
            double dR = gamma * infected;

            // Обновление значений
            notSick += dS * dt;
            latency += dE * dt;
            infected += dI * dt;
            recovered += dR * dt;

            // Обновление таблицы и графика
            
        }

        private void updateChart()
        {
            if (chart1.InvokeRequired)
            {
                chart1.Invoke(new Action(() =>
                {
                    // Добавление данных в график
                    chart1.Series["Not Sick"].Points.AddXY(day, notSick);
                    chart1.Series["Latency"].Points.AddXY(day, latency);
                    chart1.Series["Infected"].Points.AddXY(day, infected);
                    chart1.Series["Recovered"].Points.AddXY(day, recovered);
                }));
            }
            else
            {
                // Добавление данных в график
                chart1.Series["Not Sick"].Points.AddXY(day, notSick);
                chart1.Series["Latency"].Points.AddXY(day, latency);
                chart1.Series["Infected"].Points.AddXY(day, infected);
                chart1.Series["Recovered"].Points.AddXY(day, recovered);
            }
        }

        private void iteration()
        {
            day++;
            setPeople();
            setTable();
            updateChart();
        }

        private async void btnStart_Click_1(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            populationError.Text = string.Empty;
            if (int.TryParse(textBox1.Text, out totalPopulation))
            {
                lblTest.Text = totalPopulation.ToString();
                if (dataGridView1.Rows.Count == 1)
                    await Task.Run(() => setPopulation());
                await Task.Run(() => iteration());
                await Task.Run(() => iteration());
                // Запуск моделирования
                while (Math.Round(infected) > 0 || Math.Round(latency) > 0)
                {
                    await Task.Run(() => iteration());
                    await Task.Delay(100); // Задержка для визуализации
                }

                btnStart.Enabled = true;
            }
            else
            {
                populationError.Text = "Неверный ввод";
                btnStart.Enabled = true;
                return;
            }
        }
    }
}
