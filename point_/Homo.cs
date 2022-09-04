using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point_
{
	/// <summary>
	/// homogeneous coordinates
	/// <see cref="System.Drawing.co"/>
	/// </summary>
	public class Homo4dbl:


		Point4dblI
	{

		private double _horizon;

		public double horizon
		{
			get { return _horizon; }
			set { _horizon = value; }
		}

		private double _vertical;

		public double vertical
		{
			get { return _vertical; }
			set { _vertical = value; }
		}

		private nilnul.num.real_.NonnilDblI _w;

		public nilnul.num.real_.NonnilDblI w
		{
			get { return _w; }
			set { _w = value; }
		}

		public double x => _horizon/ this._w.dblee.ee;

		public double y => _vertical/this._w.dblee.ee;

		public Homo4dbl(double x0, double y0, nilnul.num.real_.NonnilDblI w0)
		{
			this._horizon = x0;
			this._vertical = y0;
			this._w = w0;
		}

	}
}
