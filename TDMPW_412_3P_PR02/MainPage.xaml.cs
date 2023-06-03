using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TDMPW_412_3P_PR02;

public partial class MainPage : ContentPage
{

    TasksViewModel allTasks = new TasksViewModel();
    int numberOfTasks = 0;

    public MainPage()
	{
		InitializeComponent();
        BindingContext = allTasks;
    }


    private async void btnAdd_Clicked(System.Object sender, System.EventArgs e)
    {
       numberOfTasks++;
       Task newTask = new Task(numberOfTasks,txtNuevaTarea.Text,false);
       allTasks.Tasks.Add(newTask);

        await DisplayAlert("Tarea agregada con éxito","", "Ok");
    }
}

