namespace Mail_Application
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
            this.subjecttextbox = new System.Windows.Forms.TextBox();
            this.messagetextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addfilebutton = new System.Windows.Forms.Button();
            this.historybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjecttextbox
            // 
            this.subjecttextbox.Location = new System.Drawing.Point(110, 65);
            this.subjecttextbox.Name = "subjecttextbox";
            this.subjecttextbox.Size = new System.Drawing.Size(244, 22);
            this.subjecttextbox.TabIndex = 1;
            this.subjecttextbox.TextChanged += new System.EventHandler(this.subjecttextbox_TextChanged);
            // 
            // messagetextbox
            // 
            this.messagetextbox.Location = new System.Drawing.Point(110, 103);
            this.messagetextbox.Multiline = true;
            this.messagetextbox.Name = "messagetextbox";
            this.messagetextbox.Size = new System.Drawing.Size(244, 123);
            this.messagetextbox.TabIndex = 2;
            this.messagetextbox.TextChanged += new System.EventHandler(this.messagetextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message :";
            // 
            // sendbutton
            // 
            this.sendbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbutton.Location = new System.Drawing.Point(318, 258);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(90, 33);
            this.sendbutton.TabIndex = 4;
            this.sendbutton.Text = "SEND";
            this.sendbutton.UseVisualStyleBackColor = false;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subject : ";
            // 
            // addfilebutton
            // 
            this.addfilebutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addfilebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfilebutton.Location = new System.Drawing.Point(56, 258);
            this.addfilebutton.Name = "addfilebutton";
            this.addfilebutton.Size = new System.Drawing.Size(90, 33);
            this.addfilebutton.TabIndex = 3;
            this.addfilebutton.Text = "ADD FILE";
            this.addfilebutton.UseVisualStyleBackColor = false;
            this.addfilebutton.Click += new System.EventHandler(this.addfilebutton_Click);
            // 
            // historybtn
            // 
            this.historybtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.historybtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historybtn.Location = new System.Drawing.Point(12, 12);
            this.historybtn.Name = "historybtn";
            this.historybtn.Size = new System.Drawing.Size(75, 23);
            this.historybtn.TabIndex = 9;
            this.historybtn.Text = "History";
            this.historybtn.UseVisualStyleBackColor = false;
            this.historybtn.Click += new System.EventHandler(this.historybtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 344);
            this.Controls.Add(this.historybtn);
            this.Controls.Add(this.addfilebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messagetextbox);
            this.Controls.Add(this.subjecttextbox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Local Mail Application ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox subjecttextbox;
        private System.Windows.Forms.TextBox messagetextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addfilebutton;
        private System.Windows.Forms.Button historybtn;
    }
}

