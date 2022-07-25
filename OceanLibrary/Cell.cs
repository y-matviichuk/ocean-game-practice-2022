using OceanLibrary.GameCharacters;

namespace Ocean
{
    public class Cell
    {
        public Ocean ocean { set; get; }
        public char image { set; get;}
        public Coordinate offset { set; get; }

        public Cell(Coordinate offset, char image = '-')
        {
            this.image = image;
            this.offset = offset;
        }

        private Cell GetNeighborWithImage(char image)
        {
            char west = West().image;
            char south = South().image;
            char north = North().image;
            char east = East().image;
            int count = 0;
            Cell[] neightbors = new Cell[4];

            if (west.Equals(image))
            {
                neightbors[count++] = West();
            }

            if (south.Equals(image))
            {
                neightbors[count++] = South();
            }

            if (north.Equals(image))
            {
                neightbors[count++] = North();
            }

            if (east.Equals(image))
            {
                neightbors[count++] = East();
            }

            if (count != 0)
            {
                return neightbors[ocean.random.Next(0, count - 1)];
            }

            else
            {
                return this;
            }
        }

        protected Coordinate GetEmptyNeighborCoord()
        {
            char west = West().image;
            char south = South().image;
            char north = North().image;
            char east = East().image;

            char empty = '-';

            Cell[] emptyNeightbors = new Cell[4];

            int count = 0;

            if (west.Equals(empty))
            {
                emptyNeightbors[count++] = West();
            }

            if (south.Equals(empty))
            {
                emptyNeightbors[count++] = South();
            }

            if (north.Equals(empty))
            {
                emptyNeightbors[count++] = North();
            }

            if (east.Equals(empty))
            {
                emptyNeightbors[count++] = East();
            }

            if (count != 0)
            {
                return emptyNeightbors[ocean.random.Next(0, count - 1)].offset;
            }

            else
            {
                return this.offset;
            }
        }


        public virtual void Process()
        {

        }

        protected virtual void Reproduce(Coordinate coordinate)
        {

        }

        protected Coordinate getPreyCoord()
        {
            return GetNeighborWithImage('f').offset;
        }

        protected Cell GetCellAt(Coordinate coordinate)
        {
            return ocean.cells[coordinate.x, coordinate.y];
        }

        protected void AssignCellAt(Coordinate coordinate, Cell cell)
        {
            ocean.cells[coordinate.x, coordinate.y] = cell;
        }

        private Cell East()
        {
            if (offset.x == ocean.Row - 1)
            {
                return this;
            }

            else
            {
                Coordinate coordinate = new Coordinate(offset.x + 1, offset.y);
                return GetCellAt(coordinate);
            }
        }

        private Cell West()
        {
            if (offset.x == 0)
            {
                return this;
            }

            else
            {
                Coordinate coordinate = new Coordinate(offset.x - 1, offset.y);
                return GetCellAt(coordinate);
            }
        }

        private Cell North()
        {
            if (offset.y == 0)
            {
                return this;
            }

            else
            {
                Coordinate coordinate = new Coordinate(offset.x, offset.y - 1);
                return GetCellAt(coordinate);
            }
        }

        private Cell South()
        {
            if (offset.y == ocean.Column - 1)
            {
                return this;
            }

            else
            {
                Coordinate coordinate = new Coordinate(offset.x, offset.y + 1);
                return GetCellAt(coordinate);
            }
        }
    }
}
