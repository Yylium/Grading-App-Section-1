using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grading_App_Section_1.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins_Teachers",
                columns: table => new
                {
                    prof_netid = table.Column<string>(type: "TEXT", nullable: false),
                    first_name = table.Column<string>(type: "TEXT", nullable: false),
                    last_name = table.Column<string>(type: "TEXT", nullable: false),
                    class_number = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins_Teachers", x => x.prof_netid);
                });

            migrationBuilder.CreateTable(
                name: "Judge_Teams",
                columns: table => new
                {
                    judge_team_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    judge_team_modifier = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Judge_Teams", x => x.judge_team_id);
                });

            migrationBuilder.CreateTable(
                name: "Login_Tables",
                columns: table => new
                {
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    password_hash = table.Column<string>(type: "TEXT", nullable: false),
                    authorization_level = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login_Tables", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "Student_Groups",
                columns: table => new
                {
                    group_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    section_number = table.Column<int>(type: "INTEGER", nullable: false),
                    group_number = table.Column<int>(type: "INTEGER", nullable: false),
                    submission_link = table.Column<string>(type: "TEXT", nullable: true),
                    group_modifier = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Groups", x => x.group_id);
                });

            migrationBuilder.CreateTable(
                name: "Rubric_Items",
                columns: table => new
                {
                    rubric_item_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    class_number = table.Column<int>(type: "INTEGER", nullable: false),
                    Admins_Teacherprof_netid = table.Column<string>(type: "TEXT", nullable: true),
                    rubric_item_text = table.Column<string>(type: "TEXT", nullable: false),
                    rubric_item_details = table.Column<string>(type: "TEXT", nullable: true),
                    max_points = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubric_Items", x => x.rubric_item_id);
                    table.ForeignKey(
                        name: "FK_Rubric_Items_Admins_Teachers_Admins_Teacherprof_netid",
                        column: x => x.Admins_Teacherprof_netid,
                        principalTable: "Admins_Teachers",
                        principalColumn: "prof_netid");
                });

            migrationBuilder.CreateTable(
                name: "TAs",
                columns: table => new
                {
                    ta_netid = table.Column<string>(type: "TEXT", nullable: false),
                    class_number = table.Column<int>(type: "INTEGER", nullable: false),
                    Admins_Teacherprof_netid = table.Column<string>(type: "TEXT", nullable: true),
                    first_name = table.Column<string>(type: "TEXT", nullable: false),
                    last_name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAs", x => x.ta_netid);
                    table.ForeignKey(
                        name: "FK_TAs_Admins_Teachers_Admins_Teacherprof_netid",
                        column: x => x.Admins_Teacherprof_netid,
                        principalTable: "Admins_Teachers",
                        principalColumn: "prof_netid");
                });

            migrationBuilder.CreateTable(
                name: "Judges",
                columns: table => new
                {
                    judge_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    first_name = table.Column<string>(type: "TEXT", nullable: false),
                    last_name = table.Column<string>(type: "TEXT", nullable: false),
                    judge_team_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Judges", x => x.judge_id);
                    table.ForeignKey(
                        name: "FK_Judges_Judge_Teams_judge_team_id",
                        column: x => x.judge_team_id,
                        principalTable: "Judge_Teams",
                        principalColumn: "judge_team_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rubric_Item_Grades",
                columns: table => new
                {
                    grade_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    group_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Student_Groupgroup_id = table.Column<int>(type: "INTEGER", nullable: false),
                    rubric_item_id = table.Column<int>(type: "INTEGER", nullable: false),
                    rubric_item_score = table.Column<int>(type: "INTEGER", nullable: false),
                    ta_comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubric_Item_Grades", x => x.grade_id);
                    table.ForeignKey(
                        name: "FK_Rubric_Item_Grades_Student_Groups_Student_Groupgroup_id",
                        column: x => x.Student_Groupgroup_id,
                        principalTable: "Student_Groups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    schedule_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    judge_team_id = table.Column<int>(type: "INTEGER", nullable: false),
                    group_id = table.Column<int>(type: "INTEGER", nullable: true),
                    Student_Groupgroup_id = table.Column<int>(type: "INTEGER", nullable: false),
                    schedule_room = table.Column<string>(type: "TEXT", nullable: false),
                    schedule_time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.schedule_id);
                    table.ForeignKey(
                        name: "FK_Schedules_Judge_Teams_judge_team_id",
                        column: x => x.judge_team_id,
                        principalTable: "Judge_Teams",
                        principalColumn: "judge_team_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Student_Groups_Student_Groupgroup_id",
                        column: x => x.Student_Groupgroup_id,
                        principalTable: "Student_Groups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    student_netid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    group_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Student_Groupgroup_id = table.Column<int>(type: "INTEGER", nullable: false),
                    first_name = table.Column<string>(type: "TEXT", nullable: false),
                    last_name = table.Column<string>(type: "TEXT", nullable: false),
                    student_modifier = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.student_netid);
                    table.ForeignKey(
                        name: "FK_Students_Student_Groups_Student_Groupgroup_id",
                        column: x => x.Student_Groupgroup_id,
                        principalTable: "Student_Groups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Survey_Responses",
                columns: table => new
                {
                    survey_response_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    group_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Student_Groupgroup_id = table.Column<int>(type: "INTEGER", nullable: false),
                    judge_id = table.Column<int>(type: "INTEGER", nullable: false),
                    question_id = table.Column<int>(type: "INTEGER", nullable: false),
                    survey_num_response = table.Column<int>(type: "INTEGER", nullable: true),
                    survey_text_response = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey_Responses", x => x.survey_response_id);
                    table.ForeignKey(
                        name: "FK_Survey_Responses_Judges_judge_id",
                        column: x => x.judge_id,
                        principalTable: "Judges",
                        principalColumn: "judge_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Survey_Responses_Student_Groups_Student_Groupgroup_id",
                        column: x => x.Student_Groupgroup_id,
                        principalTable: "Student_Groups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Judges_judge_team_id",
                table: "Judges",
                column: "judge_team_id");

            migrationBuilder.CreateIndex(
                name: "IX_Rubric_Item_Grades_Student_Groupgroup_id",
                table: "Rubric_Item_Grades",
                column: "Student_Groupgroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_Rubric_Items_Admins_Teacherprof_netid",
                table: "Rubric_Items",
                column: "Admins_Teacherprof_netid");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_judge_team_id",
                table: "Schedules",
                column: "judge_team_id");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Student_Groupgroup_id",
                table: "Schedules",
                column: "Student_Groupgroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Student_Groupgroup_id",
                table: "Students",
                column: "Student_Groupgroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_Survey_Responses_judge_id",
                table: "Survey_Responses",
                column: "judge_id");

            migrationBuilder.CreateIndex(
                name: "IX_Survey_Responses_Student_Groupgroup_id",
                table: "Survey_Responses",
                column: "Student_Groupgroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_TAs_Admins_Teacherprof_netid",
                table: "TAs",
                column: "Admins_Teacherprof_netid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login_Tables");

            migrationBuilder.DropTable(
                name: "Rubric_Item_Grades");

            migrationBuilder.DropTable(
                name: "Rubric_Items");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Survey_Responses");

            migrationBuilder.DropTable(
                name: "TAs");

            migrationBuilder.DropTable(
                name: "Judges");

            migrationBuilder.DropTable(
                name: "Student_Groups");

            migrationBuilder.DropTable(
                name: "Admins_Teachers");

            migrationBuilder.DropTable(
                name: "Judge_Teams");
        }
    }
}
