namespace Smart_green_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.main = new System.Windows.Forms.Label();
            this.new_client = new System.Windows.Forms.Button();
            this.old_client = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.AutoSize = true;
            this.main.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.main.Location = new System.Drawing.Point(561, 246);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(0, 51);
            this.main.TabIndex = 0;
            // 
            // new_client
            // 
            this.new_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.new_client.Image = ((System.Drawing.Image)(resources.GetObject("new_client.Image")));
            this.new_client.Location = new System.Drawing.Point(356, 248);
            this.new_client.Name = "new_client";
            this.new_client.Size = new System.Drawing.Size(252, 57);
            this.new_client.TabIndex = 1;
            this.new_client.Text = "יצירת לקוח חדש";
            this.new_client.UseVisualStyleBackColor = true;
            this.new_client.Click += new System.EventHandler(this.new_client_Click);
            // 
            // old_client
            // 
            this.old_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.old_client.Image = ((System.Drawing.Image)(resources.GetObject("old_client.Image")));
            this.old_client.Location = new System.Drawing.Point(356, 348);
            this.old_client.Name = "old_client";
            this.old_client.Size = new System.Drawing.Size(252, 58);
            this.old_client.TabIndex = 2;
            this.old_client.Text = "לקוח קיים";
            this.old_client.UseVisualStyleBackColor = true;
            this.old_client.Click += new System.EventHandler(this.old_client_Click);
            // 
            // client
            // 
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.client.Image = ((System.Drawing.Image)(resources.GetObject("client.Image")));
            this.client.Location = new System.Drawing.Point(356, 441);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(252, 47);
            this.client.TabIndex = 3;
            this.client.Text = "מידע על לקוח";
            this.client.UseVisualStyleBackColor = true;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // home
            // 
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(129, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(718, 213);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home.TabIndex = 4;
            this.home.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(970, 500);
            this.Controls.Add(this.home);
            this.Controls.Add(this.client);
            this.Controls.Add(this.old_client);
            this.Controls.Add(this.new_client);
            this.Controls.Add(this.main);
            this.Name = "Form1";
            this.Text = "Smart green";
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main;
        private System.Windows.Forms.Button new_client;
        private System.Windows.Forms.Button old_client;
        private System.Windows.Forms.Button client;
        private System.Windows.Forms.PictureBox home;
    }
}

