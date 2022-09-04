using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{

	public interface IPointsDbl { }


	public interface PointsDblI1 : nilnul.ObjsI3<Point4dbl>

	{

	}

	[Obsolete()]
	public interface PointsDblI : nilnul.objs_.EnumerableI<Point4dbl>

	{

	}
	public class PointsDbl
		:
		
		nilnul.objs_.Enumable<Point4dbl>
		, PointsDblI
		,
		PointsDblI1
	{
		public PointsDbl(IEnumerable<Point4dbl> val) : base(val)
		{
		}
	}
}
