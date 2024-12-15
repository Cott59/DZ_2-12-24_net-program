using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_2_12_24_net_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SystemJob systemJob = new SystemJob();
        dataConnect dataconnect = new dataConnect();
        private void btn_connect_Click(object sender, EventArgs e)
        {            
            dataconnect.SetIP(tbox_ipadress.Text);
            dataconnect.SetPort(tbox_port.Text);
            dataconnect.connectPoint();
            tbox_outputdata.Text = dataconnect._answer;
            systemJob.SaveStringToFile(dataconnect._answer);
        }

        private void btn_outlog_Click(object sender, EventArgs e)
        {
            systemJob.OpenLogFile();
        }
    }
}
