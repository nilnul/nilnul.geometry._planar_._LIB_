using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point
{
	public class CoDbl : nilnul.obj.Co<linear.PointDblI>
	{
		public CoDbl(Tuple<PointDblI, PointDblI> tuple) : base(tuple)
		{
		}

		public CoDbl(Tuple<PointDbl, PointDbl> tuple):this( new Tuple<PointDblI, PointDblI>(tuple.Item1,tuple.Item2))
		{
		}

		public CoDbl((PointDblI, PointDblI) p):base(p)
		{
		}

		public CoDbl(PointDblI item1, PointDblI item2) : base(item1, item2)
		{
		}

		public CoDbl(double tgtStart, double tgtEnd)
			:
			this(new PointDbl(tgtStart),new PointDbl(tgtEnd) )
		{
		}
	}
}
