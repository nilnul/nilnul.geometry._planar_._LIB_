using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.comparer_.byY
{
	public class Decider
		:nilnul.comparer.decider_.FroStatic1<PointF,ByY>
	{

		static private Lazy<Decider> _Lazy = new Lazy<Decider>();
		static public Decider Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
