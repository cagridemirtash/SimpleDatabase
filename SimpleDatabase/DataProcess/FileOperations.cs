using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDatabase.DataProcess
{
    public class FileOperations
    {
        public void AddTable(List<string> table)
        {
            string path = @"C:\projects\sharp\SimpleDatabase\table.bin";
            File.Create(path).Close();
            string tableName = Convert.ToString(table[0]);
            fileWrite(path, tableName);
            
            for (int i = 1; i < table.Count; i++)
            {
                fileWrite(path, table[i]);
            }

        }
        public void addValue(List<string> list)
        {
            string path = @"C:\projects\sharp\SimpleDatabase\value.bin";
            
            for (int i = 0; i < list.Count; i++)
            {
                
 
                    fileWrite(path, list[i]);
               

            }
        }
        public void addIndex(Object obj,int index)
        {
            string path = @"C:\projects\sharp\SimpleDatabase\index.bin";
            fileWrite(path, (string)obj);
            fileWrite(path, index.ToString());
        }
        public List<string> getTable()
        {
            List<string> list = new List<string>();

            string line = "";
            string path = @"C:\projects\sharp\SimpleDatabase\table.bin";
            BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open));

            try
            {
                while ((line = binaryReader.ReadString()) != null)
                {
                    list.Add(line);
                }
                binaryReader.Close();
            }
            catch (Exception e)
            {

            }
            return list;
        }
        public List<string> getAll()
        {
            string line = "";
            string path = @"C:\projects\sharp\SimpleDatabase\value.bin";
            BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open));
            
            List<string> list = new List<string>();
            try
            {
                while ((line = binaryReader.ReadString()) != null)
                {
                    list.Add(line);
                }
                binaryReader.Close();
            }
            catch (Exception e)
            {

            }
            binaryReader.Close();
            return list;
        }
        public List<string> getByPK(string PK)
        {
            List<string> column = new List<string>();
            List<string> list = new List<string>();

            list = getAll();

            for (int i = 3; i < list.Count; i+=4)
            {
                
                if (list[i] == "True" && list[i-2] == PK)
                {
                    column.Add(list[i - 3]);
                    column.Add(list[i - 2]);
                    column.Add((i - 3).ToString());
                }
            }

            return column;
        }
        public void updateData(List<string> list)
        {
            
            List<string> columns = new List<string>();
            
            columns = getAll();
            fileClear(@"C:\projects\sharp\SimpleDatabase\value.bin");
            int i = 0;
            while (i < columns.Count)
            {
                List<string> colList = new List<string>();
                if (i != Convert.ToInt32(list[4]))
                {
                    colList.Add(columns[i]);
                    colList.Add(columns[i+1]);
                    colList.Add(columns[i+2]);
                    colList.Add(columns[i+3]);
                    addValue(colList);
                }
                else
                {
                    colList.Add(list[0]);
                    colList.Add(list[1]);
                    colList.Add(list[2]);
                    colList.Add(list[3]);
                    addValue(colList);
                }
                
                i+=4;
            }


        }
        public void deleteData(List<string> list)
        {
            List<string> columns = new List<string>();

            columns = getAll();
            fileClear(@"C:\projects\sharp\SimpleDatabase\value.bin");
            int i = 0;
            while (i < columns.Count)
            {
                List<string> colList = new List<string>();
                if (i != Convert.ToInt32(list[4]))
                {
                    colList.Add(columns[i]);
                    colList.Add(columns[i + 1]);
                    colList.Add(columns[i + 2]);
                    colList.Add(columns[i + 3]);
                    addValue(colList);
                }

                i += 4;
            }
        }
        public void fileClear(string path)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(path, FileMode.Open)))
            {
                binaryWriter.Write("");
            };
        }
        public void fileWrite(string path, Object obj)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(path, FileMode.Append)))
            {
                binaryWriter.Write(obj.ToString());
            };
        }
        public string fileRead(string path)
        {
            string line = "";
            BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open));
            line = binaryReader.ReadString();
            return line;
        }
    }
}
