namespace App_WindowsForm
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
            Mensaje = new Button();
            label1 = new Label();
            text_nombre = new TextBox();
            SuspendLayout();
            // 
            // Mensaje
            // 
            Mensaje.Location = new Point(285, 221);
            Mensaje.Name = "Mensaje";
            Mensaje.Size = new Size(217, 48);
            Mensaje.TabIndex = 0;
            Mensaje.Text = "Aceptar";
            Mensaje.UseVisualStyleBackColor = true;
            Mensaje.Click += Mensaje_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 145);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingres su nombre";
            // 
            // text_nombre
            // 
            text_nombre.Location = new Point(285, 142);
            text_nombre.Name = "text_nombre";
            text_nombre.Size = new Size(278, 27);
            text_nombre.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(text_nombre);
            Controls.Add(label1);
            Controls.Add(Mensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Mensaje;
        private Label label1;
        private TextBox text_nombre;
    }
}