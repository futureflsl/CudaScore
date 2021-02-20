using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIRC
{
    public class CudaManager
    {
        private string[] CudaDeviceScore = null;
        public string[] CudaDeviceNameList = null;
        public Dictionary<string, string> dicCudaName2Score = new Dictionary<string, string>();
        public void LoadCudaData()
        {
            var lines = File.ReadAllLines(Application.StartupPath+"\\cuda.txt");
            CudaDeviceNameList = new string[lines.Length];
            CudaDeviceScore = new string[lines.Length];
            for(int i=0;i<lines.Length;i++)
            {
                var line = lines[i];
                var index=line.IndexOf("=");
                CudaDeviceNameList[i]=line.Substring(0,index);
                CudaDeviceScore[i] = line.Substring(index+1);
                dicCudaName2Score[CudaDeviceNameList[i]] = CudaDeviceScore[i];

            }
           
        }
    }
}
