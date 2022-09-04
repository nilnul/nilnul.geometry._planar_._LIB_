using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = nilnul.geometry.planar._point.PointD;
using Point1 = nilnul.geometry.planar._point.PointD;
using PointD = nilnul.geometry.planar._point.PointD;


namespace nilnul.geometry.planar.point.s.b
{
	public class Distinct
	{

		static public bool _Eval(PointD point,  IEnumerable<PointD> _points__distinct) {

			return _points__distinct.All(
				x=>Ne.Eval(point, x)
					
			);

		}




		static public bool Eval(IEnumerable<PointD> points) {

			if (points.Count()==0)
			{
				return true;

			}
			return _Eval(points.First(), points.Skip(1));

		}


		static public bool Eval(params PointD[] points) {

			
			return Eval(points as IEnumerable<PointD>);

		}


	}
}
