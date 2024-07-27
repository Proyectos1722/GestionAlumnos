namespace GUI
{
    partial class FrmGestionAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionAlumnos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.bntNUEVO = new System.Windows.Forms.Button();
            this.bntELIMINAR = new System.Windows.Forms.Button();
            this.bntGUARDAR = new System.Windows.Forms.Button();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.txtPrecedencia = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbxComboCiuda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 177);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBUSCAR.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCAR.Location = new System.Drawing.Point(434, 256);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(122, 20);
            this.btnBUSCAR.TabIndex = 38;
            this.btnBUSCAR.Text = "&BUSCAR";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // bntNUEVO
            // 
            this.bntNUEVO.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNUEVO.Location = new System.Drawing.Point(645, 170);
            this.bntNUEVO.Name = "bntNUEVO";
            this.bntNUEVO.Size = new System.Drawing.Size(101, 41);
            this.bntNUEVO.TabIndex = 37;
            this.bntNUEVO.Text = "&NUEVO";
            this.bntNUEVO.UseVisualStyleBackColor = true;
            this.bntNUEVO.Click += new System.EventHandler(this.bntNUEVO_Click);
            // 
            // bntELIMINAR
            // 
            this.bntELIMINAR.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntELIMINAR.Location = new System.Drawing.Point(489, 170);
            this.bntELIMINAR.Name = "bntELIMINAR";
            this.bntELIMINAR.Size = new System.Drawing.Size(122, 41);
            this.bntELIMINAR.TabIndex = 36;
            this.bntELIMINAR.Text = "&ELIMINAR";
            this.bntELIMINAR.UseVisualStyleBackColor = true;
            this.bntELIMINAR.Click += new System.EventHandler(this.bntELIMINAR_Click);
            // 
            // bntGUARDAR
            // 
            this.bntGUARDAR.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntGUARDAR.Location = new System.Drawing.Point(333, 173);
            this.bntGUARDAR.Name = "bntGUARDAR";
            this.bntGUARDAR.Size = new System.Drawing.Size(118, 41);
            this.bntGUARDAR.TabIndex = 35;
            this.bntGUARDAR.Text = "&GUARDAR";
            this.bntGUARDAR.UseVisualStyleBackColor = true;
            this.bntGUARDAR.Click += new System.EventHandler(this.bntGUARDAR_Click);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(15, 256);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(413, 20);
            this.txtCriterio.TabIndex = 34;
            this.txtCriterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCriterio_KeyPress);
            // 
            // txtPrecedencia
            // 
            this.txtPrecedencia.Location = new System.Drawing.Point(476, 139);
            this.txtPrecedencia.Name = "txtPrecedencia";
            this.txtPrecedencia.Size = new System.Drawing.Size(270, 20);
            this.txtPrecedencia.TabIndex = 33;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(476, 109);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(270, 20);
            this.txtEdad.TabIndex = 32;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(104, 181);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(205, 20);
            this.txtNacionalidad.TabIndex = 30;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 149);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(205, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(104, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(205, 20);
            this.txtID.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "&Procedencia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "&Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "&Nacionalidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "&Fecha de Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "&Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "&Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "&ID:";
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(476, 76);
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(270, 20);
            this.txtFechaDeNacimiento.TabIndex = 40;
            // 
            // cbxComboCiuda
            // 
            this.cbxComboCiuda.FormattingEnabled = true;
            this.cbxComboCiuda.Location = new System.Drawing.Point(104, 212);
            this.cbxComboCiuda.Name = "cbxComboCiuda";
            this.cbxComboCiuda.Size = new System.Drawing.Size(205, 21);
            this.cbxComboCiuda.TabIndex = 41;
            this.cbxComboCiuda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "&Ciudad:";
            // 
            // FrmGestionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(758, 471);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxComboCiuda);
            this.Controls.Add(this.txtFechaDeNacimiento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.bntNUEVO);
            this.Controls.Add(this.bntELIMINAR);
            this.Controls.Add(this.bntGUARDAR);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.txtPrecedencia);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionAlumnos";
            this.Text = "GestionAlumnos";
            this.Load += new System.EventHandler(this.FrmGestionAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button bntNUEVO;
        private System.Windows.Forms.Button bntELIMINAR;
        private System.Windows.Forms.Button bntGUARDAR;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.TextBox txtPrecedencia;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtFechaDeNacimiento;
        private System.Windows.Forms.ComboBox cbxComboCiuda;
        private System.Windows.Forms.Label label8;
    }
}

