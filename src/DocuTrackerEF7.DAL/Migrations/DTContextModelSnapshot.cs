using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using DocuTrackerEF7.DAL;

namespace DocuTrackerEF7.DAL.Migrations
{
    [DbContext(typeof(DTContext))]
    partial class DTContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DTModels.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AnswerTypeID");

                    b.Property<string>("Text");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("DTModels.AnswerType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("DTModels.InternalAnswer", b =>
                {
                    b.Property<int>("InternalAnswerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("InternalAnswerID");
                });

            modelBuilder.Entity("DTModels.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("DTModels.QuestionAnswer", b =>
                {
                    b.Property<int>("QuestionID");

                    b.Property<int>("AnswerID");

                    b.HasKey("QuestionID", "AnswerID");
                });

            modelBuilder.Entity("DTModels.Answer", b =>
                {
                    b.HasOne("DTModels.AnswerType")
                        .WithMany()
                        .HasForeignKey("AnswerTypeID");
                });

            modelBuilder.Entity("DTModels.QuestionAnswer", b =>
                {
                    b.HasOne("DTModels.Answer")
                        .WithMany()
                        .HasForeignKey("AnswerID");

                    b.HasOne("DTModels.Question")
                        .WithMany()
                        .HasForeignKey("QuestionID");
                });
        }
    }
}
