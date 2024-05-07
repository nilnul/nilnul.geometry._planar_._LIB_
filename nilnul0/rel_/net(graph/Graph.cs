using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.net
{
	public class Graph<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

		public nilnul.num.real_.PositiveI radius = new nilnul.num.real_.Positive(5);
		private nilnul.NetI<T,TEq> _net;

		public nilnul.NetI<T,TEq> net
		{
			get { return _net; }
			set { _net = value; }
		}

		private _graph.vertex.Dict<T,TEq> _vertices;

		public _graph.vertex.Dict<T,TEq> vertices
		{
			get { return _vertices; }
			set { _vertices = value; }
		}



		public string toSvg() {
			var sb = new StringBuilder();

			foreach (var item in _net.objs.toArr())
			{
				var p=_vertices[item];
				var c = new nilnul.geometry.planar.loop_.Circle1(
					p, 
					radius
				);

			}

			return sb.ToString();
		}
	}
}
