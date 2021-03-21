using GOFLibrary.Maze.EnchantedMapSite;
using GOFLibrary.Maze.MapSite;

namespace AbstractFactoryGOF
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int roomNo)
        {
            return new EnchantedRoom(roomNo, CastSpell());
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
