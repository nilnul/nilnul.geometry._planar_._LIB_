using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line.co.be_.align_
{
	public class Incident :
		planar.line.co.BeOnReA,

		ReI
	{
		public override bool re(planar.LineI a, planar.LineI b)
		{

			

			return line.re_.cross.Anto.Singleton.re(a,b)
				&&

				co_.align.be_._IncidentX._Be_ofAligned(
				 a
				 ,
				 
				 b
			);
				

			//throw new NotImplementedException();
		}

		

		static public Incident Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Incident>.Instance;
			}
		}

	}
}
