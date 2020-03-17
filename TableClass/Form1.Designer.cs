namespace TableClass
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
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.numberButton = new System.Windows.Forms.RadioButton();
            this.syllabelButton = new System.Windows.Forms.RadioButton();
            this.letterButton = new System.Windows.Forms.RadioButton();
            this.sizeTable = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // numberButton
            // 
            this.numberButton.AutoSize = true;
            this.numberButton.Checked = true;
            this.numberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberButton.Location = new System.Drawing.Point(115, 57);
            this.numberButton.Name = "numberButton";
            this.numberButton.Size = new System.Drawing.Size(79, 21);
            this.numberButton.TabIndex = 1;
            this.numberButton.TabStop = true;
            this.numberButton.Text = "Цифры";
            this.numberButton.UseVisualStyleBackColor = true;
            // 
            // syllabelButton
            // 
            this.syllabelButton.AutoSize = true;
            this.syllabelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.syllabelButton.Location = new System.Drawing.Point(115, 91);
            this.syllabelButton.Name = "syllabelButton";
            this.syllabelButton.Size = new System.Drawing.Size(69, 21);
            this.syllabelButton.TabIndex = 2;
            this.syllabelButton.Text = "Слога";
            this.syllabelButton.UseVisualStyleBackColor = true;
            // 
            // letterButton
            // 
            this.letterButton.AutoSize = true;
            this.letterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.letterButton.Location = new System.Drawing.Point(115, 127);
            this.letterButton.Name = "letterButton";
            this.letterButton.Size = new System.Drawing.Size(71, 21);
            this.letterButton.TabIndex = 2;
            this.letterButton.Text = "Буквы";
            this.letterButton.UseVisualStyleBackColor = true;
            // 
            // sizeTable
            // 
            this.sizeTable.AllowDrop = true;
            this.sizeTable.Location = new System.Drawing.Point(250, 172);
            this.sizeTable.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sizeTable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeTable.Name = "sizeTable";
            this.sizeTable.Size = new System.Drawing.Size(35, 20);
            this.sizeTable.TabIndex = 3;
            this.sizeTable.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите размер таблицы";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(312, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeTable);
            this.Controls.Add(this.letterButton);
            this.Controls.Add(this.syllabelButton);
            this.Controls.Add(this.numberButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор упражнения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sizeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton numberButton;
        private System.Windows.Forms.RadioButton syllabelButton;
        private System.Windows.Forms.RadioButton letterButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown sizeTable;
    }
}