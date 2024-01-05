namespace SerializeSettingsApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        CreateButton = new Button();
        ReadButton = new Button();
        ResultsTextBox = new TextBox();
        SuspendLayout();
        // 
        // CreateButton
        // 
        CreateButton.Location = new Point(26, 26);
        CreateButton.Name = "CreateButton";
        CreateButton.Size = new Size(155, 29);
        CreateButton.TabIndex = 0;
        CreateButton.Text = "Create";
        CreateButton.UseVisualStyleBackColor = true;
        CreateButton.Click += CreateButton_Click;
        // 
        // ReadButton
        // 
        ReadButton.Location = new Point(26, 79);
        ReadButton.Name = "ReadButton";
        ReadButton.Size = new Size(155, 29);
        ReadButton.TabIndex = 1;
        ReadButton.Text = "Read";
        ReadButton.UseVisualStyleBackColor = true;
        ReadButton.Click += ReadButton_Click;
        // 
        // ResultsTextBox
        // 
        ResultsTextBox.Location = new Point(213, 81);
        ResultsTextBox.Multiline = true;
        ResultsTextBox.Name = "ResultsTextBox";
        ResultsTextBox.ScrollBars = ScrollBars.Horizontal;
        ResultsTextBox.Size = new Size(881, 234);
        ResultsTextBox.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1106, 327);
        Controls.Add(ResultsTextBox);
        Controls.Add(ReadButton);
        Controls.Add(CreateButton);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sample";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CreateButton;
    private Button ReadButton;
    private TextBox ResultsTextBox;
}
