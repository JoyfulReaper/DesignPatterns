namespace PrototypeGOF
{
    public class RoomWithABomb : Room
    {
        public RoomWithABomb()
        {

        }

        public RoomWithABomb(int roomNumber) : base (roomNumber)
        {

        }

        public RoomWithABomb(RoomWithABomb room)
        {

        }

        public override Room Clone()
        {
            return new RoomWithABomb(this);
        }
    }
}
