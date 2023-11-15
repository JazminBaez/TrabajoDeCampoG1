using seguridad_barrios_privados.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using seguridad_barrios_privados.Util;

namespace seguridad_barrios_privados.Repositorio
{

    public class BackupRepositorio
    {
        private readonly DbBarriosPrivadosContext? _context;

        public BackupRepositorio()
        {
            _context = Contexto.dbBarriosPrivadosContext!;
        }

        public async Task<bool> Backup(string path)
        {
            try
            {
                string backupFileName = $"db_barrios_privados-{DateTime.Now:dd-MM-yyyy-HH-mm-ss}.bak";
                string backupFilePath = Path.Combine(path, backupFileName);

                // imprime la ubicación del archivo
                Console.WriteLine(backupFilePath);

                string query = $"BACKUP DATABASE [db_barrios_privados] TO DISK = '{backupFilePath}'";
                await _context.Database.ExecuteSqlRawAsync(query);
                MessageBox.Show("Backup realizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
                return false;
            }
        }


        public async Task<bool> Restore(string path)
        {
            try
            {
                // Cambiar la base de datos a modo de usuario único antes de la restauración
                await _context.Database.ExecuteSqlRawAsync("USE MASTER ALTER DATABASE [db_barrios_privados] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");

                // Realizar la restauración
                string restoreQuery = "USE MASTER RESTORE DATABASE [db_barrios_privados] FROM DISK = @path WITH REPLACE";
                SqlParameter[] restoreParameters = new SqlParameter[] { new("@path", path) };
                await _context.Database.ExecuteSqlRawAsync(restoreQuery, restoreParameters);

                // Cambiar la base de datos de vuelta a modo multiusuario
                await _context.Database.ExecuteSqlRawAsync("USE MASTER ALTER DATABASE [db_barrios_privados] SET MULTI_USER");

                // Migrar la base de datos si es necesario
                await _context.Database.MigrateAsync();

                _context.ChangeTracker.Clear();
                MessageBox.Show("Base de datos restaurada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Error al restaurar la base de datos en SQL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error al restaurar la base de datos: {sqlException}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        public string GetUbication(bool getFile)
        {
                if (!getFile)
                {
                    FolderBrowserDialog folderBrowserDialog = new();
                    folderBrowserDialog.ShowDialog();
                    return folderBrowserDialog.SelectedPath;
                }

                OpenFileDialog openFileDialog = new()
                {
                    Filter = "Backup files (*.bak)|*.bak",
                    Title = "Seleccionar archivo",
                    RestoreDirectory = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Multiselect = false,
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK) return openFileDialog.FileName;

                return string.Empty;
            
        }
    }
}
