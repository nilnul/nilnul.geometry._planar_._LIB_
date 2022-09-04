using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;
using RI = nilnul.num.RealI;
using nilnul.num;
using nilnul.geometry.planar._rotation;

namespace nilnul.geometry.planar
{
	
	

	public class Rotation4dbl<T>:
		nilnul.geometry.linear_._measured.Mark4dblA<T>
		
		,
		RotationOfDoubleI<T>
		where T: _rotation.Unit4dblI
	{

		public Rotation4dbl(double quantity0, T unit0):base(quantity0,unit0)
		{
			
		}


	}
	public class Rotation4dbl
		:
		Rotation4dbl<_rotation.Unit4dblI>
	{
		public Rotation4dbl(double quantity0, Unit4dblI unit0) : base(quantity0, unit0)
		{
		}

		static public Rotation4dbl operator -(Rotation4dbl x, Rotation4dbl b) {
			return new rotation_.Radian4dbl(
				x.toStd()
				-
				b.toStd()
			);
		}
	}
}