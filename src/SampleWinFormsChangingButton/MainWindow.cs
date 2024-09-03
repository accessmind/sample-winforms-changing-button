namespace SampleWinFormsChangingButton;

public partial class MainWindow: Form {
    private const string BtnTextStart = "&Start";
    private const string BtnTextPause = "&Pause";
    private const string BtnTextResumeStop = "&Resume/Stop";

    public MainWindow() {
        InitializeComponent();
        TimerButton.BackColor = Color.Gray;
    }

    private void TimerButton_Click(object sender, EventArgs e) {
        TimerButton.BackColor = Color.Gray;
        if (TimerButton.Text == BtnTextStart) {
            TimerButton.Text = "&Pause";
            this.Refresh();
            TimerButton.Focus();
        } else if (TimerButton.Text == BtnTextPause) {
            TimerButton.BackColor = Color.Yellow;
            TimerButton.Text = BtnTextResumeStop;
            this.Refresh();
            TimerButton.Focus();
        } else if (TimerButton.Text == BtnTextResumeStop) {
            Confirmation confirmation = new Confirmation();
            var result = confirmation.ShowDialog();

            if (result == DialogResult.OK) {
                TimerButton.BackColor = Color.Green;
                TimerButton.Text = BtnTextPause;
            } else {
                TimerButton.BackColor = Color.Gray;
                TimerButton.Text = BtnTextStart;
            }
            this.Refresh();
            TimerButton.Focus();
        }
    }

    private void OptionsButton_Click(object sender, EventArgs e) {
        MessageBox.Show("Nothing here yet.", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
