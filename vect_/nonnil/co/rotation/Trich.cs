using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.vect_.nonnil.co.rotation
{
	namespace _layout
	{
		public enum Directional {
			Opposite
				,
			/// <summary>
			/// not aligin; not in a line; crossed; angle is not 0 or pi
			/// </summary>
			Cross
				,
			Codirectional
		}
	}
	static public  class _LayoutX
	{
		static public _layout.Directional Align(planar.vect_.Nonnil x, planar.vect_.Nonnil y) {
			var angle = planar.vect_.nonnil.co._RotationX.Rotation(x, y);

			if (angle==0 )
			{
				return _layout.Directional.Codirectional;
				
			}
			if (angle.quantity== nilnul.num.real_.TauX.Half)
			{
				return _layout.Directional.Opposite;
				
			}
			return _layout.Directional.Cross;
		}
	}
}
