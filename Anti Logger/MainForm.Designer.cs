namespace Anti_Logger
{
    partial class MainForm
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
            this.dragPanel = new System.Windows.Forms.Panel();
            this.dragLabel = new System.Windows.Forms.Label();
            this.dragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.AllowDrop = true;
            this.dragPanel.BackColor = System.Drawing.Color.White;
            this.dragPanel.Controls.Add(this.dragLabel);
            this.dragPanel.Location = new System.Drawing.Point(12, 12);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(495, 152);
            this.dragPanel.TabIndex = 0;
            this.dragPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragPanel_DragDrop);
            this.dragPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragPanel_DragEnter);
            this.dragPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dragPanel_Paint);
            // 
            // dragLabel
            // 
            this.dragLabel.AutoSize = true;
            this.dragLabel.Location = new System.Drawing.Point(140, 70);
            this.dragLabel.Name = "dragLabel";
            this.dragLabel.Size = new System.Drawing.Size(239, 13);
            this.dragLabel.TabIndex = 0;
            this.dragLabel.Text = "Drag and drop your suspected stub here";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 176);
            this.Controls.Add(this.dragPanel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anti Logger";
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label dragLabel;
    }
}

