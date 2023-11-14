namespace FrmOpenFile
{
    partial class FrmOpenFileText
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
            this.lvShowText = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShowText
            // 
            this.lvShowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(12, 12);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(345, 182);
            this.lvShowText.TabIndex = 0;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            this.lvShowText.View = System.Windows.Forms.View.List;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpen.Location = new System.Drawing.Point(134, 223);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(83, 30);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FrmOpenFileText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(369, 284);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lvShowText);
            this.Name = "FrmOpenFileText";
            this.Text = "FrmOpenFileText";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpen;
    }
}

