using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// a bounded curve
	/// of length gt 0. So single point is excluded.
	/// The curve shouldn't interset with it self.
	/// the length of the curve can not be infinite.
	/// the path is directional. for undirectional path, see:
	/// 
	/// </summary>
	public interface PathI
	{
	}

	/// <summary>
	/// nomenclature:
	///		one way means way is directional.
	///		Ray is directional and Way looks like ray; but ray is strait whileas way is curvous
	/// </summary>
	public interface WayI {

	}
}
