using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiAppJeffersonR.Models
{
    internal class AllNotesJeffersonRuiz
    {
        public ObservableCollection<JeffersonRuizNote> Notes { get; set; } = new ObservableCollection<JeffersonRuizNote>();
        public AllNotesJeffersonRuiz() =>
            LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();

            // Get the folder where the notes are stored.
            string appDataPath = FileSystem.AppDataDirectory;

            // Use Linq extensions to load the *.notes.txt files.
            IEnumerable<JeffersonRuizNote> notes = Directory

                                        // Select the file names from the directory
                                        .EnumerateFiles(appDataPath, "*.notes.txt")

            // Each file name is used to create a new Note
                                        .Select(filename => new JeffersonRuizNote()
                                        {
                                            Filename = filename,
                                            Text = File.ReadAllText(filename),
                                            Date = File.GetLastWriteTime(filename)
                                        })

                                        // With the final collection of notes, order them by date
                                        .OrderBy(note => note.Date);

            // Add each note into the ObservableCollection
            foreach (JeffersonRuizNote note in notes)
                Notes.Add(note);
        }
    }
}
