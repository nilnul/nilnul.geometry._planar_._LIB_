using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.nonneg.vsPoint.be_
{
	
	static public class _HasX
	{
		/// <summary>
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		static public bool _Be(VectI _nonneg, linear.PointI p)
		{


			if (nilnul.num.real.be_.Negative.Singleton.be(p.x))
			{
				return false;
			}
			if (nilnul.num.real.re_.Gt.Lazy.re(p.x, _nonneg.end.x))
			{
				return false;
			}
			

			return true;
			
		}



		static public bool _Be(nilnul.num.RealI _nonneg, nilnul.num.RealI p)
		{
			return _Be(
				new linear.Vector(_nonneg)
				,
				new linear.Point(p)
			);
		}


		static public bool Be(vect_.Nonneg nonneg, PointI p) {

			return _Be(nonneg,p);
		}

	

		public static bool Be(RealI realI, linear.PointI vector2BeIncluded)
		{
			return Be(
				new linear.vect_.Nonneg(realI),vector2BeIncluded
			);
		}
		public static bool _Be_assumeNonneg(double _vect_nonneg, double point)
		{
			return point >= 0 && point <= _vect_nonneg;

		}

		public static bool Be(NonnegDbl v, Vect4dblI vectorDbl)
		{
			return nilnul.num.real.BoundDbl.CreateClose(0, v.end.coord).has(vectorDbl.end.coord);

		
		}
	}
}
