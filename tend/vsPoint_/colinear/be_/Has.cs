using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.grad_;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.tend_;
using nilnul.num;

namespace nilnul.geometry.planar.tend.vsPoint_.coline.be_
{
	static public class _HasX
	{



		// Given three colinear points p, q, r, the function checks if
		// point q lies on line segment 'pr'
		static public bool _Has_ofColinear(Point1 begin, Point1 end, Point1 _point_colinear)
		{

			return planar.tend_.originated.vsPoint_.coline.be_._HasX._Has(
				end-begin,
				_point_colinear-begin
			);
			/// analog to a linear case:
			/// we can compare the coords of the point to the begin as well as the end to know its position.
			/// we do this by point - begin, and point -end to determin the relation of point vs begin and point vs end
			/// 
			/// for the planar case
			///		we project the point-begin, and point - end to the line of(begin, end) for the comparision


			//var sinceBeginProjecttion = nilnul.geometry.planar.vector.co.to_.real_.InnerProduct.Singleton.to(
			//	_point_colinear - begin
			//	,

			//	end - begin

			//).ToReal(); // to know the relative positon of point vs begin


			//var sinceEndProjecttion = nilnul.geometry.planar.vector.co.to_.real_.InnerProduct.Singleton.to(
			//	_point_colinear - end
			//	,

			//	end - begin

			//).ToReal(); // to know the relative positon of point vs begin


			//var sinceBeginSign = nilnul.num.real.Sign.Singleton.sign(sinceBeginProjecttion);
			//var sinceEndSign = nilnul.num.real.Sign.Singleton.sign(sinceEndProjecttion);

			//if (sinceBeginProjecttion < 0)  //intersect at the end point
			//{
			//	return false;
			//}
			//if (sinceBeginProjecttion == 0)
			//{
			//	return true;
			//}
			//if (sinceEndSign == false)
			//{
			//	return true;

			//}
			//if (sinceEndSign == null)
			//{
			//	return true;
			//}
			//return false;
		}


		public static bool _Has_ofColinear(point.Co x, Point1 point)
		{
			return _Has_ofColinear(x.begin,x.end,point);
			//throw new NotImplementedException();
		}
		public static bool _Has_ofColinear(IArrow y, Point1 end)
		{
			return _Has_ofColinear(y.points,end);
			throw new NotImplementedException();
		}

		public static bool _Has_ofColinear(tend_.EdgeI x, Point1 _point_colinear)
		{

			return _Has_ofColinear(x.pair.en.begin, x.pair.en.end, _point_colinear);
		}

		public static bool _Has_ofColinear(tend_.Edge x, Point1 _point_colinear)
		{

			return _Has_ofColinear((EdgeI)x, _point_colinear);
		}


		public static bool _Has_ofColinear(TendI x, Point1 _point_colinear)
		{

			return _Has_ofColinear(x.points.begin, x.points.end, _point_colinear);
		}

	}


	
}
