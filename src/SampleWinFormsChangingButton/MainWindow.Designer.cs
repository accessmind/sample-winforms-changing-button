namespace SampleWinFormsChangingButton;

partial class MainWindow {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        MainPanel = new TableLayoutPanel();
        TimerButton = new Button();
        InfoLabel = new Label();
        OptionsButton = new Button();
        MainPanel.SuspendLayout();
        SuspendLayout();
        // 
        // MainPanel
        // 
        MainPanel.ColumnCount = 2;
        MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        MainPanel.Controls.Add(TimerButton, 0, 1);
        MainPanel.Controls.Add(InfoLabel, 0, 0);
        MainPanel.Controls.Add(OptionsButton, 1, 1);
        MainPanel.Dock = DockStyle.Fill;
        MainPanel.Location = new Point(0, 0);
        MainPanel.Name = "MainPanel";
        MainPanel.RowCount = 2;
        MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        MainPanel.Size = new Size(481, 227);
        MainPanel.TabIndex = 0;
        // 
        // TimerButton
        // 
        TimerButton.BackColor = SystemColors.ControlLight;
        TimerButton.Dock = DockStyle.Fill;
        TimerButton.Location = new Point(3, 116);
        TimerButton.Name = "TimerButton";
        TimerButton.Size = new Size(234, 108);
        TimerButton.TabIndex = 0;
        TimerButton.Text = "&Start";
        TimerButton.UseVisualStyleBackColor = false;
        TimerButton.Click += TimerButton_Click;
        // 
        // InfoLabel
        // 
        InfoLabel.AccessibleRole = AccessibleRole.StaticText;
        InfoLabel.AutoSize = true;
        InfoLabel.BackColor = SystemColors.ControlLight;
        MainPanel.SetColumnSpan(InfoLabel, 2);
        InfoLabel.Dock = DockStyle.Fill;
        InfoLabel.Location = new Point(3, 0);
        InfoLabel.Name = "InfoLabel";
        InfoLabel.Size = new Size(475, 113);
        InfoLabel.TabIndex = 0;
        InfoLabel.Text = "Welcome! Please click Start to launch the stopwatch.";
        // 
        // OptionsButton
        // 
        OptionsButton.BackColor = SystemColors.ControlLight;
        OptionsButton.Dock = DockStyle.Fill;
        OptionsButton.Location = new Point(243, 116);
        OptionsButton.Name = "OptionsButton";
        OptionsButton.Size = new Size(235, 108);
        OptionsButton.TabIndex = 1;
        OptionsButton.Text = "&Options...";
        OptionsButton.UseVisualStyleBackColor = false;
        OptionsButton.Click += OptionsButton_Click;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(481, 227);
        Controls.Add(MainPanel);
        Margin = new Padding(4, 5, 4, 5);
        Name = "MainWindow";
        Text = "Sample Windows Forms Changing Button";
        MainPanel.ResumeLayout(false);
        MainPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel MainPanel;
    private Button TimerButton;
    private Label InfoLabel;
    private Button OptionsButton;
}
