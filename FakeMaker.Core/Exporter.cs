﻿using System.Data;

namespace FakeMaker.Core;

public static class Exporter
{
    public static void Export(Stream stream, DataTable dataTable)
    {
        if (dataTable.Columns.Count == 0)
            return;

        using var writer = new StreamWriter(stream, leaveOpen: true);

        var columnNames = dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName);
        var header = string.Join(',', columnNames);

        writer.Write(header);

        foreach (var dataRow in dataTable.Rows.Cast<DataRow>())
        {
            writer.WriteLine();
            
            var fields = dataRow.ItemArray.Select(i => i is null ? string.Empty : i.ToString());
            var row = string.Join(',', fields);

            writer.Write(row);
        }

        writer.Flush();
    }
}
