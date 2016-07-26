using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CainPortal.Models
{
    public partial class CainafricaContext : DbContext
    {
        public CainafricaContext(DbContextOptions<CainafricaContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonationActivity>(entity =>
            {
                entity.ToTable("donationActivity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.AppreciationNotificationDate)
                    .HasColumnName("appreciation_notification_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(20);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DonationPlatformId).HasColumnName("donation_platform_id");

                entity.Property(e => e.PeopleId).HasColumnName("people_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ReceiptSendDate)
                    .HasColumnName("receipt_send_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.DonationPlatform)
                    .WithMany(p => p.DonationActivity)
                    .HasForeignKey(d => d.DonationPlatformId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__donationA__donat__2F10007B");
            });

            modelBuilder.Entity<DonationPlatform>(entity =>
            {
                entity.ToTable("donationPlatform");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DonationPlatformName)
                    .IsRequired()
                    .HasColumnName("donation_platform_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("paymentType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PaymentTypeName)
                    .IsRequired()
                    .HasColumnName("payment_type_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.ToTable("people");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("text");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(255);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.DateOfFirstContact)
                    .HasColumnName("date_of_first_contact")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("email_address")
                    .HasMaxLength(255);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50);

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(20);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(10);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__people__role_id__31EC6D26");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("project");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("text");

                entity.Property(e => e.AmountRaised)
                    .HasColumnName("amount_raised")
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.NumberOfParticipants).HasColumnName("number_of_participants");

                entity.Property(e => e.Organizer)
                    .IsRequired()
                    .HasColumnName("organizer")
                    .HasMaxLength(100);

                entity.Property(e => e.ProjectTypeId).HasColumnName("project_type_id");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasMaxLength(10);

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__project__project__32E0915F");
            });

            modelBuilder.Entity<ProjectType>(entity =>
            {
                entity.ToTable("projectType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProjectType1)
                    .IsRequired()
                    .HasColumnName("project_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.ToTable("subscription");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("email_address")
                    .HasMaxLength(255);

                entity.Property(e => e.IsSubscribed)
                    .HasColumnName("is_subscribed")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SubscriptionInfo)
                    .IsRequired()
                    .HasColumnName("subscription_info")
                    .HasMaxLength(255);
            });
        }

        public virtual DbSet<DonationActivity> DonationActivity { get; set; }
        public virtual DbSet<DonationPlatform> DonationPlatform { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectType> ProjectType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }

        // Unable to generate entity type for table 'dbo.expenseActivity'. Please see the warning messages.
    }
}