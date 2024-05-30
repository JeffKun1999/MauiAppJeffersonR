namespace MauiAppJeffersonR.Views;

public partial class AllNoteJeffersonRuiz : ContentPage
{
    public AllNoteJeffersonRuiz()
    {
        InitializeComponent();

        BindingContext = new Models.AllNotesJeffersonRuiz();
    }
    protected override void OnAppearing()
    {
        ((Models.AllNotesJeffersonRuiz)BindingContext).LoadNotes();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NewPageJeffersonRuiz));
    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var note = (Models.JeffersonRuizNote)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(NewPageJeffersonRuiz)}?{nameof(NewPageJeffersonRuiz.ItemId)}={note.Filename}");

            // Unselect the UI
            notesCollection.SelectedItem = null;
        }
    }
}