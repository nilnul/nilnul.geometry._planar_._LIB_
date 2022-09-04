using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar._dir
{
	/// <summary>
	/// direction defined by two points
	/// </summary>
	public partial class DirD :nilnul.geometry.planar._point.pointD.duo.be.Irreflexive.Be.Asserted
	{
		public DirD(_point.pointD.Duo duo) :
			base(duo)
		{

		}
		public DirD(_point.PointD begin, _point.PointD end)
			:this(
				 new _point.pointD.Duo(begin,end)
				 )

		{

		}
	}
}
