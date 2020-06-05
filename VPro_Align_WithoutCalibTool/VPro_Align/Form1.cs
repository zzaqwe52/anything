using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using System.IO;

// VisionPro Class
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;

namespace VPro_Align
{
    public partial class Form1 : Form
    {
        // 사용자 기본 정의 =================================================================================== 
        int CamCount = 2;


        // List
        List<ICogAcqFifo> CameraList = new List<ICogAcqFifo>();


        // Class 객체 생성
        Calibration Calib_Cam1 = new Calibration();
        Calibration Calib_Cam2 = new Calibration();
        CommonManager CM = new CommonManager(); // 파라미터 관리 


        // Thread
        int LiveThreadSwitch = 0; // Live Thread 중지 Flag
        Thread LiveThread; // Live Thread 


        // VisionPro 객체 선언 
        public CogFrameGrabbers cogFrameGrabbers = new CogFrameGrabbers();  // NOTE : GigE Configurator 에 연결되어 있는 카메라 장치 정보가 자동으로 포함 됨 
        ICogImage LoadedImage1;
        ICogImage LoadedImage2;
        ICogImage Image_Cam1;
        ICogImage Image_Cam2;


        // 일반 변수
        int ToolBlockMode; // ToolBlock Edit 창 출력 인덱스 (라디오 버튼으로 제어)

        public Form1()
        {
            InitializeComponent();

            // 초기화 ===================================================================================

            /// Camera Fifo 초기화  
            for (int i = 0; i < CamCount; i++)
            {
                ICogAcqFifo TempFifo = null;
                CameraList.Add(TempFifo);
            }

            // 저장된 값 가져오기
            CM.Load_Json();


            Init_vpp(); // VisionPro ToolBlock 데이터 로드 




            //NJH 20.05.23
            // Class 객체 로드
            //CM.Load_Object<Calibration>("D:\\NewAlign2\\ClassSaveTest.json");

            // UI 디스플레이에 출력 
            cogToolBlockEditV21.Subject = Calib_Cam1.ToolBlock_Calib_CalcPixelSize;

            // TOolBlock 라디오 버튼 초기화 
            radio_PX1.Checked = true;
            ToolBlockMode = 1;


            // 저장된 Pixel Size 값 화면에 출력 
            txt_PxSize1.Text = CM.Cam1_PixelSize.ToString("F3");
            Calib_Cam1.PixelSize = CM.Cam1_PixelSize;
            txt_PxSize2.Text = CM.Cam2_PixelSize.ToString("F3");
            Calib_Cam2.PixelSize = CM.Cam2_PixelSize;
        }


        public void Load_Image_Cam1() // 이미지 시뮬레이션 모드일 때 이미지 로드 
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Grab Image";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap LoadedImage = new Bitmap(ofd.FileName);
                this.LoadedImage1 = new CogImage8Grey(LoadedImage); // 이미지 시뮬 모드에서는 불러온 이미지를 LoadedImage 변수에 저장하여 보유

