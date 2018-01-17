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
            this.DragNDrop_PANEL = new System.Windows.Forms.Panel();
            this.DragNDrop_LABEL = new System.Windows.Forms.Label();
            this.Status_LABEL = new System.Windows.Forms.Label();
            this.DragNDrop_PANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragNDrop_PANEL
            // 
            this.DragNDrop_PANEL.AllowDrop = true;
            this.DragNDrop_PANEL.BackColor = System.Drawing.Color.White;
            this.DragNDrop_PANEL.Controls.Add(this.DragNDrop_LABEL);
            this.DragNDrop_PANEL.Location = new System.Drawing.Point(12, 12);
            this.DragNDrop_PANEL.Name = "DragNDrop_PANEL";
            this.DragNDrop_PANEL.Size = new System.Drawing.Size(392, 152);
            this.DragNDrop_PANEL.TabIndex = 0;
            this.DragNDrop_PANEL.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragNDrop_PANEL_DragDrop);
            this.DragNDrop_PANEL.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragNDrop_PANEL_DragEnter);
            this.DragNDrop_PANEL.DragLeave += new System.EventHandler(this.DragNDrop_PANEL_DragLeave);
            this.DragNDrop_PANEL.Paint += new System.Windows.Forms.PaintEventHandler(this.DragNDrop_PANEL_Paint);
            // 
            // DragNDrop_LABEL
            // 
            this.DragNDrop_LABEL.AutoSize = true;
            this.DragNDrop_LABEL.Location = new System.Drawing.Point(77, 70);
            this.DragNDrop_LABEL.Name = "DragNDrop_LABEL";
            this.DragNDrop_LABEL.Size = new System.Drawing.Size(239, 13);
            this.DragNDrop_LABEL.TabIndex = 0;
            this.DragNDrop_LABEL.Text = "Drag and drop your suspected stub here";
            // 
            // Status_LABEL
            // 
            this.Status_LABEL.AutoSize = true;
            this.Status_LABEL.Location = new System.Drawing.Point(9, 168);
            this.Status_LABEL.Name = "Status_LABEL";
            this.Status_LABEL.Size = new System.Drawing.Size(78, 13);
            this.Status_LABEL.TabIndex = 1;
            this.Status_LABEL.Text = "Status: Idle.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 190);
            this.Controls.Add(this.Status_LABEL);
            this.Controls.Add(this.DragNDrop_PANEL);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anti Logger";
            this.DragNDrop_PANEL.ResumeLayout(false);
            this.DragNDrop_PANEL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DragNDrop_PANEL;
        private System.Windows.Forms.Label DragNDrop_LABEL;
        private System.Windows.Forms.Label Status_LABEL;
    }
}

