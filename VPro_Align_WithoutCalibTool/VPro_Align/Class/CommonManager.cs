using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Cognex.VisionPro;


namespace VPro_Align
{
    public class CommonManager
    {
        string FilePath = "D:\\NewAlign2\\JsonData.json";

        public string RecipeName { get; set; }

        public int RecipeNum { get; set; }

        public string Cam1_Serial { get; set; }

        public string Cam2_Serial { get; set; }

        public double Cam1_PixelSize { get; set; }

        public double Cam2_PixelSize { get; set; }

        public void Save_Json()
        {
            // Main Recipe File
            var jsonFile = new JObject();

            // Recipe File 내에서 구분
            // 1. Recipe
            var jRecipe = new JObject();
            jRecipe.Add("RecipeName", RecipeName);
            jRecipe.Add("RecipeNum", RecipeNum);
            jRecipe.Add("Cam1_Serial", Cam1_Serial);
            jRecipe.Add("Cam2_Serial", Cam2_Serial);
            jRecipe.Add("Cam1_PixelSize", Cam1_PixelSize);
            jRecipe.Add("Cam2_PixelSize", Cam2_PixelSize);


            // 구분된 Recipe 저장 내용들을 Main Recipe File 에 저장 
            jsonFile.Add("Recipe", jRecipe);

            string sjsonFile = jsonFile.ToString();

            

            System.IO.File.WriteAllText(FilePath, sjsonFile);
        }

        public void Load_Json()
        {
            if (!System.IO.File.Exists(FilePath))
                return;

            // Main Recipe File
            JObject jsonFile = JObject.Parse(File.ReadAllText(FilePath));
            
            // Recipe File 내에서 구분
            // 1. Recipe
            JObject jRecipe = (JObject)jsonFile["Recipe"];

            RecipeName = jRecipe["RecipeName"].ToString();
            RecipeNum = jRecipe["RecipeNum"].ToString() == "" ? 0 : int.Parse(jRecipe["RecipeNum"].ToString());
            Cam1_Serial = jRecipe["Cam1_Serial"].ToString();
            Cam2_Serial = jRecipe["Cam2_Serial"].ToString();
            Cam1_PixelSize = jRecipe["Cam1_PixelSize"].ToString() == "" ? 0 : double.Parse(jRecipe["Cam1_PixelSize"].ToString());
            Cam2_PixelSize = jRecipe["Cam2_PixelSize"].ToString() == "" ? 0 : double.Parse(jRecipe["Cam2_PixelSize"].ToString());
        }

        /*
        public void Save_Json(string jCategory, string jVarName, object jObj)
        {
            System.Type type = jObj.GetType();
            string TypeName = type.FullName;      


            // Main Recipe File
            var jsonFile = new JObject();

            // Recipe File 내에서 구분
            var jPart = new JObject();

            if (TypeName.Contains("Int16"))
                jPart.Add(jVarName, (Int16) jObj);
            else if (TypeName.Contains("Int32"))
                jPart.Add(jVarName, (Int32)jObj);
            else if (TypeName.Contains("Int64"))
                jPart.Add(jVarName, (Int64)jObj);
            else if (TypeName.Contains("Double"))
                jPart.Add(jVarName, (Double)jObj);
            else if (TypeName.Contains("String"))
                jPart.Add(jVarName, (string)jObj);

            // 구분된 Recipe 저장 내용들을 Main Recipe File 에 저장 
            jsonFile.Add(jCategory, jPart);

            string sjsonFile = jsonFile.ToString();

            string FilePath = "D:\\test.json";

            System.IO.File.WriteAllText(FilePath, sjsonFile);           
        }
        */

        /*
        public void Load_Json(string jCategory, string jVarName, out object jObj)
        {
            jObj = null; // 초기화 

            System.Type type = jObj.GetType();
            string TypeName = type.FullName;


            string FilePath = "D:\\test.json";
            if (!System.IO.File.Exists(FilePath))
                return;

            // Main Recipe File
            JObject jsonFile = JObject.Parse(File.ReadAllText(FilePath));

            // Recipe File 내에서 구분
            // 1. Recipe
            JObject jPart = (JObject)jsonFile["jCategory"];

            if (TypeName.Contains("Int16") || TypeName.Contains("Int32") || TypeName.Contains("Int64"))
                jObj = jPart[jVarName].ToString() == "" ? 0 : int.Parse(jPart[jVarName].ToString());

            else if (TypeName.Contains("Double"))
                jObj = jPart[jVarName].ToString() == "" ? 0 : Double.Parse(jPart[jVarName].ToString());

            else if (TypeName.Contains("String"))
                jObj = jPart[jVarName].ToString();
        }
        */



        public void Save_Vpp(Object CogObj, string FilePath)
        {
            try
            {
                CogSerializer.SaveObjectToFile(CogObj, FilePath);
            }
            catch(Exception e)
            {

            }
        }


        public Object Load_Vpp(string FilePath)
        {
            Object CogObj;

            try
            {
                CogObj = CogSerializer.LoadObjectFromFile(FilePath);

                return CogObj;
            }
            catch(Exception e)
            {
                CogObj = null;

                return CogObj;
            }
        }


        public void Save_Object(Object ClassObject, string FilePath)
        {
            try
            {

                string sjsonFile = JsonConvert.SerializeObject(ClassObject);
               
                System.IO.File.WriteAllText(FilePath, sjsonFile);
            }
            catch (Exception e)
            {

            }
        }


        public T Load_Object<T>(string FilePath)
        {
            T ClassObject = default(T);

            try
            {
                if (!System.IO.File.Exists(FilePath))
                    return ClassObject;

                string sjsonFile = File.ReadAllText(FilePath);

                var test = JsonConvert.DeserializeObject<T>(sjsonFile);

                return ClassObject;
            }
            catch (Exception e)
            {
                ClassObject = default(T); 

                return ClassObject;
            }
        }

    }


    
}
