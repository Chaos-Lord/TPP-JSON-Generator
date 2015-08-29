namespace TPP_JSON
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
            this.B_Go = new System.Windows.Forms.Button();
            this.PB_Progress = new System.Windows.Forms.ProgressBar();
            this.TB_In = new System.Windows.Forms.TextBox();
            this.B_Open = new System.Windows.Forms.Button();
            this.CalcArceus = new System.Windows.Forms.CheckBox();
            this.FormeName = new System.Windows.Forms.CheckBox();
            this.HPtype = new System.Windows.Forms.CheckBox();
            this.HPpow = new System.Windows.Forms.CheckBox();
            this.ErrorBlock = new System.Windows.Forms.Label();
            this.ReturnPow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // B_Go
            // 
            this.B_Go.Enabled = false;
            this.B_Go.Location = new System.Drawing.Point(338, 12);
            this.B_Go.Name = "B_Go";
            this.B_Go.Size = new System.Drawing.Size(86, 23);
            this.B_Go.TabIndex = 0;
            this.B_Go.Text = "Go!";
            this.B_Go.UseVisualStyleBackColor = true;
            this.B_Go.Click += new System.EventHandler(this.B_Go_Click);
            // 
            // PB_Progress
            // 
            this.PB_Progress.Location = new System.Drawing.Point(12, 46);
            this.PB_Progress.Name = "PB_Progress";
            this.PB_Progress.Size = new System.Drawing.Size(412, 23);
            this.PB_Progress.TabIndex = 1;
            // 
            // TB_In
            // 
            this.TB_In.Location = new System.Drawing.Point(13, 13);
            this.TB_In.Name = "TB_In";
            this.TB_In.ReadOnly = true;
            this.TB_In.Size = new System.Drawing.Size(231, 20);
            this.TB_In.TabIndex = 2;
            this.TB_In.TextChanged += new System.EventHandler(this.TB_In_TextChanged);
            // 
            // B_Open
            // 
            this.B_Open.Location = new System.Drawing.Point(249, 12);
            this.B_Open.Name = "B_Open";
            this.B_Open.Size = new System.Drawing.Size(86, 23);
            this.B_Open.TabIndex = 3;
            this.B_Open.Text = "Open";
            this.B_Open.UseVisualStyleBackColor = true;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // CalcArceus
            // 
            this.CalcArceus.AutoSize = true;
            this.CalcArceus.Checked = true;
            this.CalcArceus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CalcArceus.Location = new System.Drawing.Point(13, 76);
            this.CalcArceus.Name = "CalcArceus";
            this.CalcArceus.Size = new System.Drawing.Size(153, 17);
            this.CalcArceus.TabIndex = 4;
            this.CalcArceus.Text = "Calcualate Arceus Properly";
            this.CalcArceus.UseVisualStyleBackColor = true;
            this.CalcArceus.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormeName
            // 
            this.FormeName.AutoSize = true;
            this.FormeName.Checked = true;
            this.FormeName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FormeName.Location = new System.Drawing.Point(173, 76);
            this.FormeName.Name = "FormeName";
            this.FormeName.Size = new System.Drawing.Size(113, 17);
            this.FormeName.TabIndex = 5;
            this.FormeName.Text = "Use Forme Names";
            this.FormeName.UseVisualStyleBackColor = true;
            // 
            // HPtype
            // 
            this.HPtype.AutoSize = true;
            this.HPtype.Checked = true;
            this.HPtype.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HPtype.Location = new System.Drawing.Point(12, 99);
            this.HPtype.Name = "HPtype";
            this.HPtype.Size = new System.Drawing.Size(153, 17);
            this.HPtype.TabIndex = 6;
            this.HPtype.Text = "Display Hidden Power type";
            this.HPtype.UseVisualStyleBackColor = true;
            // 
            // HPpow
            // 
            this.HPpow.AutoSize = true;
            this.HPpow.Checked = true;
            this.HPpow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HPpow.Location = new System.Drawing.Point(172, 100);
            this.HPpow.Name = "HPpow";
            this.HPpow.Size = new System.Drawing.Size(110, 17);
            this.HPpow.TabIndex = 7;
            this.HPpow.Text = "Display HP power";
            this.HPpow.UseVisualStyleBackColor = true;
            // 
            // ErrorBlock
            // 
            this.ErrorBlock.AutoSize = true;
            this.ErrorBlock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ErrorBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBlock.Location = new System.Drawing.Point(12, 119);
            this.ErrorBlock.MaximumSize = new System.Drawing.Size(400, 40);
            this.ErrorBlock.Name = "ErrorBlock";
            this.ErrorBlock.Size = new System.Drawing.Size(0, 13);
            this.ErrorBlock.TabIndex = 8;
            // 
            // ReturnPow
            // 
            this.ReturnPow.AutoSize = true;
            this.ReturnPow.Checked = true;
            this.ReturnPow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReturnPow.Location = new System.Drawing.Point(289, 99);
            this.ReturnPow.Name = "ReturnPow";
            this.ReturnPow.Size = new System.Drawing.Size(130, 17);
            this.ReturnPow.TabIndex = 9;
            this.ReturnPow.Text = "Show Return/frust BP";
            this.ReturnPow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 166);
            this.Controls.Add(this.ReturnPow);
            this.Controls.Add(this.ErrorBlock);
            this.Controls.Add(this.HPpow);
            this.Controls.Add(this.HPtype);
            this.Controls.Add(this.FormeName);
            this.Controls.Add(this.CalcArceus);
            this.Controls.Add(this.B_Open);
            this.Controls.Add(this.TB_In);
            this.Controls.Add(this.PB_Progress);
            this.Controls.Add(this.B_Go);
            this.Name = "Form1";
            this.Text = "TPP Platinum Save -> JSON Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Go;
        private System.Windows.Forms.ProgressBar PB_Progress;
        private System.Windows.Forms.TextBox TB_In;
        private System.Windows.Forms.Button B_Open;
        private System.Windows.Forms.CheckBox CalcArceus;
        private System.Windows.Forms.CheckBox FormeName;
        private System.Windows.Forms.CheckBox HPtype;
        private System.Windows.Forms.CheckBox HPpow;
        private System.Windows.Forms.Label ErrorBlock;
        private System.Windows.Forms.CheckBox ReturnPow;
    }
}

