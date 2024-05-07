using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.net._graph.vertex
{
	public class Dict<T,TEq>:nilnul.obj.Dict<T, nilnul.geometry.planar.Point1, TEq>
		where TEq:IEqualityComparer<T>,new()
	{


	}
}
