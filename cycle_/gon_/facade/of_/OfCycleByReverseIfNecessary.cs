using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.facade.of_
{
	 public class OfCycleByReverseIfNecessary
		:
		facade.OfI< cycle_.Polygon4dblI>
	{
		


		static public IEnumerable<Point4dblI> _MakePositiveTurn(
			IEnumerable<Point4dblI> points
		)
		{
			return cloze_.gon_.facade.of_._OfClozeByReverseIfNecessaryX._MakeStokesNonneg_assumeStarted(points);

		}

		public static Facade4dbl _ReverseIfNecessary_assumeCycle(IEnumerable<Point4dblI> val)

		{
			return new Facade4dbl(_MakePositiveTurn(val));

		}

		public Facade4dbl of(Polygon4dblI arg)
		{
			return new Facade4dbl(
				_ReverseIfNecessary_assumeCycle(arg.vertexes)
			);
			//throw new NotImplementedException();
		}


		static public OfCycleByReverseIfNecessary Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OfCycleByReverseIfNecessary>.Instance;
			}
		}

	}
}
