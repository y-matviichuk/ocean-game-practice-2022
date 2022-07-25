using OceanLibrary.GameCharacters;

namespace Ocean.GameCharacters
{
    internal class Prey : Cell
    {
        private const int TimeToReproduce = 6;
        protected int timeToReproduce;

        public Prey(Coordinate coordinate) : base(coordinate)
        {
            timeToReproduce = TimeToReproduce;
            image = 'f';
        }

        public override void Process()
        {

            Coordinate coordinate = GetEmptyNeighborCoord();
            Coordinate preyCoordinate = GetEmptyNeighborCoord();

            if (timeToReproduce <= 0)
            {
                Reproduce(preyCoordinate);
                timeToReproduce = TimeToReproduce;
            }

            else
            {
                MoveFrom(offset, coordinate);
                timeToReproduce -= 1;
            }

        }

        protected void MoveFrom(Coordinate from, Coordinate to)
        {
            if (from.x != to.x || from.y != to.y
                    || from.x != to.x & from.y != to.y)
            {
                offset = to;

                AssignCellAt(from, new Cell(from));

                AssignCellAt(to, this);
            }
        }

        protected override void Reproduce(Coordinate coordinate)
        {
            ocean.preys += 1;
            AssignCellAt(coordinate, new Prey(coordinate));
        }
    }
}
