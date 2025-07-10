using Dapper;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Views.Admin;

namespace TrinityCinema.Models
{
    public class AllMethods
    {
        string connectionString = GlobalSettings.connectionString;

        public (string Role, string UserID) ValidateLogin(string userName, string password)
        {
            using (var sql = new SqlConnection(connectionString))
            {
                // Adjusted query to only fetch by username
                string query = "SELECT PasswordHash, Role, UserID FROM Users WHERE Username = @Username";

                sql.Open();
                using (var cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("@Username", userName);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["PasswordHash"]?.ToString();

                            if (storedHash != null && BCrypt.Net.BCrypt.Verify(password, storedHash))
                            {
                                string role = reader["Role"]?.ToString();
                                string userID = reader["UserID"]?.ToString();
                                return (role, userID);
                            }
                        }
                    }
                }
            }

            return (null, null); // Login failed
        }

        //Retrieval of records
        public List<T> GetRecords<T>(string query, object parameters = null)
        {
            IEnumerable<T> records;
            using (var sql = new SqlConnection(connectionString))
            {
                sql.Open();
                records = sql.Query<T>(query, parameters, commandType: CommandType.Text);
            }
            return records.ToList();
        }

        public static void LoadCheckedComboBoxData<T>(CheckedComboBoxEdit control, string query, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var data = connection.Query<T>(query).ToList();

                control.Properties.Items.Clear();

                foreach (var item in data)
                {
                    // Assuming T has GenreID and GenreName properties
                    var genreID = (int)item.GetType().GetProperty("GenreID").GetValue(item);
                    var genreName = (string)item.GetType().GetProperty("GenreName").GetValue(item);

                    control.Properties.Items.Add(new CheckedListBoxItem(genreID, genreName, CheckState.Unchecked, true));
                }
            }
        }


        //Populate LookUpEdits

        public static void LoadComboBoxData<T>(ComboBoxEdit control, string query, string connectionString, Func<T, string> selector)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var data = connection.Query<T>(query).ToList();

                control.Properties.Items.Clear();
                control.Properties.Items.AddRange(data.Select(selector).ToList());
            }
        }


        public static void LoadLookupData<T>(LookUpEdit control, string query, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var data = connection.Query<T>(query).ToList();
                control.Properties.DataSource = data;
            }
        }

        //Reusable method for inserting data
        public void InsertMethod(object classAdd, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, classAdd);
            }
            // XtraMessageBox.Show("Account details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool InsertMovieGenre(string movieID, int genreID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
                {
                    string query = "INSERT INTO MovieGenres (MovieID, GenreID) VALUES (@MovieID, @GenreID)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MovieID", movieID);
                        cmd.Parameters.AddWithValue("@GenreID", genreID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Optional: log the error or show a message
                MessageBox.Show($"Error inserting genre: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //public Dictionary<string, string> GetRecordById(string query, object parameters, List<string> columns)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            // Add parameters dynamically
        //            foreach (var prop in parameters.GetType().GetProperties())
        //            {
        //                command.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(parameters) ?? DBNull.Value);
        //            }

        //            connection.Open();

        //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //            {
        //                DataTable dt = new DataTable();
        //                adapter.Fill(dt);

        //                if (dt.Rows.Count == 0)
        //                    return null;

        //                DataRow row = dt.Rows[0];
        //                Dictionary<string, string> result = new Dictionary<string, string>();

        //                foreach (string col in columns)
        //                {
        //                    result[col] = row[col]?.ToString() ?? "";
        //                }

        //                return result;
        //            }
        //        }
        //    }
        //}

        public Dictionary<string, string> GetRecordById(string query, object parameters, List<string> columns)
        {
            var record = new Dictionary<string, string>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var prop in parameters.GetType().GetProperties())
                    {
                        command.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(parameters));
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foreach (var column in columns)
                            {
                                object value = reader[column];
                                if (value == DBNull.Value)
                                {
                                    record[column] = null;
                                }
                                else if (value is byte[]) // for image/VARBINARY
                                {
                                    record[column] = Convert.ToBase64String((byte[])value);
                                }
                                else
                                {
                                    record[column] = value.ToString();
                                }
                            }
                        }
                        else
                        {
                            return null; // not found
                        }
                    }
                }
            }

            return record;
        }


        public bool UpdateRecord(string tableName, object parameters, List<string> columns, string keyColumn)
        {
            if (parameters == null) return false;

            string setClause = string.Join(", ", columns.Select(c => $"{c} = @{c}"));
            string query = $"UPDATE [{tableName}] SET {setClause} WHERE {keyColumn} = @{keyColumn}";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int rows = connection.Execute(query, parameters);
                return rows > 0;  // Return true if rows were updated
            }
        }

        public bool RemoveRecordByKey(string primaryKeyColumn, string primaryKeyValue, List<string> tablesToDeleteFrom, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(primaryKeyValue) || tablesToDeleteFrom == null || tablesToDeleteFrom.Count == 0)
            {
                MessageBox.Show("Invalid input.");
                return false;
            }

            var parameters = new Dictionary<string, object> { { primaryKeyColumn, primaryKeyValue } };

            string deleteQuery = string.Join(Environment.NewLine,
                tablesToDeleteFrom.Select(t => $"DELETE FROM [{t}] WHERE [{primaryKeyColumn}] = @{primaryKeyColumn};"));

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int rowsAffected = connection.Execute(deleteQuery, parameters);
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No matching record found.");
                    return false;
                }
            }
        }


        public static void ShowModal<T>(Func<AdminMainForm, T> formFactory) where T : Form
        {
            // Get open ManagerHome instance
            var managerHome = Application.OpenForms.OfType<AdminMainForm>().FirstOrDefault();

            if (managerHome == null)
            {
                MessageBox.Show("ManagerHome not found.");
                return;
            }

            // Prevent multiple dialogs of the same type
            if (Application.OpenForms.OfType<T>().Any())
                return;

            // Create form instance using factory method
            var form = formFactory(managerHome);

            // Optional: standard modal dialog settings
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowInTaskbar = false;

            // Show as modal
            form.ShowDialog(managerHome);
        }

        public static void GridCustomization(GridControl grid, TileView view, object data)
        {
            view.BeginUpdate();
            try
            {
                grid.DataSource = null;
                grid.DataSource = data;
                grid.RefreshDataSource();
            }
            finally
            {
                view.EndUpdate();
            }
        }

        public static void GridCustomization(GridControl gridControl, GridView gridView, object dataSource)
        {
            gridControl.DataSource = null; // Clear existing data
            gridControl.DataSource = dataSource; // Reload data
            gridControl.RefreshDataSource(); // Ensure grid refresh

            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            gridView.OptionsView.ShowHorizontalLines = DefaultBoolean.True;
            gridView.OptionsView.ShowVerticalLines = DefaultBoolean.False;
            gridView.OptionsView.RowAutoHeight = true;
            gridView.ColumnPanelRowHeight = 30;
            gridView.OptionsCustomization.AllowColumnResizing = false;
        }

        public static void RefreshManagerHome<T>(Func<AdminMainForm, T> createNewControl) where T : Control
        {
            // Locate the ManagerHome form
            AdminMainForm adminForm = Application.OpenForms.OfType<AdminMainForm>().FirstOrDefault();
            if (adminForm == null)
            {
                MessageBox.Show("ManagerHome not found.");
                return;
            }

            // Find and remove existing control of type T
            T oldControl = adminForm.gcHome.Controls.OfType<T>().FirstOrDefault();
            if (oldControl != null)
            {
                adminForm.gcHome.Controls.Remove(oldControl);
                oldControl.Dispose();
            }

            // Create and add the new control
            T newControl = createNewControl(adminForm);
            newControl.Dock = DockStyle.Fill;
            adminForm.gcHome.Controls.Add(newControl);
            newControl.BringToFront();
        }

    }
}


 
