using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Model
{
    internal class Note
    {
        private string _name;
        private string _description;
        private DateTime _creationDate;
        private DateTime _editDate;
        private ENoteType _noteType;

        public string Name
        {
            get { return _name; }
            set
            {
                if (Validator.AssertValueInRange(value.Length, 0, 101))
                {
                    _name = value;
                }
            }
        }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime EditDate { get; set; }

        public ENoteType NoteType { get; set; }

        public Note(string name, string description, ENoteType noteType)
        {
            Name = name;
            Description = description;
            CreationDate = DateTime.Now;
            EditDate = DateTime.Now;
            NoteType = noteType;
        }
    }
}
