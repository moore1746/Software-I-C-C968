using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGU968
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static int prtIndex;


        //populateBindingLists
        public static void PopulateLists()
        {
            //populate Products
            Product testProd1 = new Product(1, "Product 1", (decimal)5.00, 15, 15, 20);
            Product testProd2 = new Product(2, "Product 2", (decimal)20.50, 26, 25, 30);
            Product testProd3 = new Product(3, "Product 3", (decimal)10.50, 10, 10, 20);
            Product testProd4 = new Product(4, "Product 4", (decimal)14.00, 25, 20, 30);

            Products.Add(testProd1);
            Products.Add(testProd2);
            Products.Add(testProd3);
            Products.Add(testProd4);

            //populate Parts

            Part testPart1 = new Inhouse(1, "Part 1", (decimal)10.00, 17, 15, 20);
            Part testPart2 = new Inhouse(2, "Part 2", (decimal)15.00, 15, 10, 20);
            Part testPart3 = new Inhouse(3, "Part 3", (decimal)20.00, 10, 10, 20);
            Part testPart4 = new Inhouse(4, "Part 4", (decimal)25.50, 15, 15, 20);
            Part testPart5 = new Outsourced(5, "Part 5", (decimal)5.00, 15, 10,20, "CompanyA");
            Part testPart6 = new Outsourced(6, "Part 6", (decimal)5.50, 15, 10, 20, "CompanyA");
            Part testPart7 = new Outsourced(7, "Part 7", (decimal)6.00, 15, 10, 20, "CompanyB");
            Part testPart8 = new Outsourced(8, "Part 8", (decimal)110.00, 15, 10, 20, "CompanyB");

            AllParts.Add(testPart1);
            AllParts.Add(testPart2);
            AllParts.Add(testPart3);
            AllParts.Add(testPart4);
            AllParts.Add(testPart5);
            AllParts.Add(testPart6);
            AllParts.Add(testPart7);
            AllParts.Add(testPart8);

            //Add Parts to Products

            testProd1.AddAssociatedPart(testPart1);
            testProd1.AddAssociatedPart(testPart2);
            testProd2.AddAssociatedPart(testPart3);
            testProd2.AddAssociatedPart(testPart4);
            testProd3.AddAssociatedPart(testPart5);
            testProd3.AddAssociatedPart(testPart6);
            testProd4.AddAssociatedPart(testPart7);
            testProd4.AddAssociatedPart(testPart8);

        }

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int id)
        {
            bool removed = false;

            foreach (Product product in Products)
            {
                if (id == product.ID)
                {
                    Products.Remove(product);
                        return removed = true;
                }
                else
                {
                    MessageBox.Show("Failed to Remove! Error!");
                    return false;
                }
            }
            return removed;
        }

        public static Product LookupProduct(int id)
        {
            foreach(Product product in Products)
            {
                if (product.ID == id)
                {
                    return product;
                }
            }
            Product voidProd = new Product();
            return voidProd;
        }

        public static void UpdateProduct(int id, Product updatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ID == id)
                {
                    currentProduct.name = updatedProduct.name;
                    currentProduct.price = updatedProduct.price;
                    currentProduct.Stock = updatedProduct.Stock;
                    currentProduct.min = updatedProduct.min;
                    currentProduct.max = updatedProduct.max;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;

                }
            }
        }

        public static void AddPart(int index, Part part)
        {
            AllParts.Insert(index - 1, part);
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        public static bool DeletePart(Part part)
        { 
              try
            {
                AllParts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part LookupPart(int id)
        {
            foreach(Part part in AllParts)
            {
                if(part.PartID == id)
                { 
                    return part;
                }
            }
            Part EmptyPart = null;
            return EmptyPart;
        }

     //   public static void UpdateInPart(int SelectedPart, Inhouse PartUpdate)
     //   {
            
     //   }

        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }

        public static void UpdatePart(int partID, Part part)
        {
            DeletePart(partID);
            AllParts.Add(part);
        }

    //    public static void UpdateOutPart(int SelectedPart, Outsourced PartUpdate)
    //    {
    //        foreach (Outsourced Part in AllParts)
    //        {
    //            if (SelectedPart == Part.PartID )
    //            {
    //                Part.Name = PartUpdate.Name;
    //                Part.Price = PartUpdate.Price;
    //                Part.InStock = PartUpdate.InStock;
    //                Part.Max = PartUpdate.Max;
    //                Part.Min = PartUpdate.Min;
    //                Part.Companyname = PartUpdate.Companyname;

    //            }

    //        }
    //    }
    }

  
}
