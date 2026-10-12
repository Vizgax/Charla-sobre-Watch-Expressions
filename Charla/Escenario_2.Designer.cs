namespace Charla
{
    partial class Escenario_2
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
            BTN_Cam1 = new Button();
            BTN_Cam2 = new Button();
            label1 = new Label();
            TB_Nom = new TextBox();
            TB_Sal = new TextBox();
            BTN_Agregar = new Button();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // BTN_Cam1
            // 
            BTN_Cam1.Location = new Point(12, 415);
            BTN_Cam1.Name = "BTN_Cam1";
            BTN_Cam1.Size = new Size(95, 23);
            BTN_Cam1.TabIndex = 0;
            BTN_Cam1.Text = "Escenario 1";
            BTN_Cam1.UseVisualStyleBackColor = true;
            BTN_Cam1.Click += BTN_Cam1_Click;
            // 
            // BTN_Cam2
            // 
            BTN_Cam2.Location = new Point(693, 415);
            BTN_Cam2.Name = "BTN_Cam2";
            BTN_Cam2.Size = new Size(95, 23);
            BTN_Cam2.TabIndex = 1;
            BTN_Cam2.Text = "Escenario 3";
            BTN_Cam2.UseVisualStyleBackColor = true;
            BTN_Cam2.Click += BTN_Cam2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 64);
            label1.TabIndex = 2;
            label1.Text = "Escenario2:\r\nValidación y Robustez";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TB_Nom
            // 
            TB_Nom.Location = new Point(196, 187);
            TB_Nom.Name = "TB_Nom";
            TB_Nom.Size = new Size(100, 23);
            TB_Nom.TabIndex = 3;
            TB_Nom.KeyPress += TB_Nom_KeyPress;
            // 
            // TB_Sal
            // 
            TB_Sal.Location = new Point(501, 187);
            TB_Sal.Name = "TB_Sal";
            TB_Sal.Size = new Size(100, 23);
            TB_Sal.TabIndex = 4;
            TB_Sal.KeyPress += TB_Sal_KeyPress;
            // 
            // BTN_Agregar
            // 
            BTN_Agregar.Location = new Point(337, 252);
            BTN_Agregar.Name = "BTN_Agregar";
            BTN_Agregar.Size = new Size(125, 23);
            BTN_Agregar.TabIndex = 5;
            BTN_Agregar.Text = "Agregar Empleado";
            BTN_Agregar.UseVisualStyleBackColor = true;
            BTN_Agregar.Click += BTN_Agregar_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 169);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 169);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Salario";
            // 
            // Escenario_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BTN_Agregar);
            Controls.Add(TB_Sal);
            Controls.Add(TB_Nom);
            Controls.Add(label1);
            Controls.Add(BTN_Cam2);
            Controls.Add(BTN_Cam1);
            Name = "Escenario_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escenario 2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_Cam1;
        private Button BTN_Cam2;
        private Label label1;
        private TextBox TB_Nom;
        private TextBox TB_Sal;
        private Button BTN_Agregar;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label2;
    }
}