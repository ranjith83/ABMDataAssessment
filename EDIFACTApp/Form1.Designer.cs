namespace EDIFACTApp
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
            this.btRefText = new System.Windows.Forms.Button();
            this.btEDIFACT = new System.Windows.Forms.Button();
            this.btPayloadXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRefText
            // 
            this.btRefText.Location = new System.Drawing.Point(350, 152);
            this.btRefText.Name = "btRefText";
            this.btRefText.Size = new System.Drawing.Size(171, 23);
            this.btRefText.TabIndex = 1;
            this.btRefText.Text = "Get RefText Valule - Question 2";
            this.btRefText.UseVisualStyleBackColor = true;
            this.btRefText.Click += new System.EventHandler(this.btRefText_Click);
            // 
            // btEDIFACT
            // 
            this.btEDIFACT.Location = new System.Drawing.Point(350, 89);
            this.btEDIFACT.Name = "btEDIFACT";
            this.btEDIFACT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btEDIFACT.Size = new System.Drawing.Size(218, 23);
            this.btEDIFACT.TabIndex = 2;
            this.btEDIFACT.Text = "Get EDIFACT Message - Question 1";
            this.btEDIFACT.UseVisualStyleBackColor = true;
            this.btEDIFACT.Click += new System.EventHandler(this.btEDIFACT_Click);
            // 
            // btPayloadXML
            // 
            this.btPayloadXML.Location = new System.Drawing.Point(350, 221);
            this.btPayloadXML.Name = "btPayloadXML";
            this.btPayloadXML.Size = new System.Drawing.Size(188, 23);
            this.btPayloadXML.TabIndex = 3;
            this.btPayloadXML.Text = "PayloadXML - Question 3";
            this.btPayloadXML.UseVisualStyleBackColor = true;
            this.btPayloadXML.Click += new System.EventHandler(this.btPayloadXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPayloadXML);
            this.Controls.Add(this.btEDIFACT);
            this.Controls.Add(this.btRefText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btRefText;
        private System.Windows.Forms.Button btEDIFACT;
        private System.Windows.Forms.Button btPayloadXML;
    }
}

