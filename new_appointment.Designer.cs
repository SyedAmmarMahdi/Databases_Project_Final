
namespace vet_appointment
{
    partial class new_appointment
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
            this.label2 = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.animal = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Animal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // client
            // 
            this.client.FormattingEnabled = true;
            this.client.Location = new System.Drawing.Point(130, 23);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(158, 21);
            this.client.TabIndex = 8;
            this.client.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animal
            // 
            this.animal.FormattingEnabled = true;
            this.animal.Location = new System.Drawing.Point(129, 59);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(159, 21);
            this.animal.TabIndex = 10;
            this.animal.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // new_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 178);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "new_appointment";
            this.Text = "new_appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox client;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox animal;
        private System.Windows.Forms.Button button2;
    }
}