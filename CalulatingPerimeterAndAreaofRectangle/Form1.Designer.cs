namespace CalulatingPerimeterAndAreaofRectangle
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
            this.tboxLine1 = new System.Windows.Forms.TextBox();
            this.tboxLine2 = new System.Windows.Forms.TextBox();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxLine1
            // 
            this.tboxLine1.Location = new System.Drawing.Point(80, 50);
            this.tboxLine1.Name = "tboxLine1";
            this.tboxLine1.Size = new System.Drawing.Size(100, 20);
            this.tboxLine1.TabIndex = 0;
            this.tboxLine1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tboxLine2
            // 
            this.tboxLine2.Location = new System.Drawing.Point(80, 86);
            this.tboxLine2.Name = "tboxLine2";
            this.tboxLine2.Size = new System.Drawing.Size(100, 20);
            this.tboxLine2.TabIndex = 1;
            this.tboxLine2.TextChanged += new System.EventHandler(this.tboxLine2_TextChanged);
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Location = new System.Drawing.Point(226, 46);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(79, 27);
            this.btnPerimeter.TabIndex = 2;
            this.btnPerimeter.Text = "Perimeter";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Line 2:";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(226, 82);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(79, 27);
            this.btnArea.TabIndex = 5;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 166);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPerimeter);
            this.Controls.Add(this.tboxLine2);
            this.Controls.Add(this.tboxLine1);
            this.Name = "Form1";
            this.Text = "Area and Periemeter of Rectangle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxLine1;
        private System.Windows.Forms.TextBox tboxLine2;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArea;
    }
}

