using Ocean.GameCharacters;
using Ocean.Interface;
using Ocean.Visitor;
using OceanLibrary.GameCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean
{
    public class Ocean
    {
        private const int MaxNumRows = 25;
        private const int MaxNumColumns = 70;
        private const int MaxNumPrey = 150;
        private const int MaxNumPredators = 20;
        private const int MaxNumObstacles = 75;
        private const int MaxNumIterations = 1000;

        public int preys = 150;
        public int predators = 25;
        public int obstacles = 75;

        private int size;
        public int rows = 25;
        public int columns = 75;
        public int iterations = 150;

        public Cell[,] cells;
        public Random random = new Random();

        public IView output;

        public Ocean(IView output)
        {
            this.output = output;
        }

        public int Row
        {
            get => rows;
            set
            {
                if (rows > MaxNumRows || rows < 0)
                {
                    rows = MaxNumRows;
                    throw new IncorrectInputException();
                }

                else
                {
                    Row = rows;
                }
            }
        }

        public int Column
        {
            get => columns;
            set
            {
                if (columns > MaxNumColumns || columns < 0)
                {
                    columns = MaxNumColumns;
                    throw new IncorrectInputException();
                }

                else
                {
                    Column = columns;
                }
            }
        }

        public int Prey
        {
            get => preys;
            set
            {
                if (preys < 0 || preys > size - obstacles)
                {
                    preys = MaxNumPrey;
                    throw new IncorrectInputException();
                }

                else
                {
                    Prey = preys;
                }
            }
        }

        public int Predator
        {
            get => predators;
            set
            {
                if (predators < 0 || predators > size - obstacles)
                {
                    predators = MaxNumPredators;
                    throw new IncorrectInputException();
                }

                else
                {
                    Predator = predators;
                }
            }
        }

        public int Obstacle
        {
            get => obstacles;
            set
            {
                if (obstacles > size || obstacles < 0)
                {
                    obstacles = MaxNumObstacles;
                    throw new IncorrectInputException();
                }

                else
                {
                    Obstacle = obstacles;
                }
            }
        }

        public int Iteration
        {
            get => iterations;
            set
            {
                if (iterations < 0 || iterations > 1000)
                {
                    iterations = MaxNumIterations;
                    throw new IncorrectInputException();
                }

                else
                {
                    Iteration = iterations;
                }
            }
        }

        public void InputValues()
        {
            try
            {
                output.InputValues(this);
                output.InputIterations(this);
            }

            catch (IncorrectInputException exception)
            {
                output.PrintException(exception.message);
            }
        }

        public void InitCells()
        {
            AddEmptyCells();
            AddObstacles();
            AddPredators();
            AddPrey();
        }

        private void AddEmptyCells()
        {
            try
            {
                output.InputRowsAndColumn(this);
            }

            catch (IncorrectInputException exception)
            {
                output.PrintException(exception.message);
            }

            cells = new Cell[rows, columns];

            size = columns * rows;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    cells[row, column] = new Cell(new Coordinate(row, column));
                }
            }
        }

        private void AddObstacles()
        {
            Coordinate emptyCell;
            for (int i = 0; i < obstacles; i++)
            {
                emptyCell = GetEmptyCellCoord();
                cells[emptyCell.x, emptyCell.y] = new Obstacle(emptyCell);
            }
        }

        private void AddPredators()
        {
            Coordinate empty;
            for (int i = 0; i < predators; i++)
            {
                empty = GetEmptyCellCoord();
                cells[empty.x, empty.y] = new Predator(empty);
            }
        }

        private void AddPrey()
        {
            Coordinate empty;
            for (int i = 0; i < preys; i++)
            {
                empty = GetEmptyCellCoord();
                cells[empty.x, empty.y] = new Prey(empty);
            }
        }

        private Coordinate GetEmptyCellCoord()
        {
            int y = random.Next(0, columns - 1);
            int x = random.Next(0, rows - 1);

            Coordinate emptyCell;

            while (cells[x, y].image != '-')
            {
                y = random.Next(0, columns - 1);
                x = random.Next(0, rows - 1);
            }

            emptyCell = cells[x, y].offset;
            return emptyCell;
        }

        private void DisplayStats(int iteration)
        {    
            output.Print(this);
            output.DisplayBorder(this);
        }

        public void Run()
        {
            try
            {
                output.InputIterations(this);
            }

            catch (IncorrectInputException exception)
            {
                output.PrintException(exception.message);
            }

            output.PrintIterations(this);

            for (int iteration = 1; iteration <= iterations; iteration++)
            {
                Step(iteration);
            }
        }

        public void Step(int iteration)
        {
            IVisitor cellVisitor = new VisitorImpl();
            if (preys > 0 && predators > 0)
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        Cell cell = cells[row, column];
                        cell.ocean = this;
                        cellVisitor.Visit(cell);
                    }
                }

                DisplayStats(iteration);
                output.DisplayCells(this);
                output.DisplayBorder(this);
            }
        }
    }
}
