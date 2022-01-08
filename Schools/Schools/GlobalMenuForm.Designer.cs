
namespace Schools
{
    partial class GlobalMenuForm
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
            this.GlobalMenu = new System.Windows.Forms.MenuStrip();
            this.SchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PedagogyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClosedWeekSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClosingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobalMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalMenu
            // 
            this.GlobalMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SchoolToolStripMenuItem,
            this.InformationsToolStripMenuItem,
            this.ClosedWeekSettingsToolStripMenuItem,
            this.PrintingToolStripMenuItem,
            this.ClosingToolStripMenuItem});
            this.GlobalMenu.Location = new System.Drawing.Point(20, 60);
            this.GlobalMenu.Name = "GlobalMenu";
            this.GlobalMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GlobalMenu.Size = new System.Drawing.Size(760, 24);
            this.GlobalMenu.TabIndex = 0;
            this.GlobalMenu.Text = "menuStrip1";
            // 
            // schoolToolStripMenuItem
            // 
            this.SchoolToolStripMenuItem.Name = "SchoolToolStripMenuItem";
            this.SchoolToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.SchoolToolStripMenuItem.Text = "الملف";
            // 
            // informationsToolStripMenuItem
            // 
            this.InformationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaterialsToolStripMenuItem,
            this.RoomsToolStripMenuItem,
            this.ClassesToolStripMenuItem,
            this.TeachersToolStripMenuItem,
            this.PedagogyToolStripMenuItem});
            this.InformationsToolStripMenuItem.Name = "InformationsToolStripMenuItem";
            this.InformationsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.InformationsToolStripMenuItem.Text = "إدخال المعطيات";
            // 
            // materialsToolStripMenuItem
            // 
            this.MaterialsToolStripMenuItem.Name = "MaterialsToolStripMenuItem";
            this.MaterialsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.MaterialsToolStripMenuItem.Text = "تنزيل المواد";
            this.MaterialsToolStripMenuItem.Click += new System.EventHandler(this.MaterialsToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem";
            this.RoomsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.RoomsToolStripMenuItem.Text = "تنزيل القاعات";
            // 
            // classesToolStripMenuItem
            // 
            this.ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem";
            this.ClassesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ClassesToolStripMenuItem.Text = "تنزيل الأقسام";
            // 
            // teachersToolStripMenuItem
            // 
            this.TeachersToolStripMenuItem.Name = "TeachersToolStripMenuItem";
            this.TeachersToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.TeachersToolStripMenuItem.Text = "تنزيل الأساتذة";
            // 
            // pedagogyToolStripMenuItem
            // 
            this.PedagogyToolStripMenuItem.Name = "PedagogyToolStripMenuItem";
            this.PedagogyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.PedagogyToolStripMenuItem.Text = "تنزيل التوزيع البيداغوجي";
            // 
            // closedWeekSettingsToolStripMenuItem
            // 
            this.ClosedWeekSettingsToolStripMenuItem.Name = "ClosedWeekSettingsToolStripMenuItem";
            this.ClosedWeekSettingsToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.ClosedWeekSettingsToolStripMenuItem.Text = "إعدادات الأسبوع المغلق";
            // 
            // printingToolStripMenuItem
            // 
            this.PrintingToolStripMenuItem.Name = "PrintingToolStripMenuItem";
            this.PrintingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.PrintingToolStripMenuItem.Text = "الطباعة";
            // 
            // closingToolStripMenuItem
            // 
            this.ClosingToolStripMenuItem.Name = "ClosingToolStripMenuItem";
            this.ClosingToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ClosingToolStripMenuItem.Text = "غلق";
            // 
            // GlobalMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GlobalMenu);
            this.MainMenuStrip = this.GlobalMenu;
            this.Name = "GlobalMenuForm";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "القائمة الرئيسية";
           
            this.GlobalMenu.ResumeLayout(false);
            this.GlobalMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GlobalMenu;
        private System.Windows.Forms.ToolStripMenuItem SchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PedagogyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClosedWeekSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClosingToolStripMenuItem;
    }
}