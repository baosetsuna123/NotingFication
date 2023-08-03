using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Noting_Fication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Noting_Fication
{
    public partial class List : Form
    {
        private List<Note> notes;
        private String connectionString = "server =(local); database= NotingFication_2; uid=sa;pwd=12345; TrustServerCertificate=True";
        private readonly NotingFication_2Context dbContext;
        public List()
        {
            InitializeComponent();
            notes = new List<Note>();
            dbContext = new NotingFication_2Context();
        }

        private void List_Load(object sender, EventArgs e)
        {
            LoadNote();
            RefreshList();
        }

        private void RefreshList()
        {
            listNote.Items.Clear();
            foreach (Note note in notes)
            {
                listNote.Items.Add(note.Name);
            }
        }
        private void LoadNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT NoteID, Name, Content FROM Note";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<Note> notes = new List<Note>();
                            while (reader.Read())
                            {
                                int noteId = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string content = reader.GetString(2);

                                Note note = new Note { NoteId = noteId, Name = name, Content = content };
                                notes.Add(note);
                            }
                            reader.Close();

                            foreach (Note note in notes)
                            {
                                ListViewItem item = new ListViewItem(note.NoteId.ToString());
                                item.SubItems.Add(note.Name);
                                item.SubItems.Add(note.Content);
                                listNote.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notes: " + ex.Message);
            }

        }


        private void listNote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (listNote.SelectedItems.Count > 0)
            {
                // Get the selected note from the ListView
                var selectedItem = listNote.SelectedItems[0];
                var selectedNoteName = selectedItem.SubItems[0].Text;

                var selectedNote = notes.FirstOrDefault(n => n.Name == selectedNoteName);

                if (selectedNote != null)
                {
                    var result = MessageBox.Show("Are you sure you want to delete the selected note?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (var context = new NotingFication_2Context())
                            {
                                context.Notes.Remove(selectedNote);
                                context.SaveChanges();
                            }

                            // Refresh the notes list after deleting a note
                            LoadNote();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while deleting the note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a note to delete.", "Note Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}


//private void btnAddNote_Click(object sender, EventArgs e)
//{
//    CreateNote createNoteForm = new CreateNote();
//    createNoteForm.ShowDialog();

//    if (createNoteForm.NoteAdded)
//    {
//        LoadNote();
//    }

//    //if (createNoteForm.ShowDialog() == DialogResult.OK)
//    //{
//    //    Note newNote = Note.ReferenceEquals(createNoteForm.);

//    //    using (SqlConnection connection = new SqlConnection(connectionString))
//    //    {
//    //        connection.Open();

//    //        string query = "INSERT INTO Note (CreateDate, Name, UserId, CategoryId, Status, Deadline, Content) " +
//    //            "VALUES (@CreateDate, @Name, @UserId, @CategoryId, @Status, @Deadline, @Content)";

//    //        using (SqlCommand command = new SqlCommand(query, connection))
//    //        {
//    //            command.Parameters.AddWithValue("@CreateDate", newNote.CreateDate);
//    //            command.Parameters.AddWithValue("@Name", newNote.Name);
//    //            command.Parameters.AddWithValue("@UserId", newNote.UserId);
//    //            command.Parameters.AddWithValue("@CategoryId", newNote.CategoryId ?? (object)DBNull.Value);
//    //            command.Parameters.AddWithValue("@Status", newNote.Status ?? (object)DBNull.Value);
//    //            command.Parameters.AddWithValue("@Deadline", newNote.Deadline ?? (object)DBNull.Value);
//    //            command.Parameters.AddWithValue("@Content", newNote.Content);

//    //            command.ExecuteNonQuery();
//    //        }
//    //    }

//    //    LoadNote();
//    //    RefreshList();
//    //}
//}


//private void btnDeleteNote_Click(object sender, EventArgs e)
//{
//    if (listNote.SelectedItems != null)
//    {
//        int selectedIndex = listNote.TabIndex;
//        Note selectedNote = notes[selectedIndex];

//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            connection.Open();

//            string query = "DELETE FROM Note WHERE NoteId = @NoteId";

//            using (SqlCommand command = new SqlCommand(query, connection))
//            {
//                command.Parameters.AddWithValue("@NoteId", selectedNote.NoteId);
//                command.ExecuteNonQuery();
//            }
//        }

//        LoadNote();
//        RefreshList();
//    }
//}