using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point
{
	public class Quartet
	{
		private PointI1 _d;

		public PointI1 d
		{
			get { return _d; }
			set { _d = value; }
		}

		private Trio _trio;

		public Trio trio
		{
			set { _trio = value; }
		}


		public PointI1 a
		{
			get { return _trio.a; }
		}

		public PointI1 b
		{
			get { return _trio.b; }
		}
		public PointI1 c
		{
			get { return _trio.c; }
		}

		public Quartet(Trio trio, PointI1 d)
		{
			_trio = trio;
			_d = d;
		}
		public Quartet(PointI1 a, PointI1 b, PointI1 c, PointI1 d)
			:this(
				new Trio(a,b,c)
				 ,
				d 
			)
		{

		}

		public IEnumerable<PointI1> enumerate() {
			foreach (var item in _trio.AsEnumerable())
			{
				yield return item;
			}
			yield return _d;
		}


	}
}
