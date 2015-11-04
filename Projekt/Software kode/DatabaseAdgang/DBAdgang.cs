using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseAdgang
{
    public class DBAdgang
    {
        private SqlConnection conn;
        private const String DB = "F15ST2ITS2201404492";
        private DateTime dato;

        public DBAdgang()
        {
            conn = new SqlConnection("Data Source=webhotel10.iha.dk;Initial Catalog=" + DB + ";Persist Security Info=True;User ID=" + DB + ";Password=" + DB + "");        
        }

        public void gemData(string Forsøgsnavn, int AutogenereretNR, List<double> samplelist)
        {
            dato = DateTime.Now;
            double[] BLOBListe = samplelist.ToArray();
            byte[] BLOBListe2 = BLOBListe.SelectMany(value => BitConverter.GetBytes(value)).ToArray();
            Convert.ToString(dato);

            String query = "INSERT INTO BlodtryksData (Forsøgsnavn, AutogenereretNR, Datostempel, Blodtryksmåling) VALUES(@Forsøgsnavn, @AutogenereretNR, @Dato, @BLOBListe2)";
            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Forsøgsnavn", Forsøgsnavn);
            command.Parameters.AddWithValue("@AutogenereretNR", AutogenereretNR);
            command.Parameters.Add("@Dato", SqlDbType.DateTime).Value = dato;
            command.Parameters.Add("@MåleListe2", SqlDbType.Image).Value = BLOBListe2;
            command.ExecuteNonQuery();

            conn.Close();
        }
    }
}
