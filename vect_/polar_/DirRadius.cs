using nilnul.geometry.planar.rotation_;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_
{
	/// <summary>
	/// if length is zero, direction is unimportant
	/// </summary>
	public class DirectionLength :

		planar.IVector
	{

		private nilnul.geometry.planar.rotation_.Direction _direction;

		public nilnul.geometry.planar.rotation_.Direction direction
		{
			get { return _direction; }
			set { _direction = value; }
		}

		private nilnul.num.real_.NonnegI _length;

		public nilnul.num.real_.NonnegI length
		{
			get { return _length; }
			set { _length = value; }
		}

		public DirectionLength(
nilnul.geometry.planar.rotation_.Direction direction
			,
nilnul.num.real_.NonnegI length
		)
		{
			_direction = direction;
			_length = length;

		}

		public DirectionLength(Direction dir, Real real):this(dir, new nilnul.num.real_.Nonneg(real))
		{
		}

		public Real x => point.x;

		public Real y => point.y;

		public Point1 point => new Point1(
			_length.ToReal() * nilnul.num.real.op_.unary_.Cos.Singleton.op(direction)
			,
			_length.ToReal() * nilnul.num.real.op_.unary_.Sin.Singleton.op(direction)
		);
	}
}
