using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.trace_.squential_
{
	[Obsolete(nameof(linear.ILocus))]
	public interface ILocus :
		IDirected
		,
		trace_.ISpanned
		//,
		//sub_.sequential_.INonempty
	{
	}
}
