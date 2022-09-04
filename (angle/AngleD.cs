namespace nilnul.geometry.planar
{
	/// <summary>
	/// </summary>
	public class AngleD : IAngleD
	{
		private IRayDbl _inital;

		public IRayDbl initial {
			get =>_inital;
			set { _inital = value; }
		}

		private double _azimuth;
		public double azimuth
		{
			get => _azimuth;
			set => _azimuth = value; 
		}



	}


}
