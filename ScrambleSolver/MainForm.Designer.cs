namespace ScrambleSolver
{
    partial class WordBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordBuilder));
            this.InputBox = new System.Windows.Forms.TextBox();
            this.MainOutput = new System.Windows.Forms.ListBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.LengthTrackBar = new System.Windows.Forms.TrackBar();
            this.Min = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.SelectedMax = new System.Windows.Forms.Label();
            this.LettersLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalWordCount = new System.Windows.Forms.Label();
            this.OutOfLabel = new System.Windows.Forms.Label();
            this.DiscoveredWordCount = new System.Windows.Forms.Label();
            this.DiscoveredLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(54, 424);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(240, 21);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // MainOutput
            // 
            this.MainOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainOutput.FormattingEnabled = true;
            this.MainOutput.ItemHeight = 20;
            this.MainOutput.Location = new System.Drawing.Point(12, 12);
            this.MainOutput.Name = "MainOutput";
            this.MainOutput.Size = new System.Drawing.Size(286, 304);
            this.MainOutput.TabIndex = 1;
            // 
            // GoButton
            // 
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoButton.Location = new System.Drawing.Point(204, 424);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(94, 21);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Un-Scramble!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Visible = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // LengthTrackBar
            // 
            this.LengthTrackBar.LargeChange = 1;
            this.LengthTrackBar.Location = new System.Drawing.Point(12, 375);
            this.LengthTrackBar.Maximum = 5;
            this.LengthTrackBar.Minimum = 2;
            this.LengthTrackBar.Name = "LengthTrackBar";
            this.LengthTrackBar.RightToLeftLayout = true;
            this.LengthTrackBar.Size = new System.Drawing.Size(286, 45);
            this.LengthTrackBar.TabIndex = 3;
            this.LengthTrackBar.Value = this.LengthTrackBar.Maximum;
            this.LengthTrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(17, 360);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(24, 13);
            this.Min.TabIndex = 4;
            this.Min.Text = "Min";
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(265, 360);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(27, 13);
            this.Max.TabIndex = 5;
            this.Max.Text = "Max";
            // 
            // SelectedMax
            // 
            this.SelectedMax.AutoSize = true;
            this.SelectedMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedMax.Location = new System.Drawing.Point(147, 360);
            this.SelectedMax.Name = "SelectedMax";
            this.SelectedMax.Size = new System.Drawing.Size(15, 13);
            this.SelectedMax.TabIndex = 6;
            this.SelectedMax.Text = "S";
            // 
            // LettersLabel
            // 
            this.LettersLabel.AutoSize = true;
            this.LettersLabel.Location = new System.Drawing.Point(15, 428);
            this.LettersLabel.Name = "LettersLabel";
            this.LettersLabel.Size = new System.Drawing.Size(39, 13);
            this.LettersLabel.TabIndex = 7;
            this.LettersLabel.Text = "Letters";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TotalWordCount);
            this.panel1.Controls.Add(this.OutOfLabel);
            this.panel1.Controls.Add(this.DiscoveredWordCount);
            this.panel1.Controls.Add(this.DiscoveredLabel);
            this.panel1.Location = new System.Drawing.Point(12, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 29);
            this.panel1.TabIndex = 8;
            // 
            // TotalWordCount
            // 
            this.TotalWordCount.AutoSize = true;
            this.TotalWordCount.Location = new System.Drawing.Point(202, 8);
            this.TotalWordCount.Name = "TotalWordCount";
            this.TotalWordCount.Size = new System.Drawing.Size(50, 13);
            this.TotalWordCount.TabIndex = 3;
            this.TotalWordCount.Text = "0 Words!";
            // 
            // OutOfLabel
            // 
            this.OutOfLabel.AutoSize = true;
            this.OutOfLabel.Location = new System.Drawing.Point(166, 8);
            this.OutOfLabel.Name = "OutOfLabel";
            this.OutOfLabel.Size = new System.Drawing.Size(41, 13);
            this.OutOfLabel.TabIndex = 2;
            this.OutOfLabel.Text = "Out Of:";
            // 
            // DiscoveredWordCount
            // 
            this.DiscoveredWordCount.AutoSize = true;
            this.DiscoveredWordCount.Location = new System.Drawing.Point(64, 8);
            this.DiscoveredWordCount.Name = "DiscoveredWordCount";
            this.DiscoveredWordCount.Size = new System.Drawing.Size(50, 13);
            this.DiscoveredWordCount.TabIndex = 1;
            this.DiscoveredWordCount.Text = "0 Words!";
            // 
            // DiscoveredLabel
            // 
            this.DiscoveredLabel.AutoSize = true;
            this.DiscoveredLabel.Location = new System.Drawing.Point(4, 8);
            this.DiscoveredLabel.Name = "DiscoveredLabel";
            this.DiscoveredLabel.Size = new System.Drawing.Size(64, 13);
            this.DiscoveredLabel.TabIndex = 0;
            this.DiscoveredLabel.Text = "Discovered:";
            // 
            // WordBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 459);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.LettersLabel);
            this.Controls.Add(this.SelectedMax);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.LengthTrackBar);
            this.Controls.Add(this.MainOutput);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WordBuilder";
            this.Text = "Un-Scrambler!";
            ((System.ComponentModel.ISupportInitialize)(this.LengthTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.ListBox MainOutput;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TrackBar LengthTrackBar;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label SelectedMax;
        private System.Windows.Forms.Label LettersLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalWordCount;
        private System.Windows.Forms.Label OutOfLabel;
        private System.Windows.Forms.Label DiscoveredWordCount;
        private System.Windows.Forms.Label DiscoveredLabel;
    }
}

