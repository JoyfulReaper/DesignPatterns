using System;

namespace PrototypeGOF
{
    public class Wall : MapSite
    {
        public Wall()
        {

        }

        public Wall(Wall wall)
        {

        }

        public virtual Wall Clone()
        {
            return new Wall(this);
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
