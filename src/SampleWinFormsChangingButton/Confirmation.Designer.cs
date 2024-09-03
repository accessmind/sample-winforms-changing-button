namespace SampleWinFormsChangingButton;

partial class Confirmation {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        ResumeButton = new Button();
        StopButton = new Button();
        SuspendLayout();
        // 
        // ResumeButton
        // 
        ResumeButton.BackColor = Color.Green;
        ResumeButton.DialogResult = DialogResult.OK;
        ResumeButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ResumeButton.ForeColor = Color.White;
        ResumeButton.Location = new Point(13, 12);
        ResumeButton.Margin = new Padding(4, 5, 4, 5);
        ResumeButton.Name = "ResumeButton";
        ResumeButton.Size = new Size(273, 62);
        ResumeButton.TabIndex = 0;
        ResumeButton.Text = "&Resume";
        ResumeButton.UseVisualStyleBackColor = false;
        ResumeButton.Click += ResumeButton_Click;
        // 
        // StopButton
        // 
        StopButton.BackColor = Color.Gray;
        StopButton.DialogResult = DialogResult.Cancel;
        StopButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        StopButton.ForeColor = Color.Snow;
        StopButton.Location = new Point(13, 90);
        StopButton.Margin = new Padding(4, 5, 4, 5);
        StopButton.Name = "StopButton";
        StopButton.Size = new Size(273, 62);
        StopButton.TabIndex = 1;
        StopButton.Text = "&Stop";
        StopButton.UseVisualStyleBackColor = false;
        StopButton.Click += StopButton_Click;
        // 
        // Confirmation
        // 
        AcceptButton = ResumeButton;
        AccessibleRole = AccessibleRole.Dialog;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = StopButton;
        ClientSize = new Size(306, 172);
        Controls.Add(StopButton);
        Controls.Add(ResumeButton);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4, 5, 4, 5);
        Name = "Confirmation";
        Text = "Resume or Stop?";
        ResumeLayout(false);
    }

    #endregion

    private Button ResumeButton;
    private Button StopButton;
}
