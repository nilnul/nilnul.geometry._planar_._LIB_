using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.tetra_
{
	public class Square
	{
		private Point4dblI _upperLeft;

		public Point4dblI upperLeft
		{
			get { return _upperLeft; }
			set { _upperLeft = value; }
		}

		private num.real_.NonnegOfDoubleI _size;

		public num.real_.NonnegOfDoubleI size
		{
			get { return _size; }
			set { _size = value; }
		}


		public Square(
		 Point4dblI upperLeft0
			,
		 num.real_.NonnegOfDoubleI size0

		)
		{

			_upperLeft = upperLeft0;
			_size = size0;
		}

	}
}
