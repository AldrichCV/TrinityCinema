using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCinema.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrinityCinema.Views.Admin
{
    public partial class NewGenre : DevExpress.XtraEditors.XtraForm
    {
        public Action RefreshGenreList { get; set; }
        private string loggedInUser;
        public NewGenre(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string newGenreName = teNewGenre.Text.Trim();

            if (string.IsNullOrWhiteSpace(newGenreName))
            {
                XtraMessageBox.Show("Genre name cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(Exists(newGenreName))
                    {
                        XtraMessageBox.Show("This genre already exists.", "Duplicate Genre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }
            

            DialogResult result = XtraMessageBox.Show("Add Genre?", "Verify",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                AllMethods allMethods = new AllMethods();
                Genre addGenre = new Genre
                {
                    GenreName = newGenreName
                };

                allMethods.InsertMethod(addGenre, GlobalSettings.insertNewGenre);
                XtraMessageBox.Show("Genre added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                allMethods.Log(loggedInUser, "Add Genre", $"Added new genre: {addGenre.GenreName}");

                RefreshGenreList?.Invoke();

                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Exists(string newGenreName)
        {
            using (var connection = new SqlConnection(GlobalSettings.connectionString))
            {
                string query = "SELECT COUNT(*) FROM Genre WHERE LOWER(GenreName) = LOWER(@GenreName)";
                int count = connection.ExecuteScalar<int>(query, new { GenreName = newGenreName });
                return count > 0;
            }

        }

        private void teNewGenre_EditValueChanged(object sender, EventArgs e)
        {
            string genreName = teNewGenre.Text.Trim();

            if (string.IsNullOrEmpty(genreName))
            {
                genreErrorProvider.SetError(teNewGenre, "Genre cannot be empty.");
                return;
            }

            if (Exists(genreName))
            {
                genreErrorProvider.SetError(teNewGenre, "Genre already exists.");
            }
            else
            {
                genreErrorProvider.SetError(teNewGenre, string.Empty);
            }
        }
    }
    }
