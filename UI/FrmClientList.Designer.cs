namespace UI
{
    partial class FrmClientList
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
            listClients = new ListView();
            columnID = new ColumnHeader();
            columnNombre = new ColumnHeader();
            columnApellido = new ColumnHeader();
            btnCrearClient = new Button();
            SuspendLayout();
            // 
            // listClients
            // 
            listClients.Columns.AddRange(new ColumnHeader[] { columnID, columnNombre, columnApellido });
            listClients.GridLines = true;
            listClients.Location = new Point(41, 194);
            listClients.Name = "listClients";
            listClients.Size = new Size(729, 208);
            listClients.TabIndex = 0;
            listClients.UseCompatibleStateImageBehavior = false;
            listClients.View = View.Details;
            // 
            // columnID
            // 
            columnID.Text = "ID";
            columnID.Width = 80;
            // 
            // columnNombre
            // 
            columnNombre.Text = "Nombre";
            columnNombre.Width = 160;
            // 
            // columnApellido
            // 
            columnApellido.Text = "Apellido";
            columnApellido.Width = 160;
            // 
            // btnCrearClient
            // 
            btnCrearClient.Location = new Point(658, 63);
            btnCrearClient.Name = "btnCrearClient";
            btnCrearClient.Size = new Size(112, 34);
            btnCrearClient.TabIndex = 1;
            btnCrearClient.Text = "Nuevo";
            btnCrearClient.UseVisualStyleBackColor = true;
            btnCrearClient.Click += btnCrearClient_Click;
            // 
            // FrmClientList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 450);
            Controls.Add(btnCrearClient);
            Controls.Add(listClients);
            Name = "FrmClientList";
            Text = "FrmClientList";
            ResumeLayout(false);
        }

        #endregion

        private ListView listClients;
        private ColumnHeader columnID;
        private ColumnHeader columnNombre;
        private ColumnHeader columnApellido;
        private Button btnCrearClient;
    }
}