using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real_;

namespace nilnul.geometry.planar.point_
{
	/// <summary>
	/// when radius is zero, the rotation is meaningless and the information carried by it is lost. To keep this lost information, use "line_._byNorm.Norma" <see cref="nameof( nilnul.geometry.planar.line_._byNorm.Norm)"/>
	/// </summary>
	public class Polar : PolarI
	{

		public Polar(nilnul.num.real_.Nonneg radius, RotationI1 rotation)
		{
			_radius = radius;

			_rotation = rotation;


		}

		public void cannonize()
		{
			if (nilnul.num.real.be_.Nil.Singleton.be(radius))
			{

				_rotation = nilnul.geometry.planar.Rotation1.CreateZero();
			}
			

		}
		private NonnegI _radius;
		public NonnegI radius
		{
			get
			{
				return _radius;
				throw new NotImplementedException();
			}
		}

		private RotationI1 _rotation;

		public RotationI1 rotation
		{
			get
			{
				return _rotation;
			}
		}
		//static public Point1 operator -(Point1 a, Point1 b)
		//{
		//	return nilnul.geometry.planar.point.op_.binary_.Minus.Singleton.op(a, b);
		//}

	}
}
