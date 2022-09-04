using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.bloc_.nontrivia.potence_.interpolate_.bilinear_
{
	/// <summary>
	/// the four points diffeent.
	/// </summary>
	public class OfCorners
	{
		

		private nilnul.num.ieee.duo.be_.Lt.En _row;

		public nilnul.num.ieee.duo.be_.Lt.En row
		{
			get { return _row; }
			//set { _row = value; }
		}

		private nilnul.num.ieee.duo.be_.Lt.En _col;

		public nilnul.num.ieee.duo.be_.Lt.En col
		{
			get { return _col; }
			//set { _col = value; }
		}
		/// <summary>
		/// the z-value 
		/// </summary>
		private double[,] _data;

		public double[,] data
		{
			get { return _data; }
			set { _data = value; }
		}

		public OfCorners(nilnul.num.ieee.duo.be_.Lt.En row, nilnul.num.ieee.duo.be_.Lt.En col, 

			double[,] data)
		{

			nilnul.obj.AssertX.True(
				data.GetLength(0)==2
			);
			nilnul.obj.AssertX.True(
				data.GetLength(1)==2
			);

			_row = row;
			_col = col;
			_data = data;
		}

		public OfCorners(
			double x, double x1
			,double y, double y1
			,
			double [,] heights
			)
			:this(

				new  nilnul.num.ieee.duo.be_.Lt.En(x,x1),
				new  nilnul.num.ieee.duo.be_.Lt.En(y,y1)
				 ,heights

				)
		{

		}



		public double polate(Point4dbl p) {
			double x = p.x;
			if (p.x<row.avowed.Item1)
			{
				x = row.avowed.Item1;
				///truncate x to be the minimal

			}
			if (p.x >row.avowed.Item2)
			{
				x = row.avowed.Item2;
			}

			double y = p.y;
			var minY = col.avowed.Item1;
			if (p.y<minY)
			{
				y = minY;
			}

			if (p.y > col.avowed.Item2)
			{
				y = col.avowed.Item2;

			}

			return _interPolate_pointIn(x,y);

		}


		public double _interPolate_pointIn(double _x_in, double _y_in)
		{
			var preMatrix = new double[] {
				_row.avowed.Item2-_x_in
				,
				_x_in-  _row.avowed.Item1
			};
			var postMatrix = new double[] {
				_col.avowed.Item2 - _y_in
				,
				_y_in-_col.avowed.Item1
			};
			return nilnul.num.ieee.matrix.str_.startedProductable.Product.Singleton._eval(

				nilnul.matrix.Extensions.ToMatrix(
					preMatrix
				)
				,
				data
				,
				nilnul.matrix.Extensions.ToMatrixVertical(
				
					postMatrix)
				
			)[0,0]/ ( _row.avowed.shift * _col.avowed.shift);
			;


			//throw new NotImplementedException();
		}
	}
}
