namespace COMP1004_F2016_Lesson12
{
    partial class OpacityForm
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
            this.OpacityScrollBar = new System.Windows.Forms.HScrollBar();
            this.OpacityLabel = new System.Windows.Forms.Label();
            this.OpacityTextBox = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpacityScrollBar
            // 
            this.OpacityScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpacityScrollBar.LargeChange = 1;
            this.OpacityScrollBar.Location = new System.Drawing.Point(30, 149);
            this.OpacityScrollBar.Minimum = 1;
            this.OpacityScrollBar.Name = "OpacityScrollBar";
            this.OpacityScrollBar.Size = new System.Drawing.Size(213, 29);
            this.OpacityScrollBar.TabIndex = 1;
            this.OpacityScrollBar.Value = 100;
            this.OpacityScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OpacityScrollBar_Scroll);
            // 
            // OpacityLabel
            // 
            this.OpacityLabel.AutoSize = true;
            this.OpacityLabel.Location = new System.Drawing.Point(87, 31);
            this.OpacityLabel.Name = "OpacityLabel";
            this.OpacityLabel.Size = new System.Drawing.Size(112, 32);
            this.OpacityLabel.TabIndex = 2;
            this.OpacityLabel.Text = "Opacity";
            // 
            // OpacityTextBox
            // 
            this.OpacityTextBox.Location = new System.Drawing.Point(93, 82);
            this.OpacityTextBox.Name = "OpacityTextBox";
            this.OpacityTextBox.Size = new System.Drawing.Size(90, 38);
            this.OpacityTextBox.TabIndex = 3;
            this.OpacityTextBox.Text = "100";
            this.OpacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OpacityTextBox.TextChanged += new System.EventHandler(this.OpacityTextBox_TextChanged);
            this.OpacityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpacityTextBox_KeyDown);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(186, 213);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(119, 55);
            this.AcceptButton.TabIndex = 4;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(12, 213);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(119, 55);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OpacityForm
            // 
            this.AcceptButton = this.AcceptButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(317, 280);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.OpacityTextBox);
            this.Controls.Add(this.OpacityLabel);
            this.Controls.Add(this.OpacityScrollBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OpacityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opacity Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar OpacityScrollBar;
        private System.Windows.Forms.Label OpacityLabel;
        private System.Windows.Forms.TextBox OpacityTextBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

