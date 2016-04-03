using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace AnythingCanBeDone.lib
{
    public class Json
    {
        // parse json string in to json object
        public JObject ParseJson(string jsonString)
        {
            JObject jsonObject = JObject.Parse(jsonString);
            return jsonObject;
        }

        // get json object attribute
        public string GetJsonAttribute(JObject jsonObject, string attributeName)
        {
            string returnValue = string.Empty;
            try
            {
                returnValue = jsonObject[attributeName].ToString();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            return returnValue;
        }

        // get json array object
        public JArray GetJsonArray(string jsonString, string root = "data")
        {
            JObject jsonObject = JObject.Parse(jsonString);
            JArray jarray = (JArray)jsonObject.SelectToken(root);
            return jarray;
        }

        public bool CompareJArrayObjects(JArray object1, JArray object2)
        {
            if (object1.Count != object2.Count)
            {
                return false;
            }
            else
            {
                return !object1.Where((t, counter) => !JToken.DeepEquals(object1.ToArray()[counter], object2.ToArray()[counter])).Any();
            }
        }


        public void SetJsonAttribute(JObject jsonObject, string attributeName, string value)
        {

            try
            {
                jsonObject[attributeName] = value;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


        }
    }
}
