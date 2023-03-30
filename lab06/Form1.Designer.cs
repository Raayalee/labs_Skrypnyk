namespace lab06
{
    partial class Form1
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
            this.firstNumbertextBox = new System.Windows.Forms.TextBox();
            this.secondNumbertextBox = new System.Windows.Forms.TextBox();
            this.sumNumbertextBox = new System.Windows.Forms.TextBox();
            this.plusbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumbertextBox
            // 
            this.firstNumbertextBox.Location = new System.Drawing.Point(33, 48);
            this.firstNumbertextBox.Name = "firstNumbertextBox";
            this.firstNumbertextBox.Size = new System.Drawing.Size(649, 34);
            this.firstNumbertextBox.TabIndex = 0;
            // 
            // secondNumbertextBox
            // 
            this.secondNumbertextBox.Location = new System.Drawing.Point(33, 88);
            this.secondNumbertextBox.Name = "secondNumbertextBox";
            this.secondNumbertextBox.Size = new System.Drawing.Size(649, 34);
            this.secondNumbertextBox.TabIndex = 1;
            // 
            // sumNumbertextBox
            // 
            this.sumNumbertextBox.Location = new System.Drawing.Point(33, 184);
            this.sumNumbertextBox.Name = "sumNumbertextBox";
            this.sumNumbertextBox.Size = new System.Drawing.Size(649, 34);
            this.sumNumbertextBox.TabIndex = 2;
            // 
            // plusbutton
            // 
            this.plusbutton.Location = new System.Drawing.Point(253, 128);
            this.plusbutton.Name = "plusbutton";
            this.plusbutton.Size = new System.Drawing.Size(185, 50);
            this.plusbutton.TabIndex = 3;
            this.plusbutton.Text = "+";
            this.plusbutton.UseVisualStyleBackColor = true;
            this.plusbutton.Click += new System.EventHandler(this.plusbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(33, 224);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(185, 50);
            this.clearbutton.TabIndex = 4;
            this.clearbutton.Text = "Очистити";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(497, 224);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(185, 50);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "Вихід";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 338);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.plusbutton);
            this.Controls.Add(this.sumNumbertextBox);
            this.Controls.Add(this.secondNumbertextBox);
            this.Controls.Add(this.firstNumbertextBox);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "lab06: Довга сума";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumbertextBox;
        private System.Windows.Forms.TextBox secondNumbertextBox;
        private System.Windows.Forms.TextBox sumNumbertextBox;
        private System.Windows.Forms.Button plusbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

