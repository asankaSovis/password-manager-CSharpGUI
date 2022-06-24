/*
 *                              Language Management Module
 *                      
 *       This class manages everything related to translations and strings
 */

/// NOTE: Username and profile, platform and website are used interchangeably

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json; // JSON Handling

namespace password_manager_CSharpGUI
{
    /// <summary>
    /// This class manages everything related to translations and strings
    /// </summary>
    public class LanguageManagement
    {
        // List of languages available
        Dictionary<string, List<string>> languageList = new Dictionary<string, List<string>>();
        // List of strings
        Dictionary<string, string> strings = new Dictionary<string, string>();

        // Location and selected languange
        string location = "";
        string selectedLanguage = "";

        /// <summary>
        /// Loads the class
        /// </summary>
        /// <param name="_location">Location of the language files</param>
        public LanguageManagement(string _location = "")
        {
            // If the location is not empty, we load the languages
            if (_location != "")
            {
                location = _location;
                loadLanguages(location);
            }
        }

        /// <summary>
        /// Loading the ist of languages
        /// Loads the list of available languages and their details from the
        /// languages.json file
        /// </summary>
        /// <param name="_location">Location of the languages</param>
        /// <returns>List of languages as string</returns>
        public string[] loadLanguages(string _location)
        {
            try
            {
                // Loads the list of available languages and their details from the
                // languages.json file
                location = _location;

                string json = System.IO.File.ReadAllText(location + "\\languages.json");
                languageList = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
            } catch (Exception) { }

            return getLanguages();
        }

        /// <summary>
        /// Returns the list of languages available
        /// </summary>
        /// <returns>List of languages as string</returns>
        public string[] getLanguages()
        {
            return languageList.Keys.ToArray();
        }

        /// <summary>
        /// Returns the list of strings along with their corresponding details
        /// as a dictionary of lists of strings (List holding the information)
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<string>> getLanguageData()
        {
            return languageList;
        }

        /// <summary>
        /// Selects a language for the strings
        /// </summary>
        /// <param name="language">Language to be selected</param>
        /// <returns>Returns whether successful or failed</returns>
        public bool selectLanguage(string language)
        {
            // If the requested language is available, we select it
            if (getLanguages().Contains(language))
                selectedLanguage = language;

            return (selectedLanguage == language);
        }

        /// <summary>
        /// Loads all the strings for the selected language
        /// </summary>
        /// <param name="formID"></param>
        /// <returns></returns>
        public bool loadStrings(string formID)
        {
            bool error = false; // Successful or failed
            Dictionary<string, string> loadedStrings = new Dictionary<string, string>(); // Loaded strings

            // We load the translation file and for each of the items, we check
            // if it matches the formID. If so we add it to the main variable
            try
            {
                string json = System.IO.File.ReadAllText(location + "\\" + languageList[selectedLanguage][2]);
                loadedStrings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

                foreach (var item in loadedStrings.Keys)
                {
                    if (item.Contains(formID + "x"))
                        strings[item] = loadedStrings[item];
                }
            } catch { error = true; }

            return error;
        }

        /// <summary>
        /// Returns the translation according to the ID
        /// </summary>
        /// <param name="ID">ID of the string</param>
        /// <returns>String</returns>
        public string get(string ID)
        {
            string returnVal = "";

            try { returnVal = strings[ID]; } catch { returnVal = ID; }

            return returnVal;
        }

        /// <summary>
        /// Returns the translation according to the ID and a variable assigned
        /// </summary>
        /// <param name="ID">ID of the string</param>
        /// <returns>String</returns>
        public string get(string ID, string vars)
        {
            string returnVal = "";

            try { returnVal = strings[ID]; } catch { returnVal = ID; }

            return parse(returnVal, vars);
        }

        /// <summary>
        /// Returns the translation according to the ID and an array of variables assigned
        /// </summary>
        /// <param name="ID">ID of the string</param>
        /// <returns>String</returns>
        public string get(string ID, string[] vars)
        {
            string returnVal = "";

            try { returnVal = strings[ID]; } catch { returnVal = ID; }

            return parse(returnVal, vars); ;
        }

        /// <summary>
        /// Returns a string after replacing all variables
        /// </summary>
        /// <param name="text">Text</param>
        /// <returns>String</returns>
        public static string parse(string text, string vars)
        {
            try { return text.Replace("%s0", vars); }catch { return text; }
        }

        /// <summary>
        /// Returns a string after replacing all variables
        /// </summary>
        /// <param name="text">Text</param>
        /// <returns>String</returns>
        public static string parse(string text, string[] vars)
        {
            if (vars != null)
            {
                for (int i = 0; i < vars.Length; i++)
                {
                    try { text = text.Replace("%s" + i.ToString(), vars[i]); } catch { }
                }
            }

            return text;
        }
    }
}
