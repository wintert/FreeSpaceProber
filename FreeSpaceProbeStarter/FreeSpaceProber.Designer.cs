namespace FreeSpaceProbeStarter
{
    partial class FreeSpaceProber
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeTxtBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.destinationTxtBox = new System.Windows.Forms.TextBox();
            this.serviceNotRunLbl = new System.Windows.Forms.Label();
            this.serviceRunLbl = new System.Windows.Forms.Label();
            this.serviceNotExistsLbl = new System.Windows.Forms.Label();
            this.serviceExistsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "שם לקוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 48);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "אי מייל לקוח";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(131, 9);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameTxtBox.Size = new System.Drawing.Size(218, 20);
            this.nameTxtBox.TabIndex = 1;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(131, 45);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(218, 20);
            this.emailTxtBox.TabIndex = 3;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(257, 175);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(92, 23);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "הפעלת שירות";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(131, 175);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(94, 23);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "הפסקת שירות";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 119);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "מינימום שטח פנוי להתראה";
            // 
            // sizeTxtBox
            // 
            this.sizeTxtBox.Location = new System.Drawing.Point(304, 116);
            this.sizeTxtBox.Name = "sizeTxtBox";
            this.sizeTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sizeTxtBox.Size = new System.Drawing.Size(45, 20);
            this.sizeTxtBox.TabIndex = 7;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(131, 114);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 23);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "עדכון נתונים";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 82);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "כתובת אי מייל יעד";
            // 
            // destinationTxtBox
            // 
            this.destinationTxtBox.Location = new System.Drawing.Point(131, 79);
            this.destinationTxtBox.Name = "destinationTxtBox";
            this.destinationTxtBox.Size = new System.Drawing.Size(218, 20);
            this.destinationTxtBox.TabIndex = 5;
            // 
            // serviceNotRunLbl
            // 
            this.serviceNotRunLbl.AutoSize = true;
            this.serviceNotRunLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNotRunLbl.ForeColor = System.Drawing.Color.Red;
            this.serviceNotRunLbl.Location = new System.Drawing.Point(108, 251);
            this.serviceNotRunLbl.Name = "serviceNotRunLbl";
            this.serviceNotRunLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serviceNotRunLbl.Size = new System.Drawing.Size(120, 13);
            this.serviceNotRunLbl.TabIndex = 13;
            this.serviceNotRunLbl.Text = "שירות לא רץ ברקע";
            this.serviceNotRunLbl.Visible = false;
            // 
            // serviceRunLbl
            // 
            this.serviceRunLbl.AutoSize = true;
            this.serviceRunLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceRunLbl.ForeColor = System.Drawing.Color.Green;
            this.serviceRunLbl.Location = new System.Drawing.Point(253, 251);
            this.serviceRunLbl.Name = "serviceRunLbl";
            this.serviceRunLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serviceRunLbl.Size = new System.Drawing.Size(99, 13);
            this.serviceRunLbl.TabIndex = 14;
            this.serviceRunLbl.Text = "שירות רץ ברקע";
            this.serviceRunLbl.Visible = false;
            // 
            // serviceNotExistsLbl
            // 
            this.serviceNotExistsLbl.AutoSize = true;
            this.serviceNotExistsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNotExistsLbl.ForeColor = System.Drawing.Color.Red;
            this.serviceNotExistsLbl.Location = new System.Drawing.Point(123, 217);
            this.serviceNotExistsLbl.Name = "serviceNotExistsLbl";
            this.serviceNotExistsLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serviceNotExistsLbl.Size = new System.Drawing.Size(105, 13);
            this.serviceNotExistsLbl.TabIndex = 15;
            this.serviceNotExistsLbl.Text = "שירות לא מותקן";
            this.serviceNotExistsLbl.Visible = false;
            // 
            // serviceExistsLbl
            // 
            this.serviceExistsLbl.AutoSize = true;
            this.serviceExistsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceExistsLbl.ForeColor = System.Drawing.Color.Green;
            this.serviceExistsLbl.Location = new System.Drawing.Point(268, 217);
            this.serviceExistsLbl.Name = "serviceExistsLbl";
            this.serviceExistsLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serviceExistsLbl.Size = new System.Drawing.Size(84, 13);
            this.serviceExistsLbl.TabIndex = 16;
            this.serviceExistsLbl.Text = "שירות מותקן";
            this.serviceExistsLbl.Visible = false;
            // 
            // FreeSpaceProber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 291);
            this.Controls.Add(this.serviceExistsLbl);
            this.Controls.Add(this.serviceNotExistsLbl);
            this.Controls.Add(this.serviceRunLbl);
            this.Controls.Add(this.serviceNotRunLbl);
            this.Controls.Add(this.destinationTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.sizeTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FreeSpaceProber";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sizeTxtBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox destinationTxtBox;
        private System.Windows.Forms.Label serviceNotRunLbl;
        private System.Windows.Forms.Label serviceRunLbl;
        private System.Windows.Forms.Label serviceNotExistsLbl;
        private System.Windows.Forms.Label serviceExistsLbl;
    }
}

