namespace MQTT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.Broker = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.Subscribe = new System.Windows.Forms.TextBox();
            this.Messages = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.Publish = new System.Windows.Forms.Button();
            this.ClearList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subscribe";
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(443, 64);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 3;
            this.Go.Text = "Subscribe";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Broker
            // 
            this.Broker.Location = new System.Drawing.Point(12, 68);
            this.Broker.Name = "Broker";
            this.Broker.Size = new System.Drawing.Size(182, 20);
            this.Broker.TabIndex = 4;
            this.Broker.Text = "iot.eclipse.org";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(209, 67);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(92, 20);
            this.Port.TabIndex = 5;
            this.Port.Text = "1883";
            this.Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Port_KeyPress);
            // 
            // Subscribe
            // 
            this.Subscribe.Location = new System.Drawing.Point(316, 67);
            this.Subscribe.Name = "Subscribe";
            this.Subscribe.Size = new System.Drawing.Size(112, 20);
            this.Subscribe.TabIndex = 6;
            this.Subscribe.Text = "$SYS/#";
            // 
            // Messages
            // 
            this.Messages.AcceptsReturn = true;
            this.Messages.BackColor = System.Drawing.Color.Black;
            this.Messages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Messages.ForeColor = System.Drawing.Color.Green;
            this.Messages.Location = new System.Drawing.Point(0, 117);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.ReadOnly = true;
            this.Messages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Messages.Size = new System.Drawing.Size(631, 317);
            this.Messages.TabIndex = 7;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(0, 441);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(530, 20);
            this.Message.TabIndex = 10;
            // 
            // Publish
            // 
            this.Publish.Location = new System.Drawing.Point(536, 440);
            this.Publish.Name = "Publish";
            this.Publish.Size = new System.Drawing.Size(75, 23);
            this.Publish.TabIndex = 9;
            this.Publish.Text = "Publish";
            this.Publish.UseVisualStyleBackColor = true;
            this.Publish.Click += new System.EventHandler(this.Publish_Click);
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(533, 64);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(75, 23);
            this.ClearList.TabIndex = 11;
            this.ClearList.Text = "Clear List";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "MQTT - Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "by em@borafaze.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Publish);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.Subscribe);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Broker);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MQTT - Lightweight Client V 0.2 - beta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox Broker;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox Subscribe;
        private System.Windows.Forms.TextBox Messages;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button Publish;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

