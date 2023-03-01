using System;
using Microsoft.AspNetCore.Identity;

namespace ProjectRon.Data
{
	public class ApplicationUser : IdentityUser<Guid>
	{
	}

	public class ApplicationRole : IdentityRole<Guid>
	{
	}
}

