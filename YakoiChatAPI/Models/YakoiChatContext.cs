﻿using Microsoft.EntityFrameworkCore;
using YakoiChatAPI.Models.Data;

namespace YakoiChatAPI.Models
{
    public class YakoiChatContext : DbContext
    {
        public YakoiChatContext(DbContextOptions<YakoiChatContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserGroup>().HasKey(k => new { k.IdGroup, k.IdUser });
            builder.Entity<AppRolePermission>().HasKey(k => new { k.IdAppRole, k.IdAppPermission });

            base.OnModelCreating(builder);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }
        public DbSet<AppRole> AppRole { get; set; }
        public DbSet<AppPermission> AppPermission { get; set; }
        public DbSet<AppRolePermission> AppRolePermission { get; set; }
    }
}
