using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Company
{
    public class ElementBrandCompany
    {

        public List<Element> List()
        {
            List<Element> list = new List<Element>();
            DataAccess data = new DataAccess();

            try
            {
                data.SetQuery("Select Id, Descripcion From MARCAS");
                data.ExecuteReading();

                while (data.Reader.Read())
                {
                    Element newElement = new Element();

                    newElement.Id = (int)data.Reader["Id"];
                    newElement.Description = (string)data.Reader["Descripcion"];

                    list.Add(newElement);
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
    }
}
