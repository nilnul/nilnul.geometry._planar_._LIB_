using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using nilnul.geometry.linear_._measured.unit_.eng_;
using nilnul.geometry.planar;
using nilnul.geometry.planar._area;

namespace nilnul.img.photo
{
	public partial class OneInchX
	{
		static public readonly SizeDbl SizeInInches = new SizeDbl(1f,1.5f );

		static public SizeDbl SizeInCmS;

		static OneInchX() {

			SizeInCmS = new SizeDbl( 
				nilnul.geometry.linear_._measured.unit_.eng_.Inch.ToCm(SizeInInches.width.realee.ee)
				, 
				Inch.ToCm(SizeInInches.height.realee.ee)
			);

		}

	}
}
