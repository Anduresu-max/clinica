namespace clinica
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            regresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_clinica;
            pictureBox1.Location = new Point(253, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(612, 521);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(188, 204, 220);
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.ForeColor = Color.DarkGreen;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            iconButton1.IconColor = Color.DarkGreen;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(63, 612);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(6, 0, 0, 0);
            iconButton1.Size = new Size(162, 87);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Agregar";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(188, 204, 220);
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.ForeColor = Color.Moccasin;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton2.IconColor = Color.NavajoWhite;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(489, 612);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(6, 0, 0, 0);
            iconButton2.Size = new Size(162, 87);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Buscar";
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(188, 204, 220);
            iconButton3.FlatStyle = FlatStyle.Popup;
            iconButton3.ForeColor = Color.DarkRed;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            iconButton3.IconColor = Color.DarkRed;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(919, 612);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(6, 0, 0, 0);
            iconButton3.Size = new Size(162, 87);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "Eliminar";
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // regresar
            // 
            regresar.Cursor = Cursors.Hand;
            regresar.FlatStyle = FlatStyle.Flat;
            regresar.IconChar = FontAwesome.Sharp.IconChar.Backward;
            regresar.IconColor = Color.Black;
            regresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            regresar.Location = new Point(14, 16);
            regresar.Margin = new Padding(3, 4, 3, 4);
            regresar.Name = "regresar";
            regresar.Size = new Size(54, 53);
            regresar.TabIndex = 4;
            regresar.TextAlign = ContentAlignment.BottomCenter;
            regresar.UseVisualStyleBackColor = true;
            regresar.Click += regresar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 42, 67);
            ClientSize = new Size(1146, 853);
            Controls.Add(regresar);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton regresar;
    }
}