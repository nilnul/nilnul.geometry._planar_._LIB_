using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.positive.vsPoint
{
	static public class _LayoutX
	{
		static public _layout.Category Layout(nilnul.num.real_.PositiveI _positive, nilnul.num.RealI point)
		{

			var vsZero = nilnul.num.real.Sign.Singleton.sign(point);


			var vsRight = nilnul.num.real.Comparer.Singleton.Compare(point, _positive);

			if (vsZero == false)
			{
				return _layout.Category.Behind;
			}
			if (vsZero == null)
			{
				return _layout.Category.Start;
			}

			if (vsRight < 0)
			{
				return _layout.Category.Between;
			}
			if (vsRight == 0)
			{
				return _layout.Category.Stop;

			}
			return _layout.Category.Forward;
		}
		static public _layout.Category Layout(nilnul.num.RealI _positive, nilnul.num.RealI point)
		{
			return Layout(
				new num.real_.Positive(_positive), point
			);
		}
		static public _layout.Category Layout(Vector _positive, PointI point)
		{


			return Layout(_positive.end.x, point.x);

		}

		static public _layout.Category Layout(nilnul.geometry.linear.vect_.PositiveDbl _positive, double point)
		{

			var vsZero = nilnul.num.real._SignDblX.BitNul(point);


			var vsRight = nilnul.num.real.ComparerDbl.Singleton.Compare(point, _positive.end.coord);

			if (vsZero == false)
			{
				return _layout.Category.Behind;
			}
			if (vsZero == null)
			{
				return _layout.Category.Start;
			}

			if (vsRight < 0)
			{
				return _layout.Category.Between;
			}
			if (vsRight == 0)
			{
				return _layout.Category.Stop;

			}
			return _layout.Category.Forward;
		}
		static public _layout.Category Layout(nilnul.geometry.linear.vect_.PositiveDbl _positive, PointDblI point)
		{
			return Layout((_positive), point.coord);

		}

		static public _layout.Category Layout(VectorDbl _positive, PointDblI point)
		{


			return Layout(new vect_.PositiveDbl(_positive), point);

		}
		static public _layout.Category Layout(double _positive, double point)
		{
			return Layout(
				new vect_.PositiveDbl(_positive), point
			);
		}



	}
}
