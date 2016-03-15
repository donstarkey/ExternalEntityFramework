using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using DocuTrackerEF7.DAL.Migrations;

namespace DocuTrackerEF7.DAL.Migrations
{
    [DbContext(typeof(DTContext))]
    [Migration("20160210194114_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocuTrackerEF7.DAL.InternalAnswer", b =>
                {
                    b.Property<int>("InternalAnswerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("InternalAnswerID");
                });
        }
    }
}
