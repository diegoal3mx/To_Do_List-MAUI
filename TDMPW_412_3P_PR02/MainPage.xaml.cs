using System.Linq;

namespace TDMPW_412_3P_PR02;

public partial class MainPage : ContentPage
{
    public List<task> tasks { get; set; } = new List<task>();


    public MainPage()
	{
		InitializeComponent();

        task test = new task(1, "Terminar Práctica 2", false);
        tasks.AddRange(new task[] { test });
        BindingContext = this;
    }
    
	
}

