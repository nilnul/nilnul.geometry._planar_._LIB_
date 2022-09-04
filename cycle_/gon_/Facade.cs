using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_
{
	public class Facade4dbl
		:
		gon.be_.stokes_.front.vow.Ee4dbl
		,
		cycle_.Polygon4dblI
	{
		public Facade4dbl(Polygon4dbl val) : base(val)
		{
		}
		public Facade4dbl(Polygon4dblI val) : base(val)
		{
		}
		

		public Facade4dbl(IEnumerable<Point4dblI> enumerable) : this(
			new Polygon4dbl(enumerable)
			)
		{
		}


			public Facade4dbl(params Point4dblI[] enumerable) : this(
			(IEnumerable<Point4dblI>)(enumerable)
			)
		{
		}

		public Facade4dbl(params (double,double)[] p1):this(
			p1.Select(x=>new planar.Point4dbl(x))
		)
		{
		}

		public IEnumerable<Point4dblI> vertexes => ee.vertexes;

		public IEnumerable<Grad4dbl_byPointsI> grads => boxed.grads;


		static public IEnumerable<Point4dblI> _MakePositiveTurn(
			IEnumerable<Point4dblI> points
		)
		{
			return coil_.gon_.facade.of_._OfCoilByReverseIfNecessaryX._MakeStokesNonneg_assumeCoil(points);
			

		}

		public static Facade4dbl Of_reverseIfNecessary(IEnumerable<Point4dblI> val)

		{
			return new Facade4dbl(_MakePositiveTurn(val));

		}
	}
}
