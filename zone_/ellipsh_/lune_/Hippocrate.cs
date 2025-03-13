using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.lune_
{
	static public class Hippocrate
	{
		static public void Draw(Graphics g, Pen pen) {


			g.DrawArc(
				pen,
				new RectangleF(
					-1
					,-1
					,
					2
					,2
				)
				,
				0
				,
				(float) Math.PI/2
			);


			g.TranslateTransform(
				0.5f
				,0.5f
			);

			g.RotateTransform(
				(float) Math.PI/4
				, System.Drawing.Drawing2D.MatrixOrder.Append
			);


			var rectF = trac_.ellipse_.QuadratureX.Bounding8float(
				0.5,
				0.5,
				num.real_.eg_.sqrt_._OfTwoX.DBL/2
				,
				num.real_.eg_.sqrt_._OfTwoX.DBL/2

			).toRect8float();


			g.DrawArc(
				pen
				,
				rectF
				,
				0
				,
				(float) Math.PI
			);


		}
	}


}
