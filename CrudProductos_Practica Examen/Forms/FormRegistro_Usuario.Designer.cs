namespace CrudProductos_Practica_Examen.Forms
{
    partial class FormRegistro_Usuario
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
            components = new System.ComponentModel.Container();
            C = new Label();
            label2 = new Label();
            label3 = new Label();
            textUsuario = new TextBox();
            textContraña = new TextBox();
            button_Cancelar = new Button();
            buttonReg_Usuario = new Button();
            textConfirmar_C = new TextBox();
            label4 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
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
            label3.Location = new Point(55, 177);
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
            textUsuario.TextChanged += textUsuario_TextChanged;
            // 
            // textContraña
            // 
            textContraña.Location = new Point(55, 209);
            textContraña.Name = "textContraña";
            textContraña.Size = new Size(433, 27);
            textContraña.TabIndex = 5;
            // 
            // button_Cancelar
            // 
            button_Cancelar.BackColor = Color.Red;
            button_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Cancelar.ForeColor = SystemColors.ActiveCaption;
            button_Cancelar.Location = new Point(55, 337);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(185, 38);
            button_Cancelar.TabIndex = 6;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = false;
            button_Cancelar.Click += button_Cancelar_Click;
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
            buttonReg_Usuario.Click += buttonReg_Usuario_Click;
            // 
            // textConfirmar_C
            // 
            textConfirmar_C.Location = new Point(54, 272);
            textConfirmar_C.Name = "textConfirmar_C";
            textConfirmar_C.Size = new Size(433, 27);
            textConfirmar_C.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 239);
            label4.Name = "label4";
            label4.Size = new Size(272, 29);
            label4.TabIndex = 9;
            label4.Text = "Confirme su Contraña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 59);
            label1.Name = "label1";
            label1.Size = new Size(230, 31);
            label1.TabIndex = 1;
            label1.Text = "Registro de Usuario.";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // FormRegistro_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textConfirmar_C);
            Controls.Add(buttonReg_Usuario);
            Controls.Add(button_Cancelar);
            Controls.Add(textContraña);
            Controls.Add(textUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(C);
            Name = "FormRegistro_Usuario";
            Text = "Registro de Usuario";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label C;
        private Label label2;
        private Label label3;
        private TextBox textUsuario;
        private TextBox textContraña;
        private Button button_Cancelar;
        private Button buttonReg_Usuario;
        private TextBox textConfirmar_C;
        private Label label4;
        private Label label1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}