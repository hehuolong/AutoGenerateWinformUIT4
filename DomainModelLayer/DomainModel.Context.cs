﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MWTSEntities : DbContext
    {
        public MWTSEntities()
            : base("name=MWTSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ActiveSubscriptions> ActiveSubscriptions { get; set; }
        public DbSet<CachePolicy> CachePolicy { get; set; }
        public DbSet<Catalog> Catalog { get; set; }
        public DbSet<ChunkData> ChunkData { get; set; }
        public DbSet<ChunkSegmentMapping> ChunkSegmentMapping { get; set; }
        public DbSet<ConfigurationInfo> ConfigurationInfo { get; set; }
        public DbSet<DataSets> DataSets { get; set; }
        public DbSet<DataSource> DataSource { get; set; }
        public DbSet<DBUpgradeHistory> DBUpgradeHistory { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<ExecutionLogStorage> ExecutionLogStorage { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Keys> Keys { get; set; }
        public DbSet<ModelDrill> ModelDrill { get; set; }
        public DbSet<ModelItemPolicy> ModelItemPolicy { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Policies> Policies { get; set; }
        public DbSet<PolicyUserRole> PolicyUserRole { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RunningJobs> RunningJobs { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<SecData> SecData { get; set; }
        public DbSet<Segment> Segment { get; set; }
        public DbSet<SegmentedChunk> SegmentedChunk { get; set; }
        public DbSet<ServerParametersInstance> ServerParametersInstance { get; set; }
        public DbSet<ServerUpgradeHistory> ServerUpgradeHistory { get; set; }
        public DbSet<SnapshotData> SnapshotData { get; set; }
        public DbSet<Subscriptions> Subscriptions { get; set; }
        public DbSet<SubscriptionsBeingDeleted> SubscriptionsBeingDeleted { get; set; }
        public DbSet<UpgradeInfo> UpgradeInfo { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Batch> Batch { get; set; }
        public DbSet<ModelPerspective> ModelPerspective { get; set; }
        public DbSet<ReportSchedule> ReportSchedule { get; set; }
    }
}