
namespace LatvanyossagokApplication
{
    partial class Main
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
            this.TXTBOX_VarosNev = new System.Windows.Forms.TextBox();
            this.NUPDOWN_VarosLakossag = new System.Windows.Forms.NumericUpDown();
            this.BTN_VarosHozzaadas = new System.Windows.Forms.Button();
            this.GB_Varos = new System.Windows.Forms.GroupBox();
            this.BTN_UjVarosLetrehozasa = new System.Windows.Forms.Button();
            this.LBL_VarosLakossag = new System.Windows.Forms.Label();
            this.BTN_VarosTorles = new System.Windows.Forms.Button();
            this.LB_Varosok = new System.Windows.Forms.ListBox();
            this.GB_Latvanyossag = new System.Windows.Forms.GroupBox();
            this.BTN_UjLatvanyossagLetrehozasa = new System.Windows.Forms.Button();
            this.BTN_LatvanyossagTorles = new System.Windows.Forms.Button();
            this.LBL_LatvanyossagAr = new System.Windows.Forms.Label();
            this.BTN_LatvanyossagHozzaadas = new System.Windows.Forms.Button();
            this.TXTBOX_LatvanyossagLeiras = new System.Windows.Forms.TextBox();
            this.LB_Latvanyossagok = new System.Windows.Forms.ListBox();
            this.NUPDOWN_LatvanyossagAr = new System.Windows.Forms.NumericUpDown();
            this.TXTBOX_LatvanyossagNev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUPDOWN_VarosLakossag)).BeginInit();
            this.GB_Varos.SuspendLayout();
            this.GB_Latvanyossag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPDOWN_LatvanyossagAr)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTBOX_VarosNev
            // 
            this.TXTBOX_VarosNev.Location = new System.Drawing.Point(205, 35);
            this.TXTBOX_VarosNev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TXTBOX_VarosNev.Name = "TXTBOX_VarosNev";
            this.TXTBOX_VarosNev.PlaceholderText = "Város neve";
            this.TXTBOX_VarosNev.Size = new System.Drawing.Size(189, 26);
            this.TXTBOX_VarosNev.TabIndex = 0;
            this.TXTBOX_VarosNev.TabStop = false;
            this.TXTBOX_VarosNev.TextChanged += new System.EventHandler(this.TXTBOX_VarosNev_TextChanged);
            // 
            // NUPDOWN_VarosLakossag
            // 
            this.NUPDOWN_VarosLakossag.Location = new System.Drawing.Point(286, 67);
            this.NUPDOWN_VarosLakossag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NUPDOWN_VarosLakossag.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NUPDOWN_VarosLakossag.Name = "NUPDOWN_VarosLakossag";
            this.NUPDOWN_VarosLakossag.Size = new System.Drawing.Size(108, 26);
            this.NUPDOWN_VarosLakossag.TabIndex = 1;
            this.NUPDOWN_VarosLakossag.TabStop = false;
            this.NUPDOWN_VarosLakossag.ValueChanged += new System.EventHandler(this.NUPDOWN_VarosLakossag_ValueChanged);
            // 
            // BTN_VarosHozzaadas
            // 
            this.BTN_VarosHozzaadas.Location = new System.Drawing.Point(205, 111);
            this.BTN_VarosHozzaadas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_VarosHozzaadas.Name = "BTN_VarosHozzaadas";
            this.BTN_VarosHozzaadas.Size = new System.Drawing.Size(191, 54);
            this.BTN_VarosHozzaadas.TabIndex = 2;
            this.BTN_VarosHozzaadas.TabStop = false;
            this.BTN_VarosHozzaadas.Text = "✔";
            this.BTN_VarosHozzaadas.UseVisualStyleBackColor = true;
            this.BTN_VarosHozzaadas.Click += new System.EventHandler(this.BTN_VarosHozzaadas_Click);
            // 
            // GB_Varos
            // 
            this.GB_Varos.Controls.Add(this.BTN_UjVarosLetrehozasa);
            this.GB_Varos.Controls.Add(this.LBL_VarosLakossag);
            this.GB_Varos.Controls.Add(this.BTN_VarosTorles);
            this.GB_Varos.Controls.Add(this.LB_Varosok);
            this.GB_Varos.Controls.Add(this.NUPDOWN_VarosLakossag);
            this.GB_Varos.Controls.Add(this.BTN_VarosHozzaadas);
            this.GB_Varos.Controls.Add(this.TXTBOX_VarosNev);
            this.GB_Varos.Location = new System.Drawing.Point(15, 13);
            this.GB_Varos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GB_Varos.Name = "GB_Varos";
            this.GB_Varos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GB_Varos.Size = new System.Drawing.Size(416, 434);
            this.GB_Varos.TabIndex = 3;
            this.GB_Varos.TabStop = false;
            this.GB_Varos.Text = "Város";
            // 
            // BTN_UjVarosLetrehozasa
            // 
            this.BTN_UjVarosLetrehozasa.Location = new System.Drawing.Point(205, 231);
            this.BTN_UjVarosLetrehozasa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_UjVarosLetrehozasa.Name = "BTN_UjVarosLetrehozasa";
            this.BTN_UjVarosLetrehozasa.Size = new System.Drawing.Size(191, 37);
            this.BTN_UjVarosLetrehozasa.TabIndex = 8;
            this.BTN_UjVarosLetrehozasa.TabStop = false;
            this.BTN_UjVarosLetrehozasa.Text = "Új város";
            this.BTN_UjVarosLetrehozasa.UseVisualStyleBackColor = true;
            this.BTN_UjVarosLetrehozasa.Click += new System.EventHandler(this.BTN_UjVarosLetrehozasa_Click);
            // 
            // LBL_VarosLakossag
            // 
            this.LBL_VarosLakossag.AutoSize = true;
            this.LBL_VarosLakossag.Location = new System.Drawing.Point(205, 69);
            this.LBL_VarosLakossag.Name = "LBL_VarosLakossag";
            this.LBL_VarosLakossag.Size = new System.Drawing.Size(79, 21);
            this.LBL_VarosLakossag.TabIndex = 7;
            this.LBL_VarosLakossag.Text = "Lakosság";
            // 
            // BTN_VarosTorles
            // 
            this.BTN_VarosTorles.Location = new System.Drawing.Point(205, 171);
            this.BTN_VarosTorles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_VarosTorles.Name = "BTN_VarosTorles";
            this.BTN_VarosTorles.Size = new System.Drawing.Size(191, 54);
            this.BTN_VarosTorles.TabIndex = 5;
            this.BTN_VarosTorles.TabStop = false;
            this.BTN_VarosTorles.Text = "🗑";
            this.BTN_VarosTorles.UseVisualStyleBackColor = true;
            this.BTN_VarosTorles.Click += new System.EventHandler(this.BTN_VarosTorles_Click);
            // 
            // LB_Varosok
            // 
            this.LB_Varosok.FormattingEnabled = true;
            this.LB_Varosok.HorizontalScrollbar = true;
            this.LB_Varosok.IntegralHeight = false;
            this.LB_Varosok.ItemHeight = 21;
            this.LB_Varosok.Location = new System.Drawing.Point(8, 27);
            this.LB_Varosok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LB_Varosok.Name = "LB_Varosok";
            this.LB_Varosok.Size = new System.Drawing.Size(185, 395);
            this.LB_Varosok.TabIndex = 4;
            this.LB_Varosok.TabStop = false;
            this.LB_Varosok.SelectedIndexChanged += new System.EventHandler(this.LB_Varosok_SelectedIndexChanged);
            // 
            // GB_Latvanyossag
            // 
            this.GB_Latvanyossag.Controls.Add(this.BTN_UjLatvanyossagLetrehozasa);
            this.GB_Latvanyossag.Controls.Add(this.BTN_LatvanyossagTorles);
            this.GB_Latvanyossag.Controls.Add(this.LBL_LatvanyossagAr);
            this.GB_Latvanyossag.Controls.Add(this.BTN_LatvanyossagHozzaadas);
            this.GB_Latvanyossag.Controls.Add(this.TXTBOX_LatvanyossagLeiras);
            this.GB_Latvanyossag.Controls.Add(this.LB_Latvanyossagok);
            this.GB_Latvanyossag.Controls.Add(this.NUPDOWN_LatvanyossagAr);
            this.GB_Latvanyossag.Controls.Add(this.TXTBOX_LatvanyossagNev);
            this.GB_Latvanyossag.Location = new System.Drawing.Point(438, 12);
            this.GB_Latvanyossag.Name = "GB_Latvanyossag";
            this.GB_Latvanyossag.Size = new System.Drawing.Size(427, 435);
            this.GB_Latvanyossag.TabIndex = 5;
            this.GB_Latvanyossag.TabStop = false;
            this.GB_Latvanyossag.Text = "Látványosság";
            // 
            // BTN_UjLatvanyossagLetrehozasa
            // 
            this.BTN_UjLatvanyossagLetrehozasa.Location = new System.Drawing.Point(255, 317);
            this.BTN_UjLatvanyossagLetrehozasa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_UjLatvanyossagLetrehozasa.Name = "BTN_UjLatvanyossagLetrehozasa";
            this.BTN_UjLatvanyossagLetrehozasa.Size = new System.Drawing.Size(149, 37);
            this.BTN_UjLatvanyossagLetrehozasa.TabIndex = 9;
            this.BTN_UjLatvanyossagLetrehozasa.TabStop = false;
            this.BTN_UjLatvanyossagLetrehozasa.Text = "Új látványosság";
            this.BTN_UjLatvanyossagLetrehozasa.UseVisualStyleBackColor = true;
            this.BTN_UjLatvanyossagLetrehozasa.Click += new System.EventHandler(this.BTN_UjLatvanyossagLetrehozasa_Click);
            // 
            // BTN_LatvanyossagTorles
            // 
            this.BTN_LatvanyossagTorles.Location = new System.Drawing.Point(255, 257);
            this.BTN_LatvanyossagTorles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_LatvanyossagTorles.Name = "BTN_LatvanyossagTorles";
            this.BTN_LatvanyossagTorles.Size = new System.Drawing.Size(148, 54);
            this.BTN_LatvanyossagTorles.TabIndex = 7;
            this.BTN_LatvanyossagTorles.TabStop = false;
            this.BTN_LatvanyossagTorles.Text = "🗑";
            this.BTN_LatvanyossagTorles.UseVisualStyleBackColor = true;
            this.BTN_LatvanyossagTorles.Click += new System.EventHandler(this.BTN_LatvanyossagTorles_Click);
            // 
            // LBL_LatvanyossagAr
            // 
            this.LBL_LatvanyossagAr.AutoSize = true;
            this.LBL_LatvanyossagAr.Location = new System.Drawing.Point(255, 167);
            this.LBL_LatvanyossagAr.Name = "LBL_LatvanyossagAr";
            this.LBL_LatvanyossagAr.Size = new System.Drawing.Size(27, 21);
            this.LBL_LatvanyossagAr.TabIndex = 6;
            this.LBL_LatvanyossagAr.Text = "Ár";
            // 
            // BTN_LatvanyossagHozzaadas
            // 
            this.BTN_LatvanyossagHozzaadas.Location = new System.Drawing.Point(255, 197);
            this.BTN_LatvanyossagHozzaadas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_LatvanyossagHozzaadas.Name = "BTN_LatvanyossagHozzaadas";
            this.BTN_LatvanyossagHozzaadas.Size = new System.Drawing.Size(149, 54);
            this.BTN_LatvanyossagHozzaadas.TabIndex = 6;
            this.BTN_LatvanyossagHozzaadas.TabStop = false;
            this.BTN_LatvanyossagHozzaadas.Text = "✔";
            this.BTN_LatvanyossagHozzaadas.UseVisualStyleBackColor = true;
            this.BTN_LatvanyossagHozzaadas.Click += new System.EventHandler(this.BTN_LatvanyossagHozzaadas_Click);
            // 
            // TXTBOX_LatvanyossagLeiras
            // 
            this.TXTBOX_LatvanyossagLeiras.Location = new System.Drawing.Point(254, 61);
            this.TXTBOX_LatvanyossagLeiras.Multiline = true;
            this.TXTBOX_LatvanyossagLeiras.Name = "TXTBOX_LatvanyossagLeiras";
            this.TXTBOX_LatvanyossagLeiras.PlaceholderText = "Leírás";
            this.TXTBOX_LatvanyossagLeiras.Size = new System.Drawing.Size(150, 98);
            this.TXTBOX_LatvanyossagLeiras.TabIndex = 5;
            this.TXTBOX_LatvanyossagLeiras.TabStop = false;
            this.TXTBOX_LatvanyossagLeiras.TextChanged += new System.EventHandler(this.TXTBOX_LatvanyossagLeiras_TextChanged);
            // 
            // LB_Latvanyossagok
            // 
            this.LB_Latvanyossagok.FormattingEnabled = true;
            this.LB_Latvanyossagok.HorizontalScrollbar = true;
            this.LB_Latvanyossagok.IntegralHeight = false;
            this.LB_Latvanyossagok.ItemHeight = 21;
            this.LB_Latvanyossagok.Location = new System.Drawing.Point(6, 28);
            this.LB_Latvanyossagok.Name = "LB_Latvanyossagok";
            this.LB_Latvanyossagok.Size = new System.Drawing.Size(242, 395);
            this.LB_Latvanyossagok.TabIndex = 4;
            this.LB_Latvanyossagok.TabStop = false;
            this.LB_Latvanyossagok.SelectedIndexChanged += new System.EventHandler(this.LB_Latvanyossagok_SelectedIndexChanged);
            // 
            // NUPDOWN_LatvanyossagAr
            // 
            this.NUPDOWN_LatvanyossagAr.Location = new System.Drawing.Point(286, 165);
            this.NUPDOWN_LatvanyossagAr.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NUPDOWN_LatvanyossagAr.Name = "NUPDOWN_LatvanyossagAr";
            this.NUPDOWN_LatvanyossagAr.Size = new System.Drawing.Size(118, 26);
            this.NUPDOWN_LatvanyossagAr.TabIndex = 1;
            this.NUPDOWN_LatvanyossagAr.TabStop = false;
            this.NUPDOWN_LatvanyossagAr.ValueChanged += new System.EventHandler(this.NUPDOWN_LatvanyossagAr_ValueChanged);
            // 
            // TXTBOX_LatvanyossagNev
            // 
            this.TXTBOX_LatvanyossagNev.Location = new System.Drawing.Point(254, 28);
            this.TXTBOX_LatvanyossagNev.Name = "TXTBOX_LatvanyossagNev";
            this.TXTBOX_LatvanyossagNev.PlaceholderText = "Név";
            this.TXTBOX_LatvanyossagNev.Size = new System.Drawing.Size(150, 26);
            this.TXTBOX_LatvanyossagNev.TabIndex = 0;
            this.TXTBOX_LatvanyossagNev.TabStop = false;
            this.TXTBOX_LatvanyossagNev.TextChanged += new System.EventHandler(this.TXTBOX_LatvanyossagNev_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 461);
            this.Controls.Add(this.GB_Latvanyossag);
            this.Controls.Add(this.GB_Varos);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUPDOWN_VarosLakossag)).EndInit();
            this.GB_Varos.ResumeLayout(false);
            this.GB_Varos.PerformLayout();
            this.GB_Latvanyossag.ResumeLayout(false);
            this.GB_Latvanyossag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPDOWN_LatvanyossagAr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXTBOX_VarosNev;
        private System.Windows.Forms.NumericUpDown NUPDOWN_VarosLakossag;
        private System.Windows.Forms.Button BTN_VarosHozzaadas;
        private System.Windows.Forms.GroupBox GB_Varos;
        private System.Windows.Forms.ListBox LB_Varosok;
        private System.Windows.Forms.Label LBL_VarosLakossag;
        private System.Windows.Forms.Button BTN_VarosTorles;
        private System.Windows.Forms.GroupBox GB_Latvanyossag;
        private System.Windows.Forms.Button BTN_LatvanyossagTorles;
        private System.Windows.Forms.Label LBL_LatvanyossagAr;
        private System.Windows.Forms.Button BTN_LatvanyossagHozzaadas;
        private System.Windows.Forms.TextBox TXTBOX_LatvanyossagLeiras;
        private System.Windows.Forms.ListBox LB_Latvanyossagok;
        private System.Windows.Forms.NumericUpDown NUPDOWN_LatvanyossagAr;
        private System.Windows.Forms.TextBox TXTBOX_LatvanyossagNev;
        private System.Windows.Forms.Button BTN_UjVarosLetrehozasa;
        private System.Windows.Forms.Button BTN_UjLatvanyossagLetrehozasa;
    }
}

