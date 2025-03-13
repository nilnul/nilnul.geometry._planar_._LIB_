using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = nilnul.geometry.planar.Point4dbl;
using EdgeD = nilnul.geometry.planar.tend_.EdgeD;
using nilnul.geometry.planar.point.trio.be_;
using Point1 = nilnul.geometry.planar.Point4dbl;
using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.point.trio.be_.distinct.vow
{
	/// <summary>
	/// 
	/// </summary>





	public class EeDbl
		
		: planar.point.trio.vow.ee_.VowDefaultD<planar.point.trio.be_.distinct.VowDbl>
	{

		public EeDbl(TrioD val)
			: base(val)
		{

		}

		public double angle()
		{
			return new planar.angle_.Points4dbl (ee).azimuth;
		}

		/// <summary>
		/// as an angle, the initial ray
		/// </summary>
		/// <returns></returns>
		public EdgeD root()
		{
			return new EdgeD(
				ee.b, ee.a
			);
		}
		public EdgeD stop()
		{
			return new EdgeD(
				ee.b, ee.c
			);
		}

		public IEnumerable<EdgeD> edges
		{
			get
			{
				yield return new EdgeD(ee.a, ee.b);
				yield return new EdgeD(ee.b, ee.c);
				yield return new EdgeD(ee.c, ee.a);
			}
		}

		public EdgeD edge_ab()
		{
			return new EdgeD(ee.a, ee.b);
		}

		public EdgeD edge_bc()
		{
			return new EdgeD(ee.b, ee.c);
		}

		public EdgeD edge_ca()
		{
			return new EdgeD(ee.c, ee.a);
		}

		public EeDbl toReverse()
		{
			return new EeDbl(
				ee.toReverse()
			);
		}

		static public EeDbl _Create(IEnumerable<Point4dbl> points)
		{
			return new EeDbl(TrioD._Create(points));
		}






	}


}
