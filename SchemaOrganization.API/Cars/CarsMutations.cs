using System;
using HotChocolate.Types;
using SchemaOrganization.API.QLTypes;

namespace SchemaOrganization.API.Cars
{
	public class CarsMutations
	{
		public Guid AddCar() => Guid.NewGuid();
	}
}