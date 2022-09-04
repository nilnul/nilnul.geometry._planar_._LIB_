﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon
{
	/// don't place as extension to <see cref="planar.point.str_.started"/>, as this is a cloze, not a simple curve. The last point shall be connected to the first point.
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="sub_.directed_.connected_._polygon.vertexes._GradsX"/>
	static public class _Grads4dblX
	{
	
		static public IEnumerable<planar.Grad4dbl_byPoints> _Grads_ofStarted(
			this IEnumerable<Point4dblI> _headed
		) {

			return _PointCoEs_ofStarted(_headed).Select(x=> new Grad4dbl_byPoints(x));
		}

		static public IEnumerable<(Point4dblI, Point4dblI)> _PointCoEs_ofStarted(this IEnumerable<Point4dblI> _points_distinct)
		{
			var last = _points_distinct.Last();
			foreach (var item in _points_distinct)
			{
				yield return (last, item);
				last = item;
			}
		}





	}
}