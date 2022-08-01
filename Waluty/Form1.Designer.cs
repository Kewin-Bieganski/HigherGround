namespace Waluty
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
            this.lB_isoCurrencies = new System.Windows.Forms.ListBox();
            this.rTB_bidAskOutput = new System.Windows.Forms.RichTextBox();
            this.p_panel = new System.Windows.Forms.Panel();
            this.p_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lB_isoCurrencies
            // 
            this.lB_isoCurrencies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lB_isoCurrencies.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lB_isoCurrencies.FormattingEnabled = true;
            this.lB_isoCurrencies.ItemHeight = 32;
            this.lB_isoCurrencies.Location = new System.Drawing.Point(19, 19);
            this.lB_isoCurrencies.Margin = new System.Windows.Forms.Padding(10);
            this.lB_isoCurrencies.Name = "lB_isoCurrencies";
            this.lB_isoCurrencies.Size = new System.Drawing.Size(112, 164);
            this.lB_isoCurrencies.TabIndex = 0;
            this.lB_isoCurrencies.SelectedIndexChanged += new System.EventHandler(this.lB_isoCurrencies_SelectedIndexChanged);
            // 
            // rTB_bidAskOutput
            // 
            this.rTB_bidAskOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rTB_bidAskOutput.Font = new System.Drawing.Font("Rubik", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTB_bidAskOutput.Location = new System.Drawing.Point(151, 19);
            this.rTB_bidAskOutput.Margin = new System.Windows.Forms.Padding(10);
            this.rTB_bidAskOutput.Name = "rTB_bidAskOutput";
            this.rTB_bidAskOutput.Size = new System.Drawing.Size(502, 164);
            this.rTB_bidAskOutput.TabIndex = 2;
            this.rTB_bidAskOutput.Text = "";
            // 
            // p_panel
            // 
            this.p_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.p_panel.Controls.Add(this.rTB_bidAskOutput);
            this.p_panel.Controls.Add(this.lB_isoCurrencies);
            this.p_panel.Location = new System.Drawing.Point(0, 0);
            this.p_panel.Margin = new System.Windows.Forms.Padding(0);
            this.p_panel.Name = "p_panel";
            this.p_panel.Size = new System.Drawing.Size(678, 209);
            this.p_panel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1421, 810);
            this.Controls.Add(this.p_panel);
            this.Name = "Form1";
            this.Text = "Waluty";
            this.p_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lB_isoCurrencies;
        private RichTextBox rTB_bidAskOutput;
        private Panel p_panel;
    }
}