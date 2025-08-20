namespace UI
{
    partial class frmClient
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
            txtNombre = new TextBox();
            txtID = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(450, 171);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 31);
            txtNombre.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(97, 171);
            txtID.Name = "txtID";
            txtID.Size = new Size(261, 31);
            txtID.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(97, 288);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(261, 31);
            txtApellido.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 143);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 143);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 260);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 260);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(633, 378);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(462, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(txtID);
            Controls.Add(txtNombre);
            Name = "frmClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtID;
        private TextBox txtApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}