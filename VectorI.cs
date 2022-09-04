using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// 
	/// from origin to a point. So the vector can be a zero vector if the point is origin itself (from origin to origin)
	/// this is equi-cardianl to point
	/// </summary>
	/// <see cref="nameof(nilnul.geometry.planar.GradI)"/>
	public interface VectorI
	{
		 num.Real x { get; }
		 num.Real  y{ get; }

	}
}
