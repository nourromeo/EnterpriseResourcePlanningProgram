using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Affärssystem
{
    public class ShoppingCart
    {
        public BindingList<Product> ProductList { get; private set; }

        public ShoppingCart()
        {
            ProductList = new BindingList<Product>();
        }


        public void SaveFile()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("products");
            foreach (var product in ProductList)
            {
                XmlElement elem = doc.CreateElement("products");

                XmlElement productID = doc.CreateElement("ProductID");
                productID.InnerText = product.ID;
                elem.AppendChild(productID);

                XmlElement name = doc.CreateElement("Name");
                name.InnerText = product.Name;
                elem.AppendChild(name);

                XmlElement author = doc.CreateElement("Author");
                author.InnerText = product.Author;
                elem.AppendChild(author);

                XmlElement language = doc.CreateElement("Language");
                language.InnerText = product.Language;
                elem.AppendChild(language);

                XmlElement genre = doc.CreateElement("Genre");
                genre.InnerText = product.Genre;
                elem.AppendChild(genre);

                XmlElement price = doc.CreateElement("Price");
                price.InnerText = product.Price;
                elem.AppendChild(price);

                XmlElement format = doc.CreateElement("Format");
                format.InnerText = product.Format;
                elem.AppendChild(format);

                XmlElement type = doc.CreateElement("Type");
                type.InnerText = product.Type;
                elem.AppendChild(type);

                XmlElement platform = doc.CreateElement("Platform");
                platform.InnerText = product.PLatform;
                elem.AppendChild(platform);

                XmlElement playtime = doc.CreateElement("Playtime");
                playtime.InnerText = product.Playtime;
                elem.AppendChild(playtime);

                XmlElement quantity = doc.CreateElement("Quantity");
                quantity.InnerText = product.Quantity;
                elem.AppendChild(quantity);

                root.AppendChild(elem);
            }
            doc.AppendChild(root);
            doc.Save("database.xml");
        }

        public void LoadFile()
        {
            XmlDocument document = new XmlDocument();
            document.Load("database.xml");
            var root = document.FirstChild;

            foreach (XmlElement elem in root.ChildNodes)
            {
                var product = new Product();
                foreach (XmlElement el in elem.ChildNodes)
                {                    
                    if (el.Name == "ProductID") product.ID = el.InnerText;
                    if (el.Name == "Name") product.Name = el.InnerText;
                    if (el.Name == "Author") product.Author = el.InnerText;
                    if (el.Name == "Language") product.Language = el.InnerText;
                    if (el.Name == "Genre") product.Genre = el.InnerText;
                    if (el.Name == "Price") product.Price = el.InnerText;
                    if (el.Name == "Format") product.Format = el.InnerText;
                    if (el.Name == "Type") product.Type = el.InnerText;
                    if (el.Name == "Playtime") product.Playtime = el.InnerText;
                    if (el.Name == "PLatform") product.PLatform = el.InnerText;
                    if (el.Name == "Quantity") product.Quantity = el.InnerText;
                }
                ProductList.Add(product);
            }
        }
    }
}
