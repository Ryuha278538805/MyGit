using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace HCW.Common
{
    public class MapperHelper
    {
        /// <summary>
        /// 类转换
        /// </summary>
        /// <typeparam name="T">要转化的类型</typeparam>
        /// <param name="objSource">源数据</param>
        /// <returns>新类</returns>
        public static T ToMapper<T>(object objSource)
        {
            var temp = JsonConvert.SerializeObject(objSource);
            return JsonConvert.DeserializeObject<T>(temp);
        }

        /// <summary>
        /// 类转换
        /// </summary>
        /// <typeparam name="T">要转化的类型</typeparam>
        /// <param name="objSource">源数据</param>
        /// <returns>新类列表</returns>
        public static IList<T> ToMapperList<T>(object objSource)
        {
            var temp = JsonConvert.SerializeObject(objSource);
            return JsonConvert.DeserializeObject<List<T>>(temp);
        }
    }
}
