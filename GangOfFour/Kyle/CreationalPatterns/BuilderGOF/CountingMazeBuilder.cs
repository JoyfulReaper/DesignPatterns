using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderGOF
{
    public class CountingMazeBuilder : MazeBuilder
    {
        private int _rooms;
        private int _doors;

        public CountingMazeBuilder()
        {
            _rooms = _doors = 0;
        }

        public override void BuildRoom(int room)
        {
            _rooms++;
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            _doors++;
        }

        public void GetCounts(out int rooms, out int doors)
        {
            rooms = _rooms;
            doors = _doors;
        }
    }
}
