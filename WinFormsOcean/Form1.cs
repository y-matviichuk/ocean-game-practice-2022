using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Ocean;
using Ocean.Interface;
using OceanLibrary;

namespace WinFormsOcean
{
    public partial class Form1 : Form, IView
    {
        private Ocean.Ocean _owner;
        private StringBuilder oceanStr = new StringBuilder();
        private int iteration = 0;
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            pauseButton.Enabled = false;

            _owner = new Ocean.Ocean(this);

            playButton.Click += OnStart;
            endButton.Click += OnEnd;
            pauseButton.Click += OnPause;
            settingsButton.Click += OnSetSettings;

            _timer.Interval = 200;
            _timer.Tick += (object s, EventArgs e) =>
            {
                if (iteration < _owner.iterations)
                {
                    _owner.Step(iteration++);
                }
                else
                {
                    _timer.Stop();
                    MessageBox.Show("Game End");
                    OnEnd(null, null);
                }
            };

            DisplayEmpty();
 
        }

        private void OnStart(object sender, EventArgs e)
        {
            iteration = 0;
            _owner.InitCells();
            _timer.Start();
            playButton.Enabled = false;
            pauseButton.Enabled = true;
            settingsButton.Enabled = false;
        }

        private void OnEnd(object sender, EventArgs e)
        {
            _timer.Stop();
            playButton.Enabled = true;
            pauseButton.Enabled = false;
            settingsButton.Enabled = true;
            labelGame.Text = "";
            labelStatistic.Text = "";
            DisplayEmpty();
        }

        private void OnSetSettings(object sender, EventArgs e)
        {
            try
            {
                _owner.InputValues();
            } 
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong input format");
            }
        }

        private void OnPause(object sender, EventArgs e)
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
                pauseButton.Text = "Continue";
            }
            else
            {
                pauseButton.Text = "Pause";
                _timer.Start();
            }
        }

        public void InputRowsAndColumn(Ocean.Ocean ocean)
        {
            ocean.rows = Constants.defaultRows;
            ocean.columns = Constants.defaultColumns;
        }

        public void InputValues(Ocean.Ocean ocean)
        {
            int Obstacles = int.Parse(textObstacles.Text);

            if (Obstacles < 0 || Obstacles > Constants.maxObstacles)
            {
                throw new IncorrectInputException($"The number of obstacles must be between 0 and {Constants.maxObstacles}");
            }

            else
            {
                ocean.obstacles = Obstacles;
            }

            int Predators = int.Parse(textPredators.Text);

            if (Predators < 0 || Predators > Constants.maxPredators)
            {
                throw new IncorrectInputException($"The number of predators must be between 0 and {Constants.maxPredators}");
            }

            else
            {
                ocean.predators = Predators;
            }

            int Preys = int.Parse(textPreys.Text);

            if (Preys < 0 || Preys > Constants.maxPreys)
            {
                throw new IncorrectInputException($"The number of preys must be between 0 and {Constants.maxPreys}");
            }

            else
            {
                ocean.preys = Preys;
            }
        }

        public void InputIterations(Ocean.Ocean ocean)
        {
            int operations = int.Parse(textOperations.Text);

            if (operations < 0 || operations > Constants.maxIterations)
            {
                throw new IncorrectInputException($"The number of operations must be between 0 and {Constants.maxIterations}");
            }

            else
            {
                ocean.iterations = operations;
            }
        }

        public void PrintIterations(Ocean.Ocean ocean)
        {
            labelGame.Text = $"Type number of operations: {ocean.iterations}\n";  // \n
            labelGame.Text = " ";
        }

        public void PrintException(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Print(Ocean.Ocean ocean)
        {
            oceanStr.Clear();
            labelStatistic.Text = $"Obstacles (#) - {ocean.Obstacle}\n";
            labelStatistic.Text += $"Predators (S) - {ocean.Predator}\n";
            labelStatistic.Text += $"Preys (f) - {ocean.Prey}\n";
        }

        public void DisplayBorder(Ocean.Ocean ocean)
        {
            for (int column = 0; column < ocean.columns; column++)
            {
                if (column == ocean.columns - 1)
                {
                    oceanStr.Append("\n");
                }

                else if (column == 0)
                {
                    oceanStr.Append("*");
                }

                else
                {
                    oceanStr.Append("*");
                }
            }
            // Thread.Sleep(150);
        }

        public void DisplayCells(Ocean.Ocean ocean)
        {
            for (int row = 0; row < ocean.rows; row++)
            {
                for (int column = 0; column < ocean.columns; column++)
                {
                    oceanStr.Append(ocean.cells[row, column].image);
                }
                oceanStr.Append("\n");
            }
            labelGame.Text = oceanStr.ToString();
            //Thread.Sleep(200);
        }

        public void DisplayEmpty()
        {
            var builder = new StringBuilder();
            for (int row = 0; row < _owner.rows; row++)
            {
                for (int column = 0; column < _owner.columns; column++)
                {
                    builder.Append("-");
                }
                builder.Append("\n");
            }
            labelGame.Text = builder.ToString();
        }
    }
}