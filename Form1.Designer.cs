namespace Personal_Project_Redux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.fuseBtn = new System.Windows.Forms.Button();
            this.ffBtn = new System.Windows.Forms.Button();
            this.personaBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.StatsBox = new System.Windows.Forms.ListView();
            this.magicBox = new System.Windows.Forms.ListView();
            this.Elemental = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LvLLbl = new System.Windows.Forms.Label();
            this.ArcanaLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("displayBox.ErrorImage")));
            this.displayBox.InitialImage = null;
            this.displayBox.Location = new System.Drawing.Point(501, 42);
            this.displayBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(851, 744);
            this.displayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayBox.TabIndex = 3;
            this.displayBox.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchBox.Location = new System.Drawing.Point(40, 32);
            this.searchBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(416, 38);
            this.searchBox.TabIndex = 4;
            // 
            // fuseBtn
            // 
            this.fuseBtn.Location = new System.Drawing.Point(1531, 185);
            this.fuseBtn.Name = "fuseBtn";
            this.fuseBtn.Size = new System.Drawing.Size(170, 73);
            this.fuseBtn.TabIndex = 5;
            this.fuseBtn.Text = "Fuse This";
            this.fuseBtn.UseVisualStyleBackColor = true;
            // 
            // ffBtn
            // 
            this.ffBtn.Location = new System.Drawing.Point(1531, 379);
            this.ffBtn.Name = "ffBtn";
            this.ffBtn.Size = new System.Drawing.Size(170, 73);
            this.ffBtn.TabIndex = 6;
            this.ffBtn.Text = "Forward Fuse This";
            this.ffBtn.UseVisualStyleBackColor = true;
            // 
            // personaBox
            // 
            this.personaBox.FormattingEnabled = true;
            this.personaBox.ItemHeight = 31;
            this.personaBox.Location = new System.Drawing.Point(40, 179);
            this.personaBox.Name = "personaBox";
            this.personaBox.Size = new System.Drawing.Size(416, 1089);
            this.personaBox.TabIndex = 7;
            this.personaBox.SelectedIndexChanged += new System.EventHandler(this.personaBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(416, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // StatsBox
            // 
            this.StatsBox.BackColor = System.Drawing.Color.White;
            this.StatsBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatsBox.HideSelection = false;
            this.StatsBox.Location = new System.Drawing.Point(535, 836);
            this.StatsBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StatsBox.Name = "StatsBox";
            this.StatsBox.Size = new System.Drawing.Size(335, 479);
            this.StatsBox.TabIndex = 12;
            this.StatsBox.UseCompatibleStateImageBehavior = false;
            // 
            // magicBox
            // 
            this.magicBox.BackColor = System.Drawing.Color.White;
            this.magicBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.magicBox.HideSelection = false;
            this.magicBox.Location = new System.Drawing.Point(967, 836);
            this.magicBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.magicBox.Name = "magicBox";
            this.magicBox.Size = new System.Drawing.Size(335, 479);
            this.magicBox.TabIndex = 13;
            this.magicBox.UseCompatibleStateImageBehavior = false;
            // 
            // Elemental
            // 
            this.Elemental.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Elemental.ImageStream")));
            this.Elemental.TransparentColor = System.Drawing.Color.Transparent;
            this.Elemental.Images.SetKeyName(0, "Melee_Icon_P5.png");
            this.Elemental.Images.SetKeyName(1, "Ranged_Icon_P5.png");
            this.Elemental.Images.SetKeyName(2, "Fire_Icon_P5.png");
            this.Elemental.Images.SetKeyName(3, "Ice_Icon_P5.png");
            this.Elemental.Images.SetKeyName(4, "Elec_Icon_P5.png");
            this.Elemental.Images.SetKeyName(5, "Wind_Icon_P5.png");
            this.Elemental.Images.SetKeyName(6, "Nuclear_Icon_P5.png");
            this.Elemental.Images.SetKeyName(7, "Psy_Icon_P5.png");
            this.Elemental.Images.SetKeyName(8, "Light_Icon_P5.png");
            this.Elemental.Images.SetKeyName(9, "Dark_Icon_P5.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameLbl);
            this.groupBox1.Controls.Add(this.ArcanaLbl);
            this.groupBox1.Controls.Add(this.LvLLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1427, 836);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 448);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arcana: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level: ";
            // 
            // LvLLbl
            // 
            this.LvLLbl.AutoSize = true;
            this.LvLLbl.Location = new System.Drawing.Point(174, 363);
            this.LvLLbl.Name = "LvLLbl";
            this.LvLLbl.Size = new System.Drawing.Size(84, 32);
            this.LvLLbl.TabIndex = 3;
            this.LvLLbl.Text = "Level";
            // 
            // ArcanaLbl
            // 
            this.ArcanaLbl.AutoSize = true;
            this.ArcanaLbl.Location = new System.Drawing.Point(171, 192);
            this.ArcanaLbl.Name = "ArcanaLbl";
            this.ArcanaLbl.Size = new System.Drawing.Size(105, 32);
            this.ArcanaLbl.TabIndex = 4;
            this.ArcanaLbl.Text = "Arcana";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(174, 74);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(121, 32);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Persona";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.magicBox);
            this.Controls.Add(this.StatsBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.personaBox);
            this.Controls.Add(this.ffBtn);
            this.Controls.Add(this.fuseBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.displayBox);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button fuseBtn;
        private System.Windows.Forms.Button ffBtn;
        private System.Windows.Forms.ListBox personaBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView StatsBox;
        private System.Windows.Forms.ListView magicBox;
        private System.Windows.Forms.ImageList Elemental;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label ArcanaLbl;
        private System.Windows.Forms.Label LvLLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

