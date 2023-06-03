namespace TDMPW_412_3P_PR02;

public partial class MainPage : ContentPage
{

    TasksViewModel allTasks = new TasksViewModel();
    int numberOfTasks;
    Task taskToDelete;

    public MainPage()
	{
		InitializeComponent();
        numberOfTasks = allTasks.Tasks.Count;
        BindingContext = allTasks;
    }

    void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        Task item = args.SelectedItem as Task;

        if (item != null)
        {
            taskToDelete = item;
        }
        else { 
            taskToDelete = null;
        }

    }

    private async void btnAdd_Clicked(System.Object sender, System.EventArgs e)
    {
       numberOfTasks++;
       Task newTask = new Task(numberOfTasks,txtNuevaTarea.Text,false);
       allTasks.Tasks.Add(newTask);

        await DisplayAlert("Tarea agregada con éxito","", "Aceptar");
    }

    private async void btnDelete_Clicked(System.Object sender, System.EventArgs e)
    {
        if (taskToDelete != null)
        {
            allTasks.Tasks.Remove(taskToDelete);
            await DisplayAlert("Tarea eliminada con éxito", "", "Aceptar");
        }
        else {
            await DisplayAlert("Selecciona una tarea para eliminar", "", "Aceptar");
        }
       
     
    }

    private void btnChangeStatus_Clicked(System.Object sender, System.EventArgs e)
    {
      
        var btn = sender as Button;
        Task taskToSearch = btn.Parent.BindingContext as Task;
        var taskToModify = allTasks.Tasks.Where(taskToModify => taskToModify.Id == taskToSearch.Id);
        
        taskToModify.ElementAt(0).Status = !taskToModify.ElementAt(0).Status;
    }
}

