using nilnul.geometry._2d.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar._cloze
{
	public partial class HeadedPointsD
	{
		private _point.PointD _origin;

		public _point.PointD origin
		{
			get { return _origin; }
			set { _origin = value; }
		}

		private point._str.EnumerableOfPointD _middlePoints;

		public point._str.EnumerableOfPointD middleDots
		{
			get { return _middlePoints; }
			set { _middlePoints = value; }
		}

		 public IEnumerable<_point.PointD> begins {
			get {
				yield return _origin;
				foreach (var item in middleDots)
				{
					yield return item;
				}
			}

		}


		public IEnumerable<_point.PointD> ends
		{
			get {

				foreach (var item in middleDots)
				{
					yield return item;
				}
				yield return _origin;


			}
		}

		public int edgeCount {
			get {
				return _middlePoints.Count() + 1;
			}
		}


		public IEnumerable<point.Duo> pointDuos
		{
			get {

				for (int i = 0; i < edgeCount; i++)
				{
					yield return new point.Duo(begins.ElementAt(i), ends.ElementAt(i));


				}
				
			}

		}

		public double area {
			get {
				return point.duo.StrX.Area(pointDuos);
			}
		}

		public _point.PointD centroid {
			get {
				var area = this.area;
				return new _point.PointD(
					pointDuos.Sum(
						d=>(d.begin.x+d.end.x )*(d.begin.x *d.end.y-d.end.x*d.begin.y)
					)
					/
					(6*area)	
					,
					pointDuos.Sum(
						d=>(d.begin.y+d.end.y )*(d.begin.x *d.end.y-d.end.x*d.begin.y)
					)
					/
					(6*area)	


				);//http://wwwf.imperial.ac.uk/~rn/centroid.pdf, http://paulbourke.net/geometry/polygonmesh/

			}
		}




	

	}
}
