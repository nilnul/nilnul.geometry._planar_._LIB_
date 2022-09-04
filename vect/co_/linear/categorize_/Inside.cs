using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.linear.vect.co.categorize_._inside;
using nilnul.geometry.planar.vect.as_;
using nilnul.num;

namespace nilnul.geometry.planar.vect.duo_.linear.categorize_
{
	
	static public class _InsideX
	{
		
		 static public nilnul.geometry.linear.vect.co.categorize_._inside.Category _Categorize(PointI1 begin, PointI1 end, PointI1 _point_colinear)
		{

			return _Categorize(new Point1(begin), new Point1(end), new Point1(_point_colinear));
			
		}


		 static public nilnul.geometry.linear.vect.co.categorize_._inside.Category _Categorize(Point1 begin, Point1 end, Point1 _point_colinear)
		{

			return _Categorize(end - begin, _point_colinear - begin);
			
		}

		public static Category _Categorize(Base axis, Vector1 _point_colinear)
		{

			return nilnul.geometry.linear.vect.co.categorize_._InsideX.Inside(

				axis.opOfSelf()

				,
				axis.op(  _point_colinear -new Vector1(  axis.vector) )
			);
			//throw new NotImplementedException();
		}


		public static Category _Categorize(Vector1 v1, Vector1 _colinear)
		{

			return _Categorize(

				 new Base(v1)

				,
				_colinear
			);
			//throw new NotImplementedException();
		}


		public static Category _Categorize(Base axis, PointI1 _point_colinear)
		{

			return _Categorize(axis, new Vector1(_point_colinear) );
			//throw new NotImplementedException();
		}

	}


	
}
