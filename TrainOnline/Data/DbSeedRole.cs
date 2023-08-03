﻿using Microsoft.AspNetCore.Identity;

namespace TrainOnline.Data
{
    public class DbSeedRole
    {
        private readonly RoleManager<IdentityRole> _roManager;
        public DbSeedRole(RoleManager<IdentityRole> roManager)
        {
            _roManager = roManager;
        }
        public async Task RoleData()
        {
            var roleContext = await _roManager.CreateAsync(new IdentityRole { Name = "ADMIN", NormalizedName = "ADMIN" });
            await _roManager.CreateAsync(new IdentityRole { Name = "KETOAN", NormalizedName = "KETOAN" });
        }
    }
}
