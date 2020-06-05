using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

// VisionPro Class
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.CalibFix;

namespace VPro_Align
{
    class Calibration
    {

        // Cog ToolBlock
        public CogToolBlock ToolBlock_Calib_CalcPixelSize;
        public CogToolBlock ToolBlock_Calib_Extractor;
        public CogToolBlock ToolBlock_Calib_CalcCalibration;

        // Calibration Data 변수
        public double PixelSize = 0.0; // Pixel Size

        public List<double> List_PixelPos_X = new List<double>(); // n회 이동에 대한 Pixel 좌표 저장 
        public List<double> List_PixelPos_Y = new List<double>();

        public List<double> List_ActualPos_X = new List<double>(); // n회 이동에 대한 현재 좌표 저장 
        public List<double> List_ActualPos_Y = new List<double>();


        public Calibration()
        {
            /* <NOTE>
             * Class 객체 생성 시 기본적으로 Calibration 에 사용하게 될 ToolBlock 초기화 
             * Input 터미널 1개를 생성하는 이유는 GUI 에서 ToolBlock 을 수정하게 하기 위함 
            */

            Bitmap TempBMP = new Bitmap(100, 100);
            ICogImage TempIMage = new CogImage8Grey(TempBMP);
            string TName = "InputImage1";

            ToolBlock_Calib_CalcPixelSize = new CogToolBlock(); // 프로그램 내에서 사용 될 CogToolBlock 객체 (new 필수)
            CogToolBlockTerminal InputImage_CalcPixel = new CogToolBlockTerminal(TName, TempIMage.GetType());
            ToolBlock_Calib_CalcPixelSize.Inputs.Add(InputImage_CalcPixel);

            ToolBlock_Calib_Extractor = new CogToolBlock(); // 프로그램 내에서 사용 될 CogToolBlock 객체 (new 필수)
            CogToolBlockTerminal InputImage_Extractor = new CogToolBlockTerminal(TName, TempIMage.GetType());
            ToolBlock_Calib_Extractor.Inputs.Add(InputImage_Extractor);

            ToolBlock_Calib_CalcCalibration = new CogToolBlock(); // 프로그램 내에서 사용 될 CogToolBlock 객체 (new 필수)
            CogToolBlockTerminal InputImage_CalcCalibration = new CogToolBlockTerminal(TName, TempIMage.GetType());
            ToolBlock_Calib_CalcCalibration.Inputs.Add(InputImage_CalcCalibration);



            // n 회에 대한 좌표 보관하기 위한 List 초기화 
            InitCalibData();
        }



        public int Calc_PixelSize(double ActualDist, ICogImage CalibImage) // Image 에서 Pixel Size 를 계산  
        {
            try
            {
                ToolBlock_Calib_CalcPixelSize.Inputs["InputImage1"].Value = CalibImage;
                ToolBlock_Calib_CalcPixelSize.Inputs["ActualDist"].Value = ActualDist;


                ToolBlock_Calib_CalcPixelSize.Run();

                this.PixelSize = (double)ToolBlock_Calib_CalcPixelSize.Outputs["PixelSize"].Value;


                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }


        public void InitCalibData() // n회 이미지에서 Pixel 좌표, 현재 좌표를 저장하기 전 List 내용 초기화 
        {
            List_PixelPos_X.Clear();
            List_PixelPos_Y.Clear();
            List_ActualPos_X.Clear();
            List_ActualPos_Y.Clear();

            for (int i = 0; i < 13; i++)
            {
                // 총 13 회에 대한 좌표 보관하기 위한 List 초기화 
                List_PixelPos_X.Add(0);
                List_PixelPos_Y.Add(0);
                List_ActualPos_X.Add(0);
                List_ActualPos_Y.Add(0);
            }
        }



        public int ExtractPosData(int Index, ICogImage CalibImage) // Image 에서 Pixel 좌표를 추출 
        {
            double ResultX, ResultY;

            try
            {

                ToolBlock_Calib_Extractor.Inputs["InputImage1"].Value = CalibImage;

                ToolBlock_Calib_Extractor.Run();

                ResultX = (double)ToolBlock_Calib_Extractor.Outputs["Pos1_X"].Value;
                ResultY = (double)ToolBlock_Calib_Extractor.Outputs["Pos1_Y"].Value;

                List_PixelPos_X.Insert(Index, ResultX);
                List_PixelPos_Y.Insert(Index, ResultY);


                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
