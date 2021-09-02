
namespace UGaeBruv
{
    partial class MainWindow
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
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YesButton.Location = new System.Drawing.Point(12, 237);
            this.YesButton.Name = "YesButton";
            this.YesButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YesButton.Size = new System.Drawing.Size(119, 66);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "ДА";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            this.YesButton.MouseEnter += new System.EventHandler(this.YesButton_MouseEnter);
            this.YesButton.MouseLeave += new System.EventHandler(this.YesButton_MouseLeave);
            // 
            // NoButton
            // 
            this.NoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoButton.Location = new System.Drawing.Point(294, 237);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(119, 66);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "НЕТ";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            this.NoButton.MouseEnter += new System.EventHandler(this.NoButton_MouseEnter);
            this.NoButton.MouseLeave += new System.EventHandler(this.NoButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "В жопу долбишься?";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Name = "MainWindow";
            this.Text = "SIKE";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label label1;
    }
}

