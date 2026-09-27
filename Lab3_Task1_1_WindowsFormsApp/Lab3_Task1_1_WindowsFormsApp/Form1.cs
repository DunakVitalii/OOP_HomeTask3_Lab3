namespace Lab3_Task1_1_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label myLabel = new Label();
            myLabel.Text = "Hello World";
            myLabel.AutoSize = true;

            this.Controls.Add(myLabel);

            myLabel.Location = new Point(
                (this.ClientSize.Width - myLabel.Width) / 2,
                (this.ClientSize.Height - myLabel.Height) / 2
            );

            myLabel.Anchor = AnchorStyles.None;
        }
    }
}
