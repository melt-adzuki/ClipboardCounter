namespace ClipboardCounter;

partial class CounterForm
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
        counterLabel = new Label();
        additionModeCheckBox = new CheckBox();
        SuspendLayout();
        // 
        // counterLabel
        // 
        counterLabel.AutoSize = true;
        counterLabel.Dock = DockStyle.Right;
        counterLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        counterLabel.Location = new Point(95, 0);
        counterLabel.Margin = new Padding(0);
        counterLabel.Name = "counterLabel";
        counterLabel.Size = new Size(25, 30);
        counterLabel.TabIndex = 0;
        counterLabel.Text = "0";
        counterLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // additionModeCheckBox
        // 
        additionModeCheckBox.Anchor = AnchorStyles.Left;
        additionModeCheckBox.Appearance = Appearance.Button;
        additionModeCheckBox.CheckAlign = ContentAlignment.MiddleCenter;
        additionModeCheckBox.Location = new Point(3, 3);
        additionModeCheckBox.Margin = new Padding(0);
        additionModeCheckBox.Name = "additionModeCheckBox";
        additionModeCheckBox.Size = new Size(25, 25);
        additionModeCheckBox.TabIndex = 1;
        additionModeCheckBox.Text = "+";
        additionModeCheckBox.TextAlign = ContentAlignment.MiddleCenter;
        additionModeCheckBox.UseVisualStyleBackColor = true;
        // 
        // CounterForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(120, 31);
        Controls.Add(additionModeCheckBox);
        Controls.Add(counterLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CounterForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Counter";
        TopMost = true;
        FormClosed += CounterForm_FormClosed;
        Load += CounterForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label counterLabel;
    private CheckBox additionModeCheckBox;
}