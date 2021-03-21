using GOFLibrary.Maze;

namespace BuilderGOF
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return builder.GetMaze();
        }

        public Maze CreateComplexMaze(MazeBuilder builder)
        {
            // MazeBuilder can be reused to create differnt kinds of mazes. 
            // Pretend this is a complex maze

            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            builder.BuildRoom(3);
            builder.BuildRoom(4);
            builder.BuildDoor(3, 4);

            return builder.GetMaze();
        }
    }
}
