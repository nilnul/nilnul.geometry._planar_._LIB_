using nilnul.geometry.linear.grad.point.categorize_;
using nilnul.geometry.linear.vect.co.categorize_._inside;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.co.sig_
{
	static public class _InsideX
	{
		public static bool? Inside(VectI basis, VectI obj)
		{
			var pSinceLeft_position = nilnul.geometry.linear.vect.co.sig_.Perpend.Singleton.sign( 
				basis,obj
				
				
				
			);

			var pSinceRight_position = nilnul.geometry.linear.vect.co.sig_.Perpend.Singleton.sign(
				basis,obj
				
			);

			if (pSinceLeft_position == false)
			{
				return false;
			}
			if (pSinceRight_position ==true )
			{
				return false;
			}
			return true;

		}


		static public bool? Inside(Vector basis, Vector obj)
		{

			var pSinceLeft_position = nilnul.geometry.linear.vect.co.sig_.Perpend.Singleton.sign( 
				basis,obj
				
				
				
			);

			var pSinceRight_position = nilnul.geometry.linear.vect.co.sig_.Perpend.Singleton.sign(
				basis,obj
				
			);

			if (pSinceLeft_position == false)
			{
				return false;
			}
			if (pSinceRight_position ==true )
			{
				return false;
			}
			return true;
		}

		public static bool? Inside(Co obj)
		{
			return Inside(obj.Item1,obj.Item2);

		}

		public static bool? Inside(Duo obj)
		{
			return Inside(obj.Item1,obj.Item2);

		}
	}

	
}
