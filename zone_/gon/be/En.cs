using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon.be
{
	public class En<T> : nilnul.obj.be.En2<PolygonI, T>
		where T : BeI, new()
	{
		public En(PolygonI val) : base(val)
		{
		}
	}
}
