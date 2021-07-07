namespace Similar
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
            this.document1 = new System.Windows.Forms.RichTextBox();
            this.document2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.similar_rs = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.label_rs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // document1
            // 
            this.document1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.document1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.document1.Location = new System.Drawing.Point(28, 44);
            this.document1.Margin = new System.Windows.Forms.Padding(4);
            this.document1.Name = "document1";
            this.document1.ReadOnly = true;
            this.document1.Size = new System.Drawing.Size(817, 476);
            this.document1.TabIndex = 0;
            this.document1.TabStop = false;
            this.document1.Text = "";
            // 
            // document2
            // 
            this.document2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.document2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.document2.Location = new System.Drawing.Point(876, 44);
            this.document2.Margin = new System.Windows.Forms.Padding(4);
            this.document2.Name = "document2";
            this.document2.ReadOnly = true;
            this.document2.Size = new System.Drawing.Size(833, 476);
            this.document2.TabIndex = 1;
            this.document2.TabStop = false;
            this.document2.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 911);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tính độ Tương tự";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 677);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mức độ tương tự ";
            // 
            // similar_rs
            // 
            this.similar_rs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.similar_rs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.similar_rs.Location = new System.Drawing.Point(860, 659);
            this.similar_rs.Margin = new System.Windows.Forms.Padding(4);
            this.similar_rs.Multiline = true;
            this.similar_rs.Name = "similar_rs";
            this.similar_rs.ReadOnly = true;
            this.similar_rs.Size = new System.Drawing.Size(331, 70);
            this.similar_rs.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "(*.txt)|*.txt";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1160, 911);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(416, 82);
            this.button4.TabIndex = 9;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnchitiet
            // 
            this.btnchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchitiet.Location = new System.Drawing.Point(658, 911);
            this.btnchitiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(439, 82);
            this.btnchitiet.TabIndex = 11;
            this.btnchitiet.Text = "Xem chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.button6_Click);
            // 
            // label_rs
            // 
            this.label_rs.AutoSize = true;
            this.label_rs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rs.Location = new System.Drawing.Point(563, 809);
            this.label_rs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_rs.Name = "label_rs";
            this.label_rs.Size = new System.Drawing.Size(26, 37);
            this.label_rs.TabIndex = 12;
            this.label_rs.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1737, 1097);
            this.Controls.Add(this.label_rs);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.similar_rs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.document2);
            this.Controls.Add(this.document1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính độ tương tự văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox document1;
        private System.Windows.Forms.RichTextBox document2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox similar_rs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.Label label_rs;
    }
}

