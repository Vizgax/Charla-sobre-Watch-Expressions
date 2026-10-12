namespace Charla
{
    partial class Escenario_3
    {
        /// <summary>
        /// Variable de diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
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
            lblTitulo1 = new Label();
            lblTitulo2 = new Label();
            lblSalarioMinimo = new Label();
            btnCargarConfig = new Button();
            btnFiltrar = new Button();
            dgvFiltrados = new DataGridView();
            BTN_Cam1 = new Button();
            BTN_Cam2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFiltrados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Segoe UI", 15.75F);
            lblTitulo1.Location = new Point(280, 20);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(123, 30);
            lblTitulo1.TabIndex = 0;
            lblTitulo1.Text = "Escenario 3:";
            lblTitulo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 15.75F);
            lblTitulo2.Location = new Point(190, 55);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(359, 30);
            lblTitulo2.TabIndex = 1;
            lblTitulo2.Text = "Calidad y Seguridad / Mantenimiento";
            lblTitulo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSalarioMinimo
            // 
            lblSalarioMinimo.AutoSize = true;
            lblSalarioMinimo.Font = new Font("Segoe UI", 10F);
            lblSalarioMinimo.Location = new Point(60, 120);
            lblSalarioMinimo.Name = "lblSalarioMinimo";
            lblSalarioMinimo.Size = new Size(170, 19);
            lblSalarioMinimo.TabIndex = 2;
            lblSalarioMinimo.Text = "Salario mínimo actual: 500";
            // 
            // btnCargarConfig
            // 
            btnCargarConfig.Location = new Point(60, 160);
            btnCargarConfig.Name = "btnCargarConfig";
            btnCargarConfig.Size = new Size(180, 30);
            btnCargarConfig.TabIndex = 3;
            btnCargarConfig.Text = "Cargar Configuración";
            btnCargarConfig.UseVisualStyleBackColor = true;
            btnCargarConfig.Click += btnCargarConfig_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(260, 160);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(180, 30);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar Empleados";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dgvFiltrados
            // 
            dgvFiltrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFiltrados.Location = new Point(60, 210);
            dgvFiltrados.Name = "dgvFiltrados";
            dgvFiltrados.Size = new Size(650, 200);
            dgvFiltrados.TabIndex = 5;
            // 
            // BTN_Cam1
            // 
            BTN_Cam1.Location = new Point(20, 430);
            BTN_Cam1.Name = "BTN_Cam1";
            BTN_Cam1.Size = new Size(110, 30);
            BTN_Cam1.TabIndex = 6;
            BTN_Cam1.Text = "Escenario 1";
            BTN_Cam1.UseVisualStyleBackColor = true;
            BTN_Cam1.Click += BTN_Cam1_Click;
            // 
            // BTN_Cam2
            // 
            BTN_Cam2.Location = new Point(590, 430);
            BTN_Cam2.Name = "BTN_Cam2";
            BTN_Cam2.Size = new Size(110, 30);
            BTN_Cam2.TabIndex = 7;
            BTN_Cam2.Text = "Escenario 2";
            BTN_Cam2.UseVisualStyleBackColor = true;
            BTN_Cam2.Click += BTN_Cam2_Click;
            // 
            // Escenario_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 481);
            Controls.Add(BTN_Cam2);
            Controls.Add(BTN_Cam1);
            Controls.Add(dgvFiltrados);
            Controls.Add(btnFiltrar);
            Controls.Add(btnCargarConfig);
            Controls.Add(lblSalarioMinimo);
            Controls.Add(lblTitulo2);
            Controls.Add(lblTitulo1);
            Name = "Escenario_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escenario 3";
            ((System.ComponentModel.ISupportInitialize)dgvFiltrados).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblSalarioMinimo;
        private System.Windows.Forms.Button btnCargarConfig;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvFiltrados;
        private System.Windows.Forms.Button BTN_Cam1;
        private System.Windows.Forms.Button BTN_Cam2;
    }
}