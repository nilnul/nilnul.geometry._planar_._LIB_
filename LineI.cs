using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	public interface LineI
		
	{
		/// <summary>
		/// we have different methods to define a line. a dif pair of points is one of them; other only need an angel and a norm, for instance.
		/// </summary>
		nilnul.geometry.planar.point.twin_.Dif points { get; }
	}
}
