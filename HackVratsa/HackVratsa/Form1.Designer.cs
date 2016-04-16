namespace HackVratsa
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
            this.label1 = new System.Windows.Forms.Label();
            this.FourGradeButton = new System.Windows.Forms.Button();
            this.sevenGradeButton = new System.Windows.Forms.Button();
            this.TwelveGradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Моля изберете клас";
            // 
            // FourGradeButton
            // 
            this.FourGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourGradeButton.Location = new System.Drawing.Point(80, 134);
            this.FourGradeButton.Name = "FourGradeButton";
            this.FourGradeButton.Size = new System.Drawing.Size(246, 124);
            this.FourGradeButton.TabIndex = 1;
            this.FourGradeButton.Text = "Четвърти клас";
            this.FourGradeButton.UseVisualStyleBackColor = true;
            this.FourGradeButton.Click += new System.EventHandler(this.FourGradeButton_Click);
            // 
            // sevenGradeButton
            // 
            this.sevenGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenGradeButton.Location = new System.Drawing.Point(342, 134);
            this.sevenGradeButton.Name = "sevenGradeButton";
            this.sevenGradeButton.Size = new System.Drawing.Size(189, 123);
            this.sevenGradeButton.TabIndex = 2;
            this.sevenGradeButton.Text = "Седми клас";
            this.sevenGradeButton.UseVisualStyleBackColor = true;
            this.sevenGradeButton.Click += new System.EventHandler(this.sevenGradeButton_Click);
            // 
            // TwelveGradeButton
            // 
            this.TwelveGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwelveGradeButton.Location = new System.Drawing.Point(565, 134);
            this.TwelveGradeButton.Name = "TwelveGradeButton";
            this.TwelveGradeButton.Size = new System.Drawing.Size(334, 123);
            this.TwelveGradeButton.TabIndex = 3;
            this.TwelveGradeButton.Text = "Дванадесети клас";
            this.TwelveGradeButton.UseVisualStyleBackColor = true;
            this.TwelveGradeButton.Click += new System.EventHandler(this.TwelveGradeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.TwelveGradeButton);
            this.Controls.Add(this.sevenGradeButton);
            this.Controls.Add(this.FourGradeButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HackVratsa-Maturi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FourGradeButton;
        private System.Windows.Forms.Button sevenGradeButton;
        private System.Windows.Forms.Button TwelveGradeButton;
    }
}

