using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class AgentSelectionComboBoxItem
    {
        public string Name { get; set; }
        public Agents Agent { get; set; }
    }
    public enum Agents
    {
        Viper,
        Sage,
        Brimstone
    }
    class SettingsManager
    {
        private static readonly List<AgentSelectionComboBoxItem> _agentComboBoxItems = new List<AgentSelectionComboBoxItem>
        {
            new AgentSelectionComboBoxItem() { Name = "Viper", Agent = Agents.Viper },
            new AgentSelectionComboBoxItem() { Name = "Sage", Agent = Agents.Sage },
            new AgentSelectionComboBoxItem() { Name = "Brimstone", Agent = Agents.Brimstone },
        };

        public static void InitializeAgentSelectionComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = _agentComboBoxItems;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Agent";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void SaveCurrentlySelectedAgent(ComboBox comboBox)
        {
            var item = comboBox.SelectedItem as AgentSelectionComboBoxItem;
            if(item == null)
            {
                throw new InvalidOperationException("Selected item null or not a AgentSelectionComboBoxItem");
            }
            SettingsProvider.SelectedAgent = item.Agent;
        }



        //Intends to contain code for handling the settings page, including filling ui elements like comboboxes with static setting data.
        //Persists and loads settings.
    }
}
