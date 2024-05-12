namespace Project1_Paint_TU
{
    partial class Bgr
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
        [Obsolete("Obsolete")]
        private void InitializeComponent()
        {
            pl1 = new Panel();
            panel1 = new Panel();
            button_circle = new Button();
            button_ellipse = new Button();
            button_triangle = new Button();
            panel2 = new Panel();
            button_load = new Button();
            button_clear = new Button();
            button_rectangle = new Button();
            button_square = new Button();
            button_save = new Button();
            bgr_main = new PictureBox();
            pl1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bgr_main).BeginInit();
            SuspendLayout();
            // 
            // pl1
            // 
            pl1.BackColor = SystemColors.ActiveCaption;
            pl1.Controls.Add(panel1);
            pl1.Location = new Point(2, 2);
            pl1.Margin = new Padding(3, 2, 3, 2);
            pl1.Name = "pl1";
            pl1.Size = new Size(682, 76);
            pl1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(button_circle);
            panel1.Controls.Add(button_ellipse);
            panel1.Controls.Add(button_square);
            panel1.Controls.Add(button_rectangle);
            panel1.Controls.Add(button_triangle);
            panel1.Location = new Point(112, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 71);
            panel1.TabIndex = 2;
            // 
            // button_circle
            // 
            button_circle.BackColor = SystemColors.GradientInactiveCaption;
            button_circle.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button_circle.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            button_circle.FlatStyle = FlatStyle.Flat;
            button_circle.ForeColor = Color.Black;
            button_circle.Image = Properties.Resources.circle;
            button_circle.ImageAlign = ContentAlignment.TopCenter;
            button_circle.Location = new Point(123, 16);
            button_circle.Margin = new Padding(3, 2, 3, 2);
            button_circle.Name = "button_circle";
            button_circle.Size = new Size(50, 50);
            button_circle.TabIndex = 6;
            button_circle.UseVisualStyleBackColor = false;
            button_circle.Click += Button_circle_Click;
            // 
            // button_ellipse
            // 
            button_ellipse.BackColor = SystemColors.GradientInactiveCaption;
            button_ellipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button_ellipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            button_ellipse.FlatStyle = FlatStyle.Flat;
            button_ellipse.ForeColor = Color.Black;
            button_ellipse.Image = Properties.Resources.ellipse;
            button_ellipse.Location = new Point(40, 16);
            button_ellipse.Margin = new Padding(3, 2, 3, 2);
            button_ellipse.Name = "button_ellipse";
            button_ellipse.Size = new Size(77, 50);
            button_ellipse.TabIndex = 5;
            button_ellipse.Text = "Ellipse";
            button_ellipse.UseVisualStyleBackColor = false;
            button_ellipse.Click += Button_ellipse_Click;
            // 
            // button_triangle
            // 
            button_triangle.BackColor = SystemColors.GradientInactiveCaption;
            button_triangle.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button_triangle.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            button_triangle.FlatStyle = FlatStyle.Flat;
            button_triangle.ForeColor = Color.Black;
            button_triangle.Image = Properties.Resources.triangle;
            button_triangle.Location = new Point(179, 16);
            button_triangle.Margin = new Padding(3, 2, 3, 2);
            button_triangle.Name = "button_triangle";
            button_triangle.Size = new Size(65, 50);
            button_triangle.TabIndex = 9;
            button_triangle.TextAlign = ContentAlignment.BottomCenter;
            button_triangle.UseVisualStyleBackColor = false;
            button_triangle.Click += Button_triangle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button_load);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_save);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 353);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 24);
            panel2.TabIndex = 2;
            // 
            // button_load
            // 
            button_load.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_load.Location = new Point(513, 0);
            button_load.Name = "button_load";
            button_load.Size = new Size(75, 24);
            button_load.TabIndex = 12;
            button_load.Text = "Load";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += Button_load_Click;
            // 
            // button_clear
            // 
            button_clear.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_clear.Location = new Point(594, 0);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 24);
            button_clear.TabIndex = 11;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += Button1_Click;
            // 
            // button_rectangle
            // 
            button_rectangle.BackColor = SystemColors.GradientInactiveCaption;
            button_rectangle.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button_rectangle.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            button_rectangle.FlatStyle = FlatStyle.Flat;
            button_rectangle.ForeColor = Color.Black;
            button_rectangle.Image = Properties.Resources.square;
            button_rectangle.Location = new Point(250, 17);
            button_rectangle.Margin = new Padding(3, 2, 3, 2);
            button_rectangle.Name = "button_rectangle";
            button_rectangle.Size = new Size(65, 49);
            button_rectangle.TabIndex = 10;
            button_rectangle.TextAlign = ContentAlignment.BottomCenter;
            button_rectangle.UseVisualStyleBackColor = false;
            button_rectangle.Click += Button_rectangle_Click;
            // 
            // button_square
            // 
            button_square.BackColor = SystemColors.GradientInactiveCaption;
            button_square.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button_square.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            button_square.FlatStyle = FlatStyle.Flat;
            button_square.ForeColor = Color.Black;
            button_square.Image = Properties.Resources.rectangle;
            button_square.Location = new Point(321, 17);
            button_square.Margin = new Padding(3, 2, 3, 2);
            button_square.Name = "button_square";
            button_square.Size = new Size(65, 49);
            button_square.TabIndex = 10;
            button_square.TextAlign = ContentAlignment.BottomCenter;
            button_square.UseVisualStyleBackColor = false;
            button_square.Click += Button_square_Click;
            // 
            // button_save
            // 
            button_save.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_save.Location = new Point(432, 0);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 24);
            button_save.TabIndex = 3;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += Button_save_Click;
            // 
            // bgr_main
            // 
            bgr_main.BackColor = Color.White;
            bgr_main.Dock = DockStyle.Bottom;
            bgr_main.Location = new Point(0, 83);
            bgr_main.Name = "bgr_main";
            bgr_main.Size = new Size(684, 270);
            bgr_main.SizeMode = PictureBoxSizeMode.StretchImage;
            bgr_main.TabIndex = 3;
            bgr_main.TabStop = false;
            bgr_main.MouseDoubleClick += Bgr_Main_MouseDoubleClick;
            bgr_main.MouseDown += Bgr_main_MouseDown;
            bgr_main.MouseMove += Bgr_main_MouseMove;
            bgr_main.MouseUp += Bgr_main_MouseUp;
            // 
            // Bgr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 377);
            Controls.Add(bgr_main);
            Controls.Add(panel2);
            Controls.Add(pl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Bgr";
            Text = "Paint";
            KeyDown += Bgr_KeyDown;
            pl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bgr_main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pl1;
        private Button button_circle;
        private Panel panel1;
        private Button button_ellipse;
        private Panel panel2;
        private Button button_save;
        private Button button_rectangle;
        private Button button_square;
        private Button button_triangle;
        private Button button_clear;
        private PictureBox bgr_main;
        private Button button_load;
    }
}