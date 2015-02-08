﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codenesium.TemplateGenerator.Classes.Generation;
namespace Codenesium.TemplateGenerator.UserControls
{
    public partial class Projects : UserControl
    {
        private bool _createMode;
        public Projects()
        {
            InitializeComponent();
            LoadForm();
            ProjectContainer.GetInstance().Reload += ProjectChanged;
        }

        private void ProjectChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            SetCreateMode(true);
            ClearFields();
        }

        public void SetCreateMode(bool value)
        {
            this._createMode = value;

        }

        public void ClearFields()
        {
            textBoxName.Clear();
            comboBoxProjects.SelectedIndex = -1;
            UncheckAll();
        }

        private void LoadForm()
        {            
            comboBoxProjects.DataSource = new BindingList<Project>(ProjectContainer.GetInstance().ProjectList);
            comboBoxProjects.DisplayMember = "Name";

            checkedListBoxTemplates.Items.Clear();//checkedlistbox doesn't support databinding
            foreach(Template template in TemplateContainer.GetInstance().TemplateList)
            {
                checkedListBoxTemplates.Items.Add(template.Name);
            }

            comboBoxProjects.SelectedIndex = -1;//force reselection so the template will load
            if(comboBoxProjects.Items.Count > 0)
            {
                comboBoxProjects.SelectedIndex = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (this._createMode)
            {
                List<ProjectTemplate> templateList = new List<ProjectTemplate>();
                foreach (var item in checkedListBoxTemplates.CheckedItems)
                {
                    ProjectTemplate projectTemplate = new ProjectTemplate();
                    projectTemplate.TemplateName = item.ToString();
                    templateList.Add(projectTemplate);
                }
                Project project = new Project();
                project.Name = textBoxName.Text;
                project.ProjectTemplateList.Clear();
                project.ProjectTemplateList.AddRange(templateList);
                ProjectContainer.GetInstance().UpdateProject(project);
                ProjectContainer.GetInstance().Save(ProjectContainer.GetInstance().FileLocation);
            }
            else
            {
                if(comboBoxProjects.SelectedIndex > -1)
                {
                    Project project = (Project)comboBoxProjects.SelectedItem;
                   
                    List<string> checkedItems = new List<string>();
                    foreach (var item in checkedListBoxTemplates.CheckedItems)
                    {
                        checkedItems.Add(item.ToString());
                    }

                    project.ProjectTemplateList.RemoveAll(x => !checkedItems.Contains(x.TemplateName)); //if we unchecked a template remove it                   
                    project.Name = textBoxName.Text;

                    foreach(string templateName in checkedItems)
                    {
                        if(!project.ProjectTemplateList.Any(x => x.TemplateName == templateName)) //iterate the list of checked items. If we're missing a template add it.
                        {
                            ProjectTemplate projectTemplate = new ProjectTemplate();
                            projectTemplate.TemplateName = templateName;
                            project.ProjectTemplateList.Add(projectTemplate);
                        }
                    }
                    
                    ProjectContainer.GetInstance().UpdateProject(project);
                    ProjectContainer.GetInstance().Save(ProjectContainer.GetInstance().FileLocation);
                }
            }
        }


        private void UncheckAll()
        {
            for(int i=0; i < checkedListBoxTemplates.Items.Count;i++)
            {
                checkedListBoxTemplates.SetItemChecked(i, false);
            }

        }
        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProjects.SelectedIndex > -1)
            {
                UncheckAll();
                
                Project project = (Project)comboBoxProjects.SelectedItem;
                textBoxName.Text = project.Name;

                foreach(ProjectTemplate template in project.ProjectTemplateList.ToList())
                {
                    int index = checkedListBoxTemplates.FindStringExact(template.TemplateName);
                    if(index > -1)
                    {
                        checkedListBoxTemplates.SetItemChecked(index, true);
                    }
                }
            }
        }
    }
}
