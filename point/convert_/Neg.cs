using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.convert_
{

	public class Neg:planar.point.IConvert
	{
		

		public PointI1 convert(PointI1 par)
		{
			return new Point1(
				nilnul.num.real.op_.unary_.Neg.Singleton.op(
				 par.x
				)
				, 
				nilnul.num.real.op_.unary_.Neg.Singleton.op(
				 par.y
				) 

			);

		}

		public Point1 convert(Point1 par)
		{
			return new Point1(
				nilnul.num.real.op_.unary_.Neg.Singleton.op(
				 par.x
				)
				, 
				nilnul.num.real.op_.unary_.Neg.Singleton.op(
				 par.y
				) 

			);

		}

		static public Neg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Neg>.Instance;
			}
		}

	}
}
