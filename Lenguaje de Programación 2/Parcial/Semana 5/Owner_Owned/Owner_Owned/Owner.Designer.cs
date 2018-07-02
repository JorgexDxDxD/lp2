namespace Owner_Owned
{
    using System.Windows.Forms;
    partial class Owner
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
            this.btnOwned = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOwned
            // 
            this.btnOwned.Location = new System.Drawing.Point(12, 24);
            this.btnOwned.Name = "btnOwned";
            this.btnOwned.Size = new System.Drawing.Size(399, 23);
            this.btnOwned.TabIndex = 0;
            this.btnOwned.Text = "Mostrar Owned";
            this.btnOwned.UseVisualStyleBackColor = true;
            this.btnOwned.Click += new System.EventHandler(this.btnOwned_Click);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 311);
            this.Controls.Add(this.btnOwned);
            this.Name = "Owner";
            this.Text = "Owner";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOwned;
    }
}