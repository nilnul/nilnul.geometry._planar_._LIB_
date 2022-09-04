
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.be_
{
	public class Distinct
		:
		planar.point.str.Be4dblI
		
	{
		public bool be(planar.point.str_.SeqI obj)
		{
			return nilnul.obj.str_.seq.be_.Distinct_eqDefault<PointI1, point.Eq2>.Singleton.be(obj);
		}


		public bool be(IEnumerable<PointI1> trio)
		{
			return be( new planar.point.str_.Seq(trio));
			;
		}
		public bool be(IEnumerable<Point4dblI> obj)
		{
			return nilnul.obj.str_.seq.be_.Distinct_eqDefault<Point4dblI, point.EqDbl>.Singleton.be(obj);
		}
		public bool be(IEnumerable<Point4dbl> trio)
		{
			return nilnul.obj.str_.seq.be_.Distinct_eqDefault<Point4dbl, point.EqDbl>.Singleton.be(trio);
			;
		}


		public bool be(params PointI1[] trio)
		{
			return be( new planar.point.str_.Seq(trio));
			;
		}

		public bool be(params Point4dbl[] trio)
		{
			return be( (IEnumerable<Point4dbl>)(trio));
			;
		}


		static public Distinct Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Distinct>.Instance;
			}
		}

	}
}
