namespace task6
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
            this.dllButton = new System.Windows.Forms.Button();
            this.comboBoxForClass = new System.Windows.Forms.ComboBox();
            this.classButton = new System.Windows.Forms.Button();
            this.comboBoxForMethod = new System.Windows.Forms.ComboBox();
            this.methodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dllButton
            // 
            this.dllButton.Location = new System.Drawing.Point(238, 11);
            this.dllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dllButton.Name = "dllButton";
            this.dllButton.Size = new System.Drawing.Size(165, 37);
            this.dllButton.TabIndex = 36;
            this.dllButton.Text = "Открыть библиотеку";
            this.dllButton.UseVisualStyleBackColor = true;
            this.dllButton.Click += new System.EventHandler(this.OpenLibrary);
            // 
            // comboBoxForClass
            // 
            this.comboBoxForClass.FormattingEnabled = true;
            this.comboBoxForClass.Location = new System.Drawing.Point(448, 61);
            this.comboBoxForClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxForClass.Name = "comboBoxForClass";
            this.comboBoxForClass.Size = new System.Drawing.Size(161, 24);
            this.comboBoxForClass.TabIndex = 37;
            this.comboBoxForClass.Visible = false;
            // 
            // classButton
            // 
            this.classButton.Location = new System.Drawing.Point(238, 57);
            this.classButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(165, 31);
            this.classButton.TabIndex = 38;
            this.classButton.Text = "Выбрать класс";
            this.classButton.UseVisualStyleBackColor = true;
            this.classButton.Visible = false;
            this.classButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // comboBoxForMethod
            // 
            this.comboBoxForMethod.FormattingEnabled = true;
            this.comboBoxForMethod.Location = new System.Drawing.Point(448, 100);
            this.comboBoxForMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxForMethod.Name = "comboBoxForMethod";
            this.comboBoxForMethod.Size = new System.Drawing.Size(161, 24);
            this.comboBoxForMethod.TabIndex = 39;
            this.comboBoxForMethod.Visible = false;
            // 
            // methodButton
            // 
            this.methodButton.Location = new System.Drawing.Point(238, 95);
            this.methodButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.methodButton.Name = "methodButton";
            this.methodButton.Size = new System.Drawing.Size(165, 32);
            this.methodButton.TabIndex = 40;
            this.methodButton.Text = "Выбрать метод";
            this.methodButton.UseVisualStyleBackColor = true;
            this.methodButton.Visible = false;
            this.methodButton.Click += new System.EventHandler(this.methodButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 474);
            this.Controls.Add(this.methodButton);
            this.Controls.Add(this.comboBoxForMethod);
            this.Controls.Add(this.classButton);
            this.Controls.Add(this.comboBoxForClass);
            this.Controls.Add(this.dllButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button dllButton;
        private System.Windows.Forms.ComboBox comboBoxForClass;
        private System.Windows.Forms.Button classButton;
        private System.Windows.Forms.ComboBox comboBoxForMethod;
        private System.Windows.Forms.Button methodButton;
    }
}