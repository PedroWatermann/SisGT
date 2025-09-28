using SisGT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace SisGT.Controllers
{
    internal class TaskController
    {
        private readonly string DataPath = Environment.CurrentDirectory + "/data.txt";
        public List<TaskModel> Tasks { get; set; }

        internal bool Create(TaskModel task)
        {
            try
            {
                Read();

                StreamWriter dataWriter = new StreamWriter(DataPath);

                if (Tasks.Count <= 0)
                {
                    task.Id = 1;
                    Tasks.Add(task);

                    dataWriter.Write(JsonSerializer.Serialize(Tasks));
                    dataWriter.Close();
                }
                else
                {
                    task.Id = Tasks.Last().Id + 1;
                    Tasks.Add(task);

                    dataWriter.Write(JsonSerializer.Serialize(Tasks));
                    dataWriter.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            return false;
        }

        internal void Read()
        {
            try
            {
                if (!File.Exists(DataPath)) File.Create(DataPath).Close();
                
                StreamReader dataReader = new StreamReader(DataPath);
                string tasks = dataReader.ReadToEnd().Trim();

                Tasks = !string.IsNullOrWhiteSpace(tasks) ? JsonSerializer.Deserialize<List<TaskModel>>(tasks) : new List<TaskModel>();
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        internal bool Update(TaskModel task, int id = 0)
        {
            try
            {
                Read();

                if (Tasks.Count > 0 && id != 0)
                {
                    int count = 0;
                    while (Tasks[count].Id != id || count < Tasks.Count) count++;

                    if (Tasks[count].Id == id)
                    {
                        Tasks[count].Title = task.Title;
                        Tasks[count].Description = task.Description;
                        Tasks[count].Status = task.Status;

                        StreamWriter dataWriter = new StreamWriter(DataPath);
                        dataWriter.Write(JsonSerializer.Serialize(Tasks));
                        dataWriter.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            return false;
        }

        internal bool Delete(int id)
        {
            try
            {
                Read();

                if (Tasks.Count > 0 && id != 0)
                {
                    int count = 0;
                    while (Tasks[count].Id != id || count < Tasks.Count) count++;

                    if (Tasks[count].Id == id)
                    {
                        Tasks.RemoveAt(count);

                        StreamWriter dataWriter = new StreamWriter(DataPath);
                        dataWriter.Write(JsonSerializer.Serialize(Tasks));
                        dataWriter.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            return false;
        }
    }
}
