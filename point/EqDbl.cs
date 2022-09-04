using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace nilnul.geometry.planar.point
{
	public interface EqDblI
		:
		IEqualityComparer<Point4dbl>,
		IEqualityComparer<Point4dblI>

	{ }
 	public class EqDbl
		:    IEqualityComparer<Point4dbl>
		,EqDblI
	{


		static public EqDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EqDbl>.Instance;
			}
		}


		static public bool Eq(Point4dbl x, Point4dbl y)
		{
			return x.x == y.x && x.y == y.y;
		}

		static public bool Eq(Point4dblI x, Point4dblI y)
		{
			return x.x == y.x && x.y == y.y;
		}



		public   bool Equals(Point4dbl x, Point4dbl y)
		{
			return Eq(x, y);
 		}

		public   bool Equals(Point4dblI x, Point4dblI y)
		{
			return Eq(x, y);
 		}

		public   int GetHashCode(Point4dbl obj)
		{
			return obj.x.GetHashCode() ^ obj.y.GetHashCode();

 		}

		public   int GetHashCode(Point4dblI obj)
		{
			return obj.x.GetHashCode() ^ obj.y.GetHashCode();

 		}
	

		static public bool Eval(Point4dbl x, Point4dbl y)
		{
			return x.x == y.x && x.y == y.y;
		}


		
	}


}
