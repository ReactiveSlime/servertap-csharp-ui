namespace ServerTap_GUI
{
    partial class AddServer
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
            this.ServerNameBox = new System.Windows.Forms.TextBox();
            this.ServerIPBox = new System.Windows.Forms.TextBox();
            this.ServerTapKeyBox = new System.Windows.Forms.TextBox();
            this.ServerTapPortBox = new System.Windows.Forms.TextBox();
            this.TestConnectionButton = new System.Windows.Forms.Button();
            this.AddServerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServerNameBox
            // 
            this.ServerNameBox.Location = new System.Drawing.Point(12, 53);
            this.ServerNameBox.Name = "ServerNameBox";
            this.ServerNameBox.Size = new System.Drawing.Size(100, 20);
            this.ServerNameBox.TabIndex = 1;
            this.ServerNameBox.TextChanged += new System.EventHandler(this.ServerNameBox_TextChanged);
            // 
            // ServerIPBox
            // 
            this.ServerIPBox.Location = new System.Drawing.Point(13, 103);
            this.ServerIPBox.Name = "ServerIPBox";
            this.ServerIPBox.Size = new System.Drawing.Size(100, 20);
            this.ServerIPBox.TabIndex = 2;
            this.ServerIPBox.TextChanged += new System.EventHandler(this.ServerIPBox_TextChanged);
            // 
            // ServerTapKeyBox
            // 
            this.ServerTapKeyBox.Location = new System.Drawing.Point(13, 148);
            this.ServerTapKeyBox.Name = "ServerTapKeyBox";
            this.ServerTapKeyBox.PasswordChar = '*';
            this.ServerTapKeyBox.Size = new System.Drawing.Size(100, 20);
            this.ServerTapKeyBox.TabIndex = 4;
            this.ServerTapKeyBox.TextChanged += new System.EventHandler(this.ServerTapKeyBox_TextChanged);
            // 
            // ServerTapPortBox
            // 
            this.ServerTapPortBox.Location = new System.Drawing.Point(142, 102);
            this.ServerTapPortBox.Name = "ServerTapPortBox";
            this.ServerTapPortBox.Size = new System.Drawing.Size(100, 20);
            this.ServerTapPortBox.TabIndex = 3;
            this.ServerTapPortBox.TextChanged += new System.EventHandler(this.ServerTapPortBox_TextChanged);
            // 
            // TestConnectionButton
            // 
            this.TestConnectionButton.Location = new System.Drawing.Point(12, 213);
            this.TestConnectionButton.Name = "TestConnectionButton";
            this.TestConnectionButton.Size = new System.Drawing.Size(99, 23);
            this.TestConnectionButton.TabIndex = 5;
            this.TestConnectionButton.Text = "Test Connection";
            this.TestConnectionButton.UseVisualStyleBackColor = true;
            this.TestConnectionButton.Click += new System.EventHandler(this.TestConnectionButton_Click);
            // 
            // AddServerButton
            // 
            this.AddServerButton.Location = new System.Drawing.Point(142, 213);
            this.AddServerButton.Name = "AddServerButton";
            this.AddServerButton.Size = new System.Drawing.Size(100, 23);
            this.AddServerButton.TabIndex = 6;
            this.AddServerButton.Text = "Add Server";
            this.AddServerButton.UseVisualStyleBackColor = true;
            this.AddServerButton.Click += new System.EventHandler(this.AddServerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Server IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ServerTap Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ServerTap Key";
            // 
            // AddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddServerButton);
            this.Controls.Add(this.TestConnectionButton);
            this.Controls.Add(this.ServerTapPortBox);
            this.Controls.Add(this.ServerTapKeyBox);
            this.Controls.Add(this.ServerIPBox);
            this.Controls.Add(this.ServerNameBox);
            this.Name = "AddServer";
            this.Text = "Add Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox ServerNameBox;
        private System.Windows.Forms.TextBox ServerIPBox;
        private System.Windows.Forms.TextBox ServerTapKeyBox;
        private System.Windows.Forms.TextBox ServerTapPortBox;
        private System.Windows.Forms.Button TestConnectionButton;
        private System.Windows.Forms.Button AddServerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

