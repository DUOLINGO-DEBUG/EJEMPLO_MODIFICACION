namespace PRUEB_ANTES_DE_EXAMEN
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_enviar_formulario = new Button();
            numeric_edad_estidante = new NumericUpDown();
            textbox_nombre_estudiante = new TextBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            btn_cargar_datos = new Button();
            tabla_estudiante = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_edad_estidante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_estudiante).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(29, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(698, 373);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_enviar_formulario);
            tabPage1.Controls.Add(numeric_edad_estidante);
            tabPage1.Controls.Add(textbox_nombre_estudiante);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(690, 340);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pestaña 01";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_enviar_formulario
            // 
            btn_enviar_formulario.Location = new Point(127, 211);
            btn_enviar_formulario.Name = "btn_enviar_formulario";
            btn_enviar_formulario.Size = new Size(482, 29);
            btn_enviar_formulario.TabIndex = 6;
            btn_enviar_formulario.Text = "ENVIAR FORMULARIO";
            btn_enviar_formulario.UseVisualStyleBackColor = true;
            btn_enviar_formulario.Click += btn_enviar_formulario_Click;
            // 
            // numeric_edad_estidante
            // 
            numeric_edad_estidante.Location = new Point(296, 162);
            numeric_edad_estidante.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numeric_edad_estidante.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            numeric_edad_estidante.Name = "numeric_edad_estidante";
            numeric_edad_estidante.Size = new Size(150, 27);
            numeric_edad_estidante.TabIndex = 5;
            numeric_edad_estidante.Tag = "";
            numeric_edad_estidante.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // textbox_nombre_estudiante
            // 
            textbox_nombre_estudiante.Location = new Point(295, 129);
            textbox_nombre_estudiante.Name = "textbox_nombre_estudiante";
            textbox_nombre_estudiante.Size = new Size(314, 27);
            textbox_nombre_estudiante.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 162);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 3;
            label4.Text = "Edad del Estudiante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 129);
            label3.Name = "label3";
            label3.Size = new Size(162, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre del Estudiante";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Banner_CCFL_6_00001;
            pictureBox1.Location = new Point(281, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_cargar_datos);
            tabPage2.Controls.Add(tabla_estudiante);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(690, 340);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pestaña 02";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cargar_datos
            // 
            btn_cargar_datos.Location = new Point(17, 16);
            btn_cargar_datos.Name = "btn_cargar_datos";
            btn_cargar_datos.Size = new Size(151, 29);
            btn_cargar_datos.TabIndex = 2;
            btn_cargar_datos.Text = "Cargar Datos";
            btn_cargar_datos.UseVisualStyleBackColor = true;
            btn_cargar_datos.Click += btn_cargar_datos_Click;
            // 
            // tabla_estudiante
            // 
            tabla_estudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_estudiante.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            tabla_estudiante.Location = new Point(17, 64);
            tabla_estudiante.Name = "tabla_estudiante";
            tabla_estudiante.RowHeadersWidth = 51;
            tabla_estudiante.Size = new Size(645, 188);
            tabla_estudiante.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_edad_estidante).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabla_estudiante).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private NumericUpDown numeric_edad_estidante;
        private TextBox textbox_nombre_estudiante;
        private Label label4;
        private Label label3;
        private Button btn_enviar_formulario;
        private DataGridView tabla_estudiante;
        private DataGridViewTextBoxColumn Column1;
        private Button btn_cargar_datos;
    }
}
