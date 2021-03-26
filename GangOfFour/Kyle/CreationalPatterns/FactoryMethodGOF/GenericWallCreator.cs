using GOFLibrary.Maze.MapSite;

namespace FactoryMethodGOF
{
    public class GenericCeator
    {
        public Wall CreateWall<T>() where T : Wall, new()
        {
            return new T();
        }
    }
}
