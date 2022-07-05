using System.Drawing;

namespace TopDownshooter
{
	class Player : MovableObject
	{
		public Player(Point location, Size size, Image image, Point speed) : base(location, size, image, speed)
		{

		}
		public override void Move()
		{
			World.WorldShift.X += speed.X;
			World.WorldShift.Y += speed.Y;
		}
		public override void DrawImage(System.Drawing.Graphics gr)
		{

		}
	}
}
