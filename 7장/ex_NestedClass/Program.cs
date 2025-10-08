using System;
using System.Collections.Generic;

namespace ex_NestedClass
{
    internal class Program
    {
        class Configuration
        {
            List<ItemValue> listConfig = new List<ItemValue>();

            // 새로운 설정을 추가하거나, 기존 설정 업데이트
            public void SetConfig(string item, string value)
            { 
                ItemValue iv = new ItemValue();
                iv.SetValue(this, item, value);
            }
            // 특정 item에 대한 value 조회
            public string GetConfig(string item)
            {
                foreach (ItemValue iv in listConfig)
                { 
                    if (iv.GetItem() == item)
                        return iv.GetValue();
                }
                return "";
            }

            private class ItemValue
            {
                private string item;
                private string value;

                public void SetValue(Configuration config, string item, string value)
                {
                    this.item = item;
                    this.value = value;

                    bool found = false;
                    for (int i = 0; i < config.listConfig.Count; i++) {
                        if (config.listConfig[i].item == item) {    // 기존 item이 있으면
                            config.listConfig[i] = this;    // 기존 객체를 현재 객체(this)로 교체
                            found = true;                   // 발견 표시 후 break
                            break;
                        }
                    }
                    if (found == false) 
                        config.listConfig.Add(this);    // for문 종료 후 found가 false이면 현재 객체를 추가
                    
                }

                public string GetItem()
                { return item; }

                public string GetValue() 
                { return value; }
            }
        }

        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655.324 KB");

            Console.WriteLine(config.GetConfig("Version")); // V 5.0
            Console.WriteLine(config.GetConfig("Size"));    // 655.324 KB

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version")); // V 5.0.1
        }
    }
}
