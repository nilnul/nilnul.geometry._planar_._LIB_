using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lap_
{
	/// <summary>
	/// to make this non self-intersect, 
	/// </summary>
	public interface IPolygon :
		lapse_.IPolygon, ILap
	{
	}
}
