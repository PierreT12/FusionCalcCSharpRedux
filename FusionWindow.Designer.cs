namespace Personal_Project_Redux
{
    partial class FusionWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.ArcanaLbl = new System.Windows.Forms.Label();
            this.LvLLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TableView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameLbl);
            this.groupBox1.Controls.Add(this.ArcanaLbl);
            this.groupBox1.Controls.Add(this.LvLLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1629, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(403, 68);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(121, 32);
            this.NameLbl.TabIndex = 11;
            this.NameLbl.Text = "Persona";
            // 
            // ArcanaLbl
            // 
            this.ArcanaLbl.AutoSize = true;
            this.ArcanaLbl.Location = new System.Drawing.Point(971, 68);
            this.ArcanaLbl.Name = "ArcanaLbl";
            this.ArcanaLbl.Size = new System.Drawing.Size(105, 32);
            this.ArcanaLbl.TabIndex = 10;
            this.ArcanaLbl.Text = "Arcana";
            // 
            // LvLLbl
            // 
            this.LvLLbl.AutoSize = true;
            this.LvLLbl.Location = new System.Drawing.Point(700, 256);
            this.LvLLbl.Name = "LvLLbl";
            this.LvLLbl.Size = new System.Drawing.Size(84, 32);
            this.LvLLbl.TabIndex = 9;
            this.LvLLbl.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Level: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arcana: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Persona:";
            // 
            // TableView
            // 
            this.TableView.Location = new System.Drawing.Point(12, 394);
            this.TableView.Name = "TableView";
            this.TableView.Size = new System.Drawing.Size(1216, 518);
            this.TableView.TabIndex = 1;
            this.TableView.UseCompatibleStateImageBehavior = false;
            // 
            // FusionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 924);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FusionWindow";
            this.Text = "FusionWindow";
            this.Load += new System.EventHandler(this.FusionWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label ArcanaLbl;
        private System.Windows.Forms.Label LvLLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView TableView;
    }
}