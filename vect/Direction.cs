using nilnul.geometry.planar.rotation_;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect
{


	/// <summary>
	/// [0,Tau)
	/// </summary>
	static public class _DirectionX
	{

		static public double Dbl(double x, double y)
		{
			if (x == 0 && y == 0)
			{
				return 0;

			}

			return vect_.nonnil._DirectionX.Direction_ge0LtTau(x, y);



		}


		static public double _Ge0LtTau(Point4dbl p)
		{

			return Dbl(p.x,p.y);

		}

		static public double _Ge0LtTau(Point4dblI p)
		{

			return Dbl(p.x,p.y);

		}


		static public double _Ge0LtTau(Vector4dblI p)
		{
			return _Ge0LtTau(p.point);
		}
		static public double _Ge0LtTau(VectorDbl p)
		{
			return _Ge0LtTau((Vector4dblI)p);
		}
	}
}
