using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DB_Design.Models
{
    public partial class staff_attendanceContext : DbContext
    {
        public staff_attendanceContext()
        {
        }

        public staff_attendanceContext(DbContextOptions<staff_attendanceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<AttendanceStatistic> AttendanceStatistic { get; set; }
        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<BusinessStatistic> BusinessStatistic { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Offwork> Offwork { get; set; }
        public virtual DbSet<OffworkStatistic> OffworkStatistic { get; set; }
        public virtual DbSet<Overtime> Overtime { get; set; }
        public virtual DbSet<OvertimeStatistic> OvertimeStatistic { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=55555ku;database=db", x => x.ServerVersion("8.0.17-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.AttNum)
                    .HasName("PRIMARY");

                entity.ToTable("attendance");

                entity.HasIndex(e => e.WId)
                    .HasName("FK_Reference_5");

                entity.Property(e => e.AttNum)
                    .HasColumnName("att_num")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttAbsence)
                    .HasColumnName("att_absence")
                    .HasColumnType("enum('迟到','早退','旷工','正常')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AttEndTime)
                    .HasColumnName("att_end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttStartTime)
                    .HasColumnName("att_start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.WId)
                    .HasColumnName("w_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.W)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.WId)
                    .HasConstraintName("FK_Reference_5");
            });

            modelBuilder.Entity<AttendanceStatistic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("attendance_statistic");

                entity.Property(e => e.AbsenteeismTimes)
                    .HasColumnName("absenteeism_times")
                    .HasColumnType("decimal(23,0)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LateTimes)
                    .HasColumnName("late_times")
                    .HasColumnType("decimal(23,0)");

                entity.Property(e => e.LeaveEarlyTimes)
                    .HasColumnName("leave_early_times")
                    .HasColumnType("decimal(23,0)");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NormalTimes)
                    .HasColumnName("normal_times")
                    .HasColumnType("decimal(23,0)");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<Business>(entity =>
            {
                entity.HasKey(e => e.BusNum)
                    .HasName("PRIMARY");

                entity.ToTable("business");

                entity.HasIndex(e => e.WId)
                    .HasName("FK_Reference_4");

                entity.Property(e => e.BusNum)
                    .HasColumnName("bus_num")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BusDuration).HasColumnName("bus_duration");

                entity.Property(e => e.BusEndTime)
                    .HasColumnName("bus_end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusStartTime)
                    .HasColumnName("bus_start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.WId)
                    .HasColumnName("w_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.W)
                    .WithMany(p => p.Business)
                    .HasForeignKey(d => d.WId)
                    .HasConstraintName("FK_Reference_4");
            });

            modelBuilder.Entity<BusinessStatistic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("business_statistic");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TotalBusDuration).HasColumnName("total_bus_duration");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DId)
                    .HasName("PRIMARY");

                entity.ToTable("department");

                entity.Property(e => e.DId)
                    .HasColumnName("d_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DName)
                    .HasColumnName("d_name")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Offwork>(entity =>
            {
                entity.HasKey(e => e.OffNum)
                    .HasName("PRIMARY");

                entity.ToTable("offwork");

                entity.HasIndex(e => e.WId)
                    .HasName("FK_Reference_3");

                entity.Property(e => e.OffNum)
                    .HasColumnName("off_num")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OffDuration).HasColumnName("off_duration");

                entity.Property(e => e.OffEndTime)
                    .HasColumnName("off_end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.OffStartTime)
                    .HasColumnName("off_start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.WId)
                    .HasColumnName("w_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.W)
                    .WithMany(p => p.Offwork)
                    .HasForeignKey(d => d.WId)
                    .HasConstraintName("FK_Reference_3");
            });

            modelBuilder.Entity<OffworkStatistic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("offwork_statistic");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TotalOffDuration).HasColumnName("total_off_duration");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<Overtime>(entity =>
            {
                entity.HasKey(e => e.OverNum)
                    .HasName("PRIMARY");

                entity.ToTable("overtime");

                entity.HasIndex(e => e.WId)
                    .HasName("FK_Reference_2");

                entity.Property(e => e.OverNum)
                    .HasColumnName("over_num")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OverDuration).HasColumnName("over_duration");

                entity.Property(e => e.OverEndTime)
                    .HasColumnName("over_end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.OverStartTime)
                    .HasColumnName("over_start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.WId)
                    .HasColumnName("w_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.W)
                    .WithMany(p => p.Overtime)
                    .HasForeignKey(d => d.WId)
                    .HasConstraintName("FK_Reference_2");
            });

            modelBuilder.Entity<OvertimeStatistic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("overtime_statistic");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TotalOverDuration).HasColumnName("total_over_duration");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(5)");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.WId)
                    .HasName("PRIMARY");

                entity.ToTable("worker");

                entity.HasIndex(e => e.WDepartment)
                    .HasName("FK_Reference_1");

                entity.Property(e => e.WId)
                    .HasColumnName("w_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WAge)
                    .HasColumnName("w_age")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WDepartment)
                    .HasColumnName("w_department")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WDuty)
                    .HasColumnName("w_duty")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WName)
                    .HasColumnName("w_name")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WOnJob)
                    .HasColumnName("w_on_job")
                    .HasColumnType("enum('在职','离职')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WPost)
                    .HasColumnName("w_post")
                    .HasColumnType("enum('管理岗','普通岗')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WSex)
                    .HasColumnName("w_sex")
                    .HasColumnType("enum('男','女')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WTelephone)
                    .HasColumnName("w_telephone")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WWage)
                    .HasColumnName("w_wage")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.WDepartmentNavigation)
                    .WithMany(p => p.Worker)
                    .HasForeignKey(d => d.WDepartment)
                    .HasConstraintName("FK_Reference_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
