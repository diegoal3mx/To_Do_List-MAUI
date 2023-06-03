using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_412_3P_PR02
{
    public class TasksViewModel: INotifyPropertyChanged
    {

        private ObservableCollection<Task> tasks = new ObservableCollection<Task>();

        public TasksViewModel()
        {
            tasks.Add(new Task(1, "Terminar Práctica 2", false));
        }

        public ObservableCollection<Task> Tasks
        {
            get => tasks;
            set { tasks = value;  RaisePropertyChanged(nameof(Tasks));}
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
