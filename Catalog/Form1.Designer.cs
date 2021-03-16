namespace Catalog
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
            this.components = new System.ComponentModel.Container();
            this.productsLstbx = new System.Windows.Forms.ListBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.removeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsLstbx
            // 
            this.productsLstbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsLstbx.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsLstbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.productsLstbx.FormattingEnabled = true;
            this.productsLstbx.ItemHeight = 30;
            this.productsLstbx.Location = new System.Drawing.Point(12, 45);
            this.productsLstbx.Name = "productsLstbx";
            this.productsLstbx.Size = new System.Drawing.Size(295, 210);
            this.productsLstbx.TabIndex = 0;
            this.productsLstbx.SelectedIndexChanged += new System.EventHandler(this.productsLstbx_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Animated = true;
            this.addBtn.AutoRoundedCorners = true;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderRadius = 23;
            this.addBtn.CheckedState.Parent = this.addBtn;
            this.addBtn.CustomImages.Parent = this.addBtn;
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.Parent = this.addBtn;
            this.addBtn.Location = new System.Drawing.Point(12, 275);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(295, 49);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add Product";
            this.addBtn.UseTransparentBackground = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Animated = true;
            this.editBtn.AutoRoundedCorners = true;
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BorderRadius = 23;
            this.editBtn.CheckedState.Parent = this.editBtn;
            this.editBtn.CustomImages.Parent = this.editBtn;
            this.editBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.HoverState.Parent = this.editBtn;
            this.editBtn.Location = new System.Drawing.Point(12, 330);
            this.editBtn.Name = "editBtn";
            this.editBtn.ShadowDecoration.Parent = this.editBtn;
            this.editBtn.Size = new System.Drawing.Size(295, 49);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit Product";
            this.editBtn.UseTransparentBackground = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Animated = true;
            this.removeBtn.AutoRoundedCorners = true;
            this.removeBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeBtn.BorderRadius = 23;
            this.removeBtn.CheckedState.Parent = this.removeBtn;
            this.removeBtn.CustomImages.Parent = this.removeBtn;
            this.removeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.HoverState.Parent = this.removeBtn;
            this.removeBtn.Location = new System.Drawing.Point(12, 385);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.ShadowDecoration.Parent = this.removeBtn;
            this.removeBtn.Size = new System.Drawing.Size(295, 49);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove Product";
            this.removeBtn.UseTransparentBackground = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Animated = true;
            this.clearBtn.AutoRoundedCorners = true;
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BorderRadius = 23;
            this.clearBtn.CheckedState.Parent = this.clearBtn;
            this.clearBtn.CustomImages.Parent = this.clearBtn;
            this.clearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.HoverState.Parent = this.clearBtn;
            this.clearBtn.Location = new System.Drawing.Point(12, 440);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.Parent = this.clearBtn;
            this.clearBtn.Size = new System.Drawing.Size(295, 49);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear All Products";
            this.clearBtn.UseTransparentBackground = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.Image = global::Catalog.Properties.Resources.indir__4_;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(210, -1);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.ShadowDecoration.Parent = this.guna2CirclePictureBox3;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 7;
            this.guna2CirclePictureBox3.TabStop = false;
            this.guna2CirclePictureBox3.Click += new System.EventHandler(this.guna2CirclePictureBox3_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::Catalog.Properties.Resources.indir__1_;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(247, -1);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 6;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Catalog.Properties.Resources.indir;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(284, -1);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-2, -1);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(326, 504);
            this.guna2GradientPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 502);
            this.ControlBox = false;
            this.Controls.Add(this.guna2CirclePictureBox3);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.productsLstbx);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(325, 502);
            this.MinimumSize = new System.Drawing.Size(325, 502);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productsLstbx;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Button removeBtn;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}

