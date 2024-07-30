using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static ExamPrepper.Classes.ExamFormData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Windows.Forms;
using System.Reflection;

namespace ExamPrepper.Classes
{
    internal class JSONHandler
    {

        public static JsonSerializer ser = new JsonSerializer()
        {
            Converters = { new JavaScriptDateTimeConverter() },
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented,
        };

        #region JSON Operations
        public static void DataToJSON<T>(T data, string jsonFilePath) where T : class
        {
            SerializeLog(typeof(T).ToString());
            using (StreamWriter sw = new StreamWriter(jsonFilePath))
            {
                ser.Serialize(sw, data);
            }
        }

        public static T JSONToData<T>( string jsonFilePath) where T : class
        {
            DeserializeLog(typeof(T).ToString());
            string json = File.ReadAllText(jsonFilePath);
            try
            {
                T data = JsonConvert.DeserializeObject<T>(json.ToString());
                return data;
            }
            catch
            {
                return null;
            }           
        }

        public static void AddToJSON<T>(T data, string jsonFilePath) where T : class
        {
            AddingLog(typeof(T).ToString(), jsonFilePath);
            List<T> existingData = JSONToData<List<T>>(jsonFilePath);
            if (existingData == null) new List<T>();
            existingData.Add(data);
            DataToJSON(existingData, jsonFilePath);
        }

        public static void RemoveFromJSON<T>(T data, string jsonFilePath) where T : class
        {
            RemovingLog(typeof(T).ToString(), jsonFilePath);
            List<T> existingData = JSONToData<List<T>>(jsonFilePath);
            if (existingData == null) return;
            int index = existingData.FindIndex(dat => dat.Equals(data));
            existingData.RemoveAt(index);
            DataToJSON(existingData, jsonFilePath);
        }

        public static void EditInJSON<T>(T data, string jsonFilePath) where T : class
        {
            EditingLog(typeof(T).ToString(), jsonFilePath);
            if (data.GetType().IsGenericType && data is IList)
            {
                List<T> existingData = JSONToData<List<T>>(jsonFilePath);
                if (existingData == null) return;
                int index = existingData.FindIndex(dat => dat.Equals(data));
                existingData[index] = data;
                DataToJSON(existingData, jsonFilePath);
            }
            else
            {
                DataToJSON(data, jsonFilePath);
            }
        }
        #endregion JSON Operations

        #region "Logging"
        private static void SerializeLog(string obj)
        {
            LoggingHandler.Log($"Serializing {obj} to JSON data");
        }
        private static void DeserializeLog(string obj)
        {
            LoggingHandler.Log($"Deserializing {obj} to JSON data");
        }
        private static void AddingLog(string obj, string fp)
        {
            LoggingHandler.Log($"Adding {obj} to JSON data located in '{fp}'");
        }
        private static void RemovingLog(string obj, string fp)
        {
            LoggingHandler.Log($"Removing {obj} to JSON data located in '{fp}'");
        }
        private static void EditingLog(string obj, string fp)
        {
            LoggingHandler.Log($"Adding {obj} to JSON data located in '{fp}'");
        }
        #endregion

        #region "DataGridView Loading"

        public static void LoadData<T>(ref DataGridView dgvData, List<T> data, List<string> btnCaptions, bool clearDGV = true) where T : class
        {
            if (clearDGV) ClearDGV(dgvData);
            if (data == null) return;
            if (data.Count > 0)
                dgvData.DataSource = data;
            else
                return;
            addButtonsToDGV(dgvData, btnCaptions);
        }

        private static void ClearDGV(DataGridView dgvData)
        {
            dgvData.DataSource = null;
            dgvData.Rows.Clear();
            dgvData.Columns.Clear();
        }

        private static void addButtonsToDGV(DataGridView dgvData, List<string> buttonCaption)
        {
            foreach (string caption in buttonCaption)
            {
                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = $"dgv{caption}btn";
                deleteButton.HeaderText = caption;
                deleteButton.Text = caption;
                deleteButton.UseColumnTextForButtonValue = true;
                dgvData.Columns.Add(deleteButton);
            }
        }       
        #endregion "DataGridView Loading"

    }
}
