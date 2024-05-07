using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	/// the length is finite
	/// </summary>
	/// alias:
	///		curl,<see cref="planar.ICurl"/>
	///		bounded, not boundaried which is constraints by a bloc. but if it's bounded, it is boundaried. not vice versa, as a boundaried curve can be unbounded.
	public interface IFinite : ICurve
	{
	}
}
