using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = nilnul.geometry.planar.Point4dbl;
using EdgeD = nilnul.geometry.planar.tend_.EdgeD;
using Point1= nilnul.geometry.planar.Point4dbl;
using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.point.trio.be_
{
	public class Distinct
		:planar.point.trio.BeI
		,
		planar.point.trio.BeDblI
	{
		static public bool Be(Point4dbl a, Point4dbl b, Point4dbl c) {
			return point.str_.seq.be_.Distinct.Singleton.be(a, b, c);
		}

		static public bool Be(planar.point.Trio trio) {
			return planar.point.str_.seq.be_.Distinct.Singleton.be(trio);
		}

		

		static public bool Be(TrioD trio)
		{
			return str_.seq.be_.Distinct.Singleton.be(trio);
		}

		public bool be(Trio obj)
		{
			return Distinct.Be(obj);

			throw new NotImplementedException();
		}

		public bool be(TrioD obj)
		{
			return Be(obj);
		}

		static public Distinct Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Distinct>.Instance;
			}
		}

	}
}
