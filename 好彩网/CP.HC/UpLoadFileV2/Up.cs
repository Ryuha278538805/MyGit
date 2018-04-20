using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Services;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace UpLoadFileV2
{
    /// <summary>
    /// 文件上传控件
    /// </summary>
    public class Up
    {

        public Up()
        {
        }

        /// <summary>
        /// 上传后的文件地址
        /// </summary>
        public string FileUrl
        {
            get
            { return _fileUrl; }
            set
            { this._fileUrl = value; }
        }	private string _fileUrl;

        /// <summary>
        /// 生成的缩略图地址
        /// </summary>
        public string thumbUrl
        {
            set
            {
                this._thumbUrl = value;
            }
            get
            {
                return this._thumbUrl;
            }
        } private string _thumbUrl;

        /// <summary>
        /// 基本提示信息
        /// </summary>
        public string Message
        {
            get
            { return _message; }
            set
            { this._message = value; }
        }	private string _message;

        /// <summary>
        /// 异常信息
        /// </summary>
        public string Exception
        {
            get
            { return this._exception; }
            set
            { this._exception = value; }
        }	private string _exception;

        #region goods上传
        /// <summary>
        /// 上传200*auto和120*120的图
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="mode"></param>
        public void UpLoadGoodsPhotos(string filepath, int maxwidth, int width, int height)
        {
            string fileUrl = string.Empty;
            System.Web.HttpFileCollection oFiles;
            oFiles = System.Web.HttpContext.Current.Request.Files;
            com.haocw.images.UpLoad upload = new UpLoadFileV2.com.haocw.images.UpLoad();
            if (oFiles[0].ContentLength == 0) //文件大小处理
            {
                this.Message = "未指定上传文件";
                return;
            }
            string fileName = oFiles[0].FileName;
            string fileExt = (System.IO.Path.GetExtension(fileName).ToString().ToLower());
            if (!CheckFileExt(fileExt, upload.FileFormat())) //验证上传格式
            {
                this.Message = "不允许上传的文件格式!";
                return;
            }
            string file1 = System.DateTime.Now.ToString("yyyyMMddhhmmss") + fileExt;
            //20120117031009.jpg-120x120.jpg
            string file2 = file1 + "-" + width + "x" + height + fileExt;
            try
            {
                System.IO.Stream fs;
                byte[] b = new byte[oFiles[0].ContentLength];

                fs = (System.IO.Stream)oFiles[0].InputStream;
                fs.Read(b, 0, oFiles[0].ContentLength);
                fs.Close();
                filepath = filepath + "/" + GetDatePath();

                byte[] a = MakeThumbnail(b, maxwidth, maxwidth, "W");
                byte[] c = MakeThumbnail(b, width, height, "AUTO");

                string s = string.Empty;
                string s1 = string.Empty;
                if (a.Length > 0)
                {
                    s = upload.UploadFile(a, filepath, file1);
                }
                if (c.Length > 0)
                {
                    s1 = upload.UploadFile(c, filepath, file2);
                }
                if (s == "ok" && s1 == "ok")
                {
                    this.FileUrl = upload.FileServerUrl() + upload.FileServerDir() + "/" + filepath + "/"  + file1;
                    this.thumbUrl = upload.FileServerUrl() + upload.FileServerDir() + "/" + filepath + "/" + file2;
                    this.Message = "上传成功";
                }
                else
                {
                    this.Message = "上传失败";
                    this.Exception = s;
                }

            }
            catch (Exception ex)
            {
                this.Exception = ex.Message;
            }
        }

        #endregion

        #region 通用上传方法
        /// <summary>
        /// 通用上传方法
        /// </summary>
        /// <param name="filePath">上传后要保存的目录名,如ABC,或ABC\\123</param>
        public void UpFile(string filePath)
        {
            string fileUrl = string.Empty;
            System.Web.HttpFileCollection oFiles;
            oFiles = System.Web.HttpContext.Current.Request.Files;
            com.haocw.images.UpLoad upload = new UpLoadFileV2.com.haocw.images.UpLoad();
            if (oFiles[0].ContentLength == 0) //文件大小处理
            {
                this.Message = "未指定上传文件";
                return;
            }
            string fileName = oFiles[0].FileName;
            string fileExt = (System.IO.Path.GetExtension(fileName).ToString().ToLower());
            if (!CheckFileExt(fileExt, upload.FileFormat())) //验证上传格式
            {
                this.Message = "不允许上传的文件格式!";
                return;
            }
            string newFileName = System.DateTime.Now.ToString("yyyyMMddhhmmss") + fileExt;
            try
            {
                System.IO.Stream fs;
                byte[] b = new byte[oFiles[0].ContentLength];
                filePath = filePath +"/"+ GetDatePath();

                fs = (System.IO.Stream)oFiles[0].InputStream;
                fs.Read(b, 0, oFiles[0].ContentLength);
                fs.Close();
                string s = upload.UploadFile(b, filePath, newFileName);
                if (s == "ok")
                {
                    this.FileUrl = upload.FileServerUrl() + upload.FileServerDir() + "/" + filePath+ "/" + newFileName;
                    this.Message = "上传成功";
                }
                else
                {
                    this.Message = "上传失败";
                    this.Exception = s;
                }

            }
            catch (Exception ex)
            {
                this.Exception = ex.Message;
            }
        }
        #endregion

        #region 上传图片并按比例缩小方法
        /// <summary>
        /// 上传图片并按比例缩小方法
        /// </summary>
        /// <param name="filePath">上传后要保存的目录名,如ABC,或ABC\\123</param>
        /// <param name="ischg">是否需要缩小 1为缩小，0为不缩小</param>
        public void UpPhotoFileAndChgSamll(string filePath, bool ischg)
        {
            string fileUrl = string.Empty;
            System.Web.HttpFileCollection oFiles;
            oFiles = System.Web.HttpContext.Current.Request.Files;
            com.haocw.images.UpLoad upload = new UpLoadFileV2.com.haocw.images.UpLoad();
            if (oFiles[0].ContentLength == 0) //文件大小处理
            {
                this.Message = "未指定上传文件";
                return;
            }
            string fileName = oFiles[0].FileName;
            string fileExt = (System.IO.Path.GetExtension(fileName).ToString().ToLower());
            if (!CheckFileExt(fileExt, upload.FileFormat())) //验证上传格式
            {
                this.Message = "不允许上传的文件格式!";
                return;
            }
            string newFileName = System.DateTime.Now.ToString("yyyyMMddhhmmss") + fileExt;
            try
            {
                System.IO.Stream fs;
                byte[] b = new byte[oFiles[0].ContentLength];
                fs = (System.IO.Stream)oFiles[0].InputStream;
                fs.Read(b, 0, oFiles[0].ContentLength);
                fs.Close();
                filePath = filePath + "/" + GetDatePath();
                if (ischg)  //会自动缩小图片
                {
                    b = MakeThumbnailAuto(b, 200);
                }
                string s = upload.UploadFile(b, filePath, newFileName);
                if (s == "ok")
                {
                    this.FileUrl = upload.FileServerUrl() + upload.FileServerDir() + "/" + filePath + "/" + newFileName;
                    this.Message = "上传成功";
                }
                else
                {
                    this.Message = "上传失败";
                    this.Exception = s;
                }

            }
            catch (Exception ex)
            {
                this.Message = ex.Message;
            }
        }
        #endregion

        #region 上传图片并生成缩略图
        /// <summary>
        /// 上传图片并生成缩略图
        /// </summary>
        /// <param name="filePath">上传后要保存的目录名,如ABC,或ABC\\123</param>
        /// <param name="isMakeThumbnail">是否生成缩略图</param>
        /// <param name="width">缩略图宽</param>
        /// <param name="height">缩略图高</param>
        /// <param name="mode">缩略图方式hw,w,h,cut,auto</param>
        public void UpPhotoFile(string filePath, bool isMakeThumbnail, int width, int height, string mode)
        {
            string fileUrl = string.Empty;
            System.Web.HttpFileCollection oFiles;
            oFiles = System.Web.HttpContext.Current.Request.Files;
            com.haocw.images.UpLoad upload = new UpLoadFileV2.com.haocw.images.UpLoad();
            if (oFiles[0].ContentLength == 0) //文件大小处理
            {
                this.Message = "未指定上传文件";
                return;
            }
            string fileName = oFiles[0].FileName;
            string fileExt = (System.IO.Path.GetExtension(fileName).ToString().ToLower());
            if (!CheckFileExt(fileExt, upload.FileFormat())) //验证上传格式
            {
                this.Message = "不允许上传的文件格式!";
                return;
            }
            string newFileName = System.DateTime.Now.ToString("yyyyMMddhhmmss") + fileExt;
            try
            {
                System.IO.Stream fs;
                byte[] b = new byte[oFiles[0].ContentLength];

                fs = (System.IO.Stream)oFiles[0].InputStream;
                fs.Read(b, 0, oFiles[0].ContentLength);
                fs.Close();
                filePath = filePath + "/" + GetDatePath();
                string s = upload.UploadFile(b, filePath, newFileName);
                if (isMakeThumbnail) //生成缩略图
                {
                    byte[] a = MakeThumbnail(b, width, height, mode);
                    if (a.Length > 0)
                    {
                        string thnewFileName = "small_" + newFileName;
                        s = upload.UploadFile(a, filePath, thnewFileName);
                        this.thumbUrl = upload.FileServerUrl() + upload.FileServerDir() + "/" + filePath  + "/" + thnewFileName;
                    }
                }
                if (s == "ok")
                {
                    this.FileUrl = upload.FileServerUrl() + upload.FileServerDir() + "/" + filePath + "/" + newFileName;
                    //this.FileUrl = upload.FileServerDir() + "/" + filePath + "/" + datePath + "/" + newFileName;
                    this.Message = "上传成功";
                }
                else
                {
                    this.Message = "上传失败";
                    this.Exception = s;
                }

            }
            catch (Exception ex)
            {
                this.Exception = ex.Message;
            }
        }
        #endregion

        #region 上传固定大小的图片
        /// <summary>
        /// 只上传缩略图的方法
        /// </summary>
        /// <param name="filePath">目录名</param>
        /// <param name="width">图片宽</param>
        /// <param name="height">图片高</param>
        /// <param name="mode">缩略方式</param>
        public void UpLoadThumbnail(string filePath, int width, int height, string mode)
        {
            string fileUrl = string.Empty;
            System.Web.HttpFileCollection oFiles;
            oFiles = System.Web.HttpContext.Current.Request.Files;
            com.haocw.images.UpLoad upload = new UpLoadFileV2.com.haocw.images.UpLoad();
            if (oFiles[0].ContentLength == 0) //文件大小处理
            {
                this.Message = "未指定上传文件";
                return;
            }
            string fileName = oFiles[0].FileName;
            string fileExt = (System.IO.Path.GetExtension(fileName).ToString().ToLower());
            if (!CheckFileExt(fileExt, upload.FileFormat())) //验证上传格式
            {
                this.Message = "不允许上传的文件格式!";
                return;
            }
            string newFileName = System.DateTime.Now.ToString("yyyyMMddhhmmss") + fileExt;
            try
            {
                filePath = filePath + "/" + GetDatePath();
                System.IO.Stream fs;
                byte[] b = new byte[oFiles[0].ContentLength];

                fs = (System.IO.Stream)oFiles[0].InputStream;
                fs.Read(b, 0, oFiles[0].ContentLength);
                fs.Close();
                byte[] a = MakeThumbnail(b, width, height, mode);
                string s = string.Empty;
                if (a.Length > 0)
                {
                    s = upload.UploadFile(a, filePath, newFileName);
                }
                if (s == "ok")
                {
                    this.thumbUrl = upload.FileServerUrl() + upload.FileServerDir() + "/" + filePath +"/" + newFileName;
                    this.Message = "上传成功";
                }
                else
                {
                    this.Message = "上传失败";
                    this.Exception = s;
                }

            }
            catch (Exception ex)
            {
                this.Exception = ex.Message;
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

            if (mode == "W") //指定宽，高按比例                    
                toheight = originalImage.Height * width / originalImage.Width;
            if (mode == "H")//指定高，宽按比例
                towidth = originalImage.Width * height / originalImage.Height;
            if (mode == "CUT")//指定高宽裁减（不变形） 
            {
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
            }

            ///自动缩放，长或宽<  Thnumb的长或宽时，背景铺成白色...    
            ///9.20 Sam改动
            if (mode == "AUTO")
            {
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
            }

            System.Drawing.Image bitmap = null;
            if (mode == "AUTO")
                bitmap = new System.Drawing.Bitmap(width, height);
            else
                bitmap = new System.Drawing.Bitmap(towidth, toheight);
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
            catch (Exception ex)
            {
                this.Exception = ex.Message;
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

        #region MakeThumbnailAuto
        private byte[] MakeThumbnailAuto(byte[] b, int MaxLen)
        {
            MemoryStream ms = new MemoryStream(b);
            System.Drawing.Image originalImage = System.Drawing.Image.FromStream(ms);

            int towidth = MaxLen;
            int toheight = MaxLen;
            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            if (ow > MaxLen || oh > MaxLen)
            {
                if (ow > oh)
                {
                    toheight = originalImage.Height * MaxLen / originalImage.Width;  //根据宽度缩放
                }
                else
                {
                    towidth = originalImage.Width * MaxLen / originalImage.Height;    //根据高度缩放
                }
            }
            else
            {
                toheight = oh;
                towidth = ow;
            }


            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Color.Transparent);
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight), new Rectangle(x, y, ow, oh), GraphicsUnit.Pixel);
            MemoryStream msto = null;
            try
            {
                msto = new MemoryStream();
                bitmap.Save(msto, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (System.Exception e)
            {
                this.Message = e.Message;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
                ms.Close();
                if (msto != null)
                    msto.Close();
            }
            return msto.ToArray();
        }
        #endregion

        #region 对上传的文件扩展名进行验证
        private static bool CheckFileExt(string fileExt, string fileExts)
        {
            fileExt = fileExt.Substring(1); //去掉.
            string[] _validFileExt = fileExts.Split(',');
            foreach (string ext in _validFileExt)
            {
                if (ext.Trim().ToUpper().IndexOf(fileExt.Trim().ToUpper()) >= 0)
                    return true;
            }
            return false;
        }
        #endregion

        /// <summary>
        /// 返回日期目录
        /// </summary>
        /// <returns></returns>
        private string GetDatePath()
        {
            return DateTime.Now.ToString("yyyy-MM") + "/" + DateTime.Now.Day.ToString("00");
        }
    }
}