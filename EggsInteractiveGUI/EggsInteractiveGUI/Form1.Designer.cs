namespace EggsInteractiveGUI
{
    partial class lblResult
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
            this.txtEntry1 = new System.Windows.Forms.TextBox();
            this.txtEntry2 = new System.Windows.Forms.TextBox();
            this.txtEntry4 = new System.Windows.Forms.TextBox();
            this.txtEntry3 = new System.Windows.Forms.TextBox();
            this.txtEntry5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCalculate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntry1
            // 
            this.txtEntry1.Location = new System.Drawing.Point(62, 50);
            this.txtEntry1.Name = "txtEntry1";
            this.txtEntry1.Size = new System.Drawing.Size(44, 20);
            this.txtEntry1.TabIndex = 0;
            // 
            // txtEntry2
            // 
            this.txtEntry2.Location = new System.Drawing.Point(142, 50);
            this.txtEntry2.Name = "txtEntry2";
            this.txtEntry2.Size = new System.Drawing.Size(44, 20);
            this.txtEntry2.TabIndex = 1;
            // 
            // txtEntry4
            // 
            this.txtEntry4.Location = new System.Drawing.Point(62, 122);
            this.txtEntry4.Name = "txtEntry4";
            this.txtEntry4.Size = new System.Drawing.Size(44, 20);
            this.txtEntry4.TabIndex = 2;
            // 
            // txtEntry3
            // 
            this.txtEntry3.Location = new System.Drawing.Point(227, 50);
            this.txtEntry3.Name = "txtEntry3";
            this.txtEntry3.Size = new System.Drawing.Size(44, 20);
            this.txtEntry3.TabIndex = 2;
            // 
            // txtEntry5
            // 
            this.txtEntry5.Location = new System.Drawing.Point(142, 122);
            this.txtEntry5.Name = "txtEntry5";
            this.txtEntry5.Size = new System.Drawing.Size(44, 20);
            this.txtEntry5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter eggs produced by each of 5 chickens";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Click to calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCalculate
            // 
            this.lblCalculate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCalculate.Location = new System.Drawing.Point(49, 253);
            this.lblCalculate.Name = "lblCalculate";
            this.lblCalculate.Size = new System.Drawing.Size(250, 23);
            this.lblCalculate.TabIndex = 7;
            // 
            // lblResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 379);
            this.Controls.Add(this.lblCalculate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntry5);
            this.Controls.Add(this.txtEntry3);
            this.Controls.Add(this.txtEntry4);
            this.Controls.Add(this.txtEntry2);
            this.Controls.Add(this.txtEntry1);
            this.Name = "lblResult";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.TextBox txtEntry2;
        private System.Windows.Forms.TextBox txtEntry4;
        private System.Windows.Forms.TextBox txtEntry3;
        private System.Windows.Forms.TextBox txtEntry5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCalculate;
    }
}

