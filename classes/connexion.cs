using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class connexion
    {
        SqlConnection con;
        public SqlConnection DBConnect()
        {
            try
            {
                string strConnectionString = "Data Source=DESKTOP-JEKPT9T;Initial Catalog=db_gestion_vente_pharmacie;Integrated Security=True";
                con = new SqlConnection(strConnectionString);
                con.Open();

                return con;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }
    }
}
