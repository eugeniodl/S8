namespace GenericValidationApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput1 = new TextBox();
            txtInput2 = new TextBox();
            btnValidate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(61, 78);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(125, 27);
            txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(278, 78);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(125, 27);
            txtInput2.TabIndex = 1;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(500, 78);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(94, 29);
            btnValidate.TabIndex = 2;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(61, 154);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 220);
            Controls.Add(lblResult);
            Controls.Add(btnValidate);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Name = "Form1";
            Text = "Generic Validate Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput1;
        private TextBox txtInput2;
        private Button btnValidate;
        private Label lblResult;
    }
}
