namespace Sortowanie
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
            this.b_loadFile = new System.Windows.Forms.Button();
            this.rTB_output = new System.Windows.Forms.RichTextBox();
            this.oFD_load = new System.Windows.Forms.OpenFileDialog();
            this.cB_sortMode = new System.Windows.Forms.ComboBox();
            this.b_sort = new System.Windows.Forms.Button();
            this.p_panel = new System.Windows.Forms.Panel();
            this.gB_sortOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_panel.SuspendLayout();
            this.gB_sortOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_loadFile
            // 
            this.b_loadFile.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_loadFile.Location = new System.Drawing.Point(10, 10);
            this.b_loadFile.Margin = new System.Windows.Forms.Padding(10);
            this.b_loadFile.Name = "b_loadFile";
            this.b_loadFile.Size = new System.Drawing.Size(151, 28);
            this.b_loadFile.TabIndex = 0;
            this.b_loadFile.Text = "Wczytaj plik";
            this.b_loadFile.UseVisualStyleBackColor = true;
            this.b_loadFile.Click += new System.EventHandler(this.b_loadFile_Click);
            // 
            // rTB_output
            // 
            this.rTB_output.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTB_output.Location = new System.Drawing.Point(207, 10);
            this.rTB_output.Margin = new System.Windows.Forms.Padding(10);
            this.rTB_output.Name = "rTB_output";
            this.rTB_output.Size = new System.Drawing.Size(532, 573);
            this.rTB_output.TabIndex = 1;
            this.rTB_output.Text = "";
            // 
            // cB_sortMode
            // 
            this.cB_sortMode.FormattingEnabled = true;
            this.cB_sortMode.Location = new System.Drawing.Point(13, 53);
            this.cB_sortMode.Margin = new System.Windows.Forms.Padding(10);
            this.cB_sortMode.Name = "cB_sortMode";
            this.cB_sortMode.Size = new System.Drawing.Size(151, 28);
            this.cB_sortMode.TabIndex = 2;
            // 
            // b_sort
            // 
            this.b_sort.Location = new System.Drawing.Point(13, 101);
            this.b_sort.Margin = new System.Windows.Forms.Padding(10);
            this.b_sort.Name = "b_sort";
            this.b_sort.Size = new System.Drawing.Size(151, 28);
            this.b_sort.TabIndex = 3;
            this.b_sort.Text = "Sortuj";
            this.b_sort.UseVisualStyleBackColor = true;
            this.b_sort.Click += new System.EventHandler(this.b_sort_Click);
            // 
            // p_panel
            // 
            this.p_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.p_panel.Controls.Add(this.gB_sortOptions);
            this.p_panel.Controls.Add(this.rTB_output);
            this.p_panel.Controls.Add(this.b_loadFile);
            this.p_panel.Location = new System.Drawing.Point(0, 0);
            this.p_panel.Margin = new System.Windows.Forms.Padding(0);
            this.p_panel.Name = "p_panel";
            this.p_panel.Size = new System.Drawing.Size(749, 593);
            this.p_panel.TabIndex = 4;
            // 
            // gB_sortOptions
            // 
            this.gB_sortOptions.AutoSize = true;
            this.gB_sortOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gB_sortOptions.Controls.Add(this.label1);
            this.gB_sortOptions.Controls.Add(this.b_sort);
            this.gB_sortOptions.Controls.Add(this.cB_sortMode);
            this.gB_sortOptions.Enabled = false;
            this.gB_sortOptions.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gB_sortOptions.Location = new System.Drawing.Point(10, 58);
            this.gB_sortOptions.Margin = new System.Windows.Forms.Padding(10);
            this.gB_sortOptions.Name = "gB_sortOptions";
            this.gB_sortOptions.Size = new System.Drawing.Size(177, 163);
            this.gB_sortOptions.TabIndex = 5;
            this.gB_sortOptions.TabStop = false;
            this.gB_sortOptions.Text = "Opcje sortowania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tryb sortowania";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1841, 772);
            this.Controls.Add(this.p_panel);
            this.Name = "Form1";
            this.Text = "Sortowanie zawartości plików";
            this.p_panel.ResumeLayout(false);
            this.p_panel.PerformLayout();
            this.gB_sortOptions.ResumeLayout(false);
            this.gB_sortOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button b_loadFile;
        private RichTextBox rTB_output;
        private OpenFileDialog oFD_load;
        private ComboBox cB_sortMode;
        private Button b_sort;
        private Panel p_panel;
        private GroupBox gB_sortOptions;
        private Label label1;
    }
}