using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry
{
	[Obsolete(nameof(nilnul.geometry.original.IPoint))] // original is included in higher dimensional geometry
	public interface IPoint { }
	/// <summary>
	/// geometry starts with point; may be a 0-d point, 1-d point, 2-d point, n-d point
	/// </summary>
	public interface PointI:IPoint
	{
	}
}
