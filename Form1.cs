namespace TestingWinForms
{
    public partial class MainWindow : Form
    {
        private bool usingEndTime = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.stateTextBox.PlaceholderText = DiscordRpcController.GetState();
            this.detailsTextBox.PlaceholderText = DiscordRpcController.GetDetails();
            this.lImageTextTextBox.PlaceholderText = DiscordRpcController.GetLargeImageText();
            this.lImageTextBox.PlaceholderText = DiscordRpcController.GetLargeImageKey();
            this.sImageTextTextBox.PlaceholderText = DiscordRpcController.GetSmallImageText();
            this.sImageTextBox.PlaceholderText = DiscordRpcController.GetSmallImageKey();
            this.sTimeTextBox.PlaceholderText = DiscordRpcController.GetStartTime();
            this.button1TextTextBox.PlaceholderText = DiscordRpcController.GetButton1Text();
            this.button1UrlTextBox.PlaceholderText = DiscordRpcController.GetButton1Url();
            this.button2TextTextBox.PlaceholderText = DiscordRpcController.GetButton2Text();
            this.button2UrlTextBox.PlaceholderText = DiscordRpcController.GetButton2Url();

            this.eTimeTextBox.PlaceholderText = "No End Time Setted Yet";

            this.ActiveControl = this.stateLabel;
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            DiscordRpcController.currentDetails = this.detailsTextBox.Text;
            DiscordRpcController.UpdateRpc(usingEndTime);
        }

        private void stateButton_Click(object sender, EventArgs e)
        {
            DiscordRpcController.currentState = this.stateTextBox.Text;
            DiscordRpcController.UpdateRpc(usingEndTime);
        }

        private void sTimeButton_Click(object sender, EventArgs e)
        {
            DiscordRpcController.currentStartTime = DateTime.Parse(this.sTimeTextBox.Text);
            DiscordRpcController.UpdateRpc(usingEndTime);
        }

        private void eTimeButton_Click(object sender, EventArgs e)
        {
            DateTime parsedTime;
            if (DateTime.TryParse(this.eTimeTextBox.Text, out parsedTime))
            {
                usingEndTime = (this.eTimeTextBox.Text == "") ? false : true;
                if (usingEndTime)
                    DiscordRpcController.currentEndTime = DateTime.Parse(this.eTimeTextBox.Text);
            }
            else
            {
                var infoPopUp = new InfoPopUp();
                infoPopUp.Show();
            }


            DiscordRpcController.UpdateRpc(usingEndTime);
        }

        private void lImageTextButton_Click(object sender, EventArgs e)
        {
            DiscordRpcController.currentLargeImageText = this.lImageTextTextBox.Text;
            DiscordRpcController.UpdateRpc(usingEndTime);
        }

        private void lImageButton_Click(object sender, EventArgs e)
        {
            DiscordRpcController.currentLargeImageKey = this.lImageTextBox.Text;
            DiscordRpcController.UpdateRpc(usingEndTime);
        }

        private void sImageTextButton_Click(object sender, EventArgs e)
        {
            DiscordRpcController.currentSmallImageText = this.sImageTextTextBox.Text;
            DiscordRpcController.UpdateRpc(usingEndTime);
        }

        private void sImageButton_Click(object sender, EventArgs e)
        {
            DiscordRpcController.currentSmallImageKey = this.sImageTextBox.Text;
            DiscordRpcController.UpdateRpc(usingEndTime);
        }



        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Button_Click(object sender, EventArgs e)
        {
            DiscordRpcController.currentButton1Text = this.button1TextTextBox.Text;
            DiscordRpcController.currentButton1Url = this.button1UrlTextBox.Text;
            DiscordRpcController.UpdateRpc(usingEndTime);
        }

        private void button2Button_Click(object sender, EventArgs e)
        {
            DiscordRpcController.currentButton2Text = this.button2TextTextBox.Text;
            DiscordRpcController.currentButton2Url = this.button2UrlTextBox.Text;
            DiscordRpcController.UpdateRpc(usingEndTime);
        }
    }
}
