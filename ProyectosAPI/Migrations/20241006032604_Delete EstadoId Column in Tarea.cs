using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectosAPI.Migrations
{
    /// <inheritdoc />
    public partial class DeleteEstadoIdColumninTarea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Tareas");

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstadoTareasId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 3,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 4,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 5,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 6,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 7,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 8,
                column: "EstadoTareasId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 9,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 10,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 11,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 12,
                column: "EstadoTareasId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 13,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 14,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 15,
                column: "EstadoTareasId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "Id", "Descripcion", "EstadoTareasId", "ProyectoId" },
                values: new object[,]
                {
                    { 16, "Investigación de usuario", 1, 4 },
                    { 17, "Creación de wireframes", 1, 4 },
                    { 18, "Diseño de interfaz de usuario", 2, 4 },
                    { 19, "Implementación de prototipos", 1, 4 },
                    { 20, "Pruebas de usabilidad", 1, 4 },
                    { 21, "Desarrollo de conceptos", 1, 5 },
                    { 22, "Diseño de logo", 1, 5 },
                    { 23, "Creación de guías de estilo", 2, 5 },
                    { 24, "Elaboración de material promocional", 1, 5 },
                    { 25, "Presentación al cliente", 1, 5 },
                    { 26, "Diseño de pantallas", 1, 6 },
                    { 27, "Creación de iconografía", 1, 6 },
                    { 28, "Pruebas de diseño", 1, 6 },
                    { 29, "Adaptación a diferentes dispositivos", 2, 6 },
                    { 30, "Revisión final de diseño", 1, 6 },
                    { 31, "Auditoría de infraestructura", 1, 7 },
                    { 32, "Revisión de configuraciones actuales", 1, 7 },
                    { 33, "Implementación de mejoras", 2, 7 },
                    { 34, "Pruebas de conectividad", 1, 7 },
                    { 35, "Documentación de cambios", 1, 7 },
                    { 36, "Configuración de herramientas", 1, 8 },
                    { 37, "Desarrollo de scripts de automatización", 1, 8 },
                    { 38, "Pruebas de integración", 2, 8 },
                    { 39, "Documentación del proceso", 1, 8 },
                    { 40, "Implementación en producción", 1, 8 },
                    { 41, "Selección de plataforma", 1, 9 },
                    { 42, "Planificación de migración", 1, 9 },
                    { 43, "Transferencia de datos", 2, 9 },
                    { 44, "Configuración de seguridad", 1, 9 },
                    { 45, "Pruebas y ajustes finales", 1, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Tareas",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Tareas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EstadoId", "EstadoTareasId" },
                values: new object[] { 1, null });
        }
    }
}
