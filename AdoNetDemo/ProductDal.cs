using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    internal class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products",_connection);
            SqlDataReader reader= command.ExecuteReader();    
            
            List<Product> products = new List<Product>();
            
            while (reader.Read())
            {
                Product product = new Product
                {
                  Id =Convert.ToInt32(reader["ID"]),
                  Name=reader["Name"].ToString(),
                  StockAmount=Convert.ToInt32(reader["StockAmount"]),
                  UnitPrice=Convert.ToDecimal(reader["UnitPrice"]),
                };  
                products.Add(product);
            }
            
            reader.Close(); 
            _connection.Close();
            return products ;
        }
        
         public void Add(Product product)
         {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@Name,@UnitPrice,@StockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
         }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name=@Name,UnitPrice=@UnitPrice,StockAmount=@StockAmount where Id=@Id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public List<Product> Search(string name)
        {
            ConnectionControl();
            var command=new SqlCommand("Select *from Products where(Name LIKE '%' + @Name + '%')  ", _connection);
            command.Parameters.AddWithValue("@name", name);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }
        public void Delete(int id)
        {
            ConnectionControl();
            var command = new SqlCommand($"Delete from Products where Id={id}", _connection);
            command.ExecuteNonQuery();
            _connection.Close();
            
                
             
        }
    }

}

    

