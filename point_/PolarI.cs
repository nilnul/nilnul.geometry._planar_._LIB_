using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point_
{
	/// <summary>
	/// a point defined polar coordiantes. In retrospect, we call cartesian coords as Orthic
	/// </summary>
	/// <seealso cref="nameof(_line_._norm.Norm)"/>

	public interface PolarI:_polar_.RadiusI, _polar_.RotationI
	{
	}
}
