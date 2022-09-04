using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.line
{
 	public interface DirectionI
	{
		LineI line { get; }
		bool up { get; }	///goes up, the rotation is in [0, half Round) ;  or goes down, the rotation is in [Half Round, Full turn)
	}
}
