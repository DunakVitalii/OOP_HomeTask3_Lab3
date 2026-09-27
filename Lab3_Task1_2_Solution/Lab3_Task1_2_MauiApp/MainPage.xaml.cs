namespace Lab3_Task1_2_MauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {

            string input = NumberEntry.Text;

            
            if (int.TryParse(input, out int number))
            {
                ResultLabel.Text = $"Ви ввели число {number}";
                ResultLabel.TextColor = Colors.Green;

                DisplayAlert("Результат", $"Ви ввели число {number}", "ОК");
            }
            else
            {
                ResultLabel.Text = "Помилка: будь ласка, введіть коректне ціле число.";
                ResultLabel.TextColor = Colors.Red;
            }
        }
        }
    }
