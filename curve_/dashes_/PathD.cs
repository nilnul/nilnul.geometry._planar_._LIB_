using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PointDuo = nilnul.geometry.planar.point.Duo;

using PointStr = nilnul.geometry.planar._point.pointD._str.EnumerableOfPointD;
using Point = nilnul.geometry.planar._point.PointD;
using Point1 = nilnul.geometry.planar._point.PointD;
using PointD = nilnul.geometry.planar._point.PointD;

namespace nilnul.geometry.planar._path
{

	public class PathD
	{

		private PointDuo __base_PointDuo;

		public PointDuo base_pointDuo
		{
			get { return __base_PointDuo; }
			set { __base_PointDuo = value; }
		}

		private PointStr _laterPoints;

		public PointStr laterPoints
		{
			get { return _laterPoints; }
			set { _laterPoints = value; }
		}

		public IEnumerable< PointD> genBegins() {
			yield return __base_PointDuo.begin;

			IEnumerable<PointD> laterBegins;
			if (_laterPoints.Any())
			{
				yield return __base_PointDuo.end;

				for (int i = 0; i < _laterPoints.Count()-1; i++)
				{
					yield return _laterPoints.ElementAt(i);
				}



			}
		}

		public IEnumerable< PointD> genEnds() {
			yield return __base_PointDuo.end;

			if (_laterPoints.Any())
			{

				for (int i = 0; i < _laterPoints.Count(); i++)
				{
					yield return _laterPoints.ElementAt(i);
				}



			}
		}

		public int duosCountEval() { return _laterPoints.Count() + 1; }

		public IEnumerable<point.Duo>  duos{
			get {
				var begins = genBegins();
				var ends = genEnds();
				for (int i = 0; i < duosCountEval(); i++)
				{
					yield return new PointDuo(begins.ElementAt(i), ends.ElementAt(i));
				}




			}
		}

		public double distance {
			get {
				return duos.Sum(d=>point.DuoX.Distance(d));

			}
		}

		


			
		







	}
}
