namespace Smart_green_system
{
    partial class client_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client_info));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barcode_info = new System.Windows.Forms.TextBox();
            this.sumbit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.code_label = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shop = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.add_shop = new System.Windows.Forms.Button();
            this.min_shop = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(427, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "מידע על לקוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(797, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = ":הכנס ברקוד";
            // 
            // barcode_info
            // 
            this.barcode_info.Location = new System.Drawing.Point(405, 267);
            this.barcode_info.Multiline = true;
            this.barcode_info.Name = "barcode_info";
            this.barcode_info.Size = new System.Drawing.Size(250, 32);
            this.barcode_info.TabIndex = 3;
            // 
            // sumbit
            // 
            this.sumbit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sumbit.BackgroundImage")));
            this.sumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sumbit.Location = new System.Drawing.Point(405, 329);
            this.sumbit.Name = "sumbit";
            this.sumbit.Size = new System.Drawing.Size(250, 41);
            this.sumbit.TabIndex = 4;
            this.sumbit.Text = "אישור";
            this.sumbit.UseVisualStyleBackColor = true;
            this.sumbit.Click += new System.EventHandler(this.sumbit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(768, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = ":הזדמנויות שימוש";
            // 
            // code_label
            // 
            this.code_label.Location = new System.Drawing.Point(405, 387);
            this.code_label.Multiline = true;
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(250, 32);
            this.code_label.TabIndex = 6;
            this.code_label.TextChanged += new System.EventHandler(this.code_label_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(807, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = ":כמות קניות";
            // 
            // shop
            // 
            this.shop.Location = new System.Drawing.Point(405, 459);
            this.shop.Multiline = true;
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(250, 32);
            this.shop.TabIndex = 8;
            this.shop.TextChanged += new System.EventHandler(this.shop_TextChanged);
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.delete.Location = new System.Drawing.Point(777, 538);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(236, 41);
            this.delete.TabIndex = 9;
            this.delete.Text = "מחק לקוח";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add_shop
            // 
            this.add_shop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_shop.BackgroundImage")));
            this.add_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add_shop.Location = new System.Drawing.Point(419, 538);
            this.add_shop.Name = "add_shop";
            this.add_shop.Size = new System.Drawing.Size(236, 41);
            this.add_shop.TabIndex = 10;
            this.add_shop.Text = "הוסף קנייה";
            this.add_shop.UseVisualStyleBackColor = true;
            this.add_shop.Click += new System.EventHandler(this.add_shop_Click);
            // 
            // min_shop
            // 
            this.min_shop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("min_shop.BackgroundImage")));
            this.min_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.min_shop.Location = new System.Drawing.Point(72, 538);
            this.min_shop.Name = "min_shop";
            this.min_shop.Size = new System.Drawing.Size(236, 41);
            this.min_shop.TabIndex = 11;
            this.min_shop.Text = "הורדת קנייה";
            this.min_shop.UseVisualStyleBackColor = true;
            this.min_shop.Click += new System.EventHandler(this.min_shop_Click);
            // 
            // home
            // 
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(187, -3);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(718, 213);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home.TabIndex = 12;
            this.home.TabStop = false;
            // 
            // client_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1176, 663);
            this.Controls.Add(this.home);
            this.Controls.Add(this.min_shop);
            this.Controls.Add(this.add_shop);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.shop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.code_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumbit);
            this.Controls.Add(this.barcode_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "client_info";
            this.Text = "מידע על לקוח";
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcode_info;
        private System.Windows.Forms.Button sumbit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox code_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shop;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add_shop;
        private System.Windows.Forms.Button min_shop;
        private System.Windows.Forms.PictureBox home;
    }
}