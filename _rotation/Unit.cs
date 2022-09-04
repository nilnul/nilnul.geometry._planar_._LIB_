using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._rotation
{
	public interface UnitI1
	{
		nilnul.num.real_.Positive asRadian { get; }
	}



	public class Unit1 : UnitI1
	{
		public nilnul.num.real_.Positive asRadian => new nilnul.num.real_.Positive( 1 );

		static public Unit1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Unit1>.Instance;
			}
		}

	}
}
