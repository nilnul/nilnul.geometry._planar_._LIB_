using nilnul.geometry.planar.point.trio.be_.tripod.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.trigon_
{
	public abstract class BaseOne4DblA
		:
		cloze_._gon_.Vertexes4dblI
		,
		cloze_._trigon_.Vertexes4dblI
	{

		private nilnul.geometry.planar.Point4dblI _point2nd;

		public nilnul.geometry.planar.Point4dblI point2nd
		{
			get { return _point2nd; }
			set { _point2nd = value; }
		}

		public  IEnumerable<Point4dblI> vertexes =>  new[]{
			alfa
			,
			 bravo
			,
			charlie

		};

		public Point4dblI alfa => point_.Origin4dbl.Singleton;

		public Point4dblI bravo => point_.eks_.Unital4dbl.Singleton;

		public Point4dblI charlie =>_point2nd;

		public BaseOne4DblA(
			nilnul.geometry.planar.Point4dblI point2nd
		)
		{
			this._point2nd = point2nd;

		}

		
	}
}
