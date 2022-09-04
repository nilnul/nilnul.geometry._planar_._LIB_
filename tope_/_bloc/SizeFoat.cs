using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_._bloc
{
	/// <summary>
	/// fix the SizeF , in which negative are allowed.
	/// 
	/// 
	/// </summary>
	public class SpreadFloat
	{
		private nilnul.num.ieeeF.be_.NonNeg.En _width;

		public nilnul.num.ieeeF.be_.NonNeg.En width
		{
			get { return _width; }
			set { _width = value; }
		}

		private nilnul.num.ieeeF.be_.NonNeg.En  _height;

		public nilnul.num.ieeeF.be_.NonNeg.En height
		{
			get { return _height; }
			set { _height = value; }
		}

		public SpreadFloat(nilnul.num.ieeeF.be_.NonNeg.En width,nilnul.num.ieeeF.be_.NonNeg.En  height )
		{
			_width = width;
			_height = height;
		}

		/// <summary>
		/// information is kept, data lost.
		/// </summary>
		public void normalize() {
			if (_width.avowed==0 || _height.avowed==0)
			{
				_height = new num.ieeeF.be_.NonNeg.En( 0f);
				_width = new num.ieeeF.be_.NonNeg.En( 0f);
			}
		}

		static public SpreadFloat CreateByAbs(float width,float height) {
			return new SpreadFloat(
				new num.ieeeF.be_.NonNeg.En(Math.Abs( width))
				,
				new num.ieeeF.be_.NonNeg.En(Math.Abs( height))	
			);
		}

		static public SpreadFloat CreateFromDiagonal(PointF x, PointF y) {
			return new SpreadFloat(
				nilnul.geometry.planar.point.duo.to_._Shift.Abs(x,y)
				,nilnul.geometry.planar.point.duo.to_._Raise.Abs(x,y)
					
					
			);
		}


		static public implicit operator SizeF(SpreadFloat size) {
			return new SizeF(size.width.avowed, size.height.avowed);
		}



	}
}
