using OceanLibrary.GameCharacters;

namespace Ocean.GameCharacters
{
    internal class Predator : Prey
    {
        private const int TimeToFeed = 6;
        private const int TimeToReproduce = 6;

        private int timeToFeed;

        public Predator(Coordinate coordinate) : base(coordinate)
        {
            timeToFeed = TimeToFeed;
            image = 'S';
        }

        public override void Process()
        {
            Coordinate shouldBeEatenPreyCoordinate = getPreyCoord();
            Coordinate predatorCoordinate = GetEmptyNeighborCoord();

            if (timeToFeed <= 0)
            {
                AssignCellAt(offset, new Cell(offset));

                ocean.predators -= 1;
            }

            else
            {
                if (shouldBeEatenPreyCoordinate.x != offset.x || shouldBeEatenPreyCoordinate.y != offset.y
                    || shouldBeEatenPreyCoordinate.x != offset.x & shouldBeEatenPreyCoordinate.y != offset.y)
                {

                    ocean.preys -= 1;

                    timeToFeed = TimeToFeed;
                    timeToReproduce = TimeToReproduce;

                    MoveFrom(offset, shouldBeEatenPreyCoordinate);
                }

                else
                {
                    base.Process();
                }
            }
        }

        protected override void Reproduce(Coordinate coordinate)
        {
            ocean.predators += 1;
            AssignCellAt(coordinate, new Predator(coordinate));
        }
    }
}