                txt_ImgPath1.Text = ofd.FileName;
            }
        }


        public void Load_Image_Cam2() // 이미지 시뮬레이션 모드일 때 이미지 로드 
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Grab Image";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap LoadedImage = new Bitmap(ofd.FileName);
                this.LoadedImage2 = new CogImage8Grey(LoadedImage); // 이미지 시뮬 모드에서는 불러온 이미지를 LoadedImage 변수에 저장하여 보유

                txt_ImgPath2.Text = ofd.FileName;
            }
        }

        public void GrabImage()
        {
            /*
            if (ImageMode == 0) // 카메라 사용 시 
            {
                Image_Cam1 = m_VPro_Cam.Grab_Image(CameraList[0]);
                Image_Cam2 = m_VPro_Cam.Grab_Image(CameraList[1]);
            }
            else // 이미지 파일 사용 시 */
            {
                Image_Cam1 = LoadedImage1;
                Image_Cam2 = LoadedImage2;
            }
            cogRecordDisplay1.Image = Image_Cam1;
            cogRecordDisplay1.Fit();
            cogRecordDisplay2.Image = Image_Cam2;
            cogRecordDisplay2.Fit();
        }

        public void Init_vpp()
        {
            // Calib CogToolBlock 로드 
            CogToolBlock LoadToolBlock = new CogToolBlock();
            LoadToolBlock = CM.Load_Vpp("D:\\NewAlign2\\ToolBlock_CalibPixel_Cam1.vpp") as CogToolBlock;
            if (LoadToolBlock != null)
            {
                Calib_Cam1.ToolBlock_Calib_CalcPixelSize = LoadToolBlock;
            }

            LoadToolBlock = new CogToolBlock();
            LoadToolBlock = CM.Load_Vpp("D:\\NewAlign2\\ToolBlock_CalibExtractor_Cam1.vpp") as CogToolBlock;
            if (LoadToolBlock != null)
            {
                Calib_Cam1.ToolBlock_Calib_Extractor = LoadToolBlock;
            }

            LoadToolBlock = new CogToolBlock();
            LoadToolBlock = CM.Load_Vpp("D:\\NewAlign2\\ToolBlock_CalibCalibration_Cam1.vpp") as CogToolBlock;
            if (LoadToolBlock != null)
            {
                Calib_Cam1.ToolBlock_Calib_CalcCalibration = LoadToolBlock;
            }



            LoadToolBlock = new CogToolBlock();
            LoadToolBlock = CM.Load_Vpp("D:\\NewAlign2\\ToolBlock_CalibPixel_Cam2.vpp") as CogToolBlock;
            if (LoadToolBlock != null)
            {
                Calib_Cam2.ToolBlock_Calib_CalcPixelSize = LoadToolBlock;
            }

            LoadToolBlock = new CogToolBlock();
            LoadToolBlock = CM.Load_Vpp("D:\\NewAlign2\\ToolBlock_CalibExtractor_Cam2.vpp") as CogToolBlock;
            if (LoadToolBlock != null)
            {
                Calib_Cam2.ToolBlock_Calib_Extractor = LoadToolBlock;
            }

            LoadToolBlock = new CogToolBlock();
            LoadToolBlock = CM.Load_Vpp("D:\\NewAlign2\\ToolBlock_CalibCalibration_Cam2.vpp") as CogToolBlock;
            if (LoadToolBlock != null)
            {
                Calib_Cam2.ToolBlock_Calib_CalcCalibration = LoadToolBlock;
            }


        }



        // UI Control ===================================================================================================================

        private void button3_Click(object sender, EventArgs e) // Btn Load Image 1 버튼 
        {
            Load_Image_Cam1();
        }

        private void button4_Click(object sender, EventArgs e) // Btn Load Image 2 버튼 
        {
            Load_Image_Cam2();
        }

        private void Btn_Grab_Click(object sender, EventArgs e) // Btn Camera Image Grab 버튼 
        {
            GrabImage();
        }

        private void Btn_LiveStart_Click(object sender, EventArgs e) // Btn Live Start 버튼 
        {

            LiveThreadSwitch = 0;

            LiveThread = new Thread(new ThreadStart(delegate
            {
                for (; ; )
                {
                    /*
                    if (ImageMode == 0) // 카메라 사용 시 
                    {
                        Image_Cam1 = m_VPro_Cam.Grab_Image(CameraList[0]);
                        Image_Cam2 = m_VPro_Cam.Grab_Image(CameraList[1]);
                    }
                    else // 이미지 파일 사용 시 */
                    {
                        Image_Cam1 = LoadedImage1;
                        Image_Cam2 = LoadedImage2;
                    }
                    cogRecordDisplay1.Image = Image_Cam1;
                    cogRecordDisplay2.Image = Image_Cam2;

                    if (LiveThreadSwitch == 1)
                        break;

                    System.Threading.Thread.Sleep(1);
                }
            }));

            LiveThread.Start();
        }

        private void Btn_LiveStop_Click(object sender, EventArgs e) // Btn Live Stop 버튼 
        {
            LiveThreadSwitch = 1;
            LiveThread.Join();
            LiveThread.Abort();

        }

        private void button15_Click(object sender, EventArgs e) // Btn ToolBlock Save 버튼 
        {
            
            if (ToolBlockMode == 1) // Pixel Size ToolBlock Cam1
            {
                Calib_Cam1.ToolBlock_Calib_CalcPixelSize = cogToolBlockEditV21.Subject;
                CM.Save_Vpp(Calib_Cam1.ToolBlock_Calib_CalcPixelSize, "D:\\NewAlign2\\ToolBlock_CalibPixel_Cam1.vpp");
            }
            else if (ToolBlockMode == 2) // Pixel Size ToolBlock Cam2
            {
                Calib_Cam2.ToolBlock_Calib_CalcPixelSize = cogToolBlockEditV21.Subject;
                CM.Save_Vpp(Calib_Cam2.ToolBlock_Calib_CalcPixelSize, "D:\\NewAlign2\\ToolBlock_CalibPixel_Cam2.vpp");
            }


            else if (ToolBlockMode == 3) // Extract ToolBlock Cam1
            {
                Calib_Cam1.ToolBlock_Calib_Extractor = cogToolBlockEditV21.Subject;
                CM.Save_Vpp(Calib_Cam1.ToolBlock_Calib_Extractor, "D:\\NewAlign2\\ToolBlock_CalibExtractor_Cam1.vpp");
            }
            else if (ToolBlockMode == 4) // Extract ToolBlock Cam2
            {
                Calib_Cam2.ToolBlock_Calib_Extractor = cogToolBlockEditV21.Subject;
                CM.Save_Vpp(Calib_Cam2.ToolBlock_Calib_Extractor, "D:\\NewAlign2\\ToolBlock_CalibExtractor_Cam2.vpp");
            }


            else if (ToolBlockMode == 5) // Calc Calib ToolBlock Cam1
            {
                Calib_Cam1.ToolBlock_Calib_CalcCalibration = cogToolBlockEditV21.Subject;
                CM.Save_Vpp(Calib_Cam1.ToolBlock_Calib_CalcCalibration, "D:\\NewAlign2\\ToolBlock_CalibCalibration_Cam1.vpp");
            }
            else if (ToolBlockMode == 6) // Calc Calib ToolBlock Cam2
            {
                Calib_Cam2.ToolBlock_Calib_CalcCalibration = cogToolBlockEditV21.Subject;
                CM.Save_Vpp(Calib_Cam2.ToolBlock_Calib_CalcCalibration, "D:\\NewAlign2\\ToolBlock_CalibCalibration_Cam2.vpp");
            }

            //NJH 20.05.23
            //문제 발생 
            //CM.Save_Object(Calib_Cam1, "D:\\NewAlign2\\ClassSaveTest.json");
        }

        private void radio_PX1_CheckedChanged(object sender, EventArgs e) // Radio Pixel ToolBlock Cam1 클릭
        {
            if (radio_PX1.Checked == true)
            {
                ToolBlockMode = 1;
                cogToolBlockEditV21.Subject = Calib_Cam1.ToolBlock_Calib_CalcPixelSize;
            }
        }

        private void radio_PX2_CheckedChanged(object sender, EventArgs e) // Radio Pixel ToolBlock Cam2 클릭
        {
            if (radio_PX2.Checked == true)
            {
                ToolBlockMode = 2;
                cogToolBlockEditV21.Subject = Calib_Cam2.ToolBlock_Calib_CalcPixelSize;
            }
        }

        private void radio_EX1_CheckedChanged(object sender, EventArgs e) // Radio Extract ToolBlock Cam1 클릭
        {
            if (radio_EX1.Checked == true)
            {
                ToolBlockMode = 3;
                cogToolBlockEditV21.Subject = Calib_Cam1.ToolBlock_Calib_Extractor;
            }
        }

        private void radio_EX2_CheckedChanged(object sender, EventArgs e) // Radio Extract ToolBlock Cam2 클릭
        {
            if (radio_EX2.Checked == true)
            {
                ToolBlockMode = 4;
                cogToolBlockEditV21.Subject = Calib_Cam2.ToolBlock_Calib_Extractor;
            }
        }

        private void radio_CC1_CheckedChanged(object sender, EventArgs e) // Radio Calc Calib ToolBlock Cam1 클릭
        {
            if (radio_CC1.Checked == true)
            {
                ToolBlockMode = 5;
                cogToolBlockEditV21.Subject = Calib_Cam1.ToolBlock_Calib_CalcPixelSize;
            }
        }

        private void radio_CC2_CheckedChanged(object sender, EventArgs e) // Radio Calc Calib ToolBlock Cam2 클릭
        {
            if (radio_CC2.Checked == true)
            {
                ToolBlockMode = 6;
                cogToolBlockEditV21.Subject = Calib_Cam2.ToolBlock_Calib_CalcPixelSize;
            }
        }

        private void button5_Click(object sender, EventArgs e) // Btn Pixel Size Cam1 계산 버튼 
        {
            Calib_Cam1.Calc_PixelSize(1.0, LoadedImage1);

            txt_PxSize1.Text = Calib_Cam1.PixelSize.ToString("F3"); // PixelSize 값 UI 에 출력 
        }

        private void button6_Click(object sender, EventArgs e) // Btn Pixel Size Cam2 계산 버튼 
        {
            Calib_Cam2.Calc_PixelSize(1.0, LoadedImage2);

            txt_PxSize2.Text = Calib_Cam2.PixelSize.ToString("F3"); // PixelSize 값 UI 에 출력 
        }

        private void button16_Click(object sender, EventArgs e) // Btn Calibration Data Save 버튼 
        {
            CM.Cam1_PixelSize = Calib_Cam1.PixelSize;
            CM.Cam2_PixelSize = Calib_Cam2.PixelSize;

            CM.Save_Json();
        }

        private void button14_Click(object sender, EventArgs e) // Btn 종료 버튼 
        {
            //FrameGrabber Disconnect 구현 (카메라 사용 모드일 때에만) 
            /*
            if (FG_Count != 0)
            {
                foreach (ICogFrameGrabber fg in cogFrameGrabbers)
                    fg.Disconnect(false);

            }*/

            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
