using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line.co.sig_
{
	static public class _Orient
	{
		static public bool? Sign(Co a) {
			return Sign(
				a.component,a.component1
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>true if cross, false if parallel, null if incident</returns>
		static public bool? Sign(planar.LineI a, planar.LineI b)
		{
			if (re_.Inter.Singleton.re(a,b))
			{
				return true;
			}
			return (line.co_.align.be_._ParallelX._Be_ofAligned(a, b));
		}
	}

	public class Orient : SigI
	{
		public bool? sign(line.Co obj)
		{
			return _Orient.Sign(obj);

			//throw new NotImplementedException();
		}


		static public Orient Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Orient>.Instance;
			}
		}



	}
}
