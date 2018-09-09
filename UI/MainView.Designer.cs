namespace UI
{
    partial class MainView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Dublicate = new System.Windows.Forms.GroupBox();
            this.DublicateTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Last = new System.Windows.Forms.GroupBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.GroupBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.Dublicate.SuspendLayout();
            this.Last.SuspendLayout();
            this.First.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.First);
            this.flowLayoutPanel2.Controls.Add(this.Last);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.Dublicate);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(496, 339);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // Dublicate
            // 
            this.Dublicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Dublicate.Controls.Add(this.DublicateTxt);
            this.Dublicate.Location = new System.Drawing.Point(3, 69);
            this.Dublicate.Name = "Dublicate";
            this.Dublicate.Size = new System.Drawing.Size(156, 100);
            this.Dublicate.TabIndex = 5;
            this.Dublicate.TabStop = false;
            this.Dublicate.Text = "Dublicate";
            this.Dublicate.Enter += new System.EventHandler(this.Dublicate_Enter);
            // 
            // DublicateTxt
            // 
            this.DublicateTxt.Location = new System.Drawing.Point(6, 35);
            this.DublicateTxt.Name = "DublicateTxt";
            this.DublicateTxt.Size = new System.Drawing.Size(126, 22);
            this.DublicateTxt.TabIndex = 6;
            this.DublicateTxt.TextChanged += new System.EventHandler(this.DublicateTxt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Last
            // 
            this.Last.Controls.Add(this.LastName);
            this.Last.Location = new System.Drawing.Point(115, 3);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(106, 60);
            this.Last.TabIndex = 4;
            this.Last.TabStop = false;
            this.Last.Text = "LastName";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(6, 21);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(94, 22);
            this.LastName.TabIndex = 0;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // First
            // 
            this.First.Controls.Add(this.FirstName);
            this.First.Location = new System.Drawing.Point(3, 3);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(106, 60);
            this.First.TabIndex = 2;
            this.First.TabStop = false;
            this.First.Text = "FisrtName";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(0, 21);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 22);
            this.FirstName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 366);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(532, 390);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainView";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.Dublicate.ResumeLayout(false);
            this.Dublicate.PerformLayout();
            this.Last.ResumeLayout(false);
            this.Last.PerformLayout();
            this.First.ResumeLayout(false);
            this.First.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox First;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.GroupBox Last;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Dublicate;
        private System.Windows.Forms.TextBox DublicateTxt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

