namespace PrototypeGOF
{
    public class BombedWall : Wall
    {
        public BombedWall()
        {

        }

        public BombedWall(BombedWall wall)
        {

        }

        public override Wall Clone()
        {
            return new BombedWall(this);
        }
    }
}
