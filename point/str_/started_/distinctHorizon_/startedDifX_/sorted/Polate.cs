using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.str_.started;

namespace nilnul.geometry.planar.points_.started_.distinctHorizon_.sorted
{
	/// <summary>
	/// With a started str of points that is ordered ascendently, output a number interpolatedly:
	///		if input lt than all, the image of the lowest point should be given
	///		if input gt than all, the image of the largest point should be given.
	/// </summary>
	public class PolateDbl
		:

		nilnul.num.ieee.OpI
		

	{
		private SortedByHorizonDbl _seededRel;

		public SortedByHorizonDbl seededRel
		{
			get { return _seededRel; }
			set { _seededRel = value; }
		}




		public PolateDbl(SortedByHorizonDbl seededRel)
		{
			_seededRel = seededRel;
		}

		public double eval(double arg)
		{
			return eval_byClamp(arg);


		}

		public double eval_byCase(double arg)
		{
			if (arg < _seededRel.minAbscissa )
			{
				return _seededRel.result.ee.First().y;
			}
			if (arg > _seededRel.maxAbscissa)
			{
				return _seededRel.result.ee.Last().y;


			}



			var upper = _seededRel.result.ee.First(x => x.x >= arg);


			var lower = _seededRel.result.ee.Last(
				x => x.x<= arg);

			return point.co.be_.injective.vow.EeDbl._InterPolate__duoInjective_xWithin(
				lower, 
				upper, 
				arg
			);


		}

		public double eval_byClamp(double arg)
		{
			var argClamped = arg;
			if (arg < _seededRel.minAbscissa)
			{
				argClamped=_seededRel.minAbscissa;
			}
			if (arg > _seededRel.maxAbscissa)
			{
				argClamped = _seededRel.maxAbscissa;
				//return _seededRel.processed.avowed.Last().y;


			}

			return _interpolate_argWithin(argClamped);

		


		}
		public double _interpolate_argWithin(double arg)
		{

			var upper = _seededRel.result.ee.First(x => x.x >= arg);


			var lower = _seededRel.result.ee.Last(
				x => x.x <= arg);

			return point.co.be_.injective.vow.EeDbl._InterPolate__duoInjective_xWithin(
				lower,
				upper,
				arg
			);


		}


	}
}
