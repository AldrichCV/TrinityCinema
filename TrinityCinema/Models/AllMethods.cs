using Dapper;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.WinExplorer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Views.Admin;


namespace TrinityCinema.Models
{
    public class AllMethods
    {
        string connectionString = GlobalSettings.connectionString;

        #region Login and User Management
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

        public (bool IsLocked, int FailedAttempts)? GetUserLoginStatus(string username)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("SELECT IsLocked, FailedAttempts FROM Users WHERE Username = @Username", conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bool isBanned = Convert.ToBoolean(reader["IsLocked"]);
                        int attempts = Convert.ToInt32(reader["FailedAttempts"]);
                        return (isBanned, attempts);
                    }
                }
            }

            return null;
        }

        public (bool IsLocked, int FailedAttempts)? GetUserLoginStatusByUserID(string userID)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("SELECT IsLocked, FailedAttempts FROM Users WHERE UserID = @UserID", conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userID);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bool isLocked = Convert.ToBoolean(reader["IsLocked"]);
                        int attempts = Convert.ToInt32(reader["FailedAttempts"]);
                        return (isLocked, attempts);
                    }
                }
            }

            return null;
        }


        public static void UpdateLoginAttempts(string username, int attempts, bool isBanned)
        {
            using (var conn = new SqlConnection(GlobalSettings.connectionString))
            using (var cmd = new SqlCommand("UPDATE Users SET FailedAttempts = @Attempts, IsLocked = @Banned WHERE Username = @Username", conn))
            {
                cmd.Parameters.AddWithValue("@Attempts", attempts);
                cmd.Parameters.AddWithValue("@Banned", isBanned);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ResetLoginAttempts(string username)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("UPDATE Users SET FailedAttempts = 0, IsLocked = 0 WHERE Username = @Username", conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion


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


        public DataRow GetRecord(string tableName, string keyColumn, object keyValue)
        {
            using (SqlConnection conn = new SqlConnection(GlobalSettings.connectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM {tableName} WHERE {keyColumn} = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", keyValue);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                            return table.Rows[0];
                        else
                            return null;
                    }
                }
            }
        }




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
        public static void WinViewCustomization(GridControl grid, WinExplorerView view, object data)
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


        public void Log(string loggedInUser, string action, string description)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO ActivityLogs (UserID, Action, Description) 
                             VALUES (@UserID, @Action, @Description)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", loggedInUser);
                    cmd.Parameters.AddWithValue("@Action", action);
                    cmd.Parameters.AddWithValue("@Description", description);

                    conn.Open();        
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string GetSeatStatusFromDatabase(string seatIdentifier)
        {
            string status = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Status FROM SeatLayouts WHERE seat_Identifier = @seatIdentifier";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@seatIdentifier", seatIdentifier);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        status = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            }

            return status;
        }
        public static void RefreshManagerHome<T>(
    Func<AdminMainForm, T> createNewControl,
    Action<T> refreshIfExists = null
) where T : Control
        {
            AdminMainForm adminForm = Application.OpenForms.OfType<AdminMainForm>().FirstOrDefault();
            if (adminForm == null)
            {
                MessageBox.Show("ManagerHome not found.");
                return;
            }

            T oldControl = adminForm.gcHome.Controls.OfType<T>().FirstOrDefault();
            if (oldControl != null)
            {
                if (refreshIfExists != null)
                {
                    refreshIfExists(oldControl);
                    oldControl.BringToFront();
                    return;
                }

                adminForm.gcHome.Controls.Remove(oldControl);
                oldControl.Dispose();
            }

            T newControl = createNewControl(adminForm);
            newControl.Dock = DockStyle.Fill;
            adminForm.gcHome.Controls.Add(newControl);
            newControl.BringToFront();
        }

    }
}
      



 
