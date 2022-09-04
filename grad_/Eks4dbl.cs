using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_
{
	public class Eks4dbl
		:Grad4dbl_byPointsI
	{
		private planar.Point4dblI _basement;

		public planar.Point4dblI basis
		{
			get { return _basement; }
			set { _basement = ( value ); }
		}

		private double _displace;

		public double displace	
		{
			get { return _displace; }
			set { _displace = value; }
		}

		public Eks4dbl(planar.Point4dblI basement,double displace)
		{
			this._basement = basement;
			this._displace = displace;
		}

		

		public planar.Point4dblI finish { get {
				return new Point4dbl(
					_basement.x+_displace
					,
					_basement.y
				);
			} }


	}
}
