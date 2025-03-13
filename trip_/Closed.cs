using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trip_
{
	/// <summary>
	/// include start point and end point;
	/// </summary>
	public interface IClosed :
		IClosedAtStart
		,
		IClosedAtEnd
	{
	}
}
