using System;
using System.Collections;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace Pic
{
    /// <summary>
    /// 上传图片Web服务
    /// </summary>
    /// 
    [WebService(Namespace = "http://images.haocw.com")]
    public class UpLoad : System.Web.Services.WebService 
    {

       private string _FileServerUrl;
		private string _FileServerDir;
		private string _FileFormat;
        private string _WaterMark;
		public UpLoad()
		{
			InitializeComponent();
			_FileServerUrl = System.Configuration.ConfigurationSettings.AppSettings["FileServerUrl"];
			_FileServerDir = System.Configuration.ConfigurationSettings.AppSettings["FileServerDir"];
			_FileFormat = System.Configuration.ConfigurationSettings.AppSettings["FileFormat"];
            _WaterMark = System.Configuration.ConfigurationSettings.AppSettings["WaterMark"];
		}

		[WebMethod(Description="Web 服务提供的方法，返回文件服务器URL配置")]
		public string FileServerUrl()
		{
			return _FileServerUrl;
		}

		[WebMethod(Description="Web 服务提供的方法，返回文件服务器目录配置")]
		public string FileServerDir()
		{
            return _FileServerDir;
		}	

		[WebMethod(Description="Web 服务提供的方法，返回文件扩展名配置")]
		public string FileFormat()
		{
			return _FileFormat;
        }

 


		#region 组件设计器生成的代码
		
		//Web 服务设计器所必需的
		private IContainer components = null;
				
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion



		[WebMethod(Description="Web 服务提供的方法，返回是否文件上载成功与否，自带日期目录")]
		public string UploadFile(byte[] fs,string Path,string FileName)
		{
            MemoryStream stream = null;
            FileStream stream2 = null;
            string str = string.Empty;
            string path = base.Server.MapPath(".") + @"\" + _FileServerDir + @"\" + Path;
            try
            {
                str = FileName.Substring(0, FileName.IndexOf('.')) + "_temp." + FileName.Substring(FileName.IndexOf('.') + 1);
                stream = new MemoryStream(fs);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                stream2 = new FileStream(path + @"\" + str, FileMode.Create);
                stream.WriteTo(stream2);
                stream2.Close();
                stream.Close();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            Image image = null;
            Image image2 = null;
            Graphics graphics = null;
            try
            {
                image = Image.FromFile(path + @"\" + str);
                if ((image.Width >= 250) || (image.Height >= 250))
                {
                    image2 = Image.FromFile(base.Server.MapPath("/") + _WaterMark);
                    graphics = Graphics.FromImage(image);
                    graphics.InterpolationMode = InterpolationMode.High;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.DrawImage(image2, new Rectangle(image.Width - image2.Width, image.Height - image2.Height, image2.Width, image2.Height), 0, 0, image2.Width, image2.Height, GraphicsUnit.Pixel);
                    image2.Dispose();
                    graphics.Dispose();
                }
                image.Save(path + @"\" + FileName);
                image.Dispose();
            }
            catch (Exception exception2)
            {
                return exception2.Message;
            }
            try
            {
                if (File.Exists(path + @"\" + str))
                {
                    File.Delete(path + @"\" + str);
                }
                return "ok";
            }
            catch (Exception exception3)
            {
                return exception3.Message;
            }
		}

	}
}
