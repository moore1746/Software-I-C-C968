
namespace WGU968
{
    partial class ModifyPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.InHouseButton = new System.Windows.Forms.RadioButton();
            this.OutsourcedButton = new System.Windows.Forms.RadioButton();
            this.IDTextM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NametextM = new System.Windows.Forms.TextBox();
            this.InvTextM = new System.Windows.Forms.TextBox();
            this.PriceTextM = new System.Windows.Forms.TextBox();
            this.MaxTextM = new System.Windows.Forms.TextBox();
            this.minTextM = new System.Windows.Forms.TextBox();
            this.label8textM = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Part";
            // 
            // InHouseButton
            // 
            this.InHouseButton.AutoSize = true;
            this.InHouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseButton.Location = new System.Drawing.Point(131, 78);
            this.InHouseButton.Name = "InHouseButton";
            this.InHouseButton.Size = new System.Drawing.Size(113, 29);
            this.InHouseButton.TabIndex = 1;
            this.InHouseButton.TabStop = true;
            this.InHouseButton.Text = "In-House";
            this.InHouseButton.UseVisualStyleBackColor = true;
            this.InHouseButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OutsourcedButton
            // 
            this.OutsourcedButton.AutoSize = true;
            this.OutsourcedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutsourcedButton.Location = new System.Drawing.Point(299, 78);
            this.OutsourcedButton.Name = "OutsourcedButton";
            this.OutsourcedButton.Size = new System.Drawing.Size(140, 29);
            this.OutsourcedButton.TabIndex = 2;
            this.OutsourcedButton.TabStop = true;
            this.OutsourcedButton.Text = "Outsourced ";
            this.OutsourcedButton.UseVisualStyleBackColor = true;
            this.OutsourcedButton.CheckedChanged += new System.EventHandler(this.OutsourcedButton_CheckedChanged);
            // 
            // IDTextM
            // 
            this.IDTextM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextM.Location = new System.Drawing.Point(287, 148);
            this.IDTextM.Name = "IDTextM";
            this.IDTextM.Size = new System.Drawing.Size(125, 30);
            this.IDTextM.TabIndex = 3;
            this.IDTextM.TextChanged += new System.EventHandler(this.IDTextM_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price / Cost";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            // 
            // NametextM
            // 
            this.NametextM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextM.Location = new System.Drawing.Point(287, 184);
            this.NametextM.Name = "NametextM";
            this.NametextM.Size = new System.Drawing.Size(125, 30);
            this.NametextM.TabIndex = 11;
            this.NametextM.TextChanged += new System.EventHandler(this.NametextM_TextChanged);
            // 
            // InvTextM
            // 
            this.InvTextM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvTextM.Location = new System.Drawing.Point(287, 220);
            this.InvTextM.Name = "InvTextM";
            this.InvTextM.Size = new System.Drawing.Size(125, 30);
            this.InvTextM.TabIndex = 12;
            this.InvTextM.TextChanged += new System.EventHandler(this.InvTextM_TextChanged);
            // 
            // PriceTextM
            // 
            this.PriceTextM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextM.Location = new System.Drawing.Point(287, 256);
            this.PriceTextM.Name = "PriceTextM";
            this.PriceTextM.Size = new System.Drawing.Size(125, 30);
            this.PriceTextM.TabIndex = 13;
            this.PriceTextM.TextChanged += new System.EventHandler(this.PriceTextM_TextChanged);
            // 
            // MaxTextM
            // 
            this.MaxTextM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTextM.Location = new System.Drawing.Point(287, 292);
            this.MaxTextM.Name = "MaxTextM";
            this.MaxTextM.Size = new System.Drawing.Size(125, 30);
            this.MaxTextM.TabIndex = 14;
            this.MaxTextM.TextChanged += new System.EventHandler(this.MaxTextM_TextChanged);
            // 
            // minTextM
            // 
            this.minTextM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextM.Location = new System.Drawing.Point(287, 328);
            this.minTextM.Name = "minTextM";
            this.minTextM.Size = new System.Drawing.Size(125, 30);
            this.minTextM.TabIndex = 15;
            this.minTextM.TextChanged += new System.EventHandler(this.minTextM_TextChanged);
            // 
            // label8textM
            // 
            this.label8textM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8textM.Location = new System.Drawing.Point(287, 364);
            this.label8textM.Name = "label8textM";
            this.label8textM.Size = new System.Drawing.Size(125, 30);
            this.label8textM.TabIndex = 16;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(147, 429);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(76, 40);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(250, 429);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(107, 40);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label8textM);
            this.Controls.Add(this.minTextM);
            this.Controls.Add(this.MaxTextM);
            this.Controls.Add(this.PriceTextM);
            this.Controls.Add(this.InvTextM);
            this.Controls.Add(this.NametextM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDTextM);
            this.Controls.Add(this.OutsourcedButton);
            this.Controls.Add(this.InHouseButton);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPart";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouseButton;
        private System.Windows.Forms.RadioButton OutsourcedButton;
        private System.Windows.Forms.TextBox IDTextM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NametextM;
        private System.Windows.Forms.TextBox InvTextM;
        private System.Windows.Forms.TextBox PriceTextM;
        private System.Windows.Forms.TextBox MaxTextM;
        private System.Windows.Forms.TextBox minTextM;
        private System.Windows.Forms.TextBox label8textM;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}