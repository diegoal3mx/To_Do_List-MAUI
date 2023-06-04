using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_412_3P_PR02
{
    public class Task : INotifyPropertyChanged
    {
        private int id;
        private string description;
        private bool completed;

        public int Id { get=>id; set { id = value; RaisePropertyChanged(nameof(Id)); }}
        public string Description { get=>description; set { description = value; RaisePropertyChanged(nameof(Description)); } }
        public bool Completed { get=>completed; set { completed = value;  RaisePropertyChanged(nameof(Completed)); } }

        public Task(int id, string description, bool completed)
        {
            this.id = id;
            this.description = description;
            this.completed = completed;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
