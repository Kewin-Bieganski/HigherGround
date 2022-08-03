namespace BrainfuckCompression
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
            this.rTB_input = new System.Windows.Forms.RichTextBox();
            this.b_compress = new System.Windows.Forms.Button();
            this.b_decompress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rTB_output = new System.Windows.Forms.RichTextBox();
            this.b_read = new System.Windows.Forms.Button();
            this.b_write = new System.Windows.Forms.Button();
            this.oFD_read = new System.Windows.Forms.OpenFileDialog();
            this.sFD_write = new System.Windows.Forms.SaveFileDialog();
            this.p_panel = new System.Windows.Forms.Panel();
            this.p_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTB_input
            // 
            this.rTB_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rTB_input.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTB_input.Location = new System.Drawing.Point(20, 74);
            this.rTB_input.Margin = new System.Windows.Forms.Padding(10);
            this.rTB_input.Name = "rTB_input";
            this.rTB_input.Size = new System.Drawing.Size(592, 432);
            this.rTB_input.TabIndex = 0;
            this.rTB_input.Text = "";
            // 
            // b_compress
            // 
            this.b_compress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_compress.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_compress.Location = new System.Drawing.Point(632, 526);
            this.b_compress.Margin = new System.Windows.Forms.Padding(10);
            this.b_compress.Name = "b_compress";
            this.b_compress.Size = new System.Drawing.Size(284, 43);
            this.b_compress.TabIndex = 1;
            this.b_compress.Text = "Kompresuj";
            this.b_compress.UseVisualStyleBackColor = false;
            this.b_compress.Click += new System.EventHandler(this.b_compress_Click);
            // 
            // b_decompress
            // 
            this.b_decompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_decompress.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_decompress.Location = new System.Drawing.Point(938, 526);
            this.b_decompress.Margin = new System.Windows.Forms.Padding(10);
            this.b_decompress.Name = "b_decompress";
            this.b_decompress.Size = new System.Drawing.Size(284, 43);
            this.b_decompress.TabIndex = 2;
            this.b_decompress.Text = "Dekompresuj";
            this.b_decompress.UseVisualStyleBackColor = false;
            this.b_decompress.Click += new System.EventHandler(this.b_decompress_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(631, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rTB_output
            // 
            this.rTB_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rTB_output.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTB_output.Location = new System.Drawing.Point(632, 74);
            this.rTB_output.Margin = new System.Windows.Forms.Padding(10);
            this.rTB_output.Name = "rTB_output";
            this.rTB_output.ReadOnly = true;
            this.rTB_output.Size = new System.Drawing.Size(592, 432);
            this.rTB_output.TabIndex = 5;
            this.rTB_output.Text = "";
            // 
            // b_read
            // 
            this.b_read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_read.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_read.Location = new System.Drawing.Point(20, 526);
            this.b_read.Margin = new System.Windows.Forms.Padding(10);
            this.b_read.Name = "b_read";
            this.b_read.Size = new System.Drawing.Size(284, 43);
            this.b_read.TabIndex = 8;
            this.b_read.Text = "Wczytaj plik";
            this.b_read.UseVisualStyleBackColor = false;
            this.b_read.Click += new System.EventHandler(this.b_read_Click);
            // 
            // b_write
            // 
            this.b_write.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_write.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_write.Location = new System.Drawing.Point(326, 526);
            this.b_write.Margin = new System.Windows.Forms.Padding(10);
            this.b_write.Name = "b_write";
            this.b_write.Size = new System.Drawing.Size(284, 43);
            this.b_write.TabIndex = 9;
            this.b_write.Text = "Zapisz plik";
            this.b_write.UseVisualStyleBackColor = false;
            this.b_write.Click += new System.EventHandler(this.b_write_Click);
            // 
            // oFD_read
            // 
            this.oFD_read.Title = "Wczytaj plik z kompresją lub kodem Brainfuck";
            // 
            // sFD_write
            // 
            this.sFD_write.Title = "Zapisz plik z kompresją lub kodem Brainfuck";
            // 
            // p_panel
            // 
            this.p_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.p_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.p_panel.Controls.Add(this.rTB_output);
            this.p_panel.Controls.Add(this.label1);
            this.p_panel.Controls.Add(this.rTB_input);
            this.p_panel.Controls.Add(this.b_read);
            this.p_panel.Controls.Add(this.b_write);
            this.p_panel.Controls.Add(this.label2);
            this.p_panel.Controls.Add(this.b_compress);
            this.p_panel.Controls.Add(this.b_decompress);
            this.p_panel.Location = new System.Drawing.Point(0, 0);
            this.p_panel.Margin = new System.Windows.Forms.Padding(0);
            this.p_panel.Name = "p_panel";
            this.p_panel.Padding = new System.Windows.Forms.Padding(10);
            this.p_panel.Size = new System.Drawing.Size(1243, 589);
            this.p_panel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1737, 937);
            this.Controls.Add(this.p_panel);
            this.Name = "Form1";
            this.Text = "Brainfuck Codec";
            this.p_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rTB_input;
        private Button b_compress;
        private Button b_decompress;
        private Label label1;
        private Label label2;
        private RichTextBox rTB_output;
        private Button b_read;
        private Button b_write;
        private OpenFileDialog oFD_read;
        private SaveFileDialog sFD_write;
        private Panel p_panel;
    }
}