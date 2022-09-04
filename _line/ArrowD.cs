using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar._line
{
	public partial class LineD :nilnul.geometry.planar._point.pointD.duo.be.Irreflexive.Be.Asserted
	{
		public LineD(_point.pointD.Duo duo) :
			base(duo)
		{

		}
		public LineD(_point.PointD begin, _point.PointD end)
			:this(
				 new _point.pointD.Duo(begin,end)
				 )

		{

		}
	}
}
