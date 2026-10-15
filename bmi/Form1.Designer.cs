namespace bmi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.RbtnCm = new System.Windows.Forms.RadioButton();
            this.RbtnM = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtnM);
            this.groupBox1.Controls.Add(this.RbtnCm);
            this.groupBox1.Controls.Add(this.TxtHeight);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "身高";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(16, 160);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(79, 23);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Text = "BMI值：";
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(20, 32);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(150, 30);
            this.TxtHeight.TabIndex = 0;
            // 
            // RbtnCm
            // 
            this.RbtnCm.AutoSize = true;
            this.RbtnCm.Location = new System.Drawing.Point(14, 80);
            this.RbtnCm.Name = "RbtnCm";
            this.RbtnCm.Size = new System.Drawing.Size(71, 27);
            this.RbtnCm.TabIndex = 1;
            this.RbtnCm.TabStop = true;
            this.RbtnCm.Text = "公分";
            this.RbtnCm.UseVisualStyleBackColor = true;
            // 
            // RbtnM
            // 
            this.RbtnM.AutoSize = true;
            this.RbtnM.Location = new System.Drawing.Point(90, 80);
            this.RbtnM.Name = "RbtnM";
            this.RbtnM.Size = new System.Drawing.Size(71, 27);
            this.RbtnM.TabIndex = 2;
            this.RbtnM.TabStop = true;
            this.RbtnM.Text = "公尺";
            this.RbtnM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "請輸入體重(公斤)";
            // 
            // TxtWeight
            // 
            this.TxtWeight.Location = new System.Drawing.Point(213, 59);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(150, 30);
            this.TxtWeight.TabIndex = 3;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(228, 104);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(112, 34);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 204);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton RbtnM;
        private RadioButton RbtnCm;
        private TextBox TxtHeight;
        private Label LblMsg;
        private Label label1;
        private TextBox TxtWeight;
        private Button BtnOK;
    }
}