namespace SymptomCheckerThesis
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBlock_enter_symptom = new System.Windows.Forms.Label();
            this.textBox_symptomname = new System.Windows.Forms.TextBox();
            this.button_proceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBlock_enter_symptom
            // 
            this.textBlock_enter_symptom.AutoSize = true;
            this.textBlock_enter_symptom.BackColor = System.Drawing.Color.Transparent;
            this.textBlock_enter_symptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBlock_enter_symptom.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBlock_enter_symptom.Location = new System.Drawing.Point(322, 93);
            this.textBlock_enter_symptom.Name = "textBlock_enter_symptom";
            this.textBlock_enter_symptom.Size = new System.Drawing.Size(51, 20);
            this.textBlock_enter_symptom.TabIndex = 0;
            this.textBlock_enter_symptom.Text = "label1";
            this.textBlock_enter_symptom.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_symptomname
            // 
            this.textBox_symptomname.Location = new System.Drawing.Point(179, 116);
            this.textBox_symptomname.Name = "textBox_symptomname";
            this.textBox_symptomname.Size = new System.Drawing.Size(378, 20);
            this.textBox_symptomname.TabIndex = 1;
            // 
            // button_proceed
            // 
            this.button_proceed.BackColor = System.Drawing.Color.SteelBlue;
            this.button_proceed.Location = new System.Drawing.Point(352, 142);
            this.button_proceed.Name = "button_proceed";
            this.button_proceed.Size = new System.Drawing.Size(75, 31);
            this.button_proceed.TabIndex = 2;
            this.button_proceed.Text = "Proceed";
            this.button_proceed.UseVisualStyleBackColor = false;
            this.button_proceed.Click += new System.EventHandler(this.button_proceed_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 340);
            this.Controls.Add(this.button_proceed);
            this.Controls.Add(this.textBox_symptomname);
            this.Controls.Add(this.textBlock_enter_symptom);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBlock_enter_symptom;
        private System.Windows.Forms.TextBox textBox_symptomname;
        private System.Windows.Forms.Button button_proceed;
    }
}