using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RaftSimulationGUI
{
    public partial class RaftForm : Form
    {
        private Panel rightDock;
        private Panel leftDock;
        private Panel water;
        private Button raft;
        private List<Label> peopleOnRaft;
        private List<Label> peopleOnRightDock;
        private Random random;
        private int raftSpeed = 10;

        public RaftForm()
        {
            InitializeComponent();
            InitializeSimulation();
        }

        private void InitializeSimulation()
        {
            this.Text = "Raft Simulation";
            this.Size = new Size(800, 400);
            this.BackColor = Color.LightSkyBlue;

            random = new Random();
            peopleOnRaft = new List<Label>();
            peopleOnRightDock = new List<Label>();

            // Initialize docks
            rightDock = new Panel { Location = new Point(650, 50), Size = new Size(100, 300), BackColor = Color.Black };
            leftDock = new Panel { Location = new Point(50, 50), Size = new Size(100, 300), BackColor = Color.Black };
            this.Controls.Add(rightDock);
            this.Controls.Add(leftDock);

            // Initialize water
            water = new Panel { Location = new Point(150, 150), Size = new Size(500, 100), BackColor = Color.Blue };
            this.Controls.Add(water);

            // Initialize raft
            raft = new Button { Text = "Raft", Location = new Point(650, 200), Size = new Size(100, 30), BackColor = Color.Gray };
            raft.Click += Raft_Click;
            this.Controls.Add(raft);

            // Add initial people to the right dock
            AddPeopleToRightDock(random.Next(1, 5));
        }

        private void AddPeopleToRightDock(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var person = new Label
                {
                    Text = "☺",
                    Font = new Font("Arial", 14),
                    AutoSize = true,
                    ForeColor = Color.Yellow,
                    Location = new Point(10, peopleOnRightDock.Count * 25 + 10)
                };
                peopleOnRightDock.Add(person);
                rightDock.Controls.Add(person);
            }
            UpdateDockInfo();
        }

        private void Raft_Click(object sender, EventArgs e)
        {
            if (raft.Location.X > leftDock.Right)
            {
                // Move people from right dock to raft
                MovePeopleToRaft();
                // Start moving the raft
                timer1.Start();
            }
            else if (raft.Location.X <= leftDock.Right)
            {
                // Unload raft at left dock
                UnloadRaftAtLeftDock();
                // Move raft back to right dock
                MoveRaftBack();
            }
        }

        private void MovePeopleToRaft()
        {
            int peopleToBoard = Math.Min(4 - peopleOnRaft.Count, peopleOnRightDock.Count);
            for (int i = 0; i < peopleToBoard; i++)
            {
                var person = peopleOnRightDock[0];
                peopleOnRightDock.Remove(person);
                rightDock.Controls.Remove(person);
                peopleOnRaft.Add(person);
                raft.Controls.Add(person);
            }
            UpdateDockInfo();
        }

        private void UnloadRaftAtLeftDock()
        {
            foreach (var person in peopleOnRaft)
            {
                raft.Controls.Remove(person);
            }
            peopleOnRaft.Clear();
            UpdateDockInfo();
        }

        private void MoveRaftBack()
        {
            raft.Location = new Point(rightDock.Left, raft.Location.Y);
            AddPeopleToRightDock(random.Next(1, 5)); // Add new people to the right dock
        }

        private void UpdateDockInfo()
        {
            this.Text = $"Raft Simulation - Right Dock: {peopleOnRightDock.Count} people, Raft: {peopleOnRaft.Count} people";
        }

        private Timer timer1;

        private void InitializeComponent()
        {
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 100; // Timer interval in milliseconds
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RaftForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "RaftForm";
            this.Load += new System.EventHandler(this.RaftForm_Load);
            this.ResumeLayout(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (raft.Location.X > leftDock.Right)
            {
                raft.Location = new Point(raft.Location.X - raftSpeed, raft.Location.Y);
            }
            else
            {
                timer1.Stop();
                UnloadRaftAtLeftDock();
                MoveRaftBack();
            }
        }

        private void RaftForm_Load(object sender, EventArgs e)
        {
            // Form load logic if necessary
        }
    }

    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RaftForm());
        }
    }
}
