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
    public partial class FormAddArticle : Form
    {
        private Article article = null; 

        public FormAddArticle()
        {
            InitializeComponent();
        }

        public FormAddArticle(Article selectedArticle)
        {
            InitializeComponent();
            article = selectedArticle;
            Text = "Modify Article";
        }

        private void FormAddArticle_Load(object sender, EventArgs e)
        {
            ElementBrandCompany brandCompany = new ElementBrandCompany();
            ElementCategoryCompany categoryCompany = new ElementCategoryCompany();

            try
            {
                ComboBoxBrand.DataSource = brandCompany.List();
                ComboBoxBrand.ValueMember = "Id";
                ComboBoxBrand.DisplayMember = "Description";
                ComboBoxCategory.DataSource = categoryCompany.List();
                ComboBoxCategory.ValueMember = "Id";
                ComboBoxCategory.DisplayMember = "Description";

                if (article != null)
                {
                    TextBoxArticleCode.Text = article.ArticleCode;
                    TextBoxName.Text = article.Name;
                    TextBoxDescription.Text = article.Description;
                    ComboBoxBrand.SelectedValue = article.Brand.Id;
                    ComboBoxCategory.SelectedValue = article.Category.Id;
                    TextBoxImageURL.Text = article.ImageURL;
                    LoadImage(article.ImageURL);
                    TextBoxPrice.Text = article.Price.ToString();
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            ArticleCompany articleCompany = new ArticleCompany();

            try
            {
                if (!CanAddItem())
                    return; 

                if (article == null)
                    article = new Article();

                article.ArticleCode = TextBoxArticleCode.Text;
                article.Name = TextBoxName.Text;
                article.Description = TextBoxDescription.Text;
                article.Brand = (Element)ComboBoxBrand.SelectedItem;
                article.Category = (Element)ComboBoxCategory.SelectedItem;
                article.ImageURL = TextBoxImageURL.Text;
                article.Price = decimal.Parse(TextBoxPrice.Text);

                if (article.Id != 0)
                {
                    articleCompany.ModifyArticle(article);
                    MessageBox.Show("Article successfully modified");
                }
                else
                {
                    articleCompany.AddArticle(article);
                    MessageBox.Show("Article successfully added");
                }

                Close();
            }
            catch (Exception exception)
            {   
                throw exception;
            }
        }

        private void TextBoxImageURL_Leave(object sender, EventArgs e) => LoadImage(TextBoxImageURL.Text);

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

        #region Add & Modify Exceptions

        private void BtnCancel_Click(object sender, EventArgs e) => Close();

        private bool CanAddItem()
        {
            if (TextBoxArticleCode.Text == "" || TextBoxName.Text == "" || TextBoxDescription.Text == "" || TextBoxImageURL.Text == "" || TextBoxPrice.Text == "")
            {
                MessageBox.Show("Please fill in all the fields to add or modify an item");
                return false;
            }

            if (!OnlyNumbers(TextBoxPrice.Text))
            {
                MessageBox.Show("Only numbers to add or modify the price");
                return false;
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
    }
}
