using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.net._graph
{
	public class Vertex<T>
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		private nilnul.geometry.planar.Point1 _coords;

		public nilnul.geometry.planar.Point1 coords
		{
			get { return _coords; }
			set { _coords = value; }
		}


	}
}
