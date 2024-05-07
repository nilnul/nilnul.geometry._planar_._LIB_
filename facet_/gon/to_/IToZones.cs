using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.gon.to_
{
	/// <see cref="nilnul.geometry.planar.coil_.gon_.conduit_.flake.of_.err_.IAntizones"/>
	/// <summary>
	/// for each hole, find the other conduit in opposite direction.
	/// the conduit might end at another hole.
	///		for that hole, goes to it's conduit start point, and follows its edges to it's other conduit start, then follows the conduit,
	///		, to the other hole, or to the outside.
	///
	/// We can find the way to outside. and we can also find the way to outside in the other direction.
	///
	/// Thus we partitioned the gon into two.
	///
	/// and for each, we can further partition until each component is a zone.
	/// 
	/// </summary>
	/// alias:
	///		dissection:
	///			en.wikipedia.org/wiki/Dissection_problem
	internal class IToZones
	{

		/// in a U-shaped with two hole at each upper protruding peninsula,
		///		, <see cref="cycle_.gon_.antiwise.str_.Disjoint"/> 
		///		, <see cref="cycle_.gon_.antiwise.str."/> 
	}
}
