namespace nilnul.geometry.planar.morph_.affine_
{
	/// <summary>
	/// marix is put on the right.
	/// </summary>
	/// <remarks>
	/// for the multiplication part:
	///		the left vector is a row,  and the right matrix is two rows.
	/// for the addition part:
	///		the added is also a row
	/// </remarks>
	/// alias:
	///		rowwise
	///		asRows
	internal class IRowwise
	{
	}

	static public class _RowwiseX
	{
		/// <summary>
		/// for <see cref="System.Drawing.Graphics"/>, the <see cref="System.Drawing.Graphics.Transform"/> is rowwise <see cref="System.Drawing.Drawing2D.Matrix"/>, and you can tell from:
		///		new Matrix(0, 1, -1, 0, 3, 4) constructs the matrix shown in the preceding figure.
		///		, which is (0, 1, -1, 0) for <see cref="rebase_.IRowwise"/> and (3,4) for translate
		/// </summary>
		/// <param name="linear8rows"></param>
		/// <param name="translate"></param>
		/// <returns></returns>
		static public double[,] _Rowwise_0neobase_1translate(
			double[,] linear8rows
			,
			double[] translate
		) {
			return new[,] {
				{ linear8rows[0,0],linear8rows[0,1]	, 0			}
				,
				{ linear8rows[1,0],linear8rows[1,1]		,0		}
				,
				{ translate[0],translate[1]		,1		}  // note here the rowmajor is honored.

			};
		}





	}

}
