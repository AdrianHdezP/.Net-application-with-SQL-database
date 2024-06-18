using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Company;

namespace App
{
    public partial class FormArticleList : Form
    {
        private List<Article> articlesList;

        public FormArticleList()
        {
            InitializeComponent();
        }

        private void FormArticleList_Load(object sender, EventArgs e)
        {
            LoadList();
            AddFieldsToComboBox();
        }

        private void LoadList()
        {
            ArticleCompany articleCompany = new ArticleCompany();
            articlesList = articleCompany.List();

            DataGridView.DataSource = articlesList;
            LoadImage(articlesList[0].ImageURL);
            HideColums();
        }

        private void HideColums()
        {
            DataGridView.Columns["Id"].Visible = false;
            DataGridView.Columns["ImageURL"].Visible = false;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
                return;

            Article selectedArticle = (Article)DataGridView.CurrentRow.DataBoundItem;
            LoadImage(selectedArticle.ImageURL);
        }

        private void LoadImage(string imageURL)
        {
            try
            {
                PictureBox.Load(imageURL);
            }
            catch (Exception)
            {
                string placeholderImageURL = "https://lh4.googleusercontent.com/proxy/qi9EXf-Xo3kgK4r0nGy4C42hY_BihCq365KLinAFHr5Zi2Q7rq4BSOwQ2dtWLwX-VKkfrrMFGzI3SU3XUBJOEUlLWHuiHvKFJPBMkCl4pYf9ug";
                PictureBox.Load(placeholderImageURL);
            }
        }

        #region Detail, Add, Modify, Delete

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            Article selectedArticle = (Article)DataGridView.CurrentRow.DataBoundItem;
            FormArticleDetail formArticleDetail = new FormArticleDetail(selectedArticle);
            formArticleDetail.ShowDialog();
            LoadList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddArticle formAddArticle = new FormAddArticle();
            formAddArticle.ShowDialog();
            LoadList();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            Article selectedArticle = (Article)DataGridView.CurrentRow.DataBoundItem;
            FormAddArticle formAddArticle = new FormAddArticle(selectedArticle);
            formAddArticle.ShowDialog();
            LoadList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ArticleCompany articleCompany = new ArticleCompany();
            Article selectedArticle;

            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete it?", "Delete Article", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    selectedArticle = (Article)DataGridView.CurrentRow.DataBoundItem;
                    articleCompany.DeleteArticle(selectedArticle.Id);
                    LoadList();
                    MessageBox.Show("Correctly deleted");
                }    
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        #endregion

        #region Filters

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            List<Article> filteredList;
            string filter = TextBoxFilter.Text;

            if (filter != "")
                filteredList = articlesList.FindAll(x =>
                x.Name.ToUpper().Contains(filter.ToUpper()) ||
                x.ArticleCode.ToUpper().Contains(filter.ToUpper()));
            else
                filteredList = articlesList;

            DataGridView.DataSource = null;
            DataGridView.DataSource = filteredList;
            HideColums();
        }

        private void AddFieldsToComboBox()
        {
            ComboBoxField.Items.Add("Article Code");
            ComboBoxField.Items.Add("Name");
            ComboBoxField.Items.Add("Description");
            ComboBoxField.Items.Add("Brand");
            ComboBoxField.Items.Add("Category");
            ComboBoxField.Items.Add("Price");
        }

        private void ResetFilter()
        {
            ArticleCompany articleCompany = new ArticleCompany();

            DataGridView.DataSource = articleCompany.List();
            ComboBoxField.Items.Clear();
            ComboBoxPrinciple.Items.Clear();
            AddFieldsToComboBox();
            TextBoxFilter.Text = "";
            TextBoxFilter2.Text = "";
        }

        private void ComboBoxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string field = ComboBoxField.SelectedItem.ToString();

            if (field == "Article Code")
            {
                ComboBoxPrinciple.Items.Clear();
                ComboBoxPrinciple.Items.Add("Its letter is:");
                ComboBoxPrinciple.Items.Add("Contains the numbers:");
            }
            else if (field == "Name" || field == "Description" || field == "Brand" || field == "Category")
            {
                ComboBoxPrinciple.Items.Clear();
                ComboBoxPrinciple.Items.Add("Start with the letter:");
                ComboBoxPrinciple.Items.Add("Contains the letter:");
                ComboBoxPrinciple.Items.Add("Ends with the letter:");
            }
            else if (field == "Price")
            {
                ComboBoxPrinciple.Items.Clear();
                ComboBoxPrinciple.Items.Add("The number is greater than:");
                ComboBoxPrinciple.Items.Add("The number is less than:");
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            ArticleCompany articleCompany = new ArticleCompany();   

            try
            {
                if (!CanFilter())
                    return;

                string field = ComboBoxField.SelectedItem.ToString();
                string principle = ComboBoxPrinciple.SelectedItem.ToString();
                string filter = TextBoxFilter2.Text;

                DataGridView.DataSource = articleCompany.FilterArticle(field, principle, filter);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void BtnResetFilter_Click(object sender, EventArgs e) => ResetFilter();

        #region Filter Exceptions

        private bool CanFilter()
        {
            if (ComboBoxField.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the field to be filtered");
                return false;
            }

            if (ComboBoxPrinciple.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the principle to be filtered");
                return false;
            }

            if (ComboBoxField.SelectedItem.ToString() == "Price")
            {
                if (TextBoxFilter2.Text == "")
                {
                    MessageBox.Show("Please write numbers in the filter");
                    return false;
                }

                if (!OnlyNumbers(TextBoxFilter2.Text))
                {
                    MessageBox.Show("Please only numbers for filtering price");
                    TextBoxFilter2.Text = "";
                    return false;
                }
            }

            return true;
        }

        private bool OnlyNumbers(string myString)
        {
            foreach (char character in myString)
            {
                if (!char.IsNumber(character))
                    return false;
            }

            return true;
        }

        #endregion

        #endregion
    }
}
