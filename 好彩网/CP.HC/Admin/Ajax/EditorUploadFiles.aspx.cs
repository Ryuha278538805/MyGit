using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.IO;
using System.Globalization;
using LitJson; 

namespace Admin.Ajax
{
    public partial class EditorUploadFiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpLoad();
        }

        public void UpLoad()
        {
            String aspxUrl = Request.Path.Substring(0, Request.Path.LastIndexOf("/") + 1);

            //定义允许上传的文件扩展名
            Hashtable extTable = new Hashtable();
            extTable.Add("image", "gif,jpg,jpeg,png,bmp");
            //extTable.Add("flash", "swf,flv");
            //extTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            //extTable.Add("file", "doc,docx,xls,xlsx,ppt,htm,html,txt,zip,rar,gz,bz2");

            string filetype = "image";

            //最大文件大小
            int maxSize = 512000;

            HttpPostedFile imgFile = Request.Files["imgFile"];
            if (imgFile == null)
            {
                showError("请选择文件。");
            }

            String fileName = imgFile.FileName;
            String fileExt = Path.GetExtension(fileName).ToLower();

            if (imgFile.InputStream == null || imgFile.InputStream.Length > maxSize)
            {
                showError("上传文件大小超过限制。");
            }
            if (String.IsNullOrEmpty(fileExt) || Array.IndexOf(((String)extTable[filetype]).Split(','), fileExt.Substring(1).ToLower()) == -1)
            {
                showError("上传文件扩展名是不允许的扩展名。\n只允许" + ((String)extTable[filetype]) + "格式。");
            }

            String fileUrl = UpLoad(imgFile);

            Hashtable hash = new Hashtable();
            hash["error"] = 0;
            hash["url"] = fileUrl;
            Response.AddHeader("Content-Type", "text/html; charset=UTF-8");
            Response.Write(JsonMapper.ToJson(hash));
            Response.End();
        }

        private string UpLoad(System.Web.HttpPostedFile File)
        {
            string filePath = DateTime.Now.ToString("yyyy-MM") + "/" + DateTime.Now.ToString("dd");

            string fileurl = string.Empty;
            string fileName = File.FileName;
            string fileExt = (System.IO.Path.GetExtension(fileName).ToString().ToLower());
            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss_ffff", DateTimeFormatInfo.InvariantInfo) + fileExt;
            com.haocw.images.UpLoad upload = new com.haocw.images.UpLoad();
            try
            {
                System.IO.Stream fs;
                byte[] b = new byte[File.ContentLength];
                fs = (System.IO.Stream)File.InputStream;
                fs.Read(b, 0, File.ContentLength);
                fs.Close();
                string s = upload.UploadFile(b, filePath, newFileName);
                if (s == "ok")
                {
                    fileurl =  Upload.picdomain + upload.FileServerDir() + "/" + filePath + "/" + newFileName;
                }
            }
            catch( Exception ex)
            {
                return ex.Message;
            }
            return fileurl;
        }

        private void showError(string message)
        {
            Hashtable hash = new Hashtable();
            hash["error"] = 1;
            hash["message"] = message;
            Response.AddHeader("Content-Type", "text/html; charset=UTF-8");
            Response.Write(JsonMapper.ToJson(hash));
            Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}
