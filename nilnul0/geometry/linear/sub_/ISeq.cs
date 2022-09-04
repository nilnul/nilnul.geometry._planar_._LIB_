using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.sub_
{
	/// <summary>
	/// the point in which is linear ordered. I.e, given any two points, there is a prior/posterior relationship; and this relationship is reflexive/antisymmetric/transitive, and total (as we said, any two points are comparable.)
	/// </summary>
	public interface ISequential : ISub
	{
	}
}
