using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_
{
	public class Wai4dbl
	{
		private planar.Point4dbl _basement;

		public planar.Point4dbl basement
		{
			get { return _basement; }
			set { _basement = value; }
		}

		private double _displace;

		public double displace	
		{
			get { return _displace; }
			set { _displace = value; }
		}

		public Wai4dbl(planar.Point4dbl basement,double displace)
		{
			this._basement = basement;
			this._displace = displace;
		}

		

		public planar.Point4dbl end { get {
				return new Point4dbl(
					_basement.x
					,
					_basement.y+_displace
				);
			} }



	}
}
