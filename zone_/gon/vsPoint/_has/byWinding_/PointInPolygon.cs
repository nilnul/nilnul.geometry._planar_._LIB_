using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.zone_.polygon.vsPoint
{

	/// <summary>
	/// <see cref="planar.loop_"/>
	/// </summary>
	public  class PointInPolygon
	{
		//  adapted from http://alienryderflex.com/polygon/
		
		/// Globals which should be set before calling this function:
		//
		//  int    polyCorners  =  how many corners the polygon has (no repeats)
		//  float  polyX[]      =  horizontal coordinates of corners
		//  float  polyY[]      =  vertical coordinates of corners
		//  float  x, y         =  point to be tested
		//
		//  (Globals are used in this example for purposes of speed.  Change as
		//  desired.)
		//
		//  The function will return YES if the point x,y is inside the polygon, or
		//  NO if it is not.  If the point is exactly on the edge of the polygon,
		//  then the function may return YES or NO.
		//
		//  Note that division by zero is avoided because the division is protected
		//  by the "if" clause which surrounds it.

		static public bool Eval(PointD point, Polygon polygon)
		{


			//int i, j = polygon.count;

			bool oddNodes = false;
			var polyCorners = polygon.count;
			var j=polyCorners;
			//var x = point.x;
			//var y = point.y;
			

			for (var  i = 0; i < polyCorners; i++)
			{
				if (
					polygon.val.ElementAt(i).y < point.y && polygon.val.ElementAt(j).y >= point.y
					|| polygon.val.ElementAt(j).y < point.y && polygon.val.ElementAt(i).y>= point.y
				)
				{
					if (
						polygon.val.ElementAt(i).x
						+ 
						(point.y - polygon.val.ElementAt(i).y) / (polygon.val.ElementAt(j).y-  polygon.val.ElementAt(i).y)
							* 
						( polygon.val.ElementAt(j).x- polygon.val.ElementAt(i).x)
						< 
						point.x

						// only one side is considered.
						
					)
					{
						oddNodes = !oddNodes;
					}
				}
				j = i;
			}

			return oddNodes;
		} 
	}
}
