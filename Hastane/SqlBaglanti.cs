using System;
using Microsoft.Data.SqlClient;

namespace Hastane
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=Mahammad;Initial Catalog=Hastane;Persist Security Info=True;User ID=sa;Password=Gasimoff.2006;Trust Server Certificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
