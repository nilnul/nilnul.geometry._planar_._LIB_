using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.cloze_.gon_
{
	public  class Digon:IDi
	{
		private planar.PointI1 _start;

		public planar.PointI1  start
		{
			get { return _start; }
			set { _start = value; }
		}
		private planar.PointI1 _end;

		public planar.PointI1 end
		{
			get { return _end; }
			set { _end = value; }
		}
		public Digon(planar.PointI1 p, planar.PointI1 p1)
		{
			this.start = p;
			this.end = p1;

		}

		
	}
}
