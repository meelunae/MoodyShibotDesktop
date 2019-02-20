namespace EleunameBot
{
    partial class Poll
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


        // Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.questionText = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.answer1Text = new System.Windows.Forms.TextBox();
            this.answer2Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Counterino = new System.Windows.Forms.Label();
            this.Counterone = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cancelPoll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pointsNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.verifyAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(3, 32);
            this.questionText.Margin = new System.Windows.Forms.Padding(4);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(311, 22);
            this.questionText.TabIndex = 0;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(111, 130);
            this.Send.Margin = new System.Windows.Forms.Padding(4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(100, 30);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send Poll";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // answer1Text
            // 
            this.answer1Text.Location = new System.Drawing.Point(3, 79);
            this.answer1Text.Margin = new System.Windows.Forms.Padding(4);
            this.answer1Text.Name = "answer1Text";
            this.answer1Text.Size = new System.Drawing.Size(99, 22);
            this.answer1Text.TabIndex = 2;
            // 
            // answer2Text
            // 
            this.answer2Text.Location = new System.Drawing.Point(111, 79);
            this.answer2Text.Margin = new System.Windows.Forms.Padding(4);
            this.answer2Text.Name = "answer2Text";
            this.answer2Text.Size = new System.Drawing.Size(99, 22);
            this.answer2Text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Answer 1 Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answer 2 Count:";
            // 
            // Counterino
            // 
            this.Counterino.AutoSize = true;
            this.Counterino.Location = new System.Drawing.Point(124, 178);
            this.Counterino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Counterino.Name = "Counterino";
            this.Counterino.Size = new System.Drawing.Size(0, 17);
            this.Counterino.TabIndex = 6;
            // 
            // Counterone
            // 
            this.Counterone.AutoSize = true;
            this.Counterone.Location = new System.Drawing.Point(123, 213);
            this.Counterone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Counterone.Name = "Counterone";
            this.Counterone.Size = new System.Drawing.Size(0, 17);
            this.Counterone.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 45000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cancelPoll
            // 
            this.cancelPoll.Location = new System.Drawing.Point(3, 130);
            this.cancelPoll.Margin = new System.Windows.Forms.Padding(4);
            this.cancelPoll.Name = "cancelPoll";
            this.cancelPoll.Size = new System.Drawing.Size(100, 28);
            this.cancelPoll.TabIndex = 8;
            this.cancelPoll.Text = "Cancel Poll";
            this.cancelPoll.UseVisualStyleBackColor = true;
            this.cancelPoll.Click += new System.EventHandler(this.cancelPoll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Question:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Answer 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Answer 2";
            // 
            // pointsNumber
            // 
            this.pointsNumber.Location = new System.Drawing.Point(219, 79);
            this.pointsNumber.Margin = new System.Windows.Forms.Padding(4);
            this.pointsNumber.Name = "pointsNumber";
            this.pointsNumber.Size = new System.Drawing.Size(95, 22);
            this.pointsNumber.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Points Amount";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Answer 1",
            "Answer 2"});
            this.comboBox1.Location = new System.Drawing.Point(219, 133);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Correct Answer";
            // 
            // verifyAns
            // 
            this.verifyAns.Location = new System.Drawing.Point(220, 177);
            this.verifyAns.Margin = new System.Windows.Forms.Padding(4);
            this.verifyAns.Name = "verifyAns";
            this.verifyAns.Size = new System.Drawing.Size(100, 44);
            this.verifyAns.TabIndex = 16;
            this.verifyAns.Text = "Submit Answer";
            this.verifyAns.UseVisualStyleBackColor = true;
            this.verifyAns.Click += new System.EventHandler(this.verifyAns_Click);
            // 
            // Poll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 240);
            this.Controls.Add(this.verifyAns);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pointsNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelPoll);
            this.Controls.Add(this.Counterone);
            this.Controls.Add(this.Counterino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer2Text);
            this.Controls.Add(this.answer1Text);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.questionText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Poll";
            this.Text = "Poll";
            this.Load += new System.EventHandler(this.Poll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public System.Windows.Forms.Button Send;
        public System.Windows.Forms.TextBox answer1Text;
        public System.Windows.Forms.TextBox answer2Text;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Counterino;
        public System.Windows.Forms.Label Counterone;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cancelPoll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pointsNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button verifyAns;
        public System.Windows.Forms.TextBox questionText;
    }
}