namespace clinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            entrar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(250, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(722, 522);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // entrar
            // 
            entrar.BackColor = Color.FromArgb(188, 204, 220);
            entrar.FlatStyle = FlatStyle.Popup;
            entrar.ForeColor = Color.Black;
            entrar.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            entrar.IconColor = Color.Black;
            entrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            entrar.ImageAlign = ContentAlignment.MiddleLeft;
            entrar.Location = new Point(527, 567);
            entrar.Margin = new Padding(3, 4, 3, 4);
            entrar.Name = "entrar";
            entrar.Padding = new Padding(6, 0, 0, 0);
            entrar.Size = new Size(182, 65);
            entrar.TabIndex = 1;
            entrar.Text = "Entrar";
            entrar.UseVisualStyleBackColor = false;
            entrar.Click += entrar_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(188, 204, 220);
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(527, 669);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(6, 0, 0, 0);
            iconButton1.Size = new Size(182, 65);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Salir";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 42, 67);
            ClientSize = new Size(1217, 859);
            Controls.Add(iconButton1);
            Controls.Add(entrar);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton entrar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}