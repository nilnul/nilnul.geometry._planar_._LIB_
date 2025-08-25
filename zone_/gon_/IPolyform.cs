using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_
{
	///en.wikipedia.org/wiki/Polyform
	/// 
	/// <summary>
	/// In recreational mathematics, a polyform is a plane figure or solid compound constructed by joining together identical basic polygons. The basic polygon is often (but not necessarily) a convex plane-filling polygon, such as a square or a triangle.
	/// </summary>
	/// <remarks>
	///Two basic polygons may be joined only along a common edge, and must share the entirety of that edge.
	///No two basic polygons may overlap.
	///A polyform must be connected (that is, all one piece; see connected graph, connected space). Configurations of disconnected basic polygons do not qualify as polyforms.
	///The mirror image of an asymmetric polyform is not considered a distinct polyform(polyforms are "double sided").
	/// </remarks>
	/// <see cref="gon_.perpend_.IPolyomino"/>
    public interface IPolyform
		:
		zone_.IPolygon
		///IGon
    {
    }


}
