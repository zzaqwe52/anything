using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognex.VisionPro;

namespace VPro_Align
{    public class VPro_Cam
    {    
        public VPro_Cam()
        {

        }


        public ICogAcqFifo ConnectCam(ICogFrameGrabber CurrentCamFG)
        {
            ICogAcqFifo CurrentCamFifo = null;

            string videoFormat = "Generic GigEVision (Mono)";
            CurrentCamFifo = CurrentCamFG.CreateAcqFifo(videoFormat, CogAcqFifoPixelFormatConstants.Format8Grey, 0, true); // CogAcqFifo 초기화
            
            return CurrentCamFifo;
        }

        public ICogImage Grab_Image(ICogAcqFifo CamFifo)
        {
            ICogImage GrabImage;
            try
            {
                CamFifo.AcquiredPixelFormat();

                int TrigOut;
                GrabImage = CamFifo.Acquire(out TrigOut) as CogImage8Grey;

                return GrabImage;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
