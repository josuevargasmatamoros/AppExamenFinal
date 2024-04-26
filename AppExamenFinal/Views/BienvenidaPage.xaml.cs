using AppExamenFinal.ViewModels;
namespace AppExamenFinal.Views;

public partial class BienvenidaPage : ContentPage
{

    UserViewModel? vm;

    public BienvenidaPage()
	{
		InitializeComponent();
        BindingContext = vm = new UserViewModel();

        //Y ahora llamamos a la funcion que se encarga de llenar el picker
        //con los datos de los roles de Usuario

        ConsultarPorID();
    }

    private async void ConsultarPorID()
    {

        await vm.GetAllUserRolesAsync();

    }

    private async void BtnIngresar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PreguntaPage());
       


    }
}