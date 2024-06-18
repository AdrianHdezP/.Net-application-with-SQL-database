using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Company
{
    public class ArticleCompany
    {

        public List<Article> List()
        {
            List<Article> list = new List<Article>();
            DataAccess data = new DataAccess();

            try
            {
                data.SetQuery("Select Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.IdMarca, A.IdCategoria, A.Id, ImagenUrl, Precio From ARTICULOS A, MARCAS M, CATEGORIAS C Where M.Id = A.IdMarca And C.Id = A.IdCategoria");
                data.ExecuteReading();

                while (data.Reader.Read())
                {
                    Article newArticle = new Article();

                    newArticle.Id = (int)data.Reader["Id"];
                    newArticle.ArticleCode = (string)data.Reader["Codigo"];
                    newArticle.Name = (string)data.Reader["Nombre"];
                    newArticle.Description = (string)data.Reader["Descripcion"];
                    newArticle.Brand = new Element();
                    newArticle.Brand.Id = (int)data.Reader["IdMarca"];
                    newArticle.Brand.Description = (string)data.Reader["Marca"];
                    newArticle.Category = new Element();
                    newArticle.Category.Id = (int)data.Reader["IdCategoria"];
                    newArticle.Category.Description = (string)data.Reader["Categoria"];

                    if (!(data.Reader["ImagenUrl"] is DBNull))
                        newArticle.ImageURL = (string)data.Reader["ImagenUrl"];

                    newArticle.Price = (decimal)data.Reader["Precio"];

                    list.Add(newArticle);
                }

                return list;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                data.ClosedConnection();
            }
        }

        public void AddArticle(Article articleToAdd)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.SetQuery("Insert Into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) Values (@ArticleCode, @Name, @Description, @IdBrand, @IdCategory, @ImageURL, @Price)");

                data.SetParameter("@ArticleCode", articleToAdd.ArticleCode);
                data.SetParameter("@Name", articleToAdd.Name);
                data.SetParameter("@Description", articleToAdd.Description);
                data.SetParameter("@IdBrand", articleToAdd.Brand.Id);
                data.SetParameter("@IdCategory", articleToAdd.Category.Id);
                data.SetParameter("@ImageURL", articleToAdd.ImageURL);
                data.SetParameter("@Price", articleToAdd.Price);

                data.ExecuteAction();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void ModifyArticle(Article articleToModify)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.SetQuery("Update ARTICULOS Set Codigo = @ArticleCode, Nombre = @Name, Descripcion = @Description, IdMarca = @IdBrand, IdCategoria = @IdCategory, ImagenUrl = @ImageURL, Precio = @Price Where Id = @Id");
               
                data.SetParameter("@ArticleCode", articleToModify.ArticleCode);
                data.SetParameter("@Name", articleToModify.Name);
                data.SetParameter("@Description", articleToModify.Description);
                data.SetParameter("@IdBrand", articleToModify.Brand.Id);
                data.SetParameter("@IdCategory", articleToModify.Category.Id);
                data.SetParameter("@ImageURL", articleToModify.ImageURL);
                data.SetParameter("@Price", articleToModify.Price);
                data.SetParameter("@Id", articleToModify.Id);

                data.ExecuteAction();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                data.ClosedConnection();
            }
        }

        public void DeleteArticle(int articleId)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.SetQuery("Delete From ARTICULOS Where Id = @Id");

                data.SetParameter("@Id", articleId);

                data.ExecuteAction();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                data.ClosedConnection();
            }
        }

        public List<Article> FilterArticle(string field, string principle, string filter)
        {
            DataAccess data = new DataAccess();
            List<Article> list = new List<Article>();

            try
            {
                string query = "Select Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.IdMarca, A.IdCategoria, A.Id, ImagenUrl, Precio From ARTICULOS A, MARCAS M, CATEGORIAS C Where M.Id = A.IdMarca And C.Id = A.IdCategoria And ";

                if (field == "Article Code")
                {
                    switch (principle)
                    {
                        case "Its letter is:":
                            query += "Codigo like '" + filter + "%' ";
                            break;

                        case "Contains the numbers:":
                            query += "Codigo like '%" + filter + "%'";
                            break;
                    }
                }
                else if (field == "Name" || field == "Description" || field == "Brand" || field == "Category")
                {
                    string newField = "";

                    switch (field)
                    {
                        case "Name":
                            newField = "Nombre";
                            break;

                        case "Description":
                            newField = "A.Descripcion";
                            break;

                        case "Brand":
                            newField = "M.Descripcion";
                            break;

                        case "Category":
                            newField = "C.Descripcion";
                            break;
                    }


                    switch (principle)
                    {
                        case "Start with the letter:":
                            query += newField + " like '" + filter + "%'";
                            break;

                        case "Contains the letter:":
                            query += newField + " like '%" + filter + "%'";
                            break;

                        case "Ends with the letter:":
                            query += newField + " like '%" + filter + "'";
                            break;
                    }
                }
                else if (field == "Price")
                {
                    switch (principle)
                    {
                        case "The number is greater than:":
                            query += "Precio > " + filter;
                            break;

                        case "The number is less than:":
                            query += "Precio < " + filter;
                            break;
                    }
                }

                data.SetQuery(query);
                data.ExecuteReading();

                while (data.Reader.Read())
                {
                    Article newArticle = new Article();

                    newArticle.Id = (int)data.Reader["Id"];
                    newArticle.ArticleCode = (string)data.Reader["Codigo"];
                    newArticle.Name = (string)data.Reader["Nombre"];
                    newArticle.Description = (string)data.Reader["Descripcion"];
                    newArticle.Brand = new Element();
                    newArticle.Brand.Id = (int)data.Reader["IdMarca"];
                    newArticle.Brand.Description = (string)data.Reader["Marca"];
                    newArticle.Category = new Element();
                    newArticle.Category.Id = (int)data.Reader["IdCategoria"];
                    newArticle.Category.Description = (string)data.Reader["Categoria"];

                    if (!(data.Reader["ImagenUrl"] is DBNull))
                        newArticle.ImageURL = (string)data.Reader["ImagenUrl"];

                    newArticle.Price = (decimal)data.Reader["Precio"];

                    list.Add(newArticle);
                }

                return list;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
