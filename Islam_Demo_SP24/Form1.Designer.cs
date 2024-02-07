namespace Islam_Demo_SP24
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWidgetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidgetPrice = new System.Windows.Forms.TextBox();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Widget &Name";
            // 
            // txtWidgetName
            // 
            this.txtWidgetName.Location = new System.Drawing.Point(215, 65);
            this.txtWidgetName.Name = "txtWidgetName";
            this.txtWidgetName.Size = new System.Drawing.Size(127, 22);
            this.txtWidgetName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Widget Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtWidgetPrice
            // 
            this.txtWidgetPrice.Location = new System.Drawing.Point(215, 117);
            this.txtWidgetPrice.Name = "txtWidgetPrice";
            this.txtWidgetPrice.Size = new System.Drawing.Size(127, 22);
            this.txtWidgetPrice.TabIndex = 3;
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 16;
            this.lstOut.Location = new System.Drawing.Point(90, 193);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(596, 132);
            this.lstOut.TabIndex = 4;
            this.lstOut.TabStop = false;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(90, 350);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(103, 73);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate &Price";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(342, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 73);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(597, 350);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(103, 73);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.txtWidgetPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWidgetName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Islam_Demo_SP24";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWidgetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidgetPrice;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
    }
}

