using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormArticleDetail : Form
    {
        private Article article = null;

        public FormArticleDetail()
        {
            InitializeComponent();
        }

        public FormArticleDetail(Article selectedArticle)
        {
            InitializeComponent();
            article = selectedArticle;
        }

        private void FormArticleDetail_Load(object sender, EventArgs e)
        {
            LabelArticleCode.Text = "Article Code: " + article.ArticleCode;
            LabelName.Text = "Name: " + article.Name;
            LabelDescription.Text = "Description: " + article.Description;
            LabelBrand.Text = "Brand: " + article.Brand.Description;
            LabelCategory.Text = "Category: " + article.Category.Description;
            LoadImage(article.ImageURL);
            LabelPrice.Text = "Price: " + article.Price.ToString();
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

        private void BtnBack_Click(object sender, EventArgs e) => Close();
    }
}
