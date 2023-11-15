namespace Mines
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
            this.tbxSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnInsats = new System.Windows.Forms.Button();
            this.rbtn3x3 = new System.Windows.Forms.RadioButton();
            this.rbtn5x5 = new System.Windows.Forms.RadioButton();
            this.rbtn7x7 = new System.Windows.Forms.RadioButton();
            this.rbtn9x9 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMines = new System.Windows.Forms.Label();
            this.btnMines1 = new System.Windows.Forms.Button();
            this.btnMines2 = new System.Windows.Forms.Button();
            this.btnMines3 = new System.Windows.Forms.Button();
            this.btnMines4 = new System.Windows.Forms.Button();
            this.tbxMinesCustom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInsats = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxSaldo
            // 
            this.tbxSaldo.Location = new System.Drawing.Point(167, 12);
            this.tbxSaldo.Name = "tbxSaldo";
            this.tbxSaldo.Size = new System.Drawing.Size(100, 20);
            this.tbxSaldo.TabIndex = 0;
            this.tbxSaldo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSaldo_KeyDown);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaldo.Location = new System.Drawing.Point(82, 15);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(84, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Skriv Startsaldo:";
            // 
            // btnInsats
            // 
            this.btnInsats.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInsats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsats.Enabled = false;
            this.btnInsats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsats.Location = new System.Drawing.Point(151, 351);
            this.btnInsats.Name = "btnInsats";
            this.btnInsats.Size = new System.Drawing.Size(164, 23);
            this.btnInsats.TabIndex = 2;
            this.btnInsats.Text = "Insats";
            this.btnInsats.UseVisualStyleBackColor = false;
            this.btnInsats.Click += new System.EventHandler(this.btnInsats_Click);
            // 
            // rbtn3x3
            // 
            this.rbtn3x3.AutoSize = true;
            this.rbtn3x3.Enabled = false;
            this.rbtn3x3.Location = new System.Drawing.Point(129, 375);
            this.rbtn3x3.Name = "rbtn3x3";
            this.rbtn3x3.Size = new System.Drawing.Size(42, 17);
            this.rbtn3x3.TabIndex = 3;
            this.rbtn3x3.Text = "3x3";
            this.rbtn3x3.UseVisualStyleBackColor = true;
            this.rbtn3x3.CheckedChanged += new System.EventHandler(this.rbtn3x3_CheckedChanged);
            // 
            // rbtn5x5
            // 
            this.rbtn5x5.AutoSize = true;
            this.rbtn5x5.Enabled = false;
            this.rbtn5x5.Location = new System.Drawing.Point(177, 375);
            this.rbtn5x5.Name = "rbtn5x5";
            this.rbtn5x5.Size = new System.Drawing.Size(42, 17);
            this.rbtn5x5.TabIndex = 4;
            this.rbtn5x5.Text = "5x5";
            this.rbtn5x5.UseVisualStyleBackColor = true;
            this.rbtn5x5.CheckedChanged += new System.EventHandler(this.rbtn5x5_CheckedChanged);
            // 
            // rbtn7x7
            // 
            this.rbtn7x7.AutoSize = true;
            this.rbtn7x7.Checked = true;
            this.rbtn7x7.Enabled = false;
            this.rbtn7x7.Location = new System.Drawing.Point(225, 375);
            this.rbtn7x7.Name = "rbtn7x7";
            this.rbtn7x7.Size = new System.Drawing.Size(42, 17);
            this.rbtn7x7.TabIndex = 5;
            this.rbtn7x7.TabStop = true;
            this.rbtn7x7.Text = "7x7";
            this.rbtn7x7.UseVisualStyleBackColor = true;
            this.rbtn7x7.CheckedChanged += new System.EventHandler(this.rbtn7x7_CheckedChanged);
            // 
            // rbtn9x9
            // 
            this.rbtn9x9.AutoSize = true;
            this.rbtn9x9.Enabled = false;
            this.rbtn9x9.Location = new System.Drawing.Point(273, 375);
            this.rbtn9x9.Name = "rbtn9x9";
            this.rbtn9x9.Size = new System.Drawing.Size(42, 17);
            this.rbtn9x9.TabIndex = 6;
            this.rbtn9x9.Text = "9x9";
            this.rbtn9x9.UseVisualStyleBackColor = true;
            this.rbtn9x9.CheckedChanged += new System.EventHandler(this.rbtn9x9_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Storlek:";
            // 
            // lblMines
            // 
            this.lblMines.AutoSize = true;
            this.lblMines.Location = new System.Drawing.Point(56, 404);
            this.lblMines.Name = "lblMines";
            this.lblMines.Size = new System.Drawing.Size(38, 13);
            this.lblMines.TabIndex = 8;
            this.lblMines.Text = "Mines:";
            // 
            // btnMines1
            // 
            this.btnMines1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMines1.Enabled = false;
            this.btnMines1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMines1.Location = new System.Drawing.Point(100, 401);
            this.btnMines1.Name = "btnMines1";
            this.btnMines1.Size = new System.Drawing.Size(30, 23);
            this.btnMines1.TabIndex = 9;
            this.btnMines1.Text = "1";
            this.btnMines1.UseVisualStyleBackColor = true;
            this.btnMines1.Click += new System.EventHandler(this.btnMines1_Click);
            // 
            // btnMines2
            // 
            this.btnMines2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMines2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMines2.Enabled = false;
            this.btnMines2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMines2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMines2.Location = new System.Drawing.Point(136, 401);
            this.btnMines2.Name = "btnMines2";
            this.btnMines2.Size = new System.Drawing.Size(30, 23);
            this.btnMines2.TabIndex = 10;
            this.btnMines2.Text = "5";
            this.btnMines2.UseVisualStyleBackColor = false;
            this.btnMines2.Click += new System.EventHandler(this.btnMines2_Click);
            // 
            // btnMines3
            // 
            this.btnMines3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMines3.Enabled = false;
            this.btnMines3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMines3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMines3.Location = new System.Drawing.Point(172, 401);
            this.btnMines3.Name = "btnMines3";
            this.btnMines3.Size = new System.Drawing.Size(30, 23);
            this.btnMines3.TabIndex = 11;
            this.btnMines3.Text = "10";
            this.btnMines3.UseVisualStyleBackColor = true;
            this.btnMines3.Click += new System.EventHandler(this.btnMines3_Click);
            // 
            // btnMines4
            // 
            this.btnMines4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMines4.Enabled = false;
            this.btnMines4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMines4.Location = new System.Drawing.Point(208, 401);
            this.btnMines4.Name = "btnMines4";
            this.btnMines4.Size = new System.Drawing.Size(30, 23);
            this.btnMines4.TabIndex = 12;
            this.btnMines4.Text = "15";
            this.btnMines4.UseVisualStyleBackColor = true;
            this.btnMines4.Click += new System.EventHandler(this.btnMines4_Click);
            // 
            // tbxMinesCustom
            // 
            this.tbxMinesCustom.Enabled = false;
            this.tbxMinesCustom.Location = new System.Drawing.Point(291, 403);
            this.tbxMinesCustom.MaxLength = 2;
            this.tbxMinesCustom.Name = "tbxMinesCustom";
            this.tbxMinesCustom.Size = new System.Drawing.Size(42, 20);
            this.tbxMinesCustom.TabIndex = 13;
            this.tbxMinesCustom.TextChanged += new System.EventHandler(this.tbxMinesCustom_TextChanged);
            this.tbxMinesCustom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMinesCustom_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Custom:";
            // 
            // tbxInsats
            // 
            this.tbxInsats.Enabled = false;
            this.tbxInsats.Location = new System.Drawing.Point(80, 353);
            this.tbxInsats.Name = "tbxInsats";
            this.tbxInsats.Size = new System.Drawing.Size(65, 20);
            this.tbxInsats.TabIndex = 15;
            this.tbxInsats.TextChanged += new System.EventHandler(this.tbxInsats_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(389, 440);
            this.Controls.Add(this.tbxInsats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMinesCustom);
            this.Controls.Add(this.btnMines4);
            this.Controls.Add(this.btnMines3);
            this.Controls.Add(this.btnMines2);
            this.Controls.Add(this.btnMines1);
            this.Controls.Add(this.lblMines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn9x9);
            this.Controls.Add(this.rbtn7x7);
            this.Controls.Add(this.rbtn5x5);
            this.Controls.Add(this.rbtn3x3);
            this.Controls.Add(this.btnInsats);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.tbxSaldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnInsats;
        private System.Windows.Forms.RadioButton rbtn3x3;
        private System.Windows.Forms.RadioButton rbtn5x5;
        private System.Windows.Forms.RadioButton rbtn7x7;
        private System.Windows.Forms.RadioButton rbtn9x9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMines;
        private System.Windows.Forms.Button btnMines1;
        private System.Windows.Forms.Button btnMines2;
        private System.Windows.Forms.Button btnMines3;
        private System.Windows.Forms.Button btnMines4;
        private System.Windows.Forms.TextBox tbxMinesCustom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxInsats;
    }
}

