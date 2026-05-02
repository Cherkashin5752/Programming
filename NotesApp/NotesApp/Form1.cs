using NotesApp.Model;
using System.ComponentModel;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        private BindingList<Note> Notes = new BindingList<Note>();

        private Note _currentNote;
        private int _currentNoteId;

        private bool _isUpdating = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxType.DataSource = Enum.GetValues(typeof(ENoteType));
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Note newNote = new Note("default name", "default description", ENoteType.Default);
            Notes.Add(newNote);
            _currentNote = newNote;
            SortList(Notes);
            RefreshListBox();
        }

        private void NotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (NotesList.SelectedIndex == -1 || Notes.Count == 0)
            {
                ClearDetails();
                return;
            }

            _currentNoteId = NotesList.SelectedIndex;
            _currentNote = Notes[_currentNoteId];

            if (!textBoxName.Focused && !textBoxDescription.Focused)
            {
                UpdateDetailsUI();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxName.Focused || _currentNote == null) return;

            try
            {
                _currentNote.Name = textBoxName.Text;
                _currentNote.EditDate = DateTime.Now;

                textBoxName.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                textBoxName.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Имя должно содердать не более 100 и не менее 1 символа");
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxDescription.Focused || _currentNote == null) return;

            string newDescription = textBoxDescription.Text;
            _currentNote.Description = newDescription;
            _currentNote.EditDate = DateTime.Now;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ENoteType newType = (ENoteType)comboBoxType.SelectedItem;
            if (_currentNote == null || _isUpdating) return;

            if (comboBoxType.SelectedItem == null) return;
                
            _currentNote.NoteType = newType;
            _currentNote.EditDate = DateTime.Now;
            SortList(Notes);
            RefreshListBox();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_currentNoteId != -1)
            {
                int indexToRemove = NotesList.SelectedIndex;
                Notes.RemoveAt(indexToRemove);
                _currentNote = null;
                RefreshListBox();
            }
        }

        private void SortList(BindingList<Note> Notes)
        {
            for (int i = 0; i < Notes.Count; i++)
            {
                int maxIndex = i;

                for (int j = i; j < Notes.Count; j++)
                {
                    if (Notes[j].EditDate > Notes[maxIndex].EditDate)
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    Note temp = Notes[i];
                    Notes[i] = Notes[maxIndex];
                    Notes[maxIndex] = temp;
                }
            }
        }

        private void ClearDetails()
        {
            _isUpdating = true;

            _currentNote = null;
            _currentNoteId = -1;

            textBoxName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            textBoxDate.Text = string.Empty;
            comboBoxType.SelectedIndex = 0;

            _isUpdating = false;
        }

        private void UpdateDetailsUI()
        {
            if (_currentNote == null) return;

            _isUpdating = true;

            try
            {
                textBoxName.Text = _currentNote.Name;
                textBoxDescription.Text = _currentNote.Description;
                textBoxDate.Text = _currentNote.CreationDate.ToString();
                comboBoxType.Text = _currentNote.NoteType.ToString();
            }
            finally
            {
                _isUpdating = false;
            }
        }

        private void RefreshListBox()
        {
            _isUpdating = true;

            Note selectedNote = _currentNote;

            NotesList.DataSource = null;
            NotesList.DataSource = Notes;
            NotesList.DisplayMember = "Name";

            if (selectedNote != null && Notes.Contains(selectedNote))
                NotesList.SelectedItem = selectedNote;
            else
                NotesList.SelectedIndex = -1;

            _isUpdating = false;
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            SortList(Notes);
            RefreshListBox();
        }

        private void textBoxDescription_Leave(object sender, EventArgs e)
        {
            SortList(Notes);
            RefreshListBox();
        }
    }
}
