using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheodoliteConvert
{
    public class GISLibrary
    {
        #region 定义变量

        const double PI = 3.1415926535897932;  //圆周率
        private double radioA = 6378245.0;       //椭圆长半轴
        private double radioB = 6356863.0188;       //椭圆短半轴

        const double E = 2.718281828;       //科学计数点E
        private double eOne = 1;             //椭圆第一偏心率
        private double eTwo = 1;             //椭圆第二偏心率
        double N = 0;                        ////卯酉圈曲率半径
        double R = 0;                        // //子午圈曲率半径
        private const double RAD = 57.295779; //单位弧度
        //double f = (radioA - radioB) / radioA;  // 扁率         

        #endregion

        /// <summary>
        ///  //椭圆长半轴
        /// </summary>
        public double RadioA
        {
            get { return radioA; }
            set { radioA = value; }
        }

        /// <summary>
        /// /椭圆短半轴
        /// </summary>
        public double RadioB
        {
            get { return radioB; }
            set { radioB = value; }
        }
        private void Init(double angle)
        {
            //eOne = 1 - (radioB / radioA) * (radioB / radioA);  //椭圆第一偏心率
            //eTwo = (radioA / radioB) * (radioA / radioB) - 1;  //椭圆第一偏心率
            eOne = Math.Sqrt(1 - (radioB / radioA) * (radioB / radioA));  //椭圆第一偏心率
            eTwo = Math.Sqrt((radioA / radioB) * (radioA / radioB) - 1);  //椭圆第一偏心率
            //卯酉圈曲率半径 
            N = (radioA * radioA / radioB) / Math.Sqrt(1 + eTwo * eTwo * Math.Cos(angle) * Math.Cos(angle));

            //子午圈曲率半径
            R = radioA * (1 - eOne * eOne) / Math.Sqrt(Math.Pow(1 - eOne * eOne * Math.Sin(angle) * Math.Sin(angle), 2));

        }
        public GISLibrary()
        {
            //Init();
        }
     
        /// <summary>
        ///  高斯投影转换
        /// </summary>
        /// <param name="L">经度</param>
        /// <param name="B"> 纬度</param>
        /// <param name="X">纵直角坐标</param>
        /// <param name="Y"> 横直角坐标</param>
        public void GaussCalu(double L, double B, ref double X, ref double Y)
        {

            double dblPI = 3.1415926535898 / 180.0; // 角度弧度转换参数
            int zoneWide = 6;// // 带宽 3度带或6度带
            int ZoneNumber = 0;  // 带号
            double L0;   // 中央经度
         double   f = (radioA - radioB) / radioA;
            if (zoneWide == 3) // 3度带
            {
                ZoneNumber = (int)(L - zoneWide / 2) / zoneWide + 1;
            }
            if (zoneWide == 6)  // 6度带
            {
                ZoneNumber = (int)(L) / zoneWide + 1;
            }
            // 中央经度

            //  L0 = (ZoneNumber - 1) * zoneWide + zoneWide / 2;
            L0 = ZoneNumber * 6;
            //L0 = 120;
            // 角度转换成弧度
            double L1 = L * dblPI;
            double B1 = B * dblPI;
            Init(B1);
            L0 = L0 * dblPI;
            // 子午圈曲率半径
            double R = radioA * (1 - eOne) / Math.Sqrt((1 - eOne * Math.Sin(B1) * Math.Sin(B1)) * (1 - eOne * Math.Sin(B1) * Math.Sin(B1)) * (1 - eOne * Math.Sin(B1) * Math.Sin(B1)));

            double N = radioA / Math.Sqrt(1 - eOne * eOne * Math.Sin(B1) * Math.Sin(B1));

            double T = Math.Tan(B1) * Math.Tan(B1);
            double C = eTwo * Math.Cos(B1) * Math.Cos(B1);
            double A = (L1 - L0) * Math.Cos(B1); //中经线

            // 子午线弧长
            //      double M = radioA * ((1 - eOne * eOne / 4 - 3 * Math.Pow(eOne, 4) / 64 - 5 * Math.Pow(eOne, 6) / 256) * B1
            //- (3 * eOne * eOne / 8 + 3 * Math.Pow(eOne, 4) / 32 + 45 * Math.Pow(eOne, 6) / 1024) * Math.Sin(2 * B1)
            //+ (15 * Math.Pow(eOne, 4) / 256 + 45 * Math.Pow(eOne, 6) / 1024) * Math.Sin(4 * B1)
            //- (35 * Math.Pow(eOne, 6) / 3072) * Math.Sin(6 * B1));
            double M = radioA * ((1 - eOne * eOne / 4 - 3 * eOne * eOne / 64 - 5 * eOne * eOne * eOne / 256) * B1
             - (3 * eOne / 8 + 3 * eOne * eOne / 32 + 45 * eOne * eOne * eOne / 1024) * Math.Sin(2 * B1)
             + (15 * eOne * eOne / 256 + 45 * eOne * eOne * eOne / 1024) * Math.Sin(4 * B1)
             - (35 * eOne * eOne * eOne / 3072) * Math.Sin(6 * B1));

            // 东纬度偏移
            double FE = ZoneNumber * 1000000L + 500000L;
            // 高斯 - 克吕格投影比例因子
            double k0 = 1;
            X = FE + k0 * N * (A + (1 - T + C) * Math.Pow(A, 3) / 6 + (5 - 18 * T + T * T + 14 * C - 58 * T * C) * Math.Pow(A, 5) / 120);

            Y = k0 * (M + N * Math.Tan(B1) * (A * A / 2 + (5 - T + 9 * C + 4 * C * C) * Math.Pow(A, 4) / 24)
  + (61 - 58 * T + T * T + 270 * C - 330 * T * C) * Math.Pow(A, 6) / 720);


        }
        /// <summary>
        ///  高斯投影转换
        /// </summary>
        /// <param name="L">经度</param>
        /// <param name="B"> 纬度</param>
        /// <param name="X">纵直角坐标</param>
        /// <param name="Y"> 横直角坐标</param>
        public void Gauss2(double L, double B, ref double x, ref  double y)
        {
            // 椭球体
            double a = 6378245;      // 北京54
            double b = 6356863.0188;    // 北京54
            //double a = 6378140;     // 西安80
            //double b = 6356755.2882;    // 西安80
            //double a = 6378137;     // WGS 84
            //double b = 6356752.3142;    // WGS 84
            double f = (a - b) / a;     // 扁率
            double e = 1 - (b / a) * (b / a);  // 第一偏心率平方
            double e2 = (a / b) * (a / b) - 1;  // 第二偏心率平方

            // 求经度所在带号
            int ZoneWide = 3; // 带宽 3度带或6度带
            int ZoneNumber;  // 带号
            double L0;   // 中央经度
            if (3 == ZoneWide)
            {// 3度带
                ZoneNumber = (int)(L - ZoneWide / 2) / ZoneWide + 1;
                L0 = ZoneNumber * ZoneWide;
            }
            else// if (6 == ZoneWide)
            {// 6度带
                ZoneNumber = (int)(L) / ZoneWide + 1;
                L0 = ZoneNumber * ZoneWide - 3;
            }

            //L、B转化成度
            L = (int)L + ((int)(L * 100) - (int)(L) * 100) / (double)(60) + (L * 10000 - (int)(L * 100) * 100) / 3600;
            B = (int)(B) + ((int)(B * 100) - (int)(B) * 100) / (double)(60) + (B * 10000 - (int)(B * 100) * 100) / 3600;

            double A = (L - L0) / RAD;
            double TB = Math.Tan(B / RAD);
            double TB2 = TB * TB;
            double CB = Math.Cos(B / RAD);
            double C = e2 * CB * CB;
            double C2 = 1 + C;
            double N = (a * a / b) / Math.Sqrt(C2);//卯酉曲率半径
            double P = A * A * CB * CB;
            double P2 = Math.Sin(B / RAD);
            double Q = P2 * P2;
            double R = 32005.78006 + Q * (133.92133 + Q * 0.7031);
            x = 6367558.49686 * B / RAD - P2 * CB * R + ((((TB2 - 58) * TB2 + 61) * P / 30 + (4 * N + 5) * C2 - TB2) * P / 12 + 1) * N * CB * P / 2;
            y = 500000 + ((((TB2 - 18) * TB2 - (58 * TB2 - 14) * N + 5) * P / 20 + C2 - TB2) * P / 6 + 1) * N * (A * CB);//为保证为正数，向西便偏移500公里，即＋500,000；

        }
        /// <summary>
        ///  高斯投影转换
        /// </summary>
        /// <param name="L">/角度表示的经度</param>
        /// <param name="B"> /角度表示的纬度</param>
        /// <param name="X">纵直角坐标</param>
        /// <param name="Y"> 横直角坐标</param>
        ///    /// <param name="zoneWide">  投影方式</param>
        public void Gauss3(double L, double B2, ref double X, ref  double Y, int zoneWide)
        {
            //SetCoordinateTypeValue(Type);
            int centerLine;              //中央经线
            int zone = 0;                 //带号
            //高斯坐标
            double N;                      //卯酉圈半径
            double eTwo2;                  //eta的平方，计算时需用到的参数
            double radioLength;            //沿经线方向的弧长
            double BB;                     //弧度表示的纬度
            double dL;                     //所给经度与中央经线的经差
            double dL2, dL3, dL4, dL5,dL6; //经差的三、四、五次方
            double sinB, cosB, tanB, cos3B, cos5B, tanB4;  //纬度的三角函数值

            BB = B2 * PI / 180;       //弧度表示的纬度
            if (zoneWide == 3) // 3度带
            {
                if (L %3 != 0)             //求带号
                    zone = (int)(L / 3) + 1;
                else
                    zone = (int)(L / 3);

                //zone = (int)(L - zoneWide / 2) / zoneWide + 1;
            }
            if (zoneWide == 6)  // 6度带
            {
                if (L % 6 != 0)             //求带号
                    zone = (int)(L / 6) + 1;
                else
                    zone = (int)(L / 6);

            }
            // 中央经度

            centerLine = (int)(zone * zoneWide - zoneWide / 2f);//求中央经线
   
            dL =( L - centerLine);          //求经差
            dL = dL * PI / 180;             //经差转换为弧度

            dL2 = dL * dL;                   //经差的2 次方
            dL3 = dL * dL * dL;               //经差的3 次方
            dL4 = dL * dL * dL * dL;           //经差的4次方
            dL5 = dL * dL * dL * dL * dL;       //经差的5 次方
            dL6 = dL * dL * dL * dL * dL * dL;    //经差的6 次方

            sinB = Math.Sin(BB);
            cosB = Math.Cos(BB);
            tanB = Math.Tan(BB);
            cos3B = cosB * cosB * cosB;                //三次方
            cos5B = cosB * cosB * cosB * cosB * cosB;  //五次方
            tanB4 = tanB * tanB * tanB * tanB;         //4次方

            Init(BB);
            N = radioA / Math.Sqrt((1 - eOne * eOne * sinB * sinB));  //计算卯酉圈半径
            eTwo2 = eTwo * eTwo * cosB * cosB;                         //eta的平方，计算时需用到的参数
            radioLength = RadianLength(BB);                         //沿经线方向的弧长

            X = radioLength + (dL2 * N / 2) * sinB * cosB + (dL4 * N / 24) * sinB * cos3B * (5 - tanB * tanB + 9 * eTwo2 + 4 * eTwo2 * eTwo2)
                + (61.0 - 58.0 * tanB + tanB * tanB + 270 * eTwo2 - 330 * tanB * eTwo2) * dL6 / 720;

            Y = dL * N * cosB + dL3 * N * cos3B * (1 - tanB * tanB + eTwo2 * eTwo2) / 6 + dL5 / 120.0 * N * cos5B * (5 - 18 * tanB * tanB + tanB4);

            Y = Y + 500000 + zone * 1000000;
            double temp_Y = zone * 1000000;

        }

        /// <summary>
        /// 计算从赤道 到纬度B的经线弧长
        /// </summary>
        /// <param name="B">纬度B</param>
        /// <returns></returns>
        private double RadianLength(double B)
        {
            double A = 1 + (eOne * eOne) * 3 / 4 + Math.Pow(eOne, 4) * 45 / 64 + Math.Pow(eOne, 6) * 175 / 256 + Math.Pow(eOne, 8) * 11025 / 16384;
            double BB = Math.Pow(eOne, 2) * 3 / 4 + Math.Pow(eOne, 4) * 15 / 16 + Math.Pow(eOne, 6) * 525 / 512 + Math.Pow(eOne, 8) * 2205 / 2048;
            double C = Math.Pow(eOne, 4) * 15 / 64 + Math.Pow(eOne, 6) * 105 / 256 + Math.Pow(eOne, 8) * 2205 / 4096;
            double D = Math.Pow(eOne, 6) * 35 / 512 + Math.Pow(eOne, 8) * 315 / 2048;
            double E = Math.Pow(eOne, 8) * 315 / 16384;
            return radioA * (1 - eOne * eOne) * (A * B - BB / 2 * Math.Sin(2 * B)) + C / 4 * Math.Sin(4 * B) - D / 6 * Math.Sin(6 * B) + E / 8 * Math.Sin(8 * B);
        }

        /// <summary>
        /// 根据坐标类型设定，椭球长轴与椭球短轴的值
        /// </summary>
        /// <param name="Type"></param>
        public  void SetCoordinateTypeValue(CoordinateType Type)
        {
            switch (Type)
            {
                case CoordinateType.BeiJing54 :
                    radioA = 6378245;    // 北京54
                    radioB = 6356863.0188;
                    break;
                case CoordinateType.XiAn80 :
                    radioA = 6378140;       // 西安80
                    radioB = 6356755.2882;
                    break;
                case CoordinateType.WGS84 :
                    radioA = 6378137;     // WGS 84

                    radioB = 6356752.3142;
                    break;
                case CoordinateType.None :
                    radioA = 6378245;
                    radioB = 6356863.0188;
                    break;
                default :
                    break;
            }

        }

        /// <summary>
        /// 根据坐标类型设定，椭球长轴与椭球短轴的值
        /// </summary>
        /// <param name="Type"></param>
        public void SetCoordinateTypeValue(CoordinateType Type,ref double X,ref double Y)
        {
            switch (Type)
            {
                case CoordinateType.BeiJing54:
                    X = 6378245;    // 北京54
                    Y = 6356863.0188;
                    break;
                case CoordinateType.XiAn80:
                    X = 6378140;       // 西安80
                    Y = 6356755.2882;
                    break;
                case CoordinateType.WGS84:
                    X = 6378137;     // WGS 84

                    Y = 6356752.3142;
                    break;
                case CoordinateType.None:
                    //X = X;
                    //Y = Y;
                    break;
                default:
                    break;
            }

        }

    }
   


    
    public enum CoordinateType
    {
        /// <summary>
        /// 北京54
        /// </summary>
        BeiJing54,
        /// <summary>
        ///  西安80
        /// </summary>
        XiAn80,
        /// <summary>
        ///  WGS84,
        /// </summary>
        WGS84,
        /// <summary>
        /// 米制
        /// </summary>
        None
    }
}
