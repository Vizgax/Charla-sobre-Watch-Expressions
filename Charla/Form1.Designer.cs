namespace Charla
{
    partial class Escenario_1
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
            BTN_Cam = new Button();
            label1 = new Label();
            dgvEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // BTN_Cam
            // 
            BTN_Cam.Location = new Point(688, 415);
            BTN_Cam.Name = "BTN_Cam";
            BTN_Cam.Size = new Size(89, 23);
            BTN_Cam.TabIndex = 0;
            BTN_Cam.Text = "Escenario 2";
            BTN_Cam.UseVisualStyleBackColor = true;
            BTN_Cam.Click += BTN_Cam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 64);
            label1.TabIndex = 1;
            label1.Text = "Escenario 1:\r\nEstructuras y Datos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(12, 137);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(776, 243);
            dgvEmpleados.TabIndex = 2;
            // 
            // Escenario_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEmpleados);
            Controls.Add(label1);
            Controls.Add(BTN_Cam);
            Name = "Escenario_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escenario 1";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_Cam;
        private Label label1;
        private DataGridView dgvEmpleados;
    }
}
