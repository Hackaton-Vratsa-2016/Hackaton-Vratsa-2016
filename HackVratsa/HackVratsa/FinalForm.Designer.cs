namespace HackVratsa
{
    partial class FinalForm
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
            this.newTestButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newTestButton
            // 
            this.newTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTestButton.Location = new System.Drawing.Point(58, 416);
            this.newTestButton.Name = "newTestButton";
            this.newTestButton.Size = new System.Drawing.Size(350, 60);
            this.newTestButton.TabIndex = 0;
            this.newTestButton.Text = "Нов тест";
            this.newTestButton.UseVisualStyleBackColor = true;
            this.newTestButton.Click += new System.EventHandler(this.newTestButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(544, 416);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(350, 60);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Изход";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // testPoints
            // 
            this.testPoints.AutoSize = true;
            this.testPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testPoints.Location = new System.Drawing.Point(393, 167);
            this.testPoints.Name = "testPoints";
            this.testPoints.Size = new System.Drawing.Size(70, 25);
            this.testPoints.TabIndex = 2;
            this.testPoints.Text = "label1";
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.testPoints);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newTestButton);
            this.Name = "FinalForm";
            this.Text = "FinalForm";
            this.Load += new System.EventHandler(this.FinalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newTestButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label testPoints;
    }
}