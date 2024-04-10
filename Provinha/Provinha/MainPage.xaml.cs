

namespace Provinha
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
        }
        private void onRodar(object sender, EventArgs e)
        {
            int convercao = Convert.ToInt32(picker.SelectedItem);
            int trocar = new Random().Next(1, convercao + 1);
            Mostrar.Text=trocar.ToString();
        }

    }

}
