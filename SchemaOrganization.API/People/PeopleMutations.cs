using System;

namespace SchemaOrganization.API.People
{
	public class PeopleMutations
	{
		public Guid AddPerson() => Guid.NewGuid();
	}
}