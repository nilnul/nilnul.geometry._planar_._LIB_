using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad
{
	public class _DrawX
	{
		public static void Draw(Graphics g, Grad4dbl_byPointsI grad, Pen pen)
		{
			g.DrawLine(
				pen
				,
				grad.basis.ToPointF()
				,
				grad.finish.ToPointF()
			);
			//throw new NotImplementedException();
		}

		public static void Draw(Graphics g, Vect4dbl v1, Pen pen)
		{
			Draw(g, new Grad4dbl_byPoints(v1), pen);

		}
	}
}
