
namespace Multi_service_company_program
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel_contenaire = new System.Windows.Forms.Panel();
            this.panel_titre = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.header_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.home_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_choix = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.hide_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.log_out_butt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.accissibilite_form = new Bunifu.Framework.UI.BunifuFlatButton();
            this.base_donne_form = new Bunifu.Framework.UI.BunifuFlatButton();
            this.service_form = new Bunifu.Framework.UI.BunifuFlatButton();
            this.employee_form = new Bunifu.Framework.UI.BunifuFlatButton();
            this.client_form = new Bunifu.Framework.UI.BunifuFlatButton();
            this.side_panel_timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuCards1.SuspendLayout();
            this.panel_titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).BeginInit();
            this.panel_choix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_button)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuCards1.BorderRadius = 20;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Gray;
            this.bunifuCards1.Controls.Add(this.panel_contenaire);
            this.bunifuCards1.Controls.Add(this.panel_titre);
            this.bunifuCards1.Controls.Add(this.panel_choix);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(977, 548);
            this.bunifuCards1.TabIndex = 0;
            // 
            // panel_contenaire
            // 
            this.panel_contenaire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_contenaire.BackgroundImage")));
            this.panel_contenaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_contenaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenaire.Location = new System.Drawing.Point(160, 64);
            this.panel_contenaire.Name = "panel_contenaire";
            this.panel_contenaire.Size = new System.Drawing.Size(813, 480);
            this.panel_contenaire.TabIndex = 3;
            // 
            // panel_titre
            // 
            this.panel_titre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_titre.BackgroundImage")));
            this.panel_titre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_titre.Controls.Add(this.header_label);
            this.panel_titre.Controls.Add(this.home_button);
            this.panel_titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titre.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_titre.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_titre.GradientTopLeft = System.Drawing.Color.White;
            this.panel_titre.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel_titre.Location = new System.Drawing.Point(160, 0);
            this.panel_titre.Name = "panel_titre";
            this.panel_titre.Quality = 10;
            this.panel_titre.Size = new System.Drawing.Size(813, 64);
            this.panel_titre.TabIndex = 2;
            // 
            // header_label
            // 
            this.header_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_label.AutoSize = true;
            this.header_label.BackColor = System.Drawing.Color.Transparent;
            this.header_label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.header_label.Font = new System.Drawing.Font("Snap ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.Location = new System.Drawing.Point(349, 12);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(127, 37);
            this.header_label.TabIndex = 1;
            this.header_label.Text = "HOME";
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.ImageActive = null;
            this.home_button.Location = new System.Drawing.Point(0, 2);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(151, 61);
            this.home_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home_button.TabIndex = 0;
            this.home_button.TabStop = false;
            this.home_button.Zoom = 10;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // panel_choix
            // 
            this.panel_choix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_choix.BackgroundImage")));
            this.panel_choix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_choix.Controls.Add(this.hide_button);
            this.panel_choix.Controls.Add(this.log_out_butt);
            this.panel_choix.Controls.Add(this.accissibilite_form);
            this.panel_choix.Controls.Add(this.base_donne_form);
            this.panel_choix.Controls.Add(this.service_form);
            this.panel_choix.Controls.Add(this.employee_form);
            this.panel_choix.Controls.Add(this.client_form);
            this.panel_choix.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_choix.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_choix.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel_choix.GradientTopLeft = System.Drawing.Color.Black;
            this.panel_choix.GradientTopRight = System.Drawing.Color.White;
            this.panel_choix.Location = new System.Drawing.Point(0, 0);
            this.panel_choix.Name = "panel_choix";
            this.panel_choix.Quality = 10;
            this.panel_choix.Size = new System.Drawing.Size(160, 544);
            this.panel_choix.TabIndex = 1;
            // 
            // hide_button
            // 
            this.hide_button.BackColor = System.Drawing.Color.Transparent;
            this.hide_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.hide_button.Image = ((System.Drawing.Image)(resources.GetObject("hide_button.Image")));
            this.hide_button.ImageActive = null;
            this.hide_button.Location = new System.Drawing.Point(119, 0);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(41, 544);
            this.hide_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide_button.TabIndex = 2;
            this.hide_button.TabStop = false;
            this.hide_button.Zoom = 10;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // log_out_butt
            // 
            this.log_out_butt.Activecolor = System.Drawing.Color.Gray;
            this.log_out_butt.BackColor = System.Drawing.Color.Transparent;
            this.log_out_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_out_butt.BorderRadius = 0;
            this.log_out_butt.ButtonText = "Quitter";
            this.log_out_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out_butt.DisabledColor = System.Drawing.Color.Gray;
            this.log_out_butt.Iconcolor = System.Drawing.Color.Transparent;
            this.log_out_butt.Iconimage = ((System.Drawing.Image)(resources.GetObject("log_out_butt.Iconimage")));
            this.log_out_butt.Iconimage_right = null;
            this.log_out_butt.Iconimage_right_Selected = null;
            this.log_out_butt.Iconimage_Selected = null;
            this.log_out_butt.IconMarginLeft = 0;
            this.log_out_butt.IconMarginRight = 0;
            this.log_out_butt.IconRightVisible = true;
            this.log_out_butt.IconRightZoom = 0D;
            this.log_out_butt.IconVisible = true;
            this.log_out_butt.IconZoom = 90D;
            this.log_out_butt.IsTab = false;
            this.log_out_butt.Location = new System.Drawing.Point(-2, 447);
            this.log_out_butt.Name = "log_out_butt";
            this.log_out_butt.Normalcolor = System.Drawing.Color.Transparent;
            this.log_out_butt.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.log_out_butt.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.log_out_butt.selected = false;
            this.log_out_butt.Size = new System.Drawing.Size(128, 48);
            this.log_out_butt.TabIndex = 1;
            this.log_out_butt.Text = "Quitter";
            this.log_out_butt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_out_butt.Textcolor = System.Drawing.Color.White;
            this.log_out_butt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_butt.Click += new System.EventHandler(this.log_out_butt_Click);
            // 
            // accissibilite_form
            // 
            this.accissibilite_form.Activecolor = System.Drawing.Color.Gray;
            this.accissibilite_form.BackColor = System.Drawing.Color.Transparent;
            this.accissibilite_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accissibilite_form.BorderRadius = 0;
            this.accissibilite_form.ButtonText = "Accissibilte";
            this.accissibilite_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accissibilite_form.DisabledColor = System.Drawing.Color.Gray;
            this.accissibilite_form.Iconcolor = System.Drawing.Color.Transparent;
            this.accissibilite_form.Iconimage = ((System.Drawing.Image)(resources.GetObject("accissibilite_form.Iconimage")));
            this.accissibilite_form.Iconimage_right = null;
            this.accissibilite_form.Iconimage_right_Selected = null;
            this.accissibilite_form.Iconimage_Selected = null;
            this.accissibilite_form.IconMarginLeft = 0;
            this.accissibilite_form.IconMarginRight = 0;
            this.accissibilite_form.IconRightVisible = true;
            this.accissibilite_form.IconRightZoom = 0D;
            this.accissibilite_form.IconVisible = true;
            this.accissibilite_form.IconZoom = 90D;
            this.accissibilite_form.IsTab = false;
            this.accissibilite_form.Location = new System.Drawing.Point(-2, 393);
            this.accissibilite_form.Name = "accissibilite_form";
            this.accissibilite_form.Normalcolor = System.Drawing.Color.Transparent;
            this.accissibilite_form.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.accissibilite_form.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.accissibilite_form.selected = false;
            this.accissibilite_form.Size = new System.Drawing.Size(128, 48);
            this.accissibilite_form.TabIndex = 1;
            this.accissibilite_form.Text = "Accissibilte";
            this.accissibilite_form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accissibilite_form.Textcolor = System.Drawing.Color.White;
            this.accissibilite_form.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accissibilite_form.Click += new System.EventHandler(this.accissibilite_form_Click);
            // 
            // base_donne_form
            // 
            this.base_donne_form.Activecolor = System.Drawing.Color.Gray;
            this.base_donne_form.BackColor = System.Drawing.Color.Transparent;
            this.base_donne_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.base_donne_form.BorderRadius = 0;
            this.base_donne_form.ButtonText = "Base de donnes";
            this.base_donne_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.base_donne_form.DisabledColor = System.Drawing.Color.Gray;
            this.base_donne_form.Iconcolor = System.Drawing.Color.Transparent;
            this.base_donne_form.Iconimage = ((System.Drawing.Image)(resources.GetObject("base_donne_form.Iconimage")));
            this.base_donne_form.Iconimage_right = null;
            this.base_donne_form.Iconimage_right_Selected = null;
            this.base_donne_form.Iconimage_Selected = null;
            this.base_donne_form.IconMarginLeft = 0;
            this.base_donne_form.IconMarginRight = 0;
            this.base_donne_form.IconRightVisible = true;
            this.base_donne_form.IconRightZoom = 0D;
            this.base_donne_form.IconVisible = true;
            this.base_donne_form.IconZoom = 90D;
            this.base_donne_form.IsTab = false;
            this.base_donne_form.Location = new System.Drawing.Point(-2, 339);
            this.base_donne_form.Name = "base_donne_form";
            this.base_donne_form.Normalcolor = System.Drawing.Color.Transparent;
            this.base_donne_form.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.base_donne_form.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.base_donne_form.selected = false;
            this.base_donne_form.Size = new System.Drawing.Size(128, 48);
            this.base_donne_form.TabIndex = 1;
            this.base_donne_form.Text = "Base de donnes";
            this.base_donne_form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.base_donne_form.Textcolor = System.Drawing.Color.White;
            this.base_donne_form.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base_donne_form.Click += new System.EventHandler(this.base_donne_form_Click);
            // 
            // service_form
            // 
            this.service_form.Activecolor = System.Drawing.Color.Gray;
            this.service_form.BackColor = System.Drawing.Color.Transparent;
            this.service_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.service_form.BorderRadius = 0;
            this.service_form.ButtonText = "Service";
            this.service_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.service_form.DisabledColor = System.Drawing.Color.Gray;
            this.service_form.Iconcolor = System.Drawing.Color.Transparent;
            this.service_form.Iconimage = ((System.Drawing.Image)(resources.GetObject("service_form.Iconimage")));
            this.service_form.Iconimage_right = null;
            this.service_form.Iconimage_right_Selected = null;
            this.service_form.Iconimage_Selected = null;
            this.service_form.IconMarginLeft = 0;
            this.service_form.IconMarginRight = 0;
            this.service_form.IconRightVisible = true;
            this.service_form.IconRightZoom = 0D;
            this.service_form.IconVisible = true;
            this.service_form.IconZoom = 90D;
            this.service_form.IsTab = false;
            this.service_form.Location = new System.Drawing.Point(-2, 285);
            this.service_form.Name = "service_form";
            this.service_form.Normalcolor = System.Drawing.Color.Transparent;
            this.service_form.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.service_form.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.service_form.selected = false;
            this.service_form.Size = new System.Drawing.Size(128, 48);
            this.service_form.TabIndex = 1;
            this.service_form.Text = "Service";
            this.service_form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.service_form.Textcolor = System.Drawing.Color.White;
            this.service_form.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_form.Click += new System.EventHandler(this.service_form_Click);
            // 
            // employee_form
            // 
            this.employee_form.Activecolor = System.Drawing.Color.Gray;
            this.employee_form.BackColor = System.Drawing.Color.Transparent;
            this.employee_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employee_form.BorderRadius = 0;
            this.employee_form.ButtonText = "Employee";
            this.employee_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_form.DisabledColor = System.Drawing.Color.Gray;
            this.employee_form.Iconcolor = System.Drawing.Color.Transparent;
            this.employee_form.Iconimage = ((System.Drawing.Image)(resources.GetObject("employee_form.Iconimage")));
            this.employee_form.Iconimage_right = null;
            this.employee_form.Iconimage_right_Selected = null;
            this.employee_form.Iconimage_Selected = null;
            this.employee_form.IconMarginLeft = 0;
            this.employee_form.IconMarginRight = 0;
            this.employee_form.IconRightVisible = true;
            this.employee_form.IconRightZoom = 0D;
            this.employee_form.IconVisible = true;
            this.employee_form.IconZoom = 90D;
            this.employee_form.IsTab = false;
            this.employee_form.Location = new System.Drawing.Point(-2, 231);
            this.employee_form.Name = "employee_form";
            this.employee_form.Normalcolor = System.Drawing.Color.Transparent;
            this.employee_form.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.employee_form.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.employee_form.selected = false;
            this.employee_form.Size = new System.Drawing.Size(128, 48);
            this.employee_form.TabIndex = 1;
            this.employee_form.Text = "Employee";
            this.employee_form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee_form.Textcolor = System.Drawing.Color.White;
            this.employee_form.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_form.Click += new System.EventHandler(this.employee_form_Click);
            // 
            // client_form
            // 
            this.client_form.Activecolor = System.Drawing.Color.Gray;
            this.client_form.BackColor = System.Drawing.Color.Transparent;
            this.client_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.client_form.BorderRadius = 0;
            this.client_form.ButtonText = "Client";
            this.client_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.client_form.DisabledColor = System.Drawing.Color.Gray;
            this.client_form.Iconcolor = System.Drawing.Color.Transparent;
            this.client_form.Iconimage = ((System.Drawing.Image)(resources.GetObject("client_form.Iconimage")));
            this.client_form.Iconimage_right = null;
            this.client_form.Iconimage_right_Selected = null;
            this.client_form.Iconimage_Selected = null;
            this.client_form.IconMarginLeft = 0;
            this.client_form.IconMarginRight = 0;
            this.client_form.IconRightVisible = true;
            this.client_form.IconRightZoom = 0D;
            this.client_form.IconVisible = true;
            this.client_form.IconZoom = 90D;
            this.client_form.IsTab = false;
            this.client_form.Location = new System.Drawing.Point(-2, 166);
            this.client_form.Name = "client_form";
            this.client_form.Normalcolor = System.Drawing.Color.Transparent;
            this.client_form.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.client_form.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.client_form.selected = false;
            this.client_form.Size = new System.Drawing.Size(128, 48);
            this.client_form.TabIndex = 1;
            this.client_form.Text = "Client";
            this.client_form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.client_form.Textcolor = System.Drawing.Color.White;
            this.client_form.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_form.Click += new System.EventHandler(this.client_form_Click);
            // 
            // side_panel_timer
            // 
            this.side_panel_timer.Tick += new System.EventHandler(this.side_panel_timer_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 548);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.panel_titre.ResumeLayout(false);
            this.panel_titre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).EndInit();
            this.panel_choix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hide_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_titre;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_choix;
        private System.Windows.Forms.Panel panel_contenaire;
        private Bunifu.Framework.UI.BunifuImageButton home_button;
        private Bunifu.Framework.UI.BunifuFlatButton client_form;
        private Bunifu.Framework.UI.BunifuFlatButton log_out_butt;
        private Bunifu.Framework.UI.BunifuFlatButton accissibilite_form;
        private Bunifu.Framework.UI.BunifuFlatButton base_donne_form;
        private Bunifu.Framework.UI.BunifuFlatButton service_form;
        private Bunifu.Framework.UI.BunifuFlatButton employee_form;
        private Bunifu.Framework.UI.BunifuCustomLabel header_label;
        private Bunifu.Framework.UI.BunifuImageButton hide_button;
        private System.Windows.Forms.Timer side_panel_timer;
    }
}

