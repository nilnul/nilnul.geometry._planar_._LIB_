using nilnul.geometry.planar.sub_.directed_.connected_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.cloze_.gon_
{
	/// <summary>
	/// there is a closing path, which is also the begining path. So there is only one path.
	/// It can be represented in SVG path as m3,4z.
	/// </summary>
	/// <remarks>
	///   for n-gon, we have n edges; for example, for digon, we have two edges.
	///   bu for monogon, we have no edges.
	///   So monogon is abnormal, and may be excluded from normal polygon
	/// </remarks>
	/// alias:
	///		unigon
	///	<see cref="sub_.polygon_"/>
	public class Monogon:Polygon
	{
		public Monogon(planar.PointI1 point)
			:base(new []{point})
		{

		}





	}
}
