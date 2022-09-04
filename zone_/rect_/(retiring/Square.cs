using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.rect_
{
	/// <summary>
	/// note square can rotate. 
	/// </summary>
	public class Square4dbl
	{
		private Point4dblI _upperLeft;

		public Point4dblI upperLeft
		{
			get { return _upperLeft; }
			set { _upperLeft = value; }
		}

		private bloc_.Square4dbl _bloc;

		public bloc_.Square4dbl bloc
		{
			get { return _bloc; }
			set { _bloc = value; }
		}

		public Square4dbl(
			 Point4dblI upperLeft0

			,bloc_.Square4dbl bloc0

)
		{
			_upperLeft = upperLeft0;
			_bloc = bloc0;
		}




	}
}
