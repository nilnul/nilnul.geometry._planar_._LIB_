using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real;

namespace nilnul.geometry.planar.line.re_
{
	/// <summary>
	/// 
	/// </summary>
	public class Inter : ReI
	{
		public bool re(LineI a, LineI b)
		{

			var vector1 = a.points.en.end - a.points.en.begin;

			var vector2 = b.points.en.end - b.points.en.begin;

			return nilnul.num.real.be_.Nil.Singleton.be(  
				new nilnul.num.real.matrix_.square_.Two_Two(
					vector1.x, vector1.y
					,
					vector2.x,vector2.y
				).getDeterminant()
			);


			
		}

		static public Inter Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inter>.Instance;
			}
		}

	}
}
