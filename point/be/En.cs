using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.be
{
	public class En<T> : 
		nilnul.obj.be.En2<PointI, T>
		

		where T : BeI, new()
	{
		public En(PointI val) : base(val)
		{
		}
	}
}
