using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trace_
{
	/// <summary>
	/// point0curve can be sequential. 
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		directed
	///		sequential
	///		traject
	/// 
	public interface IDirected :
		point.IMoving, ITrail, manifold_.INil0oneDimension
	{

	}

}
