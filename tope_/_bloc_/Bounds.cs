using nilnul.geometry.planar._area;
using nilnul.geometry.planar.tope_._bloc;
using nilnul.num.real.bound_;
using System.Collections.Generic;
using System.Drawing;

namespace nilnul.geometry.planar.tope_._bloc_
{
	public interface BoundsI
	{
		ClosedDbl boundX { get;  }
		ClosedDbl boundY { get;  }
	}
}