namespace C_assignment1_Rania
{
    partial class inputdataform
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
            this.prompt = new System.Windows.Forms.Label();
            this.entered_kwh = new System.Windows.Forms.TextBox();
            this.calculatebill = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Location = new System.Drawing.Point(41, 100);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(125, 13);
            this.prompt.TabIndex = 0;
            this.prompt.Text = "Please enter KWh used: ";
            // 
            // entered_kwh
            // 
            this.entered_kwh.Location = new System.Drawing.Point(273, 99);
            this.entered_kwh.Name = "entered_kwh";
            this.entered_kwh.Size = new System.Drawing.Size(101, 20);
            this.entered_kwh.TabIndex = 1;
            // 
            // calculatebill
            // 
            this.calculatebill.Location = new System.Drawing.Point(57, 204);
            this.calculatebill.Name = "calculatebill";
            this.calculatebill.Size = new System.Drawing.Size(75, 42);
            this.calculatebill.TabIndex = 2;
            this.calculatebill.Text = "Calculate bill";
            this.calculatebill.UseVisualStyleBackColor = true;
            this.calculatebill.Click += new System.EventHandler(this.Calculatebill_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(57, 293);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(163, 20);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            this.result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(236, 204);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(85, 42);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(421, 204);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 42);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // inputdataform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calculatebill);
            this.Controls.Add(this.entered_kwh);
            this.Controls.Add(this.prompt);
            this.Name = "inputdataform";
            this.Text = "Input Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prompt;
        private System.Windows.Forms.TextBox entered_kwh;
        private System.Windows.Forms.Button calculatebill;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
    }
}

