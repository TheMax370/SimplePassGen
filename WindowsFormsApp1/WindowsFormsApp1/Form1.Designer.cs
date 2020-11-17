namespace WindowsFormsApp1
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
            this.TextPass = new System.Windows.Forms.Label();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.Btn_ClipBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextPass
            // 
            this.TextPass.AutoSize = true;
            this.TextPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPass.Location = new System.Drawing.Point(52, 33);
            this.TextPass.Name = "TextPass";
            this.TextPass.Size = new System.Drawing.Size(92, 24);
            this.TextPass.TabIndex = 0;
            this.TextPass.Text = "Password";
            this.TextPass.Click += new System.EventHandler(this.TextPass_Click);
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(38, 84);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(127, 28);
            this.Btn_Generate.TabIndex = 1;
            this.Btn_Generate.Text = "Generate Password";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // Btn_ClipBoard
            // 
            this.Btn_ClipBoard.Location = new System.Drawing.Point(38, 135);
            this.Btn_ClipBoard.Name = "Btn_ClipBoard";
            this.Btn_ClipBoard.Size = new System.Drawing.Size(127, 25);
            this.Btn_ClipBoard.TabIndex = 2;
            this.Btn_ClipBoard.Text = "Copy To ClipBoard";
            this.Btn_ClipBoard.UseVisualStyleBackColor = true;
            this.Btn_ClipBoard.Click += new System.EventHandler(this.Btn_ClipBoard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 172);
            this.Controls.Add(this.Btn_ClipBoard);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.TextPass);
            this.Name = "Form1";
            this.Text = "Password Generator!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextPass;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.Button Btn_ClipBoard;
    }
}

