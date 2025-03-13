using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.sig_
{
	/// <summary>
	/// colinar, counterclock, or clock
	/// </summary>
	static public class _CoilX
	{
		static public bool? Sig( Point1 a,Point1 b, Point1 c) {

			return nilnul.num.real.Sign.Singleton.sign(
				planar.vect.co._CrossProductX.AreaOfParallelogram(
					b-a
					,
					c-b
				)
			);

		}
		static public bool? Sig( PointI1 a,PointI1 b, PointI1 c) {

			return Sig(new Point1(a),new Point1(b),new Point1(c));

		}

	}

	/// <summary>
	/// 
	/// </summary>
	/// 
	public class Coil : nilnul.obj.SignI<Trio>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>true:counterClock, false:clock, null: sameLine</returns>
		public bool? sign(Trio obj)
		{
			return _CoilX.Sig(obj.a,obj.b,obj.c);

			throw new NotImplementedException();
		}
		public bool? sign(Point1 a, Point1 b, Point1 c)
		{
			return _CoilX.Sig(a,b,c);

			throw new NotImplementedException();
		}



		static public Coil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Coil>.Instance;
			}
		}

	}
}
