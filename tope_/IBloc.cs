using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_
{
	/// <summary>
	/// a start point, with a size, where size is a couple of two nonnegs
	/// vs:
	///		point+vector
	///			pointA plus a vector downRight as a bloc might be the same with PointC plus a vector upLeft. 
	/// </summary>
	/// <remarks>
	///	Alias:
	///		boundary
	///		bounding
	///		brick
	///		crop
	///			rect
	///		bloc
	///			“b” also appears in "bounding box". bloc is a bounding box
	///		box
	///			reserved for 3d?
	///		subarea
	///		clip
	///			irregular?
	///		clop
	///		window
	///		guided
	///		blot
	///		clot
	///		rect
	///			rotated, translated, flipped?
	///		bounding:
	///			used as bounding box
	/// </remarks>
	/// Axis
	/// Aligned
	/// Bounding
	/// Box

	///
	public interface IBloc
		:geometry.planar.grad_.based_.nonneg.IBloc
		,
		ITope
	{

	}
}
