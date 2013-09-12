using System.Data;
using System.Data.OleDb;

namespace Mailing
{
    class ExcelOLEDB
    {
        private OleDbConnection conn;

        public enum ExcelVersion {v2000, v2003, v2007};

        public ExcelOLEDB(string file, ExcelVersion version)
        {
            string sconn = string.Format(this.getConn(version), file);
            conn = new OleDbConnection(sconn);
        }

        private string getConn(ExcelVersion version)
        {
            string sconn;
            if (version == ExcelVersion.v2007)
            {
                sconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0 Xml;";
            }
            else
            {
                sconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0;";
            }
            return sconn;
        }

        private string getSheetName(int index)
        {
            string sheetName = null;

            conn.Open();

            DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            sheetName = dtSchema.Rows[index].Field<string>("TABLE_NAME");

            conn.Close();

            return sheetName;
        }

        public DataTable readExcel()
        {
            string sheetName = this.getSheetName(0);
            string sql = string.Format("select * from [{0}]",sheetName);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public DataTable readExcelColumn(string columName)
        {
            string sheetName = this.getSheetName(0);
            string sql = string.Format("select * from [{1}${0}:{0}]", columName, sheetName);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
