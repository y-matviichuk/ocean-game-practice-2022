using OceanLibrary.GameCharacters;

namespace Ocean.GameCharacters
{
    internal class Obstacle : Cell
    {
        public Obstacle(Coordinate coordinate) : base(coordinate)
        {
            image = '#';
        }
    }
}
