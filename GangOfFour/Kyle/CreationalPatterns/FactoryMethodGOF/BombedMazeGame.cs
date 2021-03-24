using GOFLibrary.Maze.BombedMazeSite;
using GOFLibrary.Maze.MapSite;

namespace FactoryMethodGOF
{
    public class BombedMazeGame : MazeGame
    {
        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int n)
        {
            return new RoomWithABomb(n);
        }
    }
}
