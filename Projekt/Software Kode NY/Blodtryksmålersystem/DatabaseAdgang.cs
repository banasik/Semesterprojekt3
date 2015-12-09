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


        IndhentDAQData indhentdata = new IndhentDAQData(); 
        public DatabaseAdgang()
        {
            conn = new SqlConnection("Data Source=webhotel10.iha.dk;Initial Catalog=" + DB + ";Persist Security Info=True;User ID=" + DB + ";Password=" + DB + "");        
        }

        public int gemData(string Forsøgsnavn, List<double> GennemsnitListe)
        {
            Datostempel = DateTime.Now;
            //double[] BLOBListe = samplelist.ToArray();
            double[] BLOBListe = GennemsnitListe.ToArray();
            byte[] BYTEliste = GennemsnitListe.SelectMany(value => BitConverter.GetBytes(value)).ToArray();
            //Convert.ToString(Datostempel);
            
            int GemtId = 0;

            String query = "INSERT INTO BlodtryksData (Forsøgsnavn, Datostempel, Blodtryksmåling) VALUES(@Forsøgsnavn, @Dato, @MåleListe);" +
                "SELECT CAST (SCOPE_IDENTITY() AS int)";
            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Forsøgsnavn", Forsøgsnavn);
            //command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.Add("@Dato", SqlDbType.DateTime).Value = Datostempel;
            command.Parameters.Add("@MåleListe", SqlDbType.Image).Value = BYTEliste;
            command.Parameters["@Id"].Value = GemtId;
            command.ExecuteNonQuery();

            conn.Close();

            return (int)GemtId;
        }
    }
}
