namespace nilnul.geometry.planar.morph_.affine_
{
	interface INonTranslate { }

	static public class _NonTranslateX 
	{
		static public System.Drawing.Drawing2D.Matrix Matrix8float(
			float a00,float a1, float b0,float b1
		) => new System.Drawing.Drawing2D.Matrix(
			a00,a1,b0,b1, 0, 0
		);

	}


}
