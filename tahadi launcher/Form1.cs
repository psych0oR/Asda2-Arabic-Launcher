/*
#################################################################
##                                                             ##
##                                                             ##
##  خاص بمشروع تطوير أسدا2 - يسمح بإعادة التعديل والنـشر   ##
##                                                             ##
##   لانشر تحدي - يسمح للاعب بتشغيل برنامج تسجيل الحسابات    ##
##                                                             ##
#################################################################
*/
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace tahadi_launcher
{
    public partial class Form1 : Form
    {
        public static string ServerIp = "192.168.1.11"; //اتركه كما هو فقط حتى لا تحدث مشكلة أثناء تشغيل البرنامج

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"system\Asda2.exe", "CDLDKJFRE342LDLSL39"); //تشغيل الإصدار العربي
                if (Process.GetProcesses().All((Process p) => !p.ProcessName.ToLower().Contains("vcharmgr.exe")))
                {
                Process.Start("vchrmgr.exe", Form1.ServerIp); //تشغيل برنامج تسجيل الحسابات
                }
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception) {
                //إن لم يتم العثور على إحدى البرنامجين بالأعلى سوف يظهر هذا الخطأ
                MessageBox.Show("عذرا,لم يتم إيجاد البرنامج");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //الخروج من البرنامج
        }
    }
}
