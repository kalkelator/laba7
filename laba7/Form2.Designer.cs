
namespace laba7
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.linkLabel_RC2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_TriplDES = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DES = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Rijndael = new System.Windows.Forms.LinkLabel();
            this.linkLabel_AES = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel_RC2
            // 
            this.linkLabel_RC2.AutoSize = true;
            this.linkLabel_RC2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_RC2.Location = new System.Drawing.Point(119, 97);
            this.linkLabel_RC2.Name = "linkLabel_RC2";
            this.linkLabel_RC2.Size = new System.Drawing.Size(38, 19);
            this.linkLabel_RC2.TabIndex = 21;
            this.linkLabel_RC2.TabStop = true;
            this.linkLabel_RC2.Text = "RC2";
            this.linkLabel_RC2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_RC2_LinkClicked);
            // 
            // linkLabel_TriplDES
            // 
            this.linkLabel_TriplDES.AutoSize = true;
            this.linkLabel_TriplDES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_TriplDES.Location = new System.Drawing.Point(149, 130);
            this.linkLabel_TriplDES.Name = "linkLabel_TriplDES";
            this.linkLabel_TriplDES.Size = new System.Drawing.Size(65, 19);
            this.linkLabel_TriplDES.TabIndex = 20;
            this.linkLabel_TriplDES.TabStop = true;
            this.linkLabel_TriplDES.Text = "TriplDES";
            this.linkLabel_TriplDES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_TriplDES_LinkClicked);
            // 
            // linkLabel_DES
            // 
            this.linkLabel_DES.AutoSize = true;
            this.linkLabel_DES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_DES.Location = new System.Drawing.Point(176, 97);
            this.linkLabel_DES.Name = "linkLabel_DES";
            this.linkLabel_DES.Size = new System.Drawing.Size(38, 19);
            this.linkLabel_DES.TabIndex = 19;
            this.linkLabel_DES.TabStop = true;
            this.linkLabel_DES.Text = "DES";
            this.linkLabel_DES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DES_LinkClicked);
            // 
            // linkLabel_Rijndael
            // 
            this.linkLabel_Rijndael.AutoSize = true;
            this.linkLabel_Rijndael.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_Rijndael.Location = new System.Drawing.Point(51, 130);
            this.linkLabel_Rijndael.Name = "linkLabel_Rijndael";
            this.linkLabel_Rijndael.Size = new System.Drawing.Size(58, 19);
            this.linkLabel_Rijndael.TabIndex = 18;
            this.linkLabel_Rijndael.TabStop = true;
            this.linkLabel_Rijndael.Text = "Rijndael";
            this.linkLabel_Rijndael.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Rijndael_LinkClicked);
            // 
            // linkLabel_AES
            // 
            this.linkLabel_AES.AutoSize = true;
            this.linkLabel_AES.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_AES.Location = new System.Drawing.Point(51, 97);
            this.linkLabel_AES.Name = "linkLabel_AES";
            this.linkLabel_AES.Size = new System.Drawing.Size(38, 19);
            this.linkLabel_AES.TabIndex = 17;
            this.linkLabel_AES.TabStop = true;
            this.linkLabel_AES.Text = "AES";
            this.linkLabel_AES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AES_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "в .NET Framework";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "алгоритми шифрування, вбудовані";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Програма використовує симетричні";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(93, 181);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 26);
            this.buttonClose.TabIndex = 22;
            this.buttonClose.Text = "ОК";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 212);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.linkLabel_RC2);
            this.Controls.Add(this.linkLabel_TriplDES);
            this.Controls.Add(this.linkLabel_DES);
            this.Controls.Add(this.linkLabel_Rijndael);
            this.Controls.Add(this.linkLabel_AES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Про блокові шифри";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel_RC2;
        private System.Windows.Forms.LinkLabel linkLabel_TriplDES;
        private System.Windows.Forms.LinkLabel linkLabel_DES;
        private System.Windows.Forms.LinkLabel linkLabel_Rijndael;
        private System.Windows.Forms.LinkLabel linkLabel_AES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
    }
}