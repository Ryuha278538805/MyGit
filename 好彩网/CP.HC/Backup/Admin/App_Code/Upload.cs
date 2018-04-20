using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.SessionState;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Collections;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Business;

namespace Admin
{
    public class Upload : IHttpHandler, IRequiresSessionState       
    {
        protected int gid;
        public static string picdomain = ConfigurationManager.AppSettings["picdomain"].ToString();

        public Upload()
	    {
        }

        #region IHttpHandler Members 

        public bool IsReusable
        {
            get { return true; }
        }

        private byte[] getBytes(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open);
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, (int)stream.Length);
            stream.Close();
            return buffer;
        }

        private string CreateRandomCode(int codeCount)
        {
            string[] strArray = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(new char[] { ',' });
            string str2 = "";
            int num = -1;
            Random random = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (num != -1)
                {
                    random = new Random((i * num) * ((int)DateTime.Now.Ticks));
                }
                int index = random.Next(0x24);
                if (num == index)
                {
                    return CreateRandomCode(codeCount);
                }
                num = index;
                str2 = str2 + strArray[index];
            }
            return str2;
        }

        public static string GetUpLoadFooter()
        {
            DateTime dt = DateTime.Now;
            return dt.Year.ToString("0000") + "_" + dt.Month.ToString("00") + "/" + dt.Day.ToString("00");
        }

        public void ProcessRequest(HttpContext context)
        {
            GetValue();
            com.haocw.images.UpLoad load = new com.haocw.images.UpLoad();
            StringBuilder builder = new StringBuilder();
            string filePath = "upload";
            string datepath = GetUpLoadFooter();   //生成日期目录
            for (int j = 0; j < context.Request.Files.Count; j++)
            {
                HttpPostedFile uploadFile = context.Request.Files[j];
                HttpPostedFile smalluploadFile = uploadFile;
                string fileExt = Path.GetExtension(uploadFile.FileName).ToString().ToLower();
                string fileName = GetFileName() + fileExt;
                string smallfileName = "s"+GetFileName() + fileExt;

                //大图
                if (UpLoadThumbnail(uploadFile, "/" + datepath + "/", fileName, smallfileName, UpPicConfig.NEWSIMG_BIG_WIDTH, UpPicConfig.NEWSIMG_BIG_HEIGHT, UpPicConfig.NEWSIMG_TH_WIDTH, UpPicConfig.NEWSIMG_TH_HEIGHT, "AUTO"))
                {
                    DataProvider.AdminPageData.UpdateGoodsPhoto(gid, picdomain + filePath + "/" + datepath + "/" + fileName);                   
                }

                //byte[] postArray = new byte[uploadFile.ContentLength];
                //Stream inputStream = uploadFile.InputStream;
                //inputStream.Read(postArray, 0, uploadFile.ContentLength);
                //inputStream.Close();
                //com.haocw.images.UpLoad up = new com.haocw.images.UpLoad();
                //string str5 = up.UploadFile(postArray, "/" + datepath, fileName);
                // if (gid > 0 && str5 == "ok")
                HttpContext.Current.Response.Write(" ");
            } 

            ////得到保存文件的路径
            //string uploadPath = context.Server.MapPath(context.Request.ApplicationPath + "/Upload");
            ////如果目录不存在则创建该目录
            //if (!System.IO.Directory.Exists(uploadPath))
            //    System.IO.Directory.CreateDirectory(uploadPath);
            ////循环要上传的文件列表
            //for (int j = 0; j < context.Request.Files.Count; j++)
            //{
            //    //得到当前文件
            //    HttpPostedFile uploadFile = context.Request.Files[j];
            //    // 如果有文件要上传
            //    if (uploadFile.ContentLength > 0)
            //    {
            //        // 保存文件到指定目录
            //        uploadFile.SaveAs(Path.Combine(uploadPath, uploadFile.FileName));
            //    }
            //}
            //HttpContext.Current.Response.Write(" ");
        }

        #endregion

        public static string GetFileName()
        {
            Random rd = new Random();
            StringBuilder serial = new StringBuilder();
            serial.Append(DateTime.Now.ToString("yyyyMMddHHmmssff"));
            serial.Append(rd.Next(0, 999999).ToString());
            return serial.ToString();
        }

        private void GetValue()
        {
            try
            {
                gid = int.Parse(HttpContext.Current.Request.QueryString["gid"]);
            }
            catch
            {
                gid = 0;
            }

        }

        #region 上传固定大小的图片
        /// <summary>
        /// 上传固定大小的图片
        /// </summary>
        /// <param name="upfile">文件</param>
        /// <param name="filePath">目录名</param>
        ///  <param name="newFileName">文件名</param>
        /// <param name="width">图片宽</param>
        /// <param name="height">图片高</param>
        /// <param name="mode">缩略方式</param>
        public bool UpLoadThumbnail(HttpPostedFile upfile, string filePath, string newFileName, int width, int height, string mode)
        {
            string fileUrl = string.Empty;
            com.haocw.images.UpLoad upload = new com.haocw.images.UpLoad();
                      
            try
            {
                System.IO.Stream fs;
                byte[] b = new byte[upfile.ContentLength];

                string datePath = System.DateTime.Now.ToShortDateString();
                fs = (System.IO.Stream)upfile.InputStream;
                fs.Read(b, 0, upfile.ContentLength);
                fs.Close();
                byte[] a = MakeThumbnail(b, width, height, mode);
                string s = string.Empty;
                if (a.Length > 0)
                {
                    s = upload.UploadFile(a, filePath, newFileName);
                }
                if (s == "ok")
                    return true;
                else
                    return false;
            }
            catch// (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region 上传固定大小的图片 + 缩略图
        /// <summary>
        /// 上传固定大小的图片 +  缩略图
        /// </summary>
        ///<param name="b">二进制数组</param>
        /// <param name="filePath">目录名</param>
        /// <param name="newFileName">文件名</param>
        /// <param name="sFileName">缩略文件名</param>
        /// <param name="width">图片宽</param>
        /// <param name="height">图片高</param>
        /// <param name="swidth">缩略图片宽</param>
        /// <param name="sheight">缩略图片高</param>
        /// <param name="mode">缩略方式</param>
        public bool UpLoadTwoPhotos(byte[] b, string filePath, string newFileName, string sFileName, int width, int height, int swidth, int sheight, string mode)
        {
            string fileUrl = string.Empty;
            com.haocw.images.UpLoad upload = new com.haocw.images.UpLoad();

            try
            {
                byte[] a = MakeThumbnail(b, width, height, mode);
                byte[] small = MakeThumbnail(b, swidth, sheight, mode);
                string s1 = string.Empty;
                string s2 = string.Empty;
                if (a.Length > 0)
                {
                    s1 = upload.UploadFile(a, filePath, newFileName);
                    s2 = upload.UploadFile(small, filePath, sFileName);
                }
                if (s1 == "ok" && s2 == "ok")
                    return true;
                else
                    return false;
            }
            catch// (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region 上传固定大小的图片 + 缩略图
        /// <summary>
        /// 上传固定大小的图片 +  缩略图
        /// </summary>
        /// <param name="upfile">文件</param>
        /// <param name="filePath">目录名</param>
        /// <param name="newFileName">文件名</param>
        /// <param name="sFileName">缩略文件名</param>
        /// <param name="width">图片宽</param>
        /// <param name="height">图片高</param>
        /// <param name="swidth">缩略图片宽</param>
        /// <param name="sheight">缩略图片高</param>
        /// <param name="mode">缩略方式</param>
        public bool UpLoadThumbnail(HttpPostedFile upfile, string filePath, string newFileName, string sFileName, int width, int height, int swidth, int sheight, string mode)
        {
            string fileUrl = string.Empty;
            com.haocw.images.UpLoad upload = new com.haocw.images.UpLoad();

            try
            {
                System.IO.Stream fs;
                byte[] b = new byte[upfile.ContentLength];

                string datePath = System.DateTime.Now.ToShortDateString();
                fs = (System.IO.Stream)upfile.InputStream;
                fs.Read(b, 0, upfile.ContentLength);
                fs.Close();
                byte[] a = MakeThumbnail(b, width, height, mode);
                byte[] small = MakeThumbnail(b, swidth, sheight, mode);
                string s1 = string.Empty;
                string s2 = string.Empty;
                if (a.Length > 0)
                {
                    s1 = upload.UploadFile(a, filePath, newFileName);
                    s2 = upload.UploadFile(small, filePath, sFileName);
                }
                if (s1 == "ok" && s2=="ok")
                    return true;
                else
                    return false;
            }
            catch// (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region MakeThumbnail
        private byte[] MakeThumbnail(byte[] b, int width, int height, string mode)
        {
            MemoryStream ms = new MemoryStream(b);
            System.Drawing.Image originalImage = System.Drawing.Image.FromStream(ms);

            int towidth = width;
            int toheight = height;
            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;
            int sx = 0;
            int sy = 0;
            switch (mode.ToUpper())
            {
                case "HW"://指定高宽缩放（可能变形）                
                    break;
                case "W"://指定宽，高按比例                    
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "CUT"://指定高宽裁减（不变形）                
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                ///自动缩放，长或宽<  Thnumb的长或宽时，背景铺成白色...    
                ///9.20 Sam改动
                case "AUTO":           
                    if (originalImage.Width >= originalImage.Height)
                    {
                        toheight = originalImage.Height * width / originalImage.Width;
                        sy = (height - toheight) / 2;
                    }
                    else  //按高缩放
                    {
                        towidth = originalImage.Width * height / originalImage.Height;
                        sx = (width - towidth) / 2;
                    }
                    break;
                default:
                    break;
            }

            System.Drawing.Image bitmap = new System.Drawing.Bitmap(width, height);
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.Clear(Color.White);
            g.DrawImage(originalImage, new Rectangle(sx, sy, towidth, toheight), new Rectangle(x, y, ow, oh), GraphicsUnit.Pixel);
            g.Dispose();

            //以下代码为保存图片时，设置压缩质量   
            EncoderParameters encoderParams = new EncoderParameters();
            long[] quality = new long[1];
            quality[0] = 100;
            EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            encoderParams.Param[0] = encoderParam;
            //获取包含有关内置图像编码解码器的信息的ImageCodecInfo对象。   
            ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();
            ImageCodecInfo jpegICI = null;

            MemoryStream msto = new MemoryStream();
            try
            {
                for (int i = 0; i < arrayICI.Length; i++)
                {
                    if (arrayICI[i].FormatDescription.Equals("JPEG"))
                    {
                        jpegICI = arrayICI[i];//设置jpeg编码   
                        break;
                    }
                }
                if (jpegICI != null)
                {
                    bitmap.Save(msto, jpegICI, encoderParams);
                }
                else
                {
                    bitmap.Save(msto, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch //(Exception ex)
            {
                //this.Exception = ex.Message;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                ms.Close();
                if (msto != null)
                    msto.Close();
            }
            return msto.ToArray();
        }
        #endregion

    }

}
