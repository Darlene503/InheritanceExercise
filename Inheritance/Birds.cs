using System;
namespace Inheritance
{
	public class Birds : Animal 
	{
		public Birds()
		{

			
			CanBreathe = true;
			Eyes = 2;
			Feet = 2;
			LandSeaAir = "Air";


		}



		

		public string FeatherColor { get; set; }
		public bool CanFly { get; set; }
		public bool CanSing { get; set; }
		public double WingSpanLength { get; set; }



	}
}

