/*
 *                              Settings Management Module
 *                      
 *       This class manages everything related to settings
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
    public class SettingsManagement
    {
        /// <summary>
        /// Handle everything related to settings
        /// </summary>
        
        // List of settings
        Dictionary<string, List<string>> settings = new Dictionary<string, List<string>>();

        // Location
        string location = "";

        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="_location">Location of settings file</param>
        public SettingsManagement(string _location = "")
        {
            // If the location is not empty, we load the settings
            if (_location != "")
            {
                location = _location;
                loadSettings(location);
            }
        }

        /// <summary>
        /// Loading the list of settings
        /// Loads the list of settings from the settings.json file
        /// </summary>
        /// <param name="_location">Location of the settings</param>
        /// <returns>List of settingss as string[]</returns>
        public string[] loadSettings(string _location)
        {
            // Loads the list of settings from the settings.sjon file
            location = _location;

            try
            {
                // If the file exist, we load the settings, otherwise we create a new file.
                if (System.IO.File.Exists(location + "\\settings.json"))
                {
                    string json = System.IO.File.ReadAllText(location + "\\settings.json");
                    settings = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
                }
                else
                    System.IO.File.Create(location + "\\settings.json");
            }
            catch (Exception) { }

            return getSettings();
        }

        /// <summary>
        /// Returns the list of settings available
        /// </summary>
        /// <returns>List of settings as string[]</returns>
        public string[] getSettings()
        {
            return settings.Keys.ToArray();
        }

        /// <summary>
        /// Returns a particular settings according to the ID provided
        /// </summary>
        /// <param name="ID">ID of the setting</param>
        /// <returns>Setting value as string</returns>
        public string getSetting(string ID)
        {
            // If the database has the particular setting, we return it, otherwise
            // we return null
            if (settings.ContainsKey(ID))
                return settings[ID][0];
            else
                return null;
        }

        /// <summary>
        /// Return the default value of the setting
        /// </summary>
        /// <param name="ID">ID of the setting</param>
        /// <returns>Value as a string</returns>
        public string getDefault(string ID)
        {
            // If the setting exist we return the default value, otherwise
            // we return null
            if (settings.ContainsKey(ID))
                return settings[ID][1];
            else
                return null;
        }

        /// <summary>
        /// Changes the value of the selected setting
        /// </summary>
        /// <param name="ID">ID of the setting</param>
        /// <param name="value">Value to be changed to</param>
        public void setSetting(string ID, string value)
        {
            // List of the setting values
            List<string> values = new List<string>();
            values.Add(value); // We add the new value

            // If the setting already exist, we add its default value to the
            // list otherwise we set this value as default as well
            if (settings.ContainsKey(ID))
                values.Add(settings[ID][1]);
            else
                values.Add(value);

            // Sets the new list as the settings
            settings[ID] = values;
        }

        /// <summary>
        /// Saves the settings to file
        /// </summary>
        public void saveSettings()
        {
            string json = JsonSerializer.Serialize<Dictionary<string, List<string>>>(settings);
            System.IO.File.WriteAllText(location + "\\settings.json", json);
        }

        /// <summary>
        /// Resets all settings to default
        /// </summary>
        public void setDefaults()
        {
            string[] settingKeys = settings.Keys.ToArray();

            // We create a temporary settings file and change the values to
            // defaults and finally save it
            foreach (string item in settingKeys)
            {
                List<string> values = new List<string>();
                values.Add(settings[item][1]);
                values.Add(settings[item][1]);

                settings[item] = values;
            }

            saveSettings();
        }
    }
}
