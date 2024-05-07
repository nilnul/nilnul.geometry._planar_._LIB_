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
	public partial class PhotoX
	{
		static public readonly SizeDbl OneInchIdPhotoDimensionsInInches = new SizeDbl(1f,1.5f );
		static public readonly SizeDbl TwoInchIdPhotoDimensionsInInches = new SizeDbl(1.5f,2f );

		static public SizeDbl OneInchPhotoSizeInCmS;
		static public SizeDbl TwoInchPhotoSizeInCmS;

		static PhotoX() {

			OneInchPhotoSizeInCmS = new SizeDbl( 
				Inch.ToCm(OneInchIdPhotoDimensionsInInches.width.realee.ee), 
				Inch.ToCm(OneInchIdPhotoDimensionsInInches.height.realee.ee)
			);

		}

	}
}
