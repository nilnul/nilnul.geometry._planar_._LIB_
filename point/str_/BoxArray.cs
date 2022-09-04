using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace nilnul.geometry.planar.points_
{
	public class NatTimesTwoMatrixDbl
		: IEnumerable<Point4dbl>

	{
		/// <summary>
		/// n*2 matrix 
		/// </summary>
		private nilnul.matrix.be_.Duos<double>.En _duos;

		public nilnul.matrix.be_.Duos<double>.En duos
		{
			get { return _duos; }
			set { _duos = value; }
		}

		public NatTimesTwoMatrixDbl(
			nilnul.matrix.be_.Duos<double>.En duos
		)
		{
			_duos = duos;

		}

		public NatTimesTwoMatrixDbl(params double[] duos)
			: this(
				matrix.be_.Duos<double>.En.Create(duos)
				)
		{

		}

		static public NatTimesTwoMatrixDbl Create_XsYs(params double[] xS_yS)
		{

			return new NatTimesTwoMatrixDbl(
				nilnul.matrix.be_.Duos<double>.En.Create_XsYs(xS_yS)
			);

		}



		public NatTimesTwoMatrixDbl()
			: this(

				new matrix.be_.Duos<double>.En()
				)
		{

		}

		public IEnumerator<Point4dbl> GetEnumerator()
		{
			for (int i = 0; i < _duos.avowed.GetLength(0); i++)
			{
				yield return new Point4dbl(_duos.avowed[i, 0], _duos.avowed[i, 1]);
			}
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
}
