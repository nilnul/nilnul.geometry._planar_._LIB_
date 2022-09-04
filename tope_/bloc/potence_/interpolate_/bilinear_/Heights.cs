using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.bloc.potence_.interpolate_.bilinear_
{
	/// <summary>
	/// the rows are different; the cols are different
	/// </summary>
	public class OnLattice
	{
		

		private nilnul.num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed _row;

		public nilnul.num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed row
		{
			get { return _row; }
			//set { _row = value; }
		}

		private nilnul.num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed _col;

		public nilnul.num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed col
		{
			get { return _col; }
			//set { _col = value; }
		}
		/// <summary>
		/// z-val of each coord
		/// </summary>
		private double[,] _data;

		public double[,] data
		{
			get { return _data; }
			set { _data = value; }
		}



		public OnLattice(nilnul.num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed row, nilnul.num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed col, 

			double[,] data)
		{

			nilnul.obj.AssertX.True(
				data.GetLength(0)==row.processed.avowed.Count()
			);
			nilnul.obj.AssertX.True(
				data.GetLength(1)==col.processed.avowed.Count()
			);

			_row = row;
			_col = col;
			_data = data;
		}

		public OnLattice(double[] v1, double[] v2, double[,] v3)
			:this(
				 new num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed(v1)

				 ,new num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed(v2)
				 ,v3
				 )
		{
		}

		public double polate(double x, double y) {


			double xR =x;
			if (x < row.processed.avowed.Min())
			{
				xR = row.processed.avowed.Min();
				///truncate x to be the minimal

			}
			if (x > row.processed.avowed.Max())
			{
				xR = row.processed.avowed.Max();
			}

			double yR = y;

			if (y > col.processed.avowed.Max())
			{
				yR = col.processed.avowed.Max();

			}
			var minY = col.processed.avowed.Min();
			if (y < minY)
			{
				yR = minY;
			}

			return _interPolate_pointIn(xR, yR);


		}

		public double polate(Point4dbl p) {
			double x = p.x;
			if (p.x<row.processed.avowed.Min() )
			{
				x = row.processed.avowed.Min();
				///truncate x to be the minimal

			}
			if (p.x >row.processed.avowed.Max())
			{
				x = row.processed.avowed.Max();
			}

			double y = p.y;

			if (p.y > col.processed.avowed.Max() )
			{
				y = col.processed.avowed.Max();

			}
			var minY = col.processed.avowed.Min();
			if (p.y<col.processed.avowed.Min())
			{
				y = minY;
			}

			return _interPolate_pointIn(x,y);

		}

		private double _interPolate_pointIn(double _x_in, double _y_in)
		{

			///get all x.
			///

			var xPosition = nilnul.num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed._Search_retIndex(_row.processed.avowed, _x_in);

			var yPosition=nilnul.num.ieee.str_.enumerable_.startedDif.op_.sort_.ByDefault.Ed._Search_retIndex(_col.processed.avowed, _y_in);
			#region xTrivia

			if (xPosition.Item1==xPosition.Item2)
			{


				return nilnul.geometry.planar.point.co.be_.injective.vow.EeDbl._InterPolate__duoInjective_xWithin(
					new Point4dbl(
						_col.processed.avowed.ElementAt(
							yPosition.Item1
						),
						data[
							xPosition.Item1,
							yPosition.Item1
						]
					)
					,
					new Point4dbl(
						_col.processed.avowed.ElementAt(
							yPosition.Item2
						)

						,
						data[
							xPosition.Item2,
							yPosition.Item2
						]
					)
					,
					_y_in

				);

			}
			#endregion

			#region yTrivia

			if (yPosition.Item1==yPosition.Item2)
			{
				return  nilnul.geometry.planar.point.co.be_.injective.vow.EeDbl._InterPolate__duoInjective_xWithin(
					new Point4dbl(
						_row.processed.avowed.ElementAt(
							xPosition.Item1
						),
						data[
							xPosition.Item1, 
							yPosition.Item1
						]
					)
					,
					new Point4dbl(
						_row.processed.avowed.ElementAt(
							xPosition.Item2
						)
						
						,
						data[
							xPosition.Item2,
							yPosition.Item2
						]
					)
					,
					_x_in
						
				);
			}
			#endregion

			#region x span, y span


			return new bloc_.nontrivia.potence_.interpolate_.bilinear_.OfCorners(
				_row.processed.avowed.ElementAt(xPosition.Item1)
				,_row.processed.avowed.ElementAt(xPosition.Item2)
				,
				_col.processed.avowed.ElementAt(yPosition.Item1)
				,
				_col.processed.avowed.ElementAt(
					yPosition.Item2
					)
				,
				new double[,] {
					{
					data[xPosition.Item1, yPosition.Item1]
					,
					data[xPosition.Item1, yPosition.Item2]
					}
					, {
					data[xPosition.Item2, yPosition.Item1]
					,
					data[xPosition.Item2, yPosition.Item2]

					}

				}
				
			)._interPolate_pointIn( _x_in,_y_in  );
			#endregion


			//throw new NotImplementedException();
		}
	}
}
