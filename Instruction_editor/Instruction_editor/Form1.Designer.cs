namespace Instruction_editor
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.I_MEM = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PGIN = new System.Windows.Forms.Button();
            this.MEM = new System.Windows.Forms.TabPage();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.era = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.cd0 = new System.Windows.Forms.Button();
            this.cd1 = new System.Windows.Forms.Button();
            this.cd2 = new System.Windows.Forms.Button();
            this.cd3 = new System.Windows.Forms.Button();
            this.cd4 = new System.Windows.Forms.Button();
            this.cd5 = new System.Windows.Forms.Button();
            this.cc0 = new System.Windows.Forms.Button();
            this.cc8 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sss = new System.Windows.Forms.Button();
            this.mem_in = new System.Windows.Forms.RichTextBox();
            this.mem_out = new System.Windows.Forms.RichTextBox();
            this.mem_save = new System.Windows.Forms.Button();
            this.save_source_code = new System.Windows.Forms.Button();
            this.row_numb_dispaly = new System.Windows.Forms.RichTextBox();
            this.mem_error = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.I_MEM.SuspendLayout();
            this.MEM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.I_MEM);
            this.tabControl1.Controls.Add(this.MEM);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // I_MEM
            // 
            this.I_MEM.Controls.Add(this.sss);
            this.I_MEM.Controls.Add(this.checkBox1);
            this.I_MEM.Controls.Add(this.cc8);
            this.I_MEM.Controls.Add(this.cc0);
            this.I_MEM.Controls.Add(this.cd5);
            this.I_MEM.Controls.Add(this.cd4);
            this.I_MEM.Controls.Add(this.cd3);
            this.I_MEM.Controls.Add(this.cd2);
            this.I_MEM.Controls.Add(this.cd1);
            this.I_MEM.Controls.Add(this.cd0);
            this.I_MEM.Controls.Add(this.button13);
            this.I_MEM.Controls.Add(this.button12);
            this.I_MEM.Controls.Add(this.button11);
            this.I_MEM.Controls.Add(this.button10);
            this.I_MEM.Controls.Add(this.button9);
            this.I_MEM.Controls.Add(this.button8);
            this.I_MEM.Controls.Add(this.button7);
            this.I_MEM.Controls.Add(this.button6);
            this.I_MEM.Controls.Add(this.button4);
            this.I_MEM.Controls.Add(this.button3);
            this.I_MEM.Controls.Add(this.button1);
            this.I_MEM.Controls.Add(this.era);
            this.I_MEM.Controls.Add(this.label1);
            this.I_MEM.Controls.Add(this.save);
            this.I_MEM.Controls.Add(this.richTextBox2);
            this.I_MEM.Controls.Add(this.richTextBox1);
            this.I_MEM.Controls.Add(this.PGIN);
            this.I_MEM.Location = new System.Drawing.Point(4, 22);
            this.I_MEM.Name = "I_MEM";
            this.I_MEM.Padding = new System.Windows.Forms.Padding(3);
            this.I_MEM.Size = new System.Drawing.Size(869, 425);
            this.I_MEM.TabIndex = 0;
            this.I_MEM.Text = "I_MEM";
            this.I_MEM.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(494, 15);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(287, 364);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(216, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 364);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PGIN
            // 
            this.PGIN.Location = new System.Drawing.Point(13, 13);
            this.PGIN.Name = "PGIN";
            this.PGIN.Size = new System.Drawing.Size(75, 19);
            this.PGIN.TabIndex = 2;
            this.PGIN.Text = "NOP";
            this.PGIN.UseVisualStyleBackColor = true;
            this.PGIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // MEM
            // 
            this.MEM.Controls.Add(this.mem_error);
            this.MEM.Controls.Add(this.row_numb_dispaly);
            this.MEM.Controls.Add(this.save_source_code);
            this.MEM.Controls.Add(this.mem_save);
            this.MEM.Controls.Add(this.mem_out);
            this.MEM.Controls.Add(this.mem_in);
            this.MEM.Location = new System.Drawing.Point(4, 22);
            this.MEM.Name = "MEM";
            this.MEM.Padding = new System.Windows.Forms.Padding(3);
            this.MEM.Size = new System.Drawing.Size(869, 425);
            this.MEM.TabIndex = 1;
            this.MEM.Text = "MEM";
            this.MEM.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(789, 13);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(67, 44);
            this.save.TabIndex = 5;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "行數:";
            // 
            // era
            // 
            this.era.AutoSize = true;
            this.era.Location = new System.Drawing.Point(298, 386);
            this.era.Name = "era";
            this.era.Size = new System.Drawing.Size(38, 12);
            this.era.TabIndex = 7;
            this.era.Text = "error@";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "NOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 19);
            this.button3.TabIndex = 9;
            this.button3.Text = "NOP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 19);
            this.button4.TabIndex = 10;
            this.button4.Text = "NOP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 19);
            this.button6.TabIndex = 12;
            this.button6.Text = "NOP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 138);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 19);
            this.button7.TabIndex = 13;
            this.button7.Text = "NOP";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 163);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 19);
            this.button8.TabIndex = 14;
            this.button8.Text = "NOP";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(13, 188);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 19);
            this.button9.TabIndex = 15;
            this.button9.Text = "NOP";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(13, 213);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 19);
            this.button10.TabIndex = 16;
            this.button10.Text = "NOP";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(13, 238);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 19);
            this.button11.TabIndex = 17;
            this.button11.Text = "NOP";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(13, 263);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 19);
            this.button12.TabIndex = 18;
            this.button12.Text = "NOP";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(13, 288);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 19);
            this.button13.TabIndex = 19;
            this.button13.Text = "NOP";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // cd0
            // 
            this.cd0.Location = new System.Drawing.Point(111, 19);
            this.cd0.Name = "cd0";
            this.cd0.Size = new System.Drawing.Size(70, 29);
            this.cd0.TabIndex = 20;
            this.cd0.Text = "always (0)";
            this.cd0.UseVisualStyleBackColor = true;
            this.cd0.Click += new System.EventHandler(this.cd0_Click);
            // 
            // cd1
            // 
            this.cd1.Location = new System.Drawing.Point(111, 58);
            this.cd1.Name = "cd1";
            this.cd1.Size = new System.Drawing.Size(70, 29);
            this.cd1.TabIndex = 21;
            this.cd1.Text = "carry (1)";
            this.cd1.UseVisualStyleBackColor = true;
            this.cd1.Click += new System.EventHandler(this.cd1_Click);
            // 
            // cd2
            // 
            this.cd2.Location = new System.Drawing.Point(111, 98);
            this.cd2.Name = "cd2";
            this.cd2.Size = new System.Drawing.Size(70, 29);
            this.cd2.TabIndex = 22;
            this.cd2.Text = "even (2)";
            this.cd2.UseVisualStyleBackColor = true;
            this.cd2.Click += new System.EventHandler(this.cd2_Click);
            // 
            // cd3
            // 
            this.cd3.Location = new System.Drawing.Point(111, 137);
            this.cd3.Name = "cd3";
            this.cd3.Size = new System.Drawing.Size(70, 29);
            this.cd3.TabIndex = 23;
            this.cd3.Text = "parity (3)";
            this.cd3.UseVisualStyleBackColor = true;
            this.cd3.Click += new System.EventHandler(this.cd3_Click);
            // 
            // cd4
            // 
            this.cd4.Location = new System.Drawing.Point(111, 176);
            this.cd4.Name = "cd4";
            this.cd4.Size = new System.Drawing.Size(70, 29);
            this.cd4.TabIndex = 24;
            this.cd4.Text = "zero (4)";
            this.cd4.UseVisualStyleBackColor = true;
            this.cd4.Click += new System.EventHandler(this.cd4_Click);
            // 
            // cd5
            // 
            this.cd5.Location = new System.Drawing.Point(111, 214);
            this.cd5.Name = "cd5";
            this.cd5.Size = new System.Drawing.Size(70, 29);
            this.cd5.TabIndex = 25;
            this.cd5.Text = "negative (5)";
            this.cd5.UseVisualStyleBackColor = true;
            this.cd5.Click += new System.EventHandler(this.cd5_Click);
            // 
            // cc0
            // 
            this.cc0.Location = new System.Drawing.Point(111, 263);
            this.cc0.Name = "cc0";
            this.cc0.Size = new System.Drawing.Size(70, 49);
            this.cc0.TabIndex = 26;
            this.cc0.Text = "source type : reg ([27]=0)";
            this.cc0.UseVisualStyleBackColor = true;
            this.cc0.Click += new System.EventHandler(this.cc0_Click);
            // 
            // cc8
            // 
            this.cc8.Location = new System.Drawing.Point(111, 316);
            this.cc8.Name = "cc8";
            this.cc8.Size = new System.Drawing.Size(70, 49);
            this.cc8.TabIndex = 27;
            this.cc8.Text = "source type : imm ([27]=1)";
            this.cc8.UseVisualStyleBackColor = true;
            this.cc8.Click += new System.EventHandler(this.cc8_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 333);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 16);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "auto blank";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // sss
            // 
            this.sss.Location = new System.Drawing.Point(789, 63);
            this.sss.Name = "sss";
            this.sss.Size = new System.Drawing.Size(67, 44);
            this.sss.TabIndex = 29;
            this.sss.Text = "Save source code";
            this.sss.UseVisualStyleBackColor = true;
            this.sss.Click += new System.EventHandler(this.sss_Click);
            // 
            // mem_in
            // 
            this.mem_in.Location = new System.Drawing.Point(194, 14);
            this.mem_in.Name = "mem_in";
            this.mem_in.Size = new System.Drawing.Size(275, 405);
            this.mem_in.TabIndex = 0;
            this.mem_in.Text = "";
            this.mem_in.TextChanged += new System.EventHandler(this.mem_in_TextChanged);
            // 
            // mem_out
            // 
            this.mem_out.Location = new System.Drawing.Point(479, 14);
            this.mem_out.Name = "mem_out";
            this.mem_out.Size = new System.Drawing.Size(275, 405);
            this.mem_out.TabIndex = 1;
            this.mem_out.Text = "";
            // 
            // mem_save
            // 
            this.mem_save.Location = new System.Drawing.Point(771, 22);
            this.mem_save.Name = "mem_save";
            this.mem_save.Size = new System.Drawing.Size(79, 54);
            this.mem_save.TabIndex = 2;
            this.mem_save.Text = "save";
            this.mem_save.UseVisualStyleBackColor = true;
            this.mem_save.Click += new System.EventHandler(this.mem_save_Click);
            // 
            // save_source_code
            // 
            this.save_source_code.Location = new System.Drawing.Point(771, 82);
            this.save_source_code.Name = "save_source_code";
            this.save_source_code.Size = new System.Drawing.Size(79, 54);
            this.save_source_code.TabIndex = 3;
            this.save_source_code.Text = "Save source code";
            this.save_source_code.UseVisualStyleBackColor = true;
            this.save_source_code.Click += new System.EventHandler(this.save_source_code_Click);
            // 
            // row_numb_dispaly
            // 
            this.row_numb_dispaly.Location = new System.Drawing.Point(141, 14);
            this.row_numb_dispaly.Name = "row_numb_dispaly";
            this.row_numb_dispaly.Size = new System.Drawing.Size(46, 405);
            this.row_numb_dispaly.TabIndex = 4;
            this.row_numb_dispaly.Text = "";
            // 
            // mem_error
            // 
            this.mem_error.AutoSize = true;
            this.mem_error.Location = new System.Drawing.Point(15, 17);
            this.mem_error.Name = "mem_error";
            this.mem_error.Size = new System.Drawing.Size(31, 12);
            this.mem_error.TabIndex = 5;
            this.mem_error.Text = "error:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Instruction editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.I_MEM.ResumeLayout(false);
            this.I_MEM.PerformLayout();
            this.MEM.ResumeLayout(false);
            this.MEM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage I_MEM;
        private System.Windows.Forms.TabPage MEM;
        private System.Windows.Forms.Button PGIN;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label era;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button cc8;
        private System.Windows.Forms.Button cc0;
        private System.Windows.Forms.Button cd5;
        private System.Windows.Forms.Button cd4;
        private System.Windows.Forms.Button cd3;
        private System.Windows.Forms.Button cd2;
        private System.Windows.Forms.Button cd1;
        private System.Windows.Forms.Button cd0;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button sss;
        private System.Windows.Forms.RichTextBox row_numb_dispaly;
        private System.Windows.Forms.Button save_source_code;
        private System.Windows.Forms.Button mem_save;
        private System.Windows.Forms.RichTextBox mem_out;
        private System.Windows.Forms.RichTextBox mem_in;
        private System.Windows.Forms.Label mem_error;
    }
}

