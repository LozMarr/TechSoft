using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TechSoft.Models;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssignmentProject> AssignmentProjects { get; set; }

    public virtual DbSet<Priority> Priorities { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StatusProject> StatusProjects { get; set; }

    public virtual DbSet<StatusTask> StatusTasks { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<ViewDb> ViewDbs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tech_soft_db;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssignmentProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("assignment_project_pkey");

            entity.ToTable("assignment_project");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdProjectNavigation).WithMany(p => p.AssignmentProjects)
                .HasForeignKey(d => d.IdProject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assignment_to_projects");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.AssignmentProjects)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assignment_to_users");
        });

        modelBuilder.Entity<Priority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("priorities_pkey");

            entity.ToTable("priorities");

            entity.HasIndex(e => e.PriorityName, "uq_priority_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PriorityName).HasColumnName("priority_name");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("projects_pkey");

            entity.ToTable("projects");

            entity.HasIndex(e => e.ProjectName, "uq_project_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateComplete).HasColumnName("date_complete");
            entity.Property(e => e.DateStart).HasColumnName("date_start");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdManager).HasColumnName("id_manager");
            entity.Property(e => e.IdStatusProject).HasColumnName("id_status_project");
            entity.Property(e => e.PhotoUrl).HasColumnName("photo_url");
            entity.Property(e => e.ProjectName).HasColumnName("project_name");

            entity.HasOne(d => d.IdManagerNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.IdManager)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_projects_to_managers");

            entity.HasOne(d => d.IdStatusProjectNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.IdStatusProject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_projects_to_status_projects");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.HasIndex(e => e.RoleName, "uq_role_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<StatusProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("status_projects_pkey");

            entity.ToTable("status_projects");

            entity.HasIndex(e => e.StatusProjectName, "uq_status_project_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusProjectName).HasColumnName("status_project_name");
        });

        modelBuilder.Entity<StatusTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("status_tasks_pkey");

            entity.ToTable("status_tasks");

            entity.HasIndex(e => e.StatusTaskName, "uq_status_task_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusTaskName).HasColumnName("status_task_name");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tasks_pkey");

            entity.ToTable("tasks");

            entity.HasIndex(e => e.TaskName, "uq_name_task").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreate).HasColumnName("date_create");
            entity.Property(e => e.Deadline).HasColumnName("deadline");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdPriority).HasColumnName("id_priority");
            entity.Property(e => e.IdProject).HasColumnName("id_project");
            entity.Property(e => e.IdStatussTask).HasColumnName("id_statuss_task");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.TaskName).HasColumnName("task_name");

            entity.HasOne(d => d.IdPriorityNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdPriority)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tasks_to_priorities");

            entity.HasOne(d => d.IdProjectNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdProject)
                .HasConstraintName("fk_tasks_to_projects");

            entity.HasOne(d => d.IdStatussTaskNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdStatussTask)
                .HasConstraintName("fk_tasks_to_status_tasks");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tasks_to_users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Login, "uq_login").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Password).HasColumnName("password");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_to_roles");
        });

        modelBuilder.Entity<ViewDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_db");

            entity.Property(e => e.DateCreate).HasColumnName("date_create");
            entity.Property(e => e.Deadline).HasColumnName("deadline");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.PhotoUrl).HasColumnName("photo_url");
            entity.Property(e => e.PriorityName).HasColumnName("priority_name");
            entity.Property(e => e.ProjectName).HasColumnName("project_name");
            entity.Property(e => e.StatusTaskName).HasColumnName("status_task_name");
            entity.Property(e => e.TaskName).HasColumnName("task_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
