using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	public class Size : SizeI
	{
		private _linear.LengthI1 _width;

		public _linear.LengthI1 width
		{
			get { return _width; }
			set { _width = value; }
		}

		private _linear.LengthI1 _height;

		public _linear.LengthI1 height
		{
			get { return _height; }
			set { _height = value; }
		}


		public Size(_linear.LengthI1 width, _linear.LengthI1 height)
		{
			_width = width;
			_height = height;
		}

	



		public override string ToString()
		{
			return $"{_width.ToString()}*{_height.ToString()}";
		}


	}
}
