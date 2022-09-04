using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_
{
	public interface IConvex
		:
		IPolygon	///if it's convex, it must be simple. for nonsimples that cross then encircle it, the enclosed area including all points. but the points might still cross an edge. Note that how we define convex: no point.duo would cross ANY edge 
	{
	}
}
