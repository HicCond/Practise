namespace VillageDefense
{
    partial class MainWindow
    {
        /// <summary>
        /// Обов'зкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Звільнити всі конструктори.
        /// </summary>
        /// <param name="disposing">істрина, якщо використовуваний ресурс повинен бути виделаний; інше брехня.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.renderBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.Enabled = true;
            this.Frame.Interval = 40;
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // renderBox
            // 
            this.renderBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.renderBox.Location = new System.Drawing.Point(-3, -5);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(806, 458);
            this.renderBox.TabIndex = 0;
            this.renderBox.TabStop = false;
            this.renderBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.renderBox_MouseDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Village Defense";
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Frame;
        private System.Windows.Forms.PictureBox renderBox;
    }
}

