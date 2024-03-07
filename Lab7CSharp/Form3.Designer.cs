namespace Lab7CSharp
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.starRadioButton = new System.Windows.Forms.RadioButton();
            this.recRadioButton = new System.Windows.Forms.RadioButton();
            this.sectorRadioButton = new System.Windows.Forms.RadioButton();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.circleGroupBox = new System.Windows.Forms.GroupBox();
            this.circleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circleTextBox = new System.Windows.Forms.TextBox();
            this.colorCircleButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.recGroupBox = new System.Windows.Forms.GroupBox();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recTextBox = new System.Windows.Forms.TextBox();
            this.colorRecButton = new System.Windows.Forms.Button();
            this.starGroupBox = new System.Windows.Forms.GroupBox();
            this.starA_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.starRI_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.starRO_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.starTextBox = new System.Windows.Forms.TextBox();
            this.colorStarButton = new System.Windows.Forms.Button();
            this.sectorGroupBox = new System.Windows.Forms.GroupBox();
            this.sectorR_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sectorASW_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.sectorAS_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sectorTextBox = new System.Windows.Forms.TextBox();
            this.colorSectorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.circleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleNumericUpDown)).BeginInit();
            this.recGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            this.starGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starA_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starRI_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starRO_NumericUpDown)).BeginInit();
            this.sectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorR_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorASW_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorAS_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(502, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.starRadioButton);
            this.groupBox1.Controls.Add(this.recRadioButton);
            this.groupBox1.Controls.Add(this.sectorRadioButton);
            this.groupBox1.Controls.Add(this.circleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(22, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure";
            // 
            // starRadioButton
            // 
            this.starRadioButton.AutoSize = true;
            this.starRadioButton.Location = new System.Drawing.Point(6, 125);
            this.starRadioButton.Name = "starRadioButton";
            this.starRadioButton.Size = new System.Drawing.Size(64, 24);
            this.starRadioButton.TabIndex = 3;
            this.starRadioButton.TabStop = true;
            this.starRadioButton.Text = "Star";
            this.starRadioButton.UseVisualStyleBackColor = true;
            this.starRadioButton.CheckedChanged += new System.EventHandler(this.starRadioButton_CheckedChanged);
            // 
            // recRadioButton
            // 
            this.recRadioButton.AutoSize = true;
            this.recRadioButton.Location = new System.Drawing.Point(6, 95);
            this.recRadioButton.Name = "recRadioButton";
            this.recRadioButton.Size = new System.Drawing.Size(107, 24);
            this.recRadioButton.TabIndex = 2;
            this.recRadioButton.TabStop = true;
            this.recRadioButton.Text = "Rectangle";
            this.recRadioButton.UseVisualStyleBackColor = true;
            this.recRadioButton.CheckedChanged += new System.EventHandler(this.rectangleRadioButton_CheckedChanged);
            // 
            // sectorRadioButton
            // 
            this.sectorRadioButton.AutoSize = true;
            this.sectorRadioButton.Location = new System.Drawing.Point(6, 65);
            this.sectorRadioButton.Name = "sectorRadioButton";
            this.sectorRadioButton.Size = new System.Drawing.Size(81, 24);
            this.sectorRadioButton.TabIndex = 1;
            this.sectorRadioButton.TabStop = true;
            this.sectorRadioButton.Text = "Sector";
            this.sectorRadioButton.UseVisualStyleBackColor = true;
            this.sectorRadioButton.CheckedChanged += new System.EventHandler(this.sectorRadioButton_CheckedChanged);
            // 
            // circleRadioButton
            // 
            this.circleRadioButton.AutoSize = true;
            this.circleRadioButton.Location = new System.Drawing.Point(6, 35);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(73, 24);
            this.circleRadioButton.TabIndex = 0;
            this.circleRadioButton.TabStop = true;
            this.circleRadioButton.Text = "Circle";
            this.circleRadioButton.UseVisualStyleBackColor = true;
            this.circleRadioButton.CheckedChanged += new System.EventHandler(this.cirleRadioButton_CheckedChanged);
            // 
            // circleGroupBox
            // 
            this.circleGroupBox.Controls.Add(this.circleNumericUpDown);
            this.circleGroupBox.Controls.Add(this.label2);
            this.circleGroupBox.Controls.Add(this.label1);
            this.circleGroupBox.Controls.Add(this.circleTextBox);
            this.circleGroupBox.Controls.Add(this.colorCircleButton);
            this.circleGroupBox.Location = new System.Drawing.Point(201, 28);
            this.circleGroupBox.Name = "circleGroupBox";
            this.circleGroupBox.Size = new System.Drawing.Size(295, 163);
            this.circleGroupBox.TabIndex = 2;
            this.circleGroupBox.TabStop = false;
            this.circleGroupBox.Text = "Parametrs:";
            // 
            // circleNumericUpDown
            // 
            this.circleNumericUpDown.Location = new System.Drawing.Point(167, 49);
            this.circleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.circleNumericUpDown.Name = "circleNumericUpDown";
            this.circleNumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.circleNumericUpDown.TabIndex = 5;
            this.circleNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Radius:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text:";
            // 
            // circleTextBox
            // 
            this.circleTextBox.Location = new System.Drawing.Point(140, 115);
            this.circleTextBox.Name = "circleTextBox";
            this.circleTextBox.Size = new System.Drawing.Size(128, 26);
            this.circleTextBox.TabIndex = 1;
            // 
            // colorCircleButton
            // 
            this.colorCircleButton.Location = new System.Drawing.Point(29, 49);
            this.colorCircleButton.Name = "colorCircleButton";
            this.colorCircleButton.Size = new System.Drawing.Size(75, 70);
            this.colorCircleButton.TabIndex = 0;
            this.colorCircleButton.Text = "Color";
            this.colorCircleButton.UseVisualStyleBackColor = true;
            this.colorCircleButton.Click += new System.EventHandler(this.colorCircleButton_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(22, 226);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(474, 220);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 468);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(173, 39);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(323, 468);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(173, 39);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // recGroupBox
            // 
            this.recGroupBox.Controls.Add(this.heightNumericUpDown);
            this.recGroupBox.Controls.Add(this.label9);
            this.recGroupBox.Controls.Add(this.weightNumericUpDown);
            this.recGroupBox.Controls.Add(this.label5);
            this.recGroupBox.Controls.Add(this.label6);
            this.recGroupBox.Controls.Add(this.recTextBox);
            this.recGroupBox.Controls.Add(this.colorRecButton);
            this.recGroupBox.Location = new System.Drawing.Point(174, 28);
            this.recGroupBox.Name = "recGroupBox";
            this.recGroupBox.Size = new System.Drawing.Size(295, 167);
            this.recGroupBox.TabIndex = 6;
            this.recGroupBox.TabStop = false;
            this.recGroupBox.Text = "Parametrs:";
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(200, 55);
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.heightNumericUpDown.TabIndex = 7;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Height:";
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.Location = new System.Drawing.Point(116, 55);
            this.weightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.weightNumericUpDown.TabIndex = 5;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Text:";
            // 
            // recTextBox
            // 
            this.recTextBox.Location = new System.Drawing.Point(140, 115);
            this.recTextBox.Name = "recTextBox";
            this.recTextBox.Size = new System.Drawing.Size(128, 26);
            this.recTextBox.TabIndex = 1;
            // 
            // colorRecButton
            // 
            this.colorRecButton.Location = new System.Drawing.Point(29, 49);
            this.colorRecButton.Name = "colorRecButton";
            this.colorRecButton.Size = new System.Drawing.Size(75, 70);
            this.colorRecButton.TabIndex = 0;
            this.colorRecButton.Text = "Color";
            this.colorRecButton.UseVisualStyleBackColor = true;
            this.colorRecButton.Click += new System.EventHandler(this.colorRecButton_Click);
            // 
            // starGroupBox
            // 
            this.starGroupBox.Controls.Add(this.starA_NumericUpDown);
            this.starGroupBox.Controls.Add(this.label11);
            this.starGroupBox.Controls.Add(this.starRI_NumericUpDown);
            this.starGroupBox.Controls.Add(this.label10);
            this.starGroupBox.Controls.Add(this.starRO_NumericUpDown);
            this.starGroupBox.Controls.Add(this.label7);
            this.starGroupBox.Controls.Add(this.label8);
            this.starGroupBox.Controls.Add(this.starTextBox);
            this.starGroupBox.Controls.Add(this.colorStarButton);
            this.starGroupBox.Location = new System.Drawing.Point(180, 12);
            this.starGroupBox.Name = "starGroupBox";
            this.starGroupBox.Size = new System.Drawing.Size(310, 188);
            this.starGroupBox.TabIndex = 6;
            this.starGroupBox.TabStop = false;
            this.starGroupBox.Text = "Parametrs:";
            // 
            // starA_NumericUpDown
            // 
            this.starA_NumericUpDown.Location = new System.Drawing.Point(164, 108);
            this.starA_NumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.starA_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.starA_NumericUpDown.Name = "starA_NumericUpDown";
            this.starA_NumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.starA_NumericUpDown.TabIndex = 9;
            this.starA_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Angle:";
            // 
            // starRI_NumericUpDown
            // 
            this.starRI_NumericUpDown.Location = new System.Drawing.Point(214, 45);
            this.starRI_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.starRI_NumericUpDown.Name = "starRI_NumericUpDown";
            this.starRI_NumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.starRI_NumericUpDown.TabIndex = 7;
            this.starRI_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Radius(in):";
            // 
            // starRO_NumericUpDown
            // 
            this.starRO_NumericUpDown.Location = new System.Drawing.Point(122, 45);
            this.starRO_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.starRO_NumericUpDown.Name = "starRO_NumericUpDown";
            this.starRO_NumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.starRO_NumericUpDown.TabIndex = 5;
            this.starRO_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Radius(out):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Text:";
            // 
            // starTextBox
            // 
            this.starTextBox.Location = new System.Drawing.Point(134, 144);
            this.starTextBox.Name = "starTextBox";
            this.starTextBox.Size = new System.Drawing.Size(128, 26);
            this.starTextBox.TabIndex = 1;
            // 
            // colorStarButton
            // 
            this.colorStarButton.Location = new System.Drawing.Point(26, 64);
            this.colorStarButton.Name = "colorStarButton";
            this.colorStarButton.Size = new System.Drawing.Size(75, 70);
            this.colorStarButton.TabIndex = 0;
            this.colorStarButton.Text = "Color";
            this.colorStarButton.UseVisualStyleBackColor = true;
            this.colorStarButton.Click += new System.EventHandler(this.colorStarButton_Click);
            // 
            // sectorGroupBox
            // 
            this.sectorGroupBox.Controls.Add(this.sectorR_NumericUpDown);
            this.sectorGroupBox.Controls.Add(this.label3);
            this.sectorGroupBox.Controls.Add(this.sectorASW_NumericUpDown);
            this.sectorGroupBox.Controls.Add(this.label4);
            this.sectorGroupBox.Controls.Add(this.sectorAS_NumericUpDown);
            this.sectorGroupBox.Controls.Add(this.label12);
            this.sectorGroupBox.Controls.Add(this.label13);
            this.sectorGroupBox.Controls.Add(this.sectorTextBox);
            this.sectorGroupBox.Controls.Add(this.colorSectorButton);
            this.sectorGroupBox.Location = new System.Drawing.Point(189, 7);
            this.sectorGroupBox.Name = "sectorGroupBox";
            this.sectorGroupBox.Size = new System.Drawing.Size(295, 188);
            this.sectorGroupBox.TabIndex = 10;
            this.sectorGroupBox.TabStop = false;
            this.sectorGroupBox.Text = "Parametrs:";
            // 
            // sectorR_NumericUpDown
            // 
            this.sectorR_NumericUpDown.Location = new System.Drawing.Point(164, 109);
            this.sectorR_NumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.sectorR_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sectorR_NumericUpDown.Name = "sectorR_NumericUpDown";
            this.sectorR_NumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.sectorR_NumericUpDown.TabIndex = 9;
            this.sectorR_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Radius:";
            // 
            // sectorASW_NumericUpDown
            // 
            this.sectorASW_NumericUpDown.Location = new System.Drawing.Point(195, 41);
            this.sectorASW_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sectorASW_NumericUpDown.Name = "sectorASW_NumericUpDown";
            this.sectorASW_NumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.sectorASW_NumericUpDown.TabIndex = 7;
            this.sectorASW_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Angle(sweep):";
            // 
            // sectorAS_NumericUpDown
            // 
            this.sectorAS_NumericUpDown.Location = new System.Drawing.Point(105, 44);
            this.sectorAS_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sectorAS_NumericUpDown.Name = "sectorAS_NumericUpDown";
            this.sectorAS_NumericUpDown.Size = new System.Drawing.Size(77, 26);
            this.sectorAS_NumericUpDown.TabIndex = 5;
            this.sectorAS_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(91, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Angle(start):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(85, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Text:";
            // 
            // sectorTextBox
            // 
            this.sectorTextBox.Location = new System.Drawing.Point(134, 144);
            this.sectorTextBox.Name = "sectorTextBox";
            this.sectorTextBox.Size = new System.Drawing.Size(128, 26);
            this.sectorTextBox.TabIndex = 1;
            // 
            // colorSectorButton
            // 
            this.colorSectorButton.Location = new System.Drawing.Point(25, 74);
            this.colorSectorButton.Name = "colorSectorButton";
            this.colorSectorButton.Size = new System.Drawing.Size(75, 70);
            this.colorSectorButton.TabIndex = 0;
            this.colorSectorButton.Text = "Color";
            this.colorSectorButton.UseVisualStyleBackColor = true;
            this.colorSectorButton.Click += new System.EventHandler(this.colorSectorButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 526);
            this.Controls.Add(this.sectorGroupBox);
            this.Controls.Add(this.recGroupBox);
            this.Controls.Add(this.starGroupBox);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.circleGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.circleGroupBox.ResumeLayout(false);
            this.circleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleNumericUpDown)).EndInit();
            this.recGroupBox.ResumeLayout(false);
            this.recGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            this.starGroupBox.ResumeLayout(false);
            this.starGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starA_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starRI_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starRO_NumericUpDown)).EndInit();
            this.sectorGroupBox.ResumeLayout(false);
            this.sectorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorR_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorASW_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorAS_NumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton starRadioButton;
        private System.Windows.Forms.RadioButton recRadioButton;
        private System.Windows.Forms.RadioButton sectorRadioButton;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.GroupBox circleGroupBox;
        private System.Windows.Forms.Button colorCircleButton;
        private System.Windows.Forms.TextBox circleTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown circleNumericUpDown;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.GroupBox recGroupBox;
        private System.Windows.Forms.GroupBox starGroupBox;
        private System.Windows.Forms.NumericUpDown starRO_NumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox starTextBox;
        private System.Windows.Forms.Button colorStarButton;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recTextBox;
        private System.Windows.Forms.Button colorRecButton;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown starRI_NumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown starA_NumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox sectorGroupBox;
        private System.Windows.Forms.NumericUpDown sectorR_NumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sectorASW_NumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sectorAS_NumericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sectorTextBox;
        private System.Windows.Forms.Button colorSectorButton;
    }
}