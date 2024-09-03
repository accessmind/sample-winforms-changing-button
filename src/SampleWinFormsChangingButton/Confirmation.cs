namespace SampleWinFormsChangingButton;
public partial class Confirmation: Form {
    public Confirmation() {
        InitializeComponent();
    }

    private void ResumeButton_Click(object sender, EventArgs e) {
        Close();
    }

    private void StopButton_Click(object sender, EventArgs e) {
        Close();
    }
}
