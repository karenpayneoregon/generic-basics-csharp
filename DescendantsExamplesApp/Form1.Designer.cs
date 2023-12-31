namespace DescendantsExamplesApp;

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
        FruitsGroupBox = new GroupBox();
        CherriesRadioutton = new RadioButton();
        OrangesRadioButton = new RadioButton();
        GrapesRadioButton = new RadioButton();
        GetSelectedFruitButton = new Button();
        SelectedFruitTextBox = new TextBox();
        FruitsGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // FruitsGroupBox
        // 
        FruitsGroupBox.Controls.Add(GrapesRadioButton);
        FruitsGroupBox.Controls.Add(OrangesRadioButton);
        FruitsGroupBox.Controls.Add(CherriesRadioutton);
        FruitsGroupBox.Location = new Point(28, 35);
        FruitsGroupBox.Name = "FruitsGroupBox";
        FruitsGroupBox.Size = new Size(250, 125);
        FruitsGroupBox.TabIndex = 0;
        FruitsGroupBox.TabStop = false;
        FruitsGroupBox.Text = "Fruits";
        // 
        // CherriesRadioutton
        // 
        CherriesRadioutton.AutoSize = true;
        CherriesRadioutton.Location = new Point(11, 30);
        CherriesRadioutton.Name = "CherriesRadioutton";
        CherriesRadioutton.Size = new Size(83, 24);
        CherriesRadioutton.TabIndex = 0;
        CherriesRadioutton.TabStop = true;
        CherriesRadioutton.Text = "Cherries";
        CherriesRadioutton.UseVisualStyleBackColor = true;
        // 
        // OrangesRadioButton
        // 
        OrangesRadioButton.AutoSize = true;
        OrangesRadioButton.Location = new Point(11, 60);
        OrangesRadioButton.Name = "OrangesRadioButton";
        OrangesRadioButton.Size = new Size(85, 24);
        OrangesRadioButton.TabIndex = 1;
        OrangesRadioButton.TabStop = true;
        OrangesRadioButton.Text = "Oranges";
        OrangesRadioButton.UseVisualStyleBackColor = true;
        // 
        // GrapesRadioButton
        // 
        GrapesRadioButton.AutoSize = true;
        GrapesRadioButton.Location = new Point(11, 91);
        GrapesRadioButton.Name = "GrapesRadioButton";
        GrapesRadioButton.Size = new Size(76, 24);
        GrapesRadioButton.TabIndex = 2;
        GrapesRadioButton.TabStop = true;
        GrapesRadioButton.Text = "Grapes";
        GrapesRadioButton.UseVisualStyleBackColor = true;
        // 
        // GetSelectedFruitButton
        // 
        GetSelectedFruitButton.Location = new Point(28, 166);
        GetSelectedFruitButton.Name = "GetSelectedFruitButton";
        GetSelectedFruitButton.Size = new Size(250, 29);
        GetSelectedFruitButton.TabIndex = 1;
        GetSelectedFruitButton.Text = "Get selected fruit";
        GetSelectedFruitButton.UseVisualStyleBackColor = true;
        GetSelectedFruitButton.Click += GetSelectedFruitButton_Click;
        // 
        // SelectedFruitTextBox
        // 
        SelectedFruitTextBox.Location = new Point(28, 201);
        SelectedFruitTextBox.Name = "SelectedFruitTextBox";
        SelectedFruitTextBox.Size = new Size(250, 27);
        SelectedFruitTextBox.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(320, 262);
        Controls.Add(SelectedFruitTextBox);
        Controls.Add(GetSelectedFruitButton);
        Controls.Add(FruitsGroupBox);
        FormBorderStyle = FormBorderStyle.SizableToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Descendants";
        FruitsGroupBox.ResumeLayout(false);
        FruitsGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox FruitsGroupBox;
    private RadioButton CherriesRadioutton;
    private RadioButton GrapesRadioButton;
    private RadioButton OrangesRadioButton;
    private Button GetSelectedFruitButton;
    private TextBox SelectedFruitTextBox;
}
