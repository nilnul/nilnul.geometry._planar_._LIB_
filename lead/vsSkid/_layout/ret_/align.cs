using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.lead.vsArrow._layout.ret_
{


	public interface AlignI : ResultI
	{
		bool sameDirection { get; }
	}


	public class AlignA : AlignI
	{
		private bool _sameDirection;
		public AlignA(bool sameDirection)
		{
			_sameDirection = sameDirection;


		}
		public bool sameDirection
		{
			get
			{
				return _sameDirection;

				//throw new NotImplementedException();
			}
		}
	}


	/// <summary>
	/// parrelell or incident
	/// </summary>
	namespace  align_
	{
		/// <summary>
		/// incident or float
		/// </summary>
		public interface RestrictOrIncidentI : AlignI
		{

		}
		/// <summary>
		/// one is above the other. 
		/// </summary>
		public class Restrict : AlignA, AlignI, RestrictOrIncidentI
		{
			public Restrict(bool align) : base(align)
			{

			}
		}

		public class Incident : AlignA, AlignI, RestrictOrIncidentI
		{
			public Incident(bool align)
				: base(align)
			{

			}

		}
		public class Leeway : AlignA, ResultI
		{
			public Leeway(bool align)
				: base(align)
			{

			}
		}


	}


}





