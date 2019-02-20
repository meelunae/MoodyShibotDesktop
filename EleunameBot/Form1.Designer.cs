namespace EleunameBot
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pollButton = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.votesClear = new System.Windows.Forms.Button();
            this.srClear = new System.Windows.Forms.Button();
            this.speechButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pollButton
            // 
            this.pollButton.Location = new System.Drawing.Point(295, 30);
            this.pollButton.Margin = new System.Windows.Forms.Padding(4);
            this.pollButton.Name = "pollButton";
            this.pollButton.Size = new System.Drawing.Size(112, 41);
            this.pollButton.TabIndex = 0;
            this.pollButton.Text = "Start Poll";
            this.pollButton.UseVisualStyleBackColor = true;
            this.pollButton.Click += new System.EventHandler(this.Poll_Click);
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(16, 30);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(260, 418);
            this.chatBox.TabIndex = 1;
            this.chatBox.Text = "";
            this.chatBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(432, 33);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(231, 404);
            this.listBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Poll Votes";
            // 
            // votesClear
            // 
            this.votesClear.Location = new System.Drawing.Point(491, 446);
            this.votesClear.Margin = new System.Windows.Forms.Padding(4);
            this.votesClear.Name = "votesClear";
            this.votesClear.Size = new System.Drawing.Size(100, 32);
            this.votesClear.TabIndex = 8;
            this.votesClear.Text = "Clear votes";
            this.votesClear.UseVisualStyleBackColor = true;
            this.votesClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // srClear
            // 
            this.srClear.Location = new System.Drawing.Point(732, 448);
            this.srClear.Margin = new System.Windows.Forms.Padding(4);
            this.srClear.Name = "srClear";
            this.srClear.Size = new System.Drawing.Size(139, 28);
            this.srClear.TabIndex = 10;
            this.srClear.Text = "Clear Songrequest";
            this.srClear.UseVisualStyleBackColor = true;
            this.srClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // speechButton
            // 
            this.speechButton.Location = new System.Drawing.Point(295, 89);
            this.speechButton.Name = "speechButton";
            this.speechButton.Size = new System.Drawing.Size(112, 40);
            this.speechButton.TabIndex = 11;
            this.speechButton.Text = "Text to Speech";
            this.speechButton.UseVisualStyleBackColor = true;
            this.speechButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(689, 33);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 404);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 523);
            this.Controls.Add(this.speechButton);
            this.Controls.Add(this.srClear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.votesClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.pollButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "EleunameBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private  System.Windows.Forms.Button pollButton;
        private  System.Windows.Forms.RichTextBox chatBox;
        private  System.Windows.Forms.OpenFileDialog openFileDialog1;
        private  System.Windows.Forms.Timer timer1;
        private  System.Windows.Forms.ListBox listBox2;
        private  System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button votesClear;
        private System.Windows.Forms.Button srClear;
        private System.Windows.Forms.Button speechButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

