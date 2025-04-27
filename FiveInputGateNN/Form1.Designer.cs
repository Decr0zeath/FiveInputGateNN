namespace FiveInputGateNN
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
            this.cmbInput1 = new System.Windows.Forms.ComboBox();
            this.cmbInput2 = new System.Windows.Forms.ComboBox();
            this.cmbInput3 = new System.Windows.Forms.ComboBox();
            this.cmbInput4 = new System.Windows.Forms.ComboBox();
            this.cmbInput5 = new System.Windows.Forms.ComboBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblANDResult = new System.Windows.Forms.Label();
            this.lblORResult = new System.Windows.Forms.Label();
            this.lblThoughtProcess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbInput1
            // 
            this.cmbInput1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInput1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInput1.FormattingEnabled = true;
            this.cmbInput1.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbInput1.Location = new System.Drawing.Point(155, 97);
            this.cmbInput1.Name = "cmbInput1";
            this.cmbInput1.Size = new System.Drawing.Size(65, 21);
            this.cmbInput1.TabIndex = 3;
            // 
            // cmbInput2
            // 
            this.cmbInput2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInput2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInput2.FormattingEnabled = true;
            this.cmbInput2.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbInput2.Location = new System.Drawing.Point(155, 142);
            this.cmbInput2.Name = "cmbInput2";
            this.cmbInput2.Size = new System.Drawing.Size(65, 21);
            this.cmbInput2.TabIndex = 4;
            // 
            // cmbInput3
            // 
            this.cmbInput3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInput3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInput3.FormattingEnabled = true;
            this.cmbInput3.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbInput3.Location = new System.Drawing.Point(155, 187);
            this.cmbInput3.Name = "cmbInput3";
            this.cmbInput3.Size = new System.Drawing.Size(65, 21);
            this.cmbInput3.TabIndex = 5;
            // 
            // cmbInput4
            // 
            this.cmbInput4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInput4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInput4.FormattingEnabled = true;
            this.cmbInput4.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbInput4.Location = new System.Drawing.Point(155, 232);
            this.cmbInput4.Name = "cmbInput4";
            this.cmbInput4.Size = new System.Drawing.Size(65, 21);
            this.cmbInput4.TabIndex = 6;
            // 
            // cmbInput5
            // 
            this.cmbInput5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInput5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInput5.FormattingEnabled = true;
            this.cmbInput5.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbInput5.Location = new System.Drawing.Point(155, 277);
            this.cmbInput5.Name = "cmbInput5";
            this.cmbInput5.Size = new System.Drawing.Size(65, 21);
            this.cmbInput5.TabIndex = 7;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(254, 349);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 8;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(471, 340);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 9;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // lblANDResult
            // 
            this.lblANDResult.AutoSize = true;
            this.lblANDResult.Location = new System.Drawing.Point(348, 168);
            this.lblANDResult.Name = "lblANDResult";
            this.lblANDResult.Size = new System.Drawing.Size(35, 13);
            this.lblANDResult.TabIndex = 10;
            this.lblANDResult.Text = "label1";
            // 
            // lblORResult
            // 
            this.lblORResult.AutoSize = true;
            this.lblORResult.Location = new System.Drawing.Point(348, 195);
            this.lblORResult.Name = "lblORResult";
            this.lblORResult.Size = new System.Drawing.Size(35, 13);
            this.lblORResult.TabIndex = 11;
            this.lblORResult.Text = "label1";
            // 
            // lblThoughtProcess
            // 
            this.lblThoughtProcess.AutoSize = true;
            this.lblThoughtProcess.Location = new System.Drawing.Point(285, 34);
            this.lblThoughtProcess.Name = "lblThoughtProcess";
            this.lblThoughtProcess.Size = new System.Drawing.Size(35, 13);
            this.lblThoughtProcess.TabIndex = 12;
            this.lblThoughtProcess.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThoughtProcess);
            this.Controls.Add(this.lblORResult);
            this.Controls.Add(this.lblANDResult);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.cmbInput5);
            this.Controls.Add(this.cmbInput4);
            this.Controls.Add(this.cmbInput3);
            this.Controls.Add(this.cmbInput2);
            this.Controls.Add(this.cmbInput1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbInput1;
        private System.Windows.Forms.ComboBox cmbInput2;
        private System.Windows.Forms.ComboBox cmbInput3;
        private System.Windows.Forms.ComboBox cmbInput4;
        private System.Windows.Forms.ComboBox cmbInput5;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblANDResult;
        private System.Windows.Forms.Label lblORResult;
        private System.Windows.Forms.Label lblThoughtProcess;
    }
}

