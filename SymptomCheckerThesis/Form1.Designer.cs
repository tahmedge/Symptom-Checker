namespace SymptomCheckerThesis
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
            this.Button_Proceed = new System.Windows.Forms.Button();
            this.textBox_no_of_symptoms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Proceed
            // 
            this.Button_Proceed.BackColor = System.Drawing.Color.DarkCyan;
            this.Button_Proceed.Location = new System.Drawing.Point(371, 160);
            this.Button_Proceed.Name = "Button_Proceed";
            this.Button_Proceed.Size = new System.Drawing.Size(75, 33);
            this.Button_Proceed.TabIndex = 0;
            this.Button_Proceed.Text = "Proceed";
            this.Button_Proceed.UseVisualStyleBackColor = false;
            this.Button_Proceed.Click += new System.EventHandler(this.Button_Proceed_Click);
            // 
            // textBox_no_of_symptoms
            // 
            this.textBox_no_of_symptoms.Location = new System.Drawing.Point(315, 134);
            this.textBox_no_of_symptoms.Name = "textBox_no_of_symptoms";
            this.textBox_no_of_symptoms.Size = new System.Drawing.Size(180, 20);
            this.textBox_no_of_symptoms.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(324, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many Symptoms?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_no_of_symptoms);
            this.Controls.Add(this.Button_Proceed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Proceed;
        private System.Windows.Forms.TextBox textBox_no_of_symptoms;
        private System.Windows.Forms.Label label1;
    }
}

