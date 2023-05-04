using Maya.Drawing;
namespace Maya.Engine
{
    public class Player : MayaEngine, IMayaEngine, IMove, IAnimation, IPlayer
    {
        public string _name { get; set; }
        public string _type { get; set; }
        public Sprites _sprites { get; set; }
        public MayaAnimation animation { get; set; }

        public Player() { }

        public void Animate()
        {
        }

        public void Move() 
        {
        }

        // like shoot, attack
        public void Action()
        {
        }

        public void CheckBounds()
        { }

        public bool _isMoved;
        public bool _Moving;

        public int _posX;
        public int _posY;
        public int _dx;
        public int _dy;
    }
}
