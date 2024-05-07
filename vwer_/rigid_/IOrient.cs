using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vwer_.rigid_
{
	/// <summary>
	/// when we take <see cref="morph_.rebase_.IOrient"/> including:
	///		<see cref="morph_.rebase_.orient_.IFlip"/>, such as (x, -y)
	///	the object would also flip. and the stokes surrounded, or the signed area, remains unchanged , that implies the sign will not change.
	///	for example: a positive winding cirle in old bisectant (x,y) would show still positive winding in new bisectant ( x, - old y); but with respect to old coords, the winding is opposite.
	/// </summary>
	/// <remarks>
	/// vwer is a reinterpretation of the axes.
	/// </remarks>
	/// <see cref="planar_"/> such as <see cref="planar_.IErgo"/> or <see cref="planar_.IGeo"/> or <see cref="planar_.ICosmo"/>
	internal class IOrient
	{
	}
}
