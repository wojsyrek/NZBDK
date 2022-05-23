using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NZBDK.Models;

namespace NZBDK.Data
{
    public partial class NzbdkDBContext : DbContext
    {
        public NzbdkDBContext(DbContextOptions<NzbdkDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Field> Fields { get; set; } = null!;
        public virtual DbSet<Segment> Segments { get; set; } = null!;
        public virtual DbSet<Sygnature> Sygnatures { get; set; } = null!;
        public virtual DbSet<Variant> Variants { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Clause> Clauses { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;

    }
}
