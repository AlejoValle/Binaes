namespace BINAES
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.usuariosToolStripMenuItem, this.eventosToolStripMenuItem, this.areasToolStripMenuItem, this.bibliotecaToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.listarUsuariosToolStripMenuItem, this.editarUsuariosToolStripMenuItem });
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listarUsuariosToolStripMenuItem
            // 
            this.listarUsuariosToolStripMenuItem.Name = "listarUsuariosToolStripMenuItem";
            this.listarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarUsuariosToolStripMenuItem.Text = "Listar Usuarios";
            // 
            // editarUsuariosToolStripMenuItem
            // 
            this.editarUsuariosToolStripMenuItem.Name = "editarUsuariosToolStripMenuItem";
            this.editarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarUsuariosToolStripMenuItem.Text = "Editar Usuarios";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.listarEventosToolStripMenuItem, this.editarEventosToolStripMenuItem });
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // listarEventosToolStripMenuItem
            // 
            this.listarEventosToolStripMenuItem.Name = "listarEventosToolStripMenuItem";
            this.listarEventosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listarEventosToolStripMenuItem.Text = "Listar Eventos";
            // 
            // editarEventosToolStripMenuItem
            // 
            this.editarEventosToolStripMenuItem.Name = "editarEventosToolStripMenuItem";
            this.editarEventosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editarEventosToolStripMenuItem.Text = "Editar Eventos";
            // 
            // areasToolStripMenuItem
            // 
            this.areasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.listarAreasToolStripMenuItem });
            this.areasToolStripMenuItem.Name = "areasToolStripMenuItem";
            this.areasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.areasToolStripMenuItem.Text = "Areas";
            // 
            // listarAreasToolStripMenuItem
            // 
            this.listarAreasToolStripMenuItem.Name = "listarAreasToolStripMenuItem";
            this.listarAreasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.listarAreasToolStripMenuItem.Text = "Listar Areas";
            // 
            // bibliotecaToolStripMenuItem
            // 
            this.bibliotecaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.busquedaDeLibrosToolStripMenuItem, this.listarLibrosToolStripMenuItem, this.editarLibrosToolStripMenuItem });
            this.bibliotecaToolStripMenuItem.Name = "bibliotecaToolStripMenuItem";
            this.bibliotecaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bibliotecaToolStripMenuItem.Text = "Biblioteca";
            // 
            // busquedaDeLibrosToolStripMenuItem
            // 
            this.busquedaDeLibrosToolStripMenuItem.Name = "busquedaDeLibrosToolStripMenuItem";
            this.busquedaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.busquedaDeLibrosToolStripMenuItem.Text = "Busqueda de Libros";
            // 
            // listarLibrosToolStripMenuItem
            // 
            this.listarLibrosToolStripMenuItem.Name = "listarLibrosToolStripMenuItem";
            this.listarLibrosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listarLibrosToolStripMenuItem.Text = "Listar Libros";
            // 
            // editarLibrosToolStripMenuItem
            // 
            this.editarLibrosToolStripMenuItem.Name = "editarLibrosToolStripMenuItem";
            this.editarLibrosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editarLibrosToolStripMenuItem.Text = "Editar Libros";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 602);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listar);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(797, 51);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(141, 57);
            this.listar.TabIndex = 2;
            this.listar.Text = "usuarios";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 506);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Usuarios";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 627);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button listar;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAreasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLibrosToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}