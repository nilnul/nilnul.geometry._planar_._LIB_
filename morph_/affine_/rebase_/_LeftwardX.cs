using System.Runtime.CompilerServices;

namespace nilnul.geometry.planar.morph_.affine_.rebase_
{
	static public class _ScaleX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public System.Drawing.Drawing2D.Matrix AsMatrix8float(double scale, double scaleY)
		{
			return AsMatrix8float((float)scale, (float)scaleY);

		}

		static public System.Drawing.Drawing2D.Matrix AsMatrix8float(float scale, float scaleY)
		{
			System.Drawing.Drawing2D.Matrix matrix = new();
			 matrix.Scale(scale,scaleY);
			return matrix;

		}


	}

}
