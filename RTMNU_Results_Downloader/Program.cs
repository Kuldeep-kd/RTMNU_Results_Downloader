using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace RTMNU_Results_Downloader
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ConnectionManager.SetCapabilities();
            Initialise();
            Logger.Log("Initialised... ", 0);
            
            ListSelector("ddlselectfaculty");
            WaitForReady();
            ListSelector("ddlselectexam");
            //RangeSelect(ref StartRange, ref EndRange);
            Driver.FindElement(By.Id("txtrollno")).SendKeys("345494");
            Driver.FindElement(By.Id("imgbtnviewmarksheet")).Click();
            SaveImage();
        }


        
    }
}
