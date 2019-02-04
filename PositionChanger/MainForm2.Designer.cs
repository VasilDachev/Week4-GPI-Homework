namespace PositionChanger
{
    partial class MainForm2
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
            this.lbResult = new System.Windows.Forms.ListBox();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 19;
            this.lbResult.Location = new System.Drawing.Point(12, 76);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(211, 232);
            this.lbResult.TabIndex = 0;
            this.lbResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbResult_KeyDown);
            // 
            // tbEnter
            // 
            this.tbEnter.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnter.Location = new System.Drawing.Point(12, 32);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(211, 27);
            this.tbEnter.TabIndex = 1;
            this.tbEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEnter_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter text here:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(10, 10);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = ".";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTop
            // 
            this.btnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.Location = new System.Drawing.Point(229, 76);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(33, 53);
            this.btnTop.TabIndex = 4;
            this.btnTop.Text = "︿\r\n︿";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnUP
            // 
            this.btnUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUP.Location = new System.Drawing.Point(229, 135);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(33, 53);
            this.btnUP.TabIndex = 4;
            this.btnUP.Text = "︿";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDown.Location = new System.Drawing.Point(229, 196);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(33, 53);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "﹀";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBottom.Location = new System.Drawing.Point(229, 255);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(33, 53);
            this.btnBottom.TabIndex = 4;
            this.btnBottom.Text = "﹀\r\n﹀";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(136, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(10, 10);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = ".";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 499);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.lbResult);
            this.Name = "MainForm2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.TextBox tbEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnDelete;
    }
}

