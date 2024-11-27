namespace paint
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
            navpanel = new Panel();
            clearbtn = new Button();
            eraserbtn = new Button();
            groupBox2 = new GroupBox();
            mediumbtn = new RadioButton();
            largebtn = new RadioButton();
            smallbtn = new RadioButton();
            groupBox1 = new GroupBox();
            blackbtn = new RadioButton();
            bluebtn = new RadioButton();
            greenbtn = new RadioButton();
            redbtn = new RadioButton();
            drawingpanel = new Panel();
            navpanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // navpanel
            // 
            navpanel.BackColor = Color.Azure;
            navpanel.Controls.Add(clearbtn);
            navpanel.Controls.Add(eraserbtn);
            navpanel.Controls.Add(groupBox2);
            navpanel.Controls.Add(groupBox1);
            navpanel.Dock = DockStyle.Left;
            navpanel.Location = new Point(0, 0);
            navpanel.Name = "navpanel";
            navpanel.Size = new Size(106, 450);
            navpanel.TabIndex = 0;
            // 
            // clearbtn
            // 
            clearbtn.FlatStyle = FlatStyle.Flat;
            clearbtn.Location = new Point(5, 415);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(54, 23);
            clearbtn.TabIndex = 3;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // eraserbtn
            // 
            eraserbtn.FlatStyle = FlatStyle.Flat;
            eraserbtn.Location = new Point(5, 320);
            eraserbtn.Name = "eraserbtn";
            eraserbtn.Size = new Size(54, 23);
            eraserbtn.TabIndex = 2;
            eraserbtn.Text = "Eraser";
            eraserbtn.UseVisualStyleBackColor = true;
            eraserbtn.Click += eraserbtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mediumbtn);
            groupBox2.Controls.Add(largebtn);
            groupBox2.Controls.Add(smallbtn);
            groupBox2.Location = new Point(2, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(103, 136);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Size";
            // 
            // mediumbtn
            // 
            mediumbtn.AutoSize = true;
            mediumbtn.Location = new Point(3, 44);
            mediumbtn.Name = "mediumbtn";
            mediumbtn.Size = new Size(70, 19);
            mediumbtn.TabIndex = 3;
            mediumbtn.TabStop = true;
            mediumbtn.Text = "Medium";
            mediumbtn.UseVisualStyleBackColor = true;
            mediumbtn.CheckedChanged += mediumbtn_CheckedChanged;
            // 
            // largebtn
            // 
            largebtn.AutoSize = true;
            largebtn.Location = new Point(3, 69);
            largebtn.Name = "largebtn";
            largebtn.Size = new Size(54, 19);
            largebtn.TabIndex = 2;
            largebtn.TabStop = true;
            largebtn.Text = "Large";
            largebtn.UseVisualStyleBackColor = true;
            largebtn.CheckedChanged += largebtn_CheckedChanged;
            // 
            // smallbtn
            // 
            smallbtn.AutoSize = true;
            smallbtn.Location = new Point(3, 19);
            smallbtn.Name = "smallbtn";
            smallbtn.Size = new Size(54, 19);
            smallbtn.TabIndex = 0;
            smallbtn.TabStop = true;
            smallbtn.Text = "Small";
            smallbtn.UseVisualStyleBackColor = true;
            smallbtn.CheckedChanged += smallbtn_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(blackbtn);
            groupBox1.Controls.Add(bluebtn);
            groupBox1.Controls.Add(greenbtn);
            groupBox1.Controls.Add(redbtn);
            groupBox1.Location = new Point(0, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(103, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // blackbtn
            // 
            blackbtn.AutoSize = true;
            blackbtn.Location = new Point(3, 94);
            blackbtn.Name = "blackbtn";
            blackbtn.Size = new Size(53, 19);
            blackbtn.TabIndex = 4;
            blackbtn.TabStop = true;
            blackbtn.Text = "Black";
            blackbtn.UseVisualStyleBackColor = true;
            blackbtn.CheckedChanged += blackbtn_CheckedChanged;
            // 
            // bluebtn
            // 
            bluebtn.AutoSize = true;
            bluebtn.Location = new Point(3, 44);
            bluebtn.Name = "bluebtn";
            bluebtn.Size = new Size(48, 19);
            bluebtn.TabIndex = 3;
            bluebtn.TabStop = true;
            bluebtn.Text = "Blue";
            bluebtn.UseVisualStyleBackColor = true;
            bluebtn.CheckedChanged += bluebtn_CheckedChanged;
            // 
            // greenbtn
            // 
            greenbtn.AutoSize = true;
            greenbtn.Location = new Point(3, 69);
            greenbtn.Name = "greenbtn";
            greenbtn.Size = new Size(56, 19);
            greenbtn.TabIndex = 2;
            greenbtn.TabStop = true;
            greenbtn.Text = "Green";
            greenbtn.UseVisualStyleBackColor = true;
            greenbtn.CheckedChanged += greenbtn_CheckedChanged;
            // 
            // redbtn
            // 
            redbtn.AutoSize = true;
            redbtn.Location = new Point(3, 19);
            redbtn.Name = "redbtn";
            redbtn.Size = new Size(45, 19);
            redbtn.TabIndex = 0;
            redbtn.TabStop = true;
            redbtn.Text = "Red";
            redbtn.UseVisualStyleBackColor = true;
            redbtn.CheckedChanged += redbtn_CheckedChanged;
            // 
            // drawingpanel
            // 
            drawingpanel.BackColor = Color.White;
            drawingpanel.Cursor = Cursors.PanNW;
            drawingpanel.Dock = DockStyle.Fill;
            drawingpanel.Location = new Point(106, 0);
            drawingpanel.Name = "drawingpanel";
            drawingpanel.Size = new Size(694, 450);
            drawingpanel.TabIndex = 1;
            drawingpanel.MouseDown += drowingpanel_MouseDown;
            drawingpanel.MouseMove += drowingpanel_MouseMove;
            drawingpanel.MouseUp += drowingpanel_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(drawingpanel);
            Controls.Add(navpanel);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            navpanel.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navpanel;
        private GroupBox groupBox1;
        private RadioButton redbtn;
        private Panel drawingpanel;
        private RadioButton bluebtn;
        private RadioButton greenbtn;
        private GroupBox groupBox2;
        private RadioButton mediumbtn;
        private RadioButton largebtn;
        private RadioButton smallbtn;
        private RadioButton blackbtn;
        private Button clearbtn;
        private Button eraserbtn;
    }
}
