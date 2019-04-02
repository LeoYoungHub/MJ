using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MJ.Common
{
    public class Language
    {
        public static Language InstanceLanguage = new Language();
        private Dictionary<string, string> resources;
        /// <summary>
        /// 根据语言初始化信息。
        /// 加载对应语言的JSON信息，把翻译信息存储在全属性resources里面。
        /// </summary>
        /// <param name="language">默认的语言类型，如zh-Hans，en-US等</param>
        public void LoadLanguage(string language = "")
        {
            if (string.IsNullOrEmpty(language))
            {
                language = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
            }

            this.resources = new Dictionary<string, string>();
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("lang/{0}", language));
            if (Directory.Exists(dir))
            {
                var jsonFiles = Directory.GetFiles(dir, "*.json", SearchOption.AllDirectories);
                foreach (string file in jsonFiles)
                {
                    LoadFile(file);
                }
            }
        }

        private void LoadFile(string file)
        {
            var content = File.ReadAllText(file, Encoding.UTF8);
            if (!string.IsNullOrEmpty(content))
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
                foreach (string key in dict.Keys)
                {
                    //遍历集合如果语言资源键值不存在，则创建，否则更新
                    if (!resources.ContainsKey(key))
                    {
                        resources.Add(key, dict[key]);
                    }
                    else
                    {
                        resources[key] = dict[key];
                    }
                }
            }
        }

        /// <summary>
        /// 通过索引值取数据
        /// </summary>
        /// <param name="indexFields">索引字段</param>
        /// <returns></returns>
        public string this[string languageKey]
        {
            get
            {
                if (resources.ContainsKey(languageKey)) return resources[languageKey];
                return "[" + languageKey + "]";
            }
        }

    }
}
