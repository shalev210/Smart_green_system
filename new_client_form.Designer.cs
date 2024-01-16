namespace Smart_green_system
{
    partial class new_client_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_client_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Display_Qrcodr = new System.Windows.Forms.TextBox();
            this.add_new_client_button = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(355, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "לקוח חדש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(619, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = ":הכנס ברקוד";
            // 
            // Display_Qrcodr
            // 
            this.Display_Qrcodr.Location = new System.Drawing.Point(297, 327);
            this.Display_Qrcodr.Multiline = true;
            this.Display_Qrcodr.Name = "Display_Qrcodr";
            this.Display_Qrcodr.Size = new System.Drawing.Size(256, 36);
            this.Display_Qrcodr.TabIndex = 2;
            // 
            // add_new_client_button
            // 
            this.add_new_client_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_new_client_button.BackgroundImage")));
            this.add_new_client_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add_new_client_button.Location = new System.Drawing.Point(329, 382);
            this.add_new_client_button.Name = "add_new_client_button";
            this.add_new_client_button.Size = new System.Drawing.Size(200, 41);
            this.add_new_client_button.TabIndex = 3;
            this.add_new_client_button.Text = "הוסף";
            this.add_new_client_button.UseVisualStyleBackColor = true;
            this.add_new_client_button.Click += new System.EventHandler(this.add_new_client_button_Click);
            // 
            // home
            // 
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(44, 10);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(718, 213);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home.TabIndex = 5;
            this.home.TabStop = false;
            // 
            // new_client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.home);
            this.Controls.Add(this.add_new_client_button);
            this.Controls.Add(this.Display_Qrcodr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "new_client_form";
            this.Text = "new_client_form";
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Display_Qrcodr;
        private System.Windows.Forms.Button add_new_client_button;
        private System.Windows.Forms.PictureBox home;
    }
}