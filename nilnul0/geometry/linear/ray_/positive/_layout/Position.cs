using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.ray_.positive.vsPoint._layout
{
	public enum Position
	{
		Backward
			,
		Origin      //stay where you are. we put this, other than "Backward", first in order to be in line with 0-d, 
			,
		Forward	 //ship forward
	}
}
