using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aircrafts;

public partial class MainWindow : Window
{
    private Plane _plane = new Plane(800, 8200);
    private Helicopter _helicopter = new Helicopter(2100);
    
    public MainWindow()
    {
        InitializeComponent();

        ComboBoxAircraft.SelectionChanged += new SelectionChangedEventHandler(this.ComboBoxAircraftSelect);
        ButtonBoarding.Click += new RoutedEventHandler(this.ButtonBoardingClick);
        ButtonTakeoff.Click += new RoutedEventHandler(this.ButtonTakeoffClick);
        TextBlockRunwayLength.Visibility = Visibility.Hidden;
        TextBoxRunwayLength.Visibility = Visibility.Hidden;
    }

    private void ComboBoxAircraftSelect(object sender, EventArgs e)
    {
        if (((ComboBoxItem)ComboBoxAircraft.SelectedItem).Content.ToString() == "Plane")
        {
            TextBlockRunwayLength.Visibility = Visibility.Visible;
            TextBoxRunwayLength.Visibility = Visibility.Visible;
        }

        if (((ComboBoxItem)ComboBoxAircraft.SelectedItem).Content.ToString() == "Helicopter")
        {
            TextBlockRunwayLength.Visibility = Visibility.Hidden;
            TextBoxRunwayLength.Visibility = Visibility.Hidden;
        }
    }

    private async void processOfBoarding()
    {
        TextBoxProcess.Text = "Попытка взлета...";
        await Task.Delay(1000);
        
        if (((ComboBoxItem)ComboBoxAircraft.SelectedItem).Content.ToString() == "Plane" && _plane.Boarding(int.Parse(TextBoxRunwayLength.Text)))
        {
            TextBoxProcess.Text = "Набрана высота 1000 м.";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Набрана высота 2000 м.";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Набрана высота 4000 м.";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Набрана высота 8000 м.";
            await Task.Delay(1000);
        }
        else if (((ComboBoxItem)ComboBoxAircraft.SelectedItem).Content.ToString() == "Plane" && !_plane.Boarding(int.Parse(TextBoxRunwayLength.Text)))
        {
            TextBoxProcess.Text = "Взлет неудачен. Взлетная полоса меньше 800м.";
            return;
        }

        if (((ComboBoxItem)ComboBoxAircraft.SelectedItem).Content.ToString() == "Helicopter" && _helicopter.Boarding(0))
        {
            TextBoxProcess.Text = "Набрана высота 500 м.";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Набрана высота 1000 м.";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Набрана высота 1500 м.";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Набрана высота 2000 м.";
            await Task.Delay(1000);
        }
        
        TextBoxProcess.Text = "Взлет успешен."; 
    }

    private async void processOfTakeoff()
    {
        TextBoxProcess.Text = "Попытка посадки...";
        await Task.Delay(1000);
        
        if (((ComboBoxItem)ComboBoxAircraft.SelectedItem).Content.ToString() == "Plane" && _plane.Takeoff(int.Parse(TextBoxRunwayLength.Text)))
        {
            TextBoxProcess.Text = "Текущая высота 8200 м...";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Снижение высоты до 4000 м...";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Снижение высоты до 2000 м...";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Снижение высоты до 1000 м...";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Посадка на посадочную полосу...";
            await Task.Delay(1000);
        }
        else if (((ComboBoxItem)ComboBoxAircraft.SelectedItem).Content.ToString() == "Plane" && !_plane.Takeoff(int.Parse(TextBoxRunwayLength.Text)))
        {
            TextBoxProcess.Text = "Посадка неудачна. Посадочная полоса меньше 800м.";
            return;
        }

        if (((ComboBoxItem)ComboBoxAircraft.SelectedItem).Content.ToString() == "Helicopter" && _helicopter.Takeoff(0))
        {
            TextBoxProcess.Text = "Текущая высота 2200 м...";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Снижение высоты до 1500 м...";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Снижение высоты до 1000 м...";
            await Task.Delay(1000);
            TextBoxProcess.Text = "Снижение высоты до 500 м...";
            await Task.Delay(1000);
        }
        
        TextBoxProcess.Text = "Посадка Успешна."; 
    }
    
    private void ButtonTakeoffClick(object sender, EventArgs e)
    {
        processOfTakeoff();
    }
    private void ButtonBoardingClick(object sender, EventArgs e)
    {
        processOfBoarding();
    }
}