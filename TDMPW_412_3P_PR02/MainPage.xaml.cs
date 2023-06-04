using System.ComponentModel;

namespace TDMPW_412_3P_PR02;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{

    TasksViewModel allTasks = new TasksViewModel();
    private int numberOfTasks;
    public int NumberOfTasks { get => numberOfTasks; set { numberOfTasks = value; OnPropertyChanged(); } }
    DateOnly localDate;

    private string formattedLocalDate;
    public string FormattedLocalDate { get => formattedLocalDate; set { formattedLocalDate = value; } }


    public MainPage()
	{
		InitializeComponent();
        NumberOfTasks = allTasks.Tasks.Count;
        BindingContext = allTasks;
        localDate = DateOnly.FromDateTime(DateTime.Now);
        formattedLocalDate = localDate.ToLongDateString();
        lblDate.BindingContext = this;
        lblNoTasks.BindingContext = this;
    }

    private void btnAdd_Clicked(System.Object sender, System.EventArgs e)
    {
       NumberOfTasks++;
       Task newTask = new Task(numberOfTasks,txtNewTask.Text,false);
       allTasks.Tasks.Add(newTask);

    }

    private void btnDelete_Clicked(System.Object sender, System.EventArgs e)
    {

        var btn = sender as Button;
        Task taskToSearch = btn.Parent.BindingContext as Task;
        var taskToDelete = allTasks.Tasks.Where(taskToDelete => taskToDelete.Id == taskToSearch.Id);

            allTasks.Tasks.Remove(taskToDelete.ElementAt(0));

         if (allTasks.Tasks.Count == 0) {
            NumberOfTasks = 0;
            }  
     
    }

    private void chkChangeStatus_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        var btn = sender as CheckBox;
        Task taskToSearch = btn.Parent.BindingContext as Task;
        var taskToModify = allTasks.Tasks.Where(taskToModify => taskToModify.Id == taskToSearch.Id);

        taskToModify.ElementAt(0).Completed = !taskToModify.ElementAt(0).Completed;
    }
}

