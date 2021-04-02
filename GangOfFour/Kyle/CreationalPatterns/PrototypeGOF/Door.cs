using System;

namespace PrototypeGOF
{
    public class Door : MapSite
    {
        private Room _room1;
        private Room _room2;
        private bool _isOpen = true;

        public Door() { }

        public Door(Room r1, Room r2)
        {
            _room1 = r1;
            _room2 = r2;
        }

        public Door(Door other)
        {
            _room1 = other._room1;
            _room2 = other._room2;
        }

        public virtual void Initialize(Room r1, Room r2)
        {
            _room1 = r1;
            _room2 = r2;
        }

        public virtual Door Clone()
        {
            return new Door(this);
        }

        public Room OtherSideFrom(Room room)
        {
            if (room == _room1)
            {
                return _room2;
            }
            else if (room == _room2)
            {
                return _room1;
            }
            else
            {
                return null;
            }
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
