
namespace FomularioIngresoDatos
{
    partial class frmDatosPersonales
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosPersonales));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txbEdad = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(83, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE:";
            this.lblNombre.UseMnemonic = false;
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(218, 63);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(308, 31);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.Leave += new System.EventHandler(this.txbNombre_Leave);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellido.Location = new System.Drawing.Point(83, 27);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 23);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // txbApellido
            // 
            this.txbApellido.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido.Location = new System.Drawing.Point(218, 19);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(308, 31);
            this.txbApellido.TabIndex = 0;
            this.txbApellido.Leave += new System.EventHandler(this.txbApellido_Leave);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEdad.Location = new System.Drawing.Point(83, 110);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(62, 23);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "EDAD:";
            this.lblEdad.UseMnemonic = false;
            // 
            // txbEdad
            // 
            this.txbEdad.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEdad.Location = new System.Drawing.Point(218, 102);
            this.txbEdad.Name = "txbEdad";
            this.txbEdad.Size = new System.Drawing.Size(60, 31);
            this.txbEdad.TabIndex = 2;
            this.txbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEdad_KeyPress);
            this.txbEdad.Leave += new System.EventHandler(this.txbEdad_Leave);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDireccion.Location = new System.Drawing.Point(83, 152);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(109, 23);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "DIRECCIÓN:";
            this.lblDireccion.UseMnemonic = false;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(218, 144);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(308, 31);
            this.txbDireccion.TabIndex = 3;
            this.txbDireccion.Leave += new System.EventHandler(this.txbDireccion_Leave);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultado.Location = new System.Drawing.Point(83, 205);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(117, 23);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "RESULTADO:";
            this.lblResultado.UseMnemonic = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAceptar.Location = new System.Drawing.Point(126, 389);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(132, 39);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(360, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbResultado.Font = new System.Drawing.Font("Alef", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultado.Location = new System.Drawing.Point(87, 240);
            this.txbResultado.Multiline = true;
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(439, 124);
            this.txbResultado.TabIndex = 9;
            // 
            // frmDatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txbEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(632, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(632, 497);
            this.Name = "frmDatosPersonales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txbEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbResultado;
    }
}

