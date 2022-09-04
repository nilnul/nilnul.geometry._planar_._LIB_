using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.vect.be_.nonnil.vow;
using nilnul.geometry.planar.vect.be_.nonnil;
using nilnul.num;

namespace nilnul.geometry.planar.vect_
{
	public interface NonnilI
		:IVector
		

	{
		vect.be_.nonnil.vow.Ee vectoree { get; }
	}
	public class Nonnil : vect.be_.nonnil.vow.Ee
		,
		NonnilI
		,
		IVector
	{
		public Nonnil(VectorI val) : base(new Vector1(val.x,val.y))
		{
		}

		public Nonnil(IVector val) : base(val)
		{
		}

		public Nonnil(Vector1 vector):base((IVector)vector)
		{

		}

		public Nonnil(Point1 point1):this(new Vector1(point1))
		{
		}

		public Nonnil(RealI realI1, RealI realI2):this(
			new Vector1(realI1,realI2)
		)
		{
		}

		public Point1 point =>base.ee.point ;

		public Ee vectoree => this;
	}
}
