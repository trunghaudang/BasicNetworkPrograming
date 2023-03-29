namespace Client
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
            this.txt_ClientView = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_ClientMess = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.lb_ClientMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ClientView
            // 
            this.txt_ClientView.Location = new System.Drawing.Point(66, 21);
            this.txt_ClientView.Multiline = true;
            this.txt_ClientView.Name = "txt_ClientView";
            this.txt_ClientView.ReadOnly = true;
            this.txt_ClientView.Size = new System.Drawing.Size(669, 201);
            this.txt_ClientView.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_ClientMess
            // 
            this.txt_ClientMess.Location = new System.Drawing.Point(257, 265);
            this.txt_ClientMess.Multiline = true;
            this.txt_ClientMess.Name = "txt_ClientMess";
            this.txt_ClientMess.Size = new System.Drawing.Size(478, 35);
            this.txt_ClientMess.TabIndex = 2;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(412, 332);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(133, 41);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send ";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // lb_ClientMess
            // 
            this.lb_ClientMess.AutoSize = true;
            this.lb_ClientMess.Location = new System.Drawing.Point(62, 280);
            this.lb_ClientMess.Name = "lb_ClientMess";
            this.lb_ClientMess.Size = new System.Drawing.Size(153, 20);
            this.lb_ClientMess.TabIndex = 4;
            this.lb_ClientMess.Text = "Write your message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_ClientMess);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_ClientMess);
            this.Controls.Add(this.txt_ClientView);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ClientView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_ClientMess;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label lb_ClientMess;
    }
}

