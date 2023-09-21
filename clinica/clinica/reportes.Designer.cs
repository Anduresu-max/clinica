namespace clinica
{
    partial class reportes
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
            dataGridViewBuscar = new DataGridView();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscarNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnMostrarTodos = new FontAwesome.Sharp.IconButton();
            regresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuscar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBuscar
            // 
            dataGridViewBuscar.BackgroundColor = Color.OldLace;
            dataGridViewBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuscar.Location = new Point(267, 10);
            dataGridViewBuscar.Name = "dataGridViewBuscar";
            dataGridViewBuscar.RowHeadersWidth = 51;
            dataGridViewBuscar.RowTemplate.Height = 25;
            dataGridViewBuscar.Size = new Size(539, 452);
            dataGridViewBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = SystemColors.MenuHighlight;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassChart;
            btnBuscar.IconColor = Color.ForestGreen;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(105, 127);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(57, 48);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(18, 100);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(222, 23);
            txtBuscarNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 70);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre del paciente que busca :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 215);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 6;
            label2.Text = "Mostar todos los pacientes:";
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.ForeColor = SystemColors.MenuHighlight;
            btnMostrarTodos.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnMostrarTodos.IconColor = Color.ForestGreen;
            btnMostrarTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarTodos.Location = new Point(105, 244);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(57, 44);
            btnMostrarTodos.TabIndex = 4;
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // regresar
            // 
            regresar.Cursor = Cursors.Hand;
            regresar.FlatStyle = FlatStyle.Flat;
            regresar.IconChar = FontAwesome.Sharp.IconChar.Backward;
            regresar.IconColor = Color.Black;
            regresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            regresar.Location = new Point(12, 405);
            regresar.Name = "regresar";
            regresar.Size = new Size(47, 40);
            regresar.TabIndex = 7;
            regresar.TextAlign = ContentAlignment.BottomCenter;
            regresar.UseVisualStyleBackColor = true;
            regresar.Click += regresar_Click_1;
            // 
            // reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 204, 220);
            ClientSize = new Size(808, 457);
            Controls.Add(regresar);
            Controls.Add(label2);
            Controls.Add(btnMostrarTodos);
            Controls.Add(label1);
            Controls.Add(txtBuscarNombre);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridViewBuscar);
            Name = "reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "reportes";
            Load += reportes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscarNombre;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnMostrarTodos;
        private FontAwesome.Sharp.IconButton regresar;
    }
}