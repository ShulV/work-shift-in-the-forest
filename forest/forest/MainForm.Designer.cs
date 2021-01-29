namespace forest
{
    partial class MainForm
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
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.currentShiftBtn = new System.Windows.Forms.Button();
            this.newShiftBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.button1);
            this.groupBoxButtons.Controls.Add(this.currentShiftBtn);
            this.groupBoxButtons.Controls.Add(this.newShiftBtn);
            this.groupBoxButtons.Location = new System.Drawing.Point(162, 79);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxButtons.Size = new System.Drawing.Size(286, 192);
            this.groupBoxButtons.TabIndex = 0;
            this.groupBoxButtons.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(68, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показать существующую вахту";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // currentShiftBtn
            // 
            this.currentShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.currentShiftBtn.Location = new System.Drawing.Point(89, 60);
            this.currentShiftBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentShiftBtn.Name = "currentShiftBtn";
            this.currentShiftBtn.Size = new System.Drawing.Size(112, 31);
            this.currentShiftBtn.TabIndex = 1;
            this.currentShiftBtn.Text = "Текущая вахта";
            this.currentShiftBtn.UseVisualStyleBackColor = true;
            // 
            // newShiftBtn
            // 
            this.newShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newShiftBtn.Location = new System.Drawing.Point(89, 24);
            this.newShiftBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newShiftBtn.Name = "newShiftBtn";
            this.newShiftBtn.Size = new System.Drawing.Size(112, 31);
            this.newShiftBtn.TabIndex = 0;
            this.newShiftBtn.Text = "Новая вахта";
            this.newShiftBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxButtons);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Главная (1)";
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button currentShiftBtn;
        private System.Windows.Forms.Button newShiftBtn;
        private System.Windows.Forms.Button button2;
    }
}

