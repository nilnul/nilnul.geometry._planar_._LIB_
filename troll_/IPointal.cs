using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.troll_
{
	/// <summary>
	/// a single point. not constant;
	/// </summary>
	/// <remarks>
	/// it is continuous (when its domain is continuous, and the mapping is continuous). But it is not curve, as the range is <see cref="num.real.borel_.crux_.IUnspanned"/>, not continuous.
	/// </remarks>
	/// alias:
	///		constant
	///		
    public interface IPointal:ITroll,planar.IPoint
    {
    }
}
