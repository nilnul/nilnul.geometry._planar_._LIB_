using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_
{
	/// <summary>
	/// locally resemble(continous mapping) a n dimensional space(full space)
	/// in other words, manifold is
	///		1) of interger dimension
	///		2) continuous (mappable continuously to a euclidean space)
	/// </summary>
	enum Manifold
	{
		Point
			,
		Curve
			,
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// alias:
		///		zone
		///		shape
		/// </remarks>
		Region
	}
}
