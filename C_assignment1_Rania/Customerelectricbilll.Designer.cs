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
            this.overallkwhLabel = new System.Windows.Forms.Label();
            this.entered_kwhTextbox = new System.Windows.Forms.TextBox();
            this.calculatebillButton = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.customertypeComboBox = new System.Windows.Forms.ComboBox();
            this.customertypeLable = new System.Windows.Forms.Label();
            this.offpeaktextbox = new System.Windows.Forms.TextBox();
            this.peakhoursLabel = new System.Windows.Forms.Label();
            this.offpeakhoursLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // overallkwhLabel
            // 
            this.overallkwhLabel.AutoSize = true;
            this.overallkwhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallkwhLabel.Location = new System.Drawing.Point(54, 167);
            this.overallkwhLabel.Name = "overallkwhLabel";
            this.overallkwhLabel.Size = new System.Drawing.Size(218, 18);
            this.overallkwhLabel.TabIndex = 0;
            this.overallkwhLabel.Text = "Please enter overall KWh used: ";
            // 
            // entered_kwhTextbox
            // 
            this.entered_kwhTextbox.Location = new System.Drawing.Point(408, 165);
            this.entered_kwhTextbox.Name = "entered_kwhTextbox";
            this.entered_kwhTextbox.Size = new System.Drawing.Size(121, 20);
            this.entered_kwhTextbox.TabIndex = 1;
            this.entered_kwhTextbox.TextChanged += new System.EventHandler(this.Entered_kwhTextbox_TextChanged);
            // 
            // calculatebillButton
            // 
            this.calculatebillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebillButton.Location = new System.Drawing.Point(57, 368);
            this.calculatebillButton.Name = "calculatebillButton";
            this.calculatebillButton.Size = new System.Drawing.Size(95, 42);
            this.calculatebillButton.TabIndex = 2;
            this.calculatebillButton.Text = "Calculate bill";
            this.calculatebillButton.UseVisualStyleBackColor = true;
            this.calculatebillButton.Click += new System.EventHandler(this.Calculatebill_Click);
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(408, 300);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(121, 20);
            this.resultText.TabIndex = 3;
            this.resultText.Visible = false;
            this.resultText.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(245, 368);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 42);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(431, 368);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 42);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // customertypeComboBox
            // 
            this.customertypeComboBox.FormattingEnabled = true;
            this.customertypeComboBox.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.customertypeComboBox.Location = new System.Drawing.Point(408, 107);
            this.customertypeComboBox.Name = "customertypeComboBox";
            this.customertypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.customertypeComboBox.TabIndex = 6;
            this.customertypeComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomertypeComboBox_SelectedIndexChanged);
            // 
            // customertypeLable
            // 
            this.customertypeLable.AutoSize = true;
            this.customertypeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customertypeLable.Location = new System.Drawing.Point(54, 106);
            this.customertypeLable.Name = "customertypeLable";
            this.customertypeLable.Size = new System.Drawing.Size(196, 18);
            this.customertypeLable.TabIndex = 7;
            this.customertypeLable.Text = "Please enter customer type: ";
            // 
            // offpeaktextbox
            // 
            this.offpeaktextbox.Location = new System.Drawing.Point(408, 237);
            this.offpeaktextbox.Name = "offpeaktextbox";
            this.offpeaktextbox.Size = new System.Drawing.Size(121, 20);
            this.offpeaktextbox.TabIndex = 1;
            this.offpeaktextbox.Visible = false;
            this.offpeaktextbox.TextChanged += new System.EventHandler(this.Offpeaktextbox_TextChanged);
            // 
            // peakhoursLabel
            // 
            this.peakhoursLabel.AutoSize = true;
            this.peakhoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peakhoursLabel.Location = new System.Drawing.Point(54, 167);
            this.peakhoursLabel.Name = "peakhoursLabel";
            this.peakhoursLabel.Size = new System.Drawing.Size(171, 18);
            this.peakhoursLabel.TabIndex = 0;
            this.peakhoursLabel.Text = "Please enter Peak kWh: ";
            this.peakhoursLabel.Visible = false;
            this.peakhoursLabel.Click += new System.EventHandler(this.PeakhoursLabel_Click);
            // 
            // offpeakhoursLabel
            // 
            this.offpeakhoursLabel.AutoSize = true;
            this.offpeakhoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offpeakhoursLabel.Location = new System.Drawing.Point(54, 236);
            this.offpeakhoursLabel.Name = "offpeakhoursLabel";
            this.offpeakhoursLabel.Size = new System.Drawing.Size(191, 18);
            this.offpeakhoursLabel.TabIndex = 0;
            this.offpeakhoursLabel.Text = "Please enter off-peak kWh: ";
            this.offpeakhoursLabel.Visible = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.Linen;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(154, 23);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(298, 29);
            this.titleTextBox.TabIndex = 8;
            this.titleTextBox.Text = "Customer power bill calculation";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(54, 299);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(141, 18);
            this.paymentLabel.TabIndex = 9;
            this.paymentLabel.Text = "Your total Payment: ";
            // 
            // inputdataform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.customertypeLable);
            this.Controls.Add(this.customertypeComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.calculatebillButton);
            this.Controls.Add(this.offpeaktextbox);
            this.Controls.Add(this.entered_kwhTextbox);
            this.Controls.Add(this.offpeakhoursLabel);
            this.Controls.Add(this.peakhoursLabel);
            this.Controls.Add(this.overallkwhLabel);
            this.Name = "inputdataform";
            this.Text = "Customer bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label overallkwhLabel;
        private System.Windows.Forms.TextBox entered_kwhTextbox;
        private System.Windows.Forms.Button calculatebillButton;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox customertypeComboBox;
        private System.Windows.Forms.Label customertypeLable;
        private System.Windows.Forms.TextBox offpeaktextbox;
        private System.Windows.Forms.Label peakhoursLabel;
        private System.Windows.Forms.Label offpeakhoursLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label paymentLabel;
    }
}

