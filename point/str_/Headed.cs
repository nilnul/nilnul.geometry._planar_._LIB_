using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.point.str
{
	public class Headed
	{
		private _point.PointD _head;

		public _point.PointD head
		{
			get { return _head; }
			set { _head = value; }
		}

		private point._str.EnumerableOfPointD _tail;

		public point._str.EnumerableOfPointD tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

	}
}
