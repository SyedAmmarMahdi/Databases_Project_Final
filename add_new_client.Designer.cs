
namespace vet_appointment
{
    partial class add_new_client
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
            System.Windows.Forms.Label client_nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phone_numberLabel;
            this.vet_Appointment_Mnagement_SystemDataSet = new vet_appointment.Vet_Appointment_Mnagement_SystemDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new vet_appointment.Vet_Appointment_Mnagement_SystemDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new vet_appointment.Vet_Appointment_Mnagement_SystemDataSetTableAdapters.TableAdapterManager();
            this.client_nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            client_nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vet_Appointment_Mnagement_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vet_Appointment_Mnagement_SystemDataSet
            // 
            this.vet_Appointment_Mnagement_SystemDataSet.DataSetName = "Vet_Appointment_Mnagement_SystemDataSet";
            this.vet_Appointment_Mnagement_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.vet_Appointment_Mnagement_SystemDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.appointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.client_transactionTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.transaction_has_itemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = vet_appointment.Vet_Appointment_Mnagement_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VetTableAdapter = null;
            // 
            // client_nameLabel
            // 
            client_nameLabel.AutoSize = true;
            client_nameLabel.Location = new System.Drawing.Point(24, 70);
            client_nameLabel.Name = "client_nameLabel";
            client_nameLabel.Size = new System.Drawing.Size(64, 13);
            client_nameLabel.TabIndex = 3;
            client_nameLabel.Text = "client name:";
            // 
            // client_nameTextBox
            // 
            this.client_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "client_name", true));
            this.client_nameTextBox.Location = new System.Drawing.Point(108, 67);
            this.client_nameTextBox.Name = "client_nameTextBox";
            this.client_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.client_nameTextBox.TabIndex = 4;
            this.client_nameTextBox.TextChanged += new System.EventHandler(this.client_nameTextBox_TextChanged);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(24, 96);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(108, 93);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(24, 122);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(108, 119);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(24, 148);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(78, 13);
            phone_numberLabel.TabIndex = 9;
            phone_numberLabel.Text = "phone number:";
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(108, 145);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phone_numberTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_new_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(client_nameLabel);
            this.Controls.Add(this.client_nameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Name = "add_new_client";
            this.Text = "add_new_client";
            //this.Load += new System.EventHandler(this.add_new_client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vet_Appointment_Mnagement_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vet_Appointment_Mnagement_SystemDataSet vet_Appointment_Mnagement_SystemDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Vet_Appointment_Mnagement_SystemDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private Vet_Appointment_Mnagement_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox client_nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}