using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point
{
	public class Quo4dbl
	{
		private Point4dblI _d;

		public Point4dblI d
		{
			get { return _d; }
			set { _d = value; }
		}

		private TrioD _trio;

		public TrioD trio
		{
			set { _trio = value; }
		}


		public Point4dblI a
		{
			get { return _trio.a; }
		}

		public Point4dblI b
		{
			get { return _trio.b; }
		}
		public Point4dblI c
		{
			get { return _trio.c; }
		}

		public Quo4dbl(TrioD trio, Point4dblI d)
		{
			_trio = trio;
			_d = d;
		}
		public Quo4dbl(Point4dblI a, Point4dblI b, Point4dblI c, Point4dblI d)
			:this(
				new TrioD(a,b,c)
				 ,
				d 
			)
		{

		}

		public IEnumerable<Point4dblI> enumerate() {
			foreach (var item in _trio.AsEnumerable())
			{
				yield return item;
			}
			yield return _d;
		}


	}
}
