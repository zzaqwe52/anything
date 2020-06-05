namespace VPro_Align
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.cogRecordDisplay2 = new Cognex.VisionPro.CogRecordDisplay();
            this.cogToolBlockEditV21 = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
            this.radio_PX1 = new System.Windows.Forms.RadioButton();
            this.radio_PX2 = new System.Windows.Forms.RadioButton();
            this.radio_EX1 = new System.Windows.Forms.RadioButton();
            this.radio_CC2 = new System.Windows.Forms.RadioButton();
            this.radio_CC1 = new System.Windows.Forms.RadioButton();
            this.radio_EX2 = new System.Windows.Forms.RadioButton();
            this.radio_ImageMode2 = new System.Windows.Forms.RadioButton();
            this.radio_ImageMode1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Serial1 = new System.Windows.Forms.TextBox();
            this.txt_Serial2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ImgPath1 = new System.Windows.Forms.TextBox();
            this.txt_ImgPath2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Btn_Grab = new System.Windows.Forms.Button();
            this.Btn_LiveStart = new System.Windows.Forms.Button();
            this.Btn_LiveStop = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_PxSize2 = new System.Windows.Forms.TextBox();
            this.txt_PxSize1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txt_CalExICurPosX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CalExICurPosY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CalExIndex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.txt_AlignY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_AlignX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_AlignT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(3, 31);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(374, 285);
            this.cogRecordDisplay1.TabIndex = 0;
            // 
            // cogRecordDisplay2
            // 
            this.cogRecordDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay2.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay2.Location = new System.Drawing.Point(383, 31);
            this.cogRecordDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay2.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay2.Name = "cogRecordDisplay2";
            this.cogRecordDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay2.OcxState")));
            this.cogRecordDisplay2.Size = new System.Drawing.Size(374, 285);
            this.cogRecordDisplay2.TabIndex = 1;
            // 
            // cogToolBlockEditV21
            // 
            this.cogToolBlockEditV21.AllowDrop = true;
            this.cogToolBlockEditV21.ContextMenuCustomizer = null;
            this.cogToolBlockEditV21.Location = new System.Drawing.Point(3, 331);
            this.cogToolBlockEditV21.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogToolBlockEditV21.Name = "cogToolBlockEditV21";
            this.cogToolBlockEditV21.ShowNodeToolTips = true;
            this.cogToolBlockEditV21.Size = new System.Drawing.Size(754, 284);
            this.cogToolBlockEditV21.SuspendElectricRuns = false;
            this.cogToolBlockEditV21.TabIndex = 2;
            // 
            // radio_PX1
            // 
            this.radio_PX1.AutoSize = true;
            this.radio_PX1.Location = new System.Drawing.Point(10, 21);
            this.radio_PX1.Name = "radio_PX1";
            this.radio_PX1.Size = new System.Drawing.Size(117, 16);
            this.radio_PX1.TabIndex = 1;
            this.radio_PX1.Text = "Pixel Size Cam1";
            this.radio_PX1.UseVisualStyleBackColor = true;
            this.radio_PX1.CheckedChanged += new System.EventHandler(this.radio_PX1_CheckedChanged);
            // 
            // radio_PX2
            // 
            this.radio_PX2.AutoSize = true;
            this.radio_PX2.Location = new System.Drawing.Point(128, 21);
            this.radio_PX2.Name = "radio_PX2";
            this.radio_PX2.Size = new System.Drawing.Size(117, 16);
            this.radio_PX2.TabIndex = 1;
            this.radio_PX2.Text = "Pixel Size Cam2";
            this.radio_PX2.UseVisualStyleBackColor = true;
            this.radio_PX2.CheckedChanged += new System.EventHandler(this.radio_PX2_CheckedChanged);
            // 
            // radio_EX1
            // 
            this.radio_EX1.AutoSize = true;
            this.radio_EX1.Location = new System.Drawing.Point(274, 21);
            this.radio_EX1.Name = "radio_EX1";
            this.radio_EX1.Size = new System.Drawing.Size(99, 16);
            this.radio_EX1.TabIndex = 2;
            this.radio_EX1.Text = "Extract Cam1";
            this.radio_EX1.UseVisualStyleBackColor = true;
            this.radio_EX1.CheckedChanged += new System.EventHandler(this.radio_EX1_CheckedChanged);
            // 
            // radio_CC2
            // 
            this.radio_CC2.AutoSize = true;
            this.radio_CC2.Location = new System.Drawing.Point(620, 20);
            this.radio_CC2.Name = "radio_CC2";
            this.radio_CC2.Size = new System.Drawing.Size(119, 16);
            this.radio_CC2.TabIndex = 6;
            this.radio_CC2.TabStop = true;
            this.radio_CC2.Text = "Calc Calib Cam1";
            this.radio_CC2.UseVisualStyleBackColor = true;
            this.radio_CC2.CheckedChanged += new System.EventHandler(this.radio_CC2_CheckedChanged);
            // 
            // radio_CC1
            // 
            this.radio_CC1.AutoSize = true;
            this.radio_CC1.Location = new System.Drawing.Point(502, 21);
            this.radio_CC1.Name = "radio_CC1";
            this.radio_CC1.Size = new System.Drawing.Size(119, 16);
            this.radio_CC1.TabIndex = 5;
            this.radio_CC1.Text = "Calc Calib Cam1";
            this.radio_CC1.UseVisualStyleBackColor = true;
            this.radio_CC1.CheckedChanged += new System.EventHandler(this.radio_CC1_CheckedChanged);
            // 
            // radio_EX2
            // 
            this.radio_EX2.AutoSize = true;
            this.radio_EX2.Location = new System.Drawing.Point(375, 21);
            this.radio_EX2.Name = "radio_EX2";
            this.radio_EX2.Size = new System.Drawing.Size(99, 16);
            this.radio_EX2.TabIndex = 2;
            this.radio_EX2.Text = "Extract Cam2";
            this.radio_EX2.UseVisualStyleBackColor = true;
            this.radio_EX2.CheckedChanged += new System.EventHandler(this.radio_EX2_CheckedChanged);
            // 
            // radio_ImageMode2
            // 
            this.radio_ImageMode2.AutoSize = true;
            this.radio_ImageMode2.Location = new System.Drawing.Point(136, 20);
            this.radio_ImageMode2.Name = "radio_ImageMode2";
            this.radio_ImageMode2.Size = new System.Drawing.Size(87, 16);
            this.radio_ImageMode2.TabIndex = 8;
            this.radio_ImageMode2.TabStop = true;
            this.radio_ImageMode2.Text = "이미지 사용";
            this.radio_ImageMode2.UseVisualStyleBackColor = true;
            // 
            // radio_ImageMode1
            // 
            this.radio_ImageMode1.AutoSize = true;
            this.radio_ImageMode1.Location = new System.Drawing.Point(19, 20);
            this.radio_ImageMode1.Name = "radio_ImageMode1";
            this.radio_ImageMode1.Size = new System.Drawing.Size(87, 16);
            this.radio_ImageMode1.TabIndex = 7;
            this.radio_ImageMode1.Text = "카메라 사용";
            this.radio_ImageMode1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Serial Cam1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(785, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Serial Cam2";
            // 
            // txt_Serial1
            // 
            this.txt_Serial1.Location = new System.Drawing.Point(873, 70);
            this.txt_Serial1.Name = "txt_Serial1";
            this.txt_Serial1.Size = new System.Drawing.Size(100, 21);
            this.txt_Serial1.TabIndex = 13;
            // 
            // txt_Serial2
            // 
            this.txt_Serial2.Location = new System.Drawing.Point(873, 101);
            this.txt_Serial2.Name = "txt_Serial2";
            this.txt_Serial2.Size = new System.Drawing.Size(100, 21);
            this.txt_Serial2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(979, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(980, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(789, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Image 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(789, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Image 2";
            // 
            // txt_ImgPath1
            // 
            this.txt_ImgPath1.Location = new System.Drawing.Point(851, 149);
            this.txt_ImgPath1.Name = "txt_ImgPath1";
            this.txt_ImgPath1.Size = new System.Drawing.Size(182, 21);
            this.txt_ImgPath1.TabIndex = 19;
            // 
            // txt_ImgPath2
            // 
            this.txt_ImgPath2.Location = new System.Drawing.Point(851, 178);
            this.txt_ImgPath2.Name = "txt_ImgPath2";
            this.txt_ImgPath2.Size = new System.Drawing.Size(182, 21);
            this.txt_ImgPath2.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1039, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1039, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Btn_Grab
            // 
            this.Btn_Grab.Location = new System.Drawing.Point(787, 229);
            this.Btn_Grab.Name = "Btn_Grab";
            this.Btn_Grab.Size = new System.Drawing.Size(75, 23);
            this.Btn_Grab.TabIndex = 23;
            this.Btn_Grab.Text = "Grab";
            this.Btn_Grab.UseVisualStyleBackColor = true;
            this.Btn_Grab.Click += new System.EventHandler(this.Btn_Grab_Click);
            // 
            // Btn_LiveStart
            // 
            this.Btn_LiveStart.Location = new System.Drawing.Point(868, 229);
            this.Btn_LiveStart.Name = "Btn_LiveStart";
            this.Btn_LiveStart.Size = new System.Drawing.Size(75, 23);
            this.Btn_LiveStart.TabIndex = 24;
            this.Btn_LiveStart.Text = "Live 시작";
            this.Btn_LiveStart.UseVisualStyleBackColor = true;
            this.Btn_LiveStart.Click += new System.EventHandler(this.Btn_LiveStart_Click);
            // 
            // Btn_LiveStop
            // 
            this.Btn_LiveStop.Location = new System.Drawing.Point(949, 229);
            this.Btn_LiveStop.Name = "Btn_LiveStop";
            this.Btn_LiveStop.Size = new System.Drawing.Size(75, 23);
            this.Btn_LiveStop.TabIndex = 25;
            this.Btn_LiveStop.Text = "Live 중지";
            this.Btn_LiveStop.UseVisualStyleBackColor = true;
            this.Btn_LiveStop.Click += new System.EventHandler(this.Btn_LiveStop_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(787, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Pixel Run Cam1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(910, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Pixel Run Cam2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_PxSize2
            // 
            this.txt_PxSize2.Location = new System.Drawing.Point(888, 344);
            this.txt_PxSize2.Name = "txt_PxSize2";
            this.txt_PxSize2.Size = new System.Drawing.Size(127, 21);
            this.txt_PxSize2.TabIndex = 31;
            // 
            // txt_PxSize1
            // 
            this.txt_PxSize1.Location = new System.Drawing.Point(888, 317);
            this.txt_PxSize1.Name = "txt_PxSize1";
            this.txt_PxSize1.Size = new System.Drawing.Size(127, 21);
            this.txt_PxSize1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "PixelSeze Cam2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(783, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "PixelSize Cam1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(781, 414);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 23);
            this.button7.TabIndex = 32;
            this.button7.Text = "Init Cal";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txt_CalExICurPosX
            // 
            this.txt_CalExICurPosX.Location = new System.Drawing.Point(812, 443);
            this.txt_CalExICurPosX.Name = "txt_CalExICurPosX";
            this.txt_CalExICurPosX.Size = new System.Drawing.Size(86, 21);
            this.txt_CalExICurPosX.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(789, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "X";
            // 
            // txt_CalExICurPosY
            // 
            this.txt_CalExICurPosY.Location = new System.Drawing.Point(937, 443);
            this.txt_CalExICurPosY.Name = "txt_CalExICurPosY";
            this.txt_CalExICurPosY.Size = new System.Drawing.Size(86, 21);
            this.txt_CalExICurPosY.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(914, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "Y";
            // 
            // txt_CalExIndex
            // 
            this.txt_CalExIndex.Location = new System.Drawing.Point(956, 414);
            this.txt_CalExIndex.Name = "txt_CalExIndex";
            this.txt_CalExIndex.Size = new System.Drawing.Size(67, 21);
            this.txt_CalExIndex.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(914, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 12);
            this.label9.TabIndex = 37;
            this.label9.Text = "Index";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1029, 411);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 53);
            this.button8.TabIndex = 39;
            this.button8.Text = "Run Extract";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(785, 507);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 23);
            this.button9.TabIndex = 40;
            this.button9.Text = "Calc Calib Cam1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(910, 507);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 23);
            this.button10.TabIndex = 41;
            this.button10.Text = "Calc Calib Cam2";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(785, 565);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 23);
            this.button11.TabIndex = 42;
            this.button11.Text = "Align Cam1";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(110, 20);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(93, 23);
            this.button12.TabIndex = 43;
            this.button12.Text = "Align Cam2";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(209, 20);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(93, 23);
            this.button13.TabIndex = 44;
            this.button13.Text = "Compute";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // txt_AlignY
            // 
            this.txt_AlignY.Location = new System.Drawing.Point(120, 45);
            this.txt_AlignY.Name = "txt_AlignY";
            this.txt_AlignY.Size = new System.Drawing.Size(56, 21);
            this.txt_AlignY.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 12);
            this.label10.TabIndex = 47;
            this.label10.Text = "Y";
            // 
            // txt_AlignX
            // 
            this.txt_AlignX.Location = new System.Drawing.Point(806, 590);
            this.txt_AlignX.Name = "txt_AlignX";
            this.txt_AlignX.Size = new System.Drawing.Size(56, 21);
            this.txt_AlignX.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(783, 598);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 12);
            this.label11.TabIndex = 45;
            this.label11.Text = "X";
            // 
            // txt_AlignT
            // 
            this.txt_AlignT.Location = new System.Drawing.Point(209, 44);
            this.txt_AlignT.Name = "txt_AlignT";
            this.txt_AlignT.Size = new System.Drawing.Size(56, 21);
            this.txt_AlignT.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(186, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 12);
            this.label12.TabIndex = 49;
            this.label12.Text = "T";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 12);
            this.label13.TabIndex = 51;
            this.label13.Text = "Cam1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 12);
            this.label14.TabIndex = 52;
            this.label14.Text = "Cam2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_ImageMode2);
            this.groupBox1.Controls.Add(this.radio_ImageMode1);
            this.groupBox1.Location = new System.Drawing.Point(774, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 240);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(774, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 123);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calc Pixel Size";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(774, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 87);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Feature Extract";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(774, 485);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 54);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calc Calibration Result";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Controls.Add(this.button13);
            this.groupBox5.Controls.Add(this.txt_AlignT);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txt_AlignY);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(774, 545);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 70);
            this.groupBox5.TabIndex = 57;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calc Calibration Result";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(997, 643);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(117, 23);
            this.button14.TabIndex = 58;
            this.button14.Text = "Exit";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radio_CC2);
            this.groupBox6.Controls.Add(this.radio_PX1);
            this.groupBox6.Controls.Add(this.radio_PX2);
            this.groupBox6.Controls.Add(this.radio_EX1);
            this.groupBox6.Controls.Add(this.radio_EX2);
            this.groupBox6.Controls.Add(this.radio_CC1);
            this.groupBox6.Location = new System.Drawing.Point(13, 621);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(744, 45);
            this.groupBox6.TabIndex = 59;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tool Block Mode";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(763, 643);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(117, 23);
            this.button15.TabIndex = 60;
            this.button15.Text = "Run&Save";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(1059, 306);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(81, 53);
            this.button16.TabIndex = 61;
            this.button16.Text = "Calib Data Save";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 678);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_AlignX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txt_CalExIndex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_CalExICurPosY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_CalExICurPosX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txt_PxSize2);
            this.Controls.Add(this.txt_PxSize1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Btn_LiveStop);
            this.Controls.Add(this.Btn_LiveStart);
            this.Controls.Add(this.Btn_Grab);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_ImgPath2);
            this.Controls.Add(this.txt_ImgPath1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Serial2);
            this.Controls.Add(this.txt_Serial1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cogToolBlockEditV21);
            this.Controls.Add(this.cogRecordDisplay2);
            this.Controls.Add(this.cogRecordDisplay1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay2;
        private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEditV21;
        private System.Windows.Forms.RadioButton radio_PX1;
        private System.Windows.Forms.RadioButton radio_PX2;
        private System.Windows.Forms.RadioButton radio_EX1;
        private System.Windows.Forms.RadioButton radio_CC2;
        private System.Windows.Forms.RadioButton radio_CC1;
        private System.Windows.Forms.RadioButton radio_EX2;
        private System.Windows.Forms.RadioButton radio_ImageMode2;
        private System.Windows.Forms.RadioButton radio_ImageMode1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Serial1;
        private System.Windows.Forms.TextBox txt_Serial2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ImgPath1;
        private System.Windows.Forms.TextBox txt_ImgPath2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Btn_Grab;
        private System.Windows.Forms.Button Btn_LiveStart;
        private System.Windows.Forms.Button Btn_LiveStop;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_PxSize2;
        private System.Windows.Forms.TextBox txt_PxSize1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txt_CalExICurPosX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CalExICurPosY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CalExIndex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox txt_AlignY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_AlignX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_AlignT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

