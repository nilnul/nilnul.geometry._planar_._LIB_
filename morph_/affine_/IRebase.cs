using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.affine_
{
	/// <summary>
	/// no translation (translation is nil )
	/// 
	/// </summary>
	/// alias:
	///		nontranslate
	///		rebase
	public interface IRebase
		:
		morph_.IAffine
		,
		morph_.IRebase
	{
		
	}

	static public class _RebaseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="rebase"></param>
		/// <returns></returns>
		/// alias:
		///		expand
		///		enlarge
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Matrix _Augment2float_0rebase(float[,] rebase) {
			return new Matrix(
				rebase[0,0],rebase[0,1]
				,
				rebase[1,0],rebase[1, 1]	
				,
				0,0

			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Matrix _Augment2float_0rebase(double[,] rebase) {
			return new Matrix(
				(float) rebase[0,0],(float)rebase[0,1]
				,
				(float)rebase[1,0],(float)rebase[1, 1]	
				,
				0,0

			);
		}


	}






	
}
