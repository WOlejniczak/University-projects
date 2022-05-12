
namespace Geo
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
            this.components = new System.ComponentModel.Container();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.LoadButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MaximalizeButton = new System.Windows.Forms.Button();
            this.MinimalizeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Graphs = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveAllPrev = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOnePrev = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOneNext = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAllNext = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.EditCancel = new System.Windows.Forms.Button();
            this.EditAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditEle = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditLat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.EditLon = new System.Windows.Forms.NumericUpDown();
            this.labeledit = new System.Windows.Forms.Label();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.AddCancel = new System.Windows.Forms.Button();
            this.AddAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddEle = new System.Windows.Forms.NumericUpDown();
            this.AddTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddLat = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.AddLon = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditEle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditLon)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTime)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddLon)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(1, 30);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = false;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1100, 567);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_OnMapClick);
            // 
            // LoadButton
            // 
            this.LoadButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadButton.Location = new System.Drawing.Point(1, 0);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(105, 31);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Wczytaj";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(1061, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 31);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MaximalizeButton
            // 
            this.MaximalizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximalizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximalizeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MaximalizeButton.Location = new System.Drawing.Point(1023, 0);
            this.MaximalizeButton.Name = "MaximalizeButton";
            this.MaximalizeButton.Size = new System.Drawing.Size(40, 31);
            this.MaximalizeButton.TabIndex = 3;
            this.MaximalizeButton.Text = "□";
            this.MaximalizeButton.UseVisualStyleBackColor = true;
            this.MaximalizeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // MinimalizeButton
            // 
            this.MinimalizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimalizeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MinimalizeButton.Location = new System.Drawing.Point(984, 0);
            this.MinimalizeButton.Name = "MinimalizeButton";
            this.MinimalizeButton.Size = new System.Drawing.Size(40, 31);
            this.MinimalizeButton.TabIndex = 4;
            this.MinimalizeButton.Text = "__";
            this.MinimalizeButton.UseVisualStyleBackColor = true;
            this.MinimalizeButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Location = new System.Drawing.Point(105, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(105, 31);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 31);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Graphs
            // 
            this.Graphs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Graphs.Location = new System.Drawing.Point(210, 0);
            this.Graphs.Name = "Graphs";
            this.Graphs.Size = new System.Drawing.Size(105, 31);
            this.Graphs.TabIndex = 7;
            this.Graphs.Text = "Wykresy";
            this.Graphs.UseVisualStyleBackColor = true;
            this.Graphs.Click += new System.EventHandler(this.Graphs_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveAllPrev,
            this.AddOnePrev,
            this.RemoveSelected,
            this.EditSelected,
            this.AddOneNext,
            this.RemoveAllNext});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(280, 136);
            // 
            // RemoveAllPrev
            // 
            this.RemoveAllPrev.Name = "RemoveAllPrev";
            this.RemoveAllPrev.Size = new System.Drawing.Size(279, 22);
            this.RemoveAllPrev.Text = "Usuń wszystkie wcześniejsze punkty";
            this.RemoveAllPrev.Click += new System.EventHandler(this.RemoveAllPrev_Click);
            // 
            // AddOnePrev
            // 
            this.AddOnePrev.Name = "AddOnePrev";
            this.AddOnePrev.Size = new System.Drawing.Size(279, 22);
            this.AddOnePrev.Text = "Dodaj punkt przed tym punktem";
            this.AddOnePrev.Click += new System.EventHandler(this.AddOnePrev_Click);
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(279, 22);
            this.RemoveSelected.Text = "Usuń ten punkt";
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // EditSelected
            // 
            this.EditSelected.Name = "EditSelected";
            this.EditSelected.Size = new System.Drawing.Size(279, 22);
            this.EditSelected.Text = "Edytuj wybrany punkt";
            this.EditSelected.Click += new System.EventHandler(this.EditSelected_Click);
            // 
            // AddOneNext
            // 
            this.AddOneNext.Name = "AddOneNext";
            this.AddOneNext.Size = new System.Drawing.Size(279, 22);
            this.AddOneNext.Text = "Dodaj punkt za tym punktem";
            this.AddOneNext.Click += new System.EventHandler(this.AddOneNext_Click);
            // 
            // RemoveAllNext
            // 
            this.RemoveAllNext.Name = "RemoveAllNext";
            this.RemoveAllNext.Size = new System.Drawing.Size(279, 22);
            this.RemoveAllNext.Text = "Usuń wszystkie punkty po tym punkcie";
            this.RemoveAllNext.Click += new System.EventHandler(this.RemoveAllNext_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.EditCancel);
            this.AddPanel.Controls.Add(this.EditAdd);
            this.AddPanel.Controls.Add(this.groupBox2);
            this.AddPanel.Controls.Add(this.groupBox1);
            this.AddPanel.Location = new System.Drawing.Point(185, 174);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(413, 132);
            this.AddPanel.TabIndex = 8;
            this.AddPanel.Visible = false;
            // 
            // EditCancel
            // 
            this.EditCancel.Location = new System.Drawing.Point(334, 103);
            this.EditCancel.Name = "EditCancel";
            this.EditCancel.Size = new System.Drawing.Size(75, 23);
            this.EditCancel.TabIndex = 7;
            this.EditCancel.Text = "Anuluj";
            this.EditCancel.UseVisualStyleBackColor = true;
            // 
            // EditAdd
            // 
            this.EditAdd.Location = new System.Drawing.Point(3, 103);
            this.EditAdd.Name = "EditAdd";
            this.EditAdd.Size = new System.Drawing.Size(325, 23);
            this.EditAdd.TabIndex = 6;
            this.EditAdd.Text = "Dodaj";
            this.EditAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EditEle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "wysokość(n.p.m) i czas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Format: RRRR-MM-DD GG:MM:SS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "data i czas:";
            // 
            // EditEle
            // 
            this.EditEle.DecimalPlaces = 4;
            this.EditEle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.EditEle.Location = new System.Drawing.Point(70, 24);
            this.EditEle.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.EditEle.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.EditEle.Name = "EditEle";
            this.EditEle.Size = new System.Drawing.Size(120, 20);
            this.EditEle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "wysokość:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditLat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EditLon);
            this.groupBox1.Controls.Add(this.labeledit);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Długość i szerokość geograficzna";
            // 
            // EditLat
            // 
            this.EditLat.Location = new System.Drawing.Point(70, 25);
            this.EditLat.Name = "EditLat";
            this.EditLat.Size = new System.Drawing.Size(120, 20);
            this.EditLat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "wysokość:";
            // 
            // EditLon
            // 
            this.EditLon.Location = new System.Drawing.Point(70, 55);
            this.EditLon.Name = "EditLon";
            this.EditLon.Size = new System.Drawing.Size(120, 20);
            this.EditLon.TabIndex = 1;
            // 
            // labeledit
            // 
            this.labeledit.AutoSize = true;
            this.labeledit.Location = new System.Drawing.Point(6, 27);
            this.labeledit.Name = "labeledit";
            this.labeledit.Size = new System.Drawing.Size(58, 13);
            this.labeledit.TabIndex = 2;
            this.labeledit.Text = "szerokość:";
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.AddCancel);
            this.EditPanel.Controls.Add(this.AddAdd);
            this.EditPanel.Controls.Add(this.groupBox3);
            this.EditPanel.Controls.Add(this.groupBox4);
            this.EditPanel.Location = new System.Drawing.Point(185, 343);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(413, 132);
            this.EditPanel.TabIndex = 9;
            // 
            // AddCancel
            // 
            this.AddCancel.Location = new System.Drawing.Point(334, 103);
            this.AddCancel.Name = "AddCancel";
            this.AddCancel.Size = new System.Drawing.Size(75, 23);
            this.AddCancel.TabIndex = 7;
            this.AddCancel.Text = "Anuluj";
            this.AddCancel.UseVisualStyleBackColor = true;
            // 
            // AddAdd
            // 
            this.AddAdd.Location = new System.Drawing.Point(3, 103);
            this.AddAdd.Name = "AddAdd";
            this.AddAdd.Size = new System.Drawing.Size(325, 23);
            this.AddAdd.TabIndex = 6;
            this.AddAdd.Text = "Dodaj";
            this.AddAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.AddEle);
            this.groupBox3.Controls.Add(this.AddTime);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(209, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 94);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "wysokość(n.p.m) i czas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Format: RRRR-MM-DD GG:MM:SS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "data i czas:";
            // 
            // AddEle
            // 
            this.AddEle.Location = new System.Drawing.Point(70, 24);
            this.AddEle.Name = "AddEle";
            this.AddEle.Size = new System.Drawing.Size(120, 20);
            this.AddEle.TabIndex = 4;
            // 
            // AddTime
            // 
            this.AddTime.Location = new System.Drawing.Point(70, 50);
            this.AddTime.Name = "AddTime";
            this.AddTime.Size = new System.Drawing.Size(120, 20);
            this.AddTime.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "wysokość:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AddLat);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.AddLon);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 94);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Długość i szerokość geograficzna";
            // 
            // AddLat
            // 
            this.AddLat.Location = new System.Drawing.Point(70, 25);
            this.AddLat.Name = "AddLat";
            this.AddLat.Size = new System.Drawing.Size(120, 20);
            this.AddLat.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "wysokość:";
            // 
            // AddLon
            // 
            this.AddLon.Location = new System.Drawing.Point(70, 55);
            this.AddLon.Name = "AddLon";
            this.AddLon.Size = new System.Drawing.Size(120, 20);
            this.AddLon.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "szerokość:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1100, 590);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.Graphs);
            this.Controls.Add(this.MinimalizeButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.MaximalizeButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.map);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "EdytorGPX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenu.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditEle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditLon)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTime)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddLon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MaximalizeButton;
        private System.Windows.Forms.Button MinimalizeButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Graphs;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllPrev;
        private System.Windows.Forms.ToolStripMenuItem AddOnePrev;
        private System.Windows.Forms.ToolStripMenuItem RemoveSelected;
        private System.Windows.Forms.ToolStripMenuItem AddOneNext;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllNext;
        private System.Windows.Forms.ToolStripMenuItem EditSelected;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown EditEle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown EditLat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EditLon;
        private System.Windows.Forms.Label labeledit;
        private System.Windows.Forms.Button EditCancel;
        private System.Windows.Forms.Button EditAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button AddCancel;
        private System.Windows.Forms.Button AddAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown AddEle;
        private System.Windows.Forms.NumericUpDown AddTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown AddLat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown AddLon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}

