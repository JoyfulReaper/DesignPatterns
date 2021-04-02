using System;

namespace PrototypeGOF
{
    public class Room : MapSite
    {
        public int RoomNum { get; private set; }
        MapSite[] _sides = new MapSite[4];

        public Room() {}

        public Room(int roomNo)
        {
            RoomNum = roomNo;
        }

        public Room(Room other)
        {
            for(int i =0; i < other._sides.Length; i++)
            {
                if(other._sides[i] is Wall)
                {
                    _sides[i] = new Wall();
                }
                else if(other._sides[i] is Door)
                {
                    _sides[i] = new Door();
                }
            }

            RoomNum = other.RoomNum;
        }

        public virtual void Initialize(int roomNo)
        {
            RoomNum = roomNo;
        }

        public virtual Room Clone()
        {
            return new Room(this);
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            _sides[(int)direction] = mapSite;
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
