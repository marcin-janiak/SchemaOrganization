using System;

namespace SchemaOrganization.API.Projects
{
	public class ProjectMutations
	{
		public Guid AddProject() => Guid.NewGuid();
	}
}