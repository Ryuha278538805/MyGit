using System;
using System.Collections;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.IO;
using System.Net;
using System.Text;

namespace Admin.Ajax
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://admin.haocw.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class UpFiles1 : IHttpHandler
    {
         
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //验证上传的权限
            //------功能暂留

            string _fileNamePath = "";
            int _gid=0;
            try
            {
                _fileNamePath = context.Request.Form["upfile"];
                _gid = Common.TypeConverter.ObjectToInt(context.Request.Form["gid"]);
                string _savedFileResult = "";
                if (_gid > 0)
                {                  //开始上传
                    _savedFileResult = UpLoadFile(_fileNamePath);
                    if (_savedFileResult.Length > 0)
                    {
                        string[] li = _savedFileResult.Split('|');
                        if(Common.TypeConverter.StrToInt(li[0])==1)
                            DataProvider.AdminPageData.UpdateGoodsPhoto(_gid, li[1]);
                    }
                }
                else
                {
                    _savedFileResult = "0|error|没有对应的促销信息";
                }
                context.Response.Write(_savedFileResult);
            }
            catch
            {
                context.Response.Write("0|error|上传提交出错");
            }
        }

        /// <summary>
        /// 上传文件 方法
        /// </summary>
        /// <param name="fileNamePath"></param>
        /// <returns></returns>
        public string UpLoadFile(string fileNamePath)
        {
            //System.Threading.Thread.Sleep(10000);
            //System.Net.Mime.MediaTypeNames.Application.DoEvents(); 
            return UpLoadFile(fileNamePath, "");
        }

        /// <summary>
        /// 上传文件 方法
        /// </summary>
        /// <param name="fileNamePath"></param>
        /// <param name="toFilePath"></param>
        /// <returns>返回上传处理结果   格式说明： 0|file.jpg|msg   成功状态|文件名|消息    </returns>
        public string UpLoadFile(string fileNamePath, string toFilePath)
        {
            try
            {
                //获取要保存的文件信息
                FileInfo file = new FileInfo(fileNamePath);
                //获得文件扩展名
                string fileNameExt = file.Extension;

                //验证合法的文件
                if (CheckFileExt(fileNameExt))
                {
                    //生成将要保存的随机文件名
                    string fileName = GetFileName() + fileNameExt;
                    //检查保存的路径 是否有/结尾
                    if (toFilePath.EndsWith("/") == false) toFilePath = toFilePath + "/";

                    //按日期归类保存
                    string datePath = DateTime.Now.ToString("yyyy_MM") + "/" + DateTime.Now.ToString("dd") + "/";
                    if (true)
                    {
                        toFilePath += datePath;
                    }

                    string serverFileName;

                    //要上传的文件       
                    FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
                    //FileStream fs = OpenFile();       
                    BinaryReader r = new BinaryReader(fs);
                    //使用UploadFile方法可以用下面的格式       
                    //myWebClient.UploadFile(toFile, "PUT",fileNamePath);
                    byte[] postArray = r.ReadBytes((int)fs.Length);

                    com.haocw.images.UpLoad up = new com.haocw.images.UpLoad();
                    string s = up.UploadFile(postArray, toFilePath, fileName);
                    if (s == "ok")
                    {
                        //this.FileUrl = upload.FileServerUrl()+upload.FileServerDir()+"/" + filePath + "/"+ newFileName;
                        serverFileName = up.FileServerDir() +  toFilePath +  fileName;
                        return "1|" + serverFileName + "|" + "文件上传成功";
                    }
                    else
                    {
                        return "0|errorfile|" + "上传失败";                        
                    }
                   
                }
                else
                {
                    return "0|errorfile|" + "文件格式非法";
                }
            }
            catch (Exception e)
            {
                return "0|errorfile|" + "文件上传失败,错误原因：" + e.Message;
            }
        }

        /// <summary>
        /// 检查是否为合法的上传文件
        /// </summary>
        /// <param name="_fileExt"></param>
        /// <returns></returns>
        private bool CheckFileExt(string _fileExt)
        {
            string[] allowExt = new string[] { ".gif", ".jpg", ".jpeg" };
            for (int i = 0; i < allowExt.Length; i++)
            {
                if (allowExt[i] == _fileExt.ToLower()) { return true; }
            }
            return false;

        }

        public static string GetFileName()
        {
            Random rd = new Random();
            StringBuilder serial = new StringBuilder();
            serial.Append(DateTime.Now.ToString("yyyyMMddHHmmssff"));
            serial.Append(rd.Next(0, 999999).ToString());
            return serial.ToString();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
