using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.linear
{
	public class PointDbl
		:PointDblI
		,
		_point_.Eks4dblI
	{
		private double _coord;

		public double coord
		{
			get { return _coord; }
			set { _coord = value; }
		}

		public double x => _coord;

		public PointDbl(double x)
		{
			_coord = x;
		}
		public PointDbl():this(0)
		{

		}
		static public PointDbl operator -(PointDbl x) {
			return new PointDbl(-x.coord);
		}
		static public bool operator ==(PointDblI x, PointDbl y) {
			return x.coord == y.coord;
		}

		static public bool operator !=(PointDblI x, PointDbl y) {
			return !( x == y);
		}

		static public bool operator ==(PointDbl x, PointDblI y) {
			return x.coord == y.coord;
		}
		static public bool operator !=(PointDbl x, PointDblI y) {
			return !( x == y);
		}


		static public PointDbl operator -(PointDblI x, PointDbl y) {
			return new PointDbl(x.coord - y.coord);
		}

		static public PointDbl operator -(PointDbl x, PointDblI y) {
			return new PointDbl(x.coord - y.coord);
		}

		static public bool operator <(PointDblI x, PointDbl y) {
			return x.coord < y.coord;
		}


		static public bool operator >(PointDblI x, PointDbl y) {
			return  x.coord > y.coord;
		}
		static public bool operator <(PointDbl x, double y) {
			return x.coord < y;
		}


		static public bool operator >(PointDbl x, double y) {
			return  x.coord > y;
		}

		static public bool operator <(PointDbl x, PointDblI y) {
			return x.coord < y.coord;
		}

		static public bool operator >(PointDbl x, PointDblI y) {
			return  x.coord > y.coord;
		}

		static public bool operator <=(PointDbl x, PointDblI y) {
			return x.coord <= y.coord;
		}

		static public bool operator >=(PointDbl x, PointDblI y) {
			return  x.coord >= y.coord;
		}

		static public bool operator <=(PointDblI x, PointDbl y) {
			return y>=x;
		}

		static public bool operator >=(PointDblI x, PointDbl y) {
			return  y<=x;
		}


	}
}
