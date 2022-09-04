using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	/// donnot self-intersect.
	/// cloze (cut into one end being close, one end being open) can also be simple
	/// </summary>
	/// vs: singular in math
	///		singular means unique tangent exists everywhere.
	public interface ISimple:ICurve
	{
	}
}
