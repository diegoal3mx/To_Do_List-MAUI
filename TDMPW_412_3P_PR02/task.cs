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
        public int id;
        public string description;
        public bool status;

        public int Id { get=>id; set { RaisePropertyChanged(nameof(Id)); }}
        public string Description { get=>description; set { RaisePropertyChanged(nameof(Description)); } }
        public bool Status { get=>status; set { RaisePropertyChanged(nameof(Status)); } }

        public Task(int id, string description, bool status)
        {
            this.id = id;
            this.description= description;
            this.status = status;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
