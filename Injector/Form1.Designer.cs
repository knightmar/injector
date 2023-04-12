namespace Injector
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
            this.inject_button = new System.Windows.Forms.Button();
            this.program_to_inject = new System.Windows.Forms.ComboBox();
            this.select_dll_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inject_button
            // 
            this.inject_button.Location = new System.Drawing.Point(291, 363);
            this.inject_button.Name = "inject_button";
            this.inject_button.Size = new System.Drawing.Size(240, 25);
            this.inject_button.TabIndex = 1;
            this.inject_button.Text = "Inject";
            this.inject_button.UseVisualStyleBackColor = true;
            this.inject_button.Click += new System.EventHandler(this.inject_button_Click);
            // 
            // program_to_inject
            // 
            this.program_to_inject.FormattingEnabled = true;
            this.program_to_inject.Location = new System.Drawing.Point(45, 132);
            this.program_to_inject.Name = "program_to_inject";
            this.program_to_inject.Size = new System.Drawing.Size(240, 24);
            this.program_to_inject.TabIndex = 2;
            this.program_to_inject.Text = "Program to inject";
            this.program_to_inject.SelectedIndexChanged += new System.EventHandler(this.program_to_inject_SelectedIndexChanged);
            // 
            // select_dll_button
            // 
            this.select_dll_button.Location = new System.Drawing.Point(453, 134);
            this.select_dll_button.Name = "select_dll_button";
            this.select_dll_button.Size = new System.Drawing.Size(240, 25);
            this.select_dll_button.TabIndex = 3;
            this.select_dll_button.Text = "Select DLL to inject";
            this.select_dll_button.UseVisualStyleBackColor = true;
            this.select_dll_button.Click += new System.EventHandler(this.select_dll_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(292, 134);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(71, 25);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.select_dll_button);
            this.Controls.Add(this.program_to_inject);
            this.Controls.Add(this.inject_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button refresh;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Button select_dll_button;

        private System.Windows.Forms.Button inject_button;

        private System.Windows.Forms.ComboBox program_to_inject;

        #endregion
    }
}