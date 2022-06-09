using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using WA.Data.Entities;

namespace WA.ProjectLocationConsole.Helpers
{
    public static class BulkInsert
    {
        public static async Task<bool> WriteToServerAsync(RawProjectLocation rawLocation, string connString)
        {
            if (string.IsNullOrEmpty(connString))
                throw new ArgumentNullException(nameof(connString));

            using (var copy = new SqlBulkCopy(connString))
            {
                copy.DestinationTableName = "dbo.ProjectLocations";

                copy.ColumnMappings.Add("Id", "Id");
                copy.ColumnMappings.Add("Name", "Name");
                copy.ColumnMappings.Add("Location", "Location");

                await copy.WriteToServerAsync(await BulkInsert.CopyToTable(rawLocation));
            }

            return true;
        }
    
        public static async Task<DataTable> CopyToTable(RawProjectLocation projectLocation)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Location");

            await Task.Run(() =>
            {
                foreach (var p in projectLocation.Data)
                {
                    DataRow row = dt.NewRow();
                    row["Id"] = p.Id;
                    row["Name"] = p.Name;
                    row["Location"] = p.Location;

                    dt.Rows.Add(row);
                }
            });
            return dt;
        }
    }
}
