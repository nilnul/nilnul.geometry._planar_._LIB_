using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear.vect_.positive.vsPoint._layout
{

	/// <summary>
	/// imagining we query the progress of a task .
	/// This is an extension to Sign
	/// </summary>
	public enum Category
	{
		Behind=-2,     // catering to the situation that the vector points backwards

		#region extension of ==0
		Start=-1
			,
		Between=0
			,
		Stop=1

		#endregion
			,
		Forward

	}




}
