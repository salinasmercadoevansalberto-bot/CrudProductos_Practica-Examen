namespace CrudProductos_Practica_Examen.Forms
{
    partial class FormLogins
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
            C = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textUsuario = new TextBox();
            textContraña = new TextBox();
            button_Ini_Secion = new Button();
            buttonReg_Usuario = new Button();
            SuspendLayout();
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C.ForeColor = SystemColors.ControlText;
            C.Location = new Point(181, 9);
            C.Name = "C";
            C.Size = new Size(346, 37);
            C.TabIndex = 0;
            C.Text = "CRUD DE PRODUCTOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 59);
            label1.Name = "label1";
            label1.Size = new Size(275, 31);
            label1.TabIndex = 1;
            label1.Text = "Ingrese sus credenciales.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 99);
            label2.Name = "label2";
            label2.Size = new Size(239, 29);
            label2.TabIndex = 2;
            label2.Text = "Ingrese su Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 193);
            label3.Name = "label3";
            label3.Size = new Size(254, 29);
            label3.TabIndex = 3;
            label3.Text = "Ingrese su Contraña:";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(54, 147);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(433, 27);
            textUsuario.TabIndex = 4;
            // 
            // textContraña
            // 
            textContraña.Location = new Point(54, 244);
            textContraña.Name = "textContraña";
            textContraña.Size = new Size(433, 27);
            textContraña.TabIndex = 5;
            // 
            // button_Ini_Secion
            // 
            button_Ini_Secion.BackColor = SystemColors.ActiveCaption;
            button_Ini_Secion.Location = new Point(55, 337);
            button_Ini_Secion.Name = "button_Ini_Secion";
            button_Ini_Secion.Size = new Size(185, 38);
            button_Ini_Secion.TabIndex = 6;
            button_Ini_Secion.Text = "Iniciar Secion.";
            button_Ini_Secion.UseVisualStyleBackColor = false;
            // 
            // buttonReg_Usuario
            // 
            buttonReg_Usuario.BackColor = SystemColors.ActiveCaption;
            buttonReg_Usuario.Location = new Point(376, 337);
            buttonReg_Usuario.Name = "buttonReg_Usuario";
            buttonReg_Usuario.Size = new Size(185, 38);
            buttonReg_Usuario.TabIndex = 7;
            buttonReg_Usuario.Text = "Registrar Usuario";
            buttonReg_Usuario.UseVisualStyleBackColor = false;
            // 
            // FormLogins
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonReg_Usuario);
            Controls.Add(button_Ini_Secion);
            Controls.Add(textContraña);
            Controls.Add(textUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(C);
            Name = "FormLogins";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label C;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textUsuario;
        private TextBox textContraña;
        private Button button_Ini_Secion;
        private Button buttonReg_Usuario;
    }
}