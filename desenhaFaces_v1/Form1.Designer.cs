﻿namespace desenhaFaces_v1
{
    partial class Form1
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
            this.tb_transx = new System.Windows.Forms.TrackBar();
            this.tb_transy = new System.Windows.Forms.TrackBar();
            this.tb_transz = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_desenho = new System.Windows.Forms.PictureBox();
            this.CorStroke_pb = new System.Windows.Forms.PictureBox();
            this.CorStroke_btn = new System.Windows.Forms.Button();
            this.CorFill_btn = new System.Windows.Forms.Button();
            this.CorFill_pb = new System.Windows.Forms.PictureBox();
            this.cb_wireframe = new System.Windows.Forms.CheckBox();
            this.Espessura_nud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolherObjeto3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxRaio = new System.Windows.Forms.ToolStripTextBox();
            this.alturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxAltura = new System.Windows.Forms.ToolStripTextBox();
            this.facesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxFaces = new System.Windows.Forms.ToolStripTextBox();
            this.prismaPentagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piramideQuadrangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piramideHexagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Roty_tb = new System.Windows.Forms.TrackBar();
            this.Rotx_tb = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Rotz_tb = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.distancia = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dadosObjeto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transz)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorStroke_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorFill_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espessura_nud)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Roty_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotx_tb)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rotz_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distancia)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_transx
            // 
            this.tb_transx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_transx.Location = new System.Drawing.Point(785, 55);
            this.tb_transx.Margin = new System.Windows.Forms.Padding(2);
            this.tb_transx.Maximum = 50;
            this.tb_transx.Minimum = -50;
            this.tb_transx.Name = "tb_transx";
            this.tb_transx.Size = new System.Drawing.Size(139, 45);
            this.tb_transx.TabIndex = 1;
            this.tb_transx.ValueChanged += new System.EventHandler(this.tb_transx_ValueChanged);
            // 
            // tb_transy
            // 
            this.tb_transy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_transy.Location = new System.Drawing.Point(785, 101);
            this.tb_transy.Margin = new System.Windows.Forms.Padding(2);
            this.tb_transy.Maximum = 50;
            this.tb_transy.Minimum = -50;
            this.tb_transy.Name = "tb_transy";
            this.tb_transy.Size = new System.Drawing.Size(139, 45);
            this.tb_transy.TabIndex = 3;
            this.tb_transy.ValueChanged += new System.EventHandler(this.tb_transy_ValueChanged);
            // 
            // tb_transz
            // 
            this.tb_transz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_transz.Location = new System.Drawing.Point(38, 112);
            this.tb_transz.Margin = new System.Windows.Forms.Padding(2);
            this.tb_transz.Maximum = 0;
            this.tb_transz.Minimum = -50;
            this.tb_transz.Name = "tb_transz";
            this.tb_transz.Size = new System.Drawing.Size(139, 45);
            this.tb_transz.TabIndex = 4;
            this.tb_transz.ValueChanged += new System.EventHandler(this.tb_transz_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_transz);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(747, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // pb_desenho
            // 
            this.pb_desenho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_desenho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_desenho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_desenho.Location = new System.Drawing.Point(24, 34);
            this.pb_desenho.Margin = new System.Windows.Forms.Padding(2);
            this.pb_desenho.Name = "pb_desenho";
            this.pb_desenho.Size = new System.Drawing.Size(698, 533);
            this.pb_desenho.TabIndex = 0;
            this.pb_desenho.TabStop = false;
            this.pb_desenho.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_desenho_Paint);
            // 
            // CorStroke_pb
            // 
            this.CorStroke_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorStroke_pb.BackColor = System.Drawing.Color.Blue;
            this.CorStroke_pb.Location = new System.Drawing.Point(887, 373);
            this.CorStroke_pb.Name = "CorStroke_pb";
            this.CorStroke_pb.Size = new System.Drawing.Size(47, 44);
            this.CorStroke_pb.TabIndex = 6;
            this.CorStroke_pb.TabStop = false;
            // 
            // CorStroke_btn
            // 
            this.CorStroke_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorStroke_btn.Location = new System.Drawing.Point(747, 373);
            this.CorStroke_btn.Name = "CorStroke_btn";
            this.CorStroke_btn.Size = new System.Drawing.Size(124, 44);
            this.CorStroke_btn.TabIndex = 7;
            this.CorStroke_btn.Text = "Cor Contorno";
            this.CorStroke_btn.UseVisualStyleBackColor = true;
            this.CorStroke_btn.Click += new System.EventHandler(this.CorStroke_btn_Click);
            // 
            // CorFill_btn
            // 
            this.CorFill_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorFill_btn.Location = new System.Drawing.Point(747, 429);
            this.CorFill_btn.Name = "CorFill_btn";
            this.CorFill_btn.Size = new System.Drawing.Size(124, 44);
            this.CorFill_btn.TabIndex = 9;
            this.CorFill_btn.Text = "Cor Preenchimento";
            this.CorFill_btn.UseVisualStyleBackColor = true;
            this.CorFill_btn.Click += new System.EventHandler(this.CorFill_btn_Click);
            // 
            // CorFill_pb
            // 
            this.CorFill_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorFill_pb.BackColor = System.Drawing.Color.OrangeRed;
            this.CorFill_pb.Location = new System.Drawing.Point(887, 429);
            this.CorFill_pb.Name = "CorFill_pb";
            this.CorFill_pb.Size = new System.Drawing.Size(47, 44);
            this.CorFill_pb.TabIndex = 8;
            this.CorFill_pb.TabStop = false;
            // 
            // cb_wireframe
            // 
            this.cb_wireframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_wireframe.AutoSize = true;
            this.cb_wireframe.Location = new System.Drawing.Point(747, 496);
            this.cb_wireframe.Name = "cb_wireframe";
            this.cb_wireframe.Size = new System.Drawing.Size(74, 17);
            this.cb_wireframe.TabIndex = 10;
            this.cb_wireframe.Text = "Wireframe";
            this.cb_wireframe.UseVisualStyleBackColor = true;
            this.cb_wireframe.CheckedChanged += new System.EventHandler(this.cb_wireframe_CheckedChanged);
            // 
            // Espessura_nud
            // 
            this.Espessura_nud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Espessura_nud.Location = new System.Drawing.Point(885, 493);
            this.Espessura_nud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Espessura_nud.Name = "Espessura_nud";
            this.Espessura_nud.Size = new System.Drawing.Size(49, 20);
            this.Espessura_nud.TabIndex = 11;
            this.Espessura_nud.ValueChanged += new System.EventHandler(this.Espessura_nud_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Espessura";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.escolherObjeto3DToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // escolherObjeto3DToolStripMenuItem
            // 
            this.escolherObjeto3DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuboToolStripMenuItem,
            this.coneToolStripMenuItem,
            this.prismaPentagonalToolStripMenuItem,
            this.piramideQuadrangularToolStripMenuItem,
            this.piramideHexagonalToolStripMenuItem});
            this.escolherObjeto3DToolStripMenuItem.Name = "escolherObjeto3DToolStripMenuItem";
            this.escolherObjeto3DToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.escolherObjeto3DToolStripMenuItem.Text = "Escolher Objeto 3D";
            // 
            // cuboToolStripMenuItem
            // 
            this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
            this.cuboToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cuboToolStripMenuItem.Text = "Cubo";
            this.cuboToolStripMenuItem.Click += new System.EventHandler(this.cuboToolStripMenuItem_Click);
            // 
            // coneToolStripMenuItem
            // 
            this.coneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raioToolStripMenuItem,
            this.alturaToolStripMenuItem,
            this.facesToolStripMenuItem});
            this.coneToolStripMenuItem.Name = "coneToolStripMenuItem";
            this.coneToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.coneToolStripMenuItem.Text = "Cone";
            this.coneToolStripMenuItem.Click += new System.EventHandler(this.coneToolStripMenuItem_Click);
            // 
            // raioToolStripMenuItem
            // 
            this.raioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxRaio});
            this.raioToolStripMenuItem.Name = "raioToolStripMenuItem";
            this.raioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.raioToolStripMenuItem.Text = "Definir Raio";
            // 
            // textBoxRaio
            // 
            this.textBoxRaio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxRaio.Name = "textBoxRaio";
            this.textBoxRaio.Size = new System.Drawing.Size(100, 23);
            // 
            // alturaToolStripMenuItem
            // 
            this.alturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxAltura});
            this.alturaToolStripMenuItem.Name = "alturaToolStripMenuItem";
            this.alturaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.alturaToolStripMenuItem.Text = "Definir Altura";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 23);
            // 
            // facesToolStripMenuItem
            // 
            this.facesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxFaces});
            this.facesToolStripMenuItem.Name = "facesToolStripMenuItem";
            this.facesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.facesToolStripMenuItem.Text = "Definir nrº Faces";
            // 
            // textBoxFaces
            // 
            this.textBoxFaces.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxFaces.Name = "textBoxFaces";
            this.textBoxFaces.Size = new System.Drawing.Size(100, 23);
            // 
            // prismaPentagonalToolStripMenuItem
            // 
            this.prismaPentagonalToolStripMenuItem.Name = "prismaPentagonalToolStripMenuItem";
            this.prismaPentagonalToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.prismaPentagonalToolStripMenuItem.Text = "Prisma Pentagonal";
            this.prismaPentagonalToolStripMenuItem.Click += new System.EventHandler(this.prismaPentagonalToolStripMenuItem_Click);
            // 
            // piramideQuadrangularToolStripMenuItem
            // 
            this.piramideQuadrangularToolStripMenuItem.Name = "piramideQuadrangularToolStripMenuItem";
            this.piramideQuadrangularToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.piramideQuadrangularToolStripMenuItem.Text = "Piramide Quadrangular";
            this.piramideQuadrangularToolStripMenuItem.Click += new System.EventHandler(this.piramideQuadrangularToolStripMenuItem_Click);
            // 
            // piramideHexagonalToolStripMenuItem
            // 
            this.piramideHexagonalToolStripMenuItem.Name = "piramideHexagonalToolStripMenuItem";
            this.piramideHexagonalToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.piramideHexagonalToolStripMenuItem.Text = "Piramide Hexagonal";
            this.piramideHexagonalToolStripMenuItem.Click += new System.EventHandler(this.piramideHexagonalToolStripMenuItem_Click);
            // 
            // Roty_tb
            // 
            this.Roty_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Roty_tb.Location = new System.Drawing.Point(38, 66);
            this.Roty_tb.Margin = new System.Windows.Forms.Padding(2);
            this.Roty_tb.Maximum = 180;
            this.Roty_tb.Minimum = -180;
            this.Roty_tb.Name = "Roty_tb";
            this.Roty_tb.Size = new System.Drawing.Size(139, 45);
            this.Roty_tb.TabIndex = 15;
            this.Roty_tb.ValueChanged += new System.EventHandler(this.Roty_tb_ValueChanged);
            // 
            // Rotx_tb
            // 
            this.Rotx_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotx_tb.Location = new System.Drawing.Point(38, 18);
            this.Rotx_tb.Margin = new System.Windows.Forms.Padding(2);
            this.Rotx_tb.Maximum = 180;
            this.Rotx_tb.Minimum = -180;
            this.Rotx_tb.Name = "Rotx_tb";
            this.Rotx_tb.Size = new System.Drawing.Size(139, 45);
            this.Rotx_tb.TabIndex = 14;
            this.Rotx_tb.ValueChanged += new System.EventHandler(this.Rotx_tb_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Roty_tb);
            this.groupBox2.Controls.Add(this.Rotz_tb);
            this.groupBox2.Controls.Add(this.Rotx_tb);
            this.groupBox2.Location = new System.Drawing.Point(747, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 162);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            // 
            // Rotz_tb
            // 
            this.Rotz_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotz_tb.Location = new System.Drawing.Point(38, 110);
            this.Rotz_tb.Margin = new System.Windows.Forms.Padding(2);
            this.Rotz_tb.Maximum = 180;
            this.Rotz_tb.Minimum = -180;
            this.Rotz_tb.Name = "Rotz_tb";
            this.Rotz_tb.Size = new System.Drawing.Size(139, 45);
            this.Rotz_tb.TabIndex = 4;
            this.Rotz_tb.ValueChanged += new System.EventHandler(this.Rotz_tb_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(747, 522);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "ProjPersp";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(827, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Distância";
            // 
            // distancia
            // 
            this.distancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distancia.Location = new System.Drawing.Point(885, 522);
            this.distancia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.distancia.Name = "distancia";
            this.distancia.Size = new System.Drawing.Size(49, 20);
            this.distancia.TabIndex = 18;
            this.distancia.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.distancia.ValueChanged += new System.EventHandler(this.distancia_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Reset Transf.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dadosObjeto
            // 
            this.dadosObjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosObjeto.AutoSize = true;
            this.dadosObjeto.Location = new System.Drawing.Point(33, 543);
            this.dadosObjeto.Name = "dadosObjeto";
            this.dadosObjeto.Size = new System.Drawing.Size(106, 13);
            this.dadosObjeto.TabIndex = 21;
            this.dadosObjeto.Text = "                                 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 600);
            this.Controls.Add(this.dadosObjeto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.distancia);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Espessura_nud);
            this.Controls.Add(this.cb_wireframe);
            this.Controls.Add(this.CorFill_btn);
            this.Controls.Add(this.CorFill_pb);
            this.Controls.Add(this.CorStroke_btn);
            this.Controls.Add(this.CorStroke_pb);
            this.Controls.Add(this.tb_transy);
            this.Controls.Add(this.tb_transx);
            this.Controls.Add(this.pb_desenho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(965, 638);
            this.Name = "Form1";
            this.Text = "Desenho de Faces Poligonais";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tb_transx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorStroke_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorFill_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espessura_nud)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Roty_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotx_tb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rotz_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar tb_transx;
        private System.Windows.Forms.TrackBar tb_transy;
        private System.Windows.Forms.TrackBar tb_transz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_desenho;
        private System.Windows.Forms.PictureBox CorStroke_pb;
        private System.Windows.Forms.Button CorStroke_btn;
        private System.Windows.Forms.Button CorFill_btn;
        private System.Windows.Forms.PictureBox CorFill_pb;
        private System.Windows.Forms.CheckBox cb_wireframe;
        private System.Windows.Forms.NumericUpDown Espessura_nud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TrackBar Roty_tb;
        private System.Windows.Forms.TrackBar Rotx_tb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar Rotz_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem escolherObjeto3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prismaPentagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piramideQuadrangularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piramideHexagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textBoxRaio;
        private System.Windows.Forms.ToolStripTextBox textBoxAltura;
        private System.Windows.Forms.ToolStripTextBox textBoxFaces;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown distancia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dadosObjeto;
    }
}

