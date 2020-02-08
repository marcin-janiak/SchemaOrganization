using HotChocolate.Types;
using SchemaOrganization.API.Cars;
using SchemaOrganization.API.People;
using SchemaOrganization.API.Projects;

namespace SchemaOrganization.API.QLTypes
{
	public class Mutation
	{
		public PeopleMutations PeopleMutations => new PeopleMutations();
	}

	public class MutationType : ObjectType<Mutation>
	{
		protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
		{
			base.Configure(descriptor);

			descriptor.Include<ProjectMutations>();
			descriptor.Field("cars").Resolver(x => x.Resolver<CarsMutations>());
		}
	}
}