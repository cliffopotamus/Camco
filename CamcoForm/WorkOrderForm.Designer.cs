namespace CamcoForm
{
    partial class WorkOrderForm
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
            this.comboKit = new System.Windows.Forms.ComboBox();
            this.richTextBoxKits = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboKit
            // 
            this.comboKit.FormattingEnabled = true;
            this.comboKit.Location = new System.Drawing.Point(53, 38);
            this.comboKit.Name = "comboKit";
            this.comboKit.Size = new System.Drawing.Size(215, 21);
            this.comboKit.TabIndex = 0;
            this.comboKit.SelectedIndexChanged += new System.EventHandler(this.comboKit_SelectedIndexChanged);
            // 
            // richTextBoxKits
            // 
            this.richTextBoxKits.Location = new System.Drawing.Point(53, 95);
            this.richTextBoxKits.Name = "richTextBoxKits";
            this.richTextBoxKits.Size = new System.Drawing.Size(685, 334);
            this.richTextBoxKits.TabIndex = 1;
            this.richTextBoxKits.Text = "";
            // 
            // WorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxKits);
            this.Controls.Add(this.comboKit);
            this.Name = "WorkOrderForm";
            this.Text = "WorkOrderForm";
            this.Load += new System.EventHandler(this.WorkOrderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboKit;
        private System.Windows.Forms.RichTextBox richTextBoxKits;
    }
}