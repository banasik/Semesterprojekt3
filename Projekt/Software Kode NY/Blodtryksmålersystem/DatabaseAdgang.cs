using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DatabaseAdgang
    {
        private SqlConnection conn;
        private const String DB = "F15ST2ITS2201404492";
        private DateTime Datostempel;
        private int GemtId = 0;
        public DatabaseAdgang()
        {
            conn = new SqlConnection("Data Source=webhotel10.iha.dk;Initial Catalog=" + DB + ";Persist Security Info=True;User ID=" + DB + ";Password=" + DB + "");        
        }
            public int gemData(string Forsøgsnavn, List<double> Rådata)
        {
            Datostempel = DateTime.Now;
            double[] BLOBListe = Rådata.ToArray();
            byte[] BYTEliste = Rådata.SelectMany(value => BitConverter.GetBytes(value)).ToArray();

            String query = "INSERT INTO SEMPRJ3 (Forsøgsnavn, Datostempel, Blodtryksmåling) " +
                "Output Inserted.Id " +
                "VALUES(@Forsøgsnavn, @Dato, @MåleListe) ";
            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Forsøgsnavn", Forsøgsnavn);
            command.Parameters.Add("@Dato", SqlDbType.DateTime).Value = Datostempel;
            command.Parameters.Add("@MåleListe", SqlDbType.Image).Value = BYTEliste;
            GemtId = Convert.ToInt32(command.ExecuteScalar());

            conn.Close();
            return GemtId;
        }
    }
}