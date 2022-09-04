using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid_
{
	/// <summary>
	/// perpendicular to the horizon axis
	/// </summary>
	public class Wai4dbl
		:
		_grad_.VectDblI
	{
		private planar.Point4dbl _basement;

		public planar.Point4dbl basement
		{
			get { return _basement; }
			set { _basement = value; }
		}

		private nilnul.num.real_.NonnilDbl _displace;

		public nilnul.num.real_.NonnilDbl displace	
		{
			get { return _displace; }
			set { _displace = value; }
		}

		public Wai4dbl(planar.Point4dbl basement, nilnul.num.real_.NonnilDbl displace)
		{
			this._basement = basement;
			this._displace = displace;
		}

		public Wai4dbl(planar.Point4dbl basement,double displace)
			:
			this(
				basement,
				new num.real_.NonnilDbl(displace)
			)
		{
			
		}

		public bool beBigward {
			get {
				return _displace > 0;
			}
		}

		public planar.Point4dbl end { get {
				return new Point4dbl(
					_basement.x
					,
					_basement.y+_displace
				);
			} }

		public Vector4dblI vect => new vect_.Vertical4dbl(
			_displace
		);
	}
}
