namespace dataCoding
{
    partial class MainForm
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
            this.shenonFanoMessTextBox = new System.Windows.Forms.TextBox();
            this.shenonFanoLabel = new System.Windows.Forms.Label();
            this.shenonFanoMessLabel = new System.Windows.Forms.Label();
            this.shenonFanoCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shenonFanoButton = new System.Windows.Forms.Button();
            this.haphmanButton = new System.Windows.Forms.Button();
            this.haphmanTextBox = new System.Windows.Forms.TextBox();
            this.haphmanCodeTextBox = new System.Windows.Forms.TextBox();
            this.haphmanLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shenonFanoMessTextBox
            // 
            this.shenonFanoMessTextBox.Location = new System.Drawing.Point(40, 60);
            this.shenonFanoMessTextBox.Name = "shenonFanoMessTextBox";
            this.shenonFanoMessTextBox.ReadOnly = true;
            this.shenonFanoMessTextBox.Size = new System.Drawing.Size(99, 20);
            this.shenonFanoMessTextBox.TabIndex = 0;
            this.shenonFanoMessTextBox.Text = "Король";
            this.shenonFanoMessTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shenonFanoLabel
            // 
            this.shenonFanoLabel.AutoSize = true;
            this.shenonFanoLabel.Location = new System.Drawing.Point(174, 9);
            this.shenonFanoLabel.Name = "shenonFanoLabel";
            this.shenonFanoLabel.Size = new System.Drawing.Size(130, 13);
            this.shenonFanoLabel.TabIndex = 1;
            this.shenonFanoLabel.Text = "Алгоритм Шенона-Фано";
            // 
            // shenonFanoMessLabel
            // 
            this.shenonFanoMessLabel.AutoSize = true;
            this.shenonFanoMessLabel.Location = new System.Drawing.Point(42, 34);
            this.shenonFanoMessLabel.Name = "shenonFanoMessLabel";
            this.shenonFanoMessLabel.Size = new System.Drawing.Size(79, 13);
            this.shenonFanoMessLabel.TabIndex = 2;
            this.shenonFanoMessLabel.Text = "Повідомлення";
            // 
            // shenonFanoCodeTextBox
            // 
            this.shenonFanoCodeTextBox.Location = new System.Drawing.Point(177, 60);
            this.shenonFanoCodeTextBox.Name = "shenonFanoCodeTextBox";
            this.shenonFanoCodeTextBox.ReadOnly = true;
            this.shenonFanoCodeTextBox.Size = new System.Drawing.Size(142, 20);
            this.shenonFanoCodeTextBox.TabIndex = 3;
            this.shenonFanoCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кодоване повідомлення";
            // 
            // shenonFanoButton
            // 
            this.shenonFanoButton.Location = new System.Drawing.Point(346, 58);
            this.shenonFanoButton.Name = "shenonFanoButton";
            this.shenonFanoButton.Size = new System.Drawing.Size(102, 22);
            this.shenonFanoButton.TabIndex = 5;
            this.shenonFanoButton.Text = "Кодувати";
            this.shenonFanoButton.UseVisualStyleBackColor = true;
            this.shenonFanoButton.Click += new System.EventHandler(this.shenonFanoButton_Click);
            // 
            // haphmanButton
            // 
            this.haphmanButton.Location = new System.Drawing.Point(346, 116);
            this.haphmanButton.Name = "haphmanButton";
            this.haphmanButton.Size = new System.Drawing.Size(101, 28);
            this.haphmanButton.TabIndex = 6;
            this.haphmanButton.Text = "Кодувати";
            this.haphmanButton.UseVisualStyleBackColor = true;
            this.haphmanButton.Click += new System.EventHandler(this.haphmanButton_Click);
            // 
            // haphmanTextBox
            // 
            this.haphmanTextBox.Location = new System.Drawing.Point(40, 116);
            this.haphmanTextBox.Name = "haphmanTextBox";
            this.haphmanTextBox.ReadOnly = true;
            this.haphmanTextBox.Size = new System.Drawing.Size(99, 20);
            this.haphmanTextBox.TabIndex = 0;
            this.haphmanTextBox.Text = "Король";
            this.haphmanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // haphmanCodeTextBox
            // 
            this.haphmanCodeTextBox.Location = new System.Drawing.Point(177, 116);
            this.haphmanCodeTextBox.Name = "haphmanCodeTextBox";
            this.haphmanCodeTextBox.ReadOnly = true;
            this.haphmanCodeTextBox.Size = new System.Drawing.Size(142, 20);
            this.haphmanCodeTextBox.TabIndex = 3;
            this.haphmanCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // haphmanLabel
            // 
            this.haphmanLabel.AutoSize = true;
            this.haphmanLabel.Location = new System.Drawing.Point(174, 90);
            this.haphmanLabel.Name = "haphmanLabel";
            this.haphmanLabel.Size = new System.Drawing.Size(106, 13);
            this.haphmanLabel.TabIndex = 1;
            this.haphmanLabel.Text = "Алгоритм Хафмана";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 383);
            this.Controls.Add(this.haphmanButton);
            this.Controls.Add(this.shenonFanoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.haphmanCodeTextBox);
            this.Controls.Add(this.shenonFanoCodeTextBox);
            this.Controls.Add(this.shenonFanoMessLabel);
            this.Controls.Add(this.haphmanLabel);
            this.Controls.Add(this.shenonFanoLabel);
            this.Controls.Add(this.haphmanTextBox);
            this.Controls.Add(this.shenonFanoMessTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кодування даних";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shenonFanoMessTextBox;
        private System.Windows.Forms.Label shenonFanoLabel;
        private System.Windows.Forms.Label shenonFanoMessLabel;
        private System.Windows.Forms.TextBox shenonFanoCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shenonFanoButton;
        private System.Windows.Forms.Button haphmanButton;
        private System.Windows.Forms.TextBox haphmanTextBox;
        private System.Windows.Forms.TextBox haphmanCodeTextBox;
        private System.Windows.Forms.Label haphmanLabel;
    }
}