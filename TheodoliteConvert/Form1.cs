using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheodoliteConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gis = new GISLibrary();
            zone = 6;
            coordinateType = CoordinateType.BeiJing54;
            //Init();
        }

      private    int zone = 6;  //投影方式
      private   CoordinateType coordinateType;  //坐标类型

      private double degL = 0;       //经度 度数
      private double degB = 0;       //纬度 度数
      private double minL = 0;       //经度 分数
      private double minB = 0;       //纬度 分数
      private double secL = 0;       //经度 秒数
      private double secB = 0;       //纬度 度数

      private GISLibrary gis;

        /// <summary>
        /// 根据不同的坐标类型得到不同的椭球半轴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
     

     
        /// <summary>
        /// 度分秒转为度
        /// </summary>
        /// <param name="dfm"></param>
        /// <returns></returns>
        public double DFMToDegree(double dfm)
        {
            double degree , second;
            int degreeTemp,minute;
            degreeTemp = (int)dfm;
            minute =(int)((dfm-dfm-degreeTemp)*100f+0.000000000001);   
            second = (int)((dfm - degreeTemp) * 100 - minute) * 100;
             return  degree = degreeTemp + minute / 60 + second / 3600.0;   
        }

        /// <summary>
        /// 根据不同的坐标类型得到不同的椭球半轴
        /// </summary>
        /// <param name="type"></param>
        private void SetTypeValue(CoordinateType type)
        {
            double x=0, y=0;
            coordinateType = type;
            gis.SetCoordinateTypeValue(type, ref  x, ref  y);
            textBoxRadionA.Text  =x.ToString();
            textBoxRadionB.Text  =y.ToString(); 
        }

        /// <summary>
        /// 投影方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Init();
        }

        /// <summary>
        ///初始化
        /// </summary>
        private void Init()
        {
            SetCoordinateValue();
            double l = ConvertCoordinate( degL,  minL,  secL);
            double B = ConvertCoordinate(degB, minB, secB); 
            double x = 0;
            double y = 0;
            gis.RadioA = Convert.ToDouble(textBoxRadionA.Text);
            gis.RadioB = Convert.ToDouble(textBoxRadionB.Text);
            gis.Gauss3(l, B, ref x, ref y, zone);
            tbwe.Text += "东坐标:" + x.ToString() + Environment.NewLine + "西坐标:" + y.ToString() + Environment.NewLine;
         
        }


        /// <summary>
        /// 获邓度分秒的值
        /// </summary>
        private void SetCoordinateValue()
        {
            if (textBoxDegA.Text != null && textBoxDegA.Text.Trim() != "")
            {
                degL = Convert.ToDouble(textBoxDegA.Text);
            }
            if (textBoxMinA.Text != null && textBoxMinA.Text.Trim() != "")
            {
                minL = Convert.ToDouble(textBoxMinA.Text);
            }
            if (textBoxSecA.Text != null && textBoxSecA.Text.Trim() != "")
            {
                secL = Convert.ToDouble(textBoxSecA.Text);
            }
            if (textBoxDegB.Text != null && textBoxDegB.Text.Trim() != "")
            {
                degB = Convert.ToDouble(textBoxDegB.Text);
            }
            if (textBoxMinB.Text != null && textBoxMinB.Text.Trim() != "")
            {
                minB = Convert.ToDouble(textBoxMinB.Text);
            }
            if (textBoxSecB.Text != null && textBoxSecB.Text.Trim() != "")
            {
                secB = Convert.ToDouble(textBoxSecB.Text);
            }

        }

        /// <summary>
        /// 将度、分、秒转换为度
        /// </summary>
        /// <param name="deg"></param>
        /// <param name="min"></param>
        /// <param name="sec"></param>
        /// <returns></returns>
        private double ConvertCoordinate(double deg, double min, double sec)
        {
            return deg + min / 60.0 + sec / 3600.0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmb=comboBox1.Text.ToString();
             int cmb1=Convert.ToInt32(cmb);
            switch (cmb1)
            {
                case 3:
                    zone = 3;
                    lab.Text = "三度投影带";
                    break;
                case 6:
                    zone = 6;
                    lab.Text = "六度投影带";
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmb = comboBox2.Text.ToString();
            int cmb1 = Convert.ToInt32(cmb);
            switch (cmb1)
            {
                case 1954:
                    SetTypeValue(CoordinateType.BeiJing54);
                    lab1.Text = "北京54参考椭球体";
                    break;
                case 1980:
                    SetTypeValue(CoordinateType.XiAn80);
                    lab1.Text = "西安80参考椭球体";
                    break;
                case 1984:
                    SetTypeValue(CoordinateType.WGS84);
                    lab1.Text = "WGS1984参考椭球体";
                    break;
            }
        }

        private void labelRadioA_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //读取计算结果为txt格式
        private void bt_write_Click(object sender, EventArgs e)
        {
            if (tbwe.Text == string.Empty)
            {
                MessageBox.Show("要写入的文件内容不能为空");
            }
            else
            {
                //设置保存文件的格式
                saveFileDialog1.Filter = "文本文件(*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //使用“另存为”对话框中输入的文件名实例化StreamWriter对象
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);
                    //向创建的文件中写入内容
                    sw.WriteLine(tbwe.Text);
                    //关闭当前文件写入流
                    sw.Close();
                    tbwe.Text = string.Empty;
                }
            }

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            //设置打开文件的格式
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbwe.Text = string.Empty;
                //使用“打开”对话框中选择的文件实例化StreamReader对象
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                //调用ReadToEnd方法读取选中文件的全部内容
                tbwe.Text = sr.ReadToEnd();
                //关闭当前文件读取流
                sr.Close();
            }
        }

        private void buttonOk_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.buttonOk, "计算坐标");  
        }

        private void bt_write_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.bt_write, "保存计算结果");  
        }

        private void btn_read_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btn_read, "读取计算结果");  
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btn_close, "关闭计算窗体");  

        }
      
    }
}
