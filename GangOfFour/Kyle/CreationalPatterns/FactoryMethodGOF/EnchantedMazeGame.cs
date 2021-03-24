using GOFLibrary.Maze.EnchantedMapSite;
using GOFLibrary.Maze.MapSite;

namespace FactoryMethodGOF
{
    public class EnchantedMazeGame : MazeGame
    {
        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }

        protected Spell CastSpell()
        {
            return new Spell();
        }
    }
}
