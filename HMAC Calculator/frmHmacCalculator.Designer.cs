namespace HMAC_Calculator
{
    partial class frmHmacCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtText2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtText1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimestampFormat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDigest = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secret";
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(68, 30);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(356, 23);
            this.txtSecret.TabIndex = 1;
            this.txtSecret.TextChanged += new System.EventHandler(this.Inputs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text2";
            // 
            // txtText2
            // 
            this.txtText2.Location = new System.Drawing.Point(68, 88);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(356, 23);
            this.txtText2.TabIndex = 1;
            this.txtText2.TextChanged += new System.EventHandler(this.Inputs_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text1";
            // 
            // txtText1
            // 
            this.txtText1.Location = new System.Drawing.Point(68, 59);
            this.txtText1.Name = "txtText1";
            this.txtText1.Size = new System.Drawing.Size(356, 23);
            this.txtText1.TabIndex = 1;
            this.txtText1.TextChanged += new System.EventHandler(this.Inputs_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Timestamp";
            // 
            // txtTimestampFormat
            // 
            this.txtTimestampFormat.Location = new System.Drawing.Point(96, 122);
            this.txtTimestampFormat.Name = "txtTimestampFormat";
            this.txtTimestampFormat.ReadOnly = true;
            this.txtTimestampFormat.Size = new System.Drawing.Size(210, 23);
            this.txtTimestampFormat.TabIndex = 1;
            this.txtTimestampFormat.Text = "dd-MM-yyyy-hh-mm-ss";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Digest";
            // 
            // txtDigest
            // 
            this.txtDigest.Location = new System.Drawing.Point(68, 203);
            this.txtDigest.Name = "txtDigest";
            this.txtDigest.Size = new System.Drawing.Size(356, 23);
            this.txtDigest.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(68, 151);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(356, 23);
            this.txtMessage.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 154);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // frmHmacCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 251);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtDigest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimestampFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtText1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtText2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.label1);
            this.Name = "frmHmacCalculator";
            this.Text = "HMAC Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtText2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtText1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimestampFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDigest;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
    }
}

