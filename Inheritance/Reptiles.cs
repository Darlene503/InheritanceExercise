using System;
namespace Inheritance
{
	public class Reptiles : Animal
	{
		public Reptiles()
		{
		}

		public bool HasScales { get; set; }
		public bool  IsColdBlooded { get; set; }
		public double LifeSpan { get; set; }
		public string Habitat { get; set; }

	}
}

