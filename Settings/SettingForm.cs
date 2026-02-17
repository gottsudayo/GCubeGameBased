using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Settings
{
    public partial class SettingForm : Form
    {
        private static Dictionary<string, List<int>> settings = new Dictionary<string, List<int>>()
        {
            { "BGM", new List<int>() { 1, 100 } },
            { "SE", new List<int>() { 1, 100 } }
        };
        public SettingForm()
        {
            InitializeComponent();
        }
        private void SaveSettings()   // ê›íËÇÃèëÇ´çûÇ›
        {
            string raw = JsonSerializer.Serialize(settings);
            File.WriteAllText("./settings.json", raw);
        }
        private void SettingForm_Shown(object sender, EventArgs e)
        {
            if (File.Exists("./settings.json"))
            {
                string raw = File.ReadAllText("./settings.json");
                settings = JsonSerializer.Deserialize<Dictionary<string, List<int>>>(raw)
                    ?? new Dictionary<string, List<int>>()
                    {
                    { "BGM", new List<int>() { 1, 100 } },
                    { "SE", new List<int>() { 1, 100 } }
                    };
            }
            else
            {
                SaveSettings();
            }
            // ê›íËÇÃîΩâf
            EnableBGMCheck.Checked = settings["BGM"][0] == 1;
            BGMVolumeBar.Value = settings["BGM"][1];
            EnableSECheck.Checked = settings["SE"][0] == 1;
            SEVolumeBar.Value = settings["SE"][1];
        }
        private void SaveButton_Click(object sender, EventArgs e)   // ê›íËÇÃï€ë∂
        {
            settings["BGM"][0] = EnableBGMCheck.Checked ? 1 : 0;
            settings["BGM"][1] = BGMVolumeBar.Value;
            settings["SE"][0] = EnableSECheck.Checked ? 1 : 0;
            settings["SE"][1] = SEVolumeBar.Value;
            SaveSettings();
            Close();
        }
    }
}