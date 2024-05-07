using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_
{
	/// <summary>
	/// the edges can be intersecting. for nonintersecting ones, <see cref="cycle_.IPolygon"/>;
	/// the direction can be negative, or positive.
	/// </summary>
	/// <remarks>
	/// as gon is a str of grads, and a grad requires two points, different or same,  so single point is not defined as gon.
	/// </remarks>
	/// alias:
	///		gon;
	///
	[Obsolete(nameof(IPolyGram))]
	public interface IPolygon
		:ICloze
		,
		sub_.directed_.connected_.IPolygon
		//,
		//curve_.piecewise_.IPolyseg
	{ }
	
}
