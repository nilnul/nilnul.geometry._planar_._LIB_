using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Point1 = nilnul.geometry.planar.Point4dbl;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.point.co.be_
{
	/// <summary>
	/// not the same. Dif
	/// </summary>
	public class Dif
		:BeI
		,point.co.BeDblI
		

	{
		static public bool Eval(Co duo) {

			return
				!nilnul.geometry.planar.point.Eq2.Eq(
				
				duo.begin , duo.end);

		}

		public bool be(Point4dblI basis, Point4dblI finish)
		{
			return !geometry.planar.point.re_.Eq4dbl.Singleton.re(basis, finish);
			//throw new NotImplementedException();
		}

		static public bool Eval(Point1 point, Point1 point1) {

			return Eval(new Co(point,point1));

		}

		public bool be(Co obj)
		{
			return Eval(obj);
			//throw new NotImplementedException();
		}

		public bool be(CoD obj)
		{
			return planar.point.eq.NeD.Singleton.ne(obj.component, obj.component1);

		}


		static public Dif Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Dif>.Instance;
			}
		}


		//[Obsolete(nameof(dif.En))]
		//public class En:be.En<Line>
		//{
		//	public En(Duo1 duo):base(duo)
		//	{

		//	}



		//}

	}
}
