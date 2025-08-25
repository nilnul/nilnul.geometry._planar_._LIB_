using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar._point.pointD.duo.be
{
	public class Irreflexive
	{
		static public bool Eval(Duo duo) {

			return duo.begin == duo.end;

		}

		public class Be
			:nilnul.bit.Be<Duo>
		{
			public Be()
				:base(Eval)
			{


			}

			public class Asserted :nilnul.bit.be.Asserted<Duo,Be>
			{
				public Asserted(Duo duo)
					:base(duo)
				{

				}
			}

		}
	}
}
