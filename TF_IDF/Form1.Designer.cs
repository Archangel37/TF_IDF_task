namespace TF_IDF
{
    partial class FormTF_IDF
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
            this.CalculateTfIdf_btn = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CalculateTfIdf_btn
            // 
            this.CalculateTfIdf_btn.Location = new System.Drawing.Point(31, 30);
            this.CalculateTfIdf_btn.Name = "CalculateTfIdf_btn";
            this.CalculateTfIdf_btn.Size = new System.Drawing.Size(79, 69);
            this.CalculateTfIdf_btn.TabIndex = 0;
            this.CalculateTfIdf_btn.Text = "Calculate TF-IDF form source";
            this.CalculateTfIdf_btn.UseVisualStyleBackColor = true;
            this.CalculateTfIdf_btn.Click += new System.EventHandler(this.CalculateTfIdf_btn_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(31, 120);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(810, 481);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
            // 
            // FormTF_IDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 613);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.CalculateTfIdf_btn);
            this.Name = "FormTF_IDF";
            this.Text = "TF-IDF Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalculateTfIdf_btn;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}

