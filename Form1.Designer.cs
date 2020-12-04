using System.Windows.Forms;

namespace Zad2_Mateusz_Moczarski
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.zoomOut = new System.Windows.Forms.Button();
            this.zoomIn = new System.Windows.Forms.Button();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.rotateRight = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.hScrollBarBrightness = new System.Windows.Forms.HScrollBar();
            this.buttonBrightness = new System.Windows.Forms.Button();
            this.hScrollBarContrast = new System.Windows.Forms.HScrollBar();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.buttonGamma = new System.Windows.Forms.Button();
            this.hScrollBarGamma = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRotate = new System.Windows.Forms.NumericUpDown();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonSizeChange = new System.Windows.Forms.Button();
            this.buttonHistogram = new System.Windows.Forms.Button();
            this.buttonG3 = new System.Windows.Forms.Button();
            this.buttonG2 = new System.Windows.Forms.Button();
            this.buttonG1 = new System.Windows.Forms.Button();
            this.buttonBW = new System.Windows.Forms.Button();
            this.buttonInversion = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonDetection = new System.Windows.Forms.Button();
            this.buttonColorFilter = new System.Windows.Forms.Button();
            this.comboBoxFiltr = new System.Windows.Forms.ComboBox();
            this.buttonBlur = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonOil = new System.Windows.Forms.Button();
            this.buttonLinear = new System.Windows.Forms.Button();
            this.buttonMedian = new System.Windows.Forms.Button();
            this.buttonLumination = new System.Windows.Forms.Button();
            this.buttonHistEq = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomOut
            // 
            this.zoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomOut.Location = new System.Drawing.Point(138, 663);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(111, 49);
            this.zoomOut.TabIndex = 7;
            this.zoomOut.Text = "Pomniejsz";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.ZoomMinus);
            // 
            // zoomIn
            // 
            this.zoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomIn.Location = new System.Drawing.Point(12, 664);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(111, 49);
            this.zoomIn.TabIndex = 7;
            this.zoomIn.Text = "Powiększ";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.ZoomPlus);
            // 
            // rotateLeft
            // 
            this.rotateLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateLeft.Location = new System.Drawing.Point(12, 608);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(111, 49);
            this.rotateLeft.TabIndex = 7;
            this.rotateLeft.Text = "Obróć w lewo";
            this.rotateLeft.UseVisualStyleBackColor = true;
            this.rotateLeft.Click += new System.EventHandler(this.RotateToLeft);
            // 
            // rotateRight
            // 
            this.rotateRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateRight.Location = new System.Drawing.Point(138, 608);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(111, 49);
            this.rotateRight.TabIndex = 7;
            this.rotateRight.Text = "Obróć w prawo";
            this.rotateRight.UseVisualStyleBackColor = true;
            this.rotateRight.Click += new System.EventHandler(this.RotateToRight);
            // 
            // openFile
            // 
            this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFile.Location = new System.Drawing.Point(12, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(105, 49);
            this.openFile.TabIndex = 7;
            this.openFile.Text = "Otwórz plik";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 715);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1350, 26);
            this.statusStrip.TabIndex = 9;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(0, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1095, 680);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 701);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obraz";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 67);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 47);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Czyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(138, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 49);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Zapisz plik";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // hScrollBarBrightness
            // 
            this.hScrollBarBrightness.Location = new System.Drawing.Point(93, 157);
            this.hScrollBarBrightness.Maximum = 255;
            this.hScrollBarBrightness.Minimum = 50;
            this.hScrollBarBrightness.Name = "hScrollBarBrightness";
            this.hScrollBarBrightness.Size = new System.Drawing.Size(159, 28);
            this.hScrollBarBrightness.TabIndex = 50;
            this.hScrollBarBrightness.Value = 50;
            // 
            // buttonBrightness
            // 
            this.buttonBrightness.Location = new System.Drawing.Point(12, 157);
            this.buttonBrightness.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrightness.Name = "buttonBrightness";
            this.buttonBrightness.Size = new System.Drawing.Size(77, 28);
            this.buttonBrightness.TabIndex = 49;
            this.buttonBrightness.Text = "Jasność";
            this.buttonBrightness.UseVisualStyleBackColor = true;
            this.buttonBrightness.Click += new System.EventHandler(this.buttonBrightness_Click);
            // 
            // hScrollBarContrast
            // 
            this.hScrollBarContrast.Location = new System.Drawing.Point(93, 121);
            this.hScrollBarContrast.Maximum = 255;
            this.hScrollBarContrast.Minimum = 50;
            this.hScrollBarContrast.Name = "hScrollBarContrast";
            this.hScrollBarContrast.Size = new System.Drawing.Size(159, 28);
            this.hScrollBarContrast.TabIndex = 48;
            this.hScrollBarContrast.Value = 50;
            // 
            // buttonContrast
            // 
            this.buttonContrast.Location = new System.Drawing.Point(12, 121);
            this.buttonContrast.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(77, 28);
            this.buttonContrast.TabIndex = 47;
            this.buttonContrast.Text = "Kontrast";
            this.buttonContrast.UseVisualStyleBackColor = true;
            this.buttonContrast.Click += new System.EventHandler(this.buttonContrast_Click);
            // 
            // buttonGamma
            // 
            this.buttonGamma.Location = new System.Drawing.Point(12, 189);
            this.buttonGamma.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGamma.Name = "buttonGamma";
            this.buttonGamma.Size = new System.Drawing.Size(77, 28);
            this.buttonGamma.TabIndex = 51;
            this.buttonGamma.Text = "Gamma";
            this.buttonGamma.UseVisualStyleBackColor = true;
            this.buttonGamma.Click += new System.EventHandler(this.buttonGamma_Click);
            // 
            // hScrollBarGamma
            // 
            this.hScrollBarGamma.Location = new System.Drawing.Point(93, 189);
            this.hScrollBarGamma.Maximum = 255;
            this.hScrollBarGamma.Minimum = 50;
            this.hScrollBarGamma.Name = "hScrollBarGamma";
            this.hScrollBarGamma.Size = new System.Drawing.Size(159, 28);
            this.hScrollBarGamma.TabIndex = 52;
            this.hScrollBarGamma.Value = 50;
            // 
            // numericUpDownRotate
            // 
            this.numericUpDownRotate.Location = new System.Drawing.Point(97, 225);
            this.numericUpDownRotate.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownRotate.Name = "numericUpDownRotate";
            this.numericUpDownRotate.Size = new System.Drawing.Size(155, 22);
            this.numericUpDownRotate.TabIndex = 54;
            this.numericUpDownRotate.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(12, 221);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(77, 28);
            this.buttonRotate.TabIndex = 53;
            this.buttonRotate.Text = "Obrot";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWidth.Location = new System.Drawing.Point(97, 279);
            this.numericUpDownWidth.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(155, 22);
            this.numericUpDownWidth.TabIndex = 57;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHeight.Location = new System.Drawing.Point(97, 257);
            this.numericUpDownHeight.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(155, 22);
            this.numericUpDownHeight.TabIndex = 56;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // buttonSizeChange
            // 
            this.buttonSizeChange.Location = new System.Drawing.Point(12, 257);
            this.buttonSizeChange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSizeChange.Name = "buttonSizeChange";
            this.buttonSizeChange.Size = new System.Drawing.Size(77, 44);
            this.buttonSizeChange.TabIndex = 55;
            this.buttonSizeChange.Text = "Zmiana Rozmiaru";
            this.buttonSizeChange.UseVisualStyleBackColor = true;
            this.buttonSizeChange.Click += new System.EventHandler(this.buttonSizeChange_Click);
            // 
            // buttonHistogram
            // 
            this.buttonHistogram.Location = new System.Drawing.Point(12, 573);
            this.buttonHistogram.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistogram.Name = "buttonHistogram";
            this.buttonHistogram.Size = new System.Drawing.Size(111, 28);
            this.buttonHistogram.TabIndex = 58;
            this.buttonHistogram.Text = "Histogram Sh";
            this.buttonHistogram.UseVisualStyleBackColor = true;
            this.buttonHistogram.Click += new System.EventHandler(this.buttonHistogram_Click);
            // 
            // buttonG3
            // 
            this.buttonG3.Location = new System.Drawing.Point(178, 537);
            this.buttonG3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonG3.Name = "buttonG3";
            this.buttonG3.Size = new System.Drawing.Size(71, 28);
            this.buttonG3.TabIndex = 61;
            this.buttonG3.Text = "Grey #3";
            this.buttonG3.UseVisualStyleBackColor = true;
            this.buttonG3.Click += new System.EventHandler(this.buttonG3_Click);
            // 
            // buttonG2
            // 
            this.buttonG2.Location = new System.Drawing.Point(97, 537);
            this.buttonG2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonG2.Name = "buttonG2";
            this.buttonG2.Size = new System.Drawing.Size(70, 28);
            this.buttonG2.TabIndex = 60;
            this.buttonG2.Text = "Grey #2";
            this.buttonG2.UseVisualStyleBackColor = true;
            this.buttonG2.Click += new System.EventHandler(this.buttonG2_Click);
            // 
            // buttonG1
            // 
            this.buttonG1.Location = new System.Drawing.Point(12, 537);
            this.buttonG1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonG1.Name = "buttonG1";
            this.buttonG1.Size = new System.Drawing.Size(69, 28);
            this.buttonG1.TabIndex = 59;
            this.buttonG1.Text = "Grey #1";
            this.buttonG1.UseVisualStyleBackColor = true;
            this.buttonG1.Click += new System.EventHandler(this.buttonG1_Click);
            // 
            // buttonBW
            // 
            this.buttonBW.Location = new System.Drawing.Point(137, 345);
            this.buttonBW.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBW.Name = "buttonBW";
            this.buttonBW.Size = new System.Drawing.Size(111, 28);
            this.buttonBW.TabIndex = 62;
            this.buttonBW.Text = "B/W";
            this.buttonBW.UseVisualStyleBackColor = true;
            this.buttonBW.Click += new System.EventHandler(this.buttonBW_Click);
            // 
            // buttonInversion
            // 
            this.buttonInversion.Location = new System.Drawing.Point(138, 501);
            this.buttonInversion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInversion.Name = "buttonInversion";
            this.buttonInversion.Size = new System.Drawing.Size(111, 28);
            this.buttonInversion.TabIndex = 64;
            this.buttonInversion.Text = "Inwersja";
            this.buttonInversion.UseVisualStyleBackColor = true;
            // 
            // buttonNegative
            // 
            this.buttonNegative.Location = new System.Drawing.Point(12, 501);
            this.buttonNegative.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(111, 28);
            this.buttonNegative.TabIndex = 63;
            this.buttonNegative.Text = "Negatyw";
            this.buttonNegative.UseVisualStyleBackColor = true;
            // 
            // buttonDetection
            // 
            this.buttonDetection.Location = new System.Drawing.Point(137, 68);
            this.buttonDetection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDetection.Name = "buttonDetection";
            this.buttonDetection.Size = new System.Drawing.Size(106, 46);
            this.buttonDetection.TabIndex = 65;
            this.buttonDetection.Text = "Detekcja Krawedzi";
            this.buttonDetection.UseVisualStyleBackColor = true;
            this.buttonDetection.Click += new System.EventHandler(this.buttonDetection_Click);
            // 
            // buttonColorFilter
            // 
            this.buttonColorFilter.Location = new System.Drawing.Point(12, 309);
            this.buttonColorFilter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonColorFilter.Name = "buttonColorFilter";
            this.buttonColorFilter.Size = new System.Drawing.Size(77, 28);
            this.buttonColorFilter.TabIndex = 66;
            this.buttonColorFilter.Text = "Filtr";
            this.buttonColorFilter.UseVisualStyleBackColor = true;
            this.buttonColorFilter.Click += new System.EventHandler(this.buttonColorFilter_Click);
            // 
            // comboBoxFiltr
            // 
            this.comboBoxFiltr.FormattingEnabled = true;
            this.comboBoxFiltr.Items.AddRange(new object[] {
            "Magenta",
            "Yellow",
            "Cyan",
            "Magenta-Yellow",
            "Cyan-Magenta",
            "Yellow-Cyan"});
            this.comboBoxFiltr.Location = new System.Drawing.Point(97, 312);
            this.comboBoxFiltr.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFiltr.Name = "comboBoxFiltr";
            this.comboBoxFiltr.Size = new System.Drawing.Size(159, 24);
            this.comboBoxFiltr.TabIndex = 67;
            // 
            // buttonBlur
            // 
            this.buttonBlur.Location = new System.Drawing.Point(137, 381);
            this.buttonBlur.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(111, 28);
            this.buttonBlur.TabIndex = 70;
            this.buttonBlur.Text = "Rozmycie";
            this.buttonBlur.UseVisualStyleBackColor = true;
            this.buttonBlur.Click += new System.EventHandler(this.buttonBlur_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 417);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(236, 28);
            this.buttonDraw.TabIndex = 69;
            this.buttonDraw.Text = "Szkic";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonOil
            // 
            this.buttonOil.Location = new System.Drawing.Point(137, 453);
            this.buttonOil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOil.Name = "buttonOil";
            this.buttonOil.Size = new System.Drawing.Size(111, 40);
            this.buttonOil.TabIndex = 68;
            this.buttonOil.Text = "Farba";
            this.buttonOil.UseVisualStyleBackColor = true;
            this.buttonOil.Click += new System.EventHandler(this.buttonOil_Click);
            // 
            // buttonLinear
            // 
            this.buttonLinear.Location = new System.Drawing.Point(12, 380);
            this.buttonLinear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLinear.Name = "buttonLinear";
            this.buttonLinear.Size = new System.Drawing.Size(111, 28);
            this.buttonLinear.TabIndex = 74;
            this.buttonLinear.Text = "Liniowo";
            this.buttonLinear.UseVisualStyleBackColor = true;
            this.buttonLinear.Click += new System.EventHandler(this.buttonLinear_Click);
            // 
            // buttonMedian
            // 
            this.buttonMedian.Location = new System.Drawing.Point(12, 345);
            this.buttonMedian.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMedian.Name = "buttonMedian";
            this.buttonMedian.Size = new System.Drawing.Size(111, 28);
            this.buttonMedian.TabIndex = 73;
            this.buttonMedian.Text = "Mediana";
            this.buttonMedian.UseVisualStyleBackColor = true;
            this.buttonMedian.Click += new System.EventHandler(this.buttonMedian_Click);
            // 
            // buttonLumination
            // 
            this.buttonLumination.Location = new System.Drawing.Point(12, 453);
            this.buttonLumination.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLumination.Name = "buttonLumination";
            this.buttonLumination.Size = new System.Drawing.Size(111, 40);
            this.buttonLumination.TabIndex = 72;
            this.buttonLumination.Text = "Luminacja";
            this.buttonLumination.UseVisualStyleBackColor = true;
            this.buttonLumination.Click += new System.EventHandler(this.buttonLumination_Click);
            // 
            // buttonHistEq
            // 
            this.buttonHistEq.Location = new System.Drawing.Point(138, 573);
            this.buttonHistEq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistEq.Name = "buttonHistEq";
            this.buttonHistEq.Size = new System.Drawing.Size(111, 28);
            this.buttonHistEq.TabIndex = 75;
            this.buttonHistEq.Text = "Histogram Eq";
            this.buttonHistEq.UseVisualStyleBackColor = true;
            this.buttonHistEq.Click += new System.EventHandler(this.buttonHistEq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 741);
            this.Controls.Add(this.buttonHistEq);
            this.Controls.Add(this.buttonLinear);
            this.Controls.Add(this.buttonMedian);
            this.Controls.Add(this.buttonLumination);
            this.Controls.Add(this.buttonBlur);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonOil);
            this.Controls.Add(this.comboBoxFiltr);
            this.Controls.Add(this.buttonColorFilter);
            this.Controls.Add(this.buttonDetection);
            this.Controls.Add(this.buttonInversion);
            this.Controls.Add(this.buttonNegative);
            this.Controls.Add(this.buttonBW);
            this.Controls.Add(this.buttonG3);
            this.Controls.Add(this.buttonG2);
            this.Controls.Add(this.buttonG1);
            this.Controls.Add(this.buttonHistogram);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.buttonSizeChange);
            this.Controls.Add(this.numericUpDownRotate);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.hScrollBarGamma);
            this.Controls.Add(this.buttonGamma);
            this.Controls.Add(this.hScrollBarBrightness);
            this.Controls.Add(this.buttonBrightness);
            this.Controls.Add(this.hScrollBarContrast);
            this.Controls.Add(this.buttonContrast);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.rotateLeft);
            this.Controls.Add(this.rotateRight);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.zoomOut);
            this.MinimumSize = new System.Drawing.Size(1368, 788);
            this.Name = "Form1";
            this.Text = "Przeglądarka obrazów by Moczarski";
            this.ResizeEnd += new System.EventHandler(this.ChangeSize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button rotateLeft;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox;
        private GroupBox groupBox1;
        private Button buttonClear;
        private Button buttonSave;
        private HScrollBar hScrollBarBrightness;
        private Button buttonBrightness;
        private HScrollBar hScrollBarContrast;
        private Button buttonContrast;
        private Button buttonGamma;
        private HScrollBar hScrollBarGamma;
        private NumericUpDown numericUpDownRotate;
        private Button buttonRotate;
        private NumericUpDown numericUpDownWidth;
        private NumericUpDown numericUpDownHeight;
        private Button buttonSizeChange;
        private Button buttonHistogram;
        private Button buttonG3;
        private Button buttonG2;
        private Button buttonG1;
        private Button buttonBW;
        private Button buttonInversion;
        private Button buttonNegative;
        private Button buttonDetection;
        private Button buttonColorFilter;
        private ComboBox comboBoxFiltr;
        private Button buttonBlur;
        private Button buttonDraw;
        private Button buttonOil;
        private Button buttonLinear;
        private Button buttonMedian;
        private Button buttonLumination;
        private Button buttonHistEq;
    }
}

