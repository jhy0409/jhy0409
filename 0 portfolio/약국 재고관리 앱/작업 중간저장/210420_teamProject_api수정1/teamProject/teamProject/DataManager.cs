using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace teamProject
{
    class DataManager
    {
        public static List<Entp> Comps = new List<Entp>();
        static DataManager()
        {
            Load();
        }
        public static void Load()
        {
            Comps.Clear();
            try
            {
                string compOutput = File.ReadAllText(@"./drugCompInfo.xml");
                XElement compElement = XElement.Parse(compOutput);
                // XElement <속성명>데이터1</속성명>
                foreach (var item in compElement.Descendants("comp"))
                {
                    string tempEntpName = item.Element("entpName").Value;
                    string tempEntpTel = item.Element("entpTel").Value;
                    string tempEntpAddr = item.Element("entpAddr").Value;
                    string tempEntpEmail = item.Element("entpEmail").Value;

                    Entp tempEntp = new Entp()
                    {
                        entpName = tempEntpName,
                        entpTel = tempEntpTel,
                        entpAddr = tempEntpAddr,
                        entpEmail = tempEntpEmail
                    };
                    Comps.Add(tempEntp);
                }
            }
            catch (Exception ex)
            { 
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                CreateFile(); 
                Save(); 
                Load(); 
                // 단, Load 함수자체가 잘못됐다면 코드는 무한루프
            }
        }

        private static void CreateFile()
        {
            // drugCompInfo.xml파일 생성
            string fileName = @"./drugCompInfo.xml";
            StreamWriter writer = File.CreateText(fileName);
            writer.Dispose();
        }

        public static void Save()
        {
            string compOutput = "";
            compOutput += "<comps>\n";

            if (Comps.Count > 0)
            {
                foreach (var item in Comps)
                {
                    compOutput += "<comp>\n";
                    compOutput += $"   <entpName>{item.entpName}</entpName>";
                    compOutput += $"   <entpTel>{item.entpTel}</entpTel>";
                    compOutput += $"   <entpAddr>{item.entpAddr}</entpAddr>";
                    compOutput += $"   <entpEmail>{item.entpEmail}</entpEmail>";
                    compOutput += "</comp>\n";
                }
            }
            else // xml파일에 아무것도 없는 경우
            {
                for (int i = 0; i < 5; i++)
                {
                    compOutput += "<comp>\n";
                    compOutput += $"   <entpName>{i}</entpName>";
                    compOutput += $"   <entpTel></entpTel>";
                    compOutput += $"   <entpAddr></entpAddr>";
                    compOutput += $"   <entpEmail></entpEmail>";
                    compOutput += "</comp>\n";
                }
            }
            compOutput += "</comps>";
            File.WriteAllText(@"./drugCompInfo.xml", compOutput);
        }

        public static void printLog(string contents, string name = "drugComp")
        {
            DirectoryInfo di = new DirectoryInfo("drugComp");
            if (!di.Exists)
            {
                di.Create();
            }

            // 앞에 @가 있으면 \를 한개만 적는다.
            // @가 없으면 \\ 두번 써야 \하나로 인식
            //using (StreamWriter writer = new StreamWriter(@"drugComp\drugComp.txt",true))

            //string directory = drugComp;
            //using (StreamWriter writer = new StreamWriter(directory+@"\"+name+ ".txt", true))
            using (StreamWriter writer = new StreamWriter(@"drugComp\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
