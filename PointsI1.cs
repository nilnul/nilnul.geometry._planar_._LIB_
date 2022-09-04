using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{

	public interface PointsI1:nilnul.objs_.EnumerableI<PointI>

	{

	}
	public class Points1
		:
		nilnul.objs_.Enumable<PointI>
		, PointsI1
	{
		public Points1(IEnumerable<PointI> val) : base(val)
		{
		}
	}
}
