using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_.affine_
{
	public class Parrallogram
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="g"></param>
		/// <param name="img"></param>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c">
		///	if three points are the same, this is a trivia affine transformation (scale to 0; then translate.). note this is not the same as linear trivia, which can only map to the origin, not able to map to nonorigin point.
		/// </param>
		/// 
		static public void Draw(Graphics g, Image img, PointF a, PointF b, PointF c) {
			g.DrawImage( img, new[] { a,b,c});
		}
	}
}
