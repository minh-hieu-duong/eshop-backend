﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Authentication
{
	public interface IPermissionService
	{
		Task<HashSet<string>> GetPermissionsAsync(int userId);
	}
}
