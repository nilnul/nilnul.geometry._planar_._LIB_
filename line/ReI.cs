using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line
{
	//public enum _Re {
	//	Incident
	//		,
	//	Parallel
	//		,
	//	Intersect
	//}

	public interface ReI
		:
		nilnul.obj.ReI<
			nilnul.geometry.planar.LineI
		>
	{
	}
}
