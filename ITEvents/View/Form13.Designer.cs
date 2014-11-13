namespace ITEvents
{
    partial class Form13
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
            this.btnOK = new System.Windows.Forms.Button();
            this.nietingeschrevenListView = new System.Windows.Forms.ListView();
            this.ingeschrevenListView = new System.Windows.Forms.ListView();
            this.schrijfInButton = new System.Windows.Forms.Button();
            this.schrijfUitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(190, 250);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nietingeschrevenListView
            // 
            this.nietingeschrevenListView.Location = new System.Drawing.Point(12, 27);
            this.nietingeschrevenListView.Name = "nietingeschrevenListView";
            this.nietingeschrevenListView.Size = new System.Drawing.Size(161, 217);
            this.nietingeschrevenListView.TabIndex = 26;
            this.nietingeschrevenListView.UseCompatibleStateImageBehavior = false;
            // 
            // ingeschrevenListView
            // 
            this.ingeschrevenListView.Location = new System.Drawing.Point(281, 27);
            this.ingeschrevenListView.Name = "ingeschrevenListView";
            this.ingeschrevenListView.Size = new System.Drawing.Size(161, 217);
            this.ingeschrevenListView.TabIndex = 27;
            this.ingeschrevenListView.UseCompatibleStateImageBehavior = false;
            // 
            // schrijfInButton
            // 
            this.schrijfInButton.Location = new System.Drawing.Point(190, 49);
            this.schrijfInButton.Name = "schrijfInButton";
            this.schrijfInButton.Size = new System.Drawing.Size(75, 23);
            this.schrijfInButton.TabIndex = 28;
            this.schrijfInButton.Text = "Schrijf in";
            this.schrijfInButton.UseVisualStyleBackColor = true;
            this.schrijfInButton.Click += new System.EventHandler(this.schrijfInButton_Click);
            // 
            // schrijfUitButton
            // 
            this.schrijfUitButton.Location = new System.Drawing.Point(190, 96);
            this.schrijfUitButton.Name = "schrijfUitButton";
            this.schrijfUitButton.Size = new System.Drawing.Size(75, 23);
            this.schrijfUitButton.TabIndex = 29;
            this.schrijfUitButton.Text = "Schrijf uit";
            this.schrijfUitButton.UseVisualStyleBackColor = true;
            this.schrijfUitButton.Click += new System.EventHandler(this.schrijfUitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Niet ingeschreven";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ingeschreven";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.schrijfUitButton);
            this.Controls.Add(this.schrijfInButton);
            this.Controls.Add(this.ingeschrevenListView);
            this.Controls.Add(this.nietingeschrevenListView);
            this.Controls.Add(this.btnOK);
            this.Name = "Form13";
            this.Text = "Form13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView nietingeschrevenListView;
        private System.Windows.Forms.ListView ingeschrevenListView;
        private System.Windows.Forms.Button schrijfInButton;
        private System.Windows.Forms.Button schrijfUitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}