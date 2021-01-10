namespace _471_Stepanenko_Lab_3_4_5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dollar = new System.Windows.Forms.PictureBox();
            this.containerDollar = new System.Windows.Forms.PictureBox();
            this.factory = new System.Windows.Forms.PictureBox();
            this.ship = new System.Windows.Forms.PictureBox();
            this.containerFactory = new System.Windows.Forms.PictureBox();
            this.containerShip = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerShip)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dollar
            // 
            this.dollar.Image = ((System.Drawing.Image)(resources.GetObject("dollar.Image")));
            this.dollar.Location = new System.Drawing.Point(481, 511);
            this.dollar.Name = "dollar";
            this.dollar.Size = new System.Drawing.Size(199, 202);
            this.dollar.TabIndex = 2;
            this.dollar.TabStop = false;
            this.dollar.Tag = "Kolya";
            this.dollar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dollar_MouseDown);
            // 
            // containerDollar
            // 
            this.containerDollar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.containerDollar.Location = new System.Drawing.Point(80, 239);
            this.containerDollar.Name = "containerDollar";
            this.containerDollar.Size = new System.Drawing.Size(199, 202);
            this.containerDollar.TabIndex = 3;
            this.containerDollar.TabStop = false;
            this.containerDollar.DragDrop += new System.Windows.Forms.DragEventHandler(this.containerDollar_DragDrop);
            this.containerDollar.DragEnter += new System.Windows.Forms.DragEventHandler(this.containerDollar_DragEnter);
            // 
            // factory
            // 
            this.factory.Image = ((System.Drawing.Image)(resources.GetObject("factory.Image")));
            this.factory.Location = new System.Drawing.Point(897, 511);
            this.factory.Name = "factory";
            this.factory.Size = new System.Drawing.Size(199, 202);
            this.factory.TabIndex = 2;
            this.factory.TabStop = false;
            this.factory.Tag = "Kolya";
            this.factory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.factory_MouseDown);
            // 
            // ship
            // 
            this.ship.Image = ((System.Drawing.Image)(resources.GetObject("ship.Image")));
            this.ship.Location = new System.Drawing.Point(80, 511);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(199, 202);
            this.ship.TabIndex = 2;
            this.ship.TabStop = false;
            this.ship.Tag = "Kolya";
            this.ship.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ship_MouseDown);
            // 
            // containerFactory
            // 
            this.containerFactory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.containerFactory.Location = new System.Drawing.Point(481, 239);
            this.containerFactory.Name = "containerFactory";
            this.containerFactory.Size = new System.Drawing.Size(199, 202);
            this.containerFactory.TabIndex = 3;
            this.containerFactory.TabStop = false;
            this.containerFactory.DragDrop += new System.Windows.Forms.DragEventHandler(this.containerFactory_DragDrop);
            this.containerFactory.DragEnter += new System.Windows.Forms.DragEventHandler(this.containerFactory_DragEnter);
            // 
            // containerShip
            // 
            this.containerShip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.containerShip.Location = new System.Drawing.Point(897, 239);
            this.containerShip.Name = "containerShip";
            this.containerShip.Size = new System.Drawing.Size(199, 202);
            this.containerShip.TabIndex = 3;
            this.containerShip.TabStop = false;
            this.containerShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.containerShip_DragDrop);
            this.containerShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.containerShip_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Долар";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фабрика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(897, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Корабель";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(80, 748);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1016, 26);
            this.progressBar1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(80, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Кількість спроб: 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(897, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Успішність тесту: 0%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Розпочати тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(481, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Залишилось часу:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(680, 70);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(37, 30);
            this.time.TabIndex = 14;
            this.time.Text = "30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 847);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.containerShip);
            this.Controls.Add(this.containerFactory);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.factory);
            this.Controls.Add(this.containerDollar);
            this.Controls.Add(this.dollar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox dollar;
        private System.Windows.Forms.PictureBox containerDollar;
        private System.Windows.Forms.PictureBox factory;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox containerFactory;
        private System.Windows.Forms.PictureBox containerShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label time;
    }
}

