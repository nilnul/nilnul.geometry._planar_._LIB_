using nilnul.geometry.linear.grad.point.categorize_;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.nonnil.vsPoint.layout_
{
	static public class _Convert2PosiveX
	{
		static public positive.vsPoint._layout.Category Layout(linear.vect_.Nonnil _basis, linear.Point p)
		{

			if (_basis.end.x.ToReal() < 0)
			{
				return vect_.positive.vsPoint._LayoutX.Layout(
					-_basis
					,
					new linear.Point(-(p.x.ToReal()))
				);
			}
			/// nil vector
			///
			var sign= nilnul.num.real._SignX.BitNul(p.coord);

			return ( positive.vsPoint._layout.Category) nilnul.bit._NulableX.ToInt(sign);

			//if (sign==true)
			//{
			//	return positive.vsPoint._layout.Category.Forward;
			//}
			//if (sign is null)
			//{
			//	return positive.vsPoint._layout.Category.Between;
			//}


			



		}


	}
}
