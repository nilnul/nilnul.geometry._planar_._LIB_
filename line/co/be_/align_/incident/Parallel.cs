using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line.co.be_.align_.incident
{
	public class Parallel : 
		nilnul.obj.re.Complement<planar.LineI, Incident>
		,
		ReI
	{

		static public Parallel Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Parallel>.Instance;
			}
		}

	}
}
